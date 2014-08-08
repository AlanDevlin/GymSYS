<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWelcomeScreen
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
        Me.btnEnterMainMenu = New System.Windows.Forms.Button()
        Me.btnExitWelcomeScreen = New System.Windows.Forms.Button()
        Me.picboxWelcomeScreen = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.picboxWelcomeScreen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEnterMainMenu
        '
        Me.btnEnterMainMenu.AccessibleName = "btnEnterMainMenu"
        Me.btnEnterMainMenu.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEnterMainMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEnterMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnEnterMainMenu.Location = New System.Drawing.Point(40, 323)
        Me.btnEnterMainMenu.Name = "btnEnterMainMenu"
        Me.btnEnterMainMenu.Size = New System.Drawing.Size(149, 57)
        Me.btnEnterMainMenu.TabIndex = 0
        Me.btnEnterMainMenu.Text = "Enter GymSYS"
        Me.btnEnterMainMenu.UseVisualStyleBackColor = False
        '
        'btnExitWelcomeScreen
        '
        Me.btnExitWelcomeScreen.AccessibleName = "btnExitWelcomeScreen"
        Me.btnExitWelcomeScreen.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnExitWelcomeScreen.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnExitWelcomeScreen.Location = New System.Drawing.Point(285, 323)
        Me.btnExitWelcomeScreen.Name = "btnExitWelcomeScreen"
        Me.btnExitWelcomeScreen.Size = New System.Drawing.Size(153, 59)
        Me.btnExitWelcomeScreen.TabIndex = 2
        Me.btnExitWelcomeScreen.Text = "Exit"
        Me.btnExitWelcomeScreen.UseVisualStyleBackColor = False
        '
        'picboxWelcomeScreen
        '
        Me.picboxWelcomeScreen.AccessibleDescription = "picboxWelcomeScreen"
        Me.picboxWelcomeScreen.BackColor = System.Drawing.SystemColors.Control
        Me.picboxWelcomeScreen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picboxWelcomeScreen.Image = Global.GymSYS.My.Resources.Resources.WelcomeScreen2
        Me.picboxWelcomeScreen.Location = New System.Drawing.Point(302, 93)
        Me.picboxWelcomeScreen.Name = "picboxWelcomeScreen"
        Me.picboxWelcomeScreen.Size = New System.Drawing.Size(163, 165)
        Me.picboxWelcomeScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picboxWelcomeScreen.TabIndex = 4
        Me.picboxWelcomeScreen.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(292, 39)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Welcome To GymSYS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 194)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(214, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "The gym membership system "
        '
        'frmWelcomeScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 425)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picboxWelcomeScreen)
        Me.Controls.Add(Me.btnExitWelcomeScreen)
        Me.Controls.Add(Me.btnEnterMainMenu)
        Me.Name = "frmWelcomeScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Welcome Screen"
        CType(Me.picboxWelcomeScreen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEnterMainMenu As System.Windows.Forms.Button
    Friend WithEvents btnExitWelcomeScreen As System.Windows.Forms.Button
    Friend WithEvents picboxWelcomeScreen As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
