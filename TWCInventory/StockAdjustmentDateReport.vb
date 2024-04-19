'Title:         Stock Adjustment Date Report
'Date:          11-19-15
'Author:        Terry Holmes

'Description:   This form is for Stock Adjustment

Option Strict On

Public Class StockAdjustmentDateReport

    'setting up the employee data variables
    Private TheEmployeesDataSet As employeesDataSet
    Private TheEmployeesDataTier As TWInventoryDataTier
    Private WithEvents TheEmployeesBindingSource As BindingSource

    'setting up the parts data variables
    Private ThePartNumberDataSet As PartNumberDataSet
    Private ThePartNumberDataTier As PartsDataTier
    Private WithEvents ThePartNumberBindingSource As BindingSource

    'setting up the inventory adjustment variables
    Private TheAdjustInventoryDataSet As AdjustInventoryDataSet
    Private TheAdjustInventoryDataTier As TWInventoryDataTier
    Private WithEvents TheAdjustInventoryBindingSource As BindingSource

    'setting up data structures
    Structure Employees
        Dim mintEmployeeID As Integer
        Dim mstrLastName As String
        Dim mstrFirstName As String
    End Structure

    Dim structEmployees() As Employees
    Dim mintEmployeeCounter As Integer
    Dim mintEmployeeUpperLimit As Integer

    Structure Parts
        Dim mintPartID As Integer
        Dim mstrPartNumber As String
        Dim mstrDescription As String
    End Structure

    Dim structParts() As Parts
    Dim mintPartCounter As Integer
    Dim mintPartUpperLimit As Integer

    Structure AdjustInventory
        Dim mintTransactionID As Integer
        Dim mstrPartNumber As String
        Dim mintQuantity As Integer
        Dim mstrReason As String
        Dim mintEmployeeID As Integer
        Dim mdatTransactionDate As Date
        Dim mintWarehouseID As Integer
    End Structure

    Dim structAdjustInventory() As AdjustInventory
    Dim mintAdjustCounter As Integer
    Dim mintAdjustUpperLimit As Integer

    'setting up the search results structure
    Structure SearchResults
        Dim mdatTransactionDate As Date
        Dim mstrPartNumber As String
        Dim mstrDescription As String
        Dim mintQuantity As Integer
        Dim mstrReason As String
        Dim mstrFirstName As String
        Dim mstrLastName As String
    End Structure

    Dim structSearchResults() As SearchResults
    Dim mintResultCounter As Integer
    Dim mintResultUpperLimit As Integer

    'setting up misc global variables
    Dim mstrErrorMessage As String
    Dim mintNewPrintCounter As Integer

    'setting up class variables
    Dim TheKeyWordSearch As New KeyWordSearchClass
    Dim TheInputDataValidation As New InputDataValidation
    Dim TheCheckTimeWarnerPartNumber As New CheckTimeWarnerPartNumber
    Dim TheDateSearchClass As New DateSearchClass

    Private Sub btnAdministrationMenu_Click(sender As Object, e As EventArgs) Handles btnAdministrationMenu.Click

        LastTransaction.Show()
        AdminMenu.Show()
        Me.Close()

    End Sub

    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click

        LastTransaction.Show()
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        CloseProgram.ShowDialog()
    End Sub

    Private Sub StockAdjustmentDateReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'this will load up the controls
        'setting local variables
        Dim blnFatalError As Boolean = False

        PleaseWait.Show()

        ClearDataBindings()
        blnFatalError = SetEmployeeDataBindings()
        If blnFatalError = False Then
            ClearDataBindings()
            blnFatalError = SetPartNumberDataBindings()
        End If
        If blnFatalError = False Then
            ClearDataBindings()
            blnFatalError = SetAdjustmentDataBindings()
        End If

        CreateDataGrid()
        PleaseWait.Close()

        If blnFatalError = True Then
            btnFindTransactions.Enabled = False
            btnRunReport.Enabled = False
            MessageBox.Show(mstrErrorMessage, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub CreateDataGrid()

        'creating a grid
        dgvSearchResults.ColumnCount = 7
        dgvSearchResults.Columns(0).Name = "Date"
        dgvSearchResults.Columns(0).Width = 75
        dgvSearchResults.Columns(1).Name = "Part Number"
        dgvSearchResults.Columns(1).Width = 75
        dgvSearchResults.Columns(2).Name = "Description"
        dgvSearchResults.Columns(2).Width = 150
        dgvSearchResults.Columns(3).Name = "Quantity"
        dgvSearchResults.Columns(3).Width = 75
        dgvSearchResults.Columns(4).Name = "Explaination"
        dgvSearchResults.Columns(4).Width = 150
        dgvSearchResults.Columns(5).Name = "First Name"
        dgvSearchResults.Columns(5).Width = 100
        dgvSearchResults.Columns(6).Name = "Last Name"
        dgvSearchResults.Columns(6).Width = 100

    End Sub
    Private Function SetAdjustmentDataBindings() As Boolean

        'setting local variables
        Dim intCounter As Integer
        Dim intNumberOfRecords As Integer
        Dim intWarehouseIDForSearch As Integer
        Dim intWarehouseIDFromTable As Integer
        Dim blnFatalError As Boolean = False
        Dim blnNoItemsFound As Boolean = True

        'try catch for exceptions
        Try

            'setting the data variables
            TheAdjustInventoryDataTier = New TWInventoryDataTier
            TheAdjustInventoryDataSet = TheAdjustInventoryDataTier.GetAdjustInventoryInformation
            TheAdjustInventoryBindingSource = New BindingSource

            'setting up the binding source
            With TheAdjustInventoryBindingSource
                .DataSource = TheAdjustInventoryDataSet
                .DataMember = "adjustinventory"
                .MoveFirst()
                .MoveLast()
            End With

            'setting up the combo box
            With cboAdjustTransactionID
                .DataSource = TheAdjustInventoryBindingSource
                .DisplayMember = "TransactionID"
                .DataBindings.Add("text", TheAdjustInventoryBindingSource, "TransactionID", False, DataSourceUpdateMode.Never)
            End With

            'setting up the rest of the controls
            txtAdjustDate.DataBindings.Add("text", TheAdjustInventoryBindingSource, "Date")
            txtAdjustEmployeeID.DataBindings.Add("text", TheAdjustInventoryBindingSource, "EmployeeID")
            txtAdjustPartNumber.DataBindings.Add("text", TheAdjustInventoryBindingSource, "PartNumber")
            txtAdjustQuantity.DataBindings.Add("Text", TheAdjustInventoryBindingSource, "Quantity")
            txtAdjustReason.DataBindings.Add("text", TheAdjustInventoryBindingSource, "Reason")
            txtAdjustWarehouseID.DataBindings.Add("text", TheAdjustInventoryBindingSource, "WarehouseID")

            'setting up for the loop
            intNumberOfRecords = cboAdjustTransactionID.Items.Count - 1
            ReDim structAdjustInventory(intNumberOfRecords)
            ReDim structSearchResults(intNumberOfRecords)
            mintAdjustCounter = 0
            intWarehouseIDForSearch = CInt(Logon.mintPartsWarehouseID)

            'beginning loop
            For intCounter = 0 To intNumberOfRecords

                'incrementing the combo box
                cboAdjustTransactionID.SelectedIndex = intCounter

                'getting the warehouse id for the transaction
                intWarehouseIDFromTable = CInt(txtAdjustWarehouseID.Text)

                If intWarehouseIDForSearch = intWarehouseIDFromTable Then

                    structAdjustInventory(mintAdjustCounter).mdatTransactionDate = CDate(txtAdjustDate.Text)
                    structAdjustInventory(mintAdjustCounter).mintEmployeeID = CInt(txtAdjustEmployeeID.Text)
                    structAdjustInventory(mintAdjustCounter).mintQuantity = CInt(txtAdjustQuantity.Text)
                    structAdjustInventory(mintAdjustCounter).mintTransactionID = CInt(cboAdjustTransactionID.Text)
                    structAdjustInventory(mintAdjustCounter).mintWarehouseID = CInt(txtAdjustWarehouseID.Text)
                    structAdjustInventory(mintAdjustCounter).mstrPartNumber = txtAdjustPartNumber.Text
                    structAdjustInventory(mintAdjustCounter).mstrReason = txtAdjustReason.Text
                    mintAdjustCounter += 1
                    blnNoItemsFound = False

                End If

            Next

            If blnNoItemsFound = True Then
                mstrErrorMessage = "There Were no Transactions for this Warehouse"
                blnFatalError = True
            ElseIf blnNoItemsFound = False Then
                mintAdjustUpperLimit = mintAdjustCounter - 1
                mintAdjustCounter = 0
            End If

            'returning message to user
            Return blnFatalError

        Catch ex As Exception

            mstrErrorMessage = ex.Message
            blnFatalError = True

            'returning message to user
            Return blnFatalError

        End Try

    End Function
    Private Function SetPartNumberDataBindings() As Boolean

        'setting local variables
        Dim intCounter As Integer
        Dim intNumberOfRecords As Integer
        Dim blnFatalError As Boolean
        Dim blnNotTimeWarnerPart As Boolean

        'try catch for exceptions
        Try

            ThePartNumberDataTier = New PartsDataTier
            ThePartNumberDataSet = ThePartNumberDataTier.GetPartNumberInformation
            ThePartNumberBindingSource = New BindingSource

            'setting up the binding source
            With ThePartNumberBindingSource
                .DataSource = ThePartNumberDataSet
                .DataMember = "partnumbers"
                .MoveFirst()
                .MoveLast()
            End With

            'setting up the combo box
            With cboPartID
                .DataSource = ThePartNumberBindingSource
                .DisplayMember = "PartID"
                .DataBindings.Add("Text", ThePartNumberBindingSource, "PartID", False, DataSourceUpdateMode.Never)
            End With

            'setting the rest of the controls
            txtPartNumber.DataBindings.Add("text", ThePartNumberBindingSource, "PartNumber")
            txtDescription.DataBindings.Add("text", ThePartNumberBindingSource, "Description")

            'getting ready for the loop
            intNumberOfRecords = cboPartID.Items.Count - 1
            ReDim structParts(intNumberOfRecords)
            mintPartCounter = 0

            'beginning loop
            For intCounter = 0 To intNumberOfRecords

                'incrementing the combo box
                cboPartID.SelectedIndex = intCounter

                'checking to see if this a TWC part number
                blnNotTimeWarnerPart = TheCheckTimeWarnerPartNumber.CheckPartNumber(txtPartNumber.Text)

                If blnNotTimeWarnerPart = False Then
                    structParts(mintPartCounter).mintPartID = CInt(cboPartID.Text)
                    structParts(mintPartCounter).mstrDescription = txtDescription.Text
                    structParts(mintPartCounter).mstrPartNumber = txtPartNumber.Text
                    mintPartCounter += 1

                End If
            Next

            mintPartUpperLimit = mintPartCounter - 1
            mintPartCounter = 0

            'returning message to user
            Return blnFatalError

        Catch ex As Exception

            mstrErrorMessage = ex.Message
            blnFatalError = True

            'returning message to user
            Return blnFatalError

        End Try

    End Function
    Private Function SetEmployeeDataBindings() As Boolean

        'setting up the local variables
        Dim intCounter As Integer
        Dim intNumberOfRecords As Integer
        Dim blnFatalError As Boolean

        'try catch for exceptions
        Try

            'setting up the global variables
            TheEmployeesDataTier = New TWInventoryDataTier
            TheEmployeesDataSet = TheEmployeesDataTier.GetEmployeesInformation
            TheEmployeesBindingSource = New BindingSource

            'Setting up the binding source
            With TheEmployeesBindingSource
                .DataSource = TheEmployeesDataSet
                .DataMember = "employees"
                .MoveFirst()
                .MoveLast()
            End With

            'setting up the combo box
            With cboPartID
                .DataSource = TheEmployeesBindingSource
                .DisplayMember = "EmployeeID"
                .DataBindings.Add("Text", TheEmployeesBindingSource, "EmployeeID", False, DataSourceUpdateMode.Never)
            End With

            'setting up the rest of the controls
            txtPartNumber.DataBindings.Add("text", TheEmployeesBindingSource, "FirstName")
            txtDescription.DataBindings.Add("text", TheEmployeesBindingSource, "LastName")

            'filling the structure
            intNumberOfRecords = cboPartID.Items.Count - 1
            ReDim structEmployees(intNumberOfRecords)
            mintEmployeeCounter = 0
            mintEmployeeUpperLimit = intNumberOfRecords

            'beginning loop
            For intCounter = 0 To intNumberOfRecords

                'incrementing the combo box
                cboPartID.SelectedIndex = intCounter
                structEmployees(intCounter).mintEmployeeID = CInt(cboPartID.Text)
                structEmployees(intCounter).mstrFirstName = txtPartNumber.Text
                structEmployees(intCounter).mstrLastName = txtDescription.Text

            Next

            'returning message to user
            Return blnFatalError

        Catch ex As Exception

            mstrErrorMessage = ex.Message
            blnFatalError = True

            'returning message to user
            Return blnFatalError

        End Try
    End Function
    Private Sub ClearDataBindings()

        'this will clear the data bindings
        cboAdjustTransactionID.DataBindings.Clear()
        cboPartID.DataBindings.Clear()
        txtAdjustDate.DataBindings.Clear()
        txtAdjustEmployeeID.DataBindings.Clear()
        txtAdjustPartNumber.DataBindings.Clear()
        txtAdjustQuantity.DataBindings.Clear()
        txtAdjustReason.DataBindings.Clear()
        txtAdjustQuantity.DataBindings.Clear()
        txtPartNumber.DataBindings.Clear()
        txtDescription.DataBindings.Clear()

    End Sub

    Private Sub btnFindTransactions_Click(sender As Object, e As EventArgs) Handles btnFindTransactions.Click

        'setting up local variables
        Dim strValueForValidation As String
        Dim blnFatalError As Boolean = False
        Dim blnThereIsAProblem As Boolean = False
        Dim strErrorMessage As String = ""
        Dim datStartingDate As Date
        Dim datEndingDate As Date
        Dim datTransactionDate As Date
        Dim intAdjustCounter As Integer
        Dim intPartCounter As Integer
        Dim intEmployeeCounter As Integer
        Dim strPartNumberForSearch As String
        Dim strPartNumberFromTable As String
        Dim intEmployeeIDForSearch As Integer
        Dim intEmployeeIDFromTable As Integer
        Dim blnNoItemsFound As Boolean = True

        'performing data validation
        strValueForValidation = txtStartDate.Text
        blnFatalError = TheInputDataValidation.VerifyStartingEndingDatesAsDates(strValueForValidation)
        If blnFatalError = True Then
            blnThereIsAProblem = True
            strErrorMessage = strErrorMessage + "The Starting Date is not a Date" + vbNewLine
        End If
        strValueForValidation = txtEndDate.Text
        blnFatalError = TheInputDataValidation.VerifyStartingEndingDatesAsDates(strValueForValidation)
        If blnFatalError = True Then
            blnThereIsAProblem = True
            strErrorMessage = strErrorMessage + "The Ending Date is not a Date" + vbNewLine
        End If
        If blnThereIsAProblem = True Then
            MessageBox.Show(strErrorMessage, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'setting the date
        datStartingDate = CDate(txtStartDate.Text)
        datStartingDate = TheDateSearchClass.RemoveTime(datStartingDate)
        datEndingDate = CDate(txtEndDate.Text)
        datEndingDate = TheDateSearchClass.RemoveTime(datEndingDate)
        mintResultCounter = 0

        While datStartingDate <= datEndingDate

            For intAdjustCounter = 0 To mintAdjustUpperLimit

                'getting the date and removing the imte
                datTransactionDate = TheDateSearchClass.RemoveTime(structAdjustInventory(intAdjustCounter).mdatTransactionDate)

                If datStartingDate = datTransactionDate Then

                    structSearchResults(mintResultCounter).mdatTransactionDate = datTransactionDate
                    structSearchResults(mintResultCounter).mstrPartNumber = structAdjustInventory(intAdjustCounter).mstrPartNumber
                    structSearchResults(mintResultCounter).mstrReason = structAdjustInventory(intAdjustCounter).mstrReason
                    structSearchResults(mintResultCounter).mintQuantity = structAdjustInventory(intAdjustCounter).mintQuantity
                    strPartNumberForSearch = structAdjustInventory(intAdjustCounter).mstrPartNumber
                    intEmployeeIDForSearch = structAdjustInventory(intAdjustCounter).mintEmployeeID

                    'searching the part number
                    For intPartCounter = 0 To mintPartUpperLimit

                        strPartNumberFromTable = structParts(intPartCounter).mstrPartNumber

                        If strPartNumberForSearch = strPartNumberFromTable Then
                            structSearchResults(mintResultCounter).mstrDescription = structParts(intPartCounter).mstrDescription
                            Exit For
                        End If
                    Next

                    'searching the employee id
                    For intEmployeeCounter = 0 To mintEmployeeUpperLimit

                        intEmployeeIDFromTable = structEmployees(intEmployeeCounter).mintEmployeeID

                        If intEmployeeIDForSearch = intEmployeeIDFromTable Then
                            structSearchResults(mintResultCounter).mstrFirstName = structEmployees(intEmployeeCounter).mstrFirstName
                            structSearchResults(mintResultCounter).mstrLastName = structEmployees(intEmployeeCounter).mstrLastName
                        End If
                    Next

                    mintResultCounter += 1
                    blnNoItemsFound = False

                End If

            Next

            datStartingDate = TheDateSearchClass.AddingDay(datStartingDate, 1)

        End While

        If blnNoItemsFound = True Then
            MessageBox.Show("No Items Were Found", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf blnNoItemsFound = False Then
            mintResultUpperLimit = mintResultCounter - 1
            mintResultCounter = 0
            FillGrid()
        End If

    End Sub
    Private Sub FillGrid()

        'setting local variables
        Dim intCounter As Integer
        Dim rows() As String

        'running loop
        For intCounter = 0 To mintResultUpperLimit

            rows = New String() {CStr(structSearchResults(intCounter).mdatTransactionDate), structSearchResults(intCounter).mstrPartNumber, structSearchResults(intCounter).mstrDescription, CStr(structSearchResults(intCounter).mintQuantity), structSearchResults(intCounter).mstrReason, structSearchResults(intCounter).mstrFirstName, structSearchResults(intCounter).mstrLastName}
            dgvSearchResults.Rows.Add(rows)
        Next

    End Sub
    Private Sub PrintDocument1_QueryPageSettings(sender As Object, e As Printing.QueryPageSettingsEventArgs) Handles PrintDocument1.QueryPageSettings

        'setting the document to landscape
        e.PageSettings.Landscape = True


    End Sub
    Private Sub btnRunReport_Click(sender As Object, e As EventArgs) Handles btnRunReport.Click

        'Setting up the print dialog
        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
        End If

        'Making an entry showing that the report has been run
        Logon.mstrLastTransactionSummary = "RAN PARTS RECEIVED FOR A PROJECT REPORT"

        'Setting up for multiple pages
        mintNewPrintCounter = 0

        'Calling the print document
        PrintDocument1.Print()

    End Sub
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        'Setting up the local variables
        Dim intCounter As Integer
        Dim intNumberOfRecords As Integer
        Dim intStartingPageCounter As Integer
        Dim blnNewPage As Boolean = False

        'Setting up variables for the reports
        Dim PrintHeaderFont As New Font("Arial", 18, FontStyle.Bold)
        Dim PrintSubHeaderFont As New Font("Arial", 14, FontStyle.Bold)
        Dim PrintItemsFont As New Font("Arial", 10, FontStyle.Regular)
        Dim PrintX As Single = e.MarginBounds.Left
        Dim PrintY As Single = e.MarginBounds.Top
        Dim HeadingLineHeight As Single = PrintHeaderFont.GetHeight + 18
        Dim ItemLineHeight As Single = PrintItemsFont.GetHeight + 10

        'Variables for reducing the part discription
        Dim intCharacterCount As Integer
        Dim intCharacterLimit As Integer = 30
        Dim chaCharacterDescription() As Char
        Dim intStringLength As Integer
        Dim strPartDescription As String = ""

        'Setting up for default position
        PrintY = 100

        'Setting up for the print header
        PrintX = 300
        e.Graphics.DrawString("Blue Jay Communications Inventory Report", PrintHeaderFont, Brushes.Black, PrintX, PrintY)
        PrintY = PrintY + HeadingLineHeight
        PrintX = 400
        e.Graphics.DrawString("Inventory Adjustment Transaction Report", PrintSubHeaderFont, Brushes.Black, PrintX, PrintY)
        PrintY = PrintY + HeadingLineHeight

        'Setting up the columns
        PrintX = 50
        e.Graphics.DrawString("Date", PrintItemsFont, Brushes.Black, PrintX, PrintY)
        PrintX = 150
        e.Graphics.DrawString("Part Number", PrintItemsFont, Brushes.Black, PrintX, PrintY)
        PrintX = 250
        e.Graphics.DrawString("Description", PrintItemsFont, Brushes.Black, PrintX, PrintY)
        PrintX = 475
        e.Graphics.DrawString("Quantity", PrintItemsFont, Brushes.Black, PrintX, PrintY)
        PrintX = 600
        e.Graphics.DrawString("Explaination", PrintItemsFont, Brushes.Black, PrintX, PrintY)
        PrintY = PrintY + HeadingLineHeight

        'Setting up for multiple pages
        intStartingPageCounter = mintNewPrintCounter
        intNumberOfRecords = mintResultUpperLimit

        For intCounter = intStartingPageCounter To mintResultUpperLimit


            PrintX = 50
            e.Graphics.DrawString(CStr(structSearchResults(intCounter).mdatTransactionDate), PrintItemsFont, Brushes.Black, PrintX, PrintY)
            PrintX = 150
            e.Graphics.DrawString(CStr(structSearchResults(intCounter).mstrPartNumber), PrintItemsFont, Brushes.Black, PrintX, PrintY)

            intStringLength = structSearchResults(intCounter).mstrDescription.Length

            If intStringLength > intCharacterLimit Then

                'Setting up for the loop
                chaCharacterDescription = structSearchResults(intCounter).mstrDescription.ToCharArray
                strPartDescription = ""

                'Performing the loop
                For intCharacterCount = 0 To intCharacterLimit

                    'loading up the string
                    strPartDescription = strPartDescription + CStr(chaCharacterDescription(intCharacterCount))

                Next
            Else
                strPartDescription = structSearchResults(intCharacterCount).mstrDescription.ToCharArray
            End If

            PrintX = 250
            e.Graphics.DrawString(strPartDescription, PrintItemsFont, Brushes.Black, PrintX, PrintY)
            PrintX = 475
            e.Graphics.DrawString(CStr(structSearchResults(intCounter).mintQuantity), PrintItemsFont, Brushes.Black, PrintX, PrintY)
            PrintX = 650
            e.Graphics.DrawString(CStr(structSearchResults(intCounter).mstrReason), PrintItemsFont, Brushes.Black, PrintX, PrintY)
            PrintY = PrintY + ItemLineHeight

            If PrintY > 750 Then
                If intStartingPageCounter = mintResultUpperLimit Then
                    e.HasMorePages = False
                Else
                    e.HasMorePages = True
                    blnNewPage = True
                End If
            End If

            If blnNewPage = True Then
                mintNewPrintCounter = intCounter + 1
                intCounter = mintResultUpperLimit
            End If
        Next
    End Sub
End Class