'Title:         Create ID Form
'Date:          11-27-14
'Author:        Terry Holmes

'Description:   This form is used to create an id

Option Strict On

Public Class CreateID

    'Setting up the modular variables
    Private TheCreateIDDataSet As CreateIIDDataSet
    Private TheCreateIDDataTier As TWInventoryDataTier
    Private WithEvents TheCreateIDBindingSource As BindingSource

    Private addingBoolean As Boolean = False
    Private editingBoolean As Boolean = False
    Private previousSelectedIndex As Integer

    Private Sub SetComboBoxBinding()

        'This will set the combo box binding
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

    Private Sub CreateID_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Setting Local variables
        Dim intNumberOfRecords As Integer

        'Try Catch to catch exceptions
        Try

            'Setting the modular variables
            TheCreateIDDataTier = New TWInventoryDataTier
            TheCreateIDDataSet = TheCreateIDDataTier.GetCreateIDInformation
            TheCreateIDBindingSource = New BindingSource

            'Setting the BindingSource
            With TheCreateIDBindingSource
                .DataSource = TheCreateIDDataSet
                .DataMember = "CreateID"
                .MoveFirst()
                .MoveLast()
            End With

            'Setting up the combo box
            With cboTransactionID
                .DataSource = TheCreateIDBindingSource
                .DisplayMember = "TransactionID"
                .DataBindings.Add("text", TheCreateIDBindingSource, "TransactionID", False, DataSourceUpdateMode.Never)
            End With

            'Binding the rest of the controls
            txtCreatedID.DataBindings.Add("text", TheCreateIDBindingSource, "CreatedID")

            'Creating new id
            intNumberOfRecords = CInt(txtCreatedID.Text)
            intNumberOfRecords = intNumberOfRecords + 1

            'Placing the text
            Logon.mintCreatedTransactionID = intNumberOfRecords
            txtCreatedID.Text = CStr(intNumberOfRecords)

            'Saving update
            TheCreateIDBindingSource.EndEdit()
            TheCreateIDDataTier.UpdateCreateIDDB(TheCreateIDDataSet)

            cboTransactionID.DataBindings.Clear()
            txtCreatedID.DataBindings.Clear()

            Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class