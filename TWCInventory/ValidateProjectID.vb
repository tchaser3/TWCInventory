'Title:         Validate Project ID
'Date:          3-4-15
'Author:        Terry Holmes

'Description:   This form will validate the inputted Project ID and possibly create it.

Option Strict On

Public Class ValidateProjectID

    Private TheInternalProjectsDataTier As InternalProjectsDataTier
    Private TheInternalProjectsDataSet As InternalProjectsDataSet
    Private WithEvents TheInternalProjectsBindingSource As BindingSource

    Private addingBoolean As Boolean = False
    Private editingBoolean As Boolean = False
    Private previouseSelectedIndex As Integer

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

    Private Sub ValidateProjectID_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Setting up local variables
        Dim intCounter As Integer
        Dim intNumberOfRecords As Integer
        Dim strProjectIDForSearch As String
        Dim strProjectIDFromTable As String
        Dim strMSRNumberFromTable As String
        Dim strMSRNumberForSearch As String
        Dim blnItemNotFound As Boolean = True
        Dim blnProjectISWHS As Boolean

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
            txtMSRNumber.DataBindings.Add("Text", TheInternalProjectsBindingSource, "MSRNumber")

            'beginning search
            intNumberOfRecords = cboTransactionID.Items.Count - 1
            strProjectIDForSearch = Logon.mstrTWCProjectID
            strMSRNumberForSearch = Logon.mstrMSR
            blnProjectISWHS = Logon.mblnProjectIsWHS

            'beginning loop
            For intCounter = 0 To intNumberOfRecords

                'incrementing the counter
                cboTransactionID.SelectedIndex = intCounter

                'Getting the project id
                strProjectIDFromTable = txtProjectID.Text
                strMSRNumberFromTable = txtMSRNumber.Text

                'If statement to set the boolean modifier
                If blnProjectISWHS = False Then
                    If strProjectIDForSearch = strProjectIDFromTable Then
                        blnItemNotFound = False
                    ElseIf strMSRNumberFromTable <> "" Then
                        If strMSRNumberForSearch = strMSRNumberFromTable Then
                            blnItemNotFound = False
                        End If
                    End If
                ElseIf blnProjectISWHS = True Then
                    strProjectIDForSearch = ""
                    If strMSRNumberFromTable <> "" Then
                        If strMSRNumberForSearch = strMSRNumberFromTable Then
                            blnItemNotFound = False
                        End If
                    End If
                End If
            Next

            Logon.mblnItemNotFound = blnItemNotFound

            If Logon.mblnDoNotUpdate = False Then

                'this will create a new record
                'This will catch an illegal operation
                With TheInternalProjectsBindingSource
                    .EndEdit()
                    .AddNew()
                End With

                'Setting up the variables
                addingBoolean = True
                SetComboBoxBinding()
                CreateProjectID.Show()
                cboTransactionID.Text = CStr(Logon.mintCreatedTransactionID)
                txtProjectID.Text = strProjectIDForSearch
                txtMSRNumber.Text = strMSRNumberForSearch

                'Calling the process to save
                TheInternalProjectsBindingSource.EndEdit()
                TheInternalProjectsDataTier.UpdateInternalProjectsDB(TheInternalProjectsDataSet)
                addingBoolean = False
                editingBoolean = False
                SetComboBoxBinding()

            End If

            Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class