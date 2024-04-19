'Title:         Part Project Transaction Report
'Date:          5-13-15
'Author:        Terry

'Description:   This form will break down parts per project breakdown

Option Strict On

Public Class PartProjectTransactionReport

    Private ThePartNumberDataTier As PartsDataTier
    Private ThePartNumberDataSet As PartNumberDataSet
    Private WithEvents ThePartNumberBindingSource As BindingSource

    Private TheIssuedPartsDataTier As TWInventoryDataTier
    Private TheIssuedPartsDataSet As IssuedPartsDataSet
    Private WithEvents TheIssuedPartsBindingSource As BindingSource

    Private TheReceivedPartsDataTier As TWInventoryDataTier
    Private TheReceivedPartsDataSet As ReceivedPartsDataSet
    Private WithEvents TheReceivedPartsBindingSource As BindingSource

    Private TheBOMPartsDataTier As TWInventoryDataTier
    Private TheBOMPartsDataSet As BOMPartsDataSet
    Private WithEvents TheBOMPartsBindingSource As BindingSource

    Private TheInternalProjectsDataSet As InternalProjectsDataSet
    Private TheInternalProjectsDataTier As InternalProjectsDataTier
    Private WithEvents TheInternalProjectsBindingSource As BindingSource

    Private addingBoolean As Boolean = False
    Private editingBoolean As Boolean = False
    Private previouseSelectedIndex As Integer

    Dim TheInputDataValidation As New InputDataValidation
    Dim TheKeyWordSearchClass As New KeyWordSearchClass
    Dim TheCheckTimeWarnerPartNumber As New CheckTimeWarnerPartNumber

    Dim mintNewPrintCounter As Integer
    Dim LogDate As Date = Date.Now
    Dim mstrDate As String

    Structure PartNumbers
        Dim mstrPartNumber As String
        Dim mstrPartDescription As String
    End Structure

    Dim mintPartNumberUpperLimit As Integer
    Dim mintPartNumberCounter As Integer
    Dim structPartNumbers() As PartNumbers

    'Setting up global variables
    Dim mstrPartNumber As String
    Dim mintQuantityIssued As Integer
    Dim mintQuantityReceived As Integer
    Dim mintQuantityUsed As Integer
    
    'Setting up the Received Part Structure
    Structure ReceivedParts
        Dim mstrPartNumber As String
        Dim mintQuantity As Integer
        Dim mstrProjectID As String
        Dim mintWarehouseID As Integer
        Dim mstrMSRNumber As String
    End Structure

    Dim structReceivedParts() As ReceivedParts
    Dim mintReceivedUpperLimit As Integer
    Dim mintReceivedCounter As Integer

    'Setting up the Issued Part Structrue
    Structure IssuedParts
        Dim mstrPartNumber As String
        Dim mintQuantity As Integer
        Dim mstrProjectID As String
        Dim mintWarehouseID As Integer
    End Structure

    Dim structIssuedParts() As IssuedParts
    Dim mintIssuedUpperLimit As Integer
    Dim mintIssuedCounter As Integer

    'Setting up the Used Part Structure
    Structure UsedParts
        Dim mstrPartNumber As String
        Dim mintQuantity As Integer
        Dim mstrProjectID As String
        Dim mintWarehouseID As Integer
    End Structure

    Dim structUsedParts() As UsedParts
    Dim mintUsedUpperLimit As Integer
    Dim mintUsedCounter As Integer

    Structure SearchResults
        Dim mstrProjectID As String
        Dim mstrMSRNumber As String
        Dim mintQuantityReceived As Integer
        Dim mintQuantityIssued As Integer
        Dim mintQuantityUsed As Integer
    End Structure

    Dim structSearchResults() As SearchResults
    Dim mintResultsUpperLimit As Integer = 0
    Dim mintResultsCounter As Integer

    Structure Projects
        Dim mintInternalProjectID As Integer
        Dim mstrTWCProjectID As String
        Dim mstrMSRNumber As String
    End Structure

    Dim structProjects() As Projects
    Dim mintProjectCounter As Integer
    Dim mintProjectUpperLimit As Integer
    Dim mstrErrorMessage As String

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        'This will close the project
        CloseProgram.ShowDialog()

    End Sub

    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click

        'This will show the main menu
        LastTransaction.Show()
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub btnReportMenu_Click(sender As Object, e As EventArgs) Handles btnReportMenu.Click

        'This will load the report menu
        LastTransaction.Show()
        ReportMenu.Show()
        Me.Close()

    End Sub
    Private Function SetPartNumberDataBindings() As Boolean

        Dim blnFatalError As Boolean = False
        Dim intCounter As Integer
        Dim intNumberOfRecords As Integer
        Dim blnIsNotATimeWarnerPartNumber As Boolean
        Dim blnItemNotFound As Boolean = True

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
                .DataBindings.Add("Text", ThePartNumberBindingSource, "PartNumber", False, DataSourceUpdateMode.Never)
            End With

            'setting up the rest of the controls
            txtPartDescription.DataBindings.Add("text", ThePartNumberBindingSource, "Description")

            'Setting up for the loop
            intNumberOfRecords = cboPartNumber.Items.Count - 1
            ReDim structPartNumbers(intNumberOfRecords)
            mintPartNumberCounter = 0

            'Beginning loop
            For intCounter = 0 To intNumberOfRecords

                'incrementing the combo box
                cboPartNumber.SelectedIndex = intCounter

                'checking the part number
                blnIsNotATimeWarnerPartNumber = TheCheckTimeWarnerPartNumber.CheckPartNumber(cboPartNumber.Text)

                'If statements verifying part number
                If blnIsNotATimeWarnerPartNumber = False Then
                    structPartNumbers(mintPartNumberCounter).mstrPartNumber = cboPartNumber.Text
                    structPartNumbers(mintPartNumberCounter).mstrPartDescription = txtPartDescription.Text
                    mintPartNumberCounter += 1
                    blnItemNotFound = False
                End If

            Next

            If blnItemNotFound = True Then
                mstrErrorMessage = "There are no Time Warner Part Numbers"
            End If

            blnFatalError = blnItemNotFound

            'returning back to calling routine
            Return blnFatalError

        Catch ex As Exception

            'Message to user and returning back to calling routine
            mstrErrorMessage = ex.Message
            blnFatalError = True
            Return blnFatalError

        End Try
    End Function
    Private Function SetIssuedTransactionsBindings() As Boolean

        'Setting local variables
        Dim blnFatalError As Boolean = False
        Dim blnItemNotFound As Boolean = True
        Dim intCounter As Integer
        Dim intNumberOfRecords As Integer
        Dim intWarehouseIDForSearch As Integer
        Dim intWarehouseIDFromTable As Integer

        'Try catch for exceptions
        Try

            'Settingg up the bindings
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
                .DataBindings.Add("Text", TheIssuedPartsBindingSource, "TransactionID", False, DataSourceUpdateMode.Never)
            End With

            'Setting up the rest of the controls
            txtTransactionPartNumber.DataBindings.Add("text", TheIssuedPartsBindingSource, "PartNumber")
            txtTransactionProjectID.DataBindings.Add("Text", TheIssuedPartsBindingSource, "ProjectID")
            txtTransactionQuantity.DataBindings.Add("text", TheIssuedPartsBindingSource, "QTY")
            txtTransactionWarehouseID.DataBindings.Add("Text", TheIssuedPartsBindingSource, "WarehouseID")

            'Setting up for the loop
            intNumberOfRecords = cboTransactionID.Items.Count - 1
            ReDim structIssuedParts(intNumberOfRecords)
            mintIssuedCounter = 0
            intWarehouseIDForSearch = Logon.mintPartsWarehouseID

            For intCounter = 0 To intNumberOfRecords

                'incrementing the combo box
                cboTransactionID.SelectedIndex = intCounter

                intWarehouseIDFromTable = CInt(txtTransactionWarehouseID.Text)

                'if statement to see if the warehouses match
                If intWarehouseIDForSearch = intWarehouseIDFromTable Then

                    structIssuedParts(mintIssuedCounter).mintWarehouseID = intWarehouseIDFromTable
                    structIssuedParts(mintIssuedCounter).mintQuantity = CInt(txtTransactionQuantity.Text)
                    structIssuedParts(mintIssuedCounter).mstrPartNumber = txtTransactionPartNumber.Text
                    structIssuedParts(mintIssuedCounter).mstrProjectID = txtTransactionProjectID.Text
                    blnItemNotFound = False
                    mintIssuedCounter += 1

                End If

            Next

            'finishing the sub routine
            mintIssuedUpperLimit = mintIssuedCounter - 1
            mintIssuedCounter = 0
            blnFatalError = blnItemNotFound

            'Returning value to calling sub-routine
            Return blnFatalError

        Catch ex As Exception

            'Message to user
            mstrErrorMessage = ex.Message
            blnFatalError = True
            Return blnFatalError

        End Try

    End Function
    Private Function SetReceivedDataBindings() As Boolean

        'Setting local variables
        Dim blnFatalError As Boolean = False
        Dim blnItemNotFound As Boolean = True
        Dim intCounter As Integer
        Dim intNumberOfRecords As Integer
        Dim intWarehouseIDForSearch As Integer
        Dim intWarehouseIDFromTable As Integer

        'Try catch for exceptions
        Try

            'Settingg up the bindings
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
            txtTransactionPartNumber.DataBindings.Add("text", TheReceivedPartsBindingSource, "PartNumber")
            txtTransactionProjectID.DataBindings.Add("Text", TheReceivedPartsBindingSource, "ProjectID")
            txtTransactionQuantity.DataBindings.Add("text", TheReceivedPartsBindingSource, "QTY")
            txtTransactionWarehouseID.DataBindings.Add("Text", TheReceivedPartsBindingSource, "WarehouseID")
            txtTransactionMSRNumber.DataBindings.Add("text", TheReceivedPartsBindingSource, "MSRNumber")

            'Setting up for the loop
            intNumberOfRecords = cboTransactionID.Items.Count - 1
            ReDim structReceivedParts(intNumberOfRecords)
            ReDim structSearchResults(intNumberOfRecords)
            mintResultsUpperLimit = intNumberOfRecords
            ClearSearchResultsStructure()
            mintReceivedCounter = 0
            intWarehouseIDForSearch = Logon.mintPartsWarehouseID

            For intCounter = 0 To intNumberOfRecords

                'incrementing the combo box
                cboTransactionID.SelectedIndex = intCounter

                intWarehouseIDFromTable = CInt(txtTransactionWarehouseID.Text)

                'if statement to see if the warehouses match
                If intWarehouseIDForSearch = intWarehouseIDFromTable Then

                    Logon.mstrTWCProjectID = txtTransactionProjectID.Text
                    Logon.mstrMSR = txtTransactionMSRNumber.Text
                    FindMSRProjectID()

                        structReceivedParts(mintReceivedCounter).mintWarehouseID = intWarehouseIDFromTable
                        structReceivedParts(mintReceivedCounter).mintQuantity = CInt(txtTransactionQuantity.Text)
                        structReceivedParts(mintReceivedCounter).mstrPartNumber = txtTransactionPartNumber.Text
                        structReceivedParts(mintReceivedCounter).mstrProjectID = Logon.mstrTWCProjectID
                        structReceivedParts(mintReceivedCounter).mstrMSRNumber = Logon.mstrMSR
                        blnItemNotFound = False
                        mintReceivedCounter += 1

                End If

            Next

            'finishing the sub routine
            mintReceivedUpperLimit = mintReceivedCounter - 1
            mintReceivedCounter = 0
            blnFatalError = blnItemNotFound

            'Returning value to calling sub-routine
            Return blnFatalError

        Catch ex As Exception

            'Message to user
            mstrErrorMessage = ex.Message
            blnFatalError = True
            Return blnFatalError

        End Try

    End Function
    Private Function SetUsedDataBindings() As Boolean

        'Setting local variables
        Dim blnFatalError As Boolean = False
        Dim blnItemNotFound As Boolean = True
        Dim intCounter As Integer
        Dim intNumberOfRecords As Integer
        Dim intWarehouseIDForSearch As Integer
        Dim intWarehouseIDFromTable As Integer

        'Try catch for exceptions
        Try

            'Settingg up the bindings
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

            'Setting up the combo box
            With cboTransactionID
                .DataSource = TheBOMPartsBindingSource
                .DisplayMember = "TransactionID"
                .DataBindings.Add("Text", TheBOMPartsBindingSource, "TransactionID", False, DataSourceUpdateMode.Never)
            End With

            'Setting up the rest of the controls
            txtTransactionPartNumber.DataBindings.Add("text", TheBOMPartsBindingSource, "PartNumber")
            txtTransactionProjectID.DataBindings.Add("Text", TheBOMPartsBindingSource, "ProjectID")
            txtTransactionQuantity.DataBindings.Add("text", TheBOMPartsBindingSource, "QTY")
            txtTransactionWarehouseID.DataBindings.Add("Text", TheBOMPartsBindingSource, "WarehouseID")

            'Setting up for the loop
            intNumberOfRecords = cboTransactionID.Items.Count - 1
            ReDim structUsedParts(intNumberOfRecords)
            mintUsedCounter = 0
            intWarehouseIDForSearch = Logon.mintPartsWarehouseID

            For intCounter = 0 To intNumberOfRecords

                'incrementing the combo box
                cboTransactionID.SelectedIndex = intCounter

                intWarehouseIDFromTable = CInt(txtTransactionWarehouseID.Text)

                'if statement to see if the warehouses match
                If intWarehouseIDForSearch = intWarehouseIDFromTable Then

                    structUsedParts(mintUsedCounter).mintWarehouseID = intWarehouseIDFromTable
                    structUsedParts(mintUsedCounter).mintQuantity = CInt(txtTransactionQuantity.Text)
                    structUsedParts(mintUsedCounter).mstrPartNumber = txtTransactionPartNumber.Text
                    structUsedParts(mintUsedCounter).mstrProjectID = txtTransactionProjectID.Text
                    blnItemNotFound = False
                    mintUsedCounter += 1

                End If

            Next

            'finishing the sub routine
            mintUsedUpperLimit = mintUsedCounter - 1
            mintUsedCounter = 0
            blnFatalError = blnItemNotFound

            'Returning value to calling sub-routine
            Return blnFatalError

        Catch ex As Exception

            'Message to user
            mstrErrorMessage = ex.Message
            blnFatalError = True
            Return blnFatalError

        End Try

    End Function
    Private Function SetProjectBindings() As Boolean

        'setting local variables
        Dim intCounter As Integer
        Dim intNumberOfRecords As Integer
        Dim blnFatalError = False

        'try catch for exceptions
        Try

            'setting data variables
            TheInternalProjectsDataTier = New InternalProjectsDataTier
            TheInternalProjectsDataSet = TheInternalProjectsDataTier.GetInternalProjectsInformation
            TheInternalProjectsBindingSource = New BindingSource

            'setting up the binding source
            With TheInternalProjectsBindingSource
                .DataSource = TheInternalProjectsDataSet
                .DataMember = "internalprojects"
                .MoveFirst()
                .MoveLast()
            End With

            'setting up the combo box
            With cboTransactionID
                .DataSource = TheInternalProjectsBindingSource
                .DisplayMember = "internalProjectID"
                .DataBindings.Add("text", TheInternalProjectsBindingSource, "internalProjectID", False, DataSourceUpdateMode.Never)
            End With

            'setting up the rest of the controls
            txtTransactionMSRNumber.DataBindings.Add("text", TheInternalProjectsBindingSource, "MSRNumber")
            txtTransactionProjectID.DataBindings.Add("text", TheInternalProjectsBindingSource, "TWCControlNumber")

            'getting ready to fill structure
            intNumberOfRecords = cboTransactionID.Items.Count - 1
            ReDim structProjects(intNumberOfRecords)
            mintProjectUpperLimit = intNumberOfRecords

            'Running Loop
            For intCounter = 0 To intNumberOfRecords

                'incrementing the combo box
                cboTransactionID.SelectedIndex = intCounter

                'loading structure
                structProjects(intCounter).mintInternalProjectID = CInt(cboTransactionID.Text)
                structProjects(intCounter).mstrMSRNumber = txtTransactionMSRNumber.Text
                structProjects(intCounter).mstrTWCProjectID = txtTransactionProjectID.Text
            Next

            'returing call to sub-routine
            Return blnFatalError

        Catch ex As Exception

            'message to user
            mstrErrorMessage = ex.Message
            blnFatalError = True
            Return blnFatalError

        End Try

    End Function
    Private Sub FindMSRProjectID()

        'setting local variables
        Dim intCounter As Integer
        Dim strProjectIDForSearch As String
        Dim strProjectIDFromTable As String
        Dim strMSRNumberForSearch As String
        Dim strMSRNumberFromTable As String
        Dim blnMSRNotFound As Boolean
        Dim blnProjectIDNotFound As Boolean

        'setting up for the loop
        strMSRNumberForSearch = Logon.mstrMSR
        strProjectIDForSearch = Logon.mstrTWCProjectID
        blnMSRNotFound = True
        blnProjectIDNotFound = True

        'Running Loop
        For intCounter = 0 To mintProjectUpperLimit

            strMSRNumberFromTable = structProjects(intCounter).mstrMSRNumber
            strProjectIDFromTable = structProjects(intCounter).mstrTWCProjectID

            If strProjectIDForSearch = "WHS" Then
                If strMSRNumberForSearch = strMSRNumberFromTable Then
                    Logon.mstrTWCProjectID = strProjectIDFromTable
                    blnMSRNotFound = False
                    blnProjectIDNotFound = False
                End If
            ElseIf strProjectIDForSearch <> "WHS" Then
                If strProjectIDForSearch = strProjectIDFromTable Then
                    blnProjectIDNotFound = False
                    If strMSRNumberFromTable = "" Then
                        blnMSRNotFound = True
                    ElseIf strMSRNumberFromTable <> "" Then
                        Logon.mstrMSR = strMSRNumberFromTable
                        blnMSRNotFound = False
                    End If
                End If
            End If

        Next

        If blnProjectIDNotFound = True Then
            Logon.mstrTWCProjectID = strProjectIDForSearch
        End If
        If blnMSRNotFound = True Then
            Logon.mstrMSR = strMSRNumberForSearch
        End If

    End Sub

    Private Sub PartProjectTransactionReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Setting local variables
        Dim blnFatalError As Boolean

        PleaseWait.Show()

        'Setting binding and loading structures
        blnFatalError = SetPartNumberDataBindings()
        If blnFatalError = False Then
            ClearTransactionDataBindings()
            blnFatalError = SetProjectBindings()
            If blnFatalError = False Then
                ClearTransactionDataBindings()
                blnFatalError = SetReceivedDataBindings()
                If blnFatalError = False Then
                    ClearTransactionDataBindings()
                    blnFatalError = SetUsedDataBindings()
                    If blnFatalError = False Then
                        ClearTransactionDataBindings()
                        blnFatalError = SetIssuedTransactionsBindings()
                    End If
                End If
            End If
        End If

        If blnFatalError = True Then
            btnFindPartNumber.Enabled = False
            SetControlsVisible(False)
            btnFindPartNumber.Enabled = False
            btnRunReport.Enabled = False
            MessageBox.Show(mstrErrorMessage, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            dgvSearchResults.ColumnCount = 5
            dgvSearchResults.Columns(0).Name = "Project ID"
            dgvSearchResults.Columns(0).Width = 100
            dgvSearchResults.Columns(1).Name = "MSR Number"
            dgvSearchResults.Columns(1).Width = 100
            dgvSearchResults.Columns(2).Name = "Quantity Received"
            dgvSearchResults.Columns(3).Name = "Quantity Issued"
            dgvSearchResults.Columns(4).Name = "Quantity Reported"
            btnRunReport.Enabled = False
        End If

        PleaseWait.Close()

    End Sub

    Private Sub ClearTransactionDataBindings()

        'This will clear the transaction Data bindings
        cboTransactionID.DataBindings.Clear()
        txtTransactionPartNumber.DataBindings.Clear()
        txtTransactionQuantity.DataBindings.Clear()
        txtTransactionProjectID.DataBindings.Clear()
        txtTransactionWarehouseID.DataBindings.Clear()
        txtTransactionMSRNumber.DataBindings.Clear()

    End Sub
    Private Sub btnFindPartNumber_Click(sender As Object, e As EventArgs) Handles btnFindPartNumber.Click

        'This subroutine will load up the structure and gridview
        'Setting local variables
        Dim intCounter As Integer
        Dim intSearchResultsCounter As Integer
        Dim strPartNumberForSearch As String
        Dim strPartNumberFromTable As String
        Dim blnPartNumberDoesNotExist As Boolean = True
        Dim blnFatalError As Boolean
        Dim blnNotATWCPartNumber As Boolean
        Dim intSearchResultSelectedIndex As Integer
        Dim blnItemNotInStructure As Boolean
        Dim strProjectIDForSearch As String
        Dim strProjectIDFromTable As String
        Dim row() As String
        Dim strProjectIDForGrid As String
        Dim strMSRNumberForGrid As String
        Dim strQuantityReceivedForGrid As String
        Dim strQuantityIssuedForGrid As String
        Dim strQuantityUsedForGrid As String
        Dim strMSRNumberForSearch As String
        Dim strMSRNumberFromTable As String

        'Performing data validation
        strPartNumberForSearch = txtFindPartNumber.Text
        blnFatalError = TheInputDataValidation.VerifyTextData(strPartNumberForSearch)
        If blnFatalError = True Then
            MessageBox.Show("Part Number was not Entered", "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'Checking Part Number
        blnNotATWCPartNumber = TheCheckTimeWarnerPartNumber.CheckPartNumber(strPartNumberForSearch)
        If blnNotATWCPartNumber = True Then
            MessageBox.Show("Part Number Entered is not a Time Warner Part Number", "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'setting global variables
        mintResultsCounter = 0
        mintResultsUpperLimit = 0

        'Setting up for the search
        For intCounter = 0 To mintReceivedUpperLimit

            'getting part number
            strPartNumberFromTable = structReceivedParts(intCounter).mstrPartNumber

            'if statement for comparing part number
            If strPartNumberForSearch = strPartNumberFromTable Then

                'Boolean variable indicating the part number has been found
                blnPartNumberDoesNotExist = False

                'getting the project ID
                strProjectIDForSearch = structReceivedParts(intCounter).mstrProjectID
                strMSRNumberForSearch = structReceivedParts(intCounter).mstrMSRNumber

                'setting boolean variable
                blnItemNotInStructure = True

                'beginning search for search results
                For intSearchResultsCounter = 0 To mintResultsUpperLimit

                    'getting project id from table
                    strProjectIDFromTable = structSearchResults(intSearchResultsCounter).mstrProjectID
                    strMSRNumberFromTable = structSearchResults(intSearchResultsCounter).mstrMSRNumber

                    If strProjectIDFromTable <> "WHS" Then
                        If strProjectIDForSearch = strProjectIDFromTable Then

                            'setting up to update structure
                            intSearchResultSelectedIndex = intSearchResultsCounter

                        End If
                    ElseIf strProjectIDFromTable = "WHS" Then
                        If strMSRNumberForSearch = strMSRNumberFromTable Then

                            'setting up to update structure
                            intSearchResultSelectedIndex = intSearchResultsCounter
                            blnItemNotInStructure = False

                        End If
                    End If

                Next

                'putting data into structure
                If blnItemNotInStructure = False Then

                    'performing math
                    structSearchResults(intSearchResultSelectedIndex).mintQuantityReceived = structSearchResults(intSearchResultSelectedIndex).mintQuantityReceived + structReceivedParts(intCounter).mintQuantity

                ElseIf blnItemNotInStructure = True Then

                    structSearchResults(mintResultsCounter).mstrProjectID = strProjectIDForSearch
                    structSearchResults(mintResultsCounter).mstrMSRNumber = strMSRNumberForSearch
                    structSearchResults(mintResultsCounter).mintQuantityReceived = structReceivedParts(intCounter).mintQuantity
                    structSearchResults(mintResultsCounter).mintQuantityIssued = 0
                    structSearchResults(mintResultsCounter).mintQuantityUsed = 0
                    mintResultsCounter += 1
                    mintResultsUpperLimit += 1

                End If

            End If
        Next

        For intCounter = 0 To mintIssuedUpperLimit

            'getting part number
            strPartNumberFromTable = structIssuedParts(intCounter).mstrPartNumber

            'if statement for comparing part number
            If strPartNumberForSearch = strPartNumberFromTable Then

                'Boolean variable indicating the part number has been found
                blnPartNumberDoesNotExist = False

                'getting the project ID
                strProjectIDForSearch = structIssuedParts(intCounter).mstrProjectID

                'setting boolean variable
                blnItemNotInStructure = True

                'beginning search for search results
                For intSearchResultsCounter = 0 To mintResultsUpperLimit

                    'getting project id from table
                    strProjectIDFromTable = structSearchResults(intSearchResultsCounter).mstrProjectID

                    If strProjectIDForSearch = strProjectIDFromTable Then

                        'setting up to update structure
                        intSearchResultSelectedIndex = intSearchResultsCounter
                        blnItemNotInStructure = False

                    End If

                Next

                'putting data into structure
                If blnItemNotInStructure = False Then

                    'performing math
                    structSearchResults(intSearchResultSelectedIndex).mintQuantityIssued = structSearchResults(intSearchResultSelectedIndex).mintQuantityIssued + structIssuedParts(intCounter).mintQuantity

                ElseIf blnItemNotInStructure = True Then

                    structSearchResults(mintResultsCounter).mstrProjectID = strProjectIDForSearch
                    structSearchResults(mintResultsCounter).mintQuantityReceived = 0
                    structSearchResults(mintResultsCounter).mintQuantityIssued = structIssuedParts(intCounter).mintQuantity
                    structSearchResults(mintResultsCounter).mintQuantityUsed = 0
                    mintResultsCounter += 1
                    mintResultsUpperLimit += 1

                End If

            End If
        Next

        For intCounter = 0 To mintUsedUpperLimit

            'getting part number
            strPartNumberFromTable = structUsedParts(intCounter).mstrPartNumber

            'if statement for comparing part number
            If strPartNumberForSearch = strPartNumberFromTable Then

                'Boolean variable indicating the part number has been found
                blnPartNumberDoesNotExist = False

                'getting the project ID
                strProjectIDForSearch = structUsedParts(intCounter).mstrProjectID

                'setting boolean variable
                blnItemNotInStructure = True

                'beginning search for search results
                For intSearchResultsCounter = 0 To mintResultsUpperLimit

                    'getting project id from table
                    strProjectIDFromTable = structSearchResults(intSearchResultsCounter).mstrProjectID

                    If strProjectIDForSearch = strProjectIDFromTable Then

                        'setting up to update structure
                        intSearchResultSelectedIndex = intSearchResultsCounter
                        blnItemNotInStructure = False

                    End If

                Next

                'putting data into structure
                If blnItemNotInStructure = False Then

                    'performing math
                    structSearchResults(intSearchResultSelectedIndex).mintQuantityUsed = structSearchResults(intSearchResultSelectedIndex).mintQuantityUsed + structUsedParts(intCounter).mintQuantity

                ElseIf blnItemNotInStructure = True Then

                    structSearchResults(mintResultsCounter).mstrProjectID = strProjectIDForSearch
                    structSearchResults(mintResultsCounter).mintQuantityReceived = 0
                    structSearchResults(mintResultsCounter).mintQuantityIssued = 0
                    structSearchResults(mintResultsCounter).mintQuantityUsed = structUsedParts(intCounter).mintQuantity
                    mintResultsCounter += 1
                    mintResultsUpperLimit += 1

                End If

            End If
        Next

        If blnPartNumberDoesNotExist = True Then
            MessageBox.Show("There are no Transactions for Part Number Entered", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtFindPartNumber.Text = ""
            Exit Sub
        End If

        'Loading up the data grid
        dgvSearchResults.Visible = True
        dgvSearchResults.Rows.Clear()

        For intCounter = 0 To mintResultsUpperLimit - 1

            strProjectIDForGrid = structSearchResults(intCounter).mstrProjectID
            strMSRNumberForGrid = structSearchResults(intCounter).mstrMSRNumber
            strQuantityReceivedForGrid = CStr(structSearchResults(intCounter).mintQuantityReceived)
            strQuantityIssuedForGrid = CStr(structSearchResults(intCounter).mintQuantityIssued)
            strQuantityUsedForGrid = CStr(structSearchResults(intCounter).mintQuantityUsed)
            row = New String() {strProjectIDForGrid, strMSRNumberForGrid, strQuantityReceivedForGrid, strQuantityIssuedForGrid, strQuantityUsedForGrid}
            dgvSearchResults.Rows.Add(row)

        Next

        btnRunReport.Enabled = True

    End Sub
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        'This will print the document
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
        Dim intCharacterLimit As Integer = 25
        Dim strPartDescription As String = ""

        'Setting up for default position
        PrintY = 100

        'Setting up for the print header
        PrintX = 150
        e.Graphics.DrawString("Blue Jay Communications Transaction Report", PrintHeaderFont, Brushes.Black, PrintX, PrintY)
        PrintY = PrintY + HeadingLineHeight
        PrintX = 200
        e.Graphics.DrawString("Project Transactions for Part Number:  " + mstrPartNumber, PrintSubHeaderFont, Brushes.Black, PrintX, PrintY)
        PrintY = PrintY + HeadingLineHeight
        PrintX = 200
        e.Graphics.DrawString(txtPartDescription.Text, PrintSubHeaderFont, Brushes.Black, PrintX, PrintY)
        PrintY = PrintY + HeadingLineHeight

        'Setting up the columns
        PrintX = 100
        e.Graphics.DrawString("Project ID", PrintItemsFont, Brushes.Black, PrintX, PrintY)
        PrintX = 300
        e.Graphics.DrawString("Qty Rec", PrintItemsFont, Brushes.Black, PrintX, PrintY)
        PrintX = 500
        e.Graphics.DrawString("Qty Iss", PrintItemsFont, Brushes.Black, PrintX, PrintY)
        PrintX = 700
        e.Graphics.DrawString("BOM Qtry", PrintItemsFont, Brushes.Black, PrintX, PrintY)
        PrintY = PrintY + HeadingLineHeight

        'Setting up for multiple pages
        intStartingPageCounter = mintNewPrintCounter

        'Setting the upper limit
        intNumberOfRecords = mintResultsUpperLimit

        'Beginning the loop
        For intCounter = intStartingPageCounter To intNumberOfRecords

            mintQuantityIssued = mintQuantityIssued + structSearchResults(intCounter).mintQuantityIssued
            mintQuantityReceived = mintQuantityReceived + structSearchResults(intCounter).mintQuantityReceived
            mintQuantityUsed = mintQuantityUsed + structSearchResults(intCounter).mintQuantityUsed

            PrintX = 100
            e.Graphics.DrawString(structSearchResults(intCounter).mstrProjectID, PrintItemsFont, Brushes.Black, PrintX, PrintY)

            PrintX = 300
            e.Graphics.DrawString(CStr(structSearchResults(intCounter).mintQuantityReceived), PrintItemsFont, Brushes.Black, PrintX, PrintY)
            PrintX = 500
            e.Graphics.DrawString(CStr(structSearchResults(intCounter).mintQuantityIssued), PrintItemsFont, Brushes.Black, PrintX, PrintY)
            PrintX = 700
            e.Graphics.DrawString(CStr(structSearchResults(intCounter).mintQuantityUsed), PrintItemsFont, Brushes.Black, PrintX, PrintY)
            PrintY = PrintY + ItemLineHeight

            If intCounter = intNumberOfRecords Then
                PrintY = PrintY + ItemLineHeight
                If PrintY < 900 Then
                    PrintX = 100
                    e.Graphics.DrawString("Totals", PrintHeaderFont, Brushes.Black, PrintX, PrintY)
                    PrintX = 300
                    e.Graphics.DrawString(CStr(mintQuantityReceived), PrintHeaderFont, Brushes.Black, PrintX, PrintY)
                    PrintX = 500
                    e.Graphics.DrawString(CStr(mintQuantityIssued), PrintHeaderFont, Brushes.Black, PrintX, PrintY)
                    PrintX = 700
                    e.Graphics.DrawString(CStr(mintQuantityUsed), PrintHeaderFont, Brushes.Black, PrintX, PrintY)
                    PrintY = PrintY + ItemLineHeight
                End If
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

    End Sub
    Private Sub ClearSearchResultsStructure()

        'Setting local variables
        Dim intCounter As Integer

        'Performing Loop
        For intCounter = 0 To mintResultsUpperLimit

            'Clearing structure
            structSearchResults(intCounter).mstrProjectID = ""
            structSearchResults(intCounter).mintQuantityIssued = 0
            structSearchResults(intCounter).mintQuantityReceived = 0
            structSearchResults(intCounter).mintQuantityUsed = 0

        Next

        'Setting the upper limit
        mintResultsUpperLimit = 0

    End Sub
    Private Sub SetControlsVisible(ByVal valueBoolean As Boolean)

        cboPartNumber.Visible = valueBoolean
        cboTransactionID.Visible = valueBoolean
        txtPartDescription.Visible = valueBoolean
        txtTransactionPartNumber.Visible = valueBoolean
        txtTransactionProjectID.Visible = valueBoolean
        txtTransactionQuantity.Visible = valueBoolean
        txtTransactionWarehouseID.Visible = valueBoolean

    End Sub

    Private Sub btnRunReport_Click(sender As Object, e As EventArgs) Handles btnRunReport.Click

        'Setting up the print dialog
        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
        End If

        'Making an entry showing that the report has been run
        Logon.mstrLastTransactionSummary = "RAN PART NUMBER PROJECT REPORT"

        'Setting up for multiple pages
        mintNewPrintCounter = 0

        'Calling the print document
        PrintDocument1.Print()

    End Sub
End Class