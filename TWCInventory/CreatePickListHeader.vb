'Title:         Create Pick List Header
'Date:          3-19-15
'Author:        Terry Holmes

'Description:   This form is used to create the project header

Public Class CreatePickListHeader

    Dim TheInputDataValidation As New InputDataValidation
    Dim TheKeywordSearch As New KeyWordSearchClass
    Dim TheCheckTimeWarnerPartNumber As New CheckTimeWarnerPartNumber

    Private ThePickListDataSet As PickListDataSet
    Private ThePickListDataTier As PickListDataTier
    Private WithEvents ThePickListBindingSource As BindingSource

    Private addingBoolean As Boolean = False
    Private editingBoolean As Boolean = False

    Private Sub SetComboBoxBinding()

        With cboPickListID
            If (addingBoolean Or editingBoolean) Then
                .DataBindings!text.DataSourceUpdateMode = DataSourceUpdateMode.OnValidation
                .DropDownStyle = ComboBoxStyle.Simple
            Else
                .DataBindings!text.DataSourceUpdateMode = DataSourceUpdateMode.Never
                .DropDownStyle = ComboBoxStyle.DropDownList
            End If
        End With
    End Sub

    Private Sub CreatePickListHeader_Load(sender As Object, e As EventArgs) Handles Me.Load

        'This is used to create a Pick List header
        'Try Catch for exceptions

        'Setting local variables
        Dim datTransactionDate As Date = Date.Now
        Dim strTransactionDate As String
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

            'Beginning the save process
            With ThePickListBindingSource
                .EndEdit()
                .AddNew()
            End With

            addingBoolean = True
            SetComboBoxBinding()

            'calling the id file
            CreatePickListID.Show()
            cboPickListID.Text = CStr(Logon.mintCreatedTransactionID)
            Logon.mintPickListID = Logon.mintCreatedTransactionID
            txtProjectID.Text = CStr(Logon.mstrTWCProjectID)
            txtOrderIssued.Text = "NO"
            strTransactionDate = CStr(datTransactionDate)
            txtDate.Text = strTransactionDate
            txtMSRNumber.Text = Logon.mstrMSR

            'Saving the information
            ThePickListBindingSource.EndEdit()
            ThePickListDataTier.UpdatePickListDB(ThePickListDataSet)
            addingBoolean = False
            editingBoolean = False
            SetComboBoxBinding()

            Logon.mbolFatalError = False

            'closing the form
            Me.Close()

        Catch ex As Exception

            'Message to user
            Logon.mbolFatalError = True
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub
End Class