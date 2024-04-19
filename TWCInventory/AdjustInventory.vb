'Title:         Adjust Inventory
'Date:          1-14-15
'Author:        Terry Holmes

'Description:   This form is used to adjust the inventory

Option Strict On

Public Class AdjustInventory

    'Setting up global data sources
    Private TheAdjustInventoryDataSet As AdjustInventoryDataSet
    Private TheAdjustInventoryDataTier As TWInventoryDataTier
    Private WithEvents TheAdjustInventoryBindingSource As BindingSource

    Private TheWarehouseInventoryDataSet As WarehouseInventoryDataSet
    Private TheWarehouseInventoryDataTier As TWInventoryDataTier
    Private WithEvents TheWarehouseInventoryBindingSource As BindingSource


    'Setting data variables
    Private addingBoolean As Boolean = False
    Private editingBoolean As Boolean = False
    Private previousSelectedIndex As Integer

    'Creating Data Validation Objext
    Dim TheInputDataValidation As New InputDataValidation
    Dim mdatDate As Date = Date.Now
    Dim mstrLogDate As String

    Private Sub AdjustInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'This will ensure that the data bindings are clear
        RemoveCountDataBindings()
        RemoveInventoryDataBindings()
        SetWarehouseInventoryDataBindings()
        SetInventoryAdjustmentLogDataBindings()
        txtCountedWarehouseID.Text = CStr(Logon.mintPartsWarehouseID)
        SetInventoryControlsVisible(False)
        SetAdjustInventoryControlsVisible(False)
        btnUpdateInventory.Enabled = False
        Logon.mstrLastTransactionSummary = "LOADED ADJUST INVENTORY FORM"

    End Sub
    Private Sub SetAdjustInventoryControlsVisible(ByVal valueBoolean As Boolean)

        'this will set the controls visible
        txtAdjustInventoryEmployeeID.Visible = valueBoolean
        txtAdjustInventoryPartNumber.Visible = valueBoolean
        txtAdjustInventoryQuantity.Visible = valueBoolean
        txtAdjustInventoryReason.Visible = valueBoolean
        txtAdjustInventoryDate.Visible = valueBoolean
        txtAdjustInventoryWarehouseID.Visible = valueBoolean

    End Sub
    Private Sub SetInventoryControlsVisible(ByVal valueBoolean As Boolean)

        'This will determine if the controls are visible
        txtInventoryWarehouseID.Visible = valueBoolean
        txtInventoryPartNumber.Visible = valueBoolean
        txtInventoryQuantity.Visible = valueBoolean

    End Sub
    Private Sub SetInventoryAdjustmentLogDataBindings()

        'Try catch to load databindings
        Try

            TheAdjustInventoryDataTier = New TWInventoryDataTier
            TheAdjustInventoryDataSet = TheAdjustInventoryDataTier.GetAdjustInventoryInformation
            TheAdjustInventoryBindingSource = New BindingSource

            'Setting up the binding source
            With TheAdjustInventoryBindingSource
                .DataSource = TheAdjustInventoryDataSet
                .DataMember = "adjustinventory"
                .MoveFirst()
                .MoveLast()
            End With

            'Setting up the combo box
            With cboAdjustInventoryTransactionID
                .DataSource = TheAdjustInventoryBindingSource
                .DisplayMember = "TransactionID"
                .DataBindings.Add("text", TheAdjustInventoryBindingSource, "TransactionID", False, DataSourceUpdateMode.Never)
            End With

            'Setting up the rest of the controls
            txtAdjustInventoryEmployeeID.DataBindings.Add("text", TheAdjustInventoryBindingSource, "EmployeeID")
            txtAdjustInventoryPartNumber.DataBindings.Add("text", TheAdjustInventoryBindingSource, "PartNumber")
            txtAdjustInventoryQuantity.DataBindings.Add("text", TheAdjustInventoryBindingSource, "Quantity")
            txtAdjustInventoryReason.DataBindings.Add("text", TheAdjustInventoryBindingSource, "Reason")
            txtAdjustInventoryDate.DataBindings.Add("text", TheAdjustInventoryBindingSource, "Date")
            txtAdjustInventoryWarehouseID.DataBindings.Add("text", TheAdjustInventoryBindingSource, "WarehouseID")

        Catch ex As Exception

            'This message will display if the controls fail to load
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        'This will close the program
        CloseProgram.ShowDialog()

    End Sub

    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click

        'Display Main Menu
        LastTransaction.Show()
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub btnAdminMenu_Click(sender As Object, e As EventArgs) Handles btnAdminMenu.Click

        'This displays the Administrative Menu
        LastTransaction.Show()
        AdminMenu.Show()
        Me.Close()

    End Sub
    Private Sub RemoveCountDataBindings()

        'This will remove the data bindings for the count controls
        cboAdjustInventoryTransactionID.DataBindings.Clear()
        txtAdjustInventoryEmployeeID.DataBindings.Clear()
        txtAdjustInventoryPartNumber.DataBindings.Clear()
        txtAdjustInventoryQuantity.DataBindings.Clear()
        txtAdjustInventoryReason.DataBindings.Clear()

    End Sub
    Private Sub RemoveInventoryDataBindings()

        'This will clear the inventory data bindings
        cboPartID.DataBindings.Clear()
        txtInventoryWarehouseID.DataBindings.Clear()
        txtInventoryPartNumber.DataBindings.Clear()
        txtInventoryQuantity.DataBindings.Clear()

    End Sub
    Private Sub SetWarehouseInventoryDataBindings()

        'This will set the inventory data bindings
        Try

            'Setting the data up
            TheWarehouseInventoryDataTier = New TWInventoryDataTier
            TheWarehouseInventoryDataSet = TheWarehouseInventoryDataTier.GetWarehouseInventoryInformation
            TheWarehouseInventoryBindingSource = New BindingSource

            'Setting up the binding source
            With TheWarehouseInventoryBindingSource
                .DataSource = TheWarehouseInventoryDataSet
                .DataMember = "WarehouseInventory"
                .MoveFirst()
                .MoveLast()
            End With

            'Setting up the combo box
            With cboPartID
                .DataSource = TheWarehouseInventoryBindingSource
                .DisplayMember = "PartID"
                .DataBindings.Add("text", TheWarehouseInventoryBindingSource, "PartID", False, DataSourceUpdateMode.Never)
            End With

            'Setting the rest of the controls
            txtInventoryPartNumber.DataBindings.Add("text", TheWarehouseInventoryBindingSource, "PartNumber")
            txtInventoryQuantity.DataBindings.Add("text", TheWarehouseInventoryBindingSource, "QTYOnHand")
            txtInventoryWarehouseID.DataBindings.Add("text", TheWarehouseInventoryBindingSource, "WarehouseID")

        Catch ex As Exception

            'Message to user if there is a problem
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub btnCompareCount_Click(sender As Object, e As EventArgs) Handles btnCompareCount.Click

        'This will run to compare the count
        Dim strValueForValidation As String
        Dim blnFatalError As Boolean = False
        Dim blnItemNotFound As Boolean = True
        Dim intCounter As Integer
        Dim intNumberOfRecords As Integer
        Dim blnItemNeedsAdjustment As Boolean = False

        'Local variables for search
        Dim intWarehouseIDForSearch As Integer
        Dim intWarehouseIDFromTable As Integer
        Dim intQuantityForSearch As Integer
        Dim intQuantityFromTable As Integer
        Dim strPartNumberForSearch As String
        Dim strPartNumberFromTable As String
        Dim intSelectedIndex As Integer
        Dim strErrorMessage As String = ""
        Dim blnThereIsAProblem As Boolean = False

        'Beginning Data Validation
        strValueForValidation = txtCountedPartNumber.Text
        blnFatalError = TheInputDataValidation.VerifyTextData(strValueForValidation)
        If blnFatalError = True Then
            blnThereIsAProblem = True
            strErrorMessage = strErrorMessage + "Part Number was not Entered" + vbNewLine
        End If


        strValueForValidation = txtCountedQuantity.Text
        blnFatalError = TheInputDataValidation.VerifyIntegerData(strValueForValidation)
        If blnFatalError = True Then
            blnThereIsAProblem = True
            strErrorMessage = strErrorMessage + "The Quantity Counted is not an Integer" + vbNewLine
        Else
            blnFatalError = TheInputDataValidation.VerifyIntegerRange(strValueForValidation)
            If blnFatalError = True Then
                blnThereIsAProblem = True
                strErrorMessage = strErrorMessage + "The Quantity Counted is out of Range" + vbNewLine
            End If
        End If

        'Output to user if there is a problem
        If blnThereIsAProblem = True Then
            txtCountedPartNumber.Text = ""
            txtCountedQuantity.Text = ""
            MessageBox.Show(strErrorMessage, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'Making controls visible
        SetInventoryControlsVisible(True)

        'Perparing for search
        intNumberOfRecords = cboPartID.Items.Count - 1
        intWarehouseIDForSearch = CInt(txtCountedWarehouseID.Text)
        intQuantityForSearch = CInt(txtCountedQuantity.Text)
        strPartNumberForSearch = txtCountedPartNumber.Text

        'Performing Loop
        For intCounter = 0 To intNumberOfRecords

            'Incrementing the combo box
            cboPartID.SelectedIndex = intCounter

            'Getting information for if statements
            intWarehouseIDFromTable = CInt(txtInventoryWarehouseID.Text)
            intQuantityFromTable = CInt(txtInventoryQuantity.Text)
            strPartNumberFromTable = CStr(txtInventoryPartNumber.Text)

            'If statements to see if data meets the criteria
            If intWarehouseIDForSearch = intWarehouseIDFromTable Then
                If strPartNumberForSearch = strPartNumberFromTable Then
                    blnItemNotFound = False
                    intSelectedIndex = intCounter
                    If intQuantityForSearch <> intQuantityFromTable Then

                        blnItemNeedsAdjustment = True

                    End If

                End If
            End If

        Next

        'Letting the user know that the item was not found
        If blnItemNotFound = True Then
            txtCountedPartNumber.Text = ""
            txtCountedQuantity.Text = ""
            MessageBox.Show("Item Not Found", "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        cboPartID.SelectedIndex = intSelectedIndex

        If blnItemNeedsAdjustment = True Then
            CycleCountDiscrepancy.ShowDialog()
        ElseIf blnItemNeedsAdjustment = False Then
            MessageBox.Show("Cycle Count Matches Inventory", "Thank You", MessageBoxButtons.OK, MessageBoxIcon.Information)
            SetInventoryControlsVisible(False)
        End If
    End Sub
    Public Sub AdjustInventoryLevels()

        'enabling the update Inventory button
        btnUpdateInventory.Enabled = True
        SetAdjustInventoryControlsVisible(True)
        txtCountedQuantity.ReadOnly = True

        'Setting up controls for saving information
        With TheAdjustInventoryBindingSource
            .EndEdit()
            .AddNew()
        End With
        addingBoolean = True
        SetComboBoxBinding()
        cboAdjustInventoryTransactionID.Focus()
        If cboAdjustInventoryTransactionID.SelectedIndex <> -1 Then
            previousSelectedIndex = cboAdjustInventoryTransactionID.Items.Count - 1
        Else
            previousSelectedIndex = 0
        End If
        cboAdjustInventoryTransactionID.Visible = True
        CreateID.Show()
        cboAdjustInventoryTransactionID.Text = CStr(Logon.mintCreatedTransactionID)
        cboAdjustInventoryTransactionID.Visible = False
        txtAdjustInventoryEmployeeID.Text = CStr(Logon.mintWarehouseEmployeeID)
        txtAdjustInventoryPartNumber.Text = txtInventoryPartNumber.Text
        txtAdjustInventoryQuantity.Text = txtCountedQuantity.Text
        txtAdjustInventoryWarehouseID.Text = txtCountedWarehouseID.Text
        txtInventoryQuantity.Text = txtCountedQuantity.Text
        mstrLogDate = CStr(mdatDate)
        txtAdjustInventoryDate.Text = mstrLogDate
        btnUpdateInventory.Enabled = True
        EnableMenuButtonControls(False)

    End Sub
    Private Sub EnableMenuButtonControls(ByVal valueBoolean As Boolean)

        'the routine will enable navigation buttons
        btnCompareCount.Enabled = valueBoolean
        btnAdminMenu.Enabled = valueBoolean
        btnMainMenu.Enabled = valueBoolean
        btnClose.Enabled = valueBoolean

    End Sub

    Private Sub btnUpdateInventory_Click(sender As Object, e As EventArgs) Handles btnUpdateInventory.Click

        'This sub-routine updates the on hand inventory

        'Setting local variables
        Dim strValueForValidation As String
        Dim blnFatalError As Boolean = False

        'Performing Data Validation
        strValueForValidation = txtAdjustInventoryReason.Text
        blnFatalError = TheInputDataValidation.VerifyTextData(strValueForValidation)

        'Output to user if validation fails
        If blnFatalError = True Then
            MessageBox.Show("The Adjust Inventory Notes Were Not Entered", "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'Updating on hand inventory
        Try
            Logon.mstrLastTransactionSummary = "ADJUST INVENTORY FOR " + txtAdjustInventoryPartNumber.Text + " " + " FOR THE QUANTITY OF " + txtAdjustInventoryQuantity.Text + " ON DATE " + mstrLogDate
            TheAdjustInventoryBindingSource.EndEdit()
            TheAdjustInventoryDataTier.UpdateAdjustInventoryDB(TheAdjustInventoryDataSet)
            TheWarehouseInventoryBindingSource.EndEdit()
            TheWarehouseInventoryDataTier.UpdateWarehouseInventoryDB(TheWarehouseInventoryDataSet)
            addingBoolean = False
            editingBoolean = False
            SetComboBoxBinding()
            txtCountedQuantity.ReadOnly = False
            SetInventoryControlsVisible(False)
            SetAdjustInventoryControlsVisible(False)
            EnableMenuButtonControls(True)
            txtCountedPartNumber.Text = ""
            txtCountedQuantity.Text = ""
            btnUpdateInventory.Enabled = False

        Catch ex As Exception

            'Output if there is a failure
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub
    Private Sub SetComboBoxBinding()

        With cboAdjustInventoryTransactionID
            If (addingBoolean Or editingBoolean) Then
                .DataBindings!text.DataSourceUpdateMode = DataSourceUpdateMode.OnValidation
                .DropDownStyle = ComboBoxStyle.Simple
            Else
                .DataBindings!text.DataSourceUpdateMode = DataSourceUpdateMode.Never
                .DropDownStyle = ComboBoxStyle.DropDownList
            End If
        End With
    End Sub
End Class