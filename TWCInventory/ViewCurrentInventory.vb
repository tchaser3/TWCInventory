'Title:         View Current Inventory
'Date:          11-27-14
'Author:        Terry Holmes

'Description:   This will display the Current Inventory

Option Strict On

Public Class ViewCurrentInventory

    Private TheWarehouseInventoryDataTier As TWInventoryDataTier
    Private TheWarehouseInventoryDataSet As WarehouseInventoryDataSet
    Private WithEvents TheWarehouseInventoryBindingSource As BindingSource

    Private addingBoolean As Boolean = False
    Private editingBoolean As Boolean = False
    Private previouseSelectedIndex As Integer

    Dim TheInputDataValidation As New InputDataValidation

    'Array for Keyword Search
    Dim mintCounter As Integer
    Dim mintSelectedIndex(9999) As Integer
    Dim mintUpperLimit As Integer

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        'This calls the Close Program Dialog Box
        CloseProgram.ShowDialog()

    End Sub

    Private Sub btnMainMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMainMenu.Click

        ClearDataBindings()
        Logon.mstrLastTransactionSummary = "RETURNING TO MAIN MENU FROM VIEW CURRENT INVENTORY"
        LastTransaction.Show()
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub ViewCurrentInventory_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Try Catch to Load Form
        Try

            'Setting up the data variables
            TheWarehouseInventoryDataTier = New TWInventoryDataTier
            TheWarehouseInventoryDataSet = TheWarehouseInventoryDataTier.GetWarehouseInventoryInformation
            TheWarehouseInventoryBindingSource = New BindingSource

            'Setting up the binding source
            With TheWarehouseInventoryBindingSource
                .DataSource = TheWarehouseInventoryDataSet
                .DataMember = "WarehouseInventory"
                .MoveFirst()
                .MoveLast()
            End With

            'Setting up the combo box
            With cboPartNumber
                .DataSource = TheWarehouseInventoryBindingSource
                .DisplayMember = "PartNumber"
                .DataBindings.Add("text", TheWarehouseInventoryBindingSource, "PartNumber", False, DataSourceUpdateMode.Never)
            End With

            'Setting up the rest of the controls
            txtPartID.DataBindings.Add("text", TheWarehouseInventoryBindingSource, "PartID")
            txtPartDescription.DataBindings.Add("text", TheWarehouseInventoryBindingSource, "PartDescription")
            txtQTYResponible.DataBindings.Add("text", TheWarehouseInventoryBindingSource, "QTYOnHand")

            'Setting the combo box up
            cboPartNumber.SelectedIndex = 0

            Logon.mstrLastTransactionSummary = "LOADING THE VIEW CURRENT INVENTORY FORM"

            ResetFormNavigation()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub ClearDataBindings()

        'This will clear the data bindings
        cboPartNumber.DataBindings.Clear()
        txtPartDescription.DataBindings.Clear()
        txtPartID.DataBindings.Clear()
        txtQTYResponible.DataBindings.Clear()

    End Sub

    Private Sub btnFindPartNumber_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFindPartNumber.Click

        'Setting up local variables
        Dim intCounter As Integer
        Dim intNumberOfRecords As Integer
        Dim intSelectedIndex As Integer
        Dim strPartNumberForSearch As String
        Dim strPartNumberFromTable As String
        Dim blnFatalError As Boolean = False
        Dim blnItemNotFound As Boolean = True

        'Performing Data Validation
        strPartNumberForSearch = txtEnterPartNumber.Text
        blnFatalError = TheInputDataValidation.VerifyTextData(strPartNumberForSearch)

        'Outputting to user if there is a failure of validation
        If blnFatalError = True Then
            txtEnterPartNumber.Text = ""
            MessageBox.Show("The Part Number waa not Entered", "Enter Part Number Was Blank", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'Setting up for the loop
        intNumberOfRecords = cboPartNumber.Items.Count - 1

        'Performing the loop
        For intCounter = 0 To intNumberOfRecords

            'Incrementing the combo box
            cboPartNumber.SelectedIndex = intCounter

            'Getting the part number from the table
            strPartNumberFromTable = cboPartNumber.Text

            'Performing if statements to verify that the part number is found
            If strPartNumberForSearch = strPartNumberFromTable Then
                intSelectedIndex = intCounter
                blnItemNotFound = False
            End If
        Next

        'If statement for determining if the items was found
        If blnItemNotFound = True Then
            txtEnterPartNumber.Text = ""
            MessageBox.Show("Item Was Not Found", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'Setting the combo box
        cboPartNumber.SelectedIndex = intSelectedIndex
        txtEnterPartNumber.Text = ""

    End Sub

    Private Sub btnOnHandReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOnHandReport.Click

        'This will display the On Hand Report
        ClearDataBindings()
        OnHandReport.Show()
        Me.Close()

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        'This will display the add form
        AddPartsToInventory.Show()
        Me.Close()

    End Sub
    
    Private Sub btnKeyWordSearch_Click(sender As Object, e As EventArgs) Handles btnKeyWordSearch.Click

        'This sub routine will do a key word search
        Dim intKeyWordLengthFromTable As Integer = 0
        Dim intNumberOfRecords As Integer = 0
        Dim strKeyWordForSearch As String = ""
        Dim strKeyWordFromTable As String = ""
        Dim chaKeyWordInputArray() As Char
        Dim blnFatalError As Boolean = False
        Dim blnItemNotFound As Boolean = True
        Dim intPartDescriptionCounter As Integer = 0
        Dim intPartNumberCounter As Integer
        Dim intKeyWordCounter As Integer = 0
        Dim intCharacterCounter As Integer = 0
        Dim strTempString As String = ""
        Dim intKeyWordLengthForSearch As Integer = 0

        'Setting up for data validation
        strKeyWordForSearch = txtKeyWordSearch.Text
        strTempString = strKeyWordForSearch
        blnFatalError = TheInputDataValidation.VerifyTextData(strKeyWordForSearch)

        btnNext.Enabled = False
        btnBack.Enabled = False

        If blnFatalError = True Then
            MessageBox.Show("The Key Word was not Entered", "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ResetFormNavigation()
            Exit Sub
        End If

        'Clears the array
        ClearArray()

        'Setting up for loop
        intNumberOfRecords = cboPartNumber.Items.Count - 1
        intKeyWordLengthForSearch = txtKeyWordSearch.Text.Length - 1
        mintCounter = 0
        mintUpperLimit = 0

        'Setting up for the loop
        For intPartNumberCounter = 0 To intNumberOfRecords

            'Incrementing the combo box
            cboPartNumber.SelectedIndex = intPartNumberCounter

            'Loading the count for the text
            intKeyWordLengthFromTable = txtPartDescription.Text.Length - 1
            chaKeyWordInputArray = txtPartDescription.Text.ToCharArray
            intCharacterCounter = intKeyWordLengthForSearch

            'If statement to determine if there is need to parse out the name
            If intKeyWordLengthForSearch <= intKeyWordLengthFromTable Then

                For intPartDescriptionCounter = 0 To intKeyWordLengthFromTable

                    For intkewordcounter = intPartDescriptionCounter To intCharacterCounter

                        'loading up the string variable
                        strKeyWordFromTable = strKeyWordFromTable + CStr(chaKeyWordInputArray(intkewordcounter))

                    Next

                    If intCharacterCounter < intKeyWordLengthFromTable Then
                        intCharacterCounter += 1
                    End If

                    If strKeyWordForSearch = strKeyWordFromTable Then
                        mintSelectedIndex(mintCounter) = intPartNumberCounter
                        mintCounter += 1
                        blnItemNotFound = False
                    End If

                    strKeyWordFromTable = ""

                Next

                intCharacterCounter = intKeyWordLengthForSearch

            End If

        Next

        If blnItemNotFound = True Then
            txtKeyWordSearch.Text = ""
            MessageBox.Show("The Keyword Entered Was Not Found", "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ResetFormNavigation()
            Exit Sub
        End If

        'Setting navigation buttons
        mintUpperLimit = mintCounter - 1
        mintCounter = 0
        cboPartNumber.SelectedIndex = mintSelectedIndex(0)

        'Setting navigation up
        cboPartNumber.Visible = False
        txtKeyWordSearch.Text = ""

        If mintUpperLimit > 0 Then
            btnNext.Enabled = True
        End If

    End Sub
    Private Sub ClearArray()

        'Setting local records
        Dim intCounter As Integer

        'Loop to clear the array
        For intCounter = 0 To mintUpperLimit

            'Changing the value of the array
            mintSelectedIndex(intCounter) = -1

        Next


    End Sub
    Private Sub ResetFormNavigation()

        'Setting local variables
        Dim intNumberOfRecords As Integer
        Dim intCounter As Integer

        cboPartNumber.Visible = True

        'Setting up to load array and navigation buttons
        btnNext.Enabled = False
        btnBack.Enabled = False

        'Setting up limiting count
        intNumberOfRecords = cboPartNumber.Items.Count - 1
        mintUpperLimit = intNumberOfRecords

        'Loading up array
        For intCounter = 0 To intNumberOfRecords

            mintSelectedIndex(intCounter) = intCounter

        Next

        'Setting up navigation buttons to work
        If mintUpperLimit > 0 Then
            btnNext.Enabled = True
        End If

        'Setting global counter
        mintCounter = 0

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        'Incrementing the counter
        mintCounter += 1

        'setting the combo box
        cboPartNumber.SelectedIndex = mintSelectedIndex(mintCounter)

        'Setting the navigation control
        btnBack.Enabled = True

        'Checking to see if the navigation button should be disabled
        If mintCounter = mintUpperLimit Then
            btnNext.Enabled = False
        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        'Incrementing the counter
        mintCounter -= 1

        'setting the combo box
        cboPartNumber.SelectedIndex = mintSelectedIndex(mintCounter)

        'Setting the navigation control
        btnNext.Enabled = True

        'Checking to see if the navigation button should be disabled
        If mintCounter = 0 Then
            btnBack.Enabled = False
        End If

    End Sub

    Private Sub btnResetForm_Click(sender As Object, e As EventArgs) Handles btnResetForm.Click

        'This will reset the form
        ResetFormNavigation()

    End Sub
End Class