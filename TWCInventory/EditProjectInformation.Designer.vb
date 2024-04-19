<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditProjectInformation
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
        Me.txtProjectID = New System.Windows.Forms.TextBox()
        Me.cboTransactionID = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'txtMSRNumber
        '
        Me.txtMSRNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMSRNumber.Location = New System.Drawing.Point(13, 94)
        Me.txtMSRNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMSRNumber.Name = "txtMSRNumber"
        Me.txtMSRNumber.Size = New System.Drawing.Size(160, 22)
        Me.txtMSRNumber.TabIndex = 46
        '
        'txtProjectID
        '
        Me.txtProjectID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProjectID.Location = New System.Drawing.Point(13, 62)
        Me.txtProjectID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProjectID.Name = "txtProjectID"
        Me.txtProjectID.Size = New System.Drawing.Size(160, 22)
        Me.txtProjectID.TabIndex = 45
        '
        'cboTransactionID
        '
        Me.cboTransactionID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTransactionID.FormattingEnabled = True
        Me.cboTransactionID.Location = New System.Drawing.Point(13, 30)
        Me.cboTransactionID.Margin = New System.Windows.Forms.Padding(4)
        Me.cboTransactionID.Name = "cboTransactionID"
        Me.cboTransactionID.Size = New System.Drawing.Size(160, 24)
        Me.cboTransactionID.TabIndex = 43
        '
        'EditProjectInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(210, 143)
        Me.Controls.Add(Me.txtMSRNumber)
        Me.Controls.Add(Me.txtProjectID)
        Me.Controls.Add(Me.cboTransactionID)
        Me.Name = "EditProjectInformation"
        Me.Text = "EditProjectInformation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMSRNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtProjectID As System.Windows.Forms.TextBox
    Friend WithEvents cboTransactionID As System.Windows.Forms.ComboBox
End Class
