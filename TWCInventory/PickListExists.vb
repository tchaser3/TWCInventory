'Title:         Pick List Exists
'Date:          3-20-15
'Author:        Terry Holmes

'Description:   This is a question form

Option Strict On

Public Class PickListExists

    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click

        'Setting boolean variable
        Logon.mblnAssetCategoryExists = False
        Me.Close()

    End Sub

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click

        'setting boolean variable
        Logon.mblnAssetCategoryExists = True
        Me.Close()

    End Sub

    Private Sub PickListExists_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblMessageToUser.Text = "Pick List " + CStr(Logon.mintPickListID) + " Exists for This Project.  Press Yes to Continue Processing, Press No to Cancel"
    End Sub
End Class