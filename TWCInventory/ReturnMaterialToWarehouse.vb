'Title:         Return Material to Warehouse
'Date:          2-18-15
'Author:        Terry Holmes

'Description:   This form is used to return items to the warehouse and make a record of it.

Option Strict On

Public Class ReturnMaterialToWarehouse

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

    'Setting up the rest of the classes
    Dim TheKeywordSearch As New KeyWordSearchClass
    Dim TheCheckTimeWarnerPartNumber As New CheckTimeWarnerPartNumber

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        'This will close the form
        CloseProgram.Show()

    End Sub

    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click

        'This will display the admin menu
        LastTransaction.Show()
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub btnAdministrationMenu_Click(sender As Object, e As EventArgs) Handles btnAdministrationMenu.Click

        'this will display the admin menu
        LastTransaction.Show()
        AdminMenu.Show()
        Me.Close()

    End Sub

    Private Sub ReturnMaterialToWarehouse_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Logon.mstrLastTransactionSummary = "OPENED RETURN MATERIAL FORM"
        SetInventoryAdjustmentLogDataBindings()
        SetWarehouseInventoryDataBindings()
        txtCountedWarehouseID.Text = CStr(Logon.mintPartsWarehouseID)
        SetInventoryControlsVisible(False)
        SetAdjustInventoryControlsVisible(False)

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
            txtAdjustInventoryWarehouseID.DataBindings.Add("Text", TheAdjustInventoryBindingSource, "WarehouseID")

        Catch ex As Exception

            'This message will display if the controls fail to load
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

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
    Public Sub AdjustInventoryLevels()

        'enabling the update Inventory button
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
        txtInventoryQuantity.Text = txtCountedQuantity.Text
        txtAdjustInventoryWarehouseID.Text = txtCountedWarehouseID.Text
        mstrLogDate = CStr(mdatDate)
        txtAdjustInventoryDate.Text = mstrLogDate
        txtAdjustInventoryReason.Text = "INVENTORY RETURNED TO WAREHOUSE"

    End Sub

    Private Sub btnReturnMaterial_Click(sender As Object, e As EventArgs) Handles btnReturnMaterial.Click

        'This form will adjust the on hand inventory and make a log entry that the there have been a change

        'Setting local variables
        Dim intCounter As Integer
        Dim intNumberOfRecords As Integer
        Dim intSelectedIndex As Integer
        Dim strPartNumberForSearch As String
        Dim strPartNumberFromTable As String
        Dim blnFatalError As Boolean = False
        Dim blnItemNotFound As Boolean = True
        Dim intWarehouseIDForSearch As Integer
        Dim intWarehouseIDFromTable As Integer
        Dim intQuantityReturned As Integer
        Dim intQuantityFromTable As Integer
        Dim strErrorMessage As String = ""
        Dim blnThereIsAProblem As Boolean = False

        'Beginning data validation
        strPartNumberForSearch = txtCountedQuantity.Text
        blnFatalError = TheInputDataValidation.VerifyIntegerData(strPartNumberForSearch)
        If blnFatalError = True Then
            blnThereIsAProblem = True
            strErrorMessage = strErrorMessage + "Quantity Entered is not an Integer" + vbNewLine
        Else
            blnFatalError = TheInputDataValidation.VerifyIntegerRange(strPartNumberForSearch)
            If blnFatalError = True Then
                blnThereIsAProblem = True
                strErrorMessage = strErrorMessage + "Quantity is out range" + vbNewLine
            End If
        End If

        strPartNumberForSearch = txtCountedPartNumber.Text
        blnFatalError = TheInputDataValidation.VerifyTextData(strPartNumberForSearch)
        If blnFatalError = True Then
            blnThereIsAProblem = True
            strErrorMessage = strErrorMessage + "The Part Number was not Entered" + vbNewLine
        End If

        'Output to user
        If blnThereIsAProblem = True Then
            MessageBox.Show(strErrorMessage, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCountedPartNumber.Text = ""
            txtCountedQuantity.Text = ""
            SetInventoryControlsVisible(False)
            SetAdjustInventoryControlsVisible(False)
            Exit Sub
        End If

        'Checking to see if the part number is a time warner part number
        blnFatalError = TheCheckTimeWarnerPartNumber.CheckPartNumber(strPartNumberForSearch)

        If blnFatalError = True Then
            MessageBox.Show("Value Entered Is Not a Time Warner Part", "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCountedPartNumber.Text = ""
            SetInventoryControlsVisible(False)
            SetAdjustInventoryControlsVisible(False)
            Exit Sub
        End If

        SetInventoryControlsVisible(True)
        SetAdjustInventoryControlsVisible(True)

        'Setting up for the loop
        intNumberOfRecords = cboPartID.Items.Count - 1
        intWarehouseIDForSearch = CInt(txtCountedWarehouseID.Text)

        'Beginning loop
        For intCounter = 0 To intNumberOfRecords

            'Incrementing the combo box
            cboPartID.SelectedIndex = intCounter

            'Getting Part Number
            strPartNumberFromTable = txtInventoryPartNumber.Text
            intWarehouseIDFromTable = CInt(txtInventoryWarehouseID.Text)

            If strPartNumberForSearch = strPartNumberFromTable And intWarehouseIDForSearch = intWarehouseIDFromTable Then

                'Setting variables
                intSelectedIndex = intCounter
                blnItemNotFound = False
            End If
        Next

        If blnItemNotFound = True Then
            txtCountedPartNumber.Text = ""
            txtCountedQuantity.Text = ""
            SetAdjustInventoryControlsVisible(False)
            SetInventoryControlsVisible(False)
            MessageBox.Show("Item Not Found", "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        cboPartID.SelectedIndex = intSelectedIndex

        'Doing Math
        intQuantityReturned = CInt(txtCountedQuantity.Text)
        intQuantityFromTable = CInt(txtInventoryQuantity.Text)
        intQuantityFromTable = intQuantityFromTable + intQuantityReturned
        txtInventoryQuantity.Text = CStr(intQuantityFromTable)
        Logon.mstrLastTransactionSummary = "RETURNED PART NUMBER " + txtInventoryPartNumber.Text + " WITH A QUANTITY OF " + txtInventoryQuantity.Text
        LastTransaction.Show()

        'Saving record
        Try
            TheWarehouseInventoryBindingSource.EndEdit()
            TheWarehouseInventoryDataTier.UpdateWarehouseInventoryDB(TheWarehouseInventoryDataSet)

            'Setting up to create new record
            AdjustInventoryLevels()

            'Saving information
            TheAdjustInventoryBindingSource.EndEdit()
            TheAdjustInventoryDataTier.UpdateAdjustInventoryDB(TheAdjustInventoryDataSet)
            addingBoolean = False
            editingBoolean = False
            SetComboBoxBinding()
            txtCountedQuantity.ReadOnly = False
            SetInventoryControlsVisible(False)
            SetAdjustInventoryControlsVisible(False)
            txtCountedPartNumber.Text = ""
            txtCountedQuantity.Text = ""

            MessageBox.Show("Material Has Been Returned", "Thank You", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class