'Title:         Search by MSR Number
'Date:          7-8-15
'Author:        Terry Holmes

'Description:   This form is used to search parts by msr number

Option Strict On

Public Class SearchPartsByMSRNumber

    'Setting up the global variables
    Private ThePartNumberDataTier As PartsDataTier
    Private ThePartNumberDataSet As PartNumberDataSet
    Private WithEvents ThePartNumberBindingSource As BindingSource

    Private TheReceivedPartsDataTier As TWInventoryDataTier
    Private TheReceivedPartsDataSet As ReceivedPartsDataSet
    Private WithEvents TheReceivedPartsBindingSource As BindingSource

    Private addingBoolean As Boolean = False
    Private editingBoolean As Boolean = False
    Private previouseSelectedIndex As Integer

    Dim TheInputDataValidation As New InputDataValidation
    Dim TheModuleUnderDevelopment As New ModuleUnderDevelopment
    Dim TheKeywordSearchClass As New KeyWordSearchClass

    'Array for Selected Index
    Dim mintCounter As Integer
    Dim mintSelectedIndex() As Integer
    Dim mintUpperLimit As Integer

    'Setting up variables for the print
    Dim mintNewPrintCounter As Integer
    Dim LogDate As Date = Date.Now
    Dim mstrDate As String
    Dim mstrMSRNumber As String

    'Setting up structure for received parts
    Structure ReceivedParts
        Dim mstrMSRNumber As String
        Dim mstrPartNumber As String
        Dim mdatDate As Date
        Dim mintQuantity As Integer
        Dim mstrProjectID As String
    End Structure

    Dim structReceivedParts() As ReceivedParts
    Dim mintReceivedUpperLimit As Integer
    Dim mintReceivedCounter As Integer

    Structure Parts
        Dim mstrPartNumber As String
        Dim mstrDescription As String
    End Structure

    Dim structParts() As Parts
    Dim mintPartsUpperLimit As Integer
    Dim mintPartsCounter As Integer
    Dim mstrPartDescription As String

    Structure SearchResults
        Dim mstrMSRNumber As String
        Dim mstrPartNumber As String
        Dim mdatDate As Date
        Dim mintQuantity As Integer
        Dim mstrProjectID As String
    End Structure

    Dim structSearchResults() As SearchResults
    Dim mintResultsCounter As Integer
    Dim mintResultsUpperLimit As Integer

    Private Sub btnReceivePartsMenu_Click(sender As Object, e As EventArgs) Handles btnReceivePartsMenu.Click

        LastTransaction.Show()
        ReceiveMenu.Show()
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
    Private Function SetPartDataBindings() As Boolean

        'Setting local variables
        Dim intCounter As Integer
        Dim intNumberOfRecords As Integer
        Dim blnFatalError As Boolean = False

        Try

            'Setting up the data variables
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

            'setting up the combo box
            With cboPartNumber
                .DataSource = ThePartNumberBindingSource
                .DisplayMember = "PartNumber"
                .DataBindings.Add("text", ThePartNumberBindingSource, "PartNumber", False, DataSourceUpdateMode.Never)
            End With

            'Setting up the rest of the controls
            txtPartDescription.DataBindings.Add("text", ThePartNumberBindingSource, "Description")

            'Filling the structure
            intNumberOfRecords = cboPartNumber.Items.Count - 1
            ReDim structParts(intNumberOfRecords)
            mintPartsUpperLimit = intNumberOfRecords

            For intCounter = 0 To intNumberOfRecords

                cboPartNumber.SelectedIndex = intCounter

                structParts(intCounter).mstrPartNumber = cboPartNumber.Text
                structParts(intCounter).mstrDescription = txtPartDescription.Text

            Next

            Return blnFatalError

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            blnFatalError = True
            Return blnFatalError
        End Try

    End Function
    Private Function SetReceieveTransactionDataBindings() As Boolean

        'setting local variables
        Dim intCounter As Integer
        Dim intNumberOfRecords As Integer
        Dim intWarehouseIDForSearch As Integer
        Dim intWarehouseIDFromTable As Integer
        Dim blnFatalError As Boolean = False
        Dim blnItemsNotFound As Boolean = True

        Try

            'Setting data bindings
            TheReceivedPartsDataTier = New TWInventoryDataTier
            TheReceivedPartsDataSet = TheReceivedPartsDataTier.GetReceivedPartsInformation
            TheReceivedPartsBindingSource = New BindingSource

            'Setting up the binding source
            With TheReceivedPartsBindingSource
                .DataSource = TheReceivedPartsDataSet
                .DataMember = "ReceivedParts"
                .MoveFirst()
                .MoveLast()
            End With

            'setting up the combo box
            With cboTransactionID
                .DataSource = TheReceivedPartsBindingSource
                .DisplayMember = "TransactionID"
                .DataBindings.Add("text", TheReceivedPartsBindingSource, "TransactionID", False, DataSourceUpdateMode.Never)
            End With

            'setting up the rest of the controls
            txtDate.DataBindings.Add("text", TheReceivedPartsBindingSource, "Date")
            txtMSRNumber.DataBindings.Add("Text", TheReceivedPartsBindingSource, "MSRNumber")
            txtPartNumber.DataBindings.Add("Text", TheReceivedPartsBindingSource, "PartNumber")
            txtQuantity.DataBindings.Add("Text", TheReceivedPartsBindingSource, "QTY")
            txtWarehouseID.DataBindings.Add("Text", TheReceivedPartsBindingSource, "WarehouseID")
            txtProjectID.DataBindings.Add("Text", TheReceivedPartsBindingSource, "ProjectID")

            'beginning loop
            intNumberOfRecords = cboTransactionID.Items.Count - 1
            ReDim structReceivedParts(intNumberOfRecords)
            ReDim structSearchResults(intNumberOfRecords)
            intWarehouseIDForSearch = Logon.mintPartsWarehouseID
            mintReceivedCounter = 0

            For intCounter = 0 To intNumberOfRecords

                cboTransactionID.SelectedIndex = intCounter

                intWarehouseIDFromTable = CInt(txtWarehouseID.Text)

                If intWarehouseIDForSearch = intWarehouseIDFromTable Then

                    structReceivedParts(mintReceivedCounter).mdatDate = CDate(txtDate.Text)
                    structReceivedParts(mintReceivedCounter).mintQuantity = CInt(txtQuantity.Text)
                    structReceivedParts(mintReceivedCounter).mstrMSRNumber = txtMSRNumber.Text
                    structReceivedParts(mintReceivedCounter).mstrPartNumber = txtPartNumber.Text
                    structReceivedParts(mintReceivedCounter).mstrProjectID = txtProjectID.Text
                    mintReceivedCounter += 1
                    blnItemsNotFound = False

                End If
            Next

            If blnItemsNotFound = True Then
                blnFatalError = True
            End If

            mintReceivedUpperLimit = mintReceivedCounter - 1
            mintCounter = 0

            Return blnFatalError

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            blnFatalError = True
            Return blnFatalError
        End Try

    End Function
    

    Private Sub SearchPartsByMSRNumber_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim blnFatalError As Boolean

        PleaseWait.Show()
        Logon.mstrLastTransactionSummary = "LOADED SEARCH PARTS BY MSR NUMBER"

        blnFatalError = SetPartDataBindings()
        If blnFatalError = False Then
            blnFatalError = SetReceieveTransactionDataBindings()
        End If
        
        If blnFatalError = True Then
            PleaseWait.Close()
            setControlsVisible(False)
            btnFindMSRNumber.Enabled = False
            dgvSearchResults.Visible = False
            MessageBox.Show("The Bindings Have Failed or There Were Not Items Found", "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            'Creating Data Grive View
            dgvSearchResults.ColumnCount = 6
            dgvSearchResults.Columns(0).Name = "Date"
            dgvSearchResults.Columns(1).Name = "Project ID"
            dgvSearchResults.Columns(2).Name = "MSR Number"
            dgvSearchResults.Columns(3).Name = "Part Number"
            dgvSearchResults.Columns(4).Name = "Description"""
            dgvSearchResults.Columns(5).Name = "Quantity"
            dgvSearchResults.Visible = False

        End If

        setControlsVisible(False)
        PleaseWait.Close()
        
    End Sub
    Private Sub setControlsVisible(ByVal valueBoolean As Boolean)

        'This will make the controls visible
        txtPartDescription.Visible = valueBoolean
        txtPartNumber.Visible = valueBoolean
        txtMSRNumber.Visible = valueBoolean
        txtQuantity.Visible = valueBoolean
        txtDate.Visible = valueBoolean
        txtWarehouseID.Visible = valueBoolean
        txtProjectID.Visible = valueBoolean

    End Sub

    Private Sub btnFindMSRNumber_Click(sender As Object, e As EventArgs) Handles btnFindMSRNumber.Click

        'This will find all items that have been received for a project
        Dim intCounter As Integer
        Dim strMSRNumberForSearch As String
        Dim strMSRNumberFromTable As String
        Dim blnFatalError As Boolean = False
        Dim blnItemNotFound As Boolean = True
        Dim blnKeywordNotFound As Boolean
        Dim row() As String

        'Performing data validation
        strMSRNumberForSearch = txtFindMSRNumber.Text
        blnFatalError = TheInputDataValidation.VerifyTextData(strMSRNumberForSearch)
        If blnFatalError = True Then
            MessageBox.Show("MSR Number Was Not Entered", "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'Getting ready for the loop
        mintResultsCounter = 0
        dgvSearchResults.Visible = True
        dgvSearchResults.Rows.Clear()

        'for report
        mstrMSRNumber = strMSRNumberForSearch

        'Performing Loop
        For intCounter = 0 To mintReceivedUpperLimit

            'Getting the MSR Number
            strMSRNumberFromTable = structReceivedParts(intCounter).mstrMSRNumber
            blnKeywordNotFound = TheKeywordSearchClass.FindKeyWord(strMSRNumberForSearch, strMSRNumberFromTable)

            If blnKeywordNotFound = False Then

                structSearchResults(mintResultsCounter).mstrMSRNumber = strMSRNumberFromTable
                structSearchResults(mintResultsCounter).mstrPartNumber = structReceivedParts(intCounter).mstrPartNumber
                FindDescription(structReceivedParts(intCounter).mstrPartNumber)
                structSearchResults(mintResultsCounter).mstrProjectID = structReceivedParts(intCounter).mstrProjectID
                structSearchResults(mintResultsCounter).mintQuantity = structReceivedParts(intCounter).mintQuantity
                structSearchResults(mintResultsCounter).mdatDate = structReceivedParts(intCounter).mdatDate
                row = New String() {CStr(structSearchResults(mintResultsCounter).mdatDate), structSearchResults(mintResultsCounter).mstrProjectID, structSearchResults(mintResultsCounter).mstrMSRNumber, structSearchResults(mintResultsCounter).mstrPartNumber, mstrPartDescription, CStr(structSearchResults(mintResultsCounter).mintQuantity)}
                dgvSearchResults.Rows.Add(row)
                blnItemNotFound = False
                mintResultsCounter += 1
            End If
        Next

        If blnItemNotFound = True Then
            MessageBox.Show("No Items Were Found", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        mintResultsUpperLimit = mintResultsCounter - 1
        mintResultsCounter = 0
        btnRunReport.Enabled = True

    End Sub
    Private Sub FindDescription(ByVal strPartNumberForSearch As String)

        Dim intCounter As Integer
        Dim strPartNumberFromTable As String

        'Running loop
        For intCounter = 0 To mintPartsUpperLimit

            'Getting part number
            strPartNumberFromTable = structParts(intCounter).mstrPartNumber

            If strPartNumberForSearch = strPartNumberFromTable Then

                mstrPartDescription = structParts(intCounter).mstrDescription
                Exit For

            End If
        Next

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

        'Getting the date
        mstrDate = CStr(LogDate)

        'Setting up for default position
        PrintY = 100

        'Setting up for the print header
        PrintX = 300
        e.Graphics.DrawString("Blue Jay Communications Inventory Report", PrintHeaderFont, Brushes.Black, PrintX, PrintY)
        PrintY = PrintY + HeadingLineHeight
        PrintX = 306
        e.Graphics.DrawString("Project Part Receive Log For MSR Number:  " + mstrMSRNumber, PrintSubHeaderFont, Brushes.Black, PrintX, PrintY)
        PrintY = PrintY + HeadingLineHeight

        'Setting up the columns
        PrintX = 50
        e.Graphics.DrawString("Date", PrintItemsFont, Brushes.Black, PrintX, PrintY)
        PrintX = 220
        e.Graphics.DrawString("Project ID", PrintItemsFont, Brushes.Black, PrintX, PrintY)
        PrintX = 350
        e.Graphics.DrawString("MSR Number", PrintItemsFont, Brushes.Black, PrintX, PrintY)
        PrintX = 500
        e.Graphics.DrawString("Part Number", PrintItemsFont, Brushes.Black, PrintX, PrintY)
        PrintX = 650
        e.Graphics.DrawString("Part Description", PrintItemsFont, Brushes.Black, PrintX, PrintY)
        PrintX = 950
        e.Graphics.DrawString("Quantity", PrintItemsFont, Brushes.Black, PrintX, PrintY)
        PrintY = PrintY + HeadingLineHeight

        'Setting up for multiple pages
        intStartingPageCounter = mintNewPrintCounter
        intNumberOfRecords = mintUpperLimit

        For intCounter = intStartingPageCounter To mintResultsUpperLimit


            PrintX = 50
            e.Graphics.DrawString(CStr(structSearchResults(intCounter).mdatDate), PrintItemsFont, Brushes.Black, PrintX, PrintY)
            PrintX = 220
            e.Graphics.DrawString(CStr(structSearchResults(intCounter).mstrProjectID), PrintItemsFont, Brushes.Black, PrintX, PrintY)
            PrintX = 350
            e.Graphics.DrawString(CStr(structSearchResults(intCounter).mstrMSRNumber), PrintItemsFont, Brushes.Black, PrintX, PrintY)
            PrintX = 500
            e.Graphics.DrawString(CStr(structSearchResults(intCounter).mstrPartNumber), PrintItemsFont, Brushes.Black, PrintX, PrintY)

            FindDescription(structSearchResults(intCounter).mstrPartNumber)

            intStringLength = mstrPartDescription.Length

            If intStringLength > intCharacterLimit Then

                'Setting up for the loop
                chaCharacterDescription = mstrPartDescription.ToCharArray
                strPartDescription = ""

                'Performing the loop
                For intCharacterCount = 0 To intCharacterLimit

                    'loading up the string
                    strPartDescription = strPartDescription + CStr(chaCharacterDescription(intCharacterCount))

                Next
            Else
                strPartDescription = mstrPartDescription
            End If

            PrintX = 650
            e.Graphics.DrawString(strPartDescription, PrintItemsFont, Brushes.Black, PrintX, PrintY)
            PrintX = 950
            e.Graphics.DrawString(CStr(structSearchResults(intCounter).mintQuantity), PrintItemsFont, Brushes.Black, PrintX, PrintY)
            PrintY = PrintY + ItemLineHeight


            If PrintY > 750 Then
                If intStartingPageCounter = mintResultsUpperLimit Then
                    e.HasMorePages = False
                Else
                    e.HasMorePages = True
                    blnNewPage = True
                End If
            End If

            If blnNewPage = True Then
                mintNewPrintCounter = intCounter + 1
                intCounter = mintResultsUpperLimit
            End If


        Next
    End Sub
    Private Sub PrintDocument1_QueryPageSettings(sender As Object, e As Printing.QueryPageSettingsEventArgs) Handles PrintDocument1.QueryPageSettings

        'setting the document to landscape
        e.PageSettings.Landscape = True

    End Sub
End Class