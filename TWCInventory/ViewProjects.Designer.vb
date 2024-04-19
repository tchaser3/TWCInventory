<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewProjects
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
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnCreateProjects = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnProjectPartReport = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnMainMenu
        '
        Me.btnMainMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMainMenu.Location = New System.Drawing.Point(16, 200)
        Me.btnMainMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(203, 76)
        Me.btnMainMenu.TabIndex = 2
        Me.btnMainMenu.Text = "Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(248, 200)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(203, 76)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnCreateProjects
        '
        Me.btnCreateProjects.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateProjects.Location = New System.Drawing.Point(16, 101)
        Me.btnCreateProjects.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCreateProjects.Name = "btnCreateProjects"
        Me.btnCreateProjects.Size = New System.Drawing.Size(203, 76)
        Me.btnCreateProjects.TabIndex = 0
        Me.btnCreateProjects.Text = "View/Create Projects"
        Me.btnCreateProjects.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(439, 58)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Project Information"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnProjectPartReport
        '
        Me.btnProjectPartReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProjectPartReport.Location = New System.Drawing.Point(248, 101)
        Me.btnProjectPartReport.Margin = New System.Windows.Forms.Padding(4)
        Me.btnProjectPartReport.Name = "btnProjectPartReport"
        Me.btnProjectPartReport.Size = New System.Drawing.Size(203, 76)
        Me.btnProjectPartReport.TabIndex = 1
        Me.btnProjectPartReport.Text = "Project Part Report"
        Me.btnProjectPartReport.UseVisualStyleBackColor = True
        '
        'ViewProjects
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 308)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnProjectPartReport)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCreateProjects)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.btnClose)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ViewProjects"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ViewProjects"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnMainMenu As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnCreateProjects As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnProjectPartReport As System.Windows.Forms.Button
End Class
