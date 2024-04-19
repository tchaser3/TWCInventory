'Title:         Check For Duplicate Part Number
'Date:          11-18-15
'Author:        Terry Holmes

'Description:   This form is used to check to see if the part number entered exists

Option Strict On

Public Class CheckForDuplicatePartNumber

    'Setting up the global variables
    Private ThePartNumberDataSet As PartNumberDataSet
    Private ThePartNumberDataTier As PartsDataTier
    Private WithEvents ThePartNumberBindingSource As BindingSource

    Private Sub CheckForDuplicatePartNumber_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'setting local variables
        Dim intCounter As Integer
        Dim intNumberOfRecords As Integer
        Dim strPartNumberForSearch As String
        Dim strPartNumberFromTable As String
        Dim blnPartNumberDoesExist As Boolean = False

        'try catch for exceptions
        Try

            'setting the controls up
            ThePartNumberDataTier = New PartsDataTier
            ThePartNumberDataSet = ThePartNumberDataTier.GetPartNumberInformation
            ThePartNumberBindingSource = New BindingSource

            'setting up the binding source
            With ThePartNumberBindingSource
                .DataSource = ThePartNumberDataSet
                .DataMember = "partnumbers"
                .MoveFirst()
                .MoveLast()
            End With

            'setting the combo box
            With cboPartID
                .DataSource = ThePartNumberBindingSource
                .DisplayMember = "PartID"
                .DataBindings.Add("text", ThePartNumberBindingSource, "PartID", False, DataSourceUpdateMode.Never)
            End With

            'setting up the last control
            txtPartNumber.DataBindings.Add("text", ThePartNumberBindingSource, "PartNumber")

            'getting ready for the loop
            intNumberOfRecords = cboPartID.Items.Count - 1
            strPartNumberForSearch = Logon.mstrPartNumber

            'preforming loop
            For intCounter = 0 To intNumberOfRecords

                'incrementing the combo box
                cboPartID.SelectedIndex = intCounter

                'getting part number
                strPartNumberFromTable = txtPartNumber.Text

                'if statements
                If strPartNumberForSearch = strPartNumberFromTable Then
                    blnPartNumberDoesExist = True
                End If
            Next

            Logon.mblnPartNumberExists = blnPartNumberDoesExist

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        'closes the form
        Me.Close()

    End Sub
End Class