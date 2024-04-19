'Title:         Project Transaction Search
'Date:          12-30-14
'Author:        Terry Holmes

'Description:   This will search for all the tables for the project

Option Strict On

Public Class ProjectTransactionSearch

    Private TheIssuedPartsDataTier As TWInventoryDataTier
    Private TheIssuedPartsDataSet As IssuedPartsDataSet
    Private WithEvents TheIssuedPartsBindingSource As BindingSource

    Private TheReceivedPartsDataTier As TWInventoryDataTier
    Private TheReceivedPartsDataSet As ReceivedPartsDataSet
    Private WithEvents TheReceivedPartsBindingSource As BindingSource

    Private TheBOMPartsDataTier As TWInventoryDataTier
    Private TheBOMPartsDataSet As BOMPartsDataSet
    Private WithEvents TheBOMPartsBindingSource As BindingSource

    Private addingBoolean As Boolean = False
    Private editingBoolean As Boolean = False
    Private previouseSelectedIndex As Integer

    Dim TheInputDataValidation As New InputDataValidation
    Dim TheModuleUnderDevelopment As New ModuleUnderDevelopment

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        'Thise will close the program
        CloseProgram.Show()

    End Sub

    Private Sub btnMainMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMainMenu.Click

        'This will show the main menu
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub btnProjectTransactionReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProjectTransactionReport.Click

        TheModuleUnderDevelopment.UnderDevelopment()

    End Sub
End Class