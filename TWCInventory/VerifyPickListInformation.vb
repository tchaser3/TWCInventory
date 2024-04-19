'Title:         Verify Pick List Information
'Date:          3-20-15
'Author:        Terry Holmes

'Description:   This will check to see if there is a pick list for a project

Option Strict On

Public Class VerifyPickListInformation

    Dim TheInputDataValidation As New InputDataValidation
    Dim TheKeywordSearch As New KeyWordSearchClass
    Dim TheCheckTimeWarnerPartNumber As New CheckTimeWarnerPartNumber

    Private ThePickListDataSet As PickListDataSet
    Private ThePickListDataTier As PickListDataTier
    Private WithEvents ThePickListBindingSource As BindingSource

    Private addingBoolean As Boolean = False
    Private editingBoolean As Boolean = False

    Private Sub VerifyPickListInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Setting local variables
        Dim intCounter As Integer
        Dim intNumberOfRecords As Integer
        Dim intSelectedIndex As Integer
        Dim blnItemFound As Boolean = False
        Dim strProjectInfoForSearch As String
        Dim strProjectIDFromTable As String
        Dim strMSRNumberFromTable As String

        Try

            ThePickListDataTier = New PickListDataTier
            ThePickListDataSet = ThePickListDataTier.GetPickListInformation
            ThePickListBindingSource = New BindingSource

            'Setting up the binding source
            With ThePickListBindingSource
                .DataSource = ThePickListDataSet
                .DataMember = "picklist"
                .MoveFirst()
                .MoveLast()
            End With

            'Setting up the combo box
            With cboPickListID
                .DataSource = ThePickListBindingSource
                .DisplayMember = "PickListID"
                .DataBindings.Add("text", ThePickListBindingSource, "PickListID", False, DataSourceUpdateMode.Never)
            End With

            'Setting up the rest of the controls
            txtDate.DataBindings.Add("text", ThePickListBindingSource, "Date")
            txtOrderIssued.DataBindings.Add("text", ThePickListBindingSource, "OrderIssued")
            txtProjectID.DataBindings.Add("text", ThePickListBindingSource, "ProjectID")
            txtMSRNumber.DataBindings.Add("text", ThePickListBindingSource, "MSRNumber")

            'preparing for loop
            intNumberOfRecords = cboPickListID.Items.Count - 1
            strProjectInfoForSearch = Logon.mstrTWCProjectID

            'Beginning loop
            For intCounter = 0 To intNumberOfRecords

                'incrementing the combo box
                cboPickListID.SelectedIndex = intCounter

                'getting the info
                strProjectIDFromTable = txtProjectID.Text
                strMSRNumberFromTable = txtMSRNumber.Text

                'if statements
                If strProjectInfoForSearch = strProjectIDFromTable Then
                    blnItemFound = True
                    intSelectedIndex = intCounter
                ElseIf strProjectInfoForSearch = strMSRNumberFromTable Then
                    blnItemFound = False
                    intSelectedIndex = intCounter
                End If
            Next

            'closing the form
            Me.Close()

        Catch ex As Exception

            'Message to user
            Logon.mbolFatalError = True
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub
End Class