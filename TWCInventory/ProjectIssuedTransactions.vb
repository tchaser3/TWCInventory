'Title:         Project Issued Transactions
'Date:          2-20-15
'Author:        Terry Holmes

'Description:   This form is used for finding the project issued transactions

Public Class ProjectIssuedTransactions

    'Setting up the global variables
    Private ThePartNumberDataTier As PartsDataTier
    Private ThePartNumberDataSet As PartNumberDataSet
    Private WithEvents ThePartNumberBindingSource As BindingSource

    Private TheIssuedPartsDataTier As TWInventoryDataTier
    Private TheIssuedPartsDataSet As IssuedPartsDataSet
    Private WithEvents TheIssuedPartsBindingSource As BindingSource

    Private addingBoolean As Boolean = False
    Private editingBoolean As Boolean = False
    Private previouseSelectedIndex As Integer

    Dim TheInputDataValidation As New InputDataValidation
    Dim TheModuleUnderDevelopment As New ModuleUnderDevelopment
    Dim TheCheckTimeWarnerPartNumber As New CheckTimeWarnerPartNumber


    Structure Parts
        Dim mstrPartNumber As String
        Dim mstrDescription As String
    End Structure

    Dim structParts() As Parts
    Dim mintPartCounter As Integer
    Dim mintPartUpperLimit As Integer

    Structure IssuedTransactions
        Dim mdatDate As Date
        Dim mstrProjectID As String
        Dim mstrPartNumber As String
        Dim mintQuantity As Integer
    End Structure

    Dim structIssuedTransactions() As IssuedTransactions
    Dim mintIssuedCounter As Integer
    Dim mintIssuedUpperLimit As Integer

    Structure SearchResults
        Dim mdatDate As Date
        Dim mstrProjectID As String
        Dim mstrPartNumber As String
        Dim mintQuantity As Integer
    End Structure

    Dim structSearchResults() As SearchResults
    Dim mintResultsCounter As Integer
    Dim mintResultsUpperLimit As Integer

    'Setting up variables for the print
    Dim mintNewPrintCounter As Integer
    Dim LogDate As Date = Date.Now
    Dim mstrDate As String
    Dim mstrProjectID As String


    Private Sub btnIssuedMenu_Click(sender As Object, e As EventArgs) Handles btnIssuedMenu.Click

        'this will show the Issue Inventory Menu
        LastTransaction.Show()
        IssueInventory.Show()
        Me.Close()

    End Sub

    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click

        'This will show the main menu
        LastTransaction.Show()
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        'This will close the program
        CloseProgram.ShowDialog()

    End Sub
    Private Function SetPartsDataBinding() As Boolean

        'Setting local variables
        Dim intCounter As Integer
        Dim intNumberOfRecords As Integer
        Dim blnFatalError As Boolean
        Dim blnItemNotFound As Boolean
        Dim blnNotATimeWarnerPartNumber As Boolean

        Try

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
            With cboPartNumber
                .DataSource = ThePartNumberBindingSource
                .DisplayMember = "PartNumber"
                .DataBindings.Add("text", ThePartNumberBindingSource, "PartNumber", False, DataSourceUpdateMode.Never)
            End With

            'Setting up the rest of the controls
            txtPartDescription.DataBindings.Add("text", ThePartNumberBindingSource, "Description")

            'Getting ready to fill the structure
            intNumberOfRecords = cboPartNumber.Items.Count - 1
            ReDim structParts(intNumberOfRecords)
            mintPartCounter = 0

            'Filling the structure
            For intCounter = 0 To intNumberOfRecords

                'incrementing the combo box
                cboPartNumber.SelectedIndex = intCounter

                blnNotATimeWarnerPartNumber = TheCheckTimeWarnerPartNumber.CheckPartNumber(cboPartNumber.Text)

                If blnNotATimeWarnerPartNumber = False Then

                    structParts(mintPartCounter).mstrPartNumber = cboPartNumber.Text
                    structParts(mintPartCounter).mstrDescription = txtPartDescription.Text
                    mintPartCounter += 1
                    blnItemNotFound = False

                End If

            Next

            'Setting up for returing to the the calling sub routine
            If blnItemNotFound = True Then
                blnFatalError = True
            Else
                blnFatalError = False
                mintPartUpperLimit = mintPartCounter - 1
                mintPartCounter = 0
            End If
            
            Return blnFatalError

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            blnFatalError = True
            Return blnFatalError

        End Try

    End Function

    Private Function SetIssuedTransactionDataBindings() As Boolean

        'Setting local variables
        Dim intCounter As Integer
        Dim intNumberOfRecords As Integer
        Dim intWarehouseIDForSearch As Integer
        Dim intWarehouseIDFromTable As Integer
        Dim blnFatalError As Boolean = False
        Dim blnItemNotFound As Boolean = True

        'try catch for exception
        Try

            TheIssuedPartsDataTier = New TWInventoryDataTier
            TheIssuedPartsDataSet = TheIssuedPartsDataTier.GetIssuedPartsInformation
            TheIssuedPartsBindingSource = New BindingSource

            'Setting up the binding source
            With TheIssuedPartsBindingSource
                .DataSource = TheIssuedPartsDataSet
                .DataMember = "IssuedParts"
                .MoveFirst()
                .MoveLast()
            End With

            'Setting up the combo box
            With cboTransactionID
                .DataSource = TheIssuedPartsBindingSource
                .DisplayMember = "TransactionID"
                .DataBindings.Add("text", TheIssuedPartsBindingSource, "TransactionID", False, DataSourceUpdateMode.Never)
            End With

            'Setting up the rest of the controls
            txtDate.DataBindings.Add("text", TheIssuedPartsBindingSource, "Date")
            txtPartNumber.DataBindings.Add("text", TheIssuedPartsBindingSource, "PartNumber")
            txtProjectID.DataBindings.Add("text", TheIssuedPartsBindingSource, "ProjectID")
            txtQuantity.DataBindings.Add("text", TheIssuedPartsBindingSource, "QTY")
            txtWarehouseID.DataBindings.Add("text", TheIssuedPartsBindingSource, "WarehouseID")

            'Getting ready to fill the array
            intNumberOfRecords = cboTransactionID.Items.Count - 1
            ReDim structIssuedTransactions(intNumberOfRecords)
            intWarehouseIDForSearch = CInt(Logon.mintPartsWarehouseID)
            ReDim structSearchResults(intNumberOfRecords)
            mintIssuedCounter = 0

            'Performing Loop
            For intCounter = 0 To intNumberOfRecords

                'Incrementing the combo box
                cboTransactionID.SelectedIndex = intCounter

                intWarehouseIDFromTable = CInt(txtWarehouseID.Text)

                If intWarehouseIDForSearch = intWarehouseIDFromTable Then

                    'filling array
                    structIssuedTransactions(mintIssuedCounter).mdatDate = CDate(txtDate.Text)
                    structIssuedTransactions(mintIssuedCounter).mintQuantity = CInt(txtQuantity.Text)
                    structIssuedTransactions(mintIssuedCounter).mstrPartNumber = txtPartNumber.Text
                    structIssuedTransactions(mintIssuedCounter).mstrProjectID = txtProjectID.Text
                    mintIssuedCounter += 1
                    blnItemNotFound = False

                End If
            Next

            If blnItemNotFound = True Then
                blnFatalError = True
            Else
                blnFatalError = False
                mintIssuedUpperLimit = mintIssuedCounter - 1
                mintIssuedCounter = 0
            End If

            Return blnFatalError

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            blnFatalError = True
            Return blnFatalError

        End Try

    End Function

    Private Sub ProjectIssuedTransactions_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim blnFatalError As Boolean = False

        PleaseWait.Show()



        blnFatalError = SetPartsDataBinding()
        If blnFatalError = False Then
            blnFatalError = SetIssuedTransactionDataBindings()
        End If

        If blnFatalError = True Then
            MessageBox.Show("There is Either a Binding Problem or No Items Were Found", "Thank You", MessageBoxButtons.OK, MessageBoxIcon.Error)
            btnFindProjectID.Enabled = False
            btnRunReport.Enabled = False
        Else
            'Creating Data Grive View
            dgvSearchResults.ColumnCount = 4
            dgvSearchResults.Columns(0).Name = "Date"
            dgvSearchResults.Columns(1).Name = "Part Number"
            dgvSearchResults.Columns(2).Name = "Description"
            dgvSearchResults.Columns(3).Name = "Quantity"
            dgvSearchResults.Visible = False
            MakeControlsVisible(False)
        End If

        PleaseWait.Close()

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
    Private Sub btnFindProjectID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFindProjectID.Click

        'This will find all items that have been received for a project
        Dim intCounter As Integer
        Dim strProjectIDForSearch As String
        Dim strProjectIDFromTable As String
        Dim blnFatalError As Boolean = False
        Dim blnItemNotFound As Boolean = True
        Dim strPartDescription As String
        Dim row() As String

        btnRunReport.Enabled = False

        'Performing data validation
        strProjectIDForSearch = txtFindProjectID.Text
        blnFatalError = TheInputDataValidation.VerifyTextData(strProjectIDForSearch)
        If blnFatalError = True Then
            MessageBox.Show("The Project ID Was Not Entered", "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        dgvSearchResults.Visible = True
        dgvSearchResults.Rows.Clear()
        mstrProjectID = strProjectIDForSearch

        'getting ready for the loop
        mintResultsCounter = 0

        'Performing the loop
        For intCounter = 0 To mintIssuedUpperLimit

            'Getting the project id from the table
            strProjectIDFromTable = structIssuedTransactions(intCounter).mstrProjectID

            If strProjectIDForSearch = strProjectIDFromTable Then

                'loading the structure and gridview
                structSearchResults(mintResultsCounter).mdatDate = structIssuedTransactions(intCounter).mdatDate
                structSearchResults(mintResultsCounter).mintQuantity = structIssuedTransactions(intCounter).mintQuantity
                structSearchResults(mintResultsCounter).mstrPartNumber = structIssuedTransactions(intCounter).mstrPartNumber
                strPartDescription = FindPartDescription(structSearchResults(mintResultsCounter).mstrPartNumber)
                structSearchResults(mintResultsCounter).mstrProjectID = structIssuedTransactions(intCounter).mstrProjectID
                row = New String() {CStr(structSearchResults(mintResultsCounter).mdatDate), structSearchResults(mintResultsCounter).mstrPartNumber, strPartDescription, CStr(structSearchResults(mintResultsCounter).mintQuantity)}
                dgvSearchResults.Rows.Add(row)
                mintResultsCounter += 1
                blnItemNotFound = False

            End If

        Next

        If blnItemNotFound = True Then
            dgvSearchResults.Visible = False
            txtFindProjectID.Text = ""
            MessageBox.Show("The Project ID Entered Was Not Found", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            mintResultsUpperLimit = mintResultsCounter - 1
            txtFindProjectID.Text = ""
        End If

        btnRunReport.Enabled = True
    End Sub
    Private Function FindPartDescription(ByVal strPartNumberForSearch As String) As String

        Dim intCounter As Integer
        Dim strPartNumberFromTable As String
        Dim strPartDescription As String = ""

        'Beginning Loop
        For intCounter = 0 To mintPartUpperLimit

            'Getting part number
            strPartNumberFromTable = structParts(intCounter).mstrPartNumber

            If strPartNumberForSearch = strPartNumberFromTable Then
                strPartDescription = structParts(intCounter).mstrDescription
                Exit For
            End If

        Next

        'Value returned to calling subroutines
        Return strPartDescription

    End Function

    
    Private Sub MakeControlsVisible(ByVal valueBoolean As Boolean)

        'This will make the controls visible
        txtPartDescription.Visible = valueBoolean
        txtPartNumber.Visible = valueBoolean
        txtProjectID.Visible = valueBoolean
        txtQuantity.Visible = valueBoolean
        txtDate.Visible = valueBoolean
        txtWarehouseID.Visible = valueBoolean

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
        PrintX = 150
        e.Graphics.DrawString("Blue Jay Communications Inventory Report", PrintHeaderFont, Brushes.Black, PrintX, PrintY)
        PrintY = PrintY + HeadingLineHeight
        PrintX = 180
        e.Graphics.DrawString("Project Part Issued For Project:  " + mstrProjectID, PrintSubHeaderFont, Brushes.Black, PrintX, PrintY)
        PrintY = PrintY + HeadingLineHeight

        'Setting up the columns
        PrintX = 50
        e.Graphics.DrawString("Date", PrintItemsFont, Brushes.Black, PrintX, PrintY)
        PrintX = 220
        e.Graphics.DrawString("Part Number", PrintItemsFont, Brushes.Black, PrintX, PrintY)
        PrintX = 350
        e.Graphics.DrawString("Part Description", PrintItemsFont, Brushes.Black, PrintX, PrintY)
        PrintX = 700
        e.Graphics.DrawString("QTY", PrintItemsFont, Brushes.Black, PrintX, PrintY)
        PrintY = PrintY + HeadingLineHeight

        'Setting up for multiple pages
        intStartingPageCounter = mintNewPrintCounter
        intNumberOfRecords = mintResultsUpperLimit

        'Setting the upper limit
        For intCounter = intStartingPageCounter To mintResultsUpperLimit

            PrintX = 50
            e.Graphics.DrawString(CStr(structSearchResults(intCounter).mdatDate), PrintItemsFont, Brushes.Black, PrintX, PrintY)
            PrintX = 220
            e.Graphics.DrawString(structSearchResults(intCounter).mstrPartNumber, PrintItemsFont, Brushes.Black, PrintX, PrintY)
            PrintX = 350
            strPartDescription = FindPartDescription(structSearchResults(intCounter).mstrPartNumber)

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

            e.Graphics.DrawString(strPartDescription, PrintItemsFont, Brushes.Black, PrintX, PrintY)
            PrintX = 700
            e.Graphics.DrawString(CStr(structSearchResults(intCounter).mintQuantity), PrintItemsFont, Brushes.Black, PrintX, PrintY)
            PrintY = PrintY + ItemLineHeight

            If PrintY > 900 Then
                If intStartingPageCounter = intNumberOfRecords Then
                    e.HasMorePages = False
                Else
                    e.HasMorePages = True
                    blnNewPage = True
                End If
            End If

            If blnNewPage = True Then
                mintNewPrintCounter = intCounter + 1
                intCounter = intNumberOfRecords
            End If
        Next

    End Sub
End Class