'Title:         Create Project ID
'Date:          12-3-14
'Author:        Terry Holmes

'Description:   This form is used to create/view projects

Option Strict On

Public Class CreateProjects

    Private TheInternalProjectsDataTier As InternalProjectsDataTier
    Private TheInternalProjectsDataSet As InternalProjectsDataSet
    Private WithEvents TheInternalProjectsBindingSource As BindingSource

    Private addingBoolean As Boolean = False
    Private editingBoolean As Boolean = False
    Private previouseSelectedIndex As Integer

    Dim TheInputDataValidation As New InputDataValidation
    Dim TheKeywordSearch As New KeyWordSearchClass

    'Global Array for Key Word Search
    Structure Projects
        Dim mintSelectedIndex As Integer
        Dim mintInternalID As Integer
        Dim mstrProjectID As String
        Dim mstrProjectName As String
        Dim mstrMSRNumber As String
    End Structure

    Dim structProjects() As Projects
    Dim mintProjectUpperLimit As Integer

    Dim mintSelectedIndex() As Integer
    Dim mintIndexCounter As Integer
    Dim mintIndexUpperLimit As Integer

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

    Private Sub CreateProjects_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'This will load when the form is loaded
        Try

            'Setting up the data set variables
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

            'Binding the Combo Box
            With cboTransactionID
                .DataSource = TheInternalProjectsBindingSource
                .DisplayMember = "InternalProjectID"
                .DataBindings.Add("text", TheInternalProjectsBindingSource, "InternalProjectID", False, DataSourceUpdateMode.Never)
            End With

            'Binding the rest of the controls
            txtProjectID.DataBindings.Add("text", TheInternalProjectsBindingSource, "TWCControlNumber")
            txtProjectName.DataBindings.Add("text", TheInternalProjectsBindingSource, "ProjectName")
            txtMSRNumber.DataBindings.Add("text", TheInternalProjectsBindingSource, "MSRNumber")

            LoadProjectStructure()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub LoadProjectStructure()

        'Setting local variables
        Dim intCounter As Integer

        PleaseWait.Show()

        'Setting Dimensions of the Structure
        mintProjectUpperLimit = cboTransactionID.Items.Count - 1
        ReDim structProjects(mintProjectUpperLimit)
        ReDim mintSelectedIndex(mintProjectUpperLimit)

        'Running Loop
        For intCounter = 0 To mintProjectUpperLimit

            'incrementing the combo box
            cboTransactionID.SelectedIndex = intCounter

            'loading the structure
            structProjects(intCounter).mintSelectedIndex = intCounter
            structProjects(intCounter).mintInternalID = CInt(cboTransactionID.Text)
            structProjects(intCounter).mstrMSRNumber = txtMSRNumber.Text
            structProjects(intCounter).mstrProjectID = txtProjectID.Text
            structProjects(intCounter).mstrProjectName = txtProjectName.Text

        Next

        PleaseWait.Close()

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        CloseProgram.ShowDialog()

    End Sub

    Private Sub btnMainMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMainMenu.Click

        'This will launch the main menu
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click

        'this will search the structures
        'setting local variables
        Dim intCounter As Integer
        Dim strKeyWordForSearch As String
        Dim strKeyWordFromTable As String
        Dim strProjectIDForSearch As String
        Dim strProjectIDFromTable As String
        Dim strMSRNumberForSearch As String
        Dim strMSRNumberFromTable As String
        Dim blnKeyWordNotFound As Boolean
        Dim blnFatalError As Boolean = False
        Dim blnItemNotFound As Boolean

        'beginning Data Validation
        strKeyWordForSearch = txtFindProject.Text
        blnFatalError = TheInputDataValidation.VerifyTextData(strKeyWordForSearch)
        If blnFatalError = True Then
            MessageBox.Show("No Information Was Entered", "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        btnBack.Enabled = False
        btnNext.Enabled = False
        mintIndexCounter = 0
        strProjectIDForSearch = txtFindProject.Text
        strMSRNumberForSearch = txtFindProject.Text

        'beginning Loop
        For intCounter = 0 To mintProjectUpperLimit

            'loading controls
            strKeyWordFromTable = structProjects(intCounter).mstrProjectName
            strProjectIDFromTable = structProjects(intCounter).mstrProjectID
            strMSRNumberFromTable = structProjects(intCounter).mstrMSRNumber
            blnKeyWordNotFound = TheKeywordSearch.FindKeyWord(strKeyWordForSearch, strKeyWordFromTable)

            'if statements to determine if it was found
            If strProjectIDForSearch = strProjectIDFromTable And strProjectIDFromTable <> "" Then
                mintSelectedIndex(mintIndexCounter) = structProjects(intCounter).mintSelectedIndex
                blnItemNotFound = False
                mintIndexCounter += 1
            ElseIf strMSRNumberForSearch = strMSRNumberFromTable And strMSRNumberFromTable <> "" Then
                mintSelectedIndex(mintIndexCounter) = structProjects(intCounter).mintSelectedIndex
                blnItemNotFound = False
                mintIndexCounter += 1
            ElseIf blnKeyWordNotFound = False Then
                mintSelectedIndex(mintIndexCounter) = structProjects(intCounter).mintSelectedIndex
                blnItemNotFound = False
                mintIndexCounter += 1
            End If

        Next

        'Message to user
        If blnItemNotFound = True Then
            txtFindProject.Text = ""
            MessageBox.Show("No Items Not Found", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        'setting up navigation
        mintIndexUpperLimit = mintIndexCounter - 1
        mintIndexCounter = 0

        If mintIndexUpperLimit > 0 Then
            btnNext.Enabled = True
        End If

        cboTransactionID.SelectedIndex = mintSelectedIndex(0)
        txtFindProject.Text = ""

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        'This will add a new Project ID for the application

        'Setting Local Variables
        Dim strValueForValidation As String
        Dim blnFatalError As Boolean = False

        'If Statements 
        If btnAdd.Text = "Add" Then

            'Setting up the binding source for adding a record
            With TheInternalProjectsBindingSource
                .EndEdit()
                .AddNew()
            End With

            'Setting variables for adding a record
            addingBoolean = True
            SetComboBoxBinding()
            If cboTransactionID.SelectedIndex <> -1 Then
                previouseSelectedIndex = cboTransactionID.Items.Count - 1
            Else
                previouseSelectedIndex = 0
            End If

            CreateProjectID.Show()
            cboTransactionID.Text = CStr(Logon.mintCreatedTransactionID)
            btnAdd.Text = "Save"
            SetControlsReadonly(False)

        Else

            'Performing Data Validation
            strValueForValidation = txtProjectID.Text
            blnFatalError = TheInputDataValidation.VerifyTextData(strValueForValidation)

            'User Output for Data Validation Failure
            If blnFatalError = True Then
                MessageBox.Show("Project ID was not Entered", "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            'Try Catch to save the record
            Try

                'Updating the data set
                TheInternalProjectsBindingSource.EndEdit()
                TheInternalProjectsDataTier.UpdateInternalProjectsDB(TheInternalProjectsDataSet)

                'Resetting variables and controls
                editingBoolean = False
                addingBoolean = False
                SetComboBoxBinding()
                cboTransactionID.SelectedIndex = previouseSelectedIndex
                btnAdd.Text = "Add"
                SetControlsReadonly(True)
                LoadProjectStructure()

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If

    End Sub
    Private Sub SetControlsReadonly(ByVal valueBoolean As Boolean)

        txtMSRNumber.ReadOnly = valueBoolean
        txtProjectID.ReadOnly = valueBoolean
        txtProjectName.ReadOnly = valueBoolean

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        mintIndexCounter += 1

        cboTransactionID.SelectedIndex = mintSelectedIndex(mintIndexCounter)

        btnBack.Enabled = True

        If mintIndexCounter = mintIndexUpperLimit Then
            btnNext.Enabled = False
        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        mintIndexCounter -= 1

        cboTransactionID.SelectedIndex = mintSelectedIndex(mintIndexCounter)

        btnNext.Enabled = True

        If mintIndexCounter = 0 Then
            btnBack.Enabled = False
        End If

    End Sub

    Private Sub btnProjectMenu_Click(sender As Object, e As EventArgs) Handles btnProjectMenu.Click

        'This will open up the project menu
        ViewProjects.Show()
        Me.Close()

    End Sub
End Class