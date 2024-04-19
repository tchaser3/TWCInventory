<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewWarehouseInventory
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
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.btnViewInventoryMenu = New System.Windows.Forms.Button()
        Me.btnRunReport = New System.Windows.Forms.Button()
        Me.txtWarehouseID = New System.Windows.Forms.TextBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.txtPartNumber = New System.Windows.Forms.TextBox()
        Me.cboPartID = New System.Windows.Forms.ComboBox()
        Me.txtPartDescription = New System.Windows.Forms.TextBox()
        Me.dgvSearchResults = New System.Windows.Forms.DataGridView()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        CType(Me.dgvSearchResults, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 24)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(869, 52)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "View Warehouse Inventory"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(679, 390)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(203, 76)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnMainMenu
        '
        Me.btnMainMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMainMenu.Location = New System.Drawing.Point(679, 306)
        Me.btnMainMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(203, 76)
        Me.btnMainMenu.TabIndex = 7
        Me.btnMainMenu.Text = "Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = True
        '
        'btnViewInventoryMenu
        '
        Me.btnViewInventoryMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewInventoryMenu.Location = New System.Drawing.Point(679, 222)
        Me.btnViewInventoryMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.btnViewInventoryMenu.Name = "btnViewInventoryMenu"
        Me.btnViewInventoryMenu.Size = New System.Drawing.Size(203, 76)
        Me.btnViewInventoryMenu.TabIndex = 8
        Me.btnViewInventoryMenu.Text = "View Inventory Menu"
        Me.btnViewInventoryMenu.UseVisualStyleBackColor = True
        '
        'btnRunReport
        '
        Me.btnRunReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRunReport.Location = New System.Drawing.Point(679, 138)
        Me.btnRunReport.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRunReport.Name = "btnRunReport"
        Me.btnRunReport.Size = New System.Drawing.Size(203, 76)
        Me.btnRunReport.TabIndex = 9
        Me.btnRunReport.Text = "Run Report"
        Me.btnRunReport.UseVisualStyleBackColor = True
        '
        'txtWarehouseID
        '
        Me.txtWarehouseID.Location = New System.Drawing.Point(367, 344)
        Me.txtWarehouseID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtWarehouseID.Name = "txtWarehouseID"
        Me.txtWarehouseID.ReadOnly = True
        Me.txtWarehouseID.Size = New System.Drawing.Size(160, 22)
        Me.txtWarehouseID.TabIndex = 25
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(367, 301)
        Me.txtQuantity.Margin = New System.Windows.Forms.Padding(4)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.ReadOnly = True
        Me.txtQuantity.Size = New System.Drawing.Size(160, 22)
        Me.txtQuantity.TabIndex = 24
        '
        'txtPartNumber
        '
        Me.txtPartNumber.Location = New System.Drawing.Point(367, 161)
        Me.txtPartNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPartNumber.Name = "txtPartNumber"
        Me.txtPartNumber.ReadOnly = True
        Me.txtPartNumber.Size = New System.Drawing.Size(160, 22)
        Me.txtPartNumber.TabIndex = 22
        '
        'cboPartID
        '
        Me.cboPartID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPartID.FormattingEnabled = True
        Me.cboPartID.Location = New System.Drawing.Point(367, 126)
        Me.cboPartID.Margin = New System.Windows.Forms.Padding(4)
        Me.cboPartID.Name = "cboPartID"
        Me.cboPartID.Size = New System.Drawing.Size(160, 24)
        Me.cboPartID.TabIndex = 21
        '
        'txtPartDescription
        '
        Me.txtPartDescription.Location = New System.Drawing.Point(367, 193)
        Me.txtPartDescription.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPartDescription.Multiline = True
        Me.txtPartDescription.Name = "txtPartDescription"
        Me.txtPartDescription.ReadOnly = True
        Me.txtPartDescription.Size = New System.Drawing.Size(160, 100)
        Me.txtPartDescription.TabIndex = 23
        '
        'dgvSearchResults
        '
        Me.dgvSearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSearchResults.Location = New System.Drawing.Point(12, 79)
        Me.dgvSearchResults.Name = "dgvSearchResults"
        Me.dgvSearchResults.RowTemplate.Height = 24
        Me.dgvSearchResults.Size = New System.Drawing.Size(660, 401)
        Me.dgvSearchResults.TabIndex = 26
        '
        'PrintDocument1
        '
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'ViewWarehouseInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(895, 492)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgvSearchResults)
        Me.Controls.Add(Me.txtWarehouseID)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.txtPartDescription)
        Me.Controls.Add(Me.txtPartNumber)
        Me.Controls.Add(Me.cboPartID)
        Me.Controls.Add(Me.btnRunReport)
        Me.Controls.Add(Me.btnViewInventoryMenu)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ViewWarehouseInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ViewWarehouseInventory"
        CType(Me.dgvSearchResults, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnMainMenu As System.Windows.Forms.Button
    Friend WithEvents btnViewInventoryMenu As System.Windows.Forms.Button
    Friend WithEvents btnRunReport As System.Windows.Forms.Button
    Friend WithEvents txtWarehouseID As System.Windows.Forms.TextBox
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents txtPartNumber As System.Windows.Forms.TextBox
    Friend WithEvents cboPartID As System.Windows.Forms.ComboBox
    Friend WithEvents txtPartDescription As System.Windows.Forms.TextBox
    Friend WithEvents dgvSearchResults As System.Windows.Forms.DataGridView
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
End Class
