<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMembershipTypes
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
        Me.txtboxMemTypes = New System.Windows.Forms.RichTextBox()
        Me.btn1MemTypes = New System.Windows.Forms.Button()
        Me.btn2DeleteMemTypes = New System.Windows.Forms.Button()
        Me.btn3Edit = New System.Windows.Forms.Button()
        Me.btn4List = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn5Back = New System.Windows.Forms.Button()
        Me.btn6Exit = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtboxMemTypes
        '
        Me.txtboxMemTypes.AccessibleDescription = "txtboxMemTypes"
        Me.txtboxMemTypes.BackColor = System.Drawing.SystemColors.Control
        Me.txtboxMemTypes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtboxMemTypes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxMemTypes.Location = New System.Drawing.Point(12, 12)
        Me.txtboxMemTypes.Name = "txtboxMemTypes"
        Me.txtboxMemTypes.Size = New System.Drawing.Size(260, 26)
        Me.txtboxMemTypes.TabIndex = 0
        Me.txtboxMemTypes.Text = "Would you like to:"
        '
        'btn1MemTypes
        '
        Me.btn1MemTypes.AccessibleDescription = "btn1MemTypes"
        Me.btn1MemTypes.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn1MemTypes.Location = New System.Drawing.Point(340, 53)
        Me.btn1MemTypes.Name = "btn1MemTypes"
        Me.btn1MemTypes.Size = New System.Drawing.Size(107, 63)
        Me.btn1MemTypes.TabIndex = 1
        Me.btn1MemTypes.Text = "Create New Membership Type"
        Me.btn1MemTypes.UseVisualStyleBackColor = False
        '
        'btn2DeleteMemTypes
        '
        Me.btn2DeleteMemTypes.AccessibleDescription = "btn2DeleteMemTypes"
        Me.btn2DeleteMemTypes.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn2DeleteMemTypes.Location = New System.Drawing.Point(340, 133)
        Me.btn2DeleteMemTypes.Name = "btn2DeleteMemTypes"
        Me.btn2DeleteMemTypes.Size = New System.Drawing.Size(107, 63)
        Me.btn2DeleteMemTypes.TabIndex = 2
        Me.btn2DeleteMemTypes.Text = "Delete Membership Type"
        Me.btn2DeleteMemTypes.UseVisualStyleBackColor = False
        '
        'btn3Edit
        '
        Me.btn3Edit.AccessibleDescription = "btn3Edit"
        Me.btn3Edit.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn3Edit.Location = New System.Drawing.Point(340, 213)
        Me.btn3Edit.Name = "btn3Edit"
        Me.btn3Edit.Size = New System.Drawing.Size(107, 63)
        Me.btn3Edit.TabIndex = 3
        Me.btn3Edit.Text = "Edit Membership Type"
        Me.btn3Edit.UseVisualStyleBackColor = False
        '
        'btn4List
        '
        Me.btn4List.AccessibleDescription = "btn4List"
        Me.btn4List.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn4List.Location = New System.Drawing.Point(340, 293)
        Me.btn4List.Name = "btn4List"
        Me.btn4List.Size = New System.Drawing.Size(107, 63)
        Me.btn4List.TabIndex = 4
        Me.btn4List.Text = "List Membership Types"
        Me.btn4List.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.GymSYS.My.Resources.Resources.MembershipTypeMenu2
        Me.PictureBox1.Location = New System.Drawing.Point(22, 75)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(287, 186)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'btn5Back
        '
        Me.btn5Back.AccessibleDescription = "btn5Back"
        Me.btn5Back.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn5Back.Location = New System.Drawing.Point(3, 386)
        Me.btn5Back.Name = "btn5Back"
        Me.btn5Back.Size = New System.Drawing.Size(107, 27)
        Me.btn5Back.TabIndex = 6
        Me.btn5Back.Text = "Back"
        Me.btn5Back.UseVisualStyleBackColor = False
        '
        'btn6Exit
        '
        Me.btn6Exit.AccessibleDescription = "btn5Exit"
        Me.btn6Exit.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn6Exit.ForeColor = System.Drawing.Color.Red
        Me.btn6Exit.Location = New System.Drawing.Point(370, 386)
        Me.btn6Exit.Name = "btn6Exit"
        Me.btn6Exit.Size = New System.Drawing.Size(107, 27)
        Me.btn6Exit.TabIndex = 7
        Me.btn6Exit.Text = "Exit"
        Me.btn6Exit.UseVisualStyleBackColor = False
        '
        'frmMembershipTypes
        '
        Me.AccessibleDescription = "frmMembershipTypes"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 425)
        Me.Controls.Add(Me.btn6Exit)
        Me.Controls.Add(Me.btn5Back)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn4List)
        Me.Controls.Add(Me.btn3Edit)
        Me.Controls.Add(Me.btn2DeleteMemTypes)
        Me.Controls.Add(Me.btn1MemTypes)
        Me.Controls.Add(Me.txtboxMemTypes)
        Me.Name = "frmMembershipTypes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Membership Types"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtboxMemTypes As System.Windows.Forms.RichTextBox
    Friend WithEvents btn1MemTypes As System.Windows.Forms.Button
    Friend WithEvents btn2DeleteMemTypes As System.Windows.Forms.Button
    Friend WithEvents btn3Edit As System.Windows.Forms.Button
    Friend WithEvents btn4List As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btn5Back As System.Windows.Forms.Button
    Friend WithEvents btn6Exit As System.Windows.Forms.Button
End Class
