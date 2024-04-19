<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerifyPickListInformation
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
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.txtOrderIssued = New System.Windows.Forms.TextBox()
        Me.txtProjectID = New System.Windows.Forms.TextBox()
        Me.cboPickListID = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'txtMSRNumber
        '
        Me.txtMSRNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMSRNumber.Location = New System.Drawing.Point(43, 148)
        Me.txtMSRNumber.Name = "txtMSRNumber"
        Me.txtMSRNumber.ReadOnly = True
        Me.txtMSRNumber.Size = New System.Drawing.Size(121, 20)
        Me.txtMSRNumber.TabIndex = 56
        '
        'txtDate
        '
        Me.txtDate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDate.Location = New System.Drawing.Point(43, 94)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.ReadOnly = True
        Me.txtDate.Size = New System.Drawing.Size(121, 20)
        Me.txtDate.TabIndex = 55
        '
        'txtOrderIssued
        '
        Me.txtOrderIssued.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOrderIssued.Location = New System.Drawing.Point(43, 122)
        Me.txtOrderIssued.Name = "txtOrderIssued"
        Me.txtOrderIssued.ReadOnly = True
        Me.txtOrderIssued.Size = New System.Drawing.Size(121, 20)
        Me.txtOrderIssued.TabIndex = 54
        '
        'txtProjectID
        '
        Me.txtProjectID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProjectID.Location = New System.Drawing.Point(43, 68)
        Me.txtProjectID.Name = "txtProjectID"
        Me.txtProjectID.ReadOnly = True
        Me.txtProjectID.Size = New System.Drawing.Size(121, 20)
        Me.txtProjectID.TabIndex = 53
        '
        'cboPickListID
        '
        Me.cboPickListID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPickListID.FormattingEnabled = True
        Me.cboPickListID.Location = New System.Drawing.Point(43, 41)
        Me.cboPickListID.Name = "cboPickListID"
        Me.cboPickListID.Size = New System.Drawing.Size(121, 21)
        Me.cboPickListID.TabIndex = 52
        '
        'VerifyPickListInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(201, 232)
        Me.Controls.Add(Me.txtMSRNumber)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.txtOrderIssued)
        Me.Controls.Add(Me.txtProjectID)
        Me.Controls.Add(Me.cboPickListID)
        Me.Name = "VerifyPickListInformation"
        Me.Text = "VerifyPickListInformation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMSRNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtDate As System.Windows.Forms.TextBox
    Friend WithEvents txtOrderIssued As System.Windows.Forms.TextBox
    Friend WithEvents txtProjectID As System.Windows.Forms.TextBox
    Friend WithEvents cboPickListID As System.Windows.Forms.ComboBox
End Class
