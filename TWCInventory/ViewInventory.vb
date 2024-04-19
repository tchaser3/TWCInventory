'Title:         View Inventory Menu
'Date:          11-16-15
'Author:        Terry Holmes

'Description:   This form is used as the menu for viewing the inventory

Option Strict On

Public Class ViewInventory

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        'This will close the program
        CloseProgram.ShowDialog()

    End Sub

    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click

        'This will display the main menu
        Form1.Show()
        Me.Close()

    End Sub


    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        About.Show()
    End Sub

    Private Sub btnViewInventory_Click(sender As Object, e As EventArgs) Handles btnViewInventory.Click
        LastTransaction.Show()
        ViewWarehouseInventory.Show()
        Me.Close()
    End Sub
End Class