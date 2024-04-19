'Title:         Print Pick List
'Date:          3-20-15
'Author:        Terry Holmes

'Description:   This form will print the pick list

Option Strict On

Public Class PrintPickList

    'Setting up the data variables
    Private ThePickListDataTier As PickListDataTier
    Private ThePickListDataSet As PickListDataSet
    Private WithEvents ThePickListBindingSource As BindingSource

    Private ThePickListTransactionsDataTier As PickListDataTier
    Private ThePickListTransactionsDataSet As PickListTransactionsDataSet
    Private WithEvents ThePickListTransactionsBindingSource As BindingSource

    Private ThePartNumberDataTier As PartsDataTier
    Private ThePartNumberDataSet As PartNumberDataSet
    Private WithEvents ThePartNumberBindingSource As BindingSource

    Private addingBoolean As Boolean = False
    Private editingBoolean As Boolean = False

    Dim mintNewPrintCounter As Integer

    Private Sub PrintPickList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Setting local variables
        Dim intPickListCounter As Integer
        Dim intPickListNumberOfRecords As Integer
        Dim intPicklistSelectedIndex As Integer
        Dim intPickListIDForSearch As Integer
        Dim intPickListIDFromTable As Integer

        'try Catch during form load
        Try

            'Setting up the global data variables
            ThePartNumberDataTier = New PartsDataTier
            ThePartNumberDataSet = ThePartNumberDataTier.GetPartNumberInformation
            ThePartNumberBindingSource = New BindingSource

            ThePickListTransactionsDataTier = New PickListDataTier
            ThePickListTransactionsDataSet = ThePickListTransactionsDataTier.GetPickListTransactionsInformation
            ThePickListTransactionsBindingSource = New BindingSource

            ThePickListDataTier = New PickListDataTier
            ThePickListDataSet = ThePickListDataTier.GetPickListInformation
            ThePickListBindingSource = New BindingSource

            'Setting up the binding sources
            With ThePartNumberBindingSource
                .DataSource = ThePartNumberDataSet
                .DataMember = "partnumbers"
                .MoveFirst()
                .MoveLast()
            End With

            With ThePickListBindingSource
                .DataSource = ThePickListDataSet
                .DataMember = "picklist"
                .MoveFirst()
                .MoveLast()
            End With

            With ThePickListTransactionsBindingSource
                .DataSource = ThePickListTransactionsDataSet
                .DataMember = "picklisttransactions"
                .MoveFirst()
                .MoveLast()
            End With

            'Setting up the combo box
            With cboPartID
                .DataSource = ThePartNumberBindingSource
                .DisplayMember = "PartID"
                .DataBindings.Add("text", ThePartNumberBindingSource, "PartID", False, DataSourceUpdateMode.Never)
            End With

            With cboTransactionID
                .DataSource = ThePickListTransactionsBindingSource
                .DisplayMember = "TransactionID"
                .DataBindings.Add("text", ThePickListTransactionsBindingSource, "TransactionID", False, DataSourceUpdateMode.Never)
            End With

            With cboPickListID
                .DataSource = ThePickListBindingSource
                .DisplayMember = "PicklistID"
                .DataBindings.Add("text", ThePickListBindingSource, "PicklistID", False, DataSourceUpdateMode.Never)
            End With

            'Setting up the rest of the controls
            txtTablePartNumber.DataBindings.Add("text", ThePartNumberBindingSource, "PartNumber")
            txtPartDescription.DataBindings.Add("text", ThePartNumberBindingSource, "Description")

            txtPickListID.DataBindings.Add("text", ThePickListTransactionsBindingSource, "PickListID")
            txtPartNumber.DataBindings.Add("text", ThePickListTransactionsBindingSource, "PartNumber")
            txtQuantity.DataBindings.Add("Text", ThePickListTransactionsBindingSource, "Quantity")

            txtProjectID.DataBindings.Add("text", ThePickListBindingSource, "ProjectID")
            txtMSRNumber.DataBindings.Add("text", ThePickListBindingSource, "MSRNumber")
            txtDate.DataBindings.Add("text", ThePickListBindingSource, "Date")
            txtOrderIssued.DataBindings.Add("text", ThePickListBindingSource, "OrderIssued")

            'Beginning search for the pick list
            intPickListNumberOfRecords = cboPickListID.Items.Count - 1
            intPickListIDForSearch = CInt(Logon.mintPickListID)

            'beginning loop
            For intPickListCounter = 0 To intPickListNumberOfRecords

                'incrementing the combo box
                cboPickListID.SelectedIndex = intPickListCounter

                'Getting the pick list id
                intPickListIDFromTable = CInt(cboPickListID.Text)

                'If statements checking the id
                If intPickListIDForSearch = intPickListIDFromTable Then
                    intPicklistSelectedIndex = intPickListCounter
                End If
            Next

            'setting the pick list selected index
            cboPickListID.SelectedIndex = intPicklistSelectedIndex

            If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
            End If

            Logon.mstrLastTransactionSummary = "RAN PICK LIST REPORT FOR PICK LIST ID " + CStr(intPickListIDForSearch)

            'Setting up for multiple pages
            mintNewPrintCounter = 0

            'Calling the print document
            PrintDocument1.Print()

        Catch ex As Exception

            'Message to user
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try


    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        'Setting up the local variables
        Dim intTransactionCounter As Integer
        Dim intTransactionNumberOfRecords As Integer
        Dim intPartCounter As Integer
        Dim intPartNumberOfRecords As Integer
        Dim intPicklistIDForSearch As Integer
        Dim intPicklistIDFromTable As Integer
        Dim strPartNumberForSearch As String
        Dim strPartNumberFromTable As String
        Dim intPartSelectedIndex As Integer
        Dim intStartingPageCounter As Integer
        Dim blnNewPage As Boolean = False
        Dim strProjectID As String
        Dim strMSRNumber As String
        Dim blnItemNotFound As Boolean

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

        'Getting the string variable
        strProjectID = txtProjectID.Text
        strMSRNumber = txtMSRNumber.Text
        intPicklistIDForSearch = CInt(cboPickListID.Text)


        'Setting up for default position
        PrintY = 100

        'Setting up for the print header
        PrintX = 150
        e.Graphics.DrawString("Blue Jay Communications Inventory Report", PrintHeaderFont, Brushes.Black, PrintX, PrintY)
        PrintY = PrintY + HeadingLineHeight
        PrintX = 162
        e.Graphics.DrawString("Pick List for MSR:  " + strMSRNumber + " And Project " + strProjectID, PrintSubHeaderFont, Brushes.Black, PrintX, PrintY)
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
        intTransactionNumberOfRecords = cboTransactionID.Items.Count - 1
        intPartNumberOfRecords = cboPartID.Items.Count - 1

        'Beginning the loop
        For intTransactionCounter = intStartingPageCounter To intTransactionNumberOfRecords

            'incrementing the counter
            cboTransactionID.SelectedIndex = intTransactionCounter

            'getting the pick list id
            intPicklistIDFromTable = CInt(txtPickListID.Text)

            blnItemNotFound = True

            If intPicklistIDForSearch = intPicklistIDFromTable Then

                'setting up for the second loop
                strPartNumberForSearch = txtPartNumber.Text

                'beginning the second loop
                For intPartCounter = 0 To intPartNumberOfRecords

                    'incrementing the combo box
                    cboPartID.SelectedIndex = intPartCounter

                    'getting part number
                    strPartNumberFromTable = txtTablePartNumber.Text

                    'If statements to see if they match
                    If strPartNumberForSearch = strPartNumberFromTable Then

                        'Setting the value of the variable
                        intPartSelectedIndex = intPartCounter
                        blnItemNotFound = False

                    End If
                Next
            End If

            If blnItemNotFound = False Then
                'setting the combo box
                cboPartID.SelectedIndex = intPartSelectedIndex

                'Printing out
                PrintX = 100
                e.Graphics.DrawString(txtPartNumber.Text, PrintItemsFont, Brushes.Black, PrintX, PrintY)
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
                e.Graphics.DrawString(txtQuantity.Text, PrintItemsFont, Brushes.Black, PrintX, PrintY)
                PrintY = PrintY + ItemLineHeight

                If PrintY > 900 Then
                    If intStartingPageCounter = intTransactionNumberOfRecords Then
                        e.HasMorePages = False
                    Else
                        e.HasMorePages = True
                        blnNewPage = True
                    End If
                End If

                If blnNewPage = True Then
                    mintNewPrintCounter = intTransactionCounter + 1
                    intTransactionCounter = intTransactionNumberOfRecords
                End If
            End If
        Next

        Me.Close()

    End Sub
End Class