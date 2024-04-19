'Title:         Create Vendor Returns ID
'Date:          2-11-15
'Author:        Terry Holmes

'Description:   This form is used to create a new ID

Option Strict On

Public Class CreateVendorReturnsID

    'Setting global variables
    Private TheVendorReturnsIDDataSet As VendorReturnsIDDataSet
    Private TheVendorReturnsIDDataTier As TWInventoryDataTier
    Private WithEvents TheVendorReturnsIDBindingSource As BindingSource

    Private Sub CreateVendorReturnsID_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Local Variables
        Dim intNewID As Integer

        'Try Catch for exceptions
        Try

            'Setting data variables
            TheVendorReturnsIDDataTier = New TWInventoryDataTier
            TheVendorReturnsIDDataSet = TheVendorReturnsIDDataTier.GetVendorReturnsIDInformation
            TheVendorReturnsIDBindingSource = New BindingSource

            'Setting up the binding source
            With TheVendorReturnsIDBindingSource
                .DataSource = TheVendorReturnsIDDataSet
                .DataMember = "vendorreturnsid"
                .MoveFirst()
                .MoveLast()
            End With

            'Setting up the combo box
            With cboTransactionID
                .DataSource = TheVendorReturnsIDBindingSource
                .DisplayMember = "TransactionID"
                .DataBindings.Add("text", TheVendorReturnsIDBindingSource, "TransactionID", False, DataSourceUpdateMode.Never)
            End With

            'Setting the rest of the controls
            txtCreatedTransactionID.DataBindings.Add("text", TheVendorReturnsIDBindingSource, "CreatedTransactionID")

            'Creating the ID
            intNewID = CInt(txtCreatedTransactionID.Text)
            intNewID += 1
            txtCreatedTransactionID.Text = CStr(intNewID)
            Logon.mintCreatedTransactionID = intNewID

            'Saving Information
            TheVendorReturnsIDBindingSource.EndEdit()
            TheVendorReturnsIDDataTier.UpdateVendorReturnsIDDB(TheVendorReturnsIDDataSet)
            Me.Close()

        Catch ex As Exception

            'Message to user
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub
End Class