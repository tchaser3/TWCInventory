'Title:         Create Pick List Menu
'Date:          2-23-15
'Author:        Terry Holmes

'Description:   This form is for Creating the Pick List

Option Strict On

Public Class CreatePickListMenu

    Dim TheModuleUnderDevelopment As New ModuleUnderDevelopment

    Private Sub CreatePickListMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'loading up a global variable
        Logon.mstrLastTransactionSummary = "LOADED THE CREATE PICK LIST MENU"

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        'This closes the program
        CloseProgram.ShowDialog()

    End Sub

    Private Sub btnIssueInventoryMenu_Click(sender As Object, e As EventArgs) Handles btnIssueInventoryMenu.Click

        'This will display the issue inventory menu
        LastTransaction.Show()
        IssueInventory.Show()
        Me.Close()

    End Sub

    Private Sub btnCreatePickListFromProjectID_Click(sender As Object, e As EventArgs) Handles btnCreatePickListFromProjectID.Click

        'This will display the create pick list from Part Number Form
        LastTransaction.Show()
        CreatePickListFromProjectID.Show()
        Me.Close()

    End Sub

    Private Sub btnCreatePickListFromMSR_Click(sender As Object, e As EventArgs) Handles btnCreatePickListFromMSR.Click

        'This will display the Create Pick List from MSR
        LastTransaction.Show()
        CreatePickListFromMSR.Show()
        Me.Close()

    End Sub
End Class