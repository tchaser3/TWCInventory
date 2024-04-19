<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FindMSRProjectID
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
        Me.txtMSRNumber = New System.Windows.Forms.TextBox()
        Me.txtTWCProjectID = New System.Windows.Forms.TextBox()
        Me.cboInternalProjectID = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'txtMSRNumber
        '
        Me.txtMSRNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMSRNumber.Location = New System.Drawing.Point(24, 106)
        Me.txtMSRNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMSRNumber.Name = "txtMSRNumber"
        Me.txtMSRNumber.ReadOnly = True
        Me.txtMSRNumber.Size = New System.Drawing.Size(160, 22)
        Me.txtMSRNumber.TabIndex = 106
        '
        'txtTWCProjectID
        '
        Me.txtTWCProjectID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTWCProjectID.Location = New System.Drawing.Point(24, 66)
        Me.txtTWCProjectID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTWCProjectID.Multiline = True
        Me.txtTWCProjectID.Name = "txtTWCProjectID"
        Me.txtTWCProjectID.ReadOnly = True
        Me.txtTWCProjectID.Size = New System.Drawing.Size(160, 32)
        Me.txtTWCProjectID.TabIndex = 105
        '
        'cboInternalProjectID
        '
        Me.cboInternalProjectID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboInternalProjectID.FormattingEnabled = True
        Me.cboInternalProjectID.Location = New System.Drawing.Point(24, 32)
        Me.cboInternalProjectID.Margin = New System.Windows.Forms.Padding(4)
        Me.cboInternalProjectID.Name = "cboInternalProjectID"
        Me.cboInternalProjectID.Size = New System.Drawing.Size(160, 24)
        Me.cboInternalProjectID.TabIndex = 104
        '
        'FindMSRProjectID
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(236, 163)
        Me.Controls.Add(Me.txtMSRNumber)
        Me.Controls.Add(Me.txtTWCProjectID)
        Me.Controls.Add(Me.cboInternalProjectID)
        Me.Name = "FindMSRProjectID"
        Me.Text = "FindMSRProjectID"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMSRNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtTWCProjectID As System.Windows.Forms.TextBox
    Friend WithEvents cboInternalProjectID As System.Windows.Forms.ComboBox
End Class
