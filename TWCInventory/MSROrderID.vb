'Title:         Create MSR Order ID
'Date:          1-21-15
'Author:        Terry Holmes

'Description:   This will create an order id for the MSR Order table

Option Strict On

Public Class MSROrderID

    Private TheMSROrderIDDataSet As MSROrderIDDataSet
    Private TheMSROrderIDDataTier As TWInventoryDataTier
    Private WithEvents TheMSROrderIDBindingSource As BindingSource

    Private Sub MSROrderID_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'This will load when the form is loaded

        'Setting up the local variables
        Dim intNewID As Integer

        Try
            TheMSROrderIDDataTier = New TWInventoryDataTier
            TheMSROrderIDDataSet = TheMSROrderIDDataTier.GetMSROrderIDInformation
            TheMSROrderIDBindingSource = New BindingSource

            'Setting up the binding source
            With TheMSROrderIDBindingSource
                .DataSource = TheMSROrderIDDataSet
                .DataMember = "msrorderid"
                .MoveFirst()
                .MoveLast()
            End With

            'Binding the combo box
            With cboTransactionID
                .DataSource = TheMSROrderIDBindingSource
                .DisplayMember = "TransactionID"
                .DataBindings.Add("text", TheMSROrderIDBindingSource, "TransactionID", False, DataSourceUpdateMode.Never)
            End With

            'Setting the other control
            txtCreatedID.DataBindings.Add("text", TheMSROrderIDBindingSource, "CreatedID")

            'Getting ID
            intNewID = CInt(txtCreatedID.Text)

            'creating new id
            intNewID = intNewID + 1

            'placing ID in correct control
            Logon.mintCreatedTransactionID = intNewID
            txtCreatedID.Text = CStr(intNewID)

            'saving information
            TheMSROrderIDBindingSource.EndEdit()
            TheMSROrderIDDataTier.UpdateMSROrderIDDB(TheMSROrderIDDataSet)

            'closes the form
            Me.Close()

        Catch ex As Exception

            'This will out a message to user if there is a problem
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub
End Class