<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddPartNumberToInventory
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
        Me.txtQTYResponible = New System.Windows.Forms.TextBox()
        Me.txtPartDescription = New System.Windows.Forms.TextBox()
        Me.txtPartNumber = New System.Windows.Forms.TextBox()
        Me.cboPartID = New System.Windows.Forms.ComboBox()
        Me.txtWarehouseID = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtQTYResponible
        '
        Me.txtQTYResponible.Location = New System.Drawing.Point(31, 164)
        Me.txtQTYResponible.Name = "txtQTYResponible"
        Me.txtQTYResponible.ReadOnly = True
        Me.txtQTYResponible.Size = New System.Drawing.Size(121, 20)
        Me.txtQTYResponible.TabIndex = 19
        '
        'txtPartDescription
        '
        Me.txtPartDescription.Location = New System.Drawing.Point(31, 76)
        Me.txtPartDescription.Multiline = True
        Me.txtPartDescription.Name = "txtPartDescription"
        Me.txtPartDescription.ReadOnly = True
        Me.txtPartDescription.Size = New System.Drawing.Size(121, 82)
        Me.txtPartDescription.TabIndex = 18
        '
        'txtPartNumber
        '
        Me.txtPartNumber.Location = New System.Drawing.Point(31, 50)
        Me.txtPartNumber.Name = "txtPartNumber"
        Me.txtPartNumber.ReadOnly = True
        Me.txtPartNumber.Size = New System.Drawing.Size(121, 20)
        Me.txtPartNumber.TabIndex = 17
        '
        'cboPartID
        '
        Me.cboPartID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPartID.FormattingEnabled = True
        Me.cboPartID.Location = New System.Drawing.Point(31, 22)
        Me.cboPartID.Name = "cboPartID"
        Me.cboPartID.Size = New System.Drawing.Size(121, 21)
        Me.cboPartID.TabIndex = 16
        '
        'txtWarehouseID
        '
        Me.txtWarehouseID.Location = New System.Drawing.Point(31, 199)
        Me.txtWarehouseID.Name = "txtWarehouseID"
        Me.txtWarehouseID.ReadOnly = True
        Me.txtWarehouseID.Size = New System.Drawing.Size(121, 20)
        Me.txtWarehouseID.TabIndex = 20
        '
        'AddPartNumberToInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(193, 265)
        Me.Controls.Add(Me.txtWarehouseID)
        Me.Controls.Add(Me.txtQTYResponible)
        Me.Controls.Add(Me.txtPartDescription)
        Me.Controls.Add(Me.txtPartNumber)
        Me.Controls.Add(Me.cboPartID)
        Me.Name = "AddPartNumberToInventory"
        Me.Text = "AddPartNumberToInventory"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtQTYResponible As System.Windows.Forms.TextBox
    Friend WithEvents txtPartDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtPartNumber As System.Windows.Forms.TextBox
    Friend WithEvents cboPartID As System.Windows.Forms.ComboBox
    Friend WithEvents txtWarehouseID As System.Windows.Forms.TextBox
End Class
