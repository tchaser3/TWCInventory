Public Class AddWarehouseInventory

    Private TheWarehouseInventoryDataTier As TWInventoryDataTier
    Private TheWarehouseInventoryDataSet As WarehouseInventoryDataSet
    Private WithEvents TheWarehouseInventoryBindingSource As BindingSource

    Private addingBoolean As Boolean = False
    Private editingBoolean As Boolean = False
    Private previouseSelectedIndex As Integer

    Dim TheInputDataValidation As New InputDataValidation

    Private Sub SetComboBoxBinding()

        'This will set the combo box bindings
        With cboPartID
            If (addingBoolean Or editingBoolean) Then
                .DataBindings!text.DataSourceUpdateMode = DataSourceUpdateMode.OnValidation
                .DropDownStyle = ComboBoxStyle.Simple
            Else
                .DataBindings!text.DataSourceUpdateMode = DataSourceUpdateMode.Never
                .DropDownStyle = ComboBoxStyle.DropDownList
            End If
        End With

    End Sub

    Private Sub AddWarehouseInventory_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try

            'Setting up the data variables
            TheWarehouseInventoryDataTier = New TWInventoryDataTier
            TheWarehouseInventoryDataSet = TheWarehouseInventoryDataTier.GetWarehouseInventoryInformation
            TheWarehouseInventoryBindingSource = New BindingSource

            'Setting up the binding source
            With TheWarehouseInventoryBindingSource
                .DataSource = TheWarehouseInventoryDataSet
                .DataMember = "WarehouseInventory"
                .MoveFirst()
                .MoveLast()
            End With

            'Setting up the combo box
            With cboPartID
                .DataSource = TheWarehouseInventoryBindingSource
                .DisplayMember = "PartID"
                .DataBindings.Add("text", TheWarehouseInventoryBindingSource, "PartID", False, DataSourceUpdateMode.Never)
            End With

            'Setting up the rest of the controls
            txtPartNumber.DataBindings.Add("text", TheWarehouseInventoryBindingSource, "PartNumber")
            txtPartDescription.DataBindings.Add("text", TheWarehouseInventoryBindingSource, "PartDescription")
            txtQTYResponible.DataBindings.Add("text", TheWarehouseInventoryBindingSource, "QTYOnHand")

            'Setting the combo box up
            cboPartID.SelectedIndex = 0

            'Setting up the binding source
            With TheWarehouseInventoryBindingSource
                .EndEdit()
                .AddNew()
            End With

            'Setting up the variables
            addingBoolean = True
            SetComboBoxBinding()
            If cboPartID.SelectedIndex <> -1 Then
                previouseSelectedIndex = cboPartID.Items.Count - 1
            Else
                previouseSelectedIndex = 0
            End If
            cboPartID.Focus()

            cboPartID.Text = CStr(Logon.mintPartID)
            txtPartNumber.Text = Logon.mstrPartNumber
            txtPartDescription.Text = Logon.mstrPartDescription
            txtQTYResponible.Text = CStr(Logon.mintQuantity)

            'saving record
            TheWarehouseInventoryBindingSource.EndEdit()
            TheWarehouseInventoryDataTier.UpdateWarehouseInventoryDB(TheWarehouseInventoryDataSet)
            addingBoolean = False
            SetComboBoxBinding()

            Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class