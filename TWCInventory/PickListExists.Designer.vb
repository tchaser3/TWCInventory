<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PickListExists
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
        Me.lblMessageToUser = New System.Windows.Forms.Label()
        Me.btnNo = New System.Windows.Forms.Button()
        Me.btnYes = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblMessageToUser
        '
        Me.lblMessageToUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessageToUser.Location = New System.Drawing.Point(12, 9)
        Me.lblMessageToUser.Name = "lblMessageToUser"
        Me.lblMessageToUser.Size = New System.Drawing.Size(334, 115)
        Me.lblMessageToUser.TabIndex = 27
        Me.lblMessageToUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnNo
        '
        Me.btnNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNo.Location = New System.Drawing.Point(194, 138)
        Me.btnNo.Name = "btnNo"
        Me.btnNo.Size = New System.Drawing.Size(152, 62)
        Me.btnNo.TabIndex = 28
        Me.btnNo.Text = "No"
        Me.btnNo.UseVisualStyleBackColor = True
        '
        'btnYes
        '
        Me.btnYes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnYes.Location = New System.Drawing.Point(12, 138)
        Me.btnYes.Name = "btnYes"
        Me.btnYes.Size = New System.Drawing.Size(152, 62)
        Me.btnYes.TabIndex = 29
        Me.btnYes.Text = "Yes"
        Me.btnYes.UseVisualStyleBackColor = True
        '
        'PickListExists
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(358, 221)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnYes)
        Me.Controls.Add(Me.btnNo)
        Me.Controls.Add(Me.lblMessageToUser)
        Me.Name = "PickListExists"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PickListExists"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblMessageToUser As System.Windows.Forms.Label
    Friend WithEvents btnNo As System.Windows.Forms.Button
    Friend WithEvents btnYes As System.Windows.Forms.Button
End Class
