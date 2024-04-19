'Title:         Edit Project Information
'Date:          11-4-15
'Author:        Terry Holmes

'Description:   This form is used to edit an existing project

Option Strict On

Public Class EditProjectInformation

    Private TheInternalProjectDataSet As InternalProjectsDataSet
    Private TheInternalProjectDataTier As InternalProjectsDataTier
    Private WithEvents TheInternalProjectBindingSource As BindingSource

    Private Sub EditProjectInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'setting local variables
        Dim intCounter As Integer
        Dim intNumberOfRecords As Integer
        Dim strProjectIDForSearch As String
        Dim strProjectIDFromTable As String
        Dim strMSRNumberFromTable As String
        Dim strMSRNumberForSearch As String
        Dim intSelectedIndex As Integer
        Dim blnProjectMatches As Boolean = False
        Dim blnMSRNumberMatches As Boolean = False

        Try

            'setting up the data variables
            TheInternalProjectDataTier = New InternalProjectsDataTier
            TheInternalProjectDataSet = TheInternalProjectDataTier.GetInternalProjectsInformation
            TheInternalProjectBindingSource = New BindingSource

            'setting up the binding source
            With TheInternalProjectBindingSource
                .DataSource = TheInternalProjectDataSet
                .DataMember = "internalprojects"
                .MoveFirst()
                .MoveLast()
            End With

            'with the combo box
            With cboTransactionID
                .DataSource = TheInternalProjectBindingSource
                .DisplayMember = "internalProjectID"
                .DataBindings.Add("text", TheInternalProjectBindingSource, "internalProjectID", False, DataSourceUpdateMode.Never)
            End With

            'setting up the rest of the controls
            txtMSRNumber.DataBindings.Add("text", TheInternalProjectBindingSource, "MSRNumber")
            txtProjectID.DataBindings.Add("text", TheInternalProjectBindingSource, "TWCControlNumber")

            'getting ready for the loop
            intNumberOfRecords = cboTransactionID.Items.Count - 1
            strProjectIDForSearch = Logon.mstrTWCProjectID
            strMSRNumberForSearch = Logon.mstrMSR

            'Beginning loop
            For intCounter = 0 To intNumberOfRecords

                'incrementing the combo box
                cboTransactionID.SelectedIndex = intCounter

                'getting the project ID and msr number
                If Logon.mblnUpdateProjectID = True Then
                    strMSRNumberFromTable = txtMSRNumber.Text
                    If strMSRNumberFromTable = strMSRNumberForSearch Then
                        intSelectedIndex = intCounter
                        blnMSRNumberMatches = True
                        blnProjectMatches = False
                    End If
                ElseIf Logon.mblnUpdateMSRNumber = True Then
                    strProjectIDFromTable = txtProjectID.Text
                    If strProjectIDForSearch = strProjectIDFromTable Then
                        intSelectedIndex = intCounter
                        blnProjectMatches = True
                        blnMSRNumberMatches = False
                    End If
                End If
            Next

            'setting the selected index
            cboTransactionID.SelectedIndex = intSelectedIndex

            If blnProjectMatches = True Then
                txtMSRNumber.Text = strMSRNumberForSearch
            ElseIf blnMSRNumberMatches = True Then
                txtProjectID.Text = strProjectIDForSearch
            End If

            TheInternalProjectBindingSource.EndEdit()
            TheInternalProjectDataTier.UpdateInternalProjectsDB(TheInternalProjectDataSet)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Me.Close()

    End Sub
End Class