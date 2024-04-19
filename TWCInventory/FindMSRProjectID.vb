'Title:         Find MSR Number Project ID
'Date:          11-6-15
'Author:        Terry Holmes

'Description:   This form will take either a MSR Number or Project ID and deliver both the 
'               Project ID and MSR Number back to the calling form

Option Strict On

Public Class FindMSRProjectID

    'Setting global variables
    Private TheInternalProjectsDataSet As InternalProjectsDataSet
    Private TheInternalProjectsDataTier As InternalProjectsDataTier
    Private WithEvents TheInternalProjectsBindingSource As BindingSource

    Dim TheKeyWordSearchClass As New KeyWordSearchClass

    Private Sub FindMSRProjectID_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'setting local variables
        Dim intCounter As Integer
        Dim intNumberOfRecords As Integer
        Dim blnItemNotFound As Boolean = True
        Dim strProjectIDForSearch As String
        Dim strProjectIDFromTable As String
        Dim strMSRNumberForSearch As String
        Dim strMSRNumberFromTable As String

        'try catch for exceptions
        Try

            'setting global variables
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
            With cboInternalProjectID
                .DataSource = TheInternalProjectsBindingSource
                .DisplayMember = "internalProjectID"
                .DataBindings.Add("Text", TheInternalProjectsBindingSource, "internalProjectID", False, DataSourceUpdateMode.Never)
            End With

            'setting up the rest of the controls
            txtMSRNumber.DataBindings.Add("text", TheInternalProjectsBindingSource, "MSRNumber")
            txtTWCProjectID.DataBindings.Add("Text", TheInternalProjectsBindingSource, "TWCControlNumber")

            'getting ready for the loop
            intNumberOfRecords = cboInternalProjectID.Items.Count - 1
            strMSRNumberForSearch = Logon.mstrMSR
            strProjectIDForSearch = Logon.mstrTWCProjectID

            'Running Loop
            For intCounter = 0 To intNumberOfRecords

                'Incrementing the combo box
                cboInternalProjectID.SelectedIndex = intCounter

                'setting the variables
                strProjectIDFromTable = txtTWCProjectID.Text
                strMSRNumberFromTable = txtMSRNumber.Text

                If strProjectIDForSearch <> "WHS" Then
                    If strProjectIDForSearch = strProjectIDFromTable Then
                        Logon.mstrMSR = txtMSRNumber.Text
                        Exit For
                    ElseIf strMSRNumberFromTable <> "" Then
                        If strMSRNumberForSearch = strMSRNumberFromTable Then
                            Logon.mstrTWCProjectID = txtTWCProjectID.Text
                            Exit For
                        End If
                    End If
                ElseIf strProjectIDForSearch = "WHS" Then
                    If strMSRNumberFromTable <> "" Then
                        If strMSRNumberForSearch = strMSRNumberFromTable Then
                            Logon.mstrTWCProjectID = txtTWCProjectID.Text
                            Exit For
                        End If
                    End If
                End If
            Next

            Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class