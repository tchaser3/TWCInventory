'Title:         Create Pick List Transaction ID
'Date:          3-16-15
'Author:        Terry Holmes

'Description:   This form is used to create a Transaction ID

Option Strict On

Public Class CreatePickListTransactionID

    Private ThePickListTransactionIDDataSet As PickListTransactionIDDataSet
    Private ThePickListTransactionIDDataTier As PickListDataTier
    Private WithEvents ThePickListTransactionIDBindingSource As BindingSource

    Private addingBoolean As Boolean = False
    Private editingBoolean As Boolean = False
    Private previousSelectedIndex As Integer

    Private Sub CreatePickListTransactionID_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'This will load the form

        'Setting local variables
        Dim intNewTransactionID As Integer

        'Try Catch for exceptions
        Try

            ThePickListTransactionIDDataTier = New PickListDataTier
            ThePickListTransactionIDDataSet = ThePickListTransactionIDDataTier.GetPickListTransactionIDInformation
            ThePickListTransactionIDBindingSource = New BindingSource

            'Setting up the binding source
            With ThePickListTransactionIDBindingSource
                .DataSource = ThePickListTransactionIDDataSet
                .DataMember = "picklisttransactionid"
                .MoveFirst()
                .MoveLast()
            End With

            'Setting up the combo box
            With cboTransactionID
                .DataSource = ThePickListTransactionIDBindingSource
                .DisplayMember = "TransactionID"
                .DataBindings.Add("text", ThePickListTransactionIDBindingSource, "TransactionID", False, DataSourceUpdateMode.Never)
            End With

            'Setting up the remaining control
            txtCreatedTransactionID.DataBindings.Add("text", ThePickListTransactionIDBindingSource, "CreatedTransactionID")

            'Getting the id
            intNewTransactionID = CInt(txtCreatedTransactionID.Text)

            'creating new id
            intNewTransactionID += 1

            'Placing ID in control
            txtCreatedTransactionID.Text = CStr(intNewTransactionID)
            Logon.mintCreatedTransactionID = intNewTransactionID

            'saving the changed id
            ThePickListTransactionIDBindingSource.EndEdit()
            ThePickListTransactionIDDataTier.UpdatePickListTransactionIDDB(ThePickListTransactionIDDataSet)

            'closing the form
            Me.Close()

        Catch ex As Exception

            'Message to user
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub
End Class