'Title:         Use Inventory Menu
'Date:          2-24-15
'Author:        Terry Holmes

'Description:   This form is for using Usage

Public Class UseInventory

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

    Private Sub UseInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Loading up global variable
        Logon.mstrLastTransactionSummary = "LOADED USE INVENTORY MENU"

    End Sub

    Private Sub btnInputUsageFromBOM_Click(sender As Object, e As EventArgs) Handles btnInputUsageFromBOM.Click

        'This will load the Input from bom from
        LastTransaction.Show()
        Logon.mstrEntryType = "BOM"
        EnterInventoryInformation.Show()
        Me.Close()

    End Sub

    Private Sub btnInputUsageFromMaterialIssued_Click(sender As Object, e As EventArgs) Handles btnInputUsageFromMaterialIssued.Click

        'This will show the useage from umaterial issued
        LastTransaction.Show()
        UseMaterialFromIssued.Show()
        Me.Close()

    End Sub
End Class