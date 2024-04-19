'Title:         Find Home Office
'Date:          1-9-15
'Author:        Terry Holmes

'Description:   This for is used to find the home office

Option Strict On

Public Class FindHomeOfficeID

    'Calling Modular Variables
    Private TheEmployeesDataSet As employeesDataSet
    Private TheEmployeesDataTier As TWInventoryDataTier
    Private WithEvents TheEmployeesBindingSource As BindingSource

    Private Sub FindHomeOfficeID_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'This will load up the form.
        Dim strHomeOffice As String
        Dim intWarehouseID As Integer = 0
        Dim intCounter As Integer
        Dim intNumberOfRecords As Integer
        Dim strLastName As String
        Dim strFirstName As String

        Try

            TheEmployeesDataTier = New TWInventoryDataTier
            TheEmployeesDataSet = TheEmployeesDataTier.GetEmployeesInformation
            TheEmployeesBindingSource = New BindingSource

            With TheEmployeesBindingSource
                .DataSource = TheEmployeesDataSet
                .DataMember = "employees"
                .MoveFirst()
                .MoveLast()
            End With

            With cboEmployeeID
                .DataSource = TheEmployeesBindingSource
                .DisplayMember = "EmployeeID"
                .DataBindings.Add("text", TheEmployeesBindingSource, "EmployeeID", False, DataSourceUpdateMode.Never)
            End With

            txtFirstName.DataBindings.Add("text", TheEmployeesBindingSource, "FirstName")
            txtLastName.DataBindings.Add("text", TheEmployeesBindingSource, "LastName")
            txtGroup.DataBindings.Add("text", TheEmployeesBindingSource, "Group")

            strHomeOffice = Logon.mstrHomeOffice

            intNumberOfRecords = cboEmployeeID.Items.Count - 1

            For intCounter = 0 To intNumberOfRecords

                cboEmployeeID.SelectedIndex = intCounter
                strLastName = txtLastName.Text
                strFirstName = txtFirstName.Text
                If strLastName = "WAREHOUSE" And strFirstName = strHomeOffice Then
                    intWarehouseID = CInt(cboEmployeeID.Text)
                End If

            Next

            Logon.mintWarehouseID = intWarehouseID
            Logon.mintHomeOfficeID = intWarehouseID

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Me.Close()

    End Sub


End Class