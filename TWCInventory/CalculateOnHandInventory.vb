'Title:         Calculate On Hand Inventory
'Date:          12-4-14
'Author:        Terry Holmes

'Description:   This will calculate the on hand inventory

Option Strict On

Public Class CalculateOnHandInventory

    'Setting up the Data Global Variables
    Private TheInventoryDataSet As InventoryDataSet
    Private TheInventoryDataTier As TWInventoryDataTier
    Private WithEvents TheInventoryBindingSource As BindingSource

    Private TheReceivedPartsDataSet As ReceivedPartsDataSet
    Private TheReceivedPartsDataTier As TWInventoryDataTier
    Private WithEvents TheReceivedPartsBindingSource As BindingSource

    Private TheBOMPartsDataSet As BOMPartsDataSet
    Private TheBOMPartsDataTier As TWInventoryDataTier
    Private WithEvents TheBOMPartsBindingSource As BindingSource

    'Setting up variables
    Private editingBoolean As Boolean = False
    Private addingBoolean As Boolean = False
    Private previousSelectedIndex As Integer

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        'This will Close the Form
        CloseProgram.ShowDialog()

    End Sub

    Private Sub btnMainMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMainMenu.Click

        'This will show the main menu
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub CalculateOnHandInventory_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'This will load up the controls
        Try

            'Setting up the data variables
            TheInventoryDataTier = New TWInventoryDataTier
            TheInventoryDataSet = TheInventoryDataTier.GetInventoryInformation
            TheInventoryBindingSource = New BindingSource

            TheReceivedPartsDataTier = New TWInventoryDataTier
            TheReceivedPartsDataSet = TheReceivedPartsDataTier.GetReceivedPartsInformation
            TheReceivedPartsBindingSource = New BindingSource

            TheBOMPartsDataTier = New TWInventoryDataTier
            TheBOMPartsDataSet = TheBOMPartsDataTier.GetBOMPartsInformation
            TheBOMPartsBindingSource = New BindingSource

            'Setting up the binding source
            With TheBOMPartsBindingSource
                .DataSource = TheBOMPartsDataSet
                .DataMember = "BOMParts"
                .MoveFirst()
                .MoveLast()
            End With

            With TheReceivedPartsBindingSource
                .DataSource = TheReceivedPartsDataSet
                .DataMember = "ReceivedParts"
                .MoveFirst()
                .MoveLast()
            End With

            With TheInventoryBindingSource
                .DataSource = TheInventoryDataSet
                .DataMember = "Inventory"
                .MoveFirst()
                .MoveLast()
            End With

            'Setting up the combo boxes
            With cboIssuedTransactionID
                .DataSource = TheBOMPartsBindingSource
                .DisplayMember = "TransactionID"
                .DataBindings.Add("text", TheBOMPartsBindingSource, "TransactionID", False, DataSourceUpdateMode.Never)
            End With

            With cboReceivedTransactionID
                .DataSource = TheReceivedPartsBindingSource
                .DisplayMember = "TransactionID"
                .DataBindings.Add("text", TheReceivedPartsBindingSource, "TransactionID", False, DataSourceUpdateMode.Never)
            End With

            With cboPartID
                .DataSource = TheInventoryBindingSource
                .DisplayMember = "PartID"
                .DataBindings.Add("text", TheInventoryBindingSource, "PartID", False, DataSourceUpdateMode.Never)
            End With

            'Setting the rest of the controls
            txtIssuedPartNumber.DataBindings.Add("text", TheBOMPartsBindingSource, "PartNumber")
            txtIssuedQty.DataBindings.Add("text", TheBOMPartsBindingSource, "QTY")

            txtReceivedPartNumber.DataBindings.Add("text", TheReceivedPartsBindingSource, "PartNumber")
            txtReceivedQty.DataBindings.Add("text", TheReceivedPartsBindingSource, "QTY")

            txtPartNumber.DataBindings.Add("text", TheInventoryBindingSource, "PartNumber")
            txtPartDescription.DataBindings.Add("text", TheInventoryBindingSource, "PartDescription")
            txtQTYOnHand.DataBindings.Add("text", TheInventoryBindingSource, "QTYResponible")

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click

        Dim intWarehouseCounter As Integer
        Dim intWarehouseNumberOfRecords As Integer
        Dim intIssuedCounter As Integer
        Dim intIssuedNumberOfRecords As Integer
        Dim intReceivedCounter As Integer
        Dim intReceivedNumberOfRecords As Integer
        Dim intPartRecievedTotals As Integer = 0
        Dim intPartIssuedTotals As Integer = 0
        Dim intIssuedQTYFromTable As Integer
        Dim intReceivedQTYFromTable As Integer
        Dim intQtyOnHand As Integer
        Dim strPartNumberForSearch As String
        Dim strReceivedPartFromTable As String
        Dim strIssuedPartFromTable As String

        'Getting starting numbers
        intWarehouseNumberOfRecords = cboPartID.Items.Count - 1
        intReceivedNumberOfRecords = cboReceivedTransactionID.Items.Count - 1
        intIssuedNumberOfRecords = cboIssuedTransactionID.Items.Count - 1

        'Begining loop
        For intWarehouseCounter = 0 To intWarehouseNumberOfRecords

            'incrementing the combobox
            cboPartID.SelectedIndex = intWarehouseCounter
            intQtyOnHand = CInt(txtQTYOnHand.Text)
            strPartNumberForSearch = txtPartNumber.Text
            intPartIssuedTotals = 0
            intPartRecievedTotals = 0

            'Beginning Issued Loop
            For intIssuedCounter = 0 To intIssuedNumberOfRecords

                'incrementing the combo
                cboIssuedTransactionID.SelectedIndex = intIssuedCounter

                'Getting the part number
                strIssuedPartFromTable = txtIssuedPartNumber.Text

                'If statements to see if they work
                If strIssuedPartFromTable = strPartNumberForSearch Then
                    intIssuedQTYFromTable = CInt(txtIssuedQty.Text)
                    intPartIssuedTotals = intIssuedQTYFromTable + intPartIssuedTotals
                End If
            Next

            'Beginning loop for Recieved Parts
            For intReceivedCounter = 0 To intReceivedNumberOfRecords

                'incrementing the combo box
                cboReceivedTransactionID.SelectedIndex = intReceivedCounter

                'Getting the part number
                strReceivedPartFromTable = txtReceivedPartNumber.Text

                'If statements to see if the part numbers match
                If strPartNumberForSearch = strReceivedPartFromTable Then
                    intReceivedQTYFromTable = CInt(txtReceivedQty.Text)
                    intPartRecievedTotals = intPartRecievedTotals + intReceivedQTYFromTable
                End If
            Next

            'Doing Math to verify correct operation
            intQtyOnHand = intPartRecievedTotals - intPartIssuedTotals

            'Updating the datatable
            txtQTYOnHand.Text = CStr(intQtyOnHand)

            Try
                TheInventoryBindingSource.EndEdit()
                TheInventoryDataTier.UpdateInventoryDB(TheInventoryDataSet)

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        Next

    End Sub
End Class