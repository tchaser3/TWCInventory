'Title:         View Warehouse Inventory Form
'Date:          11-16-15
'Author:        Terry Holmes

'Description:   This form is used create a report.

Option Strict On

Public Class ViewWarehouseInventory

    'setting global variables
    Private TheWarehouseInventoryDataSet As WarehouseInventoryDataSet
    Private TheWarehouseInventoryDataTier As TWInventoryDataTier
    Private WithEvents TheWarehouseInventoryBindingSource As BindingSource

    Private TheInventoryDataSet As InventoryDataSet
    Private TheInventoryDataTier As TWInventoryDataTier
    Private WithEvents TheInventoryBindingSource As BindingSource

    Private ThePartNumberDataSet As PartNumberDataSet
    Private ThePartNumberDataTier As PartsDataTier
    Private WithEvents ThePartNumberBindingSource As BindingSource

    Structure PartNumbers
        Dim mintPartID As Integer
        Dim mstrPartNumber As String
        Dim mstrPartDescription As String
    End Structure

    Dim structPartNumbers() As PartNumbers
    Dim mintPartCounter As Integer
    Dim mintPartUpperLimit As Integer

    Structure Inventory
        Dim mintPartID As Integer
        Dim mstrPartNumber As String
        Dim mintWarehouseID As Integer
        Dim mintQuantity As Integer
    End Structure

    Structure SearchResults
        Dim mintPartID As Integer
        Dim mstrPartNumber As String
        Dim mstrPartDescription As String
        Dim mintQuantityOnHand As Integer
        Dim mintTWCQuantity As Integer
    End Structure

    Dim structTWInventory() As Inventory
    Dim mintTWCounter As Integer
    Dim mintTWUpperLimit As Integer

    Dim structWHSInventory() As Inventory
    Dim mintWHSCounter As Integer
    Dim mintWHSUpperLimit As Integer

    Dim structSearchResults() As SearchResults
    Dim mintResultCounter As Integer
    Dim mintResultUpperLimit As Integer

    Dim TheKeyWordSearchClass As New KeyWordSearchClass
    Dim TheCheckTimeWarnerPartNumber As New CheckTimeWarnerPartNumber
    Dim mstrErrorMessage As String
    Dim mintNewPrintCounter As Integer

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        CloseProgram.ShowDialog()
    End Sub

    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        LastTransaction.Show()
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub btnViewInventoryMenu_Click(sender As Object, e As EventArgs) Handles btnViewInventoryMenu.Click
        LastTransaction.Show()
        ViewInventory.Show()
        Me.Close()
    End Sub

    Private Sub ViewWarehouseInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'This will run as the form loads
        'Setting Local Variables
        Dim blnFatalError As Boolean = True

        PleaseWait.Show()
        Logon.mstrLastTransactionSummary = "Loaded the View Warehouse Inventory Form"

        'loading controls and structures
        ClearDataBindings()
        blnFatalError = SetPartNumberDataBindings()
        If blnFatalError = False Then
            ClearDataBindings()
            blnFatalError = SetWarehouseInventoryDataBindings()
        End If
        If blnFatalError = False Then
            ClearDataBindings()
            blnFatalError = SetTWInventoryDataBindings()
        End If

        'building the grid view
        dgvSearchResults.ColumnCount = 5
        dgvSearchResults.Columns(0).Name = "Part ID"
        dgvSearchResults.Columns(0).Width = 75
        dgvSearchResults.Columns(1).Name = "Part Number"
        dgvSearchResults.Columns(1).Width = 75
        dgvSearchResults.Columns(2).Name = "Description"
        dgvSearchResults.Columns(2).Width = 150
        dgvSearchResults.Columns(3).Name = "On Hand"
        dgvSearchResults.Columns(3).Width = 75
        dgvSearchResults.Columns(4).Name = "TWC Count"
        dgvSearchResults.Columns(4).Width = 75

        If blnFatalError = False Then
            FindInventory()
        End If

        If blnFatalError = True Then

            PleaseWait.Close()
            btnRunReport.Enabled = False
            MessageBox.Show(mstrErrorMessage, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

        PleaseWait.Close()

    End Sub
    Private Sub FindInventory()

        'setting local variables
        Dim intPartCounter As Integer
        Dim intWHSCounter As Integer
        Dim intTWCounter As Integer
        Dim strPartNumberForSearch As String
        Dim strPartNumberFromTable As String
        Dim blnNoPartsFound As Boolean
        Dim blnNoPartsForWarehouse As Boolean = True
        Dim intQuantityOnHand As Integer
        Dim intQuantityResponsible As Integer
        Dim intResultCounter As Integer = 0
        Dim rows() As String

        'getting ready for loop
        mintResultCounter = 0

        'beginning the part number loop
        For intPartCounter = 0 To mintPartUpperLimit

            'getting part number
            strPartNumberForSearch = structPartNumbers(intPartCounter).mstrPartNumber
            blnNoPartsFound = True
            intQuantityResponsible = 0
            intQuantityOnHand = 0

            'running loop on whs inventory table
            For intWHSCounter = 0 To mintWHSUpperLimit

                'getting part number
                strPartNumberFromTable = structWHSInventory(intWHSCounter).mstrPartNumber

                If strPartNumberForSearch = strPartNumberFromTable Then
                    blnNoPartsForWarehouse = False
                    blnNoPartsFound = False
                    intQuantityOnHand = intQuantityOnHand + structWHSInventory(intWHSCounter).mintQuantity
                End If

            Next
            For intTWCounter = 0 To mintTWUpperLimit

                'getting part number
                strPartNumberFromTable = structTWInventory(intTWCounter).mstrPartNumber

                If strPartNumberForSearch = strPartNumberFromTable Then
                    blnNoPartsForWarehouse = False
                    blnNoPartsFound = False
                    intQuantityResponsible = intQuantityResponsible + structTWInventory(intTWCounter).mintQuantity
                End If

            Next

            If blnNoPartsFound = False Then
                structSearchResults(mintResultCounter).mintPartID = structPartNumbers(intPartCounter).mintPartID
                structSearchResults(mintResultCounter).mstrPartNumber = structPartNumbers(intPartCounter).mstrPartNumber
                structSearchResults(mintResultCounter).mstrPartDescription = structPartNumbers(intPartCounter).mstrPartDescription
                structSearchResults(mintResultCounter).mintQuantityOnHand = intQuantityOnHand
                structSearchResults(mintResultCounter).mintTWCQuantity = intQuantityResponsible
                mintResultCounter += 1
            End If

        Next

        If blnNoPartsForWarehouse = True Then
            MessageBox.Show("No Parts Were Found", "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf blnNoPartsForWarehouse = False Then
            mintResultUpperLimit = mintResultCounter - 1
            mintResultCounter = 0

            'loading up grid view
            For intResultCounter = 0 To mintResultUpperLimit

                rows = New String() {CStr(structSearchResults(intResultCounter).mintPartID), structSearchResults(intResultCounter).mstrPartNumber, structSearchResults(intResultCounter).mstrPartDescription, CStr(structSearchResults(intResultCounter).mintQuantityOnHand), CStr(structSearchResults(intResultCounter).mintTWCQuantity)}
                dgvSearchResults.Rows.Add(rows)

            Next
        End If

    End Sub
    Private Function SetTWInventoryDataBindings() As Boolean

        'setting local variables
        Dim intCounter As Integer
        Dim intNumberOfRecords As Integer
        Dim blnFatalError As Boolean
        Dim intWarehouseIDForSearch As Integer
        Dim intWarehouseIDFromTable As Integer
        Dim blnNoTransactionsFound As Boolean = True

        'try catch for exceptions
        Try

            'setting the data variables
            TheInventoryDataTier = New TWInventoryDataTier
            TheInventoryDataSet = TheInventoryDataTier.GetInventoryInformation
            TheInventoryBindingSource = New BindingSource

            'setting up the binding source
            With TheInventoryBindingSource
                .DataSource = TheInventoryDataSet
                .DataMember = "Inventory"
                .MoveFirst()
                .MoveLast()
            End With

            'setting up the combo box
            With cboPartID
                .DataSource = TheInventoryBindingSource
                .DisplayMember = "PartID"
                .DataBindings.Add("Text", TheInventoryBindingSource, "PartID", False, DataSourceUpdateMode.Never)
            End With

            'setting up the rest of the controls
            txtPartNumber.DataBindings.Add("text", TheInventoryBindingSource, "PartNumber")
            txtQuantity.DataBindings.Add("Text", TheInventoryBindingSource, "QTYResponible")
            txtWarehouseID.DataBindings.Add("text", TheInventoryBindingSource, "WarehouseID")

            'getting ready to load the structure
            intNumberOfRecords = cboPartID.Items.Count - 1
            ReDim structTWInventory(intNumberOfRecords)
            mintTWCounter = 0
            intWarehouseIDForSearch = Logon.mintPartsWarehouseID

            'Beginning loop
            For intCounter = 0 To intNumberOfRecords

                'incrementing the combo box
                cboPartID.SelectedIndex = intCounter

                'Getting the warehouse id
                intWarehouseIDFromTable = CInt(txtWarehouseID.Text)

                If intWarehouseIDForSearch = intWarehouseIDFromTable Then

                    'loading structure
                    structTWInventory(mintTWCounter).mintPartID = CInt(cboPartID.Text)
                    structTWInventory(mintTWCounter).mintQuantity = CInt(txtQuantity.Text)
                    structTWInventory(mintTWCounter).mintWarehouseID = intWarehouseIDForSearch
                    structTWInventory(mintTWCounter).mstrPartNumber = txtPartNumber.Text
                    mintTWCounter += 1
                    blnNoTransactionsFound = False

                End If
            Next

            If blnNoTransactionsFound = True Then
                blnFatalError = True
                mstrErrorMessage = "No Parts For This Warehouse"
            ElseIf blnNoTransactionsFound = False Then
                mintTWUpperLimit = mintTWCounter - 1
                mintTWCounter = 0
            End If

            'returning to calling sub-routine
            Return blnFatalError

        Catch ex As Exception

            'message to user if there is a failure
            mstrErrorMessage = ex.Message
            blnFatalError = True
            Return blnFatalError

        End Try

    End Function
    Private Function SetWarehouseInventoryDataBindings() As Boolean

        'setting local variables
        Dim intCounter As Integer
        Dim intNumberOfRecords As Integer
        Dim blnFatalError As Boolean
        Dim intWarehouseIDForSearch As Integer
        Dim intWarehouseIDFromTable As Integer
        Dim blnNoTransactionsFound As Boolean = True

        'try catch for exceptions
        Try

            'setting the data variables
            TheWarehouseInventoryDataTier = New TWInventoryDataTier
            TheWarehouseInventoryDataSet = TheWarehouseInventoryDataTier.GetWarehouseInventoryInformation
            TheWarehouseInventoryBindingSource = New BindingSource

            'setting up the binding source
            With TheWarehouseInventoryBindingSource
                .DataSource = TheWarehouseInventoryDataSet
                .DataMember = "WarehouseInventory"
                .MoveFirst()
                .MoveLast()
            End With

            'setting up the combo box
            With cboPartID
                .DataSource = TheWarehouseInventoryBindingSource
                .DisplayMember = "PartID"
                .DataBindings.Add("Text", TheWarehouseInventoryBindingSource, "PartID", False, DataSourceUpdateMode.Never)
            End With

            'setting up the rest of the controls
            txtPartNumber.DataBindings.Add("text", TheWarehouseInventoryBindingSource, "PartNumber")
            txtQuantity.DataBindings.Add("Text", TheWarehouseInventoryBindingSource, "QTYOnHand")
            txtWarehouseID.DataBindings.Add("text", TheWarehouseInventoryBindingSource, "WarehouseID")

            'getting ready to load the structure
            intNumberOfRecords = cboPartID.Items.Count - 1
            ReDim structWHSInventory(intNumberOfRecords)
            mintWHSCounter = 0
            intWarehouseIDForSearch = Logon.mintPartsWarehouseID

            'Beginning loop
            For intCounter = 0 To intNumberOfRecords

                'incrementing the combo box
                cboPartID.SelectedIndex = intCounter

                'Getting the warehouse id
                intWarehouseIDFromTable = CInt(txtWarehouseID.Text)

                If intWarehouseIDForSearch = intWarehouseIDFromTable Then

                    'loading structure
                    structWHSInventory(mintWHSCounter).mintPartID = CInt(cboPartID.Text)
                    structWHSInventory(mintWHSCounter).mintQuantity = CInt(txtQuantity.Text)
                    structWHSInventory(mintWHSCounter).mintWarehouseID = intWarehouseIDForSearch
                    structWHSInventory(mintWHSCounter).mstrPartNumber = txtPartNumber.Text
                    mintWHSCounter += 1
                    blnNoTransactionsFound = False

                End If
            Next

            If blnNoTransactionsFound = True Then
                blnFatalError = True
                mstrErrorMessage = "No Parts For This Warehouse"
            ElseIf blnNoTransactionsFound = False Then
                mintWHSUpperLimit = mintWHSCounter - 1
                mintWHSCounter = 0
            End If

            'returning to calling sub-routine
            Return blnFatalError

        Catch ex As Exception

            'message to user if there is a failure
            mstrErrorMessage = ex.Message
            blnFatalError = True
            Return blnFatalError

        End Try

    End Function
    Private Function SetPartNumberDataBindings() As Boolean

        'setting local variables
        Dim intCounter As Integer
        Dim intNumberOfRecords As Integer
        Dim blnFatalError As Boolean = False
        Dim blnNotTimeWarnerPart As Boolean

        'try catch for exceptions
        Try

            'setting up the global part number
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
            End With

            'setting up the rest of the controls
            txtPartDescription.DataBindings.Add("Text", ThePartNumberBindingSource, "Description")
            txtPartNumber.DataBindings.Add("text", ThePartNumberBindingSource, "PartNumber")

            'setting up to fill the structure
            intNumberOfRecords = cboPartID.Items.Count - 1
            ReDim structPartNumbers(intNumberOfRecords)
            ReDim structSearchResults(intNumberOfRecords)
            mintPartCounter = 0

            'perfomring loop
            For intCounter = 0 To intNumberOfRecords

                cboPartID.SelectedIndex = intCounter

                blnNotTimeWarnerPart = TheCheckTimeWarnerPartNumber.CheckPartNumber(txtPartNumber.Text)

                If blnNotTimeWarnerPart = False Then

                    'loading up the structure
                    structPartNumbers(mintPartCounter).mintPartID = CInt(cboPartID.Text)
                    structPartNumbers(mintPartCounter).mstrPartDescription = txtPartDescription.Text
                    structPartNumbers(mintPartCounter).mstrPartNumber = txtPartNumber.Text
                    mintPartCounter += 1

                End If
            Next

            mintPartUpperLimit = mintPartCounter - 1
            mintPartCounter = 0

            'returning message to calling sub routine
            Return blnFatalError

        Catch ex As Exception

            'message to user if there is a failure
            mstrErrorMessage = ex.Message
            blnFatalError = True
            Return blnFatalError

        End Try

    End Function
    Private Sub ClearDataBindings()

        'this will clear the data bindings
        cboPartID.DataBindings.Clear()
        txtPartDescription.DataBindings.Clear()
        txtPartNumber.DataBindings.Clear()
        txtQuantity.DataBindings.Clear()
        txtWarehouseID.DataBindings.Clear()

    End Sub
    Private Sub PrintDocument1_QueryPageSettings(sender As Object, e As Printing.QueryPageSettingsEventArgs) Handles PrintDocument1.QueryPageSettings
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
        PrintY = PrintY + HeadingLineHeight

        'Setting up the columns
        PrintX = 50
        e.Graphics.DrawString("PartID", PrintItemsFont, Brushes.Black, PrintX, PrintY)
        PrintX = 150
        e.Graphics.DrawString("Part Number", PrintItemsFont, Brushes.Black, PrintX, PrintY)
        PrintX = 250
        e.Graphics.DrawString("Description", PrintItemsFont, Brushes.Black, PrintX, PrintY)
        PrintX = 700
        e.Graphics.DrawString("On Hand", PrintItemsFont, Brushes.Black, PrintX, PrintY)
        PrintX = 900
        e.Graphics.DrawString("TWC Count", PrintItemsFont, Brushes.Black, PrintX, PrintY)
        PrintY = PrintY + HeadingLineHeight

        'Setting up for multiple pages
        intStartingPageCounter = mintNewPrintCounter
        intNumberOfRecords = mintResultUpperLimit - 1

        For intCounter = intStartingPageCounter To mintResultUpperLimit - 1


            PrintX = 50
            e.Graphics.DrawString(CStr(structSearchResults(intCounter).mintPartID), PrintItemsFont, Brushes.Black, PrintX, PrintY)
            PrintX = 150
            e.Graphics.DrawString(structSearchResults(intCounter).mstrPartNumber, PrintItemsFont, Brushes.Black, PrintX, PrintY)

            intStringLength = structSearchResults(intCounter).mstrPartDescription.Length

            If intStringLength > intCharacterLimit Then

                'Setting up for the loop
                chaCharacterDescription = structSearchResults(intCounter).mstrPartDescription.ToCharArray
                strPartDescription = ""

                'Performing the loop
                For intCharacterCount = 0 To intCharacterLimit

                    'loading up the string
                    strPartDescription = strPartDescription + CStr(chaCharacterDescription(intCharacterCount))

                Next
            Else
                strPartDescription = structSearchResults(intCounter).mstrPartDescription
            End If

            PrintX = 250
            e.Graphics.DrawString(strPartDescription, PrintItemsFont, Brushes.Black, PrintX, PrintY)
            PrintX = 700
            e.Graphics.DrawString(CStr(structSearchResults(intCounter).mintQuantityOnHand), PrintItemsFont, Brushes.Black, PrintX, PrintY)
            PrintX = 900
            e.Graphics.DrawString(CStr(structSearchResults(intCounter).mintTWCQuantity), PrintItemsFont, Brushes.Black, PrintX, PrintY)
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