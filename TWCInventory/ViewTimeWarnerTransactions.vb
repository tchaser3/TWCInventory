'Title:         View Time Warner Transactions
'Date:          11-16-15
'Author:        Terry Holmes

'Description:   This form will only show Time Warner Transactions

Option Strict On

Public Class ViewTimeWarnerTransactions

    'Setting up the global variables
    Private ThePartNumberDataTier As PartsDataTier
    Private ThePartNumberDataSet As PartNumberDataSet
    Private WithEvents ThePartNumberBindingSource As BindingSource

    Private TheInventoryDataTier As TWInventoryDataTier
    Private TheInventoryDataSet As InventoryDataSet
    Private WithEvents TheInventoryBindingSource As BindingSource

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
    Structure TWInventory
        Dim mstrPartNumber As String
        Dim mstrDescription As String
        Dim mintQTYReceived As Integer
        Dim mintQTYUsed As Integer
        Dim mintQTYResponsible As Integer
    End Structure

    'Setting up the structure object
    Dim structCompleteInventory() As TWInventory
    Dim mintCompleteInventoryUpperLimit As Integer
    Dim mintCompleteInventoryCounter As Integer


    'Setting up the structure object
    Dim structSearchResults() As TWInventory
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

    Structure PartNumbers
        Dim mintPartID As Integer
        Dim mstrPartNumber As String
        Dim mstrDescription As String
    End Structure

    Dim structPartNumbers() As PartNumbers
    Dim mintPartCounter As Integer
    Dim mintPartUpperLimit As Integer

    Structure InventoryTable
        Dim mstrPartNumber As String
        Dim mintQuantity As Integer
        Dim mintWarehouseID As Integer
    End Structure

    Dim structInventory() As InventoryTable
    Dim mintInventoryCounter As Integer
    Dim mintInventoryUpperLimit As Integer

    Dim mstrErrorMessage As String
    Dim mdatDate As Date = Date.Now

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        CloseProgram.ShowDialog()
    End Sub

    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        LastTransaction.Show()
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub btnReportMenu_Click(sender As Object, e As EventArgs) Handles btnReportMenu.Click
        LastTransaction.Show()
        ReportMenu.Show()
        Me.Close()
    End Sub

    Private Sub ViewTimeWarnerTransactions_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'setting local variables
        Dim blnFatalError As Boolean = False

        PleaseWait.Show()
        ClearDataBindings()
        blnFatalError = SetPartNumberDataBindings()
        If blnFatalError = False Then
            ClearDataBindings()
            blnFatalError = SetInventoryDataBindings()
        End If
        If blnFatalError = False Then
            ClearDataBindings()
            blnFatalError = SetReceivedDataBindings()
        End If
        If blnFatalError = False Then
            ClearDataBindings()
            blnFatalError = SetUsedPartsDataBindings()
        End If

        dgvSearchResults.ColumnCount = 5
        dgvSearchResults.Columns(0).Name = "Part Number"
        dgvSearchResults.Columns(0).Width = 100
        dgvSearchResults.Columns(1).Name = "Description"
        dgvSearchResults.Columns(1).Width = 150
        dgvSearchResults.Columns(2).Name = "Received"
        dgvSearchResults.Columns(2).Width = 75
        dgvSearchResults.Columns(3).Name = "Reported"
        dgvSearchResults.Columns(3).Width = 75
        dgvSearchResults.Columns(4).Name = "TWC Count"
        dgvSearchResults.Columns(4).Width = 75

        If blnFatalError = False Then
            FillGridView()
        End If

        PleaseWait.Close()

        If blnFatalError = True Then
            btnRunReport.Enabled = False
            MessageBox.Show(mstrErrorMessage, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


    End Sub
    Private Sub FillGridView()

        Dim intPartCounter As Integer
        Dim intReceivedCounter As Integer
        Dim intUsedCounter As Integer
        Dim strPartNumberForSearch As String
        Dim strPartNumberFromTable As String
        Dim strTransactionPartNumber As String
        Dim intQuantityReceived As Integer
        Dim intQuantityReported As Integer
        Dim intInventoryQuantity As Integer
        Dim blnPartNotFound As Boolean

        mintCompleteInventoryCounter = 0

        'beginning loop
        For intPartCounter = 0 To mintPartUpperLimit

            'getting part number
            strPartNumberForSearch = structPartNumbers(intPartCounter).mstrPartNumber
            blnPartNotFound = True
            intQuantityReceived = 0
            intQuantityReported = 0

            'loop through the inventory
            For intInventoryCounter = 0 To mintInventoryUpperLimit

                'getting the part number from the structure
                strPartNumberFromTable = structInventory(intInventoryCounter).mstrPartNumber

                If strPartNumberForSearch = strPartNumberFromTable Then

                    blnPartNotFound = False
                    intInventoryQuantity = structInventory(intInventoryCounter).mintQuantity

                    'searching received transactions
                    For intReceivedCounter = 0 To mintReceivedUpperLimit

                        'getting part number
                        strTransactionPartNumber = structReceivedParts(intReceivedCounter).mstrPartNumber

                        'if statements and adding to the quantity received
                        If strTransactionPartNumber = strPartNumberForSearch Then
                            intQuantityReceived = intQuantityReceived + structReceivedParts(intReceivedCounter).mintQuantity
                        End If
                    Next

                    'searching used material
                    For intUsedCounter = 0 To mintUsedUpperLimit

                        'getting part number
                        strTransactionPartNumber = structUsedParts(intUsedCounter).mstrPartNumber

                        If strPartNumberForSearch = strTransactionPartNumber Then
                            intQuantityReported = intQuantityReported + structUsedParts(intUsedCounter).mintQuantity
                        End If
                    Next
                End If
            Next

            If blnPartNotFound = False Then
                structCompleteInventory(mintCompleteInventoryCounter).mstrPartNumber = strPartNumberForSearch
                structCompleteInventory(mintCompleteInventoryCounter).mstrDescription = structPartNumbers(intPartCounter).mstrDescription
                structCompleteInventory(mintCompleteInventoryCounter).mintQTYReceived = intQuantityReceived
                structCompleteInventory(mintCompleteInventoryCounter).mintQTYUsed = intQuantityReported
                structCompleteInventory(mintCompleteInventoryCounter).mintQTYResponsible = intInventoryQuantity
                mintCompleteInventoryCounter += 1
            End If
        Next

        mintCompleteInventoryUpperLimit = mintCompleteInventoryCounter - 1
        mintCompleteInventoryCounter = 0
        mintResultsCounter = 0

        'filling the grid view
        For intPartCounter = 0 To mintCompleteInventoryUpperLimit

            structSearchResults(intPartCounter).mstrPartNumber = structCompleteInventory(intPartCounter).mstrPartNumber
            structSearchResults(intPartCounter).mstrDescription = structCompleteInventory(intPartCounter).mstrDescription
            structSearchResults(intPartCounter).mintQTYReceived = structCompleteInventory(intPartCounter).mintQTYReceived
            structSearchResults(intPartCounter).mintQTYUsed = structCompleteInventory(intPartCounter).mintQTYUsed
            structSearchResults(intPartCounter).mintQTYResponsible = structCompleteInventory(intPartCounter).mintQTYResponsible
            mintResultsCounter += 1

        Next

        mintResultsUpperLimit = mintResultsCounter - 1
        mintResultsCounter = 0

        'loading the data gridview
        LoadDataGridView()

    End Sub
    Private Function SetUsedPartsDataBindings() As Boolean

        Dim intCounter As Integer
        Dim intNumberOfRecords As Integer
        Dim blnFatalError As Boolean = False
        Dim blnIsNotaTWCPartNumber As Boolean = False
        Dim blnItemNotFound As Boolean = True
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
            txtPartNumber.DataBindings.Add("text", TheBOMPartsBindingSource, "PartNumber")
            txtQuantity.DataBindings.Add("text", TheBOMPartsBindingSource, "QTY")
            txtWarehouseID.DataBindings.Add("text", TheBOMPartsBindingSource, "WarehouseID")

            'setting up for the loop
            intNumberOfRecords = cboTransactionID.Items.Count - 1
            ReDim structUsedParts(intNumberOfRecords)
            mintUsedCounter = 0
            mintUsedUpperLimit = 0
            intWarehouseIDForSearch = Logon.mintPartsWarehouseID

            'beginning loop
            For intCounter = 0 To intNumberOfRecords

                'this will increment the combo box
                cboTransactionID.SelectedIndex = intCounter

                'getting the warehouse ID
                intWarehouseIDFromTable = CInt(txtWarehouseID.Text)

                If intWarehouseIDForSearch = intWarehouseIDFromTable Then

                    'ensuring that part number is a Time Warner Part Number
                    blnIsNotaTWCPartNumber = TheCheckTWCPartNumber.CheckPartNumber(txtPartNumber.Text)

                    'if statement if part number is a TWC part number
                    If blnIsNotaTWCPartNumber = False Then

                        structUsedParts(mintUsedCounter).mintQuantity = CInt(txtQuantity.Text)
                        structUsedParts(mintUsedCounter).mintWarehouseID = CInt(txtWarehouseID.Text)
                        structUsedParts(mintUsedCounter).mstrPartNumber = txtPartNumber.Text
                        mintUsedCounter += 1
                        blnItemNotFound = False

                    End If

                End If

            Next

            If blnItemNotFound = True Then
                mstrErrorMessage = "No Processed Parts for this Warehouse"
                blnFatalError = True
            ElseIf blnItemNotFound = False Then
                mintUsedUpperLimit = mintUsedCounter - 1
                mintUsedCounter = 0
            End If

            'Returning value to calling sub-routine
            Return blnFatalError

        Catch ex As Exception
            mstrErrorMessage = ex.Message
            blnFatalError = True
            Return blnFatalError
        End Try

    End Function

    Private Function SetReceivedDataBindings() As Boolean

        'setting local variables
        Dim intCounter As Integer
        Dim intNumberOfRecords As Integer
        Dim blnFatalError As Boolean = False
        Dim blnItemsNotFound As Boolean = True
        Dim intWarehouseIDForSearch As Integer
        Dim intWarehouseIDFromTable As Integer
        Dim blnNotTimeWarnerPart As Boolean

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
            txtPartNumber.DataBindings.Add("text", TheReceivedPartsBindingSource, "PartNumber")
            txtQuantity.DataBindings.Add("text", TheReceivedPartsBindingSource, "QTY")
            txtWarehouseID.DataBindings.Add("text", TheReceivedPartsBindingSource, "WarehouseID")

            'setting up for the loop
            intNumberOfRecords = cboTransactionID.Items.Count - 1
            ReDim structReceivedParts(intNumberOfRecords)
            mintReceivedCounter = 0
            mintReceivedUpperLimit = 0
            intWarehouseIDForSearch = Logon.mintPartsWarehouseID

            'Beginning Loop
            For intCounter = 0 To intNumberOfRecords

                'incrementing the combo box
                cboTransactionID.SelectedIndex = intCounter

                'getting the information
                blnNotTimeWarnerPart = TheCheckTWCPartNumber.CheckPartNumber(txtPartNumber.Text)
                intWarehouseIDFromTable = CInt(txtWarehouseID.Text)

                'if statements
                If blnNotTimeWarnerPart = False Then
                    If intWarehouseIDForSearch = intWarehouseIDFromTable Then

                        structReceivedParts(mintReceivedCounter).mintQuantity = CInt(txtQuantity.Text)
                        structReceivedParts(mintReceivedCounter).mintWarehouseID = CInt(txtWarehouseID.Text)
                        structReceivedParts(mintReceivedCounter).mstrPartNumber = txtPartNumber.Text
                        mintReceivedCounter += 1
                        blnItemsNotFound = False

                    End If
                End If
            Next

            If blnItemsNotFound = True Then
                blnFatalError = True
                mstrErrorMessage = "No Received Parts for this Warehouse"
            ElseIf blnItemsNotFound = False Then
                mintReceivedUpperLimit = mintReceivedCounter - 1
                mintReceivedCounter = 0
            End If

            'returning value to calling sub routine
            Return blnFatalError

        Catch ex As Exception

            'setting up output for user
            mstrErrorMessage = ex.Message
            blnFatalError = True

            'returning value to calling sub routine
            Return blnFatalError

        End Try

    End Function
    Private Function SetInventoryDataBindings() As Boolean

        'setting local variables
        Dim intCounter As Integer
        Dim intNumberOfRecords As Integer
        Dim blnFatalError As Boolean = False
        Dim blnItemsNotFound As Boolean = True
        Dim intWarehouseIDForSearch As Integer
        Dim intWarehouseIDFromTable As Integer
        Dim blnNotTimeWarnerPart As Boolean

        'try catch for exceptions
        Try

            'setting global data variables
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
            With cboTransactionID
                .DataSource = TheInventoryBindingSource
                .DisplayMember = "PartID"
                .DataBindings.Add("Text", TheInventoryBindingSource, "PartID", False, DataSourceUpdateMode.Never)
            End With

            'setting up the rest of the controls
            txtPartNumber.DataBindings.Add("text", TheInventoryBindingSource, "PartNumber")
            txtQuantity.DataBindings.Add("Text", TheInventoryBindingSource, "QTYResponible")
            txtWarehouseID.DataBindings.Add("text", TheInventoryBindingSource, "WarehouseID")

            'getting ready for loop and setting size of structure
            intNumberOfRecords = cboTransactionID.Items.Count - 1
            ReDim structInventory(intNumberOfRecords)
            mintInventoryCounter = 0
            intWarehouseIDForSearch = CInt(Logon.mintPartsWarehouseID)

            For intCounter = 0 To intNumberOfRecords

                'incrementing the combo box
                cboTransactionID.SelectedIndex = intCounter

                'checking time warner part number
                blnNotTimeWarnerPart = TheCheckTWCPartNumber.CheckPartNumber(txtPartNumber.Text)
                intWarehouseIDFromTable = CInt(txtWarehouseID.Text)

                If blnNotTimeWarnerPart = False Then
                    If intWarehouseIDForSearch = intWarehouseIDFromTable Then

                        structInventory(mintInventoryCounter).mstrPartNumber = txtPartNumber.Text
                        structInventory(mintInventoryCounter).mintQuantity = CInt(txtQuantity.Text)
                        structInventory(mintInventoryCounter).mintWarehouseID = CInt(txtWarehouseID.Text)
                        blnItemsNotFound = False
                        mintInventoryCounter += 1

                    End If
                End If
            Next

            If blnItemsNotFound = True Then
                blnFatalError = True
                mstrErrorMessage = "No Time Warner Parts Found for this Warehouse"
            ElseIf blnItemsNotFound = False Then
                mintInventoryUpperLimit = mintInventoryCounter - 1
                mintInventoryCounter = 0
            End If

            'returning value to calling sub routine
            Return blnFatalError

        Catch ex As Exception

            'setting up output for user
            mstrErrorMessage = ex.Message
            blnFatalError = True

            'returning value to calling sub routine
            Return blnFatalError

        End Try

    End Function
    Private Function SetPartNumberDataBindings() As Boolean

        'Setting local variables
        Dim intCounter As Integer
        Dim intNumberOfRecords As Integer
        Dim blnFatalError As Boolean = False
        Dim blnNotTimeWarnerPart As Boolean
        Dim blnNoPartsFound As Boolean = True

        'Try Catch for exceptions
        Try

            'setting up the global variables
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

            With cboTransactionID
                .DataSource = ThePartNumberBindingSource
                .DisplayMember = "PartID"
                .DataBindings.Add("text", ThePartNumberBindingSource, "PartID", False, DataSourceUpdateMode.Never)
            End With

            'setting up the rest of the needed controls
            txtPartDescription.DataBindings.Add("text", ThePartNumberBindingSource, "Description")
            txtPartNumber.DataBindings.Add("text", ThePartNumberBindingSource, "PartNumber")

            'setting up the structure and getting ready for loop
            intNumberOfRecords = cboTransactionID.Items.Count - 1
            ReDim structPartNumbers(intNumberOfRecords)
            ReDim structSearchResults(intNumberOfRecords)
            ReDim structCompleteInventory(intNumberOfRecords)
            mintPartCounter = 0

            'beginning loop
            For intCounter = 0 To intNumberOfRecords

                'incrementing the combo box
                cboTransactionID.SelectedIndex = intCounter

                blnNotTimeWarnerPart = TheCheckTWCPartNumber.CheckPartNumber(txtPartNumber.Text)

                If blnNotTimeWarnerPart = False Then

                    structPartNumbers(mintPartCounter).mintPartID = CInt(cboTransactionID.Text)
                    structPartNumbers(mintPartCounter).mstrDescription = txtPartDescription.Text
                    structPartNumbers(mintPartCounter).mstrPartNumber = txtPartNumber.Text
                    mintPartCounter += 1
                    blnNoPartsFound = False

                End If
            Next

            If blnNoPartsFound = True Then
                blnFatalError = True
                mstrErrorMessage = "No TWC Parts Were Found"
            ElseIf blnNoPartsFound = False Then
                mintPartUpperLimit = mintPartCounter - 1
                mintPartCounter = 0
                blnFatalError = False
            End If

            'returning value to calling sub-routine
            Return blnFatalError

        Catch ex As Exception

            'message to user if there is a failure
            mstrErrorMessage = ex.Message
            blnFatalError = True

            'returning value to calling sub-routine
            Return blnFatalError

        End Try

    End Function
    Private Sub ClearDataBindings()

        'this will clear the data bindings
        cboTransactionID.DataBindings.Clear()
        txtPartDescription.DataBindings.Clear()
        txtPartNumber.DataBindings.Clear()
        txtQuantity.DataBindings.Clear()
        txtWarehouseID.DataBindings.Clear()

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
    Private Sub LoadDataGridView()

        Dim intcounter As Integer
        Dim rows() As String

        'this sub-routine will load the data grid
        dgvSearchResults.Rows.Clear()

        'loading grid
        For intcounter = 0 To mintResultsUpperLimit

            rows = New String() {structSearchResults(intcounter).mstrPartNumber, structSearchResults(intcounter).mstrDescription, CStr(structSearchResults(intcounter).mintQTYReceived), CStr(structSearchResults(intcounter).mintQTYUsed), CStr(structSearchResults(intcounter).mintQTYResponsible)}
            dgvSearchResults.Rows.Add(rows)

        Next

    End Sub

    Private Sub btnResetGrid_Click(sender As Object, e As EventArgs) Handles btnResetGrid.Click

        'this will reset the grid
        FillGridView()

    End Sub
End Class