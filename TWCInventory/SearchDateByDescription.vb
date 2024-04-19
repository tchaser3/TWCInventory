'Title:         Search Description By Date
'Date:          7-13-15
'Author:        Terry Holmes

'Description    This form will allow the user to search by a date range and description

Option Strict On

Public Class SearchDateByDescription

    Private TheReceivedPartsDataTier As TWInventoryDataTier
    Private TheReceivedPartsDataSet As ReceivedPartsDataSet
    Private WithEvents TheReceivedPartsBindingSource As BindingSource

    Private ThePartNumberDataSet As PartNumberDataSet
    Private ThePartNumberDataTier As PartsDataTier
    Private WithEvents ThePartNumberBindingSource As BindingSource

    Dim TheDateSearchClass As New DateSearchClass
    Dim TheInputDataValidation As New InputDataValidation
    Dim TheKeywordSearchClass As New KeyWordSearchClass

    Dim mintSelectedIndex() As Integer
    Dim mintCounter As Integer
    Dim mintUpperLimit As Integer

    Dim mintNewPrintCounter As Integer

    Structure Parts
        Dim mstrPartNumber As String
        Dim mstrDescription As String
    End Structure

    Dim structParts() As Parts
    Dim mintPartsUpperLimit As Integer
    Dim mstrPartDescription As String

    Structure ReceiveTransactions

        Dim mstrProjectID As String
        Dim mstrMSRNumber As String
        Dim mstrPartNumber As String
        Dim mdatDate As Date
        Dim mintQuantity As Integer

    End Structure

    Dim structSearchResults() As SearchResults
    Dim mintResultsCounter As Integer
    Dim mintResultsUpperLimit As Integer

    Dim structReceiveTransactions() As ReceiveTransactions
    Dim mintReceiveUpperLimit As Integer
    Dim mintTotalQuantity As Integer

    Structure SearchResults

        Dim mstrProjectID As String
        Dim mstrMSRNumber As String
        Dim mstrPartNumber As String
        Dim mdatDate As Date
        Dim mintQuantity As Integer

    End Structure

    Private Sub btnReceiveMenu_Click(sender As Object, e As EventArgs) Handles btnReceiveMenu.Click

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

    Private Sub SearchDateByDescription_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'This will load the controls
        'setting local variables
        Dim intCounter As Integer
        Dim intNumberOfRecords As Integer
        Dim blnItemNotFound As Boolean = True
        Dim intWarehouseIDForSearch As Integer
        Dim intWarehouseIDFromTable As Integer

        Try

            PleaseWait.Show()
            Logon.mstrLastTransactionSummary = "LOAD PART NUMBER DATE SEARCH FORM"

            TheReceivedPartsDataTier = New TWInventoryDataTier
            TheReceivedPartsDataSet = TheReceivedPartsDataTier.GetReceivedPartsInformation
            TheReceivedPartsBindingSource = New BindingSource

            ThePartNumberDataTier = New PartsDataTier
            ThePartNumberDataSet = ThePartNumberDataTier.GetPartNumberInformation
            ThePartNumberBindingSource = New BindingSource

            'Setting the binding source
            With TheReceivedPartsBindingSource
                .DataSource = TheReceivedPartsDataSet
                .DataMember = "ReceivedParts"
                .MoveFirst()
                .MoveLast()
            End With

            With ThePartNumberBindingSource
                .DataSource = ThePartNumberDataSet
                .DataMember = "partnumbers"
                .MoveFirst()
                .MoveLast()
            End With

            'Setting the combo box
            With cboTransactionID
                .DataSource = TheReceivedPartsBindingSource
                .DisplayMember = "TransactionID"
                .DataBindings.Add("text", TheReceivedPartsBindingSource, "TransactionID", False, DataSourceUpdateMode.Never)
            End With

            With cboPartNumber
                .DataSource = ThePartNumberBindingSource
                .DisplayMember = "PartNumber"
                .DataBindings.Add("text", ThePartNumberBindingSource, "PartNumber", False, DataSourceUpdateMode.Never)
            End With

            'setting the rest of the controls
            txtDate.DataBindings.Add("text", TheReceivedPartsBindingSource, "Date")
            txtMSRNumber.DataBindings.Add("text", TheReceivedPartsBindingSource, "MSRNumber")
            txtPartNumber.DataBindings.Add("Text", TheReceivedPartsBindingSource, "PartNumber")
            txtProjectID.DataBindings.Add("text", TheReceivedPartsBindingSource, "ProjectID")
            txtQuantity.DataBindings.Add("text", TheReceivedPartsBindingSource, "QTY")
            txtWarehouseID.DataBindings.Add("Text", TheReceivedPartsBindingSource, "WarehouseID")

            txtPartDescription.DataBindings.Add("text", ThePartNumberBindingSource, "Description")

            'Setting up the array
            intNumberOfRecords = cboTransactionID.Items.Count - 1
            ReDim mintSelectedIndex(intNumberOfRecords)
            ReDim structReceiveTransactions(intNumberOfRecords)
            ReDim structSearchResults(intNumberOfRecords)
            mintCounter = 0
            intWarehouseIDForSearch = Logon.mintPartsWarehouseID

            'beginning loop
            For intCounter = 0 To intNumberOfRecords

                'incrementing the combo box
                cboTransactionID.SelectedIndex = intCounter

                intWarehouseIDFromTable = CInt(txtWarehouseID.Text)

                If intWarehouseIDForSearch = intWarehouseIDFromTable Then
                    structReceiveTransactions(mintCounter).mdatDate = CDate(txtDate.Text)
                    structReceiveTransactions(mintCounter).mintQuantity = CInt(txtQuantity.Text)
                    structReceiveTransactions(mintCounter).mstrMSRNumber = txtMSRNumber.Text
                    structReceiveTransactions(mintCounter).mstrPartNumber = txtPartNumber.Text
                    structReceiveTransactions(mintCounter).mstrProjectID = txtProjectID.Text
                    mintCounter += 1
                    blnItemNotFound = False
                End If
            Next

            If blnItemNotFound = True Then
                PleaseWait.Close()
                MessageBox.Show("No Parts Were Found for this Warehouse", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtEnterKeyword.Visible = False
                txtEnterEndDate.Visible = False
                txtEnterStartDate.Visible = False
                btnFindParts.Visible = False
                btnRunReport.Visible = False
                SetControlsVisible(False)
                dgvSearchResults.Visible = False
                PleaseWait.Close()
            Else
                mintReceiveUpperLimit = mintCounter - 1
                mintCounter = 0
                FillPartsStructure()
                PleaseWait.Close()
                SetControlsVisible(False)
                txtEnterStartDate.Focus()
                dgvSearchResults.ColumnCount = 6
                dgvSearchResults.Columns(0).Name = "Project ID"
                dgvSearchResults.Columns(1).Name = "MSR Number"
                dgvSearchResults.Columns(2).Name = "Part Number"
                dgvSearchResults.Columns(3).Name = "Description"
                dgvSearchResults.Columns(4).Name = "Date"
                dgvSearchResults.Columns(5).Name = "Quantity"
                dgvSearchResults.Visible = False
            End If

        Catch ex As Exception
            PleaseWait.Close()
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub FillPartsStructure()

        'Setting up local variables
        Dim intCounter As Integer
        Dim intNumberOfRecords As Integer

        'Getting ready for loop
        intNumberOfRecords = cboPartNumber.Items.Count - 1
        ReDim structParts(intNumberOfRecords)
        mintPartsUpperLimit = intNumberOfRecords

        'Loading array
        For intCounter = 0 To intNumberOfRecords

            'incrementing the combo box
            cboPartNumber.SelectedIndex = intCounter

            structParts(intCounter).mstrPartNumber = cboPartNumber.Text
            structParts(intCounter).mstrDescription = txtPartDescription.Text

        Next

    End Sub
    Private Sub SetControlsVisible(ByVal valueBoolean As Boolean)

        'This will set the controls visible
        cboTransactionID.Visible = valueBoolean
        cboPartNumber.Visible = valueBoolean
        txtDate.Visible = valueBoolean
        txtMSRNumber.Visible = valueBoolean
        txtPartDescription.Visible = valueBoolean
        txtPartNumber.Visible = valueBoolean
        txtProjectID.Visible = valueBoolean
        txtQuantity.Visible = valueBoolean
        txtWarehouseID.Visible = valueBoolean

    End Sub

    Private Sub btnFindParts_Click(sender As Object, e As EventArgs) Handles btnFindParts.Click

        'This will run and find the parts
        Dim intPartCounter As Integer
        Dim intPartNumberOfRecords As Integer
        Dim intTransactionCounter As Integer
        Dim intTransactionNumberOfRecords As Integer
        Dim strValueForValidation As String
        Dim blnFatalError As Boolean = False
        Dim blnItemNotFound As Boolean = True
        Dim blnKeywordNotFound As Boolean
        Dim strPartNumberForSearch As String
        Dim strPartNumberFromTable As String
        Dim datStartDateForSeach As Date
        Dim datEndDateForSearch As Date
        Dim datDateEntered As Date
        Dim datDateFromTable As Date
        Dim blnThereIsAProblem As Boolean = False
        Dim strErrorMessage As String = ""
        Dim row() As String

        'Setting up for data validation
        strValueForValidation = txtEnterKeyword.Text
        blnFatalError = TheInputDataValidation.VerifyTextData(strValueForValidation)
        If blnFatalError = True Then
            blnThereIsAProblem = True
            strErrorMessage = strErrorMessage + "The Keyword was not Entered" + vbNewLine
        End If
        strValueForValidation = txtEnterStartDate.Text
        blnFatalError = TheInputDataValidation.VerifyStartingEndingDatesAsDates(strValueForValidation)
        If blnFatalError = True Then
            blnThereIsAProblem = True
            strErrorMessage = strErrorMessage + "The Starting Date Entered is not in the Correct Format" + vbNewLine
        End If
        strValueForValidation = txtEnterEndDate.Text
        blnFatalError = TheInputDataValidation.VerifyStartingEndingDatesAsDates(strValueForValidation)
        If blnFatalError = True Then
            blnThereIsAProblem = True
            strErrorMessage = strErrorMessage + "The Ending Date Entered is not in the Correct Format" + vbNewLine
        End If
        If blnThereIsAProblem = True Then
            MessageBox.Show(strErrorMessage, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        datDateEntered = CDate(txtEnterStartDate.Text)
        datStartDateForSeach = TheDateSearchClass.RemoveTime(datDateEntered)
        Logon.mdatStartingDate = datStartDateForSeach
        datDateEntered = CDate(txtEnterEndDate.Text)
        datEndDateForSearch = TheDateSearchClass.RemoveTime(datDateEntered)
        Logon.mdatEndingDate = datEndDateForSearch
        strValueForValidation = txtEnterKeyword.Text

        'Continuing search
        intPartNumberOfRecords = mintPartsUpperLimit
        intTransactionNumberOfRecords = mintReceiveUpperLimit
        mintResultsCounter = 0
        dgvSearchResults.Visible = True
        dgvSearchResults.Rows.Clear()

        'Beginning first Loop
        For intPartCounter = 0 To intPartNumberOfRecords

            'Getting description
            blnKeywordNotFound = TheKeywordSearchClass.FindKeyWord(strValueForValidation, structParts(intPartCounter).mstrDescription)

            If blnKeywordNotFound = False Then

                'Getting part Number
                strPartNumberForSearch = structParts(intPartCounter).mstrPartNumber

                'beginning second loop
                For intTransactionCounter = 0 To intTransactionNumberOfRecords

                    strPartNumberFromTable = structReceiveTransactions(intTransactionCounter).mstrPartNumber
                    datDateFromTable = structReceiveTransactions(intTransactionCounter).mdatDate

                    If strPartNumberForSearch = strPartNumberFromTable Then
                        If datDateFromTable >= datStartDateForSeach Then
                            If datDateFromTable <= datEndDateForSearch Then

                                'Saving search results
                                structSearchResults(mintResultsCounter).mstrPartNumber = structReceiveTransactions(intTransactionCounter).mstrPartNumber
                                structSearchResults(mintResultsCounter).mstrMSRNumber = structReceiveTransactions(intTransactionCounter).mstrMSRNumber
                                structSearchResults(mintResultsCounter).mstrProjectID = structReceiveTransactions(intTransactionCounter).mstrProjectID
                                structSearchResults(mintResultsCounter).mdatDate = structReceiveTransactions(intTransactionCounter).mdatDate
                                structSearchResults(mintResultsCounter).mintQuantity = structReceiveTransactions(intTransactionCounter).mintQuantity
                                row = New String() {structSearchResults(mintResultsCounter).mstrProjectID, structSearchResults(mintResultsCounter).mstrMSRNumber, structSearchResults(mintResultsCounter).mstrPartNumber, structParts(intPartCounter).mstrDescription, CStr(structSearchResults(mintResultsCounter).mdatDate), CStr(structSearchResults(mintResultsCounter).mintQuantity)}
                                dgvSearchResults.Rows.Add(row)
                                mintResultsCounter += 1
                                blnItemNotFound = False

                            End If
                        End If
                    End If
                Next

            End If

        Next
        If blnItemNotFound = True Then
            btnRunReport.Enabled = False
            dgvSearchResults.Visible = False
            MessageBox.Show("The Keyword Entered was not Found", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        mintResultsUpperLimit = mintResultsCounter - 1
        mintResultsCounter = 0
        btnRunReport.Enabled = True
        txtEnterEndDate.Text = ""
        txtEnterKeyword.Text = ""
        txtEnterStartDate.Text = ""
        MessageBox.Show("Please Press the Run Report to View Results", "Thank You", MessageBoxButtons.OK, MessageBoxIcon.Information)
        
    End Sub


    Private Sub btnRunReport_Click(sender As Object, e As EventArgs) Handles btnRunReport.Click

        'This will set up for the report
        PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings

        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
        End If

        mintNewPrintCounter = 0
        mintTotalQuantity = 0

        PrintDocument1.Print()

    End Sub
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage


        'Setting up the local variables
        Dim intCounter As Integer
        Dim intNumberOfRecords As Integer
        Dim intStartingPageCounter As Integer
        Dim blnNewPage As Boolean = False
        Dim intStructureCounter As Integer
        Dim strPartNumberForSearch As String
        Dim strPartNumberFromTable As String
        Dim intQuantity As Integer

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
        PrintX = 280
        e.Graphics.DrawString("Blue Jay Communications Inventory Report", PrintHeaderFont, Brushes.Black, PrintX, PrintY)
        PrintY = PrintY + HeadingLineHeight
        PrintX = 350
        e.Graphics.DrawString("Part Number Date Description Search", PrintSubHeaderFont, Brushes.Black, PrintX, PrintY)
        PrintY = PrintY + HeadingLineHeight
        PrintX = 280
        e.Graphics.DrawString("For Material Recieved Between " + CStr(Logon.mdatStartingDate) + " and " + CStr(Logon.mdatEndingDate), PrintSubHeaderFont, Brushes.Black, PrintX, PrintY)
        PrintY = PrintY + HeadingLineHeight

        'Setting up the columns
        PrintX = 50
        e.Graphics.DrawString("Part Number", PrintItemsFont, Brushes.Black, PrintX, PrintY)
        PrintX = 220
        e.Graphics.DrawString("Part Description", PrintItemsFont, Brushes.Black, PrintX, PrintY)
        PrintX = 500
        e.Graphics.DrawString("Project ID", PrintItemsFont, Brushes.Black, PrintX, PrintY)
        PrintX = 650
        e.Graphics.DrawString("MSR Number", PrintItemsFont, Brushes.Black, PrintX, PrintY)
        PrintX = 750
        e.Graphics.DrawString("Date", PrintItemsFont, Brushes.Black, PrintX, PrintY)
        PrintX = 950
        e.Graphics.DrawString("Quantity", PrintItemsFont, Brushes.Black, PrintX, PrintY)
        PrintY = PrintY + HeadingLineHeight

        'Setting up for multiple pages
        intStartingPageCounter = mintNewPrintCounter
        intNumberOfRecords = mintResultsUpperLimit

        'Setting the upper limit
        For intCounter = intStartingPageCounter To mintResultsUpperLimit

            PrintX = 50
            e.Graphics.DrawString(CStr(structSearchResults(intCounter).mstrPartNumber), PrintItemsFont, Brushes.Black, PrintX, PrintY)
            strPartNumberForSearch = structSearchResults(intCounter).mstrPartNumber

            For intStructureCounter = 0 To mintPartsUpperLimit

                strPartNumberFromTable = structParts(intStructureCounter).mstrPartNumber

                If strPartNumberForSearch = strPartNumberFromTable Then

                    mstrPartDescription = structParts(intStructureCounter).mstrDescription
                    Exit For

                End If

            Next

            'Setting up to limit the description size
            strPartDescription = mstrPartDescription
            intStringLength = strPartDescription.Length

            If intStringLength > intCharacterLimit Then

                'Setting up for the loop
                chaCharacterDescription = strPartDescription.ToCharArray
                strPartDescription = ""

                'Performing the loop
                For intCharacterCount = 0 To intCharacterLimit

                    'loading up the string
                    strPartDescription = strPartDescription + CStr(chaCharacterDescription(intCharacterCount))

                Next
            End If

            PrintX = 220
            e.Graphics.DrawString(CStr(strPartDescription), PrintItemsFont, Brushes.Black, PrintX, PrintY)
            PrintX = 500
            e.Graphics.DrawString(CStr(structSearchResults(intCounter).mstrProjectID), PrintItemsFont, Brushes.Black, PrintX, PrintY)
            PrintX = 650
            e.Graphics.DrawString(CStr(structSearchResults(intCounter).mstrMSRNumber), PrintItemsFont, Brushes.Black, PrintX, PrintY)
            PrintX = 750
            e.Graphics.DrawString(CStr(structSearchResults(intCounter).mdatDate), PrintItemsFont, Brushes.Black, PrintX, PrintY)
            PrintX = 950
            e.Graphics.DrawString(CStr(structSearchResults(intCounter).mintQuantity), PrintItemsFont, Brushes.Black, PrintX, PrintY)
            PrintY = PrintY + ItemLineHeight
            intQuantity = structReceiveTransactions(mintSelectedIndex(intCounter)).mintQuantity
            mintTotalQuantity = mintTotalQuantity + intQuantity

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