'Title:         Validate Part Number
'Date:          12-1-14
'Author:        Terry Holmes

'Description:   This form will validate that a part number entered does not exist

Option Strict On

Public Class ValidatePartNumber

    Private ThePartNumberDataSet As PartNumberDataSet
    Private ThePartNumberDataTier As PartsDataTier
    Private WithEvents ThePartNumberBindingSource As BindingSource

    Private addingBoolean As Boolean = False
    Private editingBoolean As Boolean = False
    Private previouseSelectedIndex As Integer

    Dim TheInputDataValidation As New InputDataValidation
    Dim mstrPartNumber() As String
    Dim mintPartCounter As Integer
    Dim mintPartUpperLimit As Integer

    Private Sub SetComboBoxBinding()

        'This will set the combo box bindings
        With cboPartID
            If (addingBoolean Or editingBoolean) Then
                .DataBindings!text.DataSourceUpdateMode = DataSourceUpdateMode.OnValidation
                .DropDownStyle = ComboBoxStyle.Simple
            Else
                .DataBindings!text.DataSourceUpdateMode = DataSourceUpdateMode.Never
                .DropDownStyle = ComboBoxStyle.DropDownList
            End If
        End With

    End Sub

    Private Sub ValidatePartNumber_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'This will run to load up the form

        'Setting local variables
        Dim intCounter As Integer
        Dim intNumberOfRecords As Integer

        'Try Catch to Load Form
        Try

            'Setting up the data variables
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
            With cboPartID
                .DataSource = ThePartNumberBindingSource
                .DisplayMember = "PartID"
                .DataBindings.Add("text", ThePartNumberBindingSource, "PartID", False, DataSourceUpdateMode.Never)
            End With

            'Setting up the rest of the controls
            txtPartNumber.DataBindings.Add("text", ThePartNumberBindingSource, "PartNumber")
            txtPartDescription.DataBindings.Add("text", ThePartNumberBindingSource, "Description")
            txtTWCPart.DataBindings.Add("text", ThePartNumberBindingSource, "TimeWarnerPart")
            txtActive.DataBindings.Add("text", ThePartNumberBindingSource, "Active")

            intNumberOfRecords = cboPartID.Items.Count - 1
            mintPartUpperLimit = intNumberOfRecords
            ReDim mstrPartNumber(intNumberOfRecords)

            'Loading up the array
            For intCounter = 0 To intNumberOfRecords

                'incrementing the combo box
                cboPartID.SelectedIndex = intCounter

                'loading the array
                mstrPartNumber(intCounter) = txtPartNumber.Text

            Next

            CreateNewRecord()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub ClearDataBindings()

        'Clearing the databindings
        cboPartID.DataBindings.Clear()
        txtPartDescription.DataBindings.Clear()
        txtPartNumber.DataBindings.Clear()

    End Sub
    Private Sub CreateNewRecord()

        'This will add the new record
        With ThePartNumberBindingSource
            .EndEdit()
            .AddNew()
        End With

        'Setting up for adding a new record
        addingBoolean = True
        SetComboBoxBinding()
        PartNumbersID.Show()

        'Setting the control
        cboPartID.Text = CStr(Logon.mintCreatedTransactionID)
        txtPartNumber.Text = Logon.mstrPartNumber
        txtTWCPart.Text = "YES"
        txtActive.Text = "YES"

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        'This will save the part
        'setting local variables
        Dim strValueForValidation As String
        Dim intCounter As Integer
        Dim blnFatalError As Boolean = False
        Dim blnThereIsAProblem As Boolean = False
        Dim strErrorMessage As String = ""
        Dim blnPartNumberExists As Boolean = False
        Dim strPartNumberForSearch As String
        Dim strPartNumberFromTable As String

        'Beginning Data Validation
        strValueForValidation = txtPartNumber.Text
        blnFatalError = TheInputDataValidation.VerifyTextData(strValueForValidation)
        If blnFatalError = True Then
            blnThereIsAProblem = True
            strErrorMessage = strErrorMessage + "The Part Number was not Entered" + vbNewLine
        End If

        strValueForValidation = txtPartDescription.Text
        blnFatalError = TheInputDataValidation.VerifyTextData(strValueForValidation)
        If blnFatalError = True Then
            blnThereIsAProblem = True
            strErrorMessage = strErrorMessage + "The Part Description was not entered" + vbNewLine
        End If

        If blnThereIsAProblem = True Then
            MessageBox.Show(strErrorMessage, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'Checking to see if the part number is present
        strPartNumberForSearch = txtPartNumber.Text

        For intCounter = 0 To mintPartUpperLimit

            strPartNumberFromTable = mstrPartNumber(intCounter)

            If strPartNumberForSearch = strPartNumberFromTable Then
                blnPartNumberExists = True
                Exit For
            End If
        Next

        If blnPartNumberExists = True Then
            Logon.mblnDoNotUpdate = True
            MessageBox.Show("Part Number Entered Exists, Please Change the Part Number within Data Entry Form", "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            EnterInventoryInformation.FinishTransaction()
            Me.Close()
        Else
            'Saving record
            Try
                Logon.mblnNewPartNumber = True
                ThePartNumberBindingSource.EndEdit()
                ThePartNumberDataTier.UpdatePartNumberDB(ThePartNumberDataSet)
                addingBoolean = False
                editingBoolean = False
                SetComboBoxBinding()
                ClearDataBindings()
                EnterInventoryInformation.FinishTransaction()
                Logon.mblnDoNotUpdate = False
                Me.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If


       

    End Sub

    Private Sub txtPartDescription_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPartDescription.KeyDown

        If e.KeyCode = Keys.Enter Then
            btnSave.PerformClick()
        End If
    End Sub
End Class