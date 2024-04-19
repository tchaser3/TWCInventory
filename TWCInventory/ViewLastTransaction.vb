'Title:         View Last Transaction
'Date:          1-13-15
'Author:        Terry Holmes

'Description:   This form is used to view the last transaction

Option Strict On

Public Class ViewLastTransaction

    'Setting up the global data sources
    Private TheLastTransactionDataSet As LastTransactionDataSet
    Private TheLastTransactionDataTier As LastTransactionDataTier
    Private WithEvents TheLastTransactionBindingSource As BindingSource

    'Setting up array
    Dim mintCounter As Integer
    Dim mintSelectedIndex() As Integer
    Dim mintUpperLimit As Integer
    Dim TheInputDataValidation As New InputDataValidation

    Private Sub ViewLastTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'This will load when the form is launched
        'Try Catch for exceptions
        'Setting up the local variables
        Dim intNumberOfRecords As Integer

        Try

            'Setting up the data set
            TheLastTransactionDataTier = New LastTransactionDataTier
            TheLastTransactionDataSet = TheLastTransactionDataTier.GetLastTransactionInformation
            TheLastTransactionBindingSource = New BindingSource

            'Setting up the binding source
            With TheLastTransactionBindingSource
                .DataSource = TheLastTransactionDataSet
                .DataMember = "lasttransaction"
                .MoveFirst()
                .MoveLast()
            End With

            'Setting up the combo box
            With cboTransactionID
                .DataSource = TheLastTransactionBindingSource
                .DisplayMember = "TransactionID"
                .DataBindings.Add("text", TheLastTransactionBindingSource, "TransactionID", False, DataSourceUpdateMode.Never)
            End With

            'Setting up the rest of the controls
            txtEmployeeID.DataBindings.Add("text", TheLastTransactionBindingSource, "EmployeeID")
            txtDate.DataBindings.Add("text", TheLastTransactionBindingSource, "Date")
            txtLastTransactionSummary.DataBindings.Add("text", TheLastTransactionBindingSource, "LastTransactionSummary")

            'Redimensioning the array
            intNumberOfRecords = cboTransactionID.Items.Count - 1
            ReDim mintSelectedIndex(intNumberOfRecords)

            'Setting defaault value
            txtNumberOfLastTransactions.Text = "10"

            'Calling sub routine
            FindLastTransactionsForEmployee()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub FindLastTransactionsForEmployee()

        'This will find the number of last transactions

        'Setting local variables
        Dim intCounter As Integer
        Dim intNumberOfRecords As Integer
        Dim strValueForValidation As String
        Dim blnFatalError As Boolean = False
        Dim blnThereIsAProblem As Boolean = False
        Dim strErrorMessage As String = ""
        Dim intEmployeeIDForSearch As Integer
        Dim intEmployeeIDFromTable As Integer
        Dim intNumberOfTransactionsRequested As Integer

        'Setting navigation buttons
        btnNext.Enabled = False
        btnBack.Enabled = False

        'Performing data validation
        strValueForValidation = txtNumberOfLastTransactions.Text
        blnFatalError = TheInputDataValidation.VerifyIntegerData(strValueForValidation)
        If blnFatalError = True Then
            blnThereIsAProblem = True
            strErrorMessage = "The Number of Transactions is not an Integer"
        Else
            blnFatalError = TheInputDataValidation.VerifyIntegerRange(strValueForValidation)
            If blnFatalError = True Then
                blnThereIsAProblem = True
                strErrorMessage = "The Number of Transactions is out Range"
            End If
        End If

        'Output to user
        If blnThereIsAProblem = True Then
            txtNumberOfLastTransactions.Text = ""
            MessageBox.Show(strErrorMessage, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'Setting up for loop
        intNumberOfRecords = cboTransactionID.Items.Count - 1
        intEmployeeIDForSearch = Logon.mintEmployeeID
        mintCounter = 0
        intNumberOfTransactionsRequested = CInt(txtNumberOfLastTransactions.Text)

        For intCounter = intNumberOfRecords To 0 Step -1

            'Setting the combo box selected index
            cboTransactionID.SelectedIndex = intCounter

            'getting employee id
            intEmployeeIDFromTable = CInt(txtEmployeeID.Text)

            'If statement to see if the IDs match
            If intEmployeeIDForSearch = intEmployeeIDFromTable Then

                'Setting up the array
                mintSelectedIndex(mintCounter) = intCounter
                mintCounter += 1

                'If statement to see if the loop is done
                If mintCounter = intNumberOfTransactionsRequested Then
                    intCounter = 0
                End If

            End If

        Next

        'Setting up for navigation
        mintUpperLimit = mintCounter - 1
        If mintUpperLimit >= intNumberOfTransactionsRequested - 1 Then
            mintUpperLimit = intNumberOfTransactionsRequested - 1
        End If

        'Setting up the navigation buttons
        If mintUpperLimit > 0 Then
            btnNext.Enabled = True
        End If

        mintCounter = 0
        cboTransactionID.SelectedIndex = mintSelectedIndex(0)

    End Sub

    Private Sub btnAdministrativeMenu_Click(sender As Object, e As EventArgs) Handles btnAdministrativeMenu.Click

        'This will launch the Administrative Menu
        LastTransaction.Show()
        AdminMenu.Show()
        Me.Close()

    End Sub

    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click

        'This will open up the main menu
        LastTransaction.Show()
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        'This will close the application
        CloseProgram.ShowDialog()

    End Sub

    Private Sub btnFindTransaction_Click(sender As Object, e As EventArgs) Handles btnFindTransaction.Click

        'Calling sub routine
        FindLastTransactionsForEmployee()

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        'Setting up the counter variable
        mintCounter += 1

        'This will increment the combo box
        cboTransactionID.SelectedIndex = mintSelectedIndex(mintCounter)

        'setting the navigation button
        btnBack.Enabled = True

        'Checking to see if to the other button is disabled
        If mintCounter = mintUpperLimit Then
            btnNext.Enabled = False
        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        'Setting up the counter variable
        mintCounter -= 1

        'This will increment the combo box
        cboTransactionID.SelectedIndex = mintSelectedIndex(mintCounter)

        'setting the navigation button
        btnNext.Enabled = True

        'Checking to see if to the other button is disabled
        If mintCounter = 0 Then
            btnBack.Enabled = False
        End If

    End Sub
End Class