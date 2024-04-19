'Title:         Add Parts To Inventory
'Date:          12-1-14
'Author:        Terry Holmes

'Description:   This will allow the user to create part numbers

Option Strict On

Public Class AddPartsToInventory

    Private ThePartNumberDataSet As PartNumberDataSet
    Private ThePartNumberDataTier As PartsDataTier
    Private WithEvents ThePartNumberBindingSource As BindingSource

    Private addingBoolean As Boolean = False
    Private editingBoolean As Boolean = False
    Private previouseSelectedIndex As Integer

    Dim TheInputDataValidation As New InputDataValidation
    Dim TheCheckTimeWarnerPartNumber As New CheckTimeWarnerPartNumber
    Dim TheKeyWordSearch As New KeyWordSearchClass

    Structure Parts
        Dim mintPartID As Integer
        Dim mstrPartNumber As String
        Dim mstrDescription As String
    End Structure

    Dim structCurrentParts() As Parts
    Dim mintCurrentCounter As Integer
    Dim mintCurrentUpperLimit As Integer

    Dim structNewParts() As Parts
    Dim mintNewCounter As Integer
    Dim mintNewUpperLimit As Integer

    Dim structSearchResults() As Parts
    Dim mintResultCounter As Integer
    Dim mintResultUpperLimit As Integer
    Dim mintNewPrintCounter As Integer
    Dim mblnNewRecordCreated As Boolean

    Private Sub SetComboBoxBinding()

        'This will set the combo box bindings
        With cboPartID
            If (addingBoolean Or editingBoolean) Then
                .DataBindings!text.DataSourceUpdateMode = DataSourceUpdateMode.OnValidation
                .DropDownStyle = ComboBoxStyle.Simple
            Else
                .DataBindings!text.DataSourceUpdateMode = DataSourceUpdateMode.Never
                .DropDownStyle = ComboBoxStyle.DropDownList
            End If
        End With

    End Sub

    Private Sub AddPartsToInventory_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Logon.mstrLastTransactionSummary = "LOADED ADD PARTS FORM"

        'setting local variables
        Dim intCounter As Integer
        Dim intNumberOfRecords As Integer
        Dim blnNotTimeWarnerPart As Boolean
        Dim blnNoTimeWarnerPartsFound As Boolean = True

        PleaseWait.Show()

        'try catch to catch exceptions
        Try

            'Setting up global databases
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
            With cboPartID
                .DataSource = ThePartNumberBindingSource
                .DisplayMember = "PartID"
                .DataBindings.Add("text", ThePartNumberBindingSource, "PartID", False, DataSourceUpdateMode.Never)
            End With

            'Setting up the rest of the controls
            txtActive.DataBindings.Add("text", ThePartNumberBindingSource, "Active")
            txtPartDescription.DataBindings.Add("text", ThePartNumberBindingSource, "Description")
            txtPartNumber.DataBindings.Add("text", ThePartNumberBindingSource, "PartNumber")
            txtPrice.DataBindings.Add("Text", ThePartNumberBindingSource, "Price")
            txtTimeWarnerPart.DataBindings.Add("text", ThePartNumberBindingSource, "TimeWarnerPart")

            'setting up to load structure
            intNumberOfRecords = cboPartID.Items.Count - 1
            ReDim structCurrentParts(intNumberOfRecords)
            ReDim structNewParts(intNumberOfRecords)
            ReDim structSearchResults(intNumberOfRecords * 2)
            mintNewCounter = 0
            mintNewUpperLimit = 0
            mintCurrentCounter = 0

            'Load to load structure
            For intCounter = 0 To intNumberOfRecords

                'incrementing the combo box
                cboPartID.SelectedIndex = intCounter

                blnNotTimeWarnerPart = TheCheckTimeWarnerPartNumber.CheckPartNumber(txtPartNumber.Text)

                If blnNotTimeWarnerPart = False Then
                    structCurrentParts(mintCurrentCounter).mintPartID = CInt(cboPartID.Text)
                    structCurrentParts(mintCurrentCounter).mstrPartNumber = txtPartNumber.Text
                    structCurrentParts(mintCurrentCounter).mstrDescription = txtPartDescription.Text
                    mintCurrentCounter += 1
                    blnNoTimeWarnerPartsFound = False
                End If
            Next

            'checking to see if parts were found
            If blnNoTimeWarnerPartsFound = False Then
                mintCurrentUpperLimit = mintCurrentCounter - 1
                mintCurrentCounter = 0
            End If

            'creating the gridview
            dgvSearchResults.ColumnCount = 3
            dgvSearchResults.Columns(0).Name = "Part ID"
            dgvSearchResults.Columns(0).Width = 75
            dgvSearchResults.Columns(1).Name = "Part Number"
            dgvSearchResults.Columns(1).Width = 75
            dgvSearchResults.Columns(2).Name = "Description"
            dgvSearchResults.Columns(2).Width = 300

            SetControlsReadOnly(True)
            cboPartID.SelectedIndex = 0
            dgvSearchResults.Visible = False
            btnPartNumberReport.Enabled = False
            mblnNewRecordCreated = False

            PleaseWait.Close()

        Catch ex As Exception

            'Message to user
            PleaseWait.Close()
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        'Setting local variables
        Dim strValueForValidation As String
        Dim strErrorMessage As String = ""
        Dim blnThereIsAProblem As Boolean = False
        Dim blnFatalError As Boolean = False

        dgvSearchResults.Visible = False
        dgvSearchResults.Visible = False

        If btnAdd.Text = "Add" Then

            'Setting up the binding source
            With ThePartNumberBindingSource
                .EndEdit()
                .AddNew()
            End With

            'Setting up the varibles and controls
            addingBoolean = True
            SetComboBoxBinding()
            SetControlsReadOnly(False)
            If cboPartID.SelectedIndex <> -1 Then
                previouseSelectedIndex = cboPartID.Items.Count - 1
            Else
                previouseSelectedIndex = 0
            End If
            PartNumbersID.Show()
            cboPartID.Text = CStr(Logon.mintCreatedTransactionID)
            txtActive.Text = "YES"
            txtPrice.Text = "0.00"
            txtTimeWarnerPart.Text = "YES"
            btnAdd.Text = "Save"
           
        Else

            'this will begin the saving function
            'Beginning Data Validation
            strValueForValidation = txtPartNumber.Text
            blnFatalError = TheInputDataValidation.VerifyTextData(strValueForValidation)
            If blnFatalError = True Then
                blnThereIsAProblem = True
                strErrorMessage = strErrorMessage + "The Part Number Was Not Entered" + vbNewLine
            ElseIf blnFatalError = False Then
                blnFatalError = TheCheckTimeWarnerPartNumber.CheckPartNumber(strValueForValidation)
                If blnFatalError = True Then
                    blnThereIsAProblem = True
                    strErrorMessage = strErrorMessage + "The Part Number Entered is not a Time Warner Part Number" + vbNewLine
                End If
            End If


            strValueForValidation = txtPartDescription.Text
            blnFatalError = TheInputDataValidation.VerifyTextData(strValueForValidation)
            If blnFatalError = True Then
                blnThereIsAProblem = True
                strErrorMessage = strErrorMessage + "The Part Description Was Not Entered" + vbNewLine
            End If


            'Output to user if there is a problem
            If blnThereIsAProblem = True Then
                MessageBox.Show(strErrorMessage, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            'Validate Part Number
            Logon.mstrPartNumber = txtPartNumber.Text
            CheckForDuplicatePartNumber.Show()

            'Output to user if there a duplicate already in system
            If Logon.mblnPartNumberExists = True Then

                MessageBox.Show("Part Number Entered Currently Exists", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub

            End If

            structNewParts(mintNewCounter).mintPartID = CInt(cboPartID.Text)
            structNewParts(mintNewCounter).mstrDescription = txtPartDescription.Text
            structNewParts(mintNewCounter).mstrPartNumber = txtPartNumber.Text
            mintNewCounter += 1
            mblnNewRecordCreated = True

            'Saving Information
            Try

                'setting the data variables
                ThePartNumberBindingSource.EndEdit()
                ThePartNumberDataTier.UpdatePartNumberDB(ThePartNumberDataSet)
                editingBoolean = False
                addingBoolean = False
                SetComboBoxBinding()
                cboPartID.SelectedIndex = previouseSelectedIndex
                SetControlsReadOnly(True)
                btnAdd.Text = "Add"

            Catch ex As Exception

                'Output to user if there is a problem
                MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try
        End If

    End Sub
    Private Sub SetControlsReadOnly(ByVal valueBoolean As Boolean)

        'This will set the controls to read only
        txtPartDescription.ReadOnly = valueBoolean
        txtPartNumber.ReadOnly = valueBoolean

    End Sub
    Private Sub ClearDataBindings()

        'This will close the data bindings
        cboPartID.DataBindings.Clear()
        txtPartDescription.DataBindings.Clear()
        txtPartNumber.DataBindings.Clear()
        txtTimeWarnerPart.DataBindings.Clear()
        txtPrice.DataBindings.Clear()
        txtActive.DataBindings.Clear()

    End Sub

    Private Sub btnMainMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMainMenu.Click

        'Calls the main form
        LastTransaction.Show()
        Form1.Show()
        Me.Hide()

    End Sub
    
    Private Sub btnAdministrationMenu_Click(sender As Object, e As EventArgs) Handles btnAdministrationMenu.Click

        'this opens the admin menu
        LastTransaction.Show()
        AdminMenu.Show()
        Me.Close()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        'This will close the program
        CloseProgram.ShowDialog()

    End Sub

    Private Sub btnPartNumberReport_Click(sender As Object, e As EventArgs) Handles btnPartNumberReport.Click

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

        'Setting up for default position
        PrintY = 100

        'Setting up for the print header
        PrintX = 150
        e.Graphics.DrawString("Blue Jay Communications Inventory Report", PrintHeaderFont, Brushes.Black, PrintX, PrintY)
        PrintY = PrintY + HeadingLineHeight
        PrintX = 325
        e.Graphics.DrawString("Part Number Listing", PrintSubHeaderFont, Brushes.Black, PrintX, PrintY)
        PrintY = PrintY + HeadingLineHeight

        'Setting up the columns
        PrintX = 50
        e.Graphics.DrawString("Part ID", PrintItemsFont, Brushes.Black, PrintX, PrintY)
        PrintX = 150
        e.Graphics.DrawString("Part Number", PrintItemsFont, Brushes.Black, PrintX, PrintY)
        PrintX = 300
        e.Graphics.DrawString("Description", PrintItemsFont, Brushes.Black, PrintX, PrintY)
        PrintY = PrintY + HeadingLineHeight

        'Setting up for multiple pages
        intStartingPageCounter = mintNewPrintCounter
        intNumberOfRecords = mintResultUpperLimit

        For intCounter = intStartingPageCounter To mintResultUpperLimit

            PrintX = 50
            e.Graphics.DrawString(CStr(structSearchResults(intCounter).mintPartID), PrintItemsFont, Brushes.Black, PrintX, PrintY)
            PrintX = 150
            e.Graphics.DrawString(CStr(structSearchResults(intCounter).mstrPartNumber), PrintItemsFont, Brushes.Black, PrintX, PrintY)
            PrintX = 300
            e.Graphics.DrawString(structSearchResults(intCounter).mstrDescription, PrintItemsFont, Brushes.Black, PrintX, PrintY)
            PrintX = 450
            PrintY = PrintY + ItemLineHeight

            If PrintY > 950 Then
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
    Private Sub FindAllParts()

        Dim intCurrentCounter As Integer
        Dim intNewCounter As Integer

        'loading up the search results structure
        mintResultCounter = 0

        For intCurrentCounter = 0 To mintCurrentUpperLimit

            structSearchResults(mintResultCounter).mintPartID = structCurrentParts(intCurrentCounter).mintPartID
            structSearchResults(mintResultCounter).mstrDescription = structCurrentParts(intCurrentCounter).mstrDescription
            structSearchResults(mintResultCounter).mstrPartNumber = structCurrentParts(intCurrentCounter).mstrPartNumber
            mintResultCounter += 1

        Next

        For intNewCounter = 0 To mintNewUpperLimit

            structSearchResults(mintResultCounter).mintPartID = structNewParts(intNewCounter).mintPartID
            structSearchResults(mintResultCounter).mstrDescription = structNewParts(intNewCounter).mstrDescription
            structSearchResults(mintResultCounter).mstrPartNumber = structNewParts(intNewCounter).mstrPartNumber
            mintResultCounter += 1

        Next

        mintResultUpperLimit = mintResultCounter - 1
        mintResultCounter = 0

    End Sub
    Private Sub LoadDataGrid()

        Dim intCounter As Integer
        Dim rows() As String

        dgvSearchResults.Rows.Clear()

        'running loop
        For intCounter = 0 To mintResultUpperLimit

            rows = New String() {CStr(structSearchResults(intCounter).mintPartID), structSearchResults(intCounter).mstrPartNumber, structSearchResults(intCounter).mstrDescription}
            dgvSearchResults.Rows.Add(rows)

        Next
    End Sub

    Private Sub btnFindAllParts_Click(sender As Object, e As EventArgs) Handles btnFindAllParts.Click

        dgvSearchResults.Visible = True
        FindAllParts()
        LoadDataGrid()
        btnPartNumberReport.Enabled = True

    End Sub

    Private Sub btnFindSpecificParts_Click(sender As Object, e As EventArgs) Handles btnFindSpecificParts.Click

        'this is used to search for with a keyword or part number
        Dim intCurrentCounter As Integer
        Dim intNewCounter As Integer
        Dim strPartNumberForSearch As String
        Dim strPartNumberFromTable As String
        Dim strDescriptionForSearch As String = ""
        Dim strDescriptionFromTable As String
        Dim blnKeyWordNotFound As Boolean
        Dim blnTransactionNotFound As Boolean
        Dim blnFatalError As Boolean = False
        Dim blnNoItemsFound As Boolean = True

        'setting up for the loop
        mintResultCounter = 0

        strPartNumberForSearch = txtFindParts.Text
        blnFatalError = TheInputDataValidation.VerifyTextData(strPartNumberForSearch)
        If blnFatalError = True Then
            MessageBox.Show("No Part Information Was Found", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf blnFatalError = False Then
            strDescriptionForSearch = strPartNumberForSearch
            dgvSearchResults.Visible = True
        End If

        'setting up for current records
        For intCurrentCounter = 0 To mintCurrentUpperLimit

            blnTransactionNotFound = True

            'getting variables
            strPartNumberFromTable = structCurrentParts(intCurrentCounter).mstrPartNumber
            strDescriptionFromTable = structCurrentParts(intCurrentCounter).mstrDescription

            If strPartNumberForSearch = strPartNumberFromTable Then
                blnTransactionNotFound = False
            ElseIf strDescriptionFromTable <> "" Then
                blnKeyWordNotFound = TheKeyWordSearch.FindKeyWord(strDescriptionForSearch, strDescriptionFromTable)
                If blnKeyWordNotFound = False Then
                    blnTransactionNotFound = False
                End If
            End If

            If blnTransactionNotFound = False Then
                structSearchResults(mintResultCounter).mintPartID = structCurrentParts(intCurrentCounter).mintPartID
                structSearchResults(mintResultCounter).mstrDescription = structCurrentParts(intCurrentCounter).mstrDescription
                structSearchResults(mintResultCounter).mstrPartNumber = structCurrentParts(intCurrentCounter).mstrPartNumber
                mintResultCounter += 1
                blnNoItemsFound = False
            End If

        Next
        If mblnNewRecordCreated = True Then
            For intNewCounter = 0 To mintNewUpperLimit

                blnTransactionNotFound = True

                'getting variables
                strPartNumberFromTable = structNewParts(intNewCounter).mstrPartNumber
                strDescriptionFromTable = structNewParts(intNewCounter).mstrDescription

                If strPartNumberForSearch = strPartNumberFromTable Then
                    blnTransactionNotFound = False
                Else
                    blnKeyWordNotFound = TheKeyWordSearch.FindKeyWord(strDescriptionForSearch, strDescriptionFromTable)
                    If blnKeyWordNotFound = False Then
                        blnTransactionNotFound = False
                    End If
                End If

                'loading search criterial
                If blnTransactionNotFound = False Then
                    structSearchResults(mintResultCounter).mintPartID = structNewParts(intNewCounter).mintPartID
                    structSearchResults(mintResultCounter).mstrDescription = structNewParts(intNewCounter).mstrDescription
                    structSearchResults(mintResultCounter).mstrPartNumber = structNewParts(intNewCounter).mstrPartNumber
                    mintResultCounter += 0
                    blnNoItemsFound = False
                End If

            Next
        End If

        If blnNoItemsFound = True Then
            MessageBox.Show("No Parts Were Found Match Search Criteria", "Try AGain", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtFindParts.Text = ""
            Exit Sub
        ElseIf blnNoItemsFound = False Then
            mintResultUpperLimit = mintResultCounter - 1
            mintResultCounter = 0
            LoadDataGrid()
            btnPartNumberReport.Enabled = True
        End If

    End Sub
End Class