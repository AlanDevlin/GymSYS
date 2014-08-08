<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainMenu
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
        Me.btnMembershipTypes = New System.Windows.Forms.Button()
        Me.btnMembers = New System.Windows.Forms.Button()
        Me.btnPurchases = New System.Windows.Forms.Button()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.txtboxMainMenu = New System.Windows.Forms.RichTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnExitMainMenu = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnMembershipTypes
        '
        Me.btnMembershipTypes.AccessibleDescription = "btnMembershipTypes"
        Me.btnMembershipTypes.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnMembershipTypes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMembershipTypes.Location = New System.Drawing.Point(343, 97)
        Me.btnMembershipTypes.Name = "btnMembershipTypes"
        Me.btnMembershipTypes.Size = New System.Drawing.Size(120, 47)
        Me.btnMembershipTypes.TabIndex = 1
        Me.btnMembershipTypes.Text = "Membership Types"
        Me.btnMembershipTypes.UseVisualStyleBackColor = False
        '
        'btnMembers
        '
        Me.btnMembers.AccessibleDescription = "btnMembers"
        Me.btnMembers.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnMembers.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMembers.Location = New System.Drawing.Point(343, 159)
        Me.btnMembers.Name = "btnMembers"
        Me.btnMembers.Size = New System.Drawing.Size(120, 47)
        Me.btnMembers.TabIndex = 2
        Me.btnMembers.Text = "Members"
        Me.btnMembers.UseVisualStyleBackColor = False
        '
        'btnPurchases
        '
        Me.btnPurchases.AccessibleDescription = "btnPurchases"
        Me.btnPurchases.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnPurchases.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPurchases.Location = New System.Drawing.Point(343, 228)
        Me.btnPurchases.Name = "btnPurchases"
        Me.btnPurchases.Size = New System.Drawing.Size(120, 47)
        Me.btnPurchases.TabIndex = 3
        Me.btnPurchases.Text = "Purchases"
        Me.btnPurchases.UseVisualStyleBackColor = False
        '
        'btnReports
        '
        Me.btnReports.AccessibleDescription = "btnReports"
        Me.btnReports.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnReports.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReports.Location = New System.Drawing.Point(343, 292)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(120, 47)
        Me.btnReports.TabIndex = 4
        Me.btnReports.Text = "Reports"
        Me.btnReports.UseVisualStyleBackColor = False
        '
        'txtboxMainMenu
        '
        Me.txtboxMainMenu.AccessibleDescription = "txtboxMainMenu"
        Me.txtboxMainMenu.BackColor = System.Drawing.SystemColors.Control
        Me.txtboxMainMenu.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtboxMainMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxMainMenu.Location = New System.Drawing.Point(12, 12)
        Me.txtboxMainMenu.Name = "txtboxMainMenu"
        Me.txtboxMainMenu.Size = New System.Drawing.Size(365, 30)
        Me.txtboxMainMenu.TabIndex = 5
        Me.txtboxMainMenu.Text = "Choose one of the following:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.GymSYS.My.Resources.Resources.MainMenu
        Me.PictureBox1.Location = New System.Drawing.Point(26, 97)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(261, 199)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'btnExitMainMenu
        '
        Me.btnExitMainMenu.ForeColor = System.Drawing.Color.Red
        Me.btnExitMainMenu.Location = New System.Drawing.Point(402, 390)
        Me.btnExitMainMenu.Name = "btnExitMainMenu"
        Me.btnExitMainMenu.Size = New System.Drawing.Size(75, 23)
        Me.btnExitMainMenu.TabIndex = 7
        Me.btnExitMainMenu.Text = "Exit"
        Me.btnExitMainMenu.UseVisualStyleBackColor = True
        '
        'frmMainMenu
        '
        Me.AccessibleDescription = "frmMainMenu"
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 425)
        Me.Controls.Add(Me.btnExitMainMenu)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtboxMainMenu)
        Me.Controls.Add(Me.btnReports)
        Me.Controls.Add(Me.btnPurchases)
        Me.Controls.Add(Me.btnMembers)
        Me.Controls.Add(Me.btnMembershipTypes)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Name = "frmMainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu"
        Me.TransparencyKey = System.Drawing.Color.Transparent
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnMembershipTypes As System.Windows.Forms.Button
    Friend WithEvents btnMembers As System.Windows.Forms.Button
    Friend WithEvents btnPurchases As System.Windows.Forms.Button
    Friend WithEvents btnReports As System.Windows.Forms.Button
    Friend WithEvents txtboxMainMenu As System.Windows.Forms.RichTextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnExitMainMenu As System.Windows.Forms.Button
End Class
