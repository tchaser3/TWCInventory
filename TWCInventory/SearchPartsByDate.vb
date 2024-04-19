'Title:         Search Parts By Date
'Date:          7-9-15
'Author:        Terry Holmes

'Descriptioh:   This form is used as a Date Search

Option Strict On

Public Class SearchPartsByDate

    Private TheReceivedPartsDataTier As TWInventoryDataTier
    Private TheReceivedPartsDataSet As ReceivedPartsDataSet
    Private WithEvents TheReceivedPartsBindingSource As BindingSource

    Private ThePartNumberDataSet As PartNumberDataSet
    Private ThePartNumberDataTier As PartsDataTier
    Private WithEvents ThePartNumberBindingSource As BindingSource

    Dim TheDateSearchClass As New DateSearchClass

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

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        CloseProgram.ShowDialog()

    End Sub

    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click

        'this will load the main menu
        LastTransaction.Show()
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub btnReceiveMenu_Click(sender As Object, e As EventArgs) Handles btnReceiveMenu.Click

        'This will load the receive menu
        LastTransaction.Show()
        ReceiveMenu.Show()
        Me.Close()

    End Sub

    Private Sub btnResetDateRange_Click(sender As Object, e As EventArgs) Handles btnResetDateRange.Click

        Logon.mstrButtonPressed = "RECEIVE TRANSACTIONS"
        DateRangeEntered.Show()
        Me.Close()

    End Sub

    Private Sub SearchPartsByDate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'This will load the controls
        'setting local variables
        Dim intCounter As Integer
        Dim intNumberOfRecords As Integer
        Dim datStartingDateForSearch As Date
        Dim datEndingDateForSearch As Date
        Dim datSearchDate As Date
        Dim datFormDate As Date
        Dim blnDateNotFound As Boolean = True
        Dim intWarehouseIDForSearch As Integer
        Dim intWarehouseIDFromTable As Integer

        Logon.mstrLastTransactionSummary = "LOADED SEARCH PARTS BY DATE"

        Try

            PleaseWait.Show()

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
            datStartingDateForSearch = TheDateSearchClass.RemoveTime(Logon.mdatStartingDate)
            datEndingDateForSearch = TheDateSearchClass.RemoveTime(Logon.mdatEndingDate)
            mintCounter = 0
            intWarehouseIDForSearch = Logon.mintPartsWarehouseID

            'beginning loop
            For intCounter = 0 To intNumberOfRecords

                'incrementing the combo box
                cboTransactionID.SelectedIndex = intCounter

                'getting dates
                datFormDate = CDate(txtDate.Text)
                datSearchDate = TheDateSearchClass.RemoveTime(datFormDate)
                intWarehouseIDFromTable = CInt(txtWarehouseID.Text)

                If intWarehouseIDForSearch = intWarehouseIDFromTable Then
                    If datStartingDateForSearch <= datSearchDate And datEndingDateForSearch >= datSearchDate Then
                        mintSelectedIndex(mintCounter) = intCounter
                        mintCounter += 1
                        blnDateNotFound = False
                    End If
                End If
            Next

            If blnDateNotFound = True Then
                PleaseWait.Close()
                MessageBox.Show("Date Range Entered Was Not Found", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Logon.mstrButtonPressed = "RECEIVE TRANSACTIONS"
                ReceiveMenu.Show()
                Me.Close()
            End If

            mintUpperLimit = mintCounter - 1
            mintCounter = 0
            cboTransactionID.SelectedIndex = mintSelectedIndex(0)
            FillPartsStructure()
            SetControlsVisible(False)
            PleaseWait.Close()

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

    Private Sub PrintDocument1_QueryPageSettings(sender As Object, e As Printing.QueryPageSettingsEventArgs) Handles PrintDocument1.QueryPageSettings

        'setting the document to landscape
        e.PageSettings.Landscape = True

    End Sub

    Private Sub btnRunReport_Click(sender As Object, e As EventArgs) Handles btnRunReport.Click

        SetControlsVisible(True)

        'This will set up for the report
        PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings

        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
        End If

        mintNewPrintCounter = 0

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

        SetControlsVisible(True)

        'Setting up for default position
        PrintY = 100

        'Setting up for the print header
        PrintX = 280
        e.Graphics.DrawString("Blue Jay Communications Inventory Report", PrintHeaderFont, Brushes.Black, PrintX, PrintY)
        PrintY = PrintY + HeadingLineHeight
        PrintX = 292
        e.Graphics.DrawString("Project Part Receive Log For Warehouse ID:  " + CStr(Logon.mintPartsWarehouseID), PrintSubHeaderFont, Brushes.Black, PrintX, PrintY)
        PrintY = PrintY + HeadingLineHeight
        PrintX = 280
        e.Graphics.DrawString("For Material Recieved Between " + CStr(Logon.mdatStartingDate) + " and " + CStr(Logon.mdatEndingDate), PrintSubHeaderFont, Brushes.Black, PrintX, PrintY)
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
        For intCounter = intStartingPageCounter To mintUpperLimit

            cboTransactionID.SelectedIndex = mintSelectedIndex(intCounter)


            PrintX = 50
            e.Graphics.DrawString(txtDate.Text, PrintItemsFont, Brushes.Black, PrintX, PrintY)
            PrintX = 220
            e.Graphics.DrawString(txtProjectID.Text, PrintItemsFont, Brushes.Black, PrintX, PrintY)
            PrintX = 350
            e.Graphics.DrawString(txtMSRNumber.Text, PrintItemsFont, Brushes.Black, PrintX, PrintY)
            PrintX = 500
            e.Graphics.DrawString(txtPartNumber.Text, PrintItemsFont, Brushes.Black, PrintX, PrintY)

            'Finding the part description
            strPartNumberForSearch = txtPartNumber.Text

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

            PrintX = 650
            e.Graphics.DrawString(strPartDescription, PrintItemsFont, Brushes.Black, PrintX, PrintY)
            PrintX = 950
            e.Graphics.DrawString(txtQuantity.Text, PrintItemsFont, Brushes.Black, PrintX, PrintY)
            PrintY = PrintY + ItemLineHeight

            If intCharacterCount = intNumberOfRecords Then

            End If

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

        SetControlsVisible(False)

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
    
End Class