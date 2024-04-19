'Title:         Cycle Count Discrepany
'Date:          2-4-15
'Author:        Terry Holmes

'Description:   This form will let the user know there was a discrepancy

Option Strict On

Public Class CycleCountDiscrepancy

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click

        'This closes the form
        Me.Close()

    End Sub

    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click

        'This activates the form
        AdjustInventory.AdjustInventoryLevels()
        Me.Close()

    End Sub
End Class