<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ValidateProjectID
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtProjectName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtProjectID = New System.Windows.Forms.TextBox()
        Me.cboTransactionID = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMSRNumber = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(35, 170)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 26)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Project Name"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtProjectName
        '
        Me.txtProjectName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProjectName.Location = New System.Drawing.Point(176, 123)
        Me.txtProjectName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtProjectName.Multiline = True
        Me.txtProjectName.Name = "txtProjectName"
        Me.txtProjectName.ReadOnly = True
        Me.txtProjectName.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtProjectName.Size = New System.Drawing.Size(160, 120)
        Me.txtProjectName.TabIndex = 38
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 91)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 26)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Project ID"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(35, 55)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 26)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Transaction ID"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtProjectID
        '
        Me.txtProjectID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProjectID.Location = New System.Drawing.Point(176, 91)
        Me.txtProjectID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtProjectID.Name = "txtProjectID"
        Me.txtProjectID.ReadOnly = True
        Me.txtProjectID.Size = New System.Drawing.Size(160, 22)
        Me.txtProjectID.TabIndex = 37
        '
        'cboTransactionID
        '
        Me.cboTransactionID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTransactionID.FormattingEnabled = True
        Me.cboTransactionID.Location = New System.Drawing.Point(176, 57)
        Me.cboTransactionID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboTransactionID.Name = "cboTransactionID"
        Me.cboTransactionID.Size = New System.Drawing.Size(160, 24)
        Me.cboTransactionID.TabIndex = 39
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 251)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 26)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "MSR Number"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMSRNumber
        '
        Me.txtMSRNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMSRNumber.Location = New System.Drawing.Point(176, 251)
        Me.txtMSRNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMSRNumber.Name = "txtMSRNumber"
        Me.txtMSRNumber.ReadOnly = True
        Me.txtMSRNumber.Size = New System.Drawing.Size(160, 22)
        Me.txtMSRNumber.TabIndex = 43
        '
        'ValidateProjectID
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 337)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMSRNumber)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtProjectName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtProjectID)
        Me.Controls.Add(Me.cboTransactionID)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "ValidateProjectID"
        Me.Text = "ValidateProjectID"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtProjectName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtProjectID As System.Windows.Forms.TextBox
    Friend WithEvents cboTransactionID As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMSRNumber As System.Windows.Forms.TextBox
End Class
