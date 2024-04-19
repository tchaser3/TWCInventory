'Title:         Project Transaction Report
'Date:          4-3-15
'Author:        Terry Holmes

'Description:   This form will process a transaction report

Option Strict On

Public Class ProjectTransactionReport

    'Setting up the classes
    Dim TheInputDataValidation As New InputDataValidation
    Dim TheKeywordClass As New KeyWordSearchClass
    Dim TheModuleUnderDevelopment As New ModuleUnderDevelopment
    Dim TheCheckTimeWarnerPartNumber As New CheckTimeWarnerPartNumber

    'Setting the data variables
    Private TheUsedPartsDataSet As BOMPartsDataSet
    Private TheUsedPartsDataTier As TWInventoryDataTier
    Private WithEvents TheUsedPartsBindingSource As BindingSource

    Private TheInternalProjectsDataTier As InternalProjectsDataTier
    Private TheInternalProjectsDataSet As InternalProjectsDataSet
    Private WithEvents TheInternalProjectsBindingSource As BindingSource

    Private TheIssuedPartsDataSet As IssuedPartsDataSet
    Private TheIssuedPartsDataTier As TWInventoryDataTier
    Private WithEvents TheIssuedPartsBindingSource As BindingSource

    Private TheReceivedPartsDataSet As ReceivedPartsDataSet
    Private TheReceivedPartsDataTier As TWInventoryDataTier
    Private WithEvents TheReceivedPartsBindingSource As BindingSource

    Private ThePartNumberDataSet As PartNumberDataSet
    Private ThePartNumberDataTier As PartsDataTier
    Private WithEvents ThePartNumberBindingSource As BindingSource

    'Setting up Used Structure
    Structure UsedParts
        Dim mstrProjectID As String
        Dim mstrPartNumber As String
        Dim mintQuantity As Integer
    End Structure

    Dim structUsedParts() As UsedParts
    Dim mintUsedUpperLimit As Integer
    Dim mintUsedCounter As Integer

    'Setting up the issued structure
    Structure IssuedParts
        Dim mstrProjectID As String
        Dim mstrPartNumber As String
        Dim mintQuantity As Integer
    End Structure

    Dim structIssuedParts() As IssuedParts
    Dim mintIssuedUpperLimit As Integer
    Dim mintIssuedCounter As Integer

    'Setting up the Received Parts
    Structure ReceivedParts
        Dim mstrProjectID As String
        Dim mstrMSRNumber As String
        Dim mstrPartNumber As String
        Dim mintQuantity As Integer
    End Structure

    Dim structReceivedParts() As ReceivedParts
    Dim mintReceivedUpperLimit As Integer
    Dim mintReceivedCounter As Integer

    'Setting up the part number
    Structure PartNumbers
        Dim mstrPartNumber As String
        Dim mstrPartDescription As String
    End Structure

    Dim structPartNumbers() As PartNumbers
    Dim mintPartUpperLimit As Integer
    Dim mintPartCounter As Integer
    Dim mstrProjectID As String
    Dim mstrMSRNumber As String
    Dim mintNewPrintCounter As Integer = 0

    Structure SearchResults
        Dim mstrPartNumber As String
        Dim mstrDescription As String
        Dim mintQTYIssued As Integer
        Dim mintQTYReceived As Integer
        Dim mintQTYReported As Integer
    End Structure

    Dim structSearchResults() As SearchResults
    Dim mintSearchResultsCounter As Integer
    Dim mintSearchResultsUpperLimit As Integer
    Dim mstrErrorMessage As String
    Dim mblnNoItemsFound As Boolean

    Structure InternalProjects
        Dim mintInternalProjectID As Integer
        Dim mstrProjectID As String
        Dim mstrMSRNumber As String
    End Structure

    Dim structInternalProjects() As InternalProjects
    Dim mintProjectCounter As Integer
    Dim mintProjectUpperLimit As Integer

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        'This will close the program
        CloseProgram.ShowDialog()

    End Sub

    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click

        'this will show the main menu
        LastTransaction.Show()
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub btnReportMenu_Click(sender As Object, e As EventArgs) Handles btnReportMenu.Click

        'This will show the report menu
        LastTransaction.Show()
        ReportMenu.Show()
        Me.Close()

    End Sub

    Private Sub ClearTransactionDataBindings()

        'this will clear the transaction data binding
        cboTransactionID.DataBindings.Clear()
        txtTransactionPartNumber.DataBindings.Clear()
        txtTransactionProjectID.DataBindings.Clear()
        txtTransactionQuantity.DataBindings.Clear()
        txtTransactionWarehouseID.DataBindings.Clear()
        txtTransactionMSRNumber.DataBindings.Clear()

    End Sub
    Private Function SetPartNumberDataBindings() As Boolean

        'setting local variables
        Dim blnFatalError As Boolean = False
        Dim intCounter As Integer
        Dim intNumberOfRecords As Integer
        Dim blnIsNotaTWCPart As Boolean
        Dim blnItemNotFound As Boolean = True

        'try catch to find exceptions
        Try

            'setting up the data source
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

            'Setting the rest of the control
            txtPartDescription.DataBindings.Add("text", ThePartNumberBindingSource, "Description")

            'Getting ready for the loop
            intNumberOfRecords = cboPartNumber.Items.Count - 1
            ReDim structPartNumbers(intNumberOfRecords)
            ReDim structSearchResults(intNumberOfRecords)
            mintPartCounter = 0

            'preforming loop
            For intCounter = 0 To intNumberOfRecords

                'setting the boolean variable
                blnIsNotaTWCPart = True

                'incrementing the part number
                cboPartNumber.SelectedIndex = intCounter

                'checking to see if the part number is a time warner part number
                blnIsNotaTWCPart = TheCheckTimeWarnerPartNumber.CheckPartNumber(cboPartNumber.Text)

                If blnIsNotaTWCPart = False Then
                    structPartNumbers(mintPartCounter).mstrPartNumber = cboPartNumber.Text
                    structPartNumbers(mintPartCounter).mstrPartDescription = txtPartDescription.Text
                    mintPartCounter += 1
                    blnItemNotFound = False
                End If
            Next

            If blnItemNotFound = True Then
                blnFatalError = blnItemNotFound
                mstrErrorMessage = "No Items Were Found"
            Else
                blnFatalError = False
                mintPartUpperLimit = mintPartCounter - 1
                mintPartCounter = 0
            End If

            'returning value to calling sub-routine
            Return blnFatalError

        Catch ex As Exception

            'setting up if there is a problem
            mstrErrorMessage = ex.Message
            blnFatalError = True
            Return blnFatalError

        End Try

    End Function
    Private Function SetReceiveDataBindings() As Boolean

        Dim blnFatalError As Boolean = False
        Dim intCounter As Integer
        Dim intNumberOfRecords As Integer
        Dim intWarehouseIDForSearch As Integer
        Dim intWarehouseIDFromTable As Integer
        Dim blnItemNotFound As Boolean = True
        Dim strPartNumberForValidation As String
        Dim blnIsNotATWCPart As Boolean

        'try catch for exceptions
        Try

            'Setting data variables
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

            'setting up the rest of the controls
            txtTransactionPartNumber.DataBindings.Add("Text", TheReceivedPartsBindingSource, "PartNumber")
            txtTransactionProjectID.DataBindings.Add("text", TheReceivedPartsBindingSource, "ProjectID")
            txtTransactionQuantity.DataBindings.Add("text", TheReceivedPartsBindingSource, "QTY")
            txtTransactionWarehouseID.DataBindings.Add("text", TheReceivedPartsBindingSource, "WarehouseID")
            txtTransactionMSRNumber.DataBindings.Add("text", TheReceivedPartsBindingSource, "MSRNumber")

            'Setting up for the loop
            intNumberOfRecords = cboTransactionID.Items.Count - 1
            ReDim structReceivedParts(intNumberOfRecords)
            intWarehouseIDForSearch = Logon.mintPartsWarehouseID
            mintReceivedCounter = 0

            'Performing loop
            For intCounter = 0 To intNumberOfRecords

                'setting the boolean variable
                blnIsNotATWCPart = True

                'incrementing the combo box
                cboTransactionID.SelectedIndex = intCounter

                'Getting the warehouse id
                intWarehouseIDFromTable = CInt(txtTransactionWarehouseID.Text)

                If intWarehouseIDForSearch = intWarehouseIDFromTable Then

                    'getting part number
                    strPartNumberForValidation = txtTransactionPartNumber.Text

                    'verifying the item is a TWC part
                    blnIsNotATWCPart = TheCheckTimeWarnerPartNumber.CheckPartNumber(strPartNumberForValidation)

                    If blnIsNotATWCPart = False Then

                        structReceivedParts(mintReceivedCounter).mintQuantity = CInt(txtTransactionQuantity.Text)
                        structReceivedParts(mintReceivedCounter).mstrPartNumber = txtTransactionPartNumber.Text
                        structReceivedParts(mintReceivedCounter).mstrProjectID = txtTransactionProjectID.Text
                        structReceivedParts(mintReceivedCounter).mstrMSRNumber = txtTransactionMSRNumber.Text
                        mintReceivedCounter += 1
                        mblnNoItemsFound = False

                    End If
                End If

            Next

            mintReceivedUpperLimit = mintReceivedCounter - 1
            mintReceivedCounter = 0

            Return blnFatalError

        Catch ex As Exception

            'Message to user
            mstrErrorMessage = ex.Message
            blnFatalError = True
            Return blnFatalError

        End Try

    End Function
    Private Function SetIssuedDataBindings() As Boolean

        Dim blnFatalError As Boolean = False
        Dim intCounter As Integer
        Dim intNumberOfRecords As Integer
        Dim intWarehouseIDForSearch As Integer
        Dim intWarehouseIDFromTable As Integer
        Dim blnItemNotFound As Boolean = True
        Dim strPartNumberForValidation As String
        Dim blnIsNotATWCPart As Boolean

        'try catch for exceptions
        Try

            'Setting data variables
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

            'setting up the rest of the controls
            txtTransactionPartNumber.DataBindings.Add("Text", TheIssuedPartsBindingSource, "PartNumber")
            txtTransactionProjectID.DataBindings.Add("text", TheIssuedPartsBindingSource, "ProjectID")
            txtTransactionQuantity.DataBindings.Add("text", TheIssuedPartsBindingSource, "QTY")
            txtTransactionWarehouseID.DataBindings.Add("text", TheIssuedPartsBindingSource, "WarehouseID")

            'Setting up for the loop
            intNumberOfRecords = cboTransactionID.Items.Count - 1
            ReDim structIssuedParts(intNumberOfRecords)
            intWarehouseIDForSearch = Logon.mintPartsWarehouseID
            mintIssuedCounter = 0

            'Performing loop
            For intCounter = 0 To intNumberOfRecords

                'setting the boolean variable
                blnIsNotATWCPart = True

                'incrementing the combo box
                cboTransactionID.SelectedIndex = intCounter

                'Getting the warehouse id
                intWarehouseIDFromTable = CInt(txtTransactionWarehouseID.Text)

                If intWarehouseIDForSearch = intWarehouseIDFromTable Then

                    'getting part number
                    strPartNumberForValidation = txtTransactionPartNumber.Text

                    'verifying the item is a TWC part
                    blnIsNotATWCPart = TheCheckTimeWarnerPartNumber.CheckPartNumber(strPartNumberForValidation)

                    If blnIsNotATWCPart = False Then

                        structIssuedParts(mintIssuedCounter).mintQuantity = CInt(txtTransactionQuantity.Text)
                        structIssuedParts(mintIssuedCounter).mstrPartNumber = txtTransactionPartNumber.Text
                        structIssuedParts(mintIssuedCounter).mstrProjectID = txtTransactionProjectID.Text
                        mintIssuedCounter += 1
                        mblnNoItemsFound = False

                    End If
                End If

            Next

            'setting the boundries
            mintIssuedUpperLimit = mintIssuedCounter - 1
            mintIssuedCounter = 0

            Return blnFatalError

        Catch ex As Exception

            'Message to user
            mstrErrorMessage = ex.Message
            blnFatalError = True
            Return blnFatalError

        End Try

    End Function
    Private Function SetUsedDataBindings() As Boolean

        Dim blnFatalError As Boolean = False
        Dim intCounter As Integer
        Dim intNumberOfRecords As Integer
        Dim intWarehouseIDForSearch As Integer
        Dim intWarehouseIDFromTable As Integer
        Dim blnItemNotFound As Boolean = True
        Dim strPartNumberForValidation As String
        Dim blnIsNotATWCPart As Boolean

        'try catch for exceptions
        Try

            'Setting data variables
            TheUsedPartsDataTier = New TWInventoryDataTier
            TheUsedPartsDataSet = TheUsedPartsDataTier.GetBOMPartsInformation
            TheUsedPartsBindingSource = New BindingSource

            'Setting up the binding source
            With TheUsedPartsBindingSource
                .DataSource = TheUsedPartsDataSet
                .DataMember = "BOMParts"
                .MoveFirst()
                .MoveLast()
            End With

            'Setting up the combo box
            With cboTransactionID
                .DataSource = TheUsedPartsBindingSource
                .DisplayMember = "TransactionID"
                .DataBindings.Add("Text", TheUsedPartsBindingSource, "TransactionID", False, DataSourceUpdateMode.Never)
            End With

            'setting up the rest of the controls
            txtTransactionPartNumber.DataBindings.Add("Text", TheUsedPartsBindingSource, "PartNumber")
            txtTransactionProjectID.DataBindings.Add("text", TheUsedPartsBindingSource, "ProjectID")
            txtTransactionQuantity.DataBindings.Add("text", TheUsedPartsBindingSource, "QTY")
            txtTransactionWarehouseID.DataBindings.Add("text", TheUsedPartsBindingSource, "WarehouseID")

            'Setting up for the loop
            intNumberOfRecords = cboTransactionID.Items.Count - 1
            ReDim structUsedParts(intNumberOfRecords)
            intWarehouseIDForSearch = Logon.mintPartsWarehouseID
            mintUsedCounter = 0

            'Performing loop
            For intCounter = 0 To intNumberOfRecords

                'setting the boolean variable
                blnIsNotATWCPart = True

                'incrementing the combo box
                cboTransactionID.SelectedIndex = intCounter

                'Getting the warehouse id
                intWarehouseIDFromTable = CInt(txtTransactionWarehouseID.Text)

                If intWarehouseIDForSearch = intWarehouseIDFromTable Then

                    'getting part number
                    strPartNumberForValidation = txtTransactionPartNumber.Text

                    'verifying the item is a TWC part
                    blnIsNotATWCPart = TheCheckTimeWarnerPartNumber.CheckPartNumber(strPartNumberForValidation)

                    If blnIsNotATWCPart = False Then

                        structUsedParts(mintUsedCounter).mintQuantity = CInt(txtTransactionQuantity.Text)
                        structUsedParts(mintUsedCounter).mstrPartNumber = txtTransactionPartNumber.Text
                        structUsedParts(mintUsedCounter).mstrProjectID = txtTransactionProjectID.Text
                        mintUsedCounter += 1
                        mblnNoItemsFound = False

                    End If
                End If

            Next

            'setting the boundries
            mintUsedUpperLimit = mintUsedCounter - 1
            mintUsedCounter = 0

            Return blnFatalError

        Catch ex As Exception

            'Message to user
            mstrErrorMessage = ex.Message
            blnFatalError = True
            Return blnFatalError

        End Try

    End Function
    Private Function SetProjectDataBindings() As Boolean

        'setting local variables
        Dim blnFatalError As Boolean = False
        Dim intCounter As Integer
        Dim intNumberOfRecords As Integer

        'try catch for exceptions
        Try

            'setting up the data variables
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
            With cboInternalID
                .DataSource = TheInternalProjectsBindingSource
                .DisplayMember = "internalProjectID"
                .DataBindings.Add("text", TheInternalProjectsBindingSource, "internalProjectID", False, DataSourceUpdateMode.Never)
            End With

            'setting the rest of the controls
            txtProjectID.DataBindings.Add("text", TheInternalProjectsBindingSource, "TWCControlNumber")
            txtTransactionMSRNumber.DataBindings.Add("text", TheInternalProjectsBindingSource, "MSRNumber")


            'getting ready for the loop
            intNumberOfRecords = cboInternalID.Items.Count - 1
            ReDim structInternalProjects(intNumberOfRecords)
            mintProjectUpperLimit = intNumberOfRecords

            'Filling structure
            For intCounter = 0 To intNumberOfRecords

                'incrementing the combo box
                cboInternalID.SelectedIndex = intCounter

                structInternalProjects(intCounter).mintInternalProjectID = CInt(cboInternalID.Text)
                structInternalProjects(intCounter).mstrProjectID = txtProjectID.Text
                structInternalProjects(intCounter).mstrMSRNumber = txtTransactionMSRNumber.Text

            Next

            'returning to calling sub routine
            Return blnFatalError

        Catch ex As Exception

            'message to user
            mstrErrorMessage = ex.Message
            blnFatalError = True
            Return blnFatalError

        End Try

    End Function

    Private Sub ProjectTransactionReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'This will load up the structures
        'setting local variables
        Dim blnFatalError As Boolean = False

        Logon.mstrLastTransactionSummary = "Loaded the Project Transaction Project"

        PleaseWait.Show()
        mblnNoItemsFound = True
        ClearTransactionDataBindings()
        blnFatalError = SetPartNumberDataBindings()
        If blnFatalError = False Then
            ClearTransactionDataBindings()
            blnFatalError = SetReceiveDataBindings()
            If blnFatalError = False Then
                ClearTransactionDataBindings()
                blnFatalError = SetIssuedDataBindings()
                If blnFatalError = False Then
                    ClearTransactionDataBindings()
                    blnFatalError = SetUsedDataBindings()
                    If blnFatalError = False Then
                        ClearTransactionDataBindings()
                        blnFatalError = SetProjectDataBindings()
                    End If
                End If
            End If
        End If

        If mblnNoItemsFound = True And blnFatalError = False Then
            mstrErrorMessage = "No Items Were Found for this Warehouse"
            blnFatalError = mblnNoItemsFound
        End If

        If blnFatalError = True Then
            MessageBox.Show(mstrErrorMessage, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            btnRunReport.Enabled = False
            btnSearchProjectID.Enabled = False
            MakeControlsInvisible()
            PleaseWait.Close()
        ElseIf blnFatalError = False Then
            dgvSearchResults.ColumnCount = 5
            dgvSearchResults.Columns(0).Name = "Part Number"
            dgvSearchResults.Columns(1).Name = "Description"
            dgvSearchResults.Columns(2).Name = "Received"
            dgvSearchResults.Columns(3).Name = "Issued"
            dgvSearchResults.Columns(4).Name = "Reported"
            btnRunReport.Enabled = False
            PleaseWait.Close()
        End If

    End Sub
    Private Sub MakeControlsInvisible()

        'This will make the controls invisible
        dgvSearchResults.Visible = False
        cboInternalID.Visible = False
        cboPartNumber.Visible = False
        cboTransactionID.Visible = False
        txtEnterProjectID.Visible = False
        txtPartDescription.Visible = False
        txtProjectID.Visible = False
        txtTransactionPartNumber.Visible = False
        txtTransactionProjectID.Visible = False
        txtTransactionQuantity.Visible = False
        txtTransactionWarehouseID.Visible = False

    End Sub

    Private Sub btnSearchProjectID_Click(sender As Object, e As EventArgs) Handles btnSearchProjectID.Click

        'This sub-routine will search for transactions matching the project id
        Dim blnFatalError As Boolean = False
        Dim strProjectIDForSearch As String
        Dim strProjectIDFromTable As String
        Dim strMSRNumberForSearch As String = ""
        Dim strMSRNumberFromTable As String
        Dim blnKeyWordNotFound As Boolean
        Dim intTransactionCounter As Integer
        Dim intPartCounter As Integer
        Dim intProjectCounter As Integer
        Dim intResultCounter As Integer
        Dim strPartNumberForSearch As String = ""
        Dim strPartNumberFromTable As String
        Dim blnItemNotFound As Boolean = True
        Dim blnProjectIDNotInTable As Boolean = True
        Dim blnItemNotInStructure As Boolean
        Dim row() As String

        'setting up for data validation
        strProjectIDForSearch = txtEnterProjectID.Text
        blnFatalError = TheInputDataValidation.VerifyTextData(strProjectIDForSearch)

        If blnFatalError = True Then
            MessageBox.Show("Project ID Was Not Entered", "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        PleaseWait.Show()

        dgvSearchResults.Rows.Clear()

        'Loop to determine if the Project ID is within the table
        For intProjectCounter = 0 To mintProjectUpperLimit

            'getting the project id
            strProjectIDFromTable = structInternalProjects(intProjectCounter).mstrProjectID

            'comparing project id
            If strProjectIDForSearch = strProjectIDFromTable Then
                blnProjectIDNotInTable = False
                strMSRNumberForSearch = structInternalProjects(intProjectCounter).mstrMSRNumber
            End If

        Next

        If blnProjectIDNotInTable = True Then
            PleaseWait.Close()
            MessageBox.Show("Project ID Entered is not a Valid Project ID", "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtEnterProjectID.Text = ""
            Exit Sub
        End If

        mstrProjectID = strProjectIDForSearch
        mstrMSRNumber = strMSRNumberForSearch

        'Getting ready for the data loop
        mintSearchResultsCounter = 0
        mintSearchResultsUpperLimit = 0

        For intTransactionCounter = 0 To mintReceivedUpperLimit

            'Getting project id
            strProjectIDFromTable = structReceivedParts(intTransactionCounter).mstrProjectID
            strMSRNumberFromTable = structReceivedParts(intTransactionCounter).mstrMSRNumber

            If strMSRNumberFromTable <> "" Then
                blnKeyWordNotFound = TheKeywordClass.FindKeyWord(strMSRNumberForSearch, strMSRNumberFromTable)
            Else
                blnKeyWordNotFound = True
            End If

            'Checking Project ID
            If strProjectIDForSearch = strProjectIDFromTable Or blnKeyWordNotFound = False Then

                blnItemNotInStructure = True

                'setting boolean modifier
                blnItemNotFound = False

                strPartNumberForSearch = structReceivedParts(intTransactionCounter).mstrPartNumber

                'beginning loop to see if part is within the search results structure

                'getting part number
                For intResultCounter = 0 To mintSearchResultsUpperLimit

                    strPartNumberFromTable = structSearchResults(intResultCounter).mstrPartNumber

                    'comparing the part number
                    If strPartNumberFromTable = strPartNumberForSearch Then

                        structSearchResults(intResultCounter).mintQTYReceived = structSearchResults(intResultCounter).mintQTYReceived + structReceivedParts(intTransactionCounter).mintQuantity
                        blnItemNotInStructure = False

                    End If
                Next

                If blnItemNotInStructure = True Then

                    'loading the part number in the structure
                    structSearchResults(mintSearchResultsCounter).mstrPartNumber = strPartNumberForSearch

                    'getting the part description
                    For intPartCounter = 0 To mintPartUpperLimit

                        strPartNumberFromTable = structPartNumbers(intPartCounter).mstrPartNumber

                        If strPartNumberForSearch = strPartNumberFromTable Then

                            structSearchResults(mintSearchResultsCounter).mstrDescription = structPartNumbers(intPartCounter).mstrPartDescription

                        End If

                    Next

                    structSearchResults(mintSearchResultsCounter).mintQTYReceived = structReceivedParts(intTransactionCounter).mintQuantity
                    structSearchResults(mintSearchResultsCounter).mintQTYIssued = 0
                    structSearchResults(mintSearchResultsCounter).mintQTYReported = 0
                    mintSearchResultsCounter += 1
                    mintSearchResultsUpperLimit += 1

                End If

            End If

        Next

        For intTransactionCounter = 0 To mintIssuedUpperLimit

            'Getting project id
            strProjectIDFromTable = structIssuedParts(intTransactionCounter).mstrProjectID

            'Checking Project ID
            If strProjectIDForSearch = strProjectIDFromTable Then

                blnItemNotInStructure = True

                'setting boolean modifier
                blnItemNotFound = False

                strPartNumberForSearch = structIssuedParts(intTransactionCounter).mstrPartNumber

                'beginning loop to see if part is within the search results structure

                'getting part number
                For intResultCounter = 0 To mintSearchResultsUpperLimit

                    strPartNumberFromTable = structSearchResults(intResultCounter).mstrPartNumber

                    'comparing the part number
                    If strPartNumberFromTable = strPartNumberForSearch Then

                        structSearchResults(intResultCounter).mintQTYIssued = structSearchResults(intResultCounter).mintQTYIssued + structIssuedParts(intTransactionCounter).mintQuantity
                        blnItemNotInStructure = False

                    End If
                Next

                If blnItemNotInStructure = True Then

                    'loading the part number in the structure
                    structSearchResults(mintSearchResultsCounter).mstrPartNumber = strPartNumberForSearch

                    'getting the part description
                    For intPartCounter = 0 To mintPartUpperLimit

                        strPartNumberFromTable = structPartNumbers(intPartCounter).mstrPartNumber

                        If strPartNumberForSearch = strPartNumberFromTable Then

                            structSearchResults(mintSearchResultsCounter).mstrDescription = structPartNumbers(intPartCounter).mstrPartDescription

                        End If

                    Next

                    structSearchResults(mintSearchResultsCounter).mintQTYReceived = 0
                    structSearchResults(mintSearchResultsCounter).mintQTYIssued = structIssuedParts(intTransactionCounter).mintQuantity
                    structSearchResults(mintSearchResultsCounter).mintQTYReported = 0
                    mintSearchResultsCounter += 1
                    mintSearchResultsUpperLimit += 1

                End If

            End If

        Next

        For intTransactionCounter = 0 To mintUsedUpperLimit

            'Getting project id
            strProjectIDFromTable = structUsedParts(intTransactionCounter).mstrProjectID

            'Checking Project ID
            If strProjectIDForSearch = strProjectIDFromTable Then

                blnItemNotInStructure = True

                'setting boolean modifier
                blnItemNotFound = False

                strPartNumberForSearch = structUsedParts(intTransactionCounter).mstrPartNumber

                'beginning loop to see if part is within the search results structure

                'getting part number
                For intResultCounter = 0 To mintSearchResultsUpperLimit

                    strPartNumberFromTable = structSearchResults(intResultCounter).mstrPartNumber

                    'comparing the part number
                    If strPartNumberFromTable = strPartNumberForSearch Then

                        structSearchResults(intResultCounter).mintQTYReported = structSearchResults(intResultCounter).mintQTYReported + structUsedParts(intTransactionCounter).mintQuantity
                        blnItemNotInStructure = False

                    End If
                Next

                If blnItemNotInStructure = True Then

                    'loading the part number in the structure
                    structSearchResults(mintSearchResultsCounter).mstrPartNumber = strPartNumberForSearch

                    'getting the part description
                    For intPartCounter = 0 To mintPartUpperLimit

                        strPartNumberFromTable = structPartNumbers(intPartCounter).mstrPartNumber

                        If strPartNumberForSearch = strPartNumberFromTable Then

                            structSearchResults(mintSearchResultsCounter).mstrDescription = structPartNumbers(intPartCounter).mstrPartDescription

                        End If

                    Next

                    structSearchResults(mintSearchResultsCounter).mintQTYReceived = 0
                    structSearchResults(mintSearchResultsCounter).mintQTYIssued = 0
                    structSearchResults(mintSearchResultsCounter).mintQTYReported = structUsedParts(intTransactionCounter).mintQuantity
                    mintSearchResultsCounter += 1
                    mintSearchResultsUpperLimit += 1

                End If

            End If

        Next

        If blnItemNotFound = True Then
            PleaseWait.Close()
            MessageBox.Show("Not Items for this Project Were Found", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtEnterProjectID.Text = ""
            Exit Sub
        End If
            

        'Loading up the data grid
        For intResultCounter = 0 To mintSearchResultsUpperLimit - 1

            row = New String() {structSearchResults(intResultCounter).mstrPartNumber, structSearchResults(intResultCounter).mstrDescription, CStr(structSearchResults(intResultCounter).mintQTYReceived), CStr(structSearchResults(intResultCounter).mintQTYIssued), CStr(structSearchResults(intResultCounter).mintQTYReported)}
            dgvSearchResults.Rows.Add(row)

        Next

        PleaseWait.Close()
        btnRunReport.Enabled = True

    End Sub
    
    Private Sub PrintDocument1_QueryPageSettings(sender As Object, e As Printing.QueryPageSettingsEventArgs) Handles PrintDocument1.QueryPageSettings
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


        'Setting up for default position
        PrintY = 100

        'Setting up for the print header
        PrintX = 300
        e.Graphics.DrawString("Blue Jay Communications Inventory Report", PrintHeaderFont, Brushes.Black, PrintX, PrintY)
        PrintY = PrintY + HeadingLineHeight
        PrintX = 303
        e.Graphics.DrawString("Complete Transaction Report for Project ID " + mstrProjectID, PrintSubHeaderFont, Brushes.Black, PrintX, PrintY)
        PrintY = PrintY + HeadingLineHeight

        'Setting up the columns
        PrintX = 50
        e.Graphics.DrawString("Part Number", PrintItemsFont, Brushes.Black, PrintX, PrintY)
        PrintX = 150
        e.Graphics.DrawString("Description", PrintItemsFont, Brushes.Black, PrintX, PrintY)
        PrintX = 500
        e.Graphics.DrawString("QTY Received", PrintItemsFont, Brushes.Black, PrintX, PrintY)
        PrintX = 700
        e.Graphics.DrawString("QTY Issued", PrintItemsFont, Brushes.Black, PrintX, PrintY)
        PrintX = 900
        e.Graphics.DrawString("QTY Reported", PrintItemsFont, Brushes.Black, PrintX, PrintY)
        PrintY = PrintY + HeadingLineHeight

        'Setting up for multiple pages
        intStartingPageCounter = mintNewPrintCounter
        intNumberOfRecords = mintSearchResultsUpperLimit - 1

        For intCounter = intStartingPageCounter To mintSearchResultsUpperLimit - 1


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
                strPartDescription = structSearchResults(intCounter).mstrDescription
            End If

            PrintX = 150
            e.Graphics.DrawString(strPartDescription, PrintItemsFont, Brushes.Black, PrintX, PrintY)
            PrintX = 500
            e.Graphics.DrawString(CStr(structSearchResults(intCounter).mintQTYReceived), PrintItemsFont, Brushes.Black, PrintX, PrintY)
            PrintX = 700
            e.Graphics.DrawString(CStr(structSearchResults(intCounter).mintQTYIssued), PrintItemsFont, Brushes.Black, PrintX, PrintY)
            PrintX = 900
            e.Graphics.DrawString(CStr(structSearchResults(intCounter).mintQTYReported), PrintItemsFont, Brushes.Black, PrintX, PrintY)
            PrintY = PrintY + ItemLineHeight

            If PrintY > 750 Then
                If intStartingPageCounter = mintSearchResultsUpperLimit Then
                    e.HasMorePages = False
                Else
                    e.HasMorePages = True
                    blnNewPage = True
                End If
            End If

            If blnNewPage = True Then
                mintNewPrintCounter = intCounter + 1
                intCounter = mintSearchResultsUpperLimit
            End If


        Next
    End Sub

    Private Sub btnProjectMenu_Click(sender As Object, e As EventArgs) Handles btnProjectMenu.Click

        LastTransaction.Show()
        ViewProjects.Show()
        Me.Close()

    End Sub
End Class