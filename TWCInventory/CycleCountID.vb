'Title:         Cycle Count ID
'Date:          2-13-15
'Author:        Terry Holmes

'Description:   This form is used for creating a transaction ID for cycle counts

Public Class CycleCountID

    'Setting global variables
    Private TheCycleCountIDDataSet As CycleCountIDDataSet
    Private TheCycleCountIDDataTier As CycleCountDataTier
    Private WithEvents TheCycleCountIDBindingSource As BindingSource

    Private addingBoolean As Boolean = False
    Private editingBoolean As Boolean = False

    Private Sub CycleCountID_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Setting local variables
        Dim intNewID As Integer

        'Try Catch for exceptions
        Try

            'Setting the data variables
            TheCycleCountIDDataTier = New CycleCountDataTier
            TheCycleCountIDDataSet = TheCycleCountIDDataTier.GetCycleCountIDInformation
            TheCycleCountIDBindingSource = New BindingSource

            'Setting up the binding source
            With TheCycleCountIDBindingSource
                .DataSource = TheCycleCountIDDataSet
                .DataMember = "cyclecountid"
                .MoveFirst()
                .MoveFirst()
            End With

            'Binding the combo box
            With cboTransactionID
                .DataSource = TheCycleCountIDBindingSource
                .DisplayMember = "TransactionID"
                .DataBindings.Add("text", TheCycleCountIDBindingSource, "TransactionID", False, DataSourceUpdateMode.Never)
            End With

            'Setting the rest of the controls
            txtCreatedTransactionID.DataBindings.Add("text", TheCycleCountIDBindingSource, "CreatedTransactionID")

            'Getting the id
            intNewID = CInt(txtCreatedTransactionID.Text)
            intNewID += 1
            txtCreatedTransactionID.Text = CStr(intNewID)
            Logon.mintCreatedTransactionID = CInt(intNewID)

            'Saving the transaction id
            TheCycleCountIDBindingSource.EndEdit()
            TheCycleCountIDDataTier.UpdateCycleCountIDDB(TheCycleCountIDDataSet)
            Me.Close()

        Catch ex As Exception

            'Message for user and failure
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub
End Class