'Title:         Received Parts Information
'Date:          12-30-14
'Author:        Terry Holmes

'Description:   This form will show all Parts Received

Option Strict On

Public Class ProjectReceivedTransactions

    'Setting up the global variables
    Private ThePartNumberDataTier As PartsDataTier
    Private ThePartNumberDataSet As PartNumberDataSet
    Private WithEvents ThePartNumberBindingSource As BindingSource

    Private TheReceivedPartsDataTier As TWInventoryDataTier
    Private TheReceivedPartsDataSet As ReceivedPartsDataSet
    Private WithEvents TheReceivedPartsBindingSource As BindingSource

    Dim TheInputDataValidation As New InputDataValidation
    Dim TheModuleUnderDevelopment As New ModuleUnderDevelopment
    Dim mstrErrorMessage As String

    'Array for Selected Index
    Dim mintCounter As Integer
    Dim mintSelectedIndex() As Integer
    Dim mintUpperLimit As Integer

    'Setting up variables for the print
    Dim mintNewPrintCounter As Integer
    Dim LogDate As Date = Date.Now
    Dim mstrDate As String
    Dim mstrProjectID As String

    'Setting up structure for received parts
    Structure ReceivedParts
        Dim mstrProjectID As String
        Dim mstrPartNumber As String
        Dim mdatDate As Date
        Dim mstrMSRNumber As String
        Dim mintQuantity As Integer
    End Structure

    Dim structReceivedParts() As ReceivedParts
    Dim mintReceivedCounter As Integer
    Dim mintReceivedUpperLimit As Integer

    Structure Parts
        Dim mstrPartNumber As String
        Dim mstrDescription As String
    End Structure

    Dim structParts() As Parts
    Dim mintPartsUpperLimit As Integer
    Dim mstrDescription As String

    Structure SearchResults
        Dim mstrProjectID As String
        Dim mstrPartNumber As String
        Dim mstrDate As String
        Dim mstrMSRNumber As String
        Dim mintQuantity As Integer
    End Structure

    Dim structSearchResults() As ReceivedParts
    Dim mintResultsCounter As Integer
    Dim mintResultsUpperLimit As Integer

    Private Sub ProjectReceivedTransactions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim blnFatalError As Boolean
        Dim strErrorMessage As String = ""

        PleaseWait.Show()
        blnFatalError = SetPartsDataBindings()

        If blnFatalError = False Then
            blnFatalError = SetReceiveTransactionDataBindings()
        End If

        If blnFatalError = True Then
            MessageBox.Show(mstrErrorMessage, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            btnFindProjectID.Enabled = False
            MakeControlsVisible(False)
            dgvSearchResults.Visible = False
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

        MakeControlsVisible(False)
        PleaseWait.Close()

    End Sub
    Private Function SetReceiveTransactionDataBindings() As Boolean

        'Setting local variables
        Dim intCounter As Integer
        Dim intNumberOfRecords As Integer
        Dim intWarehouseIDForSearch As Integer
        Dim intWarehouseIDFromTable As Integer
        Dim blnFatalError As Boolean = False
        Dim blnItemNotFound As Boolean = True

        'Try Catch for exception
        Try

            'setting up the bindings
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

            'Setting up the combo box
            With cboTransactionID
                .DataSource = TheReceivedPartsBindingSource
                .DisplayMember = "TransactionID"
                .DataBindings.Add("Text", TheReceivedPartsBindingSource, "TransactionID", False, DataSourceUpdateMode.Never)
            End With

            'Setting up the rest of the controls
            txtDate.DataBindings.Add("text", TheReceivedPartsBindingSource, "Date")
            txtProjectID.DataBindings.Add("Text", TheReceivedPartsBindingSource, "ProjectID")
            txtMSRNumber.DataBindings.Add("text", TheReceivedPartsBindingSource, "MSRNumber")
            txtPartNumber.DataBindings.Add("text", TheReceivedPartsBindingSource, "PartNumber")
            txtQuantity.DataBindings.Add("Text", TheReceivedPartsBindingSource, "QTY")
            txtWarehouseID.DataBindings.Add("Text", TheReceivedPartsBindingSource, "WarehouseID")

            'Setting up for the loop
            intNumberOfRecords = cboTransactionID.Items.Count - 1
            ReDim structReceivedParts(intNumberOfRecords)
            ReDim structSearchResults(intNumberOfRecords)
            intWarehouseIDForSearch = Logon.mintPartsWarehouseID
            mintReceivedCounter = 0

            'Beginning Loop
            For intCounter = 0 To intNumberOfRecords

                'incrementing the combo box
                cboTransactionID.SelectedIndex = intCounter

                'getting the warehouse id
                intWarehouseIDFromTable = CInt(txtWarehouseID.Text)

                If intWarehouseIDForSearch = intWarehouseIDFromTable Then

                    'loading structure
                    structReceivedParts(mintReceivedCounter).mdatDate = CDate(txtDate.Text)
                    structReceivedParts(mintReceivedCounter).mstrPartNumber = txtPartNumber.Text
                    structReceivedParts(mintReceivedCounter).mstrProjectID = txtProjectID.Text
                    structReceivedParts(mintReceivedCounter).mstrMSRNumber = txtMSRNumber.Text
                    structReceivedParts(mintReceivedCounter).mintQuantity = CInt(txtQuantity.Text)
                    mintReceivedCounter += 1
                    blnItemNotFound = False

                End If
            Next

            mintReceivedUpperLimit = mintReceivedCounter - 1
            mintReceivedCounter = 0

            'Setting up to return
            If blnItemNotFound = True Then
                blnFatalError = True
                mstrErrorMessage = "No Parts Were Found For This Warehouse"
            End If

            Return blnFatalError

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            mstrErrorMessage = "There is a Binding Problem"
            blnFatalError = True
            Return blnFatalError

        End Try

    End Function
    Private Function SetPartsDataBindings() As Boolean

        Dim blnFatalError As Boolean = False
        Dim intCounter As Integer
        Dim intNumberOfRecords As Integer

        'Try Catch for exception
        Try

            'Setting the data bindings
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

            'Setting up the combo box
            With cboPartNumber
                .DataSource = ThePartNumberBindingSource
                .DisplayMember = "PartNumber"
                .DataBindings.Add("text", ThePartNumberBindingSource, "PartNumber", False, DataSourceUpdateMode.Never)
            End With

            'Setting the rest of the controls
            txtPartDescription.DataBindings.Add("text", ThePartNumberBindingSource, "Description")

            'Setting up the loop
            intNumberOfRecords = cboPartNumber.Items.Count - 1
            ReDim structParts(intNumberOfRecords)
            mintPartsUpperLimit = intNumberOfRecords

            'Beginning loop
            For intCounter = 0 To intNumberOfRecords

                'incrementing the combo box
                cboPartNumber.SelectedIndex = intCounter

                'loading the array
                structParts(intCounter).mstrPartNumber = cboPartNumber.Text
                structParts(intCounter).mstrDescription = txtPartDescription.Text
            Next

            Return blnFatalError

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            blnFatalError = True
            mstrErrorMessage = "There is a Binding Problem"
            Return blnFatalError

        End Try

    End Function
    

    Private Sub btnRunReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRunReport.Click

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

    Private Sub btnMainMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMainMenu.Click

        'This will call up the main menu 
        LastTransaction.Show()
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        'This will close the program
        CloseProgram.ShowDialog()

    End Sub

    Private Sub btnFindProjectID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFindProjectID.Click

        'This will find all items that have been received for a project
        Dim intCounter As Integer
        Dim strProjectIDForSearch As String
        Dim strProjectIDFromTable As String
        Dim blnFatalError As Boolean = False
        Dim blnItemNotFound As Boolean = True
        Dim row() As String

        'Performing Data Validation
        strProjectIDForSearch = txtFindProjectID.Text
        blnFatalError = TheInputDataValidation.VerifyTextData(strProjectIDForSearch)
        If blnFatalError = True Then
            MessageBox.Show("Project ID Was Not Entered", "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        dgvSearchResults.Visible = True
        dgvSearchResults.Rows.Clear()

        mstrProjectID = strProjectIDForSearch
        mintResultsCounter = 0

        'Setting up for the loop
        For intCounter = 0 To mintReceivedUpperLimit

            'Checking Project ID
            strProjectIDFromTable = structReceivedParts(intCounter).mstrProjectID

            'If statement to see if the project ids match
            If strProjectIDForSearch = strProjectIDFromTable Then

                structSearchResults(mintResultsCounter).mdatDate = structReceivedParts(intCounter).mdatDate
                structSearchResults(mintResultsCounter).mintQuantity = structReceivedParts(intCounter).mintQuantity
                structSearchResults(mintResultsCounter).mstrMSRNumber = structReceivedParts(intCounter).mstrMSRNumber
                structSearchResults(mintResultsCounter).mstrPartNumber = structReceivedParts(intCounter).mstrPartNumber
                FindDescription(structSearchResults(mintResultsCounter).mstrPartNumber)
                structSearchResults(mintResultsCounter).mstrProjectID = structReceivedParts(intCounter).mstrProjectID
                row = New String() {CStr(structSearchResults(mintResultsCounter).mdatDate), structSearchResults(mintResultsCounter).mstrProjectID, structSearchResults(mintResultsCounter).mstrMSRNumber, structSearchResults(mintResultsCounter).mstrPartNumber, mstrDescription, CStr(structSearchResults(mintResultsCounter).mintQuantity)}
                dgvSearchResults.Rows.Add(row)
                mintResultsCounter += 1
                blnItemNotFound = False
            End If

        Next

        If blnItemNotFound = True Then
            dgvSearchResults.Visible = False
            MessageBox.Show("Project Entered Was Not Found", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        mintResultsUpperLimit = mintResultsCounter - 1
        mintResultsCounter = 0
        btnRunReport.Enabled = True

    End Sub
    Private Sub FindDescription(ByVal strPartNumberForSearch As String)

        Dim intCounter As Integer
        Dim intSelectedIndex As Integer
        Dim strPartNumberFromTable As String

        'Performing Loop
        For intCounter = 0 To mintPartsUpperLimit

            'Getting part number from table
            strPartNumberFromTable = structParts(intCounter).mstrPartNumber

            If strPartNumberForSearch = strPartNumberFromTable Then

                mstrDescription = structParts(intCounter).mstrDescription
                Exit For

            End If

        Next

        cboPartNumber.SelectedIndex = intSelectedIndex

    End Sub
    Private Sub MakeControlsVisible(ByVal valueBoolean As Boolean)

        'This will make the controls visible
        txtPartDescription.Visible = valueBoolean
        txtPartNumber.Visible = valueBoolean
        txtProjectID.Visible = valueBoolean
        txtQuantity.Visible = valueBoolean
        txtDate.Visible = valueBoolean
        txtWarehouseID.Visible = valueBoolean
        txtMSRNumber.Visible = valueBoolean

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

        PrintX = 300
        e.Graphics.DrawString("Blue Jay Communications Inventory Report", PrintHeaderFont, Brushes.Black, PrintX, PrintY)
        PrintY = PrintY + HeadingLineHeight
        PrintX = 306
        e.Graphics.DrawString("Project Part Receive Log For Project ID:  " + mstrProjectID, PrintSubHeaderFont, Brushes.Black, PrintX, PrintY)
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

        'Setting the upper limit
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

            intStringLength = mstrDescription.Length

            If intStringLength > intCharacterLimit Then

                'Setting up for the loop
                chaCharacterDescription = mstrDescription.ToCharArray
                strPartDescription = ""

                'Performing the loop
                For intCharacterCount = 0 To intCharacterLimit

                    'loading up the string
                    strPartDescription = strPartDescription + CStr(chaCharacterDescription(intCharacterCount))

                Next
            Else
                strPartDescription = mstrDescription
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

    Private Sub btnReceiveMenu_Click(sender As Object, e As EventArgs) Handles btnReceiveMenu.Click

        'This will display the receive menu
        LastTransaction.Show()
        ReceiveMenu.Show()
        Me.Close()

    End Sub
    Private Sub PrintDocument1_QueryPageSettings(sender As Object, e As Printing.QueryPageSettingsEventArgs) Handles PrintDocument1.QueryPageSettings

        'setting the document to landscape
        e.PageSettings.Landscape = True

    End Sub
End Class