'Title:         Change Text to Upper
'Date:          12-1-14
'Author:        Terry Holmes

'Description:   This form is used to change all the text to upper case

Option Strict On

Public Class ChangeText

    Private TheInventoryDataTier As TWInventoryDataTier
    Private TheInventoryDataSet As InventoryDataSet
    Private WithEvents TheInventoryBindingSource As BindingSource

    Private addingBoolean As Boolean = False
    Private editingBoolean As Boolean = False
    Private previouseSelectedIndex As Integer

    Dim TheInputDataValidation As New InputDataValidation

    Dim mstrPartNumberArray(1000) As String
    Dim mstrPartDescription(1000) As String

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        CloseProgram.ShowDialog()

    End Sub

    Private Sub btnMainMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMainMenu.Click

        'This will launch the main menu
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub btnRun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRun.Click

        'This will update the text of the table

        'Setting up the local variables
        Dim intCounter As Integer
        Dim intNumberOfRecords As Integer
        Dim strPartNumber As String
        Dim strPartDescription As String

        'Getting information to run loop
        intNumberOfRecords = cboPartID.Items.Count - 1

        'Running Loop
        For intCounter = 0 To intNumberOfRecords

            'Incrementing the combo box
            cboPartID.SelectedIndex = intCounter

            'Loading up the variables
            strPartDescription = txtPartDescription.Text
            strPartNumber = txtPartNumber.Text

            strPartDescription = strPartDescription.ToUpper
            strPartNumber = strPartNumber.ToUpper

            mstrPartDescription(intCounter) = strPartDescription
            mstrPartNumberArray(intCounter) = strPartNumber

        Next

        'Clearing the db
        For intCounter = 0 To intNumberOfRecords

            cboPartID.SelectedIndex = intCounter

            'Setting the text boxes
            txtPartDescription.Text = "Clearing DB"
            txtPartNumber.Text = "Clearing DB"

            TheInventoryBindingSource.EndEdit()
            TheInventoryDataTier.UpdateInventoryDB(TheInventoryDataSet)

        Next

        'Clearing the db
        For intCounter = 0 To intNumberOfRecords

            cboPartID.SelectedIndex = intCounter

            'Setting the text boxes
            txtPartDescription.Text = mstrPartDescription(intCounter)
            txtPartNumber.Text = mstrPartNumberArray(intCounter)

            TheInventoryBindingSource.EndEdit()
            TheInventoryDataTier.UpdateInventoryDB(TheInventoryDataSet)

        Next

        MessageBox.Show("It Is Completed", "Thank You", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub ChangeText_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'This will run to load up the form
        'Try Catch to Load Form
        Try

            'Setting up the data variables
            TheInventoryDataTier = New TWInventoryDataTier
            TheInventoryDataSet = TheInventoryDataTier.GetInventoryInformation
            TheInventoryBindingSource = New BindingSource

            'Setting up the binding source
            With TheInventoryBindingSource
                .DataSource = TheInventoryDataSet
                .DataMember = "Inventory"
                .MoveFirst()
                .MoveLast()
            End With

            'Setting up the combo box
            With cboPartID
                .DataSource = TheInventoryBindingSource
                .DisplayMember = "PartID"
                .DataBindings.Add("text", TheInventoryBindingSource, "PartID", False, DataSourceUpdateMode.Never)
            End With

            'Setting up the rest of the controls
            txtPartNumber.DataBindings.Add("text", TheInventoryBindingSource, "PartNumber")
            txtPartDescription.DataBindings.Add("text", TheInventoryBindingSource, "PartDescription")
            txtQTYResponible.DataBindings.Add("text", TheInventoryBindingSource, "QTYResponible")


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class