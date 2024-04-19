'Title:         Report Menu
'Date:          11-28-14
'Author:        Terry Holmes

'Description:   This form is for launching reports

Option Strict On

Public Class ReportMenu

    'Setting the global variables
    Dim TheModuleUnderDevelopment As New ModuleUnderDevelopment

    Private Sub btnMainMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMainMenu.Click

        'This will display the Main Menu
        LastTransaction.Show()
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        CloseProgram.ShowDialog()

    End Sub

    Private Sub btnOnHandReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOnHandReport.Click

        'This will display the On Hand Report
        LastTransaction.Show()
        PartProjectTransactionReport.Show()
        Me.Close()

    End Sub


    Private Sub btnCompleteInventoryReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompleteInventoryReport.Click

        'This will launch the complete report
        LastTransaction.Show()
        CompleteInventoryReport.Show()
        Me.Close()

    End Sub

    Private Sub btnProjectTransactionReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProjectTransactionReport.Click

        'Setting up the class
        LastTransaction.Show()
        ProjectTransactionReport.Show()
        Me.Close()

    End Sub

    Private Sub btnViewTimeWarnerTransactions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewTimeWarnerTransactions.Click

        'Launches the Part Number Transaction Report
        LastTransaction.Show()
        ViewTimeWarnerTransactions.Show()
        Me.Close()

    End Sub

    Private Sub ReportMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Setting global variables
        Logon.mstrLastTransactionSummary = "LOADED REPORTS MENU"

    End Sub
End Class