<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPurchaseMembership2
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
        Me.LabelMemType_ID = New System.Windows.Forms.Label()
        Me.TextBoxMem_ID = New System.Windows.Forms.TextBox()
        Me.btn6Exit = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.labelLastName = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtboxPurchaseID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPaymentDetails = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCreateNewMember = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtboxPurchaseAmount = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelMemType_ID
        '
        Me.LabelMemType_ID.AutoSize = True
        Me.LabelMemType_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMemType_ID.Location = New System.Drawing.Point(196, 243)
        Me.LabelMemType_ID.Name = "LabelMemType_ID"
        Me.LabelMemType_ID.Size = New System.Drawing.Size(0, 20)
        Me.LabelMemType_ID.TabIndex = 53
        '
        'TextBoxMem_ID
        '
        Me.TextBoxMem_ID.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.TextBoxMem_ID.Location = New System.Drawing.Point(115, 113)
        Me.TextBoxMem_ID.Name = "TextBoxMem_ID"
        Me.TextBoxMem_ID.Size = New System.Drawing.Size(137, 20)
        Me.TextBoxMem_ID.TabIndex = 0
        Me.TextBoxMem_ID.Text = "0004"
        '
        'btn6Exit
        '
        Me.btn6Exit.AccessibleDescription = "btn5Exit"
        Me.btn6Exit.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn6Exit.ForeColor = System.Drawing.Color.Red
        Me.btn6Exit.Location = New System.Drawing.Point(370, 395)
        Me.btn6Exit.Name = "btn6Exit"
        Me.btn6Exit.Size = New System.Drawing.Size(107, 27)
        Me.btn6Exit.TabIndex = 43
        Me.btn6Exit.Text = "Exit"
        Me.btn6Exit.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.AccessibleDescription = "btnBack"
        Me.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnBack.Location = New System.Drawing.Point(247, 395)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(107, 27)
        Me.btnBack.TabIndex = 42
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'labelLastName
        '
        Me.labelLastName.AccessibleDescription = "labelLastName"
        Me.labelLastName.AutoSize = True
        Me.labelLastName.Location = New System.Drawing.Point(11, 185)
        Me.labelLastName.Name = "labelLastName"
        Me.labelLastName.Size = New System.Drawing.Size(0, 13)
        Me.labelLastName.TabIndex = 40
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtboxPurchaseAmount)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtboxPurchaseID)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtPaymentDetails)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btnCreateNewMember)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBoxMem_ID)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(272, 354)
        Me.GroupBox1.TabIndex = 58
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Enter Payment Details"
        '
        'txtboxPurchaseID
        '
        Me.txtboxPurchaseID.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtboxPurchaseID.Location = New System.Drawing.Point(115, 79)
        Me.txtboxPurchaseID.Name = "txtboxPurchaseID"
        Me.txtboxPurchaseID.Size = New System.Drawing.Size(137, 20)
        Me.txtboxPurchaseID.TabIndex = 63
        Me.txtboxPurchaseID.Text = "0002"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 13)
        Me.Label6.TabIndex = 62
        Me.Label6.Text = "Purchase_ID"
        '
        'txtPaymentDetails
        '
        Me.txtPaymentDetails.Location = New System.Drawing.Point(115, 188)
        Me.txtPaymentDetails.MaxLength = 20
        Me.txtPaymentDetails.Name = "txtPaymentDetails"
        Me.txtPaymentDetails.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtPaymentDetails.Size = New System.Drawing.Size(137, 20)
        Me.txtPaymentDetails.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 13)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "Purchase Method"
        '
        'btnCreateNewMember
        '
        Me.btnCreateNewMember.AccessibleDescription = "btnAddNewMember"
        Me.btnCreateNewMember.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnCreateNewMember.Location = New System.Drawing.Point(115, 278)
        Me.btnCreateNewMember.Name = "btnCreateNewMember"
        Me.btnCreateNewMember.Size = New System.Drawing.Size(107, 34)
        Me.btnCreateNewMember.TabIndex = 56
        Me.btnCreateNewMember.Text = "Confirm Payment"
        Me.btnCreateNewMember.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 154)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Date of Purchase"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(115, 154)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(137, 20)
        Me.DateTimePicker1.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "Membership_ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 226)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 13)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "Purchase Amount(€)"
        '
        'txtboxPurchaseAmount
        '
        Me.txtboxPurchaseAmount.Location = New System.Drawing.Point(127, 223)
        Me.txtboxPurchaseAmount.MaxLength = 20
        Me.txtboxPurchaseAmount.Name = "txtboxPurchaseAmount"
        Me.txtboxPurchaseAmount.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtboxPurchaseAmount.Size = New System.Drawing.Size(125, 20)
        Me.txtboxPurchaseAmount.TabIndex = 3
        '
        'frmPurchaseMembership2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 425)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LabelMemType_ID)
        Me.Controls.Add(Me.btn6Exit)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.labelLastName)
        Me.Name = "frmPurchaseMembership2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Purchase Membership"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelMemType_ID As System.Windows.Forms.Label
    Friend WithEvents TextBoxMem_ID As System.Windows.Forms.TextBox
    Friend WithEvents btn6Exit As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents labelLastName As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtPaymentDetails As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnCreateNewMember As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtboxPurchaseID As System.Windows.Forms.TextBox
    Friend WithEvents txtboxPurchaseAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
