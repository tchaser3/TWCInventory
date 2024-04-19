'Title:         Create Cycle Count Tickets
'Date:          2-17-15
'Author:        Terry Holmes

'Description:   This will create cycle count tickets

Option Strict On

Public Class CreateCycleCountTickets

    'Setting up global variables
    Private TheWarehouseInventoryDataSet As WarehouseInventoryDataSet
    Private TheWarehouseInventoryDataTier As TWInventoryDataTier
    Private WithEvents TheWarehouseInventoryBindingSource As BindingSource

    Private ThePartNumberDataSet As PartNumberDataSet
    Private ThePartNumberDataTier As PartsDataTier
    Private WithEvents ThePartNumberBindingSource As BindingSource

    Private TheCycleCountDataSet As CycleCountDataSet
    Private TheCycleCountDataTier As CycleCountDataTier
    Private WithEvents TheCycleCountBindingSource As BindingSource

    Private TheCycleCountTimesCountedDataSet As CycleCountTimesCountedDataSet
    Private TheCycleCountTimesCountedDataTier As CycleCountDataTier
    Private WithEvents TheCycleCountTimesCountedBindingSource As BindingSource

    'Setting up user defined classes
    Dim TheInputDataValidation As New InputDataValidation
    Dim TheKeywordSearch As KeyWordSearchClass
    Dim TheCheckTimeWarnerPartNumber As New CheckTimeWarnerPartNumber

    'Setting up part number table array
    Dim mstrPartNumberForSearch() As String
    Dim mintPartNumberCounter As Integer
    Dim mintPartNumberUpperLimit As Integer

    'Setting up Warehouse Inventory Table Array
    Dim mstrInventoryPartNumber() As String
    Dim mintInventoryCounter As Integer
    Dim mintInventoryUpperLimit As Integer

    'Setting up the cycle count array table
    Dim mstrCycleCountPartNumber() As String
    Dim mintCycleCountCounter As Integer
    Dim mintCycleCountUpperLimit As Integer

    Dim mintNewPrintCounter As Integer
    Dim LogDate As Date = Date.Now
    Dim mstrDate As String
    Dim mblnItemNotPresentInTable As Boolean

    Private addingBoolean As Boolean = False
    Private editingBoolean As Boolean = False

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        'This will close the program
        CloseProgram.ShowDialog()

    End Sub

    Private Sub btnAdminMenu_Click(sender As Object, e As EventArgs) Handles btnAdminMenu.Click

        'This will show the Admin Menu
        LastTransaction.Show()
        AdminMenu.Show()
        Me.Close()

    End Sub

    Private Sub CreateCycleCountTickets_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Setting local variables
        Dim intNumberOfRecords As Integer
        Dim intCounter As Integer
        Dim strPartNumberForValidation As String
        Dim blnPartFormatNotCorrect As Boolean = True

        Logon.mstrLastTransactionSummary = "LOADED CREATE CYCLE TICKETS"

        'Loading up the form
        Try

            'Setting up the the part number
            ThePartNumberDataTier = New PartsDataTier
            ThePartNumberDataSet = ThePartNumberDataTier.GetPartNumberInformation
            ThePartNumberBindingSource = New BindingSource

            'Setting up the binding source
            With ThePartNumberBindingSource
                .DataSource = ThePartNumberDataSet
                .DataMember = "partnumbers"
                .MoveFirst()
                .MoveLast()
            End With

            'Setting up the combo box
            With cboMainPartID
                .DataSource = ThePartNumberBindingSource
                .DisplayMember = "PartID"
                .DataBindings.Add("text", ThePartNumberBindingSource, "PartID", False, DataSourceUpdateMode.Never)
            End With

            'Setting up the next control
            txtTablePartNumber.DataBindings.Add("text", ThePartNumberBindingSource, "PartNumber")
            txtTablePartDescription.DataBindings.Add("text", ThePartNumberBindingSource, "Description")

            'Setting up for loop
            intNumberOfRecords = cboMainPartID.Items.Count - 1
            ReDim mstrPartNumberForSearch(intNumberOfRecords)
            mintPartNumberCounter = 0

            'Performing Loop
            For intCounter = 0 To intNumberOfRecords

                'Incrementing the combo box
                cboMainPartID.SelectedIndex = intCounter

                'Getting part number
                strPartNumberForValidation = txtTablePartNumber.Text

                'Calling class
                blnPartFormatNotCorrect = TheCheckTimeWarnerPartNumber.CheckPartNumber(strPartNumberForValidation)

                If blnPartFormatNotCorrect = False Then
                    mstrPartNumberForSearch(mintPartNumberCounter) = strPartNumberForValidation
                    mintPartNumberCounter += 1
                End If

            Next

            'Setting limits on the array
            mintPartNumberUpperLimit = mintPartNumberCounter - 1
            mintPartNumberCounter = 0

            'Setting the inventory controls
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

            'Binding the combo box
            With cboInventoryPartID
                .DataSource = TheWarehouseInventoryBindingSource
                .DisplayMember = "PartID"
                .DataBindings.Add("text", TheWarehouseInventoryBindingSource, "PartID", False, DataSourceUpdateMode.Never)
            End With

            'Binding the rest of the controls
            txtInventoryPartNumber.DataBindings.Add("text", TheWarehouseInventoryBindingSource, "PartNumber")

            'Setting up for the loop
            intNumberOfRecords = cboInventoryPartID.Items.Count - 1
            ReDim mstrInventoryPartNumber(intNumberOfRecords)
            mintInventoryCounter = 0
            blnPartFormatNotCorrect = True

            'Performing the loop
            For intCounter = 0 To intNumberOfRecords

                'incrementing the combo box
                cboInventoryPartID.SelectedIndex = intCounter

                'Getting part number for validation
                strPartNumberForValidation = txtInventoryPartNumber.Text

                'Calling the class
                blnPartFormatNotCorrect = TheCheckTimeWarnerPartNumber.CheckPartNumber(strPartNumberForValidation)

                If blnPartFormatNotCorrect = False Then
                    mstrInventoryPartNumber(mintInventoryCounter) = strPartNumberForValidation
                    mintInventoryCounter += 1
                End If

            Next

            'Setting up the limit
            mintInventoryUpperLimit = mintInventoryCounter - 1
            mintInventoryCounter = 0

            'binding the cycle count controls
            TheCycleCountDataTier = New CycleCountDataTier
            TheCycleCountDataSet = TheCycleCountDataTier.GetCycleCountInformation
            TheCycleCountBindingSource = New BindingSource

            TheCycleCountTimesCountedDataTier = New CycleCountDataTier
            TheCycleCountTimesCountedDataSet = TheCycleCountTimesCountedDataTier.GetCycleCountTimesCountedInformation
            TheCycleCountTimesCountedBindingSource = New BindingSource

            'Setting up the bindingsource
            With TheCycleCountBindingSource
                .DataSource = TheCycleCountDataSet
                .DataMember = "cyclecount"
                .MoveFirst()
                .MoveLast()
            End With

            With TheCycleCountTimesCountedBindingSource
                .DataSource = TheCycleCountTimesCountedDataSet
                .DataMember = "cyclecounttimescounted"
                .MoveFirst()
                .MoveLast()
            End With

            'Setting up the combo box
            With cboCycleCountTransactionID
                .DataSource = TheCycleCountBindingSource
                .DisplayMember = "TransactionID"
                .DataBindings.Add("text", TheCycleCountBindingSource, "TransactionID", False, DataSourceUpdateMode.Never)
            End With

            With cboTimesCountedTransactionID
                .DataSource = TheCycleCountTimesCountedBindingSource
                .DisplayMember = "TransactionID"
                .DataBindings.Add("text", TheCycleCountTimesCountedBindingSource, "TransactionID", False, DataSourceUpdateMode.Never)
            End With

            'Setting the rest of the controls
            txtCycleCountDate.DataBindings.Add("text", TheCycleCountBindingSource, "Date")
            txtCycleCountPartNumber.DataBindings.Add("text", TheCycleCountBindingSource, "PartNumber")
            txtCycleCountTimesCounted.DataBindings.Add("text", TheCycleCountBindingSource, "TimesCounted")
            txtStoredTimesCounted.DataBindings.Add("text", TheCycleCountTimesCountedBindingSource, "TimesCounted")

            'Setting up Cycle Count Array
            intNumberOfRecords = cboCycleCountTransactionID.Items.Count - 1
            mintCycleCountCounter = 0
            ReDim mstrCycleCountPartNumber(intNumberOfRecords)

            For intCounter = 0 To intNumberOfRecords

                'incrementing the combo box
                cboCycleCountTransactionID.SelectedIndex = intCounter

                'Getting part number for validation
                strPartNumberForValidation = txtCycleCountPartNumber.Text

                'Calling the class
                blnPartFormatNotCorrect = TheCheckTimeWarnerPartNumber.CheckPartNumber(strPartNumberForValidation)

                If blnPartFormatNotCorrect = False Then
                    mstrCycleCountPartNumber(mintCycleCountCounter) = strPartNumberForValidation
                    mintCycleCountCounter += 1
                End If

            Next

            If mintCycleCountCounter > 0 Then
                mintCycleCountUpperLimit = mintCycleCountCounter - 1
            Else
                mintCycleCountUpperLimit = 0
            End If

            'Setting the controls visible
            SetControlsVisible(False)

        Catch ex As Exception

            'Message to user if there is a failure
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub
    Private Sub SetControlsVisible(ByVal ValueBoolean As Boolean)

        'This will set the controls visible
        cboCycleCountTransactionID.Visible = ValueBoolean
        cboInventoryPartID.Visible = ValueBoolean
        cboMainPartID.Visible = ValueBoolean
        cboTimesCountedTransactionID.Visible = ValueBoolean
        txtCycleCountDate.Visible = ValueBoolean
        txtCycleCountPartNumber.Visible = ValueBoolean
        txtCycleCountTimesCounted.Visible = ValueBoolean
        txtInventoryPartNumber.Visible = ValueBoolean
        txtStoredTimesCounted.Visible = ValueBoolean
        txtTablePartDescription.Visible = ValueBoolean
        txtTablePartNumber.Visible = ValueBoolean

    End Sub

    Private Sub btnCreateTickets_Click(sender As Object, e As EventArgs) Handles btnCreateTickets.Click

        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
        End If

        'Setting up for multiple pages
        mintNewPrintCounter = 0
        mintCycleCountCounter = 0

        'Calling the print document
        PrintDocument1.Print()


    End Sub
    Private Function GetRandomPartNumber() As String

        Dim intRandom As New Random
        Dim intElementNumber As Integer
        Dim strPartNumberForSearch As String

        'Creating the Random Part Number Element
        intElementNumber = intRandom.Next(0, mintPartNumberUpperLimit)

        'Getting the part number
        strPartNumberForSearch = mstrPartNumberForSearch(intElementNumber)

        'Return to calling function
        Return strPartNumberForSearch

    End Function

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        'Setting up the local variables
        Dim blnNewPage As Boolean = False
        Dim intCycleCountTotal As Integer = 10
        Dim intCycleCountCounter As Integer
        Dim blnItemNotCorrect As Boolean

        'Setting up variables for the reports
        Dim PrintHeaderFont As New Font("Arial", 18, FontStyle.Bold)
        Dim PrintSubHeaderFont As New Font("Arial", 14, FontStyle.Bold)
        Dim PrintItemsFont As New Font("Arial", 10, FontStyle.Regular)
        Dim PrintX As Single = e.MarginBounds.Left
        Dim PrintY As Single = e.MarginBounds.Top
        Dim HeadingLineHeight As Single = PrintHeaderFont.GetHeight + 18
        Dim ItemLineHeight As Single = PrintItemsFont.GetHeight + 10

        'Getting the date
        mstrDate = CStr(LogDate)

        'Setting up for default position
        PrintY = 100

        'Setting up for the print header
        PrintX = 180
        e.Graphics.DrawString("Blue Jay Communications Cycle Count Tickets", PrintHeaderFont, Brushes.Black, PrintX, PrintY)
        PrintY = PrintY + HeadingLineHeight
        PrintY = PrintY + HeadingLineHeight

        'Setting up the headers
        PrintX = 50
        e.Graphics.DrawString("Part Number", PrintItemsFont, Brushes.Black, PrintX, PrintY)
        PrintX = 175
        e.Graphics.DrawString("Part Description", PrintItemsFont, Brushes.Black, PrintX, PrintY)
        PrintX = 475
        e.Graphics.DrawString("Location", PrintItemsFont, Brushes.Black, PrintX, PrintY)
        PrintX = 650
        e.Graphics.DrawString("Quantity Counted", PrintItemsFont, Brushes.Black, PrintX, PrintY)
        PrintY = PrintY + HeadingLineHeight

        intCycleCountCounter = 0

        SetControlsVisible(True)
        While intCycleCountCounter < 10

            blnItemNotCorrect = FindPartNumberToCount()

            If blnItemNotCorrect = False Then

                PrintX = 50
                e.Graphics.DrawString(txtTablePartNumber.Text, PrintItemsFont, Brushes.Black, PrintX, PrintY)
                PrintX = 175
                e.Graphics.DrawString(txtTablePartDescription.Text, PrintItemsFont, Brushes.Black, PrintX, PrintY)
                PrintX = 475
                e.Graphics.DrawString("  ", PrintItemsFont, Brushes.Black, PrintX, PrintY)
                PrintX = 650
                e.Graphics.DrawString("_____________", PrintItemsFont, Brushes.Black, PrintX, PrintY)
                PrintY = PrintY + HeadingLineHeight

                'Incrementing the counter
                intCycleCountCounter += 1

            End If
        End While

        Logon.mstrLastTransactionSummary = "CREATED CYCLE COUNT TICKETS"
        SetControlsVisible(False)

    End Sub
    Private Function FindPartNumberToCount() As Boolean

        'Setting local variables
        Dim blnItemNotCorrect As Boolean = True
        Dim blnItemNotInCycleCountTable As Boolean = True
        Dim blnCylceCountTimesCountedDoesNotMatch As Boolean = True
        Dim strPartNumberForSearch As String
        Dim strPartNumberFromInventoryTable As String
        Dim strPartNumberFromPartsTable As String
        Dim strPartNumberFromCycleCountTable As String
        Dim intPartCounter As Integer
        Dim intInventoryCounter As Integer
        Dim intCycleCountCounter As Integer
        Dim intCycleCountSelectedIndex As Integer
        Dim blnCycleCountNotUpdated As Boolean = True

        'Finding the part number within the parts table
        Dim intPartComboBoxCounter As Integer
        Dim intPartComboBoxNumberOfRecords As Integer
        Dim intPartComboboxSelectedIndex As Integer

        'Getting Random Number
        For intPartCounter = 0 To mintPartNumberUpperLimit

            'Getting Random Part Number
            strPartNumberForSearch = GetRandomPartNumber()

            'Checking Part Number in Inventory Table
            For intInventoryCounter = 0 To mintInventoryUpperLimit

                'Getting Part Number from Array
                strPartNumberFromInventoryTable = mstrInventoryPartNumber(intInventoryCounter)

                If strPartNumberForSearch = strPartNumberFromInventoryTable Then

                    'Setting Boolean Modifier
                    blnItemNotCorrect = False
                    intPartCounter = mintPartNumberUpperLimit

                End If

            Next

            'Item Was Found
            If blnItemNotCorrect = False Then

                'Setting the part controls
                intPartComboBoxNumberOfRecords = cboMainPartID.Items.Count - 1

                'Performing loop
                For intPartComboBoxCounter = 0 To intPartComboBoxNumberOfRecords

                    'Setting Combo box
                    cboMainPartID.SelectedIndex = intPartComboBoxCounter

                    'Getting part number
                    strPartNumberFromPartsTable = txtTablePartNumber.Text

                    If strPartNumberForSearch = strPartNumberFromPartsTable Then
                        intPartComboboxSelectedIndex = intPartComboBoxCounter
                    End If
                Next

                cboMainPartID.SelectedIndex = intPartComboboxSelectedIndex

                'Performing loop on cycle count table
                For intCycleCountCounter = 0 To mintCycleCountUpperLimit

                    'Getting part number from Cycle Count Table
                    strPartNumberFromCycleCountTable = mstrCycleCountPartNumber(intCycleCountCounter)

                    If strPartNumberForSearch = strPartNumberFromCycleCountTable Then
                        blnCylceCountTimesCountedDoesNotMatch = False
                        intCycleCountSelectedIndex = intCycleCountCounter
                    End If

                Next

                If blnCylceCountTimesCountedDoesNotMatch = True Then

                    'Calling Sub routine to update the file
                    blnCycleCountNotUpdated = FindandUpdateCycleCountTable(strPartNumberForSearch)

                    If blnCycleCountNotUpdated = True Then

                        If mblnItemNotPresentInTable = True Then

                            Try
                                'Setting the array
                                mintCycleCountUpperLimit += 1
                                ReDim mstrCycleCountPartNumber(mintCycleCountUpperLimit)
                                mintCycleCountCounter += 1
                                mstrCycleCountPartNumber(mintCycleCountUpperLimit) = strPartNumberForSearch

                                With TheCycleCountBindingSource
                                    .EndEdit()
                                    .AddNew()
                                End With

                                'Setting the variables
                                addingBoolean = True
                                SetComboBoxBindings()
                                CycleCountID.Show()
                                cboCycleCountTransactionID.Text = CStr(Logon.mintCreatedTransactionID)
                                txtCycleCountPartNumber.Text = strPartNumberForSearch
                                mstrDate = CStr(LogDate)
                                txtCycleCountDate.Text = mstrDate
                                txtCycleCountTimesCounted.Text = "1"
                                TheCycleCountBindingSource.EndEdit()
                                TheCycleCountDataTier.UpdateCycleCountDB(TheCycleCountDataSet)
                                addingBoolean = False
                                SetComboBoxBindings()

                            Catch ex As Exception
                                MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End Try

                        End If

                    End If

                End If

            End If
        Next

        Return blnItemNotCorrect

    End Function
    Private Sub SetComboBoxBindings()

        With cboCycleCountTransactionID

            If (addingBoolean Or editingBoolean) Then
                .DataBindings!text.DataSourceUpdateMode = DataSourceUpdateMode.OnValidation
                .DropDownStyle = ComboBoxStyle.Simple
            Else
                .DataBindings!text.DataSourceUpdateMode = DataSourceUpdateMode.Never
                .DropDownStyle = ComboBoxStyle.DropDownList
            End If

        End With

    End Sub
    Private Function FindandUpdateCycleCountTable(strPartNumberForSearch As String) As Boolean

        'Setting sub-routine internal variables
        Dim intCounter As Integer
        Dim intNumberOfRecords As Integer
        Dim intSelectedIndex As Integer
        Dim intTimesCountedFromTable As Integer
        Dim intTimesCountedForSearch As Integer
        Dim strPartNumberFromTable As String
        Dim blnItemNotUpdated As Boolean = True
        Dim blnTimesCountedMatches = False

        mblnItemNotPresentInTable = True

        For intCounter = 0 To mintCycleCountUpperLimit

            'Getting the part number
            strPartNumberFromTable = mstrCycleCountPartNumber(intCounter)

            If strPartNumberForSearch = strPartNumberFromTable Then
                blnItemNotUpdated = False
                mblnItemNotPresentInTable = False
            End If

        Next

        If blnItemNotUpdated = False Then

            'Setting and saving the information
            intNumberOfRecords = cboCycleCountTransactionID.Items.Count - 1

            'beginning loop
            For intCounter = 0 To intNumberOfRecords

                'incrementing the combo box
                cboCycleCountTransactionID.SelectedIndex = intCounter

                'Getting the part number
                strPartNumberFromTable = txtCycleCountPartNumber.Text

                If strPartNumberForSearch = strPartNumberFromTable Then
                    intSelectedIndex = intCounter
                End If
            Next

            'Setting the index
            cboCycleCountTransactionID.SelectedIndex = intSelectedIndex

            'Getting the times counted
            intTimesCountedForSearch = CInt(txtCycleCountTimesCounted.Text)

            intTimesCountedFromTable = CInt(txtStoredTimesCounted.Text)

            If intTimesCountedForSearch < intTimesCountedFromTable Then

                'Saving the update
                intTimesCountedForSearch += 1
                txtCycleCountTimesCounted.Text = CStr(intTimesCountedForSearch)

                'Saving the update
                Try

                    TheCycleCountBindingSource.EndEdit()
                    TheCycleCountDataTier.UpdateCycleCountDB(TheCycleCountDataSet)

                Catch ex As Exception

                    'Message to suer if there is a problem
                    MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End Try

            End If
        End If

        Return blnItemNotUpdated

    End Function
End Class