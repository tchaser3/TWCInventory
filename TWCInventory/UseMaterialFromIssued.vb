'Title:         Use Material From Issued Table
'Date:          3-5-15
'Author:        Terry Holmes

'Description:   This form will allow the user to use material and post it to the BOM Table

Option Strict On

Public Class UseMaterialFromIssued

    'Declaring the classes
    Dim TheInputDataValidation As New InputDataValidation
    Dim TheKeywordSearch As New KeyWordSearchClass
    Dim TheDateSearchClass As New DateSearchClass

    'Setting local variables
    Private addingBoolean As Boolean = False
    Private editingBoolean As Boolean = False
    Private previousSelectedIndex As Integer

    'Setting up the global data sources
    Private TheIssuePartsDataSet As IssuedPartsDataSet
    Private TheIssuePartsDataTier As TWInventoryDataTier
    Private WithEvents TheIssuePartsBindingSource As BindingSource

    Private ThePartNumberDataTier As PartsDataTier
    Private ThePartNumberDataSet As PartNumberDataSet
    Private WithEvents ThePartNumberBindingSource As BindingSource

    Private TheBOMPartsDataSet As BOMPartsDataSet
    Private TheBOMPartsDataTier As TWInventoryDataTier
    Private WithEvents TheBOMPartsBindingSource As BindingSource

    Private TheInternalProjectsDataSet As InternalProjectsDataSet
    Private TheInternalProjectDataTier As InternalProjectsDataTier
    Private WithEvents TheInternalProjectBindingSource As BindingSource

    Structure IssuedTransactions
        Dim mdatDate As Date
        Dim mstrProjectID As String
        Dim mstrPartNumber As String
        Dim mintQuantity As Integer
        Dim mintWarehouseID As Integer
    End Structure

    Dim structIssuedTransactions() As IssuedTransactions
    Dim mintIssuedCounter As Integer
    Dim mintIssuedUpperLimit As Integer

    Structure UsedTransactions
        Dim mdatDate As Date
        Dim mstrProjectID As String
        Dim mstrPartNumber As String
        Dim mintQuantity As Integer
        Dim mintWarehouseID As Integer
    End Structure

    Dim structUsedTransactions() As UsedTransactions
    Dim mintUsedCounter As Integer
    Dim mintUsedUpperLimit As Integer

    Structure Parts
        Dim mstrPartNumber As String
        Dim mstrDescription As String
    End Structure

    Dim structParts() As Parts
    Dim mintPartCounter As Integer
    Dim mintPartUpperLimit As Integer

    Structure Projects
        Dim mintInternalProjectID As Integer
        Dim mstrTWCProjectID As String
    End Structure

    Dim structProjects() As Projects
    Dim mintProjectCounter As Integer
    Dim mintProjectUpperLimit As Integer

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        'This will close the program
        CloseProgram.ShowDialog()

    End Sub

    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click

        'This will show the main menu
        LastTransaction.Show()
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub btnUseMenu_Click(sender As Object, e As EventArgs) Handles btnUseMenu.Click

        'This will open the use menu
        LastTransaction.Show()
        UseInventory.Show()
        Me.Close()

    End Sub
    Private Sub SetProjectControlsVisible(ByVal ValueBoolean As Boolean)

        'This will set the controls visible
        cboInternalProjectID.Visible = ValueBoolean
        txtTWCProjectID.Visible = ValueBoolean

    End Sub
    Private Sub SetTransactionControlsVisible(ByVal valueBoolean As Boolean)

        'This will set the controls visible
        cboTransactionID.Visible = valueBoolean
        cboPartNumber.Visible = valueBoolean
        txtPartDescription.Visible = valueBoolean
        txtTransactionInternalID.Visible = valueBoolean
        txtTransactionPartNumber.Visible = valueBoolean
        txtTransactionQuantity.Visible = valueBoolean
        txtTransactionTWCProjectID.Visible = valueBoolean
        txtTransactionDate.Visible = valueBoolean
        txtTransactionWarehouseID.Visible = valueBoolean


    End Sub
    Private Sub ClearTransactionDatabindings()

        'This will clear the transaction data bindings
        cboTransactionID.DataBindings.Clear()
        txtTransactionInternalID.DataBindings.Clear()
        txtTransactionPartNumber.DataBindings.Clear()
        txtTransactionQuantity.DataBindings.Clear()
        txtTransactionTWCProjectID.DataBindings.Clear()

    End Sub
    Private Sub ClearProjectDatabindings()

        'This will clear the project data bindings
        cboInternalProjectID.DataBindings.Clear()
        txtTWCProjectID.DataBindings.Clear()

    End Sub
    Private Function SetProjectDataBindings() As Boolean

        Dim blnFatalError As Boolean = False
        Dim intCounter As Integer
        Dim intNumberOfRecords As Integer
        Dim blnItemNotFound As Boolean = True

        'this wil set up the projects controls to be bound
        Try

            'Setting up the data controls
            TheInternalProjectDataTier = New InternalProjectsDataTier
            TheInternalProjectsDataSet = TheInternalProjectDataTier.GetInternalProjectsInformation
            TheInternalProjectBindingSource = New BindingSource

            'Setting up the binding source
            With TheInternalProjectBindingSource
                .DataSource = TheInternalProjectsDataSet
                .DataMember = "internalprojects"
                .MoveFirst()
                .MoveLast()
            End With

            'Setting up the combo box
            With cboInternalProjectID
                .DataSource = TheInternalProjectBindingSource
                .DisplayMember = "internalProjectID"
                .DataBindings.Add("text", TheInternalProjectBindingSource, "internalProjectID", False, DataSourceUpdateMode.Never)
            End With

            'setting up the other control
            txtTWCProjectID.DataBindings.Add("text", TheInternalProjectBindingSource, "TWCControlNumber")

            'Perparing for Loop
            intNumberOfRecords = cboInternalProjectID.Items.Count - 1
            mintProjectUpperLimit = intNumberOfRecords
            ReDim structProjects(mintProjectUpperLimit)
            mintProjectCounter = 0

            'Loop to fill the structure
            For intCounter = 0 To intNumberOfRecords

                'incrementing the combo box
                cboInternalProjectID.SelectedIndex = intCounter

                'Loading the structure
                structProjects(mintProjectCounter).mintInternalProjectID = CInt(cboInternalProjectID.Text)
                structProjects(mintProjectCounter).mstrTWCProjectID = txtTWCProjectID.Text
                mintProjectCounter += 1
                blnItemNotFound = False

            Next

            If blnItemNotFound = True Then
                MessageBox.Show("There Are No Projects", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error)
                blnFatalError = True
            Else
                mintProjectUpperLimit = mintProjectCounter - 1
                mintProjectCounter = 0
                blnFatalError = False
            End If

            Return blnFatalError

        Catch ex As Exception

            'Message to user if there is a failure
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            blnFatalError = True
            Return blnFatalError

        End Try

    End Function
    Private Function SetPartsDataBindings() As Boolean

        'Setting local variables
        Dim intCounter As Integer
        Dim intNumberOfRecords As Integer
        Dim blnFatalError As Boolean = False
        Dim blnItemNotFound As Boolean = True

        Try

            'Setting up the parts
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

            'Getting ready to fill structure
            intNumberOfRecords = cboPartNumber.Items.Count - 1
            ReDim structParts(intNumberOfRecords)
            mintPartCounter = 0

            'Preforming Loop
            For intCounter = 0 To intNumberOfRecords

                'incrementing the combo box
                cboPartNumber.SelectedIndex = intCounter

                'Loading the array
                structParts(mintPartCounter).mstrPartNumber = cboPartNumber.Text
                structParts(mintPartCounter).mstrDescription = txtPartDescription.Text
                mintPartCounter += 1
                blnItemNotFound = False

            Next

            'If statements
            If blnItemNotFound = True Then
                blnFatalError = True
            Else
                mintPartUpperLimit = mintPartCounter - 1
                blnFatalError = False
                mintPartCounter = 0
            End If

            Return blnFatalError

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            blnFatalError = True
            Return blnFatalError
        End Try

    End Function

    Private Sub UseMaterialFromIssued_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim blnFatalError As Boolean

        blnFatalError = SetProjectDataBindings()

        PleaseWait.Show()
        If blnFatalError = False Then
            blnFatalError = SetIssuedPartsDataBindings()
        End If
        If blnFatalError = False Then
            blnFatalError = SetPartsDataBindings()
        End If

        PleaseWait.Close()
        If blnFatalError = True Then
            dgvSearchResults.Visible = False
            SetTransactionControlsVisible(False)
            SetProjectControlsVisible(False)
            btnFind.Enabled = False
            MessageBox.Show("There is a Problem", "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

        End If

    End Sub
    Private Sub SetUsedPartsDataBindings()

        'This will set the bindings for receive parts
        Try

            'Setting up the data variables
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

            'Binding the combo box
            With cboTransactionID
                .DataSource = TheBOMPartsBindingSource
                .DisplayMember = "TransactionID"
                .DataBindings.Add("text", TheBOMPartsBindingSource, "TransactionID", False, DataSourceUpdateMode.Never)
            End With

            'Binding the rest of the controls
            txtTransactionInternalID.DataBindings.Add("text", TheBOMPartsBindingSource, "InternalProjectID")
            txtTransactionPartNumber.DataBindings.Add("Text", TheBOMPartsBindingSource, "PartNumber")
            txtTransactionQuantity.DataBindings.Add("text", TheBOMPartsBindingSource, "QTY")
            txtTransactionTWCProjectID.DataBindings.Add("text", TheBOMPartsBindingSource, "ProjectID")
            txtTransactionWarehouseID.DataBindings.Add("text", TheBOMPartsBindingSource, "WarehouseID")
            txtTransactionDate.DataBindings.Add("Text", TheBOMPartsBindingSource, "Date")

        Catch ex As Exception

            'Output to user if there is a failure
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Function SetIssuedPartsDataBindings() As Boolean

        'Setting local variables
        Dim intCounter As Integer
        Dim intNumberOfRecords As Integer
        Dim intWarehouseIDForSearch As Integer
        Dim intWarehouseIDFromTable As Integer
        Dim blnFatalError As Boolean = False
        Dim blnItemNotFound As Boolean = True

        'This will set the bindings for receive parts
        Try

            'Setting up the data variables
            TheIssuePartsDataTier = New TWInventoryDataTier
            TheIssuePartsDataSet = TheIssuePartsDataTier.GetIssuedPartsInformation
            TheIssuePartsBindingSource = New BindingSource

            'Setting up the binding source
            With TheIssuePartsBindingSource
                .DataSource = TheIssuePartsDataSet
                .DataMember = "IssuedParts"
                .MoveFirst()
                .MoveLast()
            End With

            'Binding the combo box
            With cboTransactionID
                .DataSource = TheIssuePartsBindingSource
                .DisplayMember = "TransactionID"
                .DataBindings.Add("text", TheIssuePartsBindingSource, "TransactionID", False, DataSourceUpdateMode.Never)
            End With

            'Binding the rest of the controls
            txtTransactionInternalID.DataBindings.Add("text", TheIssuePartsBindingSource, "InternalProjectID")
            txtTransactionPartNumber.DataBindings.Add("Text", TheIssuePartsBindingSource, "PartNumber")
            txtTransactionQuantity.DataBindings.Add("text", TheIssuePartsBindingSource, "QTY")
            txtTransactionTWCProjectID.DataBindings.Add("text", TheIssuePartsBindingSource, "ProjectID")
            txtTransactionWarehouseID.DataBindings.Add("text", TheIssuePartsBindingSource, "WarehouseID")
            txtTransactionDate.DataBindings.Add("text", TheIssuePartsBindingSource, "Date")

            'setting up for the loop
            intNumberOfRecords = cboTransactionID.Items.Count - 1
            ReDim structIssuedTransactions(intNumberOfRecords)
            mintIssuedCounter = 0
            mintIssuedUpperLimit = intNumberOfRecords
            intWarehouseIDForSearch = Logon.mintPartsWarehouseID

            'Beginning loop
            For intCounter = 0 To intNumberOfRecords

                'incrementing the combo box 
                cboTransactionID.SelectedIndex = intCounter

                'getting warehouse id
                intWarehouseIDFromTable = CInt(txtTransactionWarehouseID.Text)

                'if statements
                If intWarehouseIDForSearch = intWarehouseIDFromTable Then

                    structIssuedTransactions(mintIssuedCounter).mdatDate = CDate(txtTransactionDate.Text)
                    structIssuedTransactions(mintIssuedCounter).mintQuantity = CInt(txtTransactionQuantity.Text)
                    structIssuedTransactions(mintIssuedCounter).mintWarehouseID = CInt(txtTransactionWarehouseID.Text)
                    structIssuedTransactions(mintIssuedCounter).mstrPartNumber = txtTransactionPartNumber.Text
                    structIssuedTransactions(mintIssuedCounter).mstrProjectID = txtTransactionTWCProjectID.Text
                    mintIssuedCounter += 1
                    blnItemNotFound = False

                End If
            Next

            If blnItemNotFound = True Then
                blnFatalError = True
            Else
                mintIssuedUpperLimit = mintIssuedCounter - 1
                mintIssuedCounter = 0
                blnFatalError = False
            End If

            Return blnFatalError

        Catch ex As Exception

            'Output to user if there is a failure
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            blnFatalError = True
            Return blnFatalError

        End Try
    End Function

    Private Sub SetComboBoxBinding()

        'This will set the combo box binding
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

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click

        'This sub routine will find the transactions that match the search criteria

        'Setting local variables
        Dim intProjectCounter As Integer
        Dim intProjectNumberOfRecords As Integer
        Dim intProjectSelectedIndex As Integer
        Dim strProjectIDForSearch As String
        Dim strProjectIDFromTable As String
        Dim blnProjectIDNotFound As Boolean = True
        Dim blnFatalError As Boolean = False
        Dim strMessageHeader As String

        PleaseWait.Show()

        'this will clear the transactions
        ClearTransactionDatabindings()
        dgvSearchResults.Rows.Clear()

        'Performing Data Validation
        SetProjectControlsVisible(True)
        strProjectIDForSearch = txtProjectIDForSearch.Text
        strMessageHeader = "Enter Project ID"
        blnFatalError = TheInputDataValidation.VerifyTextData(strProjectIDForSearch)

        'Output to user if there is a failure
        If blnFatalError = True Then
            SetProjectControlsVisible(False)
            MessageBox.Show("Project ID Was Not Entered", strMessageHeader, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'Preparing for the loop to find the Project ID
        intProjectNumberOfRecords = cboInternalProjectID.Items.Count - 1

        'preforming loop
        For intProjectCounter = 0 To intProjectNumberOfRecords

            'incrementing the project id combo box
            cboInternalProjectID.SelectedIndex = intProjectCounter

            'Getting the project id
            strProjectIDFromTable = txtTWCProjectID.Text

            'If statements to check
            If strProjectIDForSearch = strProjectIDFromTable Then
                intProjectSelectedIndex = intProjectCounter
                blnProjectIDNotFound = False
            End If

        Next

        'Outputting to the user
        If blnProjectIDNotFound = True Then
            txtProjectIDForSearch.Text = ""
            SetProjectControlsVisible(False)
            MessageBox.Show("Project ID Not Found", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        SetIssuedPartsDataBindings()
        cboInternalProjectID.SelectedIndex = intProjectSelectedIndex
        SetTransactionControlsVisible(Visible)
        dgvSearchResults.Visible = True
        FindIssuedTransactions()

        'closes the please wait form
        PleaseWait.Close()

        Logon.mstrLastTransactionSummary = "VIEWED ALL PARTS ISSUED FOR PROJECT " + txtProjectIDForSearch.Text
        LastTransaction.Show()

    End Sub
    Private Sub FindIssuedTransactions()

        'This will find all the transactions
        'Setting up local variables

        Dim intTransactionCounter As Integer
        Dim intTransactionNumberOfRecords As Integer
        Dim strProjectIDForSearch As String
        Dim strProjectIDFromTable As String
        Dim blnTransactionNotFound As Boolean = True

        'variables for the grid
        Dim row() As String

        'Setting up the gridview
        dgvSearchResults.ColumnCount = 5
        dgvSearchResults.Columns(0).Name = "Project ID"
        dgvSearchResults.Columns(1).Name = "Part Number"
        dgvSearchResults.Columns(2).Name = "TWC Project ID"
        dgvSearchResults.Columns(3).Name = "Quantity"
        dgvSearchResults.Columns(4).Name = "Was Product Used"

        'Setting up for the loop
        intTransactionNumberOfRecords = cboTransactionID.Items.Count - 1
        strProjectIDForSearch = txtTWCProjectID.Text

        'Performing Loop
        For intTransactionCounter = 0 To intTransactionNumberOfRecords

            'incrementing the combo box
            cboTransactionID.SelectedIndex = intTransactionCounter

            'Getting project id
            strProjectIDFromTable = txtTransactionTWCProjectID.Text

            If strProjectIDForSearch = strProjectIDFromTable Then

                'Setting variables
                blnTransactionNotFound = False

                'adding the row to the gridview
                row = New String() {cboInternalProjectID.Text, txtTransactionPartNumber.Text, txtTransactionTWCProjectID.Text, txtTransactionQuantity.Text, "YES"}
                dgvSearchResults.Rows.Add(row)

            End If

        Next

        If blnTransactionNotFound = True Then
            SetProjectControlsVisible(False)
            SetTransactionControlsVisible(False)
            dgvSearchResults.Visible = False
            MessageBox.Show("No Transactions Were Found", "Thank You", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        btnProcess.Enabled = True

    End Sub

    Private Sub btnProcess_Click(sender As Object, e As EventArgs) Handles btnProcess.Click

        Dim intNumberOfRecords = dgvSearchResults.RowCount - 2
        Dim intRowCounter As Integer
        Dim strNeededUpdated As String
        Dim intQuantity As Integer

        'launches the please wait
        PleaseWait.Show()

        'clearing the data bindings
        ClearTransactionDatabindings()

        'setting the BOM Part Bindings
        SetUsedPartsDataBindings()

        For intRowCounter = 0 To intNumberOfRecords

            Try

                strNeededUpdated = dgvSearchResults.Rows(intRowCounter).Cells(4).Value.ToString.ToUpper

                If strNeededUpdated = "YES" Then

                    With TheBOMPartsBindingSource
                        .EndEdit()
                        .AddNew()
                    End With

                    'Setting the variables
                    addingBoolean = True
                    SetComboBoxBinding()
                    CreateID.Show()
                    cboTransactionID.Text = CStr(Logon.mintCreatedTransactionID)
                    txtTransactionInternalID.Text = dgvSearchResults.Rows(intRowCounter).Cells(0).Value.ToString.ToUpper
                    txtTransactionPartNumber.Text = dgvSearchResults.Rows(intRowCounter).Cells(1).Value.ToString.ToUpper
                    txtTransactionTWCProjectID.Text = dgvSearchResults.Rows(intRowCounter).Cells(2).Value.ToString.ToUpper
                    txtTransactionQuantity.Text = dgvSearchResults.Rows(intRowCounter).Cells(3).Value.ToString.ToUpper

                    'getting the quantity
                    intQuantity = CInt(txtTransactionQuantity.Text)
                    intQuantity = intQuantity * -1

                    Logon.mintQuantity = intQuantity
                    Logon.mstrPartNumber = txtTransactionPartNumber.Text

                    UpdateInventory.Show()

                    'saving record
                    TheBOMPartsBindingSource.EndEdit()
                    TheBOMPartsDataTier.UpdateBOMPartsDB(TheBOMPartsDataSet)
                    addingBoolean = False
                    editingBoolean = False
                    SetComboBoxBinding()

                End If

            Catch ex As Exception

                'Output to user
                MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try

        Next

        'Setting form for orginal information
        dgvSearchResults.Visible = False
        SetTransactionControlsVisible(False)
        SetProjectControlsVisible(False)
        ClearTransactionDatabindings()

        'this closes the please wait form
        PleaseWait.Close()

        Logon.mstrLastTransactionSummary = "SHOWED USAGE FOR PROJECT " + txtProjectIDForSearch.Text
        LastTransaction.Show()

    End Sub
End Class