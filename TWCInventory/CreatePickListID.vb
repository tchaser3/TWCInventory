'Title:         Create Pick List ID
'Date:          3-16-15
'Author:        Terry Holmes

'Description:   This form is used to create a pick list id

Option Strict On

Public Class CreatePickListID

    'Setting up the global variables
    Private ThePickListIDDataSet As PickListIDDataSet
    Private ThePickListIDDataTier As PickListDataTier
    Private WithEvents ThePickListIDBindingSource As BindingSource

    Private addingBoolean As Boolean = False
    Private editingBoolean As Boolean = False
    Private previousSelectedIndex As Integer

    Private Sub CreatePickListID_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'This will load the form

        'Setting local variables
        Dim intNewTransactionID As Integer

        'Try Catch for exceptions
        Try

            ThePickListIDDataTier = New PickListDataTier
            ThePickListIDDataSet = ThePickListIDDataTier.GetPickListIDInformation
            ThePickListIDBindingSource = New BindingSource

            'Setting up the binding source
            With ThePickListIDBindingSource
                .DataSource = ThePickListIDDataSet
                .DataMember = "picklistid"
                .MoveFirst()
                .MoveLast()
            End With

            'Setting up the combo box
            With cboTransactionID
                .DataSource = ThePickListIDBindingSource
                .DisplayMember = "TransactionID"
                .DataBindings.Add("text", ThePickListIDBindingSource, "TransactionID", False, DataSourceUpdateMode.Never)
            End With

            'Setting up the remaining control
            txtPickListID.DataBindings.Add("text", ThePickListIDBindingSource, "PickListID")

            'Getting the id
            intNewTransactionID = CInt(txtPickListID.Text)

            'creating new id
            intNewTransactionID += 1

            'Placing ID in control
            txtPickListID.Text = CStr(intNewTransactionID)
            Logon.mintCreatedTransactionID = intNewTransactionID

            'saving the changed id
            ThePickListIDBindingSource.EndEdit()
            ThePickListIDDataTier.UpdatePickListIDDB(ThePickListIDDataSet)

            'closing the form
            Me.Close()

        Catch ex As Exception

            'Message to user
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub
End Class