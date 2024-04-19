'Title:         Find Warehouse ID
'Date:          5-5-15
'Author:        Terry Holmes

'Description:   This will find the warehouse id

Option Strict On

Public Class FindWarehouseID

    'Setting global variables
    Private TheEmployeesDataSet As employeesDataSet
    Private TheEmployeesDataTier As TWInventoryDataTier
    Private WithEvents TheEmployeesBindingSource As BindingSource

    Private Sub FindWarehouseID_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'This sub-routine will find the TWC parts warehouse
        'Setting local variables
        Dim intCounter As Integer
        Dim intNumberOfRecords As Integer
        Dim strPartsWarehouseForSearch As String
        Dim strPartsWarehouseFromTable As String
        Dim intWarehouseID As Integer
        Dim strLastNameForSearch As String
        Dim strLastNameFromTable As String

        'Try Catch for Exceptions
        Try

            'Loading up global variables
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
            txtFirstName.DataBindings.Add("text", TheEmployeesBindingSource, "FirstName")
            txtLastName.DataBindings.Add("text", TheEmployeesBindingSource, "LastName")

            'Getting ready for the loop
            intNumberOfRecords = cboEmployeeID.Items.Count - 1
            strPartsWarehouseForSearch = Logon.mstrHomeOffice + "-TWC"
            strLastNameForSearch = "PARTS"

            'Beginning loop
            For intCounter = 0 To intNumberOfRecords

                'incrementing the combo box
                cboEmployeeID.SelectedIndex = intCounter

                'loading string variables
                strLastNameFromTable = txtLastName.Text
                strPartsWarehouseFromTable = txtFirstName.Text

                'If statements
                If strLastNameForSearch = strLastNameFromTable Then
                    If strPartsWarehouseForSearch = strPartsWarehouseFromTable Then

                        'getting the warehouse id
                        intWarehouseID = CInt(cboEmployeeID.Text)

                    End If
                End If
            Next

            'setting the global variable
            Logon.mintWarehouseID = intWarehouseID

            Me.Close()

        Catch ex As Exception

            'Message To User
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub
End Class