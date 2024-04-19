'Title:         Select Parts Warehouse
'Date:          6-25-15
'Author:        Terry Holmes

'Description:   This form is used to select the warehouse

Option Strict On

Public Class SelectPartsWarehouse

    Private TheEmployeesDataSet As employeesDataSet
    Private TheEmployeesDataTier As TWInventoryDataTier
    Private WithEvents TheEmployeesBindingSource As BindingSource

    'Setting up for array
    Dim mintSelectedIndex() As Integer
    Dim mintCounter As Integer
    Dim mintUpperLimit As Integer

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        CloseProgram.ShowDialog()

    End Sub

    Private Sub SelectPartsWarehouse_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Setting local variables
        Dim intNumberOfRecords As Integer
        Dim intCounter As Integer
        Dim strLastNameForSearch As String
        Dim strLastNameFromTable As String

        btnNext.Enabled = False
        btnBack.Enabled = False

        'Try catch to catch exceptions
        Try

            TheEmployeesDataTier = New TWInventoryDataTier
            TheEmployeesDataSet = TheEmployeesDataTier.GetEmployeesInformation
            TheEmployeesBindingSource = New BindingSource

            'Setting up the binding source
            With TheEmployeesBindingSource
                .DataSource = TheEmployeesDataSet
                .DataMember = "employees"
                .MoveFirst()
                .MoveLast()
            End With

            'Setting up the combo box
            With cboEmployeeID
                .DataSource = TheEmployeesBindingSource
                .DisplayMember = "EmployeeID"
                .DataBindings.Add("text", TheEmployeesBindingSource, "EmployeeID", False, DataSourceUpdateMode.Never)
            End With

            'Setting up the rest of the controls
            txtFirstName.DataBindings.Add("Text", TheEmployeesBindingSource, "FirstName")
            txtLastName.DataBindings.Add("text", TheEmployeesBindingSource, "LastName")

            'getting ready for the loop
            intNumberOfRecords = cboEmployeeID.Items.Count - 1
            ReDim mintSelectedIndex(intNumberOfRecords)
            mintCounter = 0
            strLastNameForSearch = "PARTS"

            'Running loop
            For intCounter = 0 To intNumberOfRecords

                'Incrementing the combo box
                cboEmployeeID.SelectedIndex = intCounter

                'getting the last name
                strLastNameFromTable = txtLastName.Text

                If strLastNameForSearch = strLastNameFromTable Then
                    mintSelectedIndex(mintCounter) = intCounter
                    mintCounter += 1
                End If
            Next

            'Finishing loop
            mintUpperLimit = mintCounter - 1
            mintCounter = 0
            If mintUpperLimit > 0 Then
                btnNext.Enabled = True
            End If
            cboEmployeeID.SelectedIndex = mintSelectedIndex(0)

        Catch ex As Exception

            'Setting up if there is a failure
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If Logon.mstrSelectionOrigination = "LOGON" Then
                MessageBox.Show("The Application Will Now Close", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Logon.Close()
            ElseIf Logon.mstrSelectionOrigination = "ADMIN" Then
                MessageBox.Show("The Admin Menu Will Be Now Displayed", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error)
                AdminMenu.Show()
                Me.Close()
            End If

        End Try
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        'this will increment the counter
        mintCounter += 1
        cboEmployeeID.SelectedIndex = mintSelectedIndex(mintCounter)

        'Setting navigation buttons
        btnBack.Enabled = True

        If mintCounter = mintUpperLimit Then
            btnNext.Enabled = False
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click


        'this will increment the counter
        mintCounter -= 1
        cboEmployeeID.SelectedIndex = mintSelectedIndex(mintCounter)

        'Setting navigation buttons
        btnNext.Enabled = True

        If mintCounter = 0 Then
            btnBack.Enabled = False
        End If

    End Sub

    Private Sub btnLogon_Click(sender As Object, e As EventArgs) Handles btnLogon.Click

        'This will set the variable
        Logon.mintPartsWarehouseID = CInt(cboEmployeeID.Text)

        If Logon.mstrSelectionOrigination = "LOGON" Then
            Form1.Show()
        ElseIf Logon.mstrSelectionOrigination = "ADMIN" Then
            AdminMenu.Show()
        Else
            MessageBox.Show("You Have a Fucking Problem", "You asshole", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

        Me.Close()

    End Sub
End Class