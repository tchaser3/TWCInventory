'Title:         Item Not Found
'Date:          3-4-15
'Author:        Terry Holmes

'Description:   This will allow the user to update a sub routine

Option Strict On

Public Class ItemNotFound

    Private Sub ItemNotFound_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'This will load up the label
        If Logon.mstrFormForDataEntry = "PROJECT" Then
            lblUserInformation.Text = "The Project ID " + Logon.mstrTWCProjectID + " Was Not Located In the Project Table, Press to Add to Project Table or Press No To Cancel The Transaction"
        ElseIf Logon.mstrFormForDataEntry = "PART" Then
            lblUserInformation.Text = "The Part Number " + Logon.mstrPartNumber + " Entered Does Not Exist, Do You Want to Create IT"
        End If

    End Sub

    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click

        'This will set the boolean modifier
        Logon.mblnDoNotUpdate = False
        Me.Close()

    End Sub

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click

        'This will cancel the transaction
        Logon.mblnDoNotUpdate = True
        Me.Close()

    End Sub
End Class