<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdjustInventory
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cboAdjustInventoryTransactionID = New System.Windows.Forms.ComboBox()
        Me.txtAdjustInventoryPartNumber = New System.Windows.Forms.TextBox()
        Me.txtAdjustInventoryEmployeeID = New System.Windows.Forms.TextBox()
        Me.txtAdjustInventoryQuantity = New System.Windows.Forms.TextBox()
        Me.txtAdjustInventoryReason = New System.Windows.Forms.TextBox()
        Me.txtInventoryQuantity = New System.Windows.Forms.TextBox()
        Me.txtInventoryPartNumber = New System.Windows.Forms.TextBox()
        Me.cboPartID = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.btnAdminMenu = New System.Windows.Forms.Button()
        Me.btnUpdateInventory = New System.Windows.Forms.Button()
        Me.btnCompareCount = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtInventoryWarehouseID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCountedWarehouseID = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCountedQuantity = New System.Windows.Forms.TextBox()
        Me.txtCountedPartNumber = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtAdjustInventoryDate = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtAdjustInventoryWarehouseID = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cboAdjustInventoryTransactionID
        '
        Me.cboAdjustInventoryTransactionID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAdjustInventoryTransactionID.FormattingEnabled = True
        Me.cboAdjustInventoryTransactionID.Location = New System.Drawing.Point(489, 142)
        Me.cboAdjustInventoryTransactionID.Name = "cboAdjustInventoryTransactionID"
        Me.cboAdjustInventoryTransactionID.Size = New System.Drawing.Size(149, 21)
        Me.cboAdjustInventoryTransactionID.TabIndex = 7
        Me.cboAdjustInventoryTransactionID.Visible = False
        '
        'txtAdjustInventoryPartNumber
        '
        Me.txtAdjustInventoryPartNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAdjustInventoryPartNumber.Location = New System.Drawing.Point(489, 170)
        Me.txtAdjustInventoryPartNumber.Name = "txtAdjustInventoryPartNumber"
        Me.txtAdjustInventoryPartNumber.ReadOnly = True
        Me.txtAdjustInventoryPartNumber.Size = New System.Drawing.Size(149, 20)
        Me.txtAdjustInventoryPartNumber.TabIndex = 8
        '
        'txtAdjustInventoryEmployeeID
        '
        Me.txtAdjustInventoryEmployeeID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAdjustInventoryEmployeeID.Location = New System.Drawing.Point(489, 196)
        Me.txtAdjustInventoryEmployeeID.Name = "txtAdjustInventoryEmployeeID"
        Me.txtAdjustInventoryEmployeeID.ReadOnly = True
        Me.txtAdjustInventoryEmployeeID.Size = New System.Drawing.Size(149, 20)
        Me.txtAdjustInventoryEmployeeID.TabIndex = 9
        '
        'txtAdjustInventoryQuantity
        '
        Me.txtAdjustInventoryQuantity.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAdjustInventoryQuantity.Location = New System.Drawing.Point(489, 222)
        Me.txtAdjustInventoryQuantity.Name = "txtAdjustInventoryQuantity"
        Me.txtAdjustInventoryQuantity.ReadOnly = True
        Me.txtAdjustInventoryQuantity.Size = New System.Drawing.Size(149, 20)
        Me.txtAdjustInventoryQuantity.TabIndex = 10
        '
        'txtAdjustInventoryReason
        '
        Me.txtAdjustInventoryReason.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAdjustInventoryReason.Location = New System.Drawing.Point(489, 280)
        Me.txtAdjustInventoryReason.Multiline = True
        Me.txtAdjustInventoryReason.Name = "txtAdjustInventoryReason"
        Me.txtAdjustInventoryReason.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAdjustInventoryReason.Size = New System.Drawing.Size(149, 129)
        Me.txtAdjustInventoryReason.TabIndex = 12
        '
        'txtInventoryQuantity
        '
        Me.txtInventoryQuantity.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtInventoryQuantity.Location = New System.Drawing.Point(185, 342)
        Me.txtInventoryQuantity.Name = "txtInventoryQuantity"
        Me.txtInventoryQuantity.ReadOnly = True
        Me.txtInventoryQuantity.Size = New System.Drawing.Size(149, 20)
        Me.txtInventoryQuantity.TabIndex = 6
        '
        'txtInventoryPartNumber
        '
        Me.txtInventoryPartNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtInventoryPartNumber.Location = New System.Drawing.Point(185, 290)
        Me.txtInventoryPartNumber.Name = "txtInventoryPartNumber"
        Me.txtInventoryPartNumber.ReadOnly = True
        Me.txtInventoryPartNumber.Size = New System.Drawing.Size(149, 20)
        Me.txtInventoryPartNumber.TabIndex = 4
        '
        'cboPartID
        '
        Me.cboPartID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPartID.FormattingEnabled = True
        Me.cboPartID.Location = New System.Drawing.Point(185, 262)
        Me.cboPartID.Name = "cboPartID"
        Me.cboPartID.Size = New System.Drawing.Size(149, 21)
        Me.cboPartID.TabIndex = 3
        Me.cboPartID.Visible = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(352, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 23)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Part Number"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(352, 196)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 23)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Employee ID"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(352, 222)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 23)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Quantity"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(352, 319)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 23)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Reason"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(38, 339)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(131, 23)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Quantity"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(38, 287)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(131, 23)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Part Number"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(666, 368)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(171, 59)
        Me.btnClose.TabIndex = 17
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnMainMenu
        '
        Me.btnMainMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMainMenu.Location = New System.Drawing.Point(666, 303)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(171, 59)
        Me.btnMainMenu.TabIndex = 16
        Me.btnMainMenu.Text = "Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = True
        '
        'btnAdminMenu
        '
        Me.btnAdminMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdminMenu.Location = New System.Drawing.Point(666, 238)
        Me.btnAdminMenu.Name = "btnAdminMenu"
        Me.btnAdminMenu.Size = New System.Drawing.Size(171, 59)
        Me.btnAdminMenu.TabIndex = 15
        Me.btnAdminMenu.Text = "Administrative Menu"
        Me.btnAdminMenu.UseVisualStyleBackColor = True
        '
        'btnUpdateInventory
        '
        Me.btnUpdateInventory.Enabled = False
        Me.btnUpdateInventory.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateInventory.Location = New System.Drawing.Point(666, 170)
        Me.btnUpdateInventory.Name = "btnUpdateInventory"
        Me.btnUpdateInventory.Size = New System.Drawing.Size(171, 59)
        Me.btnUpdateInventory.TabIndex = 14
        Me.btnUpdateInventory.Text = "Update Inventory"
        Me.btnUpdateInventory.UseVisualStyleBackColor = True
        '
        'btnCompareCount
        '
        Me.btnCompareCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompareCount.Location = New System.Drawing.Point(666, 105)
        Me.btnCompareCount.Name = "btnCompareCount"
        Me.btnCompareCount.Size = New System.Drawing.Size(171, 59)
        Me.btnCompareCount.TabIndex = 13
        Me.btnCompareCount.Text = "Compare Count"
        Me.btnCompareCount.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(825, 55)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Compare Cycle Count Results/Update Inventory"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 310)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 23)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Warehouse ID"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtInventoryWarehouseID
        '
        Me.txtInventoryWarehouseID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtInventoryWarehouseID.Location = New System.Drawing.Point(185, 313)
        Me.txtInventoryWarehouseID.Name = "txtInventoryWarehouseID"
        Me.txtInventoryWarehouseID.ReadOnly = True
        Me.txtInventoryWarehouseID.Size = New System.Drawing.Size(149, 20)
        Me.txtInventoryWarehouseID.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(38, 148)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 23)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Warehouse ID"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCountedWarehouseID
        '
        Me.txtCountedWarehouseID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCountedWarehouseID.Location = New System.Drawing.Point(185, 151)
        Me.txtCountedWarehouseID.Name = "txtCountedWarehouseID"
        Me.txtCountedWarehouseID.ReadOnly = True
        Me.txtCountedWarehouseID.Size = New System.Drawing.Size(149, 20)
        Me.txtCountedWarehouseID.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(38, 177)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(131, 23)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Quantity"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(38, 125)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(131, 23)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Part Number"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCountedQuantity
        '
        Me.txtCountedQuantity.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCountedQuantity.Location = New System.Drawing.Point(185, 180)
        Me.txtCountedQuantity.Name = "txtCountedQuantity"
        Me.txtCountedQuantity.Size = New System.Drawing.Size(149, 20)
        Me.txtCountedQuantity.TabIndex = 2
        '
        'txtCountedPartNumber
        '
        Me.txtCountedPartNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCountedPartNumber.Location = New System.Drawing.Point(185, 128)
        Me.txtCountedPartNumber.Name = "txtCountedPartNumber"
        Me.txtCountedPartNumber.Size = New System.Drawing.Size(149, 20)
        Me.txtCountedPartNumber.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(352, 248)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(131, 23)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "Date"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAdjustInventoryDate
        '
        Me.txtAdjustInventoryDate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAdjustInventoryDate.Location = New System.Drawing.Point(489, 248)
        Me.txtAdjustInventoryDate.Name = "txtAdjustInventoryDate"
        Me.txtAdjustInventoryDate.ReadOnly = True
        Me.txtAdjustInventoryDate.Size = New System.Drawing.Size(149, 20)
        Me.txtAdjustInventoryDate.TabIndex = 11
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(352, 415)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(131, 23)
        Me.Label13.TabIndex = 35
        Me.Label13.Text = "WarehouseID"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAdjustInventoryWarehouseID
        '
        Me.txtAdjustInventoryWarehouseID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAdjustInventoryWarehouseID.Location = New System.Drawing.Point(489, 415)
        Me.txtAdjustInventoryWarehouseID.Name = "txtAdjustInventoryWarehouseID"
        Me.txtAdjustInventoryWarehouseID.ReadOnly = True
        Me.txtAdjustInventoryWarehouseID.Size = New System.Drawing.Size(149, 20)
        Me.txtAdjustInventoryWarehouseID.TabIndex = 34
        '
        'AdjustInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(849, 466)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtAdjustInventoryWarehouseID)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtAdjustInventoryDate)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtCountedWarehouseID)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtCountedQuantity)
        Me.Controls.Add(Me.txtCountedPartNumber)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtInventoryWarehouseID)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnCompareCount)
        Me.Controls.Add(Me.btnUpdateInventory)
        Me.Controls.Add(Me.btnAdminMenu)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtInventoryQuantity)
        Me.Controls.Add(Me.txtInventoryPartNumber)
        Me.Controls.Add(Me.cboPartID)
        Me.Controls.Add(Me.txtAdjustInventoryReason)
        Me.Controls.Add(Me.txtAdjustInventoryQuantity)
        Me.Controls.Add(Me.txtAdjustInventoryEmployeeID)
        Me.Controls.Add(Me.txtAdjustInventoryPartNumber)
        Me.Controls.Add(Me.cboAdjustInventoryTransactionID)
        Me.Name = "AdjustInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdjustInventory"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboAdjustInventoryTransactionID As System.Windows.Forms.ComboBox
    Friend WithEvents txtAdjustInventoryPartNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtAdjustInventoryEmployeeID As System.Windows.Forms.TextBox
    Friend WithEvents txtAdjustInventoryQuantity As System.Windows.Forms.TextBox
    Friend WithEvents txtAdjustInventoryReason As System.Windows.Forms.TextBox
    Friend WithEvents txtInventoryQuantity As System.Windows.Forms.TextBox
    Friend WithEvents txtInventoryPartNumber As System.Windows.Forms.TextBox
    Friend WithEvents cboPartID As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnMainMenu As System.Windows.Forms.Button
    Friend WithEvents btnAdminMenu As System.Windows.Forms.Button
    Friend WithEvents btnUpdateInventory As System.Windows.Forms.Button
    Friend WithEvents btnCompareCount As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtInventoryWarehouseID As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCountedWarehouseID As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtCountedQuantity As System.Windows.Forms.TextBox
    Friend WithEvents txtCountedPartNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtAdjustInventoryDate As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtAdjustInventoryWarehouseID As System.Windows.Forms.TextBox
End Class
