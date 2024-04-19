<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnViewInventory = New System.Windows.Forms.Button()
        Me.btnReceiveInventory = New System.Windows.Forms.Button()
        Me.btnIssueInventory = New System.Windows.Forms.Button()
        Me.btnViewProjects = New System.Windows.Forms.Button()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.btnAdminMenu = New System.Windows.Forms.Button()
        Me.btnUseInventory = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(378, 268)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(171, 86)
        Me.btnClose.TabIndex = 8
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(537, 55)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Time Warner Inventory Program"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnViewInventory
        '
        Me.btnViewInventory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewInventory.Location = New System.Drawing.Point(8, 176)
        Me.btnViewInventory.Name = "btnViewInventory"
        Me.btnViewInventory.Size = New System.Drawing.Size(171, 86)
        Me.btnViewInventory.TabIndex = 3
        Me.btnViewInventory.Text = "View Inventory"
        Me.btnViewInventory.UseVisualStyleBackColor = True
        '
        'btnReceiveInventory
        '
        Me.btnReceiveInventory.Enabled = False
        Me.btnReceiveInventory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReceiveInventory.Location = New System.Drawing.Point(8, 84)
        Me.btnReceiveInventory.Name = "btnReceiveInventory"
        Me.btnReceiveInventory.Size = New System.Drawing.Size(171, 86)
        Me.btnReceiveInventory.TabIndex = 0
        Me.btnReceiveInventory.Text = "Receive Inventory"
        Me.btnReceiveInventory.UseVisualStyleBackColor = True
        '
        'btnIssueInventory
        '
        Me.btnIssueInventory.Enabled = False
        Me.btnIssueInventory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIssueInventory.Location = New System.Drawing.Point(192, 84)
        Me.btnIssueInventory.Name = "btnIssueInventory"
        Me.btnIssueInventory.Size = New System.Drawing.Size(171, 86)
        Me.btnIssueInventory.TabIndex = 1
        Me.btnIssueInventory.Text = "Issue Inventory"
        Me.btnIssueInventory.UseVisualStyleBackColor = True
        '
        'btnViewProjects
        '
        Me.btnViewProjects.Enabled = False
        Me.btnViewProjects.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewProjects.Location = New System.Drawing.Point(192, 176)
        Me.btnViewProjects.Name = "btnViewProjects"
        Me.btnViewProjects.Size = New System.Drawing.Size(171, 86)
        Me.btnViewProjects.TabIndex = 4
        Me.btnViewProjects.Text = "View Projects"
        Me.btnViewProjects.UseVisualStyleBackColor = True
        '
        'btnReports
        '
        Me.btnReports.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReports.Location = New System.Drawing.Point(378, 176)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(171, 86)
        Me.btnReports.TabIndex = 5
        Me.btnReports.Text = "Reports"
        Me.btnReports.UseVisualStyleBackColor = True
        '
        'btnAbout
        '
        Me.btnAbout.Enabled = False
        Me.btnAbout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbout.Location = New System.Drawing.Point(192, 268)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(171, 86)
        Me.btnAbout.TabIndex = 7
        Me.btnAbout.Text = "About"
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'btnAdminMenu
        '
        Me.btnAdminMenu.Enabled = False
        Me.btnAdminMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdminMenu.Location = New System.Drawing.Point(8, 268)
        Me.btnAdminMenu.Name = "btnAdminMenu"
        Me.btnAdminMenu.Size = New System.Drawing.Size(171, 86)
        Me.btnAdminMenu.TabIndex = 6
        Me.btnAdminMenu.Text = "Administrative Menu"
        Me.btnAdminMenu.UseVisualStyleBackColor = True
        '
        'btnUseInventory
        '
        Me.btnUseInventory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUseInventory.Location = New System.Drawing.Point(378, 84)
        Me.btnUseInventory.Name = "btnUseInventory"
        Me.btnUseInventory.Size = New System.Drawing.Size(171, 86)
        Me.btnUseInventory.TabIndex = 2
        Me.btnUseInventory.Text = "Use Inventory"
        Me.btnUseInventory.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 370)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnUseInventory)
        Me.Controls.Add(Me.btnAdminMenu)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.btnReports)
        Me.Controls.Add(Me.btnViewProjects)
        Me.Controls.Add(Me.btnIssueInventory)
        Me.Controls.Add(Me.btnReceiveInventory)
        Me.Controls.Add(Me.btnViewInventory)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClose)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnViewInventory As System.Windows.Forms.Button
    Friend WithEvents btnReceiveInventory As System.Windows.Forms.Button
    Friend WithEvents btnIssueInventory As System.Windows.Forms.Button
    Friend WithEvents btnViewProjects As System.Windows.Forms.Button
    Friend WithEvents btnReports As System.Windows.Forms.Button
    Friend WithEvents btnAbout As System.Windows.Forms.Button
    Friend WithEvents btnAdminMenu As System.Windows.Forms.Button
    Friend WithEvents btnUseInventory As System.Windows.Forms.Button

End Class
