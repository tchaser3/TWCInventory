'Title:         Receive Menu
'Date:          1-21-15
'Author:        Terry Holmes

'Description:   This is the menu for all parts for TWC to received

Option Strict On


Public Class ReceiveMenu

    Dim TheModuleUnderDevelopment As New ModuleUnderDevelopment

   
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        'This will close the program
        CloseProgram.ShowDialog()

    End Sub

    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click

        'This will display the main menu
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub btnReceiveMSROrder_Click(sender As Object, e As EventArgs) Handles btnReceiveMSROrder.Click

        'This will load the Entry form
        Logon.mstrEntryType = "RECEIVE"
        EnterInventoryInformation.Show()
        Me.Close()

    End Sub

    Private Sub btnViewReceivedProjectParts_Click(sender As Object, e As EventArgs) Handles btnViewReceivedProjectParts.Click

        'This will show Project Receive form
        ProjectReceivedTransactions.Show()
        Me.Close()

    End Sub

    Private Sub btnViewArchiveReceivedMenu_Click(sender As Object, e As EventArgs) Handles btnViewArchiveReceivedMenu.Click

        LastTransaction.Show()
        TheModuleUnderDevelopment.UnderDevelopment()

    End Sub

    Private Sub btnSearchPartsByMSRNumber_Click(sender As Object, e As EventArgs) Handles btnSearchPartsByMSRNumber.Click

        'This will load the Search Parts by MSR Number
        LastTransaction.Show()
        SearchPartsByMSRNumber.Show()
        Me.Close()

    End Sub

    Private Sub btnSearchPartsByDate_Click(sender As Object, e As EventArgs) Handles btnSearchPartsByDate.Click

        LastTransaction.Show()
        Logon.mstrButtonPressed = "RECEIVE TRANSACTIONS"
        DateRangeEntered.Show()
        Me.Close()

    End Sub

    Private Sub btnSearchPartsByDescription_Click(sender As Object, e As EventArgs) Handles btnSearchPartsByDescription.Click

        LastTransaction.Show()
        SearchDateByDescription.Show()
        Me.Close()

    End Sub

    Private Sub btnPartNumberDateSearch_Click(sender As Object, e As EventArgs) Handles btnPartNumberDateSearch.Click

        LastTransaction.Show()
        PartNumberDateSearch.Show()
        Me.Close()

    End Sub

    Private Sub ReceiveMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Logon.mstrLastTransactionSummary = "LOADED RECEIVE INVENTORY MENU"
    End Sub
End Class