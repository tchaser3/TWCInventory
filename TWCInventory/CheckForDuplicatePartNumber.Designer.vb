<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckForDuplicatePartNumber
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
        Me.txtPartNumber = New System.Windows.Forms.TextBox()
        Me.cboPartID = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'txtPartNumber
        '
        Me.txtPartNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPartNumber.Location = New System.Drawing.Point(25, 68)
        Me.txtPartNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPartNumber.Name = "txtPartNumber"
        Me.txtPartNumber.Size = New System.Drawing.Size(160, 22)
        Me.txtPartNumber.TabIndex = 4
        '
        'cboPartID
        '
        Me.cboPartID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPartID.FormattingEnabled = True
        Me.cboPartID.Location = New System.Drawing.Point(25, 34)
        Me.cboPartID.Margin = New System.Windows.Forms.Padding(4)
        Me.cboPartID.Name = "cboPartID"
        Me.cboPartID.Size = New System.Drawing.Size(160, 24)
        Me.cboPartID.TabIndex = 3
        '
        'CheckForDuplicatePartNumber
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(214, 121)
        Me.Controls.Add(Me.txtPartNumber)
        Me.Controls.Add(Me.cboPartID)
        Me.Name = "CheckForDuplicatePartNumber"
        Me.Text = "CheckForDuplicatePartNumber"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPartNumber As System.Windows.Forms.TextBox
    Friend WithEvents cboPartID As System.Windows.Forms.ComboBox
End Class
