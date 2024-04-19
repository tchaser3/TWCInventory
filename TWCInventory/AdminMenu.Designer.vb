<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminMenu
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnChangeWarehouse = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.btnAdjustInventory = New System.Windows.Forms.Button()
        Me.btnCreateCycleCount = New System.Windows.Forms.Button()
        Me.btnAddPartToInventory = New System.Windows.Forms.Button()
        Me.btnReturnPartsToStock = New System.Windows.Forms.Button()
        Me.btnReturnPartsToVendor = New System.Windows.Forms.Button()
        Me.btnStockAdjustmentDateReport = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(641, 68)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Administrative Menu"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnChangeWarehouse
        '
        Me.btnChangeWarehouse.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangeWarehouse.Location = New System.Drawing.Point(13, 289)
        Me.btnChangeWarehouse.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnChangeWarehouse.Name = "btnChangeWarehouse"
        Me.btnChangeWarehouse.Size = New System.Drawing.Size(196, 76)
        Me.btnChangeWarehouse.TabIndex = 6
        Me.btnChangeWarehouse.Text = "Change Warehouse"
        Me.btnChangeWarehouse.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(461, 289)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(196, 76)
        Me.btnClose.TabIndex = 8
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnMainMenu
        '
        Me.btnMainMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMainMenu.Location = New System.Drawing.Point(236, 289)
        Me.btnMainMenu.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(199, 76)
        Me.btnMainMenu.TabIndex = 7
        Me.btnMainMenu.Text = "Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = True
        '
        'btnAdjustInventory
        '
        Me.btnAdjustInventory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdjustInventory.Location = New System.Drawing.Point(13, 121)
        Me.btnAdjustInventory.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAdjustInventory.Name = "btnAdjustInventory"
        Me.btnAdjustInventory.Size = New System.Drawing.Size(196, 76)
        Me.btnAdjustInventory.TabIndex = 0
        Me.btnAdjustInventory.Text = "Compare/Update Inventory"
        Me.btnAdjustInventory.UseVisualStyleBackColor = True
        '
        'btnCreateCycleCount
        '
        Me.btnCreateCycleCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateCycleCount.Location = New System.Drawing.Point(13, 205)
        Me.btnCreateCycleCount.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCreateCycleCount.Name = "btnCreateCycleCount"
        Me.btnCreateCycleCount.Size = New System.Drawing.Size(196, 76)
        Me.btnCreateCycleCount.TabIndex = 3
        Me.btnCreateCycleCount.Text = "Create Cycle Count Tickets"
        Me.btnCreateCycleCount.UseVisualStyleBackColor = True
        '
        'btnAddPartToInventory
        '
        Me.btnAddPartToInventory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddPartToInventory.Location = New System.Drawing.Point(236, 121)
        Me.btnAddPartToInventory.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAddPartToInventory.Name = "btnAddPartToInventory"
        Me.btnAddPartToInventory.Size = New System.Drawing.Size(199, 76)
        Me.btnAddPartToInventory.TabIndex = 1
        Me.btnAddPartToInventory.Text = "Add Part to Inventory"
        Me.btnAddPartToInventory.UseVisualStyleBackColor = True
        '
        'btnReturnPartsToStock
        '
        Me.btnReturnPartsToStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturnPartsToStock.Location = New System.Drawing.Point(236, 205)
        Me.btnReturnPartsToStock.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnReturnPartsToStock.Name = "btnReturnPartsToStock"
        Me.btnReturnPartsToStock.Size = New System.Drawing.Size(199, 76)
        Me.btnReturnPartsToStock.TabIndex = 4
        Me.btnReturnPartsToStock.Text = "Return Parts To Stock"
        Me.btnReturnPartsToStock.UseVisualStyleBackColor = True
        '
        'btnReturnPartsToVendor
        '
        Me.btnReturnPartsToVendor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturnPartsToVendor.Location = New System.Drawing.Point(461, 119)
        Me.btnReturnPartsToVendor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnReturnPartsToVendor.Name = "btnReturnPartsToVendor"
        Me.btnReturnPartsToVendor.Size = New System.Drawing.Size(196, 78)
        Me.btnReturnPartsToVendor.TabIndex = 2
        Me.btnReturnPartsToVendor.Text = "Return Parts To Vendor"
        Me.btnReturnPartsToVendor.UseVisualStyleBackColor = True
        '
        'btnStockAdjustmentDateReport
        '
        Me.btnStockAdjustmentDateReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStockAdjustmentDateReport.Location = New System.Drawing.Point(461, 205)
        Me.btnStockAdjustmentDateReport.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnStockAdjustmentDateReport.Name = "btnStockAdjustmentDateReport"
        Me.btnStockAdjustmentDateReport.Size = New System.Drawing.Size(196, 76)
        Me.btnStockAdjustmentDateReport.TabIndex = 5
        Me.btnStockAdjustmentDateReport.Text = "Stock Adjustment Date Report"
        Me.btnStockAdjustmentDateReport.UseVisualStyleBackColor = True
        '
        'AdminMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(677, 389)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnStockAdjustmentDateReport)
        Me.Controls.Add(Me.btnReturnPartsToVendor)
        Me.Controls.Add(Me.btnReturnPartsToStock)
        Me.Controls.Add(Me.btnAddPartToInventory)
        Me.Controls.Add(Me.btnCreateCycleCount)
        Me.Controls.Add(Me.btnAdjustInventory)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.btnChangeWarehouse)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "AdminMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdminMenu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnChangeWarehouse As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnMainMenu As System.Windows.Forms.Button
    Friend WithEvents btnAdjustInventory As System.Windows.Forms.Button
    Friend WithEvents btnCreateCycleCount As System.Windows.Forms.Button
    Friend WithEvents btnAddPartToInventory As System.Windows.Forms.Button
    Friend WithEvents btnReturnPartsToStock As System.Windows.Forms.Button
    Friend WithEvents btnReturnPartsToVendor As System.Windows.Forms.Button
    Friend WithEvents btnStockAdjustmentDateReport As System.Windows.Forms.Button
End Class
