'Title:         Update Inventory Table
'Date:          11-27-14
'Author:        Terry Holmes

'Description:   This form is used to update the table

Option Strict On

Public Class EnterInventoryInformation

    'Setting up the data variables
    Private TheBOMPartsDataSet As BOMPartsDataSet
    Private TheBOMPartsDataTier As TWInventoryDataTier
    Private WithEvents TheBOMPartsBindingSource As BindingSource

    Private TheIssuedPartsDataSet As IssuedPartsDataSet
    Private TheIssuedPartsDataTier As TWInventoryDataTier
    Private WithEvents TheIssuedPartsBindingSource As BindingSource

    Private TheReceivedPartsDataSet As ReceivedPartsDataSet
    Private TheReceivedPartsDataTier As TWInventoryDataTier
    Private WithEvents TheReceivedPartsBindingSource As BindingSource

    Private TheInternalProjectsDataSet As InternalProjectsDataSet
    Private TheInternalProjectsDataTier As InternalProjectsDataTier
    Private WithEvents TheInternalProjectsBindingSource As BindingSource

    Private ThePartNumberDataSet As PartNumberDataSet
    Private ThePartNumberDataTier As PartsDataTier
    Private WithEvents ThePartNumberBindingSource As BindingSource

    'Setting up modular variables
    Private addingBoolean As Boolean = False
    Private editingBoolean As Boolean = False
    Private PreviousSelectedIndex As Integer
    Dim mstrEntryForm As String

    Dim TheInputDataValidation As New InputDataValidation
    Dim TheCheckTimeWarnerPartNumber As New CheckTimeWarnerPartNumber

    Dim mdatLogDate As Date = Date.Now
    Dim mstrLogDate As String
    Dim mstrLastTransactionIdentifier As String

    'Setting up global variables for saving
    Dim mstrTransactionID As String
    Dim mstrTransactionDate As String
    Dim mstrTransactionProjectID As String
    Dim mstrTransactionMSRNumber As String
    Dim mstrTransactionPartNumber As String
    Dim mstrTransactionQuantity As String

    'Setting up the new Project ID array
    Dim structNewProjectInfo() As ProjectInfo
    Dim structProjectInfo() As ProjectInfo
    Dim mintNewProjectCounter As Integer
    Dim mintNewProjectUpperLimit As Integer
    Dim mblnNewProjectsCreated As Boolean = False
    Dim mintNewPrintCounter As Integer

    'Setting up other arrays
    Dim mintProjectUpperLimit As Integer
    Dim mstrPartNumber() As String
    Dim mintPartNumberUpperLimit As Integer
    Dim mstrNewPartNumber() As String
    Dim mintNewPartNumberUpperLimit As Integer

    Dim mblnNewRecordsToProcess As Boolean

    Structure ProblemTransactions
        Dim mstrTransactionID As String
        Dim mstrDate As String
        Dim mstrProjectID As String
        Dim mstrMSRNumber As String
        Dim mstrPartNumber As String
        Dim mstrQuantity As String
        Dim mstrWarehouseID As String
    End Structure

    Structure ProjectInfo
        Dim mstrProjectID As String
        Dim mstrMSRNumber As String
    End Structure

    'setting structure variables
    Dim structProblemTransactions() As ProblemTransactions
    Dim mintProblemCounter As Integer
    Dim mintProblemUpperLimit As Integer
    Dim mblnThereIsAProblem As Boolean

    Dim mintTransactionCounter As Integer
    Dim mstrErrorMessage As String

    Private Sub ClearDataBindings()

        'This will clear the data bindings
        cboTransactionID.DataBindings.Clear()
        txtPartNumber.DataBindings.Clear()
        txtProjectID.DataBindings.Clear()
        txtQuantity.DataBindings.Clear()
        txtDataEntryComplete.DataBindings.Clear()
        txtMSRNumber.DataBindings.Clear()
        txtDate.DataBindings.Clear()
        txtWarehouseID.DataBindings.Clear()

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        'This calls the Close Program Dialog Box
        btnProcess.PerformClick()

        CloseProgram.ShowDialog()

    End Sub

    Private Sub btnMainMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMainMenu.Click

        btnProcess.PerformClick()

        ClearDataBindings()
        LastTransaction.Show()
        Form1.Show()
        Me.Close()

    End Sub
    Private Sub SetBOMDataBindings()

        'Try Catch for Exceptions
        Try

            'Setting up the Data Controls
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

            'Binding the Combo box
            With cboTransactionID
                .DataSource = TheBOMPartsBindingSource
                .DisplayMember = "TransactionID"
                .DataBindings.Add("text", TheBOMPartsBindingSource, "TransactionID", False, DataSourceUpdateMode.Never)
            End With

            'Binding the rest of the controls
            txtProjectID.DataBindings.Add("text", TheBOMPartsBindingSource, "ProjectID")
            txtPartNumber.DataBindings.Add("text", TheBOMPartsBindingSource, "PartNumber")
            txtQuantity.DataBindings.Add("text", TheBOMPartsBindingSource, "QTY")
            txtDate.DataBindings.Add("text", TheBOMPartsBindingSource, "Date")
            txtWarehouseID.DataBindings.Add("text", TheBOMPartsBindingSource, "WarehouseID")

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub SetIssueDataBindings()

        'Try Catch for exceptions
        Try

            'Setting up the Data Controls
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

            'Binding the Combo box
            With cboTransactionID
                .DataSource = TheIssuedPartsBindingSource
                .DisplayMember = "TransactionID"
                .DataBindings.Add("text", TheIssuedPartsBindingSource, "TransactionID", False, DataSourceUpdateMode.Never)
            End With

            'Binding the rest of the controls
            txtProjectID.DataBindings.Add("text", TheIssuedPartsBindingSource, "ProjectID")
            txtPartNumber.DataBindings.Add("text", TheIssuedPartsBindingSource, "PartNumber")
            txtQuantity.DataBindings.Add("text", TheIssuedPartsBindingSource, "QTY")
            txtDate.DataBindings.Add("text", TheIssuedPartsBindingSource, "Date")
            txtWarehouseID.DataBindings.Add("text", TheIssuedPartsBindingSource, "WarehouseID")

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub SetReceiveDataBindings()

        Try
            'Setting up the Data Controls
            TheReceivedPartsDataTier = New TWInventoryDataTier
            TheReceivedPartsDataSet = TheReceivedPartsDataTier.GetReceivedPartsInformation
            TheReceivedPartsBindingSource = New BindingSource

            btnMenusButton.Text = "Receive Menu"

            'Setting up the binding source
            With TheReceivedPartsBindingSource
                .DataSource = TheReceivedPartsDataSet
                .DataMember = "ReceivedParts"
                .MoveFirst()
                .MoveLast()
            End With

            'Binding the Combo box
            With cboTransactionID
                .DataSource = TheReceivedPartsBindingSource
                .DisplayMember = "TransactionID"
                .DataBindings.Add("text", TheReceivedPartsBindingSource, "TransactionID", False, DataSourceUpdateMode.Never)
            End With

            'Binding the rest of the controls
            txtProjectID.DataBindings.Add("text", TheReceivedPartsBindingSource, "ProjectID")
            txtPartNumber.DataBindings.Add("text", TheReceivedPartsBindingSource, "PartNumber")
            txtQuantity.DataBindings.Add("text", TheReceivedPartsBindingSource, "QTY")
            txtDate.DataBindings.Add("text", TheReceivedPartsBindingSource, "Date")
            txtMSRNumber.DataBindings.Add("text", TheReceivedPartsBindingSource, "MSRNumber")
            txtWarehouseID.DataBindings.Add("Text", TheReceivedPartsBindingSource, "WarehouseID")

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub EnterInventoryInformation_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'This will load the form
        mstrEntryForm = Logon.mstrEntryType

        PleaseWait.Show()

        SetInternalProjectDataBindings()
        ClearDataBindings()
        SetPartNumberDataBindings()
        ClearDataBindings()


        'Try Catch for binding the controls
        Try

            'If Statements for binding the controls
            If mstrEntryForm = "BOM" Then

                lblFormTitle.Text = "Updating BOM Information"
                btnMenusButton.Text = "Use Menu"

            ElseIf mstrEntryForm = "ISSUE" Then

                lblFormTitle.Text = "Updating Issued Material"
                btnMenusButton.Text = "Issue Menu"

            ElseIf mstrEntryForm = "RECEIVE" Then

                lblFormTitle.Text = "Updating Received Material"
                txtMSRNumber.Visible = True

            End If

            'Creating the gridview
            dgvBatchTransactions.ColumnCount = 6
            dgvBatchTransactions.Columns(0).Name = "Transaction ID"
            dgvBatchTransactions.Columns(1).Name = "Date"
            dgvBatchTransactions.Columns(2).Name = "Project ID"
            dgvBatchTransactions.Columns(3).Name = "MSR Number"
            dgvBatchTransactions.Columns(4).Name = "Part Number"
            dgvBatchTransactions.Columns(5).Name = "Qty"

            Logon.mstrLastTransactionSummary = "LOADED ENTER INVENTORY INFORMATION"

            txtDate.Text = ""
            txtMSRNumber.Text = ""
            txtPartNumber.Text = ""
            txtProjectID.Text = ""
            txtQuantity.Text = ""
            txtWarehouseID.Text = CStr(Logon.mintPartsWarehouseID)

            btnAdd.PerformClick()

            cboTransactionID.Visible = False

            mintTransactionCounter = 0
            
            PleaseWait.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub SetPartNumberDataBindings()

        Dim intNumberOfRecords As Integer
        Dim intCounter As Integer

        Try

            'this will set up the data variables
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
            With cboTransactionID
                .DataSource = ThePartNumberBindingSource
                .DisplayMember = "PartID"
                .DataBindings.Add("text", ThePartNumberBindingSource, "PartID", False, DataSourceUpdateMode.Never)
            End With

            'Setting up the other control
            txtPartNumber.DataBindings.Add("Text", ThePartNumberBindingSource, "PartNumber")

            'getting ready for the array
            intNumberOfRecords = cboTransactionID.Items.Count - 1
            mintPartNumberUpperLimit = intNumberOfRecords
            mintNewPartNumberUpperLimit = 0
            ReDim mstrPartNumber(intNumberOfRecords)
            ReDim mstrNewPartNumber(intNumberOfRecords)

            'Loading the array
            For intCounter = 0 To intNumberOfRecords

                'incrementing the combo box
                cboTransactionID.SelectedIndex = intCounter

                mstrPartNumber(intCounter) = txtPartNumber.Text

            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub SetInternalProjectDataBindings()

        'Setting local variables
        Dim intNumberOfRecords As Integer
        Dim intCounter As Integer

        Try

            'this will set up the data variables
            TheInternalProjectsDataTier = New InternalProjectsDataTier
            TheInternalProjectsDataSet = TheInternalProjectsDataTier.GetInternalProjectsInformation
            TheInternalProjectsBindingSource = New BindingSource

            'Setting up the binding source
            With TheInternalProjectsBindingSource
                .DataSource = TheInternalProjectsDataSet
                .DataMember = "internalprojects"
                .MoveFirst()
                .MoveLast()
            End With

            'Setting up the combo box
            With cboTransactionID
                .DataSource = TheInternalProjectsBindingSource
                .DisplayMember = "internalProjectID"
                .DataBindings.Add("text", TheInternalProjectsBindingSource, "internalProjectID", False, DataSourceUpdateMode.Never)
            End With

            'Setting up the other control
            txtProjectID.DataBindings.Add("Text", TheInternalProjectsBindingSource, "TWCControlNumber")
            txtMSRNumber.DataBindings.Add("Text", TheInternalProjectsBindingSource, "MSRNumber")

            'getting ready for the array
            intNumberOfRecords = cboTransactionID.Items.Count - 1
            mintProjectUpperLimit = intNumberOfRecords
            mintNewProjectUpperLimit = 0
            ReDim structNewProjectInfo(intNumberOfRecords)
            ReDim structProjectInfo(intNumberOfRecords)

            'Loading the array
            For intCounter = 0 To intNumberOfRecords

                'incrementing the combo box
                cboTransactionID.SelectedIndex = intCounter

                structProjectInfo(intCounter).mstrProjectID = txtProjectID.Text
                structProjectInfo(intCounter).mstrMSRNumber = txtMSRNumber.Text

            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub SetComboBoxBinding()

        'This will set the combo box bindings
        With cboTransactionID
            If (addingBoolean Or editingBoolean) Then
                .DataBindings!text.DataSourceUpdateMode = DataSourceUpdateMode.OnValidation
                .DropDownStyle = ComboBoxStyle.Simple
            Else
                .DataBindings!text.DataSourceUpdateMode = DataSourceUpdateMode.Never
                .DropDownStyle = ComboBoxStyle.DropDownList
            End If
        End With

    End Sub
    Private Sub SetControlsReadOnly(ByVal valueBoolean As Boolean)

        'This will set the controls to readonly
        txtDataEntryComplete.ReadOnly = valueBoolean
        txtPartNumber.ReadOnly = valueBoolean
        txtProjectID.ReadOnly = valueBoolean
        txtQuantity.ReadOnly = valueBoolean
        txtWarehouseID.ReadOnly = valueBoolean

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        'Setting local variables
        Dim strValueForValidation As String
        Dim blnFatalError As Boolean = False
        Dim blnThereIsAProblem As Boolean = False
        Dim strErrorMessage As String = ""
        Dim row() As String
        Dim blnProjectIDNotFound As Boolean
        Dim blnPartNumberNotFound As Boolean
        Dim strProjectIDForSearch As String
        Dim strProjectIDFromTable As String
        Dim strPartNumberFromTable As String
        Dim strPartNumberForSearch As String
        Dim strMSRNumberForSearch As String
        Dim strMSRNumberFromTable As String
        Dim blnProjectIDFound As Boolean
        Dim blnMSRNumberNotFound As Boolean
        Dim blnProjectIsWHS As Boolean
        Dim intCounter As Integer
        Dim blnIsNotaTWCPartNumber As Boolean

        'setting variables to update structure
        Dim intStructureCounter As Integer


        If btnAdd.Text = "Add" Then

            CreateID.Show()
            txtTransactionID.Text = CStr(Logon.mintCreatedTransactionID)
            mstrLogDate = CStr(mdatLogDate)
            txtDate.Text = mstrLogDate
            btnAdd.Text = "Save"
            txtDataEntryComplete.Text = "NO"

        Else

            Logon.mblnNewPartNumber = False

            'Beginning data validation
            strValueForValidation = txtTransactionID.Text
            blnFatalError = TheInputDataValidation.VerifyIntegerData(strValueForValidation)
            If blnFatalError = True Then
                blnThereIsAProblem = True
                strErrorMessage = strErrorMessage + "The Tranasction ID is not an Integer" + vbNewLine
            Else
                blnFatalError = TheInputDataValidation.VerifyIntegerRange(strValueForValidation)
                If blnFatalError = True Then
                    blnThereIsAProblem = True
                    strErrorMessage = strErrorMessage + "The Transaction ID is out of Range" + vbNewLine
                End If
            End If

            strValueForValidation = txtDate.Text
            blnFatalError = TheInputDataValidation.VerifyStartingEndingDatesAsDates(strValueForValidation)
            If blnFatalError = True Then
                blnThereIsAProblem = True
                strErrorMessage = strErrorMessage + "The Date Information is not a Date" + vbNewLine
            End If

            strValueForValidation = txtDataEntryComplete.Text
            blnFatalError = TheInputDataValidation.VerifyYesNoData(strValueForValidation)
            If blnFatalError = True Then
                blnThereIsAProblem = True
                strErrorMessage = strErrorMessage + "The Data Entry Complete is not a Yes or No" + vbNewLine
            End If

            strValueForValidation = txtPartNumber.Text
            blnFatalError = TheInputDataValidation.VerifyTextData(strValueForValidation)
            If blnFatalError = True Then
                blnThereIsAProblem = True
                strErrorMessage = strErrorMessage + "The Part Number was not entered" + vbNewLine
            ElseIf blnFatalError = False Then
                blnIsNotaTWCPartNumber = TheCheckTimeWarnerPartNumber.CheckPartNumber(strValueForValidation)
                If blnIsNotaTWCPartNumber = True Then
                    blnThereIsAProblem = True
                    strErrorMessage = strErrorMessage + "The Part Number Entered is not a Time Warner Part Number" + vbNewLine
                End If
            End If

            strValueForValidation = txtProjectID.Text
            blnFatalError = TheInputDataValidation.VerifyTextData(strValueForValidation)
            If blnFatalError = True Then
                blnThereIsAProblem = True
                strErrorMessage = strErrorMessage + "The Project ID was not Entered" + vbNewLine
            End If

            strValueForValidation = txtQuantity.Text
            blnFatalError = TheInputDataValidation.VerifyIntegerData(strValueForValidation)
            If blnFatalError = True Then
                blnThereIsAProblem = True
                strErrorMessage = strErrorMessage + "The Quantity is not an Integer" + vbNewLine
            Else
                blnFatalError = TheInputDataValidation.VerifyIntegerRange(strValueForValidation)
                If blnFatalError = True Then
                    blnThereIsAProblem = True
                    strErrorMessage = strErrorMessage + "The Quantity is out of Range" + vbNewLine
                End If
            End If

            If mstrEntryForm = "RECEIVE" Then
                strValueForValidation = txtMSRNumber.Text
                blnFatalError = TheInputDataValidation.VerifyTextData(strValueForValidation)
                If blnFatalError = True Then
                    blnThereIsAProblem = True
                    strErrorMessage = strErrorMessage + "The MSR Number was not Entered" + vbNewLine
                End If
            End If


            If blnThereIsAProblem = True Then
                MessageBox.Show(strErrorMessage, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            'Setting up the search
            blnProjectIDNotFound = True
            blnMSRNumberNotFound = True
            blnPartNumberNotFound = True
            strProjectIDForSearch = txtProjectID.Text
            strPartNumberForSearch = txtPartNumber.Text
            strMSRNumberForSearch = txtMSRNumber.Text
            mblnNewRecordsToProcess = True
            txtProjectID.Focus()

            If strProjectIDForSearch = "WHS" Then
                blnProjectIsWHS = True
                Logon.mblnProjectIsWHS = True
            Else
                blnProjectIsWHS = False
                Logon.mblnProjectIsWHS = False
            End If

            For intCounter = 0 To mintProjectUpperLimit

                'Getting the project id
                strProjectIDFromTable = structProjectInfo(intCounter).mstrProjectID
                strMSRNumberFromTable = structProjectInfo(intCounter).mstrMSRNumber

                If blnProjectIsWHS = False Then
                    If strProjectIDFromTable <> "" Then
                        If strProjectIDForSearch = strProjectIDFromTable Then

                            'Setting the boolean variable
                            blnProjectIDNotFound = False

                        End If
                    End If
                End If

                If strMSRNumberFromTable <> "" Then
                    If strMSRNumberForSearch = strMSRNumberFromTable Then

                        'setting the boolean variable
                        blnMSRNumberNotFound = False

                    End If
                End If
            Next

            If blnMSRNumberNotFound = True Or blnProjectIDNotFound = True Then

                For intCounter = 0 To mintNewProjectUpperLimit

                    'Getting project id
                    strProjectIDFromTable = structNewProjectInfo(intCounter).mstrProjectID
                    strMSRNumberFromTable = structNewProjectInfo(intCounter).mstrMSRNumber

                    If blnProjectIsWHS = False Then
                        If strProjectIDFromTable <> "" Then
                            If strProjectIDForSearch = strProjectIDFromTable Then

                                'Setting boolean variable
                                blnProjectIDNotFound = False
                            End If
                        End If
                    End If
                    If strMSRNumberFromTable <> "" Then
                        If strMSRNumberForSearch = strMSRNumberFromTable Then
                            blnMSRNumberNotFound = False
                        End If
                    End If
                Next
            End If

            If Logon.mstrEntryType = "BOM" Then
                blnMSRNumberNotFound = blnProjectIDNotFound
            ElseIf Logon.mstrEntryType = "ISSUE" Then
                blnMSRNumberNotFound = blnProjectIDNotFound
            End If

            If (blnProjectIDNotFound = True And blnMSRNumberNotFound = True And blnProjectIsWHS = False) Then

                Logon.mstrFormForDataEntry = "PROJECT"

                Logon.mstrTWCProjectID = txtProjectID.Text
                Logon.mstrMSR = txtMSRNumber.Text
                ItemNotFound.ShowDialog()

                If Logon.mblnDoNotUpdate = True Then
                    Exit Sub
                Else
                    ValidateProjectID.Show()
                    structNewProjectInfo(mintNewProjectUpperLimit).mstrProjectID = Logon.mstrTWCProjectID
                    structNewProjectInfo(mintNewProjectUpperLimit).mstrMSRNumber = Logon.mstrMSR
                    mintNewProjectUpperLimit += 1
                    mblnNewProjectsCreated = True
                End If

            ElseIf blnProjectIsWHS = True And blnMSRNumberNotFound = True Then

                Logon.mstrFormForDataEntry = "PROJECT"

                Logon.mstrTWCProjectID = ""
                Logon.mstrMSR = txtMSRNumber.Text
                ItemNotFound.ShowDialog()

            If Logon.mblnDoNotUpdate = True Then
                Exit Sub
            Else
                ValidateProjectID.Show()
                structNewProjectInfo(mintNewProjectUpperLimit).mstrProjectID = Logon.mstrTWCProjectID
                structNewProjectInfo(mintNewProjectUpperLimit).mstrMSRNumber = Logon.mstrMSR
                mintNewProjectUpperLimit += 1
                mblnNewProjectsCreated = True
            End If


            ElseIf blnProjectIsWHS = False And blnMSRNumberNotFound = True And blnProjectIDNotFound = False Then

                Logon.mstrTWCProjectID = strProjectIDForSearch
                Logon.mstrMSR = strMSRNumberForSearch
                Logon.mblnUpdateMSRNumber = True
                Logon.mblnUpdateProjectID = False

                EditProjectInformation.Show()

                For intStructureCounter = 0 To mintProjectUpperLimit

                    strProjectIDFromTable = structProjectInfo(intStructureCounter).mstrProjectID

                    If strProjectIDForSearch = strProjectIDFromTable Then
                        structProjectInfo(intStructureCounter).mstrMSRNumber = strMSRNumberForSearch
                    End If
                Next

                 For intStructureCounter = 0 To mintProjectUpperLimit

                    strProjectIDFromTable = structNewProjectInfo(intStructureCounter).mstrProjectID
                    If structNewProjectInfo(intStructureCounter).mstrMSRNumber <> "" Then
                        If strProjectIDForSearch = strProjectIDFromTable Then
                            structNewProjectInfo(intStructureCounter).mstrMSRNumber = strMSRNumberForSearch
                        End If
                    End If
                Next

            ElseIf blnProjectIsWHS = False And blnMSRNumberNotFound = False And blnProjectIDNotFound = True Then

                Logon.mstrTWCProjectID = strProjectIDForSearch
                Logon.mstrMSR = strMSRNumberForSearch
                Logon.mblnUpdateMSRNumber = False
                Logon.mblnUpdateProjectID = True

                EditProjectInformation.Show()

                For intStructureCounter = 0 To mintProjectUpperLimit

                    strMSRNumberFromTable = structProjectInfo(intStructureCounter).mstrMSRNumber

                    If strMSRNumberForSearch = strMSRNumberFromTable Then
                        structProjectInfo(intStructureCounter).mstrProjectID = strProjectIDForSearch
                    End If
                Next

                For intStructureCounter = 0 To mintProjectUpperLimit

                    strMSRNumberFromTable = structNewProjectInfo(intStructureCounter).mstrMSRNumber

                    If strMSRNumberForSearch = strMSRNumberFromTable Then
                        structNewProjectInfo(intStructureCounter).mstrProjectID = strProjectIDForSearch
                    End If
                Next

            End If

        For intCounter = 0 To mintPartNumberUpperLimit

            'Getting part number from array
            strPartNumberFromTable = mstrPartNumber(intCounter)

            'If statements
            If strPartNumberForSearch = strPartNumberFromTable Then
                blnPartNumberNotFound = False
            End If

        Next

        If blnPartNumberNotFound = True Then
            For intCounter = 0 To mintNewPartNumberUpperLimit

                strPartNumberFromTable = mstrNewPartNumber(intCounter)

                'If statements
                If strPartNumberForSearch = strPartNumberFromTable Then
                    blnPartNumberNotFound = False
                End If

            Next
        End If

        If blnPartNumberNotFound = True Then

            Logon.mstrFormForDataEntry = "PART"
            Logon.mstrPartNumber = txtPartNumber.Text

            'Calling Confirmation box
            ItemNotFound.ShowDialog()

            If Logon.mblnDoNotUpdate = True Then
                Exit Sub
            Else
                ValidatePartNumber.Show()

            End If
        ElseIf blnPartNumberNotFound = False Then
            Logon.mblnDoNotUpdate = False
            FinishTransaction()
        End If

        mintTransactionCounter += 1

            If mintTransactionCounter = 50 Then

                btnProcess.PerformClick()
                mintTransactionCounter = 0

            End If


        End If

    End Sub
    Public Sub FinishTransaction()

        'setting local variables
        Dim blnDoNotUpdate As Boolean
        Dim row() As String

        blnDoNotUpdate = Logon.mblnDoNotUpdate

        If blnDoNotUpdate = False Then
            If Logon.mblnNewPartNumber = True Then
                mstrNewPartNumber(mintNewPartNumberUpperLimit) = Logon.mstrPartNumber
                mintNewPartNumberUpperLimit += 1
            End If


            'Adding items to the data grid view
            row = New String() {txtTransactionID.Text, txtDate.Text, txtProjectID.Text, txtMSRNumber.Text, txtPartNumber.Text, txtQuantity.Text}
            dgvBatchTransactions.Rows.Add(row)

            ClearTransactionBoxes()

            btnAdd.Text = "Add"

            If txtDataEntryComplete.Text = "NO" Then
                btnAdd.PerformClick()
            End If

        Else
            MessageBox.Show("Please Correct Transaction", "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub
    Private Sub ClearTransactionBoxes()

        'This will clear out the data controls
        txtPartNumber.Text = ""
        txtQuantity.Text = ""

    End Sub

    Private Sub txtQuantity_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtQuantity.KeyDown

        'This will make the enter key happen
        If e.KeyCode = Keys.Enter Then
            btnAdd.PerformClick()
        End If

    End Sub

    Private Sub btnMenusButton_Click(sender As Object, e As EventArgs) Handles btnMenusButton.Click

        'Writes the last transaction
        LastTransaction.Show()
        btnProcess.PerformClick()

        'Decides which form to launce
        If btnMenusButton.Text = "Receive Menu" Then
            ReceiveMenu.Show()
        ElseIf btnMenusButton.Text = "Issue Menu" Then
            IssueInventory.Show()
        ElseIf btnMenusButton.Text = "Use Menu" Then
            UseInventory.Show()
        End If

        'closes the form
        Me.Close()

    End Sub
    Private Sub btnProcess_Click(sender As Object, e As EventArgs) Handles btnProcess.Click

        'this will process the changes to the form
        'Setting local variables
        Dim intCounter As Integer
        Dim intNumberOfRecords As Integer
        Dim rows() As String

        If mblnNewRecordsToProcess = True Then

            PleaseWait.Show()

            'Clearing the controls
            txtDate.Text = ""
            txtMSRNumber.Text = ""
            txtPartNumber.Text = ""
            txtProjectID.Text = ""
            txtQuantity.Text = ""
            txtTransactionID.Text = ""
            txtTransactionID.Visible = False
            cboTransactionID.Visible = True

            If Logon.mstrEntryType = "RECEIVE" Then
                SetReceiveDataBindings()
            ElseIf Logon.mstrEntryType = "ISSUE" Then
                SetIssueDataBindings()
            ElseIf Logon.mstrEntryType = "BOM" Then
                SetBOMDataBindings()
            End If

            intNumberOfRecords = dgvBatchTransactions.RowCount - 2

            ReDim structProblemTransactions(intNumberOfRecords)
            mintProblemCounter = 0
            mblnThereIsAProblem = False

            For intCounter = 0 To intNumberOfRecords

                mstrTransactionID = dgvBatchTransactions.Rows(intCounter).Cells(0).Value.ToString.ToUpper
                mstrTransactionDate = dgvBatchTransactions.Rows(intCounter).Cells(1).Value.ToString.ToUpper
                mstrTransactionProjectID = dgvBatchTransactions.Rows(intCounter).Cells(2).Value.ToString.ToUpper
                mstrTransactionMSRNumber = dgvBatchTransactions.Rows(intCounter).Cells(3).Value.ToString.ToUpper
                mstrTransactionPartNumber = dgvBatchTransactions.Rows(intCounter).Cells(4).Value.ToString.ToUpper
                mstrTransactionQuantity = dgvBatchTransactions.Rows(intCounter).Cells(5).Value.ToString.ToUpper

                If Logon.mstrEntryType = "RECEIVE" Then
                    CreateReceiveRecords()
                ElseIf Logon.mstrEntryType = "ISSUE" Then
                    CreateIssuedRecords()
                ElseIf Logon.mstrEntryType = "BOM" Then
                    CreateBOMPartsRecords()
                End If

                If mblnThereIsAProblem = True Then
                    structProblemTransactions(mintProblemCounter).mstrDate = mstrTransactionDate
                    structProblemTransactions(mintProblemCounter).mstrMSRNumber = mstrTransactionMSRNumber
                    structProblemTransactions(mintProblemCounter).mstrPartNumber = mstrTransactionPartNumber
                    structProblemTransactions(mintProblemCounter).mstrProjectID = mstrTransactionProjectID
                    structProblemTransactions(mintProblemCounter).mstrQuantity = mstrTransactionQuantity
                    structProblemTransactions(mintProblemCounter).mstrTransactionID = mstrTransactionID
                    structProblemTransactions(mintProblemCounter).mstrWarehouseID = CStr(Logon.mintPartsWarehouseID)
                    mintProblemCounter += 1
                    Logon.mstrLastTransactionSummary = mstrErrorMessage
                    LastTransaction.Show()
                End If

            Next

            mintProblemUpperLimit = mintProblemCounter - 1
            mintProblemCounter = 0

            For intCounter = 0 To intNumberOfRecords

                dgvBatchTransactions.Rows.Clear()

            Next

            ClearDataBindings()
            ClearTransactionBoxes()
            cboTransactionID.Visible = False
            txtTransactionID.Visible = True
            mblnNewRecordsToProcess = False
            PleaseWait.Close()


            If mblnThereIsAProblem = True Then

                mblnNewRecordsToProcess = True

                For intCounter = 0 To mintProblemUpperLimit

                    rows = New String() {structProblemTransactions(intCounter).mstrTransactionID, structProblemTransactions(intCounter).mstrDate, structProblemTransactions(intCounter).mstrProjectID, structProblemTransactions(intCounter).mstrMSRNumber, structProblemTransactions(intCounter).mstrPartNumber, structProblemTransactions(intCounter).mstrQuantity, structProblemTransactions(intCounter).mstrWarehouseID}
                    dgvBatchTransactions.Rows.Add(rows)

                Next

                MessageBox.Show("The Following Transactions Were Not Saved, Please Check Last Transaction Log and Process Again", "Thank You", MessageBoxButtons.OK, MessageBoxIcon.Error)

            ElseIf mblnThereIsAProblem = False Then

                If txtDataEntryComplete.Text = "NO" Then
                    btnAdd.Text = "Add"
                    btnAdd.PerformClick()
                Else
                    btnAdd.Text = "Add"
                End If

            End If
        End If

        mintTransactionCounter = 0

    End Sub
    Private Sub CreateReceiveRecords()

        'This will save the record
        Try

            'Setting up the binding source
            With TheReceivedPartsBindingSource
                .EndEdit()
                .AddNew()
            End With

            addingBoolean = True
            SetComboBoxBinding()

            'Setting value of the controls
            cboTransactionID.Visible = True
            cboTransactionID.Text = mstrTransactionID
            txtDate.Text = mstrTransactionDate
            txtMSRNumber.Text = mstrTransactionMSRNumber
            txtPartNumber.Text = mstrTransactionPartNumber
            txtProjectID.Text = mstrTransactionProjectID
            txtQuantity.Text = mstrTransactionQuantity
            txtWarehouseID.Text = CStr(Logon.mintPartsWarehouseID)

            Logon.mstrPartNumber = mstrTransactionPartNumber
            Logon.mintQuantity = CInt(mstrTransactionQuantity)

            UpdateInventory.Show()
            UpdateWarehouseInventory.Show()

            'Saving Record
            TheReceivedPartsBindingSource.EndEdit()
            TheReceivedPartsDataTier.UpdateReceivedPartsDB(TheReceivedPartsDataSet)
            addingBoolean = False
            editingBoolean = False
            SetComboBoxBinding()

        Catch ex As Exception
            mstrErrorMessage = ex.Message
            mblnThereIsAProblem = True
        End Try

    End Sub
    Private Sub CreateIssuedRecords()

        'This will save the record
        Try

            'Setting up the binding source
            With TheIssuedPartsBindingSource
                .EndEdit()
                .AddNew()
            End With

            addingBoolean = True
            SetComboBoxBinding()

            'Setting value of the controls
            cboTransactionID.Visible = True
            cboTransactionID.Text = mstrTransactionID
            txtDate.Text = mstrTransactionDate
            txtMSRNumber.Text = mstrTransactionMSRNumber
            txtPartNumber.Text = mstrTransactionPartNumber
            txtProjectID.Text = mstrTransactionProjectID
            txtQuantity.Text = mstrTransactionQuantity
            txtWarehouseID.Text = CStr(Logon.mintPartsWarehouseID)

            Logon.mstrPartNumber = mstrTransactionPartNumber
            Logon.mintQuantity = (CInt(mstrTransactionQuantity)) * -1

            UpdateWarehouseInventory.Show()

            'Saving Record
            TheIssuedPartsBindingSource.EndEdit()
            TheIssuedPartsDataTier.UpdateIssuedPartsDB(TheIssuedPartsDataSet)
            addingBoolean = False
            editingBoolean = False
            SetComboBoxBinding()

        Catch ex As Exception
            mstrErrorMessage = ex.Message
            mblnThereIsAProblem = True
        End Try

    End Sub
    Private Sub CreateBOMPartsRecords()

        'This will save the record
        Try

            'Setting up the binding source
            With TheBOMPartsBindingSource
                .EndEdit()
                .AddNew()
            End With

            addingBoolean = True
            SetComboBoxBinding()

            'Setting value of the controls
            cboTransactionID.Visible = True
            cboTransactionID.Text = mstrTransactionID
            txtDate.Text = mstrTransactionDate
            txtMSRNumber.Text = mstrTransactionMSRNumber
            txtPartNumber.Text = mstrTransactionPartNumber
            txtProjectID.Text = mstrTransactionProjectID
            txtQuantity.Text = mstrTransactionQuantity
            txtWarehouseID.Text = CStr(Logon.mintPartsWarehouseID)

            Logon.mstrPartNumber = mstrTransactionPartNumber
            Logon.mintQuantity = (CInt(mstrTransactionQuantity)) * -1

            UpdateInventory.Show()

            'Saving Record
            TheBOMPartsBindingSource.EndEdit()
            TheBOMPartsDataTier.UpdateBOMPartsDB(TheBOMPartsDataSet)
            addingBoolean = False
            editingBoolean = False
            SetComboBoxBinding()

        Catch ex As Exception
            mstrErrorMessage = ex.Message
            mblnThereIsAProblem = True
        End Try

    End Sub

    Private Sub txtPartNumber_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPartNumber.KeyDown

        If e.KeyCode = Keys.Enter Then
            btnAdd.PerformClick()
        End If
    End Sub
End Class