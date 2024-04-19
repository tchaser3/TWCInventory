'Title:         Time Warner Inventory Program
'Date:          11-27-14
'Author:        Terry Holmes

'Description:   This Form will allow the application to use hidden variables

Option Strict On

Public Class Form1

    'This is setting the application global variables

    'Setting the module clase
    Dim TheModuleUnderDevelopment As New ModuleUnderDevelopment

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        'This calls the Close Program Dialog Box
        CloseProgram.ShowDialog()

    End Sub


    Private Sub btnReports_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReports.Click

        'This will display the report menu
        ReportMenu.Show()
        Me.Close()

    End Sub

    Private Sub btnReceiveInventory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReceiveInventory.Click

        'This will display the Receive Menu
        ReceiveMenu.Show()
        Me.Close()

    End Sub

    Private Sub btnAdminMenu_Click(sender As Object, e As EventArgs) Handles btnAdminMenu.Click

        'This will launch the Admin Menu
        AdminMenu.Show()
        Me.Close()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        'This will set up the conditions for form load
        If Logon.mstrGroup = "ADMIN" Or Logon.mstrGroup = "WAREHOUSE" Or Logon.mstrGroup = "OFFICE" Then
            btnViewProjects.Enabled = True
            btnReceiveInventory.Enabled = True
            btnIssueInventory.Enabled = True
            btnAbout.Enabled = True
            btnAdminMenu.Enabled = True
        End If
    End Sub

    Private Sub btnIssueInventory_Click(sender As Object, e As EventArgs) Handles btnIssueInventory.Click

        'This will launch the issue inventory menu
        IssueInventory.Show()
        Me.Close()

    End Sub

    Private Sub btnViewProjects_Click(sender As Object, e As EventArgs) Handles btnViewProjects.Click

        'This will show the View Projects Menu
        ViewProjects.Show()
        Me.Close()

    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click

        'This will launch the About Box
        About.ShowDialog()

    End Sub

    Private Sub btnUseInventory_Click(sender As Object, e As EventArgs) Handles btnUseInventory.Click

        'This will launch the Use Inventory Menu
        UseInventory.Show()
        Me.Close()

    End Sub

    Private Sub btnViewInventory_Click(sender As Object, e As EventArgs) Handles btnViewInventory.Click

        'This will launch the View Inventory Menu
        ViewInventory.Show()
        Me.Close()

    End Sub
End Class
