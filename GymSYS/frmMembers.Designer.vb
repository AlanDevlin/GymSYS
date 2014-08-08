<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMembers
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
        Me.btnViewMember = New System.Windows.Forms.Button()
        Me.btnEditMembers = New System.Windows.Forms.Button()
        Me.btnDeleteMembers = New System.Windows.Forms.Button()
        Me.btnCreateMembers = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtboxMemTypes = New System.Windows.Forms.RichTextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnViewMember
        '
        Me.btnViewMember.AccessibleDescription = "btnViewMember"
        Me.btnViewMember.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnViewMember.Location = New System.Drawing.Point(354, 256)
        Me.btnViewMember.Name = "btnViewMember"
        Me.btnViewMember.Size = New System.Drawing.Size(107, 50)
        Me.btnViewMember.TabIndex = 2
        Me.btnViewMember.Text = "View Members"
        Me.btnViewMember.UseVisualStyleBackColor = False
        '
        'btnEditMembers
        '
        Me.btnEditMembers.AccessibleDescription = "btnEditMembers"
        Me.btnEditMembers.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnEditMembers.Location = New System.Drawing.Point(354, 185)
        Me.btnEditMembers.Name = "btnEditMembers"
        Me.btnEditMembers.Size = New System.Drawing.Size(107, 50)
        Me.btnEditMembers.TabIndex = 3
        Me.btnEditMembers.Text = "Edit Member"
        Me.btnEditMembers.UseVisualStyleBackColor = False
        '
        'btnDeleteMembers
        '
        Me.btnDeleteMembers.AccessibleDescription = "btnDeleteMembers"
        Me.btnDeleteMembers.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnDeleteMembers.Location = New System.Drawing.Point(354, 114)
        Me.btnDeleteMembers.Name = "btnDeleteMembers"
        Me.btnDeleteMembers.Size = New System.Drawing.Size(107, 50)
        Me.btnDeleteMembers.TabIndex = 4
        Me.btnDeleteMembers.Text = "Delete Member"
        Me.btnDeleteMembers.UseVisualStyleBackColor = False
        '
        'btnCreateMembers
        '
        Me.btnCreateMembers.AccessibleDescription = "btnCreateMembers"
        Me.btnCreateMembers.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnCreateMembers.Location = New System.Drawing.Point(354, 48)
        Me.btnCreateMembers.Name = "btnCreateMembers"
        Me.btnCreateMembers.Size = New System.Drawing.Size(107, 50)
        Me.btnCreateMembers.TabIndex = 5
        Me.btnCreateMembers.Text = "Create New Member"
        Me.btnCreateMembers.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.AccessibleDescription = "btnBack"
        Me.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnBack.Location = New System.Drawing.Point(22, 381)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(107, 32)
        Me.btnBack.TabIndex = 7
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.AccessibleDescription = "btnExit"
        Me.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnExit.ForeColor = System.Drawing.Color.Red
        Me.btnExit.Location = New System.Drawing.Point(354, 381)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(107, 32)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.GymSYS.My.Resources.Resources.GymMember1
        Me.PictureBox1.Location = New System.Drawing.Point(12, 71)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(305, 202)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'txtboxMemTypes
        '
        Me.txtboxMemTypes.AccessibleDescription = "txtboxMemTypes"
        Me.txtboxMemTypes.BackColor = System.Drawing.SystemColors.Control
        Me.txtboxMemTypes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtboxMemTypes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxMemTypes.Location = New System.Drawing.Point(22, 12)
        Me.txtboxMemTypes.Name = "txtboxMemTypes"
        Me.txtboxMemTypes.Size = New System.Drawing.Size(260, 26)
        Me.txtboxMemTypes.TabIndex = 9
        Me.txtboxMemTypes.Text = "Would you like to:"
        '
        'frmMembers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 426)
        Me.Controls.Add(Me.txtboxMemTypes)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnCreateMembers)
        Me.Controls.Add(Me.btnDeleteMembers)
        Me.Controls.Add(Me.btnEditMembers)
        Me.Controls.Add(Me.btnViewMember)
        Me.Name = "frmMembers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Members Menu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnViewMember As System.Windows.Forms.Button
    Friend WithEvents btnEditMembers As System.Windows.Forms.Button
    Friend WithEvents btnDeleteMembers As System.Windows.Forms.Button
    Friend WithEvents btnCreateMembers As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtboxMemTypes As System.Windows.Forms.RichTextBox
End Class
