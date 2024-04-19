'Title:         Project Receive or Issue Report
'Date:          1-29-15
'Author:        Terry Holmes

'Description:   This form is used for both the Receive and Issue Reports

Option Strict On

Public Class ProjectReceiveIssueReport

    'Setting up the classes
    Dim TheInputDataValidation As New InputDataValidation
    Dim TheKeywordSearch As New KeyWordSearchClass

    'Setting up the project array global variables
    Dim mintProjectCounter As Integer
    Dim mintProjectSelectedIndex() As Integer
    Dim mintProjectUpperLimit As Integer
    Dim mstrProjectInternalID() As String
    Dim mstrProjectTWCID() As String
    Dim mstrProjectName() As String
    Dim mintProjectNumberOfRecords As Integer

    'Setting up the part global array variables
    Dim mintPartCounter As Integer
    Dim mintPartSelectedIndex() As Integer
    Dim mintPartUpperLimit As Integer
    Dim mstrPartInternalID() As String
    Dim mstrPartTWCID() As String
    Dim mstrPartDate() As String
    Dim mstrPartNumber() As String
    Dim mstrPartQuantity() As String
    Dim mintPartNumberOfRecords As Integer

    'Setting up the data set
    Private TheInternalProjectsDataSet As InternalProjectsDataSet
    Private TheInternalProjectsDataTier As InternalProjectsDataTier
    Private WithEvents TheInternalProjectsBindingSource As BindingSource

    Private TheReceivedPartsDataSet As ReceivedPartsDataSet
    Private TheReceivedPartsDataTier As TWInventoryDataTier
    Private WithEvents TheReceivedPartsBindingSource As BindingSource

    Private TheIssuedPartsDataSet As IssuedPartsDataSet
    Private TheIssuedPartsDataTier As TWInventoryDataTier
    Private WithEvents TheIssuedPartsBindingSource As BindingSource

    Private TheWarehouseInventoryDataSet As WarehouseInventoryDataSet
    Private TheWarehouseInventoryDataTier As TWInventoryDataTier
    Private WithEvents TheWarehouseInventoryBindingSource As BindingSource

    Dim mblnItemNotFound As Boolean = True
    Dim mintNewPrintCounter As Integer
    Dim LogDate As Date = Date.Now
    Dim mstrDate As String

    Private Sub btnProjectMenu_Click(sender As Object, e As EventArgs) Handles btnProjectMenu.Click

        'This wil launch the view projects menu
        ClearDataBindings()
        ViewProjects.Show()
        Me.Close()

    End Sub

    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click

        'This will launch the main menu
        ClearDataBindings()
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        'This will close the program
        CloseProgram.ShowDialog()

    End Sub

    Private Sub ProjectReceiveIssueReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'This sub-routine runs when the form is loaded
        If Logon.mstrCategory = "RECEIVED" Then
            lblTitle.Text = "Parts Received For a Project"
        ElseIf Logon.mstrCategory = "ISSUED" Then
            lblTitle.Text = "Parts Issued For a Project"
        End If

        PleaseWait.Show()

        'Try Catch for project
        Try

            'Setting up the controls
            TheInternalProjectsDataTier = New InternalProjectsDataTier
            TheInternalProjectsDataSet = TheInternalProjectsDataTier.GetInternalProjectsInformation
            TheInternalProjectsBindingSource = New BindingSource

            TheWarehouseInventoryDataTier = New TWInventoryDataTier
            TheWarehouseInventoryDataSet = TheWarehouseInventoryDataTier.GetWarehouseInventoryInformation
            TheWarehouseInventoryBindingSource = New BindingSource

            'Setting up the binding source
            With TheInternalProjectsBindingSource
                .DataSource = TheInternalProjectsDataSet
                .DataMember = "internalprojects"
                .MoveFirst()
                .MoveLast()
            End With

            With TheWarehouseInventoryBindingSource
                .DataSource = TheWarehouseInventoryDataSet
                .DataMember = "WarehouseInventory"
                .MoveFirst()
                .MoveFirst()
            End With

            'Binding the Combo Box
            With cboProjectTransactionID
                .DataSource = TheInternalProjectsBindingSource
                .DisplayMember = "InternalProjectID"
                .DataBindings.Add("text", TheInternalProjectsBindingSource, "InternalProjectID", False, DataSourceUpdateMode.Never)
            End With

            With cboPartID
                .DataSource = TheWarehouseInventoryBindingSource
                .DisplayMember = "PartID"
                .DataBindings.Add("text", TheWarehouseInventoryBindingSource, "PartID", False, DataSourceUpdateMode.Never)
            End With

            'Setting up the rest of the controls
            txtProjectName.DataBindings.Add("text", TheInternalProjectsBindingSource, "Projectname")
            txtProjectTWCID.DataBindings.Add("text", TheInternalProjectsBindingSource, "TWCControlNumber")
            txtInternalProjectID.DataBindings.Add("text", TheInternalProjectsBindingSource, "InternalProjectID")

            txtPartDescription.DataBindings.Add("text", TheWarehouseInventoryBindingSource, "PartDescription")
            txtPartNumber.DataBindings.Add("text", TheWarehouseInventoryBindingSource, "PartNumber")

            'Setting the correct bindings depending which button is pressed
            If Logon.mstrCategory = "RECEIVED" Then
                SetReceivedDataBindings()
            ElseIf Logon.mstrCategory = "ISSUED" Then
                SetIssuedDataBindings()
            End If

            'setting the conditions of the controls
            SetProjectControlsVisible(False)
            SetTransactionAndPartControlsVisible(False)
            btnRunReport.Enabled = False
            LoadProjectArray()
            LoadPartsArray()
            ClearDataBindings()
            PleaseWait.Close()

        Catch ex As Exception

            'Message to user if the sub-routine fails to load
            MessageBox.Show(ex.Message, "Please Correct the Project Load", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub
    Private Sub LoadPartsArray()

        Dim intCounter As Integer
        Dim intNumberOfRecords As Integer

        'Setting up for loop
        intNumberOfRecords = cboTransactionID.Items.Count - 1
        mintPartNumberOfRecords = intNumberOfRecords

        'Resizing the arrays
        ReDim mintPartSelectedIndex(intNumberOfRecords)
        ReDim mstrPartInternalID(intNumberOfRecords)
        ReDim mstrPartDate(intNumberOfRecords)
        ReDim mstrPartTWCID(intNumberOfRecords)
        ReDim mstrPartNumber(intNumberOfRecords)
        ReDim mstrPartQuantity(intNumberOfRecords)

        For intCounter = 0 To intNumberOfRecords

            'Incrementing the combo box
            cboTransactionID.SelectedIndex = intCounter

            'Loading the elements of the arrays
            mstrPartInternalID(intCounter) = txtTransactionInternalProjectID.Text
            mstrPartTWCID(intCounter) = txtTransactionProjectID.Text
            mstrPartDate(intCounter) = txtTransactionDate.Text
            mstrPartNumber(intCounter) = txtTransactionPartNumber.Text
            mstrPartQuantity(intCounter) = txtTransactionQTY.Text

        Next

    End Sub
    Private Sub LoadProjectArray()

        Dim intCounter As Integer
        Dim intNumberOfRecords As Integer

        'Setting up for loop
        intNumberOfRecords = cboProjectTransactionID.Items.Count - 1
        mintProjectNumberOfRecords = intNumberOfRecords

        'Resizing the arrays
        ReDim mintProjectSelectedIndex(intNumberOfRecords)
        ReDim mstrProjectInternalID(intNumberOfRecords)
        ReDim mstrProjectName(intNumberOfRecords)
        ReDim mstrProjectTWCID(intNumberOfRecords)

        For intCounter = 0 To intNumberOfRecords

            'Incrementing the combo box
            cboProjectTransactionID.SelectedIndex = intCounter

            'Loading the elements of the arrays
            mstrProjectInternalID(intCounter) = txtInternalProjectID.Text
            mstrProjectName(intCounter) = txtProjectName.Text
            mstrProjectTWCID(intCounter) = txtProjectTWCID.Text
        Next

    End Sub
    Private Sub SetIssuedDataBindings()

        Try

            'Setting up the controls
            TheIssuedPartsDataTier = New TWInventoryDataTier
            TheIssuedPartsDataSet = TheIssuedPartsDataTier.GetIssuedPartsInformation
            TheIssuedPartsBindingSource = New BindingSource

            'Setting up the binding source
            With TheIssuedPartsBindingSource
                .DataSource = TheIssuedPartsDataSet
                .DataMember = "IssuedParts"
                .MoveFirst()
                .MoveLast()
            End With

            'Binding the Combo Box
            With cboTransactionID
                .DataSource = TheIssuedPartsBindingSource
                .DisplayMember = "TransactionID"
                .DataBindings.Add("text", TheIssuedPartsBindingSource, "TransactionID", False, DataSourceUpdateMode.Never)
            End With

            'Setting up the rest of the controls
            txtTransactionDate.DataBindings.Add("text", TheIssuedPartsBindingSource, "Date")
            txtTransactionInternalProjectID.DataBindings.Add("text", TheIssuedPartsBindingSource, "InternalProjectID")
            txtTransactionPartNumber.DataBindings.Add("text", TheIssuedPartsBindingSource, "PartNumber")
            txtTransactionProjectID.DataBindings.Add("text", TheIssuedPartsBindingSource, "ProjectID")
            txtTransactionQTY.DataBindings.Add("text", TheIssuedPartsBindingSource, "QTY")

        Catch ex As Exception

            'Message to user if the sub-routine fails to load
            MessageBox.Show(ex.Message, "Please Correct the Project Load", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub
    Private Sub SetReceivedDataBindings()

        Try

            'Setting up the controls
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

            'Binding the Combo Box
            With cboTransactionID
                .DataSource = TheReceivedPartsBindingSource
                .DisplayMember = "TransactionID"
                .DataBindings.Add("text", TheReceivedPartsBindingSource, "TransactionID", False, DataSourceUpdateMode.Never)
            End With

            'Setting up the rest of the controls
            txtTransactionDate.DataBindings.Add("text", TheReceivedPartsBindingSource, "Date")
            txtTransactionInternalProjectID.DataBindings.Add("text", TheReceivedPartsBindingSource, "InternalProjectID")
            txtTransactionPartNumber.DataBindings.Add("text", TheReceivedPartsBindingSource, "PartNumber")
            txtTransactionProjectID.DataBindings.Add("text", TheReceivedPartsBindingSource, "ProjectID")
            txtTransactionQTY.DataBindings.Add("text", TheReceivedPartsBindingSource, "QTY")

        Catch ex As Exception

            'Message to user if the sub-routine fails to load
            MessageBox.Show(ex.Message, "Please Correct the Project Load", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub
    Private Sub ClearDataBindings()

        'This will remove all the data bindings
        'This clears the combo boxes
        cboProjectTransactionID.DataBindings.Clear()
        cboPartID.DataBindings.Clear()
        cboTransactionID.DataBindings.Clear()

        'This will clear the data bindings from the text boxes
        txtProjectName.DataBindings.Clear()
        txtProjectTWCID.DataBindings.Clear()
        txtTransactionDate.DataBindings.Clear()
        txtTransactionInternalProjectID.DataBindings.Clear()
        txtTransactionPartNumber.DataBindings.Clear()
        txtTransactionQTY.DataBindings.Clear()
        txtTransactionProjectID.DataBindings.Clear()

    End Sub
    Private Sub SetProjectControlsVisible(ByVal valueBoolean As Boolean)

        'This will set the project controls visible
        txtInternalProjectID.Visible = valueBoolean
        txtProjectName.Visible = valueBoolean
        txtProjectTWCID.Visible = valueBoolean
        btnProjectBack.Visible = valueBoolean
        btnProjectNext.Visible = valueBoolean

    End Sub
    Private Sub SetTransactionAndPartControlsVisible(ByVal valueBoolean As Boolean)

        'This will set the controls visible
        txtPartDescription.Visible = valueBoolean
        txtPartNumber.Visible = valueBoolean
        txtTransactionDate.Visible = valueBoolean
        txtTransactionInternalProjectID.Visible = valueBoolean
        txtTransactionPartNumber.Visible = valueBoolean
        txtTransactionQTY.Visible = valueBoolean
        btnPartBack.Visible = valueBoolean
        btnPartNext.Visible = valueBoolean
        txtTransactionProjectID.Visible = valueBoolean

    End Sub

    Private Sub btnProjectFind_Click(sender As Object, e As EventArgs) Handles btnProjectFind.Click

        'This is used to see if a project has been entered

        'Setting up local variables
        Dim intCounter As Integer
        Dim strProjectForSearch As String
        Dim strProjectFromTable As String
        Dim blnFatalError As Boolean = False
        Dim strMessageHeader As String
        Dim blnItemNotFound As Boolean = True

        'Preparing for data validation
        strProjectForSearch = txtFindProject.Text
        strMessageHeader = "The Control Is Empty"
        blnFatalError = TheInputDataValidation.VerifyTextData(strProjectForSearch)
        mblnItemNotFound = True

        'Setting up for the form to run
        mintProjectCounter = 0
        btnProjectNext.Enabled = False
        btnProjectBack.Enabled = False

        'Output to user if there is a problem
        If blnFatalError = True Then
            txtFindProject.Text = ""
            MessageBox.Show(Logon.mstrErrorMessage, strMessageHeader, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        PleaseWait.Show()

        SetProjectControlsVisible(True)

        'Getting the record count
        mintProjectCounter = 0

        'Beginning loop
        For intCounter = 0 To mintProjectNumberOfRecords

            'Setting the boolean modify
            blnItemNotFound = True

            'Loading the array
            txtInternalProjectID.Text = mstrProjectInternalID(intCounter)
            txtProjectTWCID.Text = mstrProjectTWCID(intCounter)
            txtProjectName.Text = mstrProjectName(intCounter)

            'Setting up the string
            strProjectFromTable = txtInternalProjectID.Text

            'If statement to see if the Internal ID matches
            If strProjectForSearch = strProjectFromTable Then
                blnItemNotFound = False
            End If

            If blnItemNotFound = True Then

                'Checking the Project ID
                strProjectFromTable = txtProjectTWCID.Text

                If strProjectForSearch = strProjectFromTable Then
                    blnItemNotFound = False
                End If

            End If

            If blnItemNotFound = True Then

                'Setting up for the third check
                strProjectFromTable = txtProjectName.Text

                If strProjectForSearch.Length <= strProjectFromTable.Length Then

                    'Calling the classstrProjectFromTable = txtProjectName.Text

                    If strProjectForSearch.Length <= strProjectFromTable.Length Then

                        'Calling the class
                        blnItemNotFound = TheKeywordSearch.FindKeyWord(strProjectForSearch, strProjectFromTable)

                    End If
                    blnItemNotFound = TheKeywordSearch.FindKeyWord(strProjectForSearch, strProjectFromTable)

                End If

            End If

            If blnItemNotFound = False Then
                mintProjectSelectedIndex(mintProjectCounter) = intCounter
                mintProjectCounter += 1
                mblnItemNotFound = False
            End If

        Next

        'If statement for if Item is Not Found
        If mblnItemNotFound = True Then
            txtFindProject.Text = ""
            PleaseWait.Close()
            SetProjectControlsVisible(False)
            MessageBox.Show("Project Not Found", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        'Setting the combo box selected index
        mintProjectUpperLimit = mintProjectCounter - 1
        mintProjectCounter = 0

        'Setting the initial conditions
        txtInternalProjectID.Text = mstrProjectInternalID(mintProjectSelectedIndex(mintProjectCounter))
        txtProjectTWCID.Text = mstrProjectTWCID(mintProjectSelectedIndex(mintProjectCounter))
        txtProjectName.Text = mstrProjectName(mintProjectSelectedIndex(mintProjectCounter))

        'This will enable the buttons
        If mintProjectUpperLimit > 0 Then
            btnProjectNext.Enabled = True
        End If

        'Make Other Controls visible
        SetTransactionAndPartControlsVisible(True)
        FindProjectPartTransactions()
        btnRunReport.Enabled = True

    End Sub

    Private Sub btnProjectNext_Click(sender As Object, e As EventArgs) Handles btnProjectNext.Click

        'This will increment the counter
        mintProjectCounter += 1

        'Setting the combo box
        txtInternalProjectID.Text = mstrProjectInternalID(mintProjectSelectedIndex(mintProjectCounter))
        txtProjectTWCID.Text = mstrProjectTWCID(mintProjectSelectedIndex(mintProjectCounter))
        txtProjectName.Text = mstrProjectName(mintProjectSelectedIndex(mintProjectCounter))

        'Enabling the navigation controls
        btnProjectBack.Enabled = True

        'disabling the navigation controls
        If mintProjectCounter = mintProjectUpperLimit Then
            btnProjectNext.Enabled = False
        End If

        'Finding the project part transactions
        FindProjectPartTransactions()


    End Sub

    Private Sub btnProjectBack_Click(sender As Object, e As EventArgs) Handles btnProjectBack.Click

        'This will increment the counter
        mintProjectCounter -= 1

        'Setting the combo box
        txtInternalProjectID.Text = mstrProjectInternalID(mintProjectSelectedIndex(mintProjectCounter))
        txtProjectTWCID.Text = mstrProjectTWCID(mintProjectSelectedIndex(mintProjectCounter))
        txtProjectName.Text = mstrProjectName(mintProjectSelectedIndex(mintProjectCounter))

        'Enabling the navigation controls
        btnProjectNext.Enabled = True

        'disabling the navigation controls
        If mintProjectCounter = 0 Then
            btnProjectBack.Enabled = False
        End If

        'Finding the project part transactions
        FindProjectPartTransactions()

    End Sub
    Private Sub FindProjectPartTransactions()

        'Setting local variables
        Dim intCounter As Integer
        Dim strTWCProjectIDForSearch As String
        Dim strTWCProjectIDFromTable As String
        Dim strInternalIDForSearch As String
        Dim strInternalIDFromTable As String
        Dim blnNoTransactionsFound As Boolean = True

        'Setting Navigation
        btnPartBack.Enabled = False
        btnPartNext.Enabled = False

        'setting up for the loop
        mintPartCounter = 0
        strTWCProjectIDForSearch = txtProjectTWCID.Text
        strInternalIDForSearch = txtInternalProjectID.Text

        'Running the loop
        For intCounter = 0 To mintPartNumberOfRecords

            txtTransactionInternalProjectID.Text = mstrPartInternalID(intCounter)
            txtTransactionProjectID.Text = mstrPartTWCID(intCounter)
            txtTransactionDate.Text = mstrPartDate(intCounter)
            txtTransactionPartNumber.Text = mstrPartNumber(intCounter)
            txtTransactionQTY.Text = mstrPartQuantity(intCounter)


            'Getting the Project IDs
            strTWCProjectIDFromTable = txtTransactionProjectID.Text
            strInternalIDFromTable = txtTransactionInternalProjectID.Text

            If strTWCProjectIDForSearch = strTWCProjectIDFromTable Or strInternalIDForSearch = strInternalIDFromTable Then

                'Setting up the array
                mintPartSelectedIndex(mintPartCounter) = intCounter
                mintPartCounter += 1
                blnNoTransactionsFound = False

            End If

        Next

        'Letting user know results
        If blnNoTransactionsFound = True Then
            MessageBox.Show("No Part Transactions Were Found", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        'Setting navigation
        mintPartUpperLimit = mintPartCounter - 1
        mintPartCounter = 0
        txtTransactionInternalProjectID.Text = mstrPartInternalID(mintPartSelectedIndex(mintPartCounter))
        txtTransactionProjectID.Text = mstrPartTWCID(mintPartSelectedIndex(mintPartCounter))
        txtTransactionDate.Text = mstrPartDate(mintPartSelectedIndex(mintPartCounter))
        txtTransactionPartNumber.Text = mstrPartNumber(mintPartSelectedIndex(mintPartCounter))
        txtTransactionQTY.Text = mstrPartQuantity(mintPartSelectedIndex(mintPartCounter))

        If mintPartUpperLimit > 0 Then
            btnPartNext.Enabled = True
        End If

        FindPartInformation()
        PleaseWait.Close()

    End Sub
    Private Sub FindPartInformation()

        'Setting sub-routine local variables
        Dim strPartNumberForSearch As String
        Dim strPartNumberFromTable As String
        Dim intSelectedIndex As Integer
        Dim intCounter As Integer
        Dim intNumberOfRecords As Integer

        'Setting up for the loop
        intNumberOfRecords = cboPartID.Items.Count - 1
        strPartNumberForSearch = txtTransactionPartNumber.Text

        'Beginning Loop
        For intCounter = 0 To intNumberOfRecords

            'Incrementing the combo box
            cboPartID.SelectedIndex = intCounter

            'getting the part number
            strPartNumberFromTable = txtPartNumber.Text

            'If Statement to see ifthey match
            If strPartNumberForSearch = strPartNumberFromTable Then
                intSelectedIndex = intCounter
            End If
        Next

        'Setting the combo box for the location
        cboPartID.SelectedIndex = intSelectedIndex

    End Sub

    Private Sub btnPartNext_Click(sender As Object, e As EventArgs) Handles btnPartNext.Click

        'This will increment the counter
        mintPartCounter += 1

        'Setting the combo box
        txtTransactionInternalProjectID.Text = mstrPartInternalID(mintPartSelectedIndex(mintPartCounter))
        txtTransactionProjectID.Text = mstrPartTWCID(mintPartSelectedIndex(mintPartCounter))
        txtTransactionDate.Text = mstrPartDate(mintPartSelectedIndex(mintPartCounter))
        txtTransactionPartNumber.Text = mstrPartNumber(mintPartSelectedIndex(mintPartCounter))
        txtTransactionQTY.Text = mstrPartQuantity(mintPartSelectedIndex(mintPartCounter))

        'Calling the part 
        FindPartInformation()

        'Enabling the navigation
        btnPartBack.Enabled = True

        If mintPartCounter = mintPartUpperLimit Then
            btnPartNext.Enabled = False
        End If

    End Sub

    Private Sub btnPartBack_Click(sender As Object, e As EventArgs) Handles btnPartBack.Click

        'This will increment the counter
        mintPartCounter -= 1

        'Setting the combo box
        txtTransactionInternalProjectID.Text = mstrPartInternalID(mintPartSelectedIndex(mintPartCounter))
        txtTransactionProjectID.Text = mstrPartTWCID(mintPartSelectedIndex(mintPartCounter))
        txtTransactionDate.Text = mstrPartDate(mintPartSelectedIndex(mintPartCounter))
        txtTransactionPartNumber.Text = mstrPartNumber(mintPartSelectedIndex(mintPartCounter))
        txtTransactionQTY.Text = mstrPartQuantity(mintPartSelectedIndex(mintPartCounter))

        'Calling the part 
        FindPartInformation()

        'Enabling the navigation
        btnPartNext.Enabled = True

        If mintPartCounter = 0 Then
            btnPartBack.Enabled = False
        End If

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        'This will print the document
        'Setting up the local variables
        Dim intCounter As Integer
        Dim intNumberOfRecords As Integer
        Dim intStartingPageCounter As Integer
        Dim blnNewPage As Boolean = False

        'Setting up variables for the reports
        Dim PrintHeaderFont As New Font("Arial", 18, FontStyle.Bold)
        Dim PrintSubHeaderFont As New Font("Arial", 14, FontStyle.Bold)
        Dim PrintItemsFont As New Font("Arial", 10, FontStyle.Regular)
        Dim PrintX As Single = e.MarginBounds.Left
        Dim PrintY As Single = e.MarginBounds.Top
        Dim HeadingLineHeight As Single = PrintHeaderFont.GetHeight + 18
        Dim ItemLineHeight As Single = PrintItemsFont.GetHeight + 10

        'Variables for reducing the part discription
        Dim intCharacterCount As Integer
        Dim intCharacterLimit As Integer = 50
        Dim chaCharacterDescription() As Char
        Dim intStringLength As Integer
        Dim strPartDescription As String = ""

        'Getting the date
        mstrDate = CStr(LogDate)

        'Setting the starting Y coordinate
        PrintY = 100

        'Setting the starting X coordinate
        PrintX = 250
        e.Graphics.DrawString("Blue Jay Communications Project Transaction Report", PrintHeaderFont, Brushes.Black, PrintX, PrintY)
        PrintY = PrintY + HeadingLineHeight
        PrintX = 275
        e.Graphics.DrawString("Parts " + Logon.mstrCategory + " For Project " + txtProjectName.Text, PrintHeaderFont, Brushes.Black, PrintX, PrintY)
        PrintY = PrintY + HeadingLineHeight

        'Setting up for the columns
        PrintX = 100
        e.Graphics.DrawString("Part Number", PrintItemsFont, Brushes.Black, PrintX, PrintY)
        PrintX = 300
        e.Graphics.DrawString("Part Description", PrintItemsFont, Brushes.Black, PrintX, PrintY)
        PrintX = 800
        e.Graphics.DrawString("Date", PrintItemsFont, Brushes.Black, PrintX, PrintY)
        PrintX = 950
        e.Graphics.DrawString("Quantity", PrintItemsFont, Brushes.Black, PrintX, PrintY)
        PrintY = PrintY + HeadingLineHeight

        'Beginning Loop and getting ready for multiple pages
        intStartingPageCounter = mintNewPrintCounter

        'Setting the upper bounds
        intNumberOfRecords = mintPartUpperLimit

        For intCounter = intStartingPageCounter To intNumberOfRecords

            'Setting the location of the combo box
            txtTransactionInternalProjectID.Text = mstrPartInternalID(mintPartSelectedIndex(intCounter))
            txtTransactionProjectID.Text = mstrPartTWCID(mintPartSelectedIndex(intCounter))
            txtTransactionDate.Text = mstrPartDate(mintPartSelectedIndex(intCounter))
            txtTransactionPartNumber.Text = mstrPartNumber(mintPartSelectedIndex(intCounter))
            txtTransactionQTY.Text = mstrPartQuantity(mintPartSelectedIndex(intCounter))

            'Finding the part information
            FindPartInformation()

            PrintX = 100
            e.Graphics.DrawString(txtTransactionPartNumber.Text, PrintItemsFont, Brushes.Black, PrintX, PrintY)
            PrintX = 300
            e.Graphics.DrawString(txtPartDescription.Text, PrintItemsFont, Brushes.Black, PrintX, PrintY)
            PrintX = 800
            e.Graphics.DrawString(txtTransactionDate.Text, PrintItemsFont, Brushes.Black, PrintX, PrintY)
            PrintX = 1000
            e.Graphics.DrawString(txtTransactionQTY.Text, PrintItemsFont, Brushes.Black, PrintX, PrintY)
            PrintY = PrintY + ItemLineHeight

            'Setting up for multiple pages
            If PrintY > 800 Then
                If intStartingPageCounter = intNumberOfRecords Then
                    e.HasMorePages = False
                Else
                    e.HasMorePages = True
                    blnNewPage = True
                End If
            End If

            If blnNewPage = True Then
                mintNewPrintCounter = intCounter + 1
                intCounter = intNumberOfRecords
            End If

        Next

    End Sub

    Private Sub PrintDocument1_QueryPageSettings(sender As Object, e As Printing.QueryPageSettingsEventArgs) Handles PrintDocument1.QueryPageSettings

        'This will set the page to landscape
        e.PageSettings.Landscape = True

    End Sub

    Private Sub btnRunReport_Click(sender As Object, e As EventArgs) Handles btnRunReport.Click

        'Setting up the print dialog
        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
        End If

        Logon.mstrLastTransactionSummary = "RAN REPORT FROM PROJECT RECEIVE ISSUE"

        'Setting up for multiple pages
        mintNewPrintCounter = 0

        'Calling the print document
        PrintDocument1.Print()

    End Sub
End Class