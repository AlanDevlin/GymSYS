<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransactionsMenu
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
        Me.btnRevenueAnalysis = New System.Windows.Forms.Button()
        Me.btnViewMemLists = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRevenueAnalysis
        '
        Me.btnRevenueAnalysis.AccessibleDescription = "btnRevenueAnalysis"
        Me.btnRevenueAnalysis.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnRevenueAnalysis.Location = New System.Drawing.Point(327, 215)
        Me.btnRevenueAnalysis.Name = "btnRevenueAnalysis"
        Me.btnRevenueAnalysis.Size = New System.Drawing.Size(107, 102)
        Me.btnRevenueAnalysis.TabIndex = 5
        Me.btnRevenueAnalysis.Text = "View Revenue Analysis"
        Me.btnRevenueAnalysis.UseVisualStyleBackColor = False
        '
        'btnViewMemLists
        '
        Me.btnViewMemLists.AccessibleDescription = ""
        Me.btnViewMemLists.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnViewMemLists.Location = New System.Drawing.Point(327, 65)
        Me.btnViewMemLists.Name = "btnViewMemLists"
        Me.btnViewMemLists.Size = New System.Drawing.Size(107, 103)
        Me.btnViewMemLists.TabIndex = 4
        Me.btnViewMemLists.Text = "View Membership Lists"
        Me.btnViewMemLists.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.AccessibleDescription = "btnExit"
        Me.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnExit.ForeColor = System.Drawing.Color.Red
        Me.btnExit.Location = New System.Drawing.Point(360, 381)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(107, 32)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.AccessibleDescription = "btnBack"
        Me.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnBack.Location = New System.Drawing.Point(232, 381)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(107, 32)
        Me.btnBack.TabIndex = 9
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.GymSYS.My.Resources.Resources.RecordsMenu
        Me.PictureBox1.Location = New System.Drawing.Point(33, 91)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(246, 210)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'frmTransactionsMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 425)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnRevenueAnalysis)
        Me.Controls.Add(Me.btnViewMemLists)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmTransactionsMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transactions Menu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnRevenueAnalysis As System.Windows.Forms.Button
    Friend WithEvents btnViewMemLists As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
End Class
