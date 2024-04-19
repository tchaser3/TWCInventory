'Title:         On Hand Report Form
'Date:          11-28-14
'Author:        Terry Holmes

'Description:   This form will process the On Hand Report

Public Class OnHandReport

    Private TheWarehouseInventoryDataTier As TWInventoryDataTier
    Private TheWarehouseInventoryDataSet As WarehouseInventoryDataSet
    Private WithEvents TheWarehouseInventoryBindingSource As BindingSource

    Private addingBoolean As Boolean = False
    Private editingBoolean As Boolean = False
    Private previouseSelectedIndex As Integer

    Dim TheInputDataValidation As New InputDataValidation

    Dim mintNewPrintCounter As Integer
    Dim LogDate As Date = Date.Now
    Dim mstrDate As String

    Private Sub btnReportMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReportMenu.Click

        'This will display the Report Menu
        ClearDataBindings()
        LastTransaction.Show()
        ReportMenu.Show()
        Me.Close()

    End Sub

    Private Sub btnMainMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMainMenu.Click

        'This will display the main menu
        LastTransaction.Show()
        ClearDataBindings()
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        'This will display the confirmation
        CloseProgram.ShowDialog()

    End Sub

    Private Sub OnHandReport_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Try Catch to Load Form
        Try

            'Setting up the data variables
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
            With cboPartNumber
                .DataSource = TheWarehouseInventoryBindingSource
                .DisplayMember = "PartNumber"
                .DataBindings.Add("text", TheWarehouseInventoryBindingSource, "PartNumber", False, DataSourceUpdateMode.Never)
            End With

            'Setting up the rest of the controls
            txtPartID.DataBindings.Add("text", TheWarehouseInventoryBindingSource, "PartID")
            txtPartDescription.DataBindings.Add("text", TheWarehouseInventoryBindingSource, "PartDescription")
            txtQTYResponible.DataBindings.Add("text", TheWarehouseInventoryBindingSource, "QTYOnHand")

            Logon.mstrLastTransactionSummary = "LOADED ON-HAND INVENTORY REPORT"
            LastTransaction.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub ClearDataBindings()

        'This will clear the data bindings
        cboPartNumber.DataBindings.Clear()
        txtPartDescription.DataBindings.Clear()
        txtPartID.DataBindings.Clear()
        txtQTYResponible.DataBindings.Clear()

    End Sub

    Private Sub btnRunReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRunReport.Click

        'Setting up the print dialog
        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
        End If

        Logon.mstrLastTransactionSummary = "RAN ON HAND INVENTORY REPORT"

        'Setting up for multiple pages
        mintNewPrintCounter = 0

        'Calling the print document
        PrintDocument1.Print()

    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

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
        Dim intCharacterLimit As Integer = 50
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
        PrintX = 162
        e.Graphics.DrawString("On Hand Inventory Report For:  " + mstrDate, PrintSubHeaderFont, Brushes.Black, PrintX, PrintY)
        PrintY = PrintY + HeadingLineHeight

        'Setting up the columns
        PrintX = 100
        e.Graphics.DrawString("Part Number", PrintItemsFont, Brushes.Black, PrintX, PrintY)
        PrintX = 250
        e.Graphics.DrawString("Part Description", PrintItemsFont, Brushes.Black, PrintX, PrintY)
        PrintX = 700
        e.Graphics.DrawString("QTY", PrintItemsFont, Brushes.Black, PrintX, PrintY)
        PrintY = PrintY + HeadingLineHeight

        'Setting up for multiple pages
        intStartingPageCounter = mintNewPrintCounter

        'Setting the upper limit
        intNumberOfRecords = cboPartNumber.Items.Count - 1

        'Beginning the loop
        For intCounter = intStartingPageCounter To intNumberOfRecords

            'incrementing the counter
            cboPartNumber.SelectedIndex = intCounter

            'Printing out
            PrintX = 100
            e.Graphics.DrawString(cboPartNumber.Text, PrintItemsFont, Brushes.Black, PrintX, PrintY)
            PrintX = 250

            'Setting up to limit the description size
            strPartDescription = txtPartDescription.Text
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
            e.Graphics.DrawString(txtQTYResponible.Text, PrintItemsFont, Brushes.Black, PrintX, PrintY)
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