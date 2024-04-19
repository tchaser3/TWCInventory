'Title:         Vendor Returns
'Date:          2-11-15
'Author:        Terry Holmes

'Description:   This form is for material returning to vendor

Option Strict On

Public Class VendorReturns

    'Setting up the global variables
    Private TheVendorReturnsDataSet As VendorReturnsDataSet
    Private TheVendorReturnsDataTier As TWInventoryDataTier
    Private WithEvents TheVendorReturnsBindingSource As BindingSource

    Private TheWarehouseInventoryDataTier As TWInventoryDataTier
    Private TheWarehouseInventoryDataSet As WarehouseInventoryDataSet
    Private WithEvents TheWarehouseInventoryBindingSource As BindingSource

    Private TheInventoryDataSet As InventoryDataSet
    Private TheInventoryDataTier As TWInventoryDataTier
    Private WithEvents TheInventoryBindingSource As BindingSource

    'Calling class objects
    Dim TheInputDataValidation As New InputDataValidation
    Dim TheKeywordSearch As New KeyWordSearchClass

    'Setting variables
    Private addingBoolean As Boolean = False
    Private editingBoolean As Boolean = False
    Private previousSelectedIndex As Integer

    'Setting date variables
    Dim mdatLogDate As Date = Date.Now
    Dim mstrLogDate As String

    'Setting table type variables
    Dim mstrTableType As String

    Private Sub btnAdministrationMenu_Click(sender As Object, e As EventArgs) Handles btnAdministrationMenu.Click

        'This will Open the Adminstration Menu
        ClearInventoryControlDataBindings()
        ClearVendorControlDataBindins()
        LastTransaction.Show()
        AdminMenu.Show()
        Me.Close()

    End Sub

    Private Sub VendorReturns_Load(sender As Object, e As EventArgs) Handles Me.Load

        'This will launch when the program loads
        Logon.mstrLastTransactionSummary = "LOADED VENDOR RETURNS"
        LastTransaction.Show()

        'Try Catch for exceptions for Vendor Returns
        Try

            TheVendorReturnsDataTier = New TWInventoryDataTier
            TheVendorReturnsDataSet = TheVendorReturnsDataTier.GetVendorReturnsInformation
            TheVendorReturnsBindingSource = New BindingSource

            'Setting up the binding source
            With TheVendorReturnsBindingSource
                .DataSource = TheVendorReturnsDataSet
                .DataMember = "vendorreturns"
                .MoveFirst()
                .MoveLast()
            End With

            'Setting up the combo box
            With cboReturnTransactionID
                .DataSource = TheVendorReturnsBindingSource
                .DisplayMember = "TransactionID"
                .DataBindings.Add("text", TheVendorReturnsBindingSource, "TransactionID", False, DataSourceUpdateMode.Never)
            End With

            'Setting the rest of the controls
            txtReturnDate.DataBindings.Add("Text", TheVendorReturnsBindingSource, "Date")
            txtReturnEmployeeID.DataBindings.Add("text", TheVendorReturnsBindingSource, "EmployeeID")
            txtReturnPartNumber.DataBindings.Add("text", TheVendorReturnsBindingSource, "PartNumber")
            txtReturnQuantity.DataBindings.Add("text", TheVendorReturnsBindingSource, "Quantity")
            txtReturnWarehouseID.DataBindings.Add("text", TheVendorReturnsBindingSource, "WarehouseID")

            'Setting the form conditions
            SetControlsReadOnly(True)
            SetInventoryControlsVisible(False)

            'this will begin the process
            btnReturnMaterial.PerformClick()

        Catch ex As Exception

            'User Exception Message
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click

        'This will open the main menu
        ClearInventoryControlDataBindings()
        ClearVendorControlDataBindins()
        LastTransaction.Show()
        Form1.Show()
        Me.Close()

    End Sub
    Private Sub SetControlsReadOnly(ByVal ValueBoolean As Boolean)

        'This will set these two controls to read only
        txtReturnPartNumber.ReadOnly = ValueBoolean
        txtReturnQuantity.ReadOnly = ValueBoolean
        txtMoreReturns.ReadOnly = ValueBoolean

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        CloseProgram.ShowDialog()

    End Sub
    Private Sub SetInventoryControlsVisible(ByVal ValueBoolean As Boolean)

        'This will set the inventory controls visible
        cboInventoryPartID.Visible = ValueBoolean
        txtInventoryPartNumber.Visible = ValueBoolean
        txtInventoryQuantity.Visible = ValueBoolean
        txtInventoryWarehouseID.Visible = ValueBoolean

    End Sub
    Private Sub ClearInventoryControlDataBindings()

        'This will clear the inventory data bindings
        cboInventoryPartID.DataBindings.Clear()
        txtInventoryPartNumber.DataBindings.Clear()
        txtInventoryQuantity.DataBindings.Clear()
        txtInventoryWarehouseID.DataBindings.Clear()

    End Sub
    Private Sub ClearVendorControlDataBindins()

        'This will clear the databinding for the vendor controls
        cboReturnTransactionID.DataBindings.Clear()
        txtReturnDate.DataBindings.Clear()
        txtReturnEmployeeID.DataBindings.Clear()
        txtReturnPartNumber.DataBindings.Clear()
        txtReturnQuantity.DataBindings.Clear()
        txtReturnWarehouseID.DataBindings.Clear()

    End Sub
    Private Sub SetInventoryDataBindings()

        'This will set the data bindings for the Inventory Table

        'try catch for exceptions
        Try

            'Setting the data variables
            TheInventoryDataTier = New TWInventoryDataTier
            TheInventoryDataSet = TheInventoryDataTier.GetInventoryInformation
            TheInventoryBindingSource = New BindingSource

            'Setting the binding source
            With TheInventoryBindingSource
                .DataSource = TheInventoryDataSet
                .DataMember = "Inventory"
                .MoveFirst()
                .MoveLast()
            End With

            'Setting the combo box
            With cboInventoryPartID
                .DataSource = TheInventoryBindingSource
                .DisplayMember = "PartID"
                .DataBindings.Add("text", TheInventoryBindingSource, "PartID", False, DataSourceUpdateMode.Never)
            End With

            'Binding the rest of the controls
            txtInventoryPartNumber.DataBindings.Add("text", TheInventoryBindingSource, "PartNumber")
            txtInventoryQuantity.DataBindings.Add("text", TheInventoryBindingSource, "QTYResponible")
            txtInventoryWarehouseID.DataBindings.Add("text", TheInventoryBindingSource, "WarehouseID")

        Catch ex As Exception

            'Message to user
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub
    Private Sub SetWarehouseInventoryDataBindings()

        'This will set the data bindings for the Inventory Table

        'try catch for exceptions
        Try

            'Setting the data variables
            TheWarehouseInventoryDataTier = New TWInventoryDataTier
            TheWarehouseInventoryDataSet = TheWarehouseInventoryDataTier.GetWarehouseInventoryInformation
            TheWarehouseInventoryBindingSource = New BindingSource

            'Setting the binding source
            With TheWarehouseInventoryBindingSource
                .DataSource = TheWarehouseInventoryDataSet
                .DataMember = "WarehouseInventory"
                .MoveFirst()
                .MoveLast()
            End With

            'Setting the combo box
            With cboInventoryPartID
                .DataSource = TheWarehouseInventoryBindingSource
                .DisplayMember = "PartID"
                .DataBindings.Add("text", TheWarehouseInventoryBindingSource, "PartID", False, DataSourceUpdateMode.Never)
            End With

            'Binding the rest of the controls
            txtInventoryPartNumber.DataBindings.Add("text", TheWarehouseInventoryBindingSource, "PartNumber")
            txtInventoryQuantity.DataBindings.Add("text", TheWarehouseInventoryBindingSource, "QTYOnHand")
            txtInventoryWarehouseID.DataBindings.Add("text", TheWarehouseInventoryBindingSource, "WarehouseID")

        Catch ex As Exception

            'Message to user
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub btnReturnMaterial_Click(sender As Object, e As EventArgs) Handles btnReturnMaterial.Click

        'This will add a record
        'Setting local variables
        Dim strValueForValidation As String
        Dim blnFatalError As Boolean = False
        Dim blnThereIsAProblem As Boolean = False
        Dim strErrorMessage As String = ""
        Dim blnItemNotFound As Boolean = True
        Dim blnNoChangesMade As Boolean = True

        If btnReturnMaterial.Text = "Return Material" Then

            With TheVendorReturnsBindingSource
                .EndEdit()
                .AddNew()
            End With

            'Setting up the variables
            addingBoolean = True
            SetComboBoxBinding()
            SetControlsReadOnly(False)
            txtReturnWarehouseID.Text = CStr(Logon.mintPartsWarehouseID)
            txtReturnEmployeeID.Text = CStr(Logon.mintEmployeeID)
            CreateVendorReturnsID.Show()
            cboReturnTransactionID.Text = CStr(Logon.mintCreatedTransactionID)
            txtMoreReturns.Text = "YES"
            mstrLogDate = CStr(mdatLogDate)
            txtReturnDate.Text = mstrLogDate
            btnReturnMaterial.Text = "Save Transaction"
        Else

            'Beginning Data Validation
            strValueForValidation = txtReturnPartNumber.Text
            blnFatalError = TheInputDataValidation.VerifyTextData(strValueForValidation)
            If blnFatalError = True Then
                blnThereIsAProblem = True
                strErrorMessage = strErrorMessage + "The Part Number was not Entered" + vbNewLine
            End If

            strValueForValidation = txtReturnQuantity.Text
            blnFatalError = TheInputDataValidation.VerifyIntegerData(strValueForValidation)
            If blnFatalError = True Then
                blnThereIsAProblem = True
                strErrorMessage = strErrorMessage + "The Quantity is not an Integer" + vbNewLine
            End If

            strValueForValidation = txtMoreReturns.Text
            blnFatalError = TheInputDataValidation.VerifyYesNoData(strValueForValidation)
            If blnFatalError = True Then
                blnThereIsAProblem = True
                strErrorMessage = strErrorMessage + "The More Returns is not a Yes or No" + vbNewLine
            End If
        

            'message to user if validation fails
            If blnThereIsAProblem = True Then
                MessageBox.Show(strErrorMessage, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If


            'Setting up for function call
            SetInventoryControlsVisible(True)
            ClearInventoryControlDataBindings()
            SetInventoryDataBindings()
            mstrTableType = "INVENTORY"
            blnItemNotFound = FindAndUpdateTables()
            If blnItemNotFound = False Then
                blnNoChangesMade = False
            End If
            ClearInventoryControlDataBindings()
            SetWarehouseInventoryDataBindings()
            mstrTableType = "WAREHOUSEINVENTORY"
            blnItemNotFound = FindAndUpdateTables()
            If blnItemNotFound = False Then
                blnNoChangesMade = False
            End If

            'Output To User
            If blnNoChangesMade = True Then
                SetInventoryControlsVisible(False)
                MessageBox.Show("Part Number Not Found In Inventory", "Thank You", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            'Finishing up sub routine
            Try
                TheVendorReturnsBindingSource.EndEdit()
                TheVendorReturnsDataTier.UpdateVendorReturnsDB(TheVendorReturnsDataSet)
                addingBoolean = False
                editingBoolean = False
                SetComboBoxBinding()
                SetControlsReadOnly(True)
                SetInventoryControlsVisible(False)
                ClearInventoryControlDataBindings()
                btnReturnMaterial.Text = "Return Material"
                MessageBox.Show("Inventory Has Been Updated", "Thank You", MessageBoxButtons.OK, MessageBoxIcon.Information)
                If txtMoreReturns.Text = "YES" Then
                    btnReturnMaterial.PerformClick()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If

    End Sub
    Private Sub SetComboBoxBinding()
        With cboReturnTransactionID
            If (addingBoolean Or editingBoolean) Then
                .DataBindings!text.DataSourceUpdateMode = DataSourceUpdateMode.OnValidation
                .DropDownStyle = ComboBoxStyle.Simple
            Else
                .DataBindings!text.DataSourceUpdateMode = DataSourceUpdateMode.Never
                .DropDownStyle = ComboBoxStyle.DropDownList
            End If
        End With
    End Sub
    Private Function FindAndUpdateTables() As Boolean

        'Setting local variables
        Dim intCounter As Integer
        Dim intNumberOfRecords As Integer
        Dim intWarehouseIDForSearch As Integer
        Dim intWarehouseIDFromTable As Integer
        Dim strPartNumberForSearch As String
        Dim strPartNumberFromTable As String
        Dim blnItemNotFound As Boolean = True
        Dim intQuantityReturned As Integer
        Dim intQuantityInTable As Integer

        'Setting up for search
        intNumberOfRecords = cboInventoryPartID.Items.Count - 1
        strPartNumberForSearch = txtReturnPartNumber.Text
        intWarehouseIDForSearch = CInt(txtReturnWarehouseID.Text)
        intQuantityReturned = CInt(txtReturnQuantity.Text)

        'Running loop
        For intCounter = 0 To intNumberOfRecords

            'incrementing the combo box
            cboInventoryPartID.SelectedIndex = intCounter

            'loading the variables
            intWarehouseIDFromTable = CInt(txtInventoryWarehouseID.Text)
            strPartNumberFromTable = txtInventoryPartNumber.Text
            intQuantityInTable = CInt(txtInventoryQuantity.Text)

            'if statements to check for match
            If strPartNumberForSearch = strPartNumberFromTable Then
                If intWarehouseIDForSearch = intWarehouseIDFromTable Then

                    'Setting up the quantity for the table
                    intQuantityInTable = intQuantityInTable - intQuantityReturned
                    txtInventoryQuantity.Text = CStr(intQuantityInTable)
                    blnItemNotFound = False

                    Try

                        If mstrTableType = "INVENTORY" Then
                            TheInventoryBindingSource.EndEdit()
                            TheInventoryDataTier.UpdateInventoryDB(TheInventoryDataSet)
                        ElseIf mstrTableType = "WAREHOUSEINVENTORY" Then
                            TheWarehouseInventoryBindingSource.EndEdit()
                            TheWarehouseInventoryDataTier.UpdateWarehouseInventoryDB(TheWarehouseInventoryDataSet)
                        End If

                    Catch ex As Exception

                        'Message to user if fails
                        MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try

                End If
            End If

        Next

        Return blnItemNotFound

    End Function
End Class