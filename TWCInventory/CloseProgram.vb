'Title:         Close Program Verification
'Date:          11-27-14
'Author:        Terry Holmes

'Description:   This form will verify with the user that the application is to be closed

Public Class CloseProgram

   
    Private Sub btnYes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnYes.Click

        'This sets the global variable
        LastTransaction.Show()
        Logon.Close()
        Me.Close()

    End Sub

    Private Sub btnNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNo.Click

        'This sets the global variable
        Me.Close()

    End Sub
End Class