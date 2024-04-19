'Title:         Administration Menu
'Date:          1-13-15
'Author:        Terry Holmes

'Description:   This form is used to run administrative functions of the application

Option Strict On

Public Class AdminMenu

    Dim TheModuleUnderDevelopment As New ModuleUnderDevelopment

    Private Sub AdminMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'This will run when the form is loaded
        Logon.mstrLastTransactionSummary = "LOADED THE ADMINISTRATIVE MENU"
        LastTransaction.Show()

    End Sub

    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click

        'This will load the main menu
        LastTransaction.Show()
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub btnAdjustInventory_Click(sender As Object, e As EventArgs) Handles btnAdjustInventory.Click

        Logon.mstrCategory = "ADJUSTINVENTORY"
        AdjustInventory.Show()
        Me.Close()

    End Sub

    Private Sub btnAddPartToInventory_Click(sender As Object, e As EventArgs) Handles btnAddPartToInventory.Click

        'This will display the Add Part Number
        AddPartsToInventory.Show()
        Me.Close()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        'This will close the program
        CloseProgram.ShowDialog()

    End Sub

    Private Sub btnReturnPartsToStock_Click(sender As Object, e As EventArgs) Handles btnReturnPartsToStock.Click
        Logon.mstrCategory = "RETURNMATERIAL"
        ReturnMaterialToWarehouse.Show()
        Me.Close()
    End Sub

    Private Sub btnCreateCycleCount_Click(sender As Object, e As EventArgs) Handles btnCreateCycleCount.Click

        'This will open the Create Cycle Count Tickets
        CreateCycleCountTickets.Show()
        Me.Close()

    End Sub

    Private Sub btnReturnPartsToVendor_Click(sender As Object, e As EventArgs) Handles btnReturnPartsToVendor.Click

        'This will load up the Returns Part To Vendor Form
        Logon.mstrCategory = "VENDORRETURNS"
        VendorReturns.Show()
        Me.Close()

    End Sub

    Private Sub btnStrockAdjustmentDateReport_Click(sender As Object, e As EventArgs) Handles btnStockAdjustmentDateReport.Click

        'This will launch the last transaction form
        LastTransaction.Show()
        StockAdjustmentDateReport.Show()
        Me.Close()

    End Sub

    Private Sub btnChangeWarehouse_Click(sender As Object, e As EventArgs) Handles btnChangeWarehouse.Click

        'This will change the warehouse
        LastTransaction.Show()
        Logon.mstrSelectionOrigination = "ADMIN"
        SelectPartsWarehouse.Show()
        Me.Close()

    End Sub
End Class