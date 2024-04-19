'Title:         Complete Inventory Report
'Date:          12-8-14
'Author:        Terry Holmes

'Description:   This will run the report on the complete inventory

Option Strict On

Public Class CompleteInventoryReport

    'Setting up the global variables
    Private TheWarehouseInventoryDataTier As TWInventoryDataTier
    Private TheWarehouseInventoryDataSet As WarehouseInventoryDataSet
    Private WithEvents TheWarehouseInventoryBindingSource As BindingSource

    Private ThePartNumberDataTier As PartsDataTier
    Private ThePartNumberDataSet As PartNumberDataSet
    Private WithEvents ThePartNumberBindingSource As BindingSource

    Private TheInventoryDataTier As TWInventoryDataTier
    Private TheInventoryDataSet As InventoryDataSet
    Private WithEvents TheInventoryBindingSource As BindingSource

    Private TheIssuedPartsDataTier As TWInventoryDataTier
    Private TheIssuedPartsDataSet As IssuedPartsDataSet
    Private WithEvents TheIssuedPartsBindingSource As BindingSource

    Private TheReceivedPartsDataTier As TWInventoryDataTier
    Private TheReceivedPartsDataSet As ReceivedPartsDataSet
    Private WithEvents TheReceivedPartsBindingSource As BindingSource

    Private TheBOMPartsDataTier As TWInventoryDataTier
    Private TheBOMPartsDataSet As BOMPartsDataSet
    Private WithEvents TheBOMPartsBindingSource As BindingSource

    Dim TheInputDataValidation As New InputDataValidation
    Dim TheKeyWordSearchClass As New KeyWordSearchClass
    Dim TheCheckTWCPartNumber As New CheckTimeWarnerPartNumber

    Dim mintNewPrintCounter As Integer
    Dim LogDate As Date = Date.Now
    Dim mstrDate As String

    'Creating up the structure
    Structure CompleteInventory
        Dim mstrPartNumber As String
        Dim mstrDescription As String
        Dim mintQTYReceived As Integer
        Dim mintQTYIssued As Integer
        Dim mintQTYOnHand As Integer
        Dim mintQTYUsed As Integer
        Dim mintQTYResponsible As Integer
    End Structure

    'Setting up the structure object
    Dim structCompleteInventory() As CompleteInventory
    Dim mintCompleteInventoryUpperLimit As Integer
    Dim mintCompleteInventoryCounter As Integer

    Structure SearchResults
        Dim mstrPartNumber As String
        Dim mstrDescription As String
        Dim mintQTYReceived As Integer
        Dim mintQTYIssued As Integer
        Dim mintQTYOnHand As Integer
        Dim mintQTYUsed As Integer
        Dim mintQTYResponsible As Integer
    End Structure

    'Setting up the structure object
    Dim structSearchResults() As SearchResults
    Dim mintResultsUpperLimit As Integer
    Dim mintResultsCounter As Integer
    Dim mblnCompleteInventory As Boolean

    Structure ReceivedParts
        Dim mstrPartNumber As String
        Dim mintQuantity As Integer
        Dim mintWarehouseID As Integer
    End Structure

    Dim structReceivedParts() As ReceivedParts
    Dim mintReceivedCounter As Integer
    Dim mintReceivedUpperLimit As Integer

    Structure UsedParts
        Dim mstrPartNumber As String
        Dim mintQuantity As Integer
        Dim mintWarehouseID As Integer
    End Structure

    Dim structUsedParts() As UsedParts
    Dim mintUsedCounter As Integer
    Dim mintUsedUpperLimit As Integer

    Structure IssuedParts
        Dim mstrPartNumber As String
        Dim mintQuantity As Integer
        Dim mintWarehouseID As Integer
    End Structure

    Dim structIssuedParts() As IssuedParts
    Dim mintIssuedCounter As Integer
    Dim mintIssuedUpperLimit As Integer

    Structure PartNumbers
        Dim mstrPartNumber As String
        Dim mstrDescription As String
    End Structure

    Dim structPartNumbers() As PartNumbers
    Dim mintPartCounter As Integer
    Dim mintPartUpperLimit As Integer

    Structure TimeWarnerInventory
        Dim mstrPartNumber As String
        Dim mintQuantity As Integer
        Dim mintWarehouseID As Integer
    End Structure

    Dim structTimeWarnerInventory() As TimeWarnerInventory
    Dim mintTimeWarnerCounter As Integer
    Dim mintTimeWarnerUpperLimit As Integer

    Structure OnHandInventory
        Dim mstrPartNumber As String
        Dim mintQuantity As Integer
        Dim mintWarehouseID As Integer
    End Structure

    Dim structOnHandInventory() As OnHandInventory
    Dim mintOnHandCounter As Integer
    Dim mintOnHandUpperLimit As Integer

    Dim mstrErrorMessage As String
    Dim mdatDate As Date = Date.Now


    Private Sub btnReportMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReportMenu.Click

        'This will display the Report Menu
        ReportMenu.Show()
        Me.Close()

    End Sub

    Private Sub btnMainMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMainMenu.Click

        'This will display the main menu
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        'This will display the confirmation
        CloseProgram.ShowDialog()

    End Sub
    Private Function SetPartNumberDataBindings() As Boolean

        'This will set the bindings for the Part Number
        Dim intCounter As Integer
        Dim intNumberOfRecords As Integer
        Dim blnFatalError As Boolean = False
        Dim blnIsNotaTWCPartNumber As Boolean
        Dim strPartNumber As String

        'try catch for excpeitons
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

            'Setting up the controls
            intNumberOfRecords = cboPartNumber.Items.Count - 1
            ReDim structPartNumbers(intNumberOfRecords)
            ReDim structSearchResults(intNumberOfRecords)
            mintPartCounter = 0

            'loading up the structure
            For intCounter = 0 To intNumberOfRecords

                'incrementing the combo box
                cboPartNumber.SelectedIndex = intCounter

                strPartNumber = cboPartNumber.Text
                blnIsNotaTWCPartNumber = TheCheckTWCPartNumber.CheckPartNumber(strPartNumber)

                If blnIsNotaTWCPartNumber = False Then

                    'loading the elements
                    structPartNumbers(mintPartCounter).mstrPartNumber = cboPartNumber.Text
                    structPartNumbers(mintPartCounter).mstrDescription = txtPartDescription.Text
                    mintPartCounter += 1

                End If
            Next

            mintPartUpperLimit = mintPartCounter - 1
            mintCompleteInventoryUpperLimit = mintPartUpperLimit
            ReDim structCompleteInventory(mintCompleteInventoryUpperLimit)

            'Loading up the Complete Inventory structure
            For intCounter = 0 To mintCompleteInventoryUpperLimit

                structCompleteInventory(intCounter).mstrPartNumber = structPartNumbers(intCounter).mstrPartNumber
                structCompleteInventory(intCounter).mstrDescription = structPartNumbers(intCounter).mstrDescription
                structCompleteInventory(intCounter).mintQTYIssued = 0
                structCompleteInventory(intCounter).mintQTYOnHand = 0
                structCompleteInventory(intCounter).mintQTYReceived = 0
                structCompleteInventory(intCounter).mintQTYResponsible = 0
                structCompleteInventory(intCounter).mintQTYUsed = 0

            Next

            Return blnFatalError

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            blnFatalError = True
            mstrErrorMessage = "There is a Problem with the Parts Data Bindings"
            Return blnFatalError

        End Try

    End Function
    Private Function SetWarehouseInventoryDataBindings() As Boolean

        Dim intTransactionCounter As Integer
        Dim intCompleteCounter As Integer = 0
        Dim intNumberOfRecords As Integer
        Dim blnFatalError As Boolean = False
        Dim blnIsNotaTWCPartNumber As Boolean = False
        Dim blnItemNotFound As Boolean = True
        Dim strPartNumberForSearch As String = ""
        Dim intWarehouseIDForSearch As Integer
        Dim intWarehouseIDFromTable As Integer

        'Try catch for exceptions
        Try

            'setting the data variables
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

            'setting up the combo box
            With cboTransactionID
                .DataSource = TheWarehouseInventoryBindingSource
                .DisplayMember = "PartID"
                .DataBindings.Add("text", TheWarehouseInventoryBindingSource, "PartID", False, DataSourceUpdateMode.Never)
            End With

            'setting up the rest of the controls
            txtTransactionPartNumber.DataBindings.Add("text", TheWarehouseInventoryBindingSource, "PartNumber")
            txtTransactionQuantity.DataBindings.Add("text", TheWarehouseInventoryBindingSource, "QTYOnHand")
            txtTransactionWarehouseID.DataBindings.Add("text", TheWarehouseInventoryBindingSource, "WarehouseID")

            'setting up for the loop
            intNumberOfRecords = cboTransactionID.Items.Count - 1
            ReDim structOnHandInventory(intNumberOfRecords)
            mintOnHandCounter = 0
            mintOnHandUpperLimit = 0
            intWarehouseIDForSearch = Logon.mintPartsWarehouseID

            'beginning loop
            For intTransactionCounter = 0 To intNumberOfRecords

                'this will increment the combo box
                cboTransactionID.SelectedIndex = intTransactionCounter

                'getting the warehouse ID
                intWarehouseIDFromTable = CInt(txtTransactionWarehouseID.Text)

                If intWarehouseIDForSearch = intWarehouseIDFromTable Then

                    'getting part number
                    strPartNumberForSearch = txtTransactionPartNumber.Text

                    'ensuring that part number is a Time Warner Part Number
                    blnIsNotaTWCPartNumber = TheCheckTWCPartNumber.CheckPartNumber(strPartNumberForSearch)

                    'if statement if part number is a TWC part number
                    If blnIsNotaTWCPartNumber = False Then

                        structOnHandInventory(mintOnHandCounter).mintQuantity = CInt(txtTransactionQuantity.Text)
                        structOnHandInventory(mintOnHandCounter).mintWarehouseID = CInt(txtTransactionWarehouseID.Text)
                        structOnHandInventory(mintOnHandCounter).mstrPartNumber = txtTransactionPartNumber.Text
                        mintOnHandCounter += 1
                        blnItemNotFound = False

                    End If

                End If

            Next

            If blnItemNotFound = True Then
                mstrErrorMessage = "There are no Parts Inventory For This Warehouse"
                blnFatalError = True
            Else
                mintOnHandUpperLimit = mintOnHandCounter - 1
                mintOnHandCounter = 0
            End If

            'Returning value to calling sub-routine
            Return blnFatalError

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            mstrErrorMessage = "On Hand Inventory Failed to load Data Bindings"
            blnFatalError = True
            Return blnFatalError
        End Try

    End Function
    Private Function SetInventoryDataBindings() As Boolean

        Dim intTransactionCounter As Integer
        Dim intCompleteCounter As Integer = 0
        Dim intNumberOfRecords As Integer
        Dim blnFatalError As Boolean = False
        Dim blnIsNotaTWCPartNumber As Boolean = False
        Dim blnItemNotFound As Boolean = True
        Dim strPartNumberForSearch As String = ""
        Dim intWarehouseIDForSearch As Integer
        Dim intWarehouseIDFromTable As Integer

        'Try catch for exceptions
        Try

            'setting the data variables
            TheInventoryDataTier = New TWInventoryDataTier
            TheInventoryDataSet = TheInventoryDataTier.GetInventoryInformation
            TheInventoryBindingSource = New BindingSource

            'Setting up the binding source
            With TheInventoryBindingSource
                .DataSource = TheInventoryDataSet
                .DataMember = "Inventory"
                .MoveFirst()
                .MoveLast()
            End With

            'setting up the combo box
            With cboTransactionID
                .DataSource = TheInventoryBindingSource
                .DisplayMember = "PartID"
                .DataBindings.Add("text", TheInventoryBindingSource, "PartID", False, DataSourceUpdateMode.Never)
            End With

            'setting up the rest of the controls
            txtTransactionPartNumber.DataBindings.Add("text", TheInventoryBindingSource, "PartNumber")
            txtTransactionQuantity.DataBindings.Add("text", TheInventoryBindingSource, "QTYResponible")
            txtTransactionWarehouseID.DataBindings.Add("text", TheInventoryBindingSource, "WarehouseID")

            'setting up for the loop
            intNumberOfRecords = cboTransactionID.Items.Count - 1
            ReDim structTimeWarnerInventory(intNumberOfRecords)
            mintTimeWarnerCounter = 0
            mintTimeWarnerUpperLimit = 0
            intWarehouseIDForSearch = Logon.mintPartsWarehouseID

            'beginning loop
            For intTransactionCounter = 0 To intNumberOfRecords

                'this will increment the combo box
                cboTransactionID.SelectedIndex = intTransactionCounter

                'getting the warehouse ID
                intWarehouseIDFromTable = CInt(txtTransactionWarehouseID.Text)

                If intWarehouseIDForSearch = intWarehouseIDFromTable Then

                    'getting part number
                    strPartNumberForSearch = txtTransactionPartNumber.Text

                    'ensuring that part number is a Time Warner Part Number
                    blnIsNotaTWCPartNumber = TheCheckTWCPartNumber.CheckPartNumber(strPartNumberForSearch)

                    'if statement if part number is a TWC part number
                    If blnIsNotaTWCPartNumber = False Then

                        structTimeWarnerInventory(mintTimeWarnerCounter).mintQuantity = CInt(txtTransactionQuantity.Text)
                        structTimeWarnerInventory(mintTimeWarnerCounter).mintWarehouseID = CInt(txtTransactionWarehouseID.Text)
                        structTimeWarnerInventory(mintTimeWarnerCounter).mstrPartNumber = txtTransactionPartNumber.Text
                        mintTimeWarnerCounter += 1
                        blnItemNotFound = False

                    End If

                End If

            Next

            If blnItemNotFound = True Then
                mstrErrorMessage = "There are no Parts Inventory For This Warehouse"
                blnFatalError = True
            Else
                mintTimeWarnerUpperLimit = mintTimeWarnerCounter - 1
                mintTimeWarnerCounter = 0
            End If

            'Returning value to calling sub-routine
            Return blnFatalError

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            mstrErrorMessage = "On Hand Inventory Failed to load Data Bindings"
            blnFatalError = True
            Return blnFatalError
        End Try

    End Function
    Private Function SetReceivedPartsDataBindings() As Boolean

        Dim intTransactionCounter As Integer
        Dim intCompleteCounter As Integer = 0
        Dim intNumberOfRecords As Integer
        Dim blnFatalError As Boolean = False
        Dim blnIsNotaTWCPartNumber As Boolean = False
        Dim blnItemNotFound As Boolean = True
        Dim strPartNumberForSearch As String = ""
        Dim intWarehouseIDForSearch As Integer
        Dim intWarehouseIDFromTable As Integer

        'Try catch for exceptions
        Try

            'setting the data variables
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
            txtTransactionPartNumber.DataBindings.Add("text", TheReceivedPartsBindingSource, "PartNumber")
            txtTransactionQuantity.DataBindings.Add("text", TheReceivedPartsBindingSource, "QTY")
            txtTransactionWarehouseID.DataBindings.Add("text", TheReceivedPartsBindingSource, "WarehouseID")

            'setting up for the loop
            intNumberOfRecords = cboTransactionID.Items.Count - 1
            ReDim structReceivedParts(intNumberOfRecords)
            mintReceivedCounter = 0
            mintReceivedUpperLimit = 0
            intWarehouseIDForSearch = Logon.mintPartsWarehouseID

            'beginning loop
            For intTransactionCounter = 0 To intNumberOfRecords

                'this will increment the combo box
                cboTransactionID.SelectedIndex = intTransactionCounter

                'getting the warehouse ID
                intWarehouseIDFromTable = CInt(txtTransactionWarehouseID.Text)

                If intWarehouseIDForSearch = intWarehouseIDFromTable Then

                    'getting part number
                    strPartNumberForSearch = txtTransactionPartNumber.Text

                    'ensuring that part number is a Time Warner Part Number
                    blnIsNotaTWCPartNumber = TheCheckTWCPartNumber.CheckPartNumber(strPartNumberForSearch)

                    'if statement if part number is a TWC part number
                    If blnIsNotaTWCPartNumber = False Then

                        structReceivedParts(mintReceivedCounter).mintQuantity = CInt(txtTransactionQuantity.Text)
                        structReceivedParts(mintReceivedCounter).mintWarehouseID = CInt(txtTransactionWarehouseID.Text)
                        structReceivedParts(mintReceivedCounter).mstrPartNumber = txtTransactionPartNumber.Text
                        mintReceivedCounter += 1
                        blnItemNotFound = False

                    End If

                End If

            Next

            If blnItemNotFound = True Then
                
            Else
                mintReceivedUpperLimit = mintReceivedCounter - 1
                mintReceivedCounter = 0
            End If

            'Returning value to calling sub-routine
            Return blnFatalError

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            mstrErrorMessage = "Received Parts Failed to load Data Bindings"
            blnFatalError = True
            Return blnFatalError
        End Try

    End Function
    Private Function SetIssuedPartsDataBindings() As Boolean

        Dim intTransactionCounter As Integer
        Dim intCompleteCounter As Integer = 0
        Dim intNumberOfRecords As Integer
        Dim blnFatalError As Boolean = False
        Dim blnIsNotaTWCPartNumber As Boolean = False
        Dim blnItemNotFound As Boolean = True
        Dim strPartNumberForSearch As String = ""
        Dim intWarehouseIDForSearch As Integer
        Dim intWarehouseIDFromTable As Integer

        'Try catch for exceptions
        Try

            'setting the data variables
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

            'setting up the combo box
            With cboTransactionID
                .DataSource = TheIssuedPartsBindingSource
                .DisplayMember = "TransactionID"
                .DataBindings.Add("text", TheIssuedPartsBindingSource, "TransactionID", False, DataSourceUpdateMode.Never)
            End With

            'setting up the rest of the controls
            txtTransactionPartNumber.DataBindings.Add("text", TheIssuedPartsBindingSource, "PartNumber")
            txtTransactionQuantity.DataBindings.Add("text", TheIssuedPartsBindingSource, "QTY")
            txtTransactionWarehouseID.DataBindings.Add("text", TheIssuedPartsBindingSource, "WarehouseID")

            'setting up for the loop
            intNumberOfRecords = cboTransactionID.Items.Count - 1
            ReDim structIssuedParts(intNumberOfRecords)
            mintIssuedCounter = 0
            mintIssuedUpperLimit = 0
            intWarehouseIDForSearch = Logon.mintPartsWarehouseID

            'beginning loop
            For intTransactionCounter = 0 To intNumberOfRecords

                'this will increment the combo box
                cboTransactionID.SelectedIndex = intTransactionCounter

                'getting the warehouse ID
                intWarehouseIDFromTable = CInt(txtTransactionWarehouseID.Text)

                If intWarehouseIDForSearch = intWarehouseIDFromTable Then

                    'getting part number
                    strPartNumberForSearch = txtTransactionPartNumber.Text

                    'ensuring that part number is a Time Warner Part Number
                    blnIsNotaTWCPartNumber = TheCheckTWCPartNumber.CheckPartNumber(strPartNumberForSearch)

                    'if statement if part number is a TWC part number
                    If blnIsNotaTWCPartNumber = False Then

                        structIssuedParts(mintIssuedCounter).mintQuantity = CInt(txtTransactionQuantity.Text)
                        structIssuedParts(mintIssuedCounter).mintWarehouseID = CInt(txtTransactionWarehouseID.Text)
                        structIssuedParts(mintIssuedCounter).mstrPartNumber = txtTransactionPartNumber.Text
                        mintIssuedCounter += 1
                        blnItemNotFound = False

                    End If

                End If

            Next

            If blnItemNotFound = True Then

            Else
                mintIssuedUpperLimit = mintIssuedCounter - 1
                mintIssuedCounter = 0
            End If

            'Returning value to calling sub-routine
            Return blnFatalError

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            mstrErrorMessage = "Issued Parts Failed to load Data Bindings"
            blnFatalError = True
            Return blnFatalError
        End Try

    End Function
    Private Function SetUsedPartsDataBindings() As Boolean

        Dim intTransactionCounter As Integer
        Dim intCompleteCounter As Integer = 0
        Dim intNumberOfRecords As Integer
        Dim blnFatalError As Boolean = False
        Dim blnIsNotaTWCPartNumber As Boolean = False
        Dim blnItemNotFound As Boolean = True
        Dim strPartNumberForSearch As String = ""
        Dim intWarehouseIDForSearch As Integer
        Dim intWarehouseIDFromTable As Integer

        'Try catch for exceptions
        Try

            'setting the data variables
            TheBOMPartsDataTier = New TWInventoryDataTier
            TheBOMPartsDataSet = TheBOMPartsDataTier.GetBOMPartsInformation
            TheBOMPartsBindingSource = New BindingSource

            'Setting up the binding source
            With TheBOMPartsBindingSource
                .DataSource = TheBOMPartsDataSet
                .DataMember = "BOMParts"
                .MoveFirst()
                .MoveLast()
            End With

            'setting up the combo box
            With cboTransactionID
                .DataSource = TheBOMPartsBindingSource
                .DisplayMember = "TransactionID"
                .DataBindings.Add("text", TheBOMPartsBindingSource, "TransactionID", False, DataSourceUpdateMode.Never)
            End With

            'setting up the rest of the controls
            txtTransactionPartNumber.DataBindings.Add("text", TheBOMPartsBindingSource, "PartNumber")
            txtTransactionQuantity.DataBindings.Add("text", TheBOMPartsBindingSource, "QTY")
            txtTransactionWarehouseID.DataBindings.Add("text", TheBOMPartsBindingSource, "WarehouseID")

            'setting up for the loop
            intNumberOfRecords = cboTransactionID.Items.Count - 1
            ReDim structUsedParts(intNumberOfRecords)
            mintUsedCounter = 0
            mintUsedUpperLimit = 0
            intWarehouseIDForSearch = Logon.mintPartsWarehouseID

            'beginning loop
            For intTransactionCounter = 0 To intNumberOfRecords

                'this will increment the combo box
                cboTransactionID.SelectedIndex = intTransactionCounter

                'getting the warehouse ID
                intWarehouseIDFromTable = CInt(txtTransactionWarehouseID.Text)

                If intWarehouseIDForSearch = intWarehouseIDFromTable Then

                    'getting part number
                    strPartNumberForSearch = txtTransactionPartNumber.Text

                    'ensuring that part number is a Time Warner Part Number
                    blnIsNotaTWCPartNumber = TheCheckTWCPartNumber.CheckPartNumber(strPartNumberForSearch)

                    'if statement if part number is a TWC part number
                    If blnIsNotaTWCPartNumber = False Then

                        structUsedParts(mintUsedCounter).mintQuantity = CInt(txtTransactionQuantity.Text)
                        structUsedParts(mintUsedCounter).mintWarehouseID = CInt(txtTransactionWarehouseID.Text)
                        structUsedParts(mintUsedCounter).mstrPartNumber = txtTransactionPartNumber.Text
                        mintUsedCounter += 1
                        blnItemNotFound = False

                    End If

                End If

            Next

            If blnItemNotFound = True Then

            Else
                mintUsedUpperLimit = mintUsedCounter - 1
                mintUsedCounter = 0
            End If

            'Returning value to calling sub-routine
            Return blnFatalError

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            mstrErrorMessage = "Issued Parts Failed to load Data Bindings"
            blnFatalError = True
            Return blnFatalError
        End Try

    End Function

    Private Sub CompleteInventoryReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim blnFatalError As Boolean = False
        Dim blnItemsNotFound As Boolean = True

        PleaseWait.Show()
        ClearTransactionDataBindings()
        blnFatalError = SetPartNumberDataBindings()
        If blnFatalError = False Then
            blnFatalError = SetWarehouseInventoryDataBindings()
            If blnFatalError = False Then
                ClearTransactionDataBindings()
                blnFatalError = SetInventoryDataBindings()
                If blnFatalError = False Then
                    ClearTransactionDataBindings()
                    blnFatalError = SetReceivedPartsDataBindings()
                    If blnFatalError = False Then
                        ClearTransactionDataBindings()
                        blnFatalError = SetIssuedPartsDataBindings()
                        If blnFatalError = False Then
                            ClearTransactionDataBindings()
                            blnFatalError = SetUsedPartsDataBindings()
                        End If
                    End If
                End If
            End If
        End If

        If blnFatalError = True Then
            PleaseWait.Close()
            MessageBox.Show(mstrErrorMessage, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            btnRunReport.Enabled = False
            dgvSearchResults.Visible = False
        ElseIf blnFatalError = False Then

            blnItemsNotFound = LoadCompleteInventoryStructure()

            If blnItemsNotFound = False Then

                'great the data grid view
                FillSearchResults()
                dgvSearchResults.ColumnCount = 7
                dgvSearchResults.Columns(0).Name = "Part Number"
                dgvSearchResults.Columns(1).Name = "Description"
                dgvSearchResults.Columns(2).Name = "On Hand"
                dgvSearchResults.Columns(3).Name = "TWC Count"
                dgvSearchResults.Columns(4).Name = "Received"
                dgvSearchResults.Columns(5).Name = "Issued"
                dgvSearchResults.Columns(6).Name = "Reported"
                LoadDataGridView()
                cboPartNumber.Visible = False
                cboTransactionID.Visible = False
                txtPartDescription.Visible = False
                txtTransactionPartNumber.Visible = False
                txtTransactionQuantity.Visible = False
                txtTransactionWarehouseID.Visible = False

                PleaseWait.Close()

            ElseIf blnItemsNotFound = True Then

                PleaseWait.Close()
                MessageBox.Show("No Items Were Found For This Warehouse", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information)
                btnRunReport.Enabled = False
                dgvSearchResults.Visible = False

            End If

        End If

    End Sub
    Private Sub FillSearchResults()

        'this will fill the array
        'setting local variables
        Dim intCounter As Integer
        Dim blnNoPartsFound As Boolean

        'setting up variables
        mintResultsCounter = 0
        mintResultsUpperLimit = 0

        For intCounter = 0 To mintCompleteInventoryUpperLimit

            'setting boolean variable
            blnNoPartsFound = True

            If structCompleteInventory(intCounter).mintQTYIssued <> 0 Then
                blnNoPartsFound = False
            End If
            If structCompleteInventory(intCounter).mintQTYOnHand <> 0 Then
                blnNoPartsFound = False
            End If
            If structCompleteInventory(intCounter).mintQTYReceived <> 0 Then
                blnNoPartsFound = False
            End If
            If structCompleteInventory(intCounter).mintQTYResponsible <> 0 Then
                blnNoPartsFound = False
            End If
            If structCompleteInventory(intCounter).mintQTYUsed <> 0 Then
                blnNoPartsFound = False
            End If

            If blnNoPartsFound = False Then

                'placing record within structure
                structSearchResults(mintResultsCounter).mstrPartNumber = structCompleteInventory(intCounter).mstrPartNumber
                structSearchResults(mintResultsCounter).mstrDescription = structCompleteInventory(intCounter).mstrDescription
                structSearchResults(mintResultsCounter).mintQTYIssued = structCompleteInventory(intCounter).mintQTYIssued
                structSearchResults(mintResultsCounter).mintQTYOnHand = structCompleteInventory(intCounter).mintQTYOnHand
                structSearchResults(mintResultsCounter).mintQTYReceived = structCompleteInventory(intCounter).mintQTYReceived
                structSearchResults(mintResultsCounter).mintQTYResponsible = structCompleteInventory(intCounter).mintQTYResponsible
                structSearchResults(mintResultsCounter).mintQTYUsed = structCompleteInventory(intCounter).mintQTYUsed
                mintResultsCounter += 1

            End If

        Next

        If mintResultsCounter <> 0 Then
            mintResultsUpperLimit = mintResultsCounter - 1
            mintResultsCounter = 0
        End If

    End Sub
    Private Sub LoadDataGridView()

        'setting local variables
        Dim intCounter As Integer
        Dim row() As String

        dgvSearchResults.Rows.Clear()

        For intCounter = 0 To mintResultsUpperLimit

            row = New String() {structSearchResults(intCounter).mstrPartNumber, structSearchResults(intCounter).mstrDescription, CStr(structSearchResults(intCounter).mintQTYOnHand), CStr(structSearchResults(intCounter).mintQTYResponsible), CStr(structSearchResults(intCounter).mintQTYReceived), CStr(structSearchResults(intCounter).mintQTYIssued), CStr(structSearchResults(intCounter).mintQTYUsed)}
            dgvSearchResults.Rows.Add(row)

        Next

    End Sub
    Private Sub ClearTransactionDataBindings()

        cboTransactionID.DataBindings.Clear()
        txtTransactionPartNumber.DataBindings.Clear()
        txtTransactionQuantity.DataBindings.Clear()
        txtTransactionWarehouseID.DataBindings.Clear()

    End Sub
    Private Function LoadCompleteInventoryStructure() As Boolean

        'Setting local variables
        Dim blnItemNotFound As Boolean = True
        Dim intPartCounter As Integer
        Dim intOnHandInventoryCounter As Integer
        Dim intTWCInventoryCounter As Integer
        Dim intReceivedCounter As Integer
        Dim intIssuedCounter As Integer
        Dim intUsedCounter As Integer
        Dim strPartNumberForSearch As String
        Dim strPartNumberFromTable As String

        'Beginning Loop
        For intPartCounter = 0 To mintPartUpperLimit

            'Loading the first part of the structure
            structCompleteInventory(intPartCounter).mstrPartNumber = structPartNumbers(intPartCounter).mstrPartNumber
            structCompleteInventory(intPartCounter).mstrDescription = structPartNumbers(intPartCounter).mstrDescription

            'Getting the part number
            strPartNumberForSearch = structCompleteInventory(intPartCounter).mstrPartNumber

            'Searching the warehouse inventory
            For intOnHandInventoryCounter = 0 To mintOnHandUpperLimit

                'Getting the part number
                strPartNumberFromTable = structOnHandInventory(intOnHandInventoryCounter).mstrPartNumber

                If strPartNumberForSearch = strPartNumberFromTable Then

                    structCompleteInventory(intPartCounter).mintQTYOnHand = structCompleteInventory(intPartCounter).mintQTYOnHand + structOnHandInventory(intOnHandInventoryCounter).mintQuantity
                    blnItemNotFound = False

                End If

            Next
            For intTWCInventoryCounter = 0 To mintTimeWarnerUpperLimit

                'getting partnumber
                strPartNumberFromTable = structTimeWarnerInventory(intTWCInventoryCounter).mstrPartNumber

                If strPartNumberForSearch = strPartNumberFromTable Then

                    structCompleteInventory(intPartCounter).mintQTYResponsible = structCompleteInventory(intPartCounter).mintQTYResponsible + structTimeWarnerInventory(intTWCInventoryCounter).mintQuantity
                    blnItemNotFound = False

                End If

            Next
            For intReceivedCounter = 0 To mintReceivedUpperLimit

                'getting part number
                strPartNumberFromTable = structReceivedParts(intReceivedCounter).mstrPartNumber

                If strPartNumberFromTable = strPartNumberForSearch Then
                    structCompleteInventory(intPartCounter).mintQTYReceived = structCompleteInventory(intPartCounter).mintQTYReceived + structReceivedParts(intReceivedCounter).mintQuantity
                    blnItemNotFound = False
                End If
            Next
            For intIssuedCounter = 0 To mintIssuedUpperLimit

                'getting part number
                strPartNumberFromTable = structIssuedParts(intIssuedCounter).mstrPartNumber

                If strPartNumberFromTable = strPartNumberForSearch Then
                    structCompleteInventory(intPartCounter).mintQTYIssued = structCompleteInventory(intPartCounter).mintQTYIssued + structIssuedParts(intIssuedCounter).mintQuantity
                    blnItemNotFound = False
                End If
            Next
            For intUsedCounter = 0 To mintUsedUpperLimit

                'getting part number
                strPartNumberFromTable = structUsedParts(intUsedCounter).mstrPartNumber

                If strPartNumberFromTable = strPartNumberForSearch Then
                    structCompleteInventory(intPartCounter).mintQTYUsed = structCompleteInventory(intPartCounter).mintQTYUsed + structUsedParts(intUsedCounter).mintQuantity
                    blnItemNotFound = False
                End If
            Next

        Next

        Return blnItemNotFound

    End Function

    
    Private Sub btnResetGrid_Click(sender As Object, e As EventArgs) Handles btnResetGrid.Click

        'This will reset the grid
        FillSearchResults()
        LoadDataGridView()

    End Sub

    Private Sub btnFindPartNumber_Click(sender As Object, e As EventArgs) Handles btnFindPartNumber.Click

        'this will find the part number
        Dim intCounter As Integer
        Dim strPartNumberForSearch As String
        Dim strPartNumberFromTable As String
        Dim blnFatalError As Boolean
        Dim blnNotATWCPartNumber As Boolean

        strPartNumberForSearch = txtFindPartNumber.Text
        blnFatalError = TheInputDataValidation.VerifyTextData(strPartNumberForSearch)
        If blnFatalError = True Then
            MessageBox.Show("The Part Number was not Entered", "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        blnNotATWCPartNumber = TheCheckTWCPartNumber.CheckPartNumber(strPartNumberForSearch)
        If blnNotATWCPartNumber = True Then
            MessageBox.Show("The Part Number Entered is not a TWC Part Number", "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtFindPartNumber.Text = ""
            Exit Sub
        End If

        'Setting up for search
        mintResultsCounter = 0
        mintResultsUpperLimit = 0

        'beginning the loop
        For intCounter = 0 To mintCompleteInventoryUpperLimit

            'getting the part number
            strPartNumberFromTable = structCompleteInventory(intCounter).mstrPartNumber

            If strPartNumberForSearch = strPartNumberFromTable Then

                structSearchResults(mintResultsCounter).mstrPartNumber = structCompleteInventory(intCounter).mstrPartNumber
                structSearchResults(mintResultsCounter).mstrDescription = structCompleteInventory(intCounter).mstrDescription
                structSearchResults(mintResultsCounter).mintQTYIssued = structCompleteInventory(intCounter).mintQTYIssued
                structSearchResults(mintResultsCounter).mintQTYOnHand = structCompleteInventory(intCounter).mintQTYOnHand
                structSearchResults(mintResultsCounter).mintQTYReceived = structCompleteInventory(intCounter).mintQTYReceived
                structSearchResults(mintResultsCounter).mintQTYResponsible = structCompleteInventory(intCounter).mintQTYResponsible
                structSearchResults(mintResultsCounter).mintQTYUsed = structCompleteInventory(intCounter).mintQTYUsed
                Exit For

            End If

        Next

        'loads the data grid
        LoadDataGridView()
        txtFindPartNumber.Text = ""

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

        'Getting the date
        mstrDate = CStr(LogDate)

        'Setting up for default position
        PrintY = 100

        'Setting up for the print header
        PrintX = 300
        e.Graphics.DrawString("Blue Jay Communications Inventory Report", PrintHeaderFont, Brushes.Black, PrintX, PrintY)
        PrintY = PrintY + HeadingLineHeight
        PrintX = 306
        e.Graphics.DrawString("Complete Inventory Report for Warehouse ID " + CStr(Logon.mintPartsWarehouseID), PrintSubHeaderFont, Brushes.Black, PrintX, PrintY)
        PrintY = PrintY + HeadingLineHeight

        'Setting up the columns
        PrintX = 50
        e.Graphics.DrawString("Part Number", PrintItemsFont, Brushes.Black, PrintX, PrintY)
        PrintX = 150
        e.Graphics.DrawString("Description", PrintItemsFont, Brushes.Black, PrintX, PrintY)
        PrintX = 450
        e.Graphics.DrawString("On Hand", PrintItemsFont, Brushes.Black, PrintX, PrintY)
        PrintX = 575
        e.Graphics.DrawString("TWC Inventory", PrintItemsFont, Brushes.Black, PrintX, PrintY)
        PrintX = 700
        e.Graphics.DrawString("QTY Received", PrintItemsFont, Brushes.Black, PrintX, PrintY)
        PrintX = 825
        e.Graphics.DrawString("QTY Issued", PrintItemsFont, Brushes.Black, PrintX, PrintY)
        PrintX = 950
        e.Graphics.DrawString("QTY Reported", PrintItemsFont, Brushes.Black, PrintX, PrintY)
        PrintY = PrintY + HeadingLineHeight

        'Setting up for multiple pages
        intStartingPageCounter = mintNewPrintCounter
        intNumberOfRecords = mintResultsUpperLimit

        For intCounter = intStartingPageCounter To mintResultsUpperLimit


            PrintX = 50
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

            PrintX = 150
            e.Graphics.DrawString(strPartDescription, PrintItemsFont, Brushes.Black, PrintX, PrintY)
            PrintX = 450
            e.Graphics.DrawString(CStr(structSearchResults(intCounter).mintQTYOnHand), PrintItemsFont, Brushes.Black, PrintX, PrintY)
            PrintX = 575
            e.Graphics.DrawString(CStr(structSearchResults(intCounter).mintQTYResponsible), PrintItemsFont, Brushes.Black, PrintX, PrintY)
            PrintX = 700
            e.Graphics.DrawString(CStr(structSearchResults(intCounter).mintQTYReceived), PrintItemsFont, Brushes.Black, PrintX, PrintY)
            PrintX = 825
            e.Graphics.DrawString(CStr(structSearchResults(intCounter).mintQTYIssued), PrintItemsFont, Brushes.Black, PrintX, PrintY)
            PrintX = 950
            e.Graphics.DrawString(CStr(structSearchResults(intCounter).mintQTYUsed), PrintItemsFont, Brushes.Black, PrintX, PrintY)
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
End Class