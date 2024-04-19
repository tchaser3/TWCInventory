'Title:         Date Range for Search
'Date:          12-16-14
'Author:        Terry Holmes

'Description:   This program is used for a Date Range Search

Option Strict On

Public Class DateRangeEntered

    Dim TheInputDataValidation As New InputDataValidation
    Dim TheModuleUnderDevelopment As New ModuleUnderDevelopment

    Private Sub btnMainMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMainMenu.Click

        'This will display the main menu
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub btnReportMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReportMenu.Click

        'This will display the Report Menu
        If Logon.mstrButtonPressed = "RECEIVE TRANSACTIONS" Then
            ReceiveMenu.Show()
        Else
            ReportMenu.Show()
        End If

        Me.Close()

    End Sub

    Private Sub btnFindDates_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFindDates.Click

        Dim strValueForValidation As String
        Dim blnFatalError As Boolean = False
        Dim strErrorMessage As String = ""
        Dim blnThereIsAProblem As Boolean = False

        'Beginning data validation
        strValueForValidation = txtStartDate.Text
        blnFatalError = TheInputDataValidation.VerifyStartingEndingDatesAsDates(strValueForValidation)
        If blnFatalError = True Then
            blnThereIsAProblem = True
            strErrorMessage = strErrorMessage + "The Starting Date is not a Date" + vbNewLine
        End If

        strValueForValidation = txtEndDate.Text
        blnFatalError = TheInputDataValidation.VerifyStartingEndingDatesAsDates(strValueForValidation)
        If blnFatalError = True Then
            blnThereIsAProblem = True
            strErrorMessage = strErrorMessage + "The Ending Date is not a Date" + vbNewLine
        End If

        'Output to user
        If blnThereIsAProblem = True Then
            txtEndDate.Text = ""
            txtStartDate.Text = ""
            MessageBox.Show(strErrorMessage, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'Loading up variables
        Logon.mdatEndingDate = CDate(txtEndDate.Text)
        Logon.mdatStartingDate = CDate(txtStartDate.Text)

        'Selecting the correct form
        If Logon.mstrButtonPressed = "COMPLETE" Then
            CompleteInventoryReport.Show()
            Me.Close()
        ElseIf Logon.mstrButtonPressed = "PROJECT" Then
            TheModuleUnderDevelopment.UnderDevelopment()
            ReportMenu.Show()
            Me.Close()
        ElseIf Logon.mstrButtonPressed = "RECEIVE TRANSACTIONS" Then
            SearchPartsByDate.Show()
            Me.Close()
        End If

    End Sub

    Private Sub DateRangeEntered_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'This will load up the button
        If Logon.mstrButtonPressed = "RECEIVE TRANSACTIONS" Then

            btnReportMenu.Text = "Receive Menu"

        End If

    End Sub
End Class