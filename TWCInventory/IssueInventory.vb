'Title:         Issue Inventory Menu
'Date:          1-21-15
'Author:        Terry Holmes

'Description:   Issue Inventory Menu

Option Strict On

Public Class IssueInventory

    Dim TheModuleUnderDevelopment As New ModuleUnderDevelopment

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

    Private Sub IssueInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Message for Last Transaction
        Logon.mstrLastTransactionSummary = "LOADED ISSUE INVENTORY MENU"

    End Sub

    Private Sub btnIssueMaterial_Click(sender As Object, e As EventArgs) Handles btnIssueMaterial.Click

        'This will load the Entry form
        LastTransaction.Show()
        Logon.mstrEntryType = "ISSUE"
        EnterInventoryInformation.Show()
        Me.Close()

    End Sub

    Private Sub btnViewProjectIssuedParts_Click(sender As Object, e As EventArgs) Handles btnViewProjectIssuedParts.Click

        'This will load the project issued transactions
        LastTransaction.Show()
        ProjectIssuedTransactions.Show()
        Me.Close()
    End Sub

    Private Sub btnIssuePickList_Click(sender As Object, e As EventArgs) Handles btnIssuePickList.Click

        'This will view the Issue Pick List form
        LastTransaction.Show()
        TheModuleUnderDevelopment.UnderDevelopment()

    End Sub

    Private Sub btnCreatePickList_Click(sender As Object, e As EventArgs) Handles btnCreatePickList.Click

        'This will load up the create pick list menu
        LastTransaction.Show()
        CreatePickListMenu.Show()
        Me.Close()

    End Sub

    Private Sub btnDateRangePartsIssuedSearch_Click(sender As Object, e As EventArgs) Handles btnDateRangePartsIssuedSearch.Click

        LastTransaction.Show()
        PartsIssuedOverADateRange.Show()
        Me.Close()

    End Sub

    Private Sub btnPartNumberDateSearch_Click(sender As Object, e As EventArgs) Handles btnPartNumberDateSearch.Click
        LastTransaction.Show()
        PartNumberDateIssuedSearch.Show()
        Me.Close()
    End Sub

    Private Sub btnPartDescriptionDateSearch_Click(sender As Object, e As EventArgs) Handles btnPartDescriptionDateSearch.Click
        LastTransaction.Show()
        PartDescriptionDateIssuedSearch.Show()
        Me.Close()
    End Sub
End Class