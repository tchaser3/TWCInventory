'Title:         About Box
'Date:          12-1-14
'Author;        Terry Holmes

'Description:   This form is about the program

Option Strict On

Public Class About

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        'This will close the form
        Me.Close()

    End Sub

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CalculateOnHandInventory.Show()
    End Sub
End Class