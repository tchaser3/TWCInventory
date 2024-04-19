'Title:         Create Pick List Transactions
'Date:          3-19-15
'Author:        Terry Holmes

'Description:   This creates the transactions for the pick list

Option Strict On

Public Class CreatePickListTransactions


    Dim TheInputDataValidation As New InputDataValidation
    Dim TheKeywordSearch As New KeyWordSearchClass
    Dim TheCheckTimeWarnerPartNumber As New CheckTimeWarnerPartNumber

    Private ThePickListTransactionsDataSet As PickListTransactionsDataSet
    Private ThePickListTransactionsDataTier As PickListDataTier
    Private WithEvents ThePickListTransactionsBindingSource As BindingSource

    'Setting up selected index array
    Dim mintSelectedIndex() As Integer
    Dim mintCounter As Integer
    Dim mintUpperLimit As Integer

    Private addingBoolean As Boolean = False
    Private editingBoolean As Boolean = False

    Private Sub SetComboBoxBinding()

        With cboTransactionID
            If (addingBoolean Or editingBoolean) Then
                .DataBindings!text.DataSourceUpdateMode = DataSourceUpdateMode.OnValidation
                .DropDownStyle = ComboBoxStyle.Simple
            Else
                .DataBindings!text.DataSourceUpdateMode = DataSourceUpdateMode.Never
                .DropDownStyle = ComboBoxStyle.DropDownList
            End If
        End With
    End Sub

    Private Sub CreatePickListTransactions_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'This will load the form 
        'try catch for exceptions
        Try

            'Setting up the data variables
            ThePickListTransactionsDataTier = New PickListDataTier
            ThePickListTransactionsDataSet = ThePickListTransactionsDataTier.GetPickListTransactionsInformation
            ThePickListTransactionsBindingSource = New BindingSource

            'setting up the binding source
            With ThePickListTransactionsBindingSource
                .DataSource = ThePickListTransactionsDataSet
                .DataMember = "picklisttransactions"
                .MoveFirst()
                .MoveLast()
            End With

            'Setting up the combo box
            With cboTransactionID
                .DataSource = ThePickListTransactionsBindingSource
                .DisplayMember = "TransactionID"
                .DataBindings.Add("text", ThePickListTransactionsBindingSource, "TransactionID")
            End With

            'binding the rest of the controls
            txtPartNumber.DataBindings.Add("text", ThePickListTransactionsBindingSource, "PartNumber")
            txtPickListID.DataBindings.Add("text", ThePickListTransactionsBindingSource, "PickListID")
            txtQuantity.DataBindings.Add("text", ThePickListTransactionsBindingSource, "Quantity")

            'Creating a new record
            With ThePickListTransactionsBindingSource
                .EndEdit()
                .AddNew()
            End With

            'Setting up to save the record
            addingBoolean = True
            SetComboBoxBinding()
            CreatePickListTransactionID.Show()
            cboTransactionID.Text = CStr(Logon.mintCreatedTransactionID)
            txtPartNumber.Text = Logon.mstrPartNumber
            txtQuantity.Text = CStr(Logon.mintQuantity)
            txtPickListID.Text = CStr(Logon.mintPickListID)

            'saving the transaction
            ThePickListTransactionsBindingSource.EndEdit()
            ThePickListTransactionsDataTier.UpdatePickListTransactionsDB(ThePickListTransactionsDataSet)
            addingBoolean = False
            editingBoolean = False
            SetComboBoxBinding()

            Logon.mbolFatalError = False

            Me.Close()

        Catch ex As Exception

            'Output to User
            Logon.mbolFatalError = True
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub
End Class