'Title:         View Project Menu
'Date:          1-29-15
'Author:        Terry Holmes

'Description:   This is the menu for the project

Public Class ViewProjects

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

    Private Sub btnCreateProjects_Click(sender As Object, e As EventArgs) Handles btnCreateProjects.Click

        'This will call the create project form
        CreateProjects.Show()
        Me.Close()

    End Sub

    Private Sub btnProjectPartReport_Click(sender As Object, e As EventArgs) Handles btnProjectPartReport.Click
        Logon.mstrLastTransactionSummary = "Loaded Project Menu"
        ProjectTransactionReport.Show()
        Me.Close()
    End Sub
End Class