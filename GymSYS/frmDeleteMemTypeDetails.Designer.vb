<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeleteMemTypeDetails
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
        Me.grpMember = New System.Windows.Forms.GroupBox()
        Me.btn6Exit = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnCreateNewMember = New System.Windows.Forms.Button()
        Me.LabelMemType_ID = New System.Windows.Forms.Label()
        Me.txtStreet = New System.Windows.Forms.TextBox()
        Me.LabelAddress = New System.Windows.Forms.Label()
        Me.LabelSurname = New System.Windows.Forms.Label()
        Me.LabelFirstName = New System.Windows.Forms.Label()
        Me.txtboxLastName = New System.Windows.Forms.TextBox()
        Me.txtboxFirstName = New System.Windows.Forms.TextBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.grpMember.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpMember
        '
        Me.grpMember.Controls.Add(Me.btn6Exit)
        Me.grpMember.Controls.Add(Me.TextBox1)
        Me.grpMember.Controls.Add(Me.btnCreateNewMember)
        Me.grpMember.Controls.Add(Me.LabelMemType_ID)
        Me.grpMember.Controls.Add(Me.txtStreet)
        Me.grpMember.Controls.Add(Me.LabelAddress)
        Me.grpMember.Controls.Add(Me.LabelSurname)
        Me.grpMember.Controls.Add(Me.LabelFirstName)
        Me.grpMember.Controls.Add(Me.txtboxLastName)
        Me.grpMember.Controls.Add(Me.txtboxFirstName)
        Me.grpMember.Location = New System.Drawing.Point(84, 57)
        Me.grpMember.Name = "grpMember"
        Me.grpMember.Size = New System.Drawing.Size(272, 354)
        Me.grpMember.TabIndex = 46
        Me.grpMember.TabStop = False
        Me.grpMember.Text = "Membership Type Details"
        '
        'btn6Exit
        '
        Me.btn6Exit.AccessibleDescription = "btn5Exit"
        Me.btn6Exit.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn6Exit.ForeColor = System.Drawing.Color.Red
        Me.btn6Exit.Location = New System.Drawing.Point(278, 329)
        Me.btn6Exit.Name = "btn6Exit"
        Me.btn6Exit.Size = New System.Drawing.Size(107, 27)
        Me.btn6Exit.TabIndex = 59
        Me.btn6Exit.Text = "Exit"
        Me.btn6Exit.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(118, 36)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(137, 20)
        Me.TextBox1.TabIndex = 57
        Me.TextBox1.Text = "S12"
        '
        'btnCreateNewMember
        '
        Me.btnCreateNewMember.AccessibleDescription = "btnAddNewMember"
        Me.btnCreateNewMember.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnCreateNewMember.Location = New System.Drawing.Point(118, 193)
        Me.btnCreateNewMember.Name = "btnCreateNewMember"
        Me.btnCreateNewMember.Size = New System.Drawing.Size(107, 34)
        Me.btnCreateNewMember.TabIndex = 56
        Me.btnCreateNewMember.Text = "Delete"
        Me.btnCreateNewMember.UseVisualStyleBackColor = False
        '
        'LabelMemType_ID
        '
        Me.LabelMemType_ID.AutoSize = True
        Me.LabelMemType_ID.Location = New System.Drawing.Point(18, 36)
        Me.LabelMemType_ID.Name = "LabelMemType_ID"
        Me.LabelMemType_ID.Size = New System.Drawing.Size(54, 13)
        Me.LabelMemType_ID.TabIndex = 50
        Me.LabelMemType_ID.Text = "MemType"
        '
        'txtStreet
        '
        Me.txtStreet.Enabled = False
        Me.txtStreet.Location = New System.Drawing.Point(118, 148)
        Me.txtStreet.Name = "txtStreet"
        Me.txtStreet.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtStreet.Size = New System.Drawing.Size(137, 20)
        Me.txtStreet.TabIndex = 49
        Me.txtStreet.Text = "450"
        '
        'LabelAddress
        '
        Me.LabelAddress.AutoSize = True
        Me.LabelAddress.Location = New System.Drawing.Point(20, 148)
        Me.LabelAddress.Name = "LabelAddress"
        Me.LabelAddress.Size = New System.Drawing.Size(28, 13)
        Me.LabelAddress.TabIndex = 48
        Me.LabelAddress.Text = "Cost"
        '
        'LabelSurname
        '
        Me.LabelSurname.AutoSize = True
        Me.LabelSurname.Location = New System.Drawing.Point(20, 116)
        Me.LabelSurname.Name = "LabelSurname"
        Me.LabelSurname.Size = New System.Drawing.Size(47, 13)
        Me.LabelSurname.TabIndex = 47
        Me.LabelSurname.Text = "Duration"
        '
        'LabelFirstName
        '
        Me.LabelFirstName.AutoSize = True
        Me.LabelFirstName.Location = New System.Drawing.Point(20, 80)
        Me.LabelFirstName.Name = "LabelFirstName"
        Me.LabelFirstName.Size = New System.Drawing.Size(60, 13)
        Me.LabelFirstName.TabIndex = 46
        Me.LabelFirstName.Text = "Description"
        '
        'txtboxLastName
        '
        Me.txtboxLastName.Enabled = False
        Me.txtboxLastName.Location = New System.Drawing.Point(118, 113)
        Me.txtboxLastName.Name = "txtboxLastName"
        Me.txtboxLastName.Size = New System.Drawing.Size(137, 20)
        Me.txtboxLastName.TabIndex = 45
        Me.txtboxLastName.Text = "12 Months"
        '
        'txtboxFirstName
        '
        Me.txtboxFirstName.Enabled = False
        Me.txtboxFirstName.Location = New System.Drawing.Point(118, 77)
        Me.txtboxFirstName.Name = "txtboxFirstName"
        Me.txtboxFirstName.Size = New System.Drawing.Size(137, 20)
        Me.txtboxFirstName.TabIndex = 44
        Me.txtboxFirstName.Text = "Student"
        '
        'btnBack
        '
        Me.btnBack.AccessibleDescription = "btnBack"
        Me.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnBack.Location = New System.Drawing.Point(362, 384)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(107, 27)
        Me.btnBack.TabIndex = 58
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'frmDeleteMemTypeDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 425)
        Me.Controls.Add(Me.grpMember)
        Me.Controls.Add(Me.btnBack)
        Me.Name = "frmDeleteMemTypeDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Delete Mem Type Confirmation"
        Me.grpMember.ResumeLayout(False)
        Me.grpMember.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpMember As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnCreateNewMember As System.Windows.Forms.Button
    Friend WithEvents LabelMemType_ID As System.Windows.Forms.Label
    Friend WithEvents txtStreet As System.Windows.Forms.TextBox
    Friend WithEvents LabelAddress As System.Windows.Forms.Label
    Friend WithEvents LabelSurname As System.Windows.Forms.Label
    Friend WithEvents LabelFirstName As System.Windows.Forms.Label
    Friend WithEvents txtboxLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtboxFirstName As System.Windows.Forms.TextBox
    Friend WithEvents btn6Exit As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
End Class
