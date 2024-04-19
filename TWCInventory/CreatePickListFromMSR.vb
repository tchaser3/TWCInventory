'Title:         Create Pick List From MSR
'Date:          2-23-15
'Author:        Terry Holmes

'Description:   This form is used to create a pick list from a MSR received

Option Strict On

Public Class CreatePickListFromMSR

    Dim TheInputDataValidation As New InputDataValidation
    Dim TheKeywordSearch As New KeyWordSearchClass
    Dim TheCheckTimeWarnerPartNumber As New CheckTimeWarnerPartNumber

    'Setting the global variables
    Private TheReceivedPartsDataSet As ReceivedPartsDataSet
    Private TheReceivedPartsDataTier As TWInventoryDataTier
    Private WithEvents TheReceivedPartsBindingSource As BindingSource

    Private ThePickListDataSet As PickListDataSet
    Private ThePickListDataTier As PickListDataTier
    Private WithEvents ThePickListBindingSource As BindingSource

    Private ThePickListTransactionsDataSet As PickListTransactionsDataSet
    Private ThePickListTransactionsDataTier As PickListDataTier
    Private WithEvents ThePickListTransactionsBindingSource As BindingSource

    'Setting up selected index array
    Dim mintSelectedIndex() As Integer
    Dim mintCounter As Integer
    Dim mintUpperLimit As Integer

    Private addingBoolean As Boolean = False
    Private editingBoolean As Boolean = False

    Private Sub btnCreatePickListMenu_Click(sender As Object, e As EventArgs) Handles btnCreatePickListMenu.Click

        'This will display the Create Pick List Menu
        LastTransaction.Show()
        CreatePickListMenu.Show()
        Me.Close()

    End Sub

    Private Sub btnIssueInventoryMenu_Click(sender As Object, e As EventArgs) Handles btnIssueInventoryMenu.Click

        'this will display the issue inventory menu
        LastTransaction.Show()
        IssueInventory.Show()
        Me.Close()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        'This will close the program
        CloseProgram.ShowDialog()

    End Sub

    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click

        'This will display the main menu
        LastTransaction.Show()
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub SetReceivedPartsDataBindings()

        'This will load up the form
        Try

            'Setting the global data variables
            TheReceivedPartsDataTier = New TWInventoryDataTier
            TheReceivedPartsDataSet = TheReceivedPartsDataTier.GetReceivedPartsInformation
            TheReceivedPartsBindingSource = New BindingSource

            'Setting up the binding source
            With TheReceivedPartsBindingSource
                .DataSource = TheReceivedPartsDataSet
                .DataMember = "ReceivedParts"
                .MoveFirst()
                .MoveLast()
            End With

            'Setting up the combo box
            With cboReceiveTransactionID
                .DataSource = TheReceivedPartsBindingSource
                .DisplayMember = "TransactionID"
                .DataBindings.Add("text", TheReceivedPartsBindingSource, "TransactionID", False, DataSourceUpdateMode.Never)
            End With

            'Setting up the rest of the controls
            txtReceiveMSRNumber.DataBindings.Add("text", TheReceivedPartsBindingSource, "MSRNumber")
            txtReceiveQuantity.DataBindings.Add("text", TheReceivedPartsBindingSource, "QTY")
            txtReceiveTWCProjectID.DataBindings.Add("text", TheReceivedPartsBindingSource, "ProjectID")
            txtReceivePartNumber.DataBindings.Add("text", TheReceivedPartsBindingSource, "PartNumber")

        Catch ex As Exception

            'Message to user
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub CreatePickListFromMSR_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'This will load when the form is loaded
        SetReceivedPartsDataBindings()
        SetControlsVisible(False)
        PartsReceivedGridView.Visible = False
        
    End Sub
    Private Sub SetControlsVisible(ByVal valueBoolean As Boolean)

        'this will make the controls visible
        cboReceiveTransactionID.Visible = valueBoolean
        txtReceiveMSRNumber.Visible = valueBoolean
        txtReceivePartNumber.Visible = valueBoolean
        txtReceiveQuantity.Visible = valueBoolean
        txtReceiveTWCProjectID.Visible = valueBoolean

    End Sub

    Private Sub btnFindMSRNumber_Click(sender As Object, e As EventArgs) Handles btnFindMSRNumber.Click

        'This will find all references to the MSR Number Entered
        'Setting local variables
        Dim intCounter As Integer
        Dim intNumberOfRecords As Integer
        Dim strMSRNumberForSearch As String
        Dim strMSRNumberFromTable As String
        Dim row() As String
        Dim blnFatalError As Boolean = False
        Dim blnItemNotFound As Boolean = True

        'Performing Data Validation
        strMSRNumberForSearch = txtEnterMSRNumber.Text
        blnFatalError = TheInputDataValidation.VerifyTextData(strMSRNumberForSearch)

        'output to user if there is failure
        If blnFatalError = True Then
            MessageBox.Show("MSR Number was not Entered", "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Logon.mstrTWCProjectID = strMSRNumberForSearch
        VerifyPickListInformation.Show()

        If blnFatalError = True Then
            PickListExists.ShowDialog()
        End If

        If Logon.mblnAssetCategoryExists = True Then
            txtEnterMSRNumber.Text = ""
            Exit Sub
        End If

        'Setting up the grid view
        SetControlsVisible(True)
        PartsReceivedGridView.Visible = True
        PartsReceivedGridView.Rows.Clear()
        PartsReceivedGridView.ColumnCount = 5
        PartsReceivedGridView.Columns(0).Name = "Project ID"
        PartsReceivedGridView.Columns(1).Name = "MSR Number"
        PartsReceivedGridView.Columns(2).Name = "Part Number"
        PartsReceivedGridView.Columns(3).Name = "Quantity"
        PartsReceivedGridView.Columns(4).Name = "Include"

        'Getting ready for the loop
        intNumberOfRecords = cboReceiveTransactionID.Items.Count - 1
        ReDim mintSelectedIndex(intNumberOfRecords)
        mintCounter = 0

        'Performing the loop
        For intCounter = 0 To intNumberOfRecords

            'incrementing the combo box
            cboReceiveTransactionID.SelectedIndex = intCounter

            'Getting the MSR Number
            strMSRNumberFromTable = txtReceiveMSRNumber.Text

            'if statement to see if the msr numbers match
            If strMSRNumberForSearch = strMSRNumberFromTable Then

                'Setting up the array
                mintSelectedIndex(mintCounter) = intCounter

                'setting the boolean modifier
                blnItemNotFound = False

                'Loading the gridview
                row = New String() {txtReceiveTWCProjectID.Text, txtReceiveMSRNumber.Text, txtReceivePartNumber.Text, txtReceiveQuantity.Text, "YES"}
                PartsReceivedGridView.Rows.Add(row)
            End If
        Next

        'Message to use if nothing found
        If blnItemNotFound = True Then
            PartsReceivedGridView.Visible = False
            SetControlsVisible(False)
            MessageBox.Show("MSR Not Found", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'Setting up the combo box
        mintUpperLimit = mintCounter - 1
        cboReceiveTransactionID.SelectedIndex = mintSelectedIndex(0)
        cboReceiveTransactionID.Visible = False
        btnProcess.Enabled = True

    End Sub
    Private Sub ClearDataBindings()

        'This will clear the data bindings
        cboReceiveTransactionID.DataBindings.Clear()
        txtReceiveMSRNumber.DataBindings.Clear()
        txtReceivePartNumber.DataBindings.Clear()
        txtReceiveQuantity.DataBindings.Clear()
        txtReceiveTWCProjectID.DataBindings.Clear()

    End Sub

    Private Sub btnProcess_Click(sender As Object, e As EventArgs) Handles btnProcess.Click

        'This will load when the button is pressed
        'Setting local variables
        Dim intCounter As Integer
        Dim intNumberOfRecords As Integer
        Dim strProjectIDFromTable As String
        Dim datDate As Date = Date.Now
        Dim strPickListIDFromTable As String
        Dim strMSRNumberFromTable As String

        'Setting the variables for the pick list
        strProjectIDFromTable = txtReceiveTWCProjectID.Text
        strMSRNumberFromTable = txtReceiveMSRNumber.Text
        Logon.mstrMSR = strMSRNumberFromTable

        'Setting the controls
        SetControlsVisible(False)

        'Creating the pick list header
        Logon.mstrTWCProjectID = strProjectIDFromTable
        CreatePickListHeader.Show()

        If Logon.mbolFatalError = True Then
            SetControlsVisible(False)
            MessageBox.Show("The Transactions were not saved", "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'Getting the pick list ID
        strPickListIDFromTable = CStr(Logon.mintPickListID)

        'Getting the count of the rows
        intNumberOfRecords = PartsReceivedGridView.RowCount - 2

        'Performing the loop
        For intCounter = 0 To intNumberOfRecords

            Logon.mstrPartNumber = PartsReceivedGridView.Rows(intCounter).Cells(2).Value.ToString.ToUpper
            Logon.mintQuantity = CInt(PartsReceivedGridView.Rows(intCounter).Cells(3).Value.ToString.ToUpper)
            Logon.mintPickListID = CInt(strPickListIDFromTable)

            CreatePickListTransactions.Show()

            If Logon.mbolFatalError = True Then
                SetControlsVisible(False)
                MessageBox.Show("The Transactions were not saved", "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

        Next

        'Final Process Clean Up
        PartsReceivedGridView.Visible = False
        btnProcess.Enabled = False
        txtEnterMSRNumber.Text = ""

        'Printing the Pick List
        Logon.mintPickListID = CInt(strPickListIDFromTable)
        PrintPickList.Show()

        MessageBox.Show("The Pick List Has Been Generated and Printed", "Thank You", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub
End Class