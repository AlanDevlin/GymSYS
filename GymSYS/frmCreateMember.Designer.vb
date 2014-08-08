<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCreateMember
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
        Me.btn6Exit = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.labelLastName = New System.Windows.Forms.Label()
        Me.label1CreateMember = New System.Windows.Forms.Label()
        Me.labelMemID = New System.Windows.Forms.Label()
        Me.txtMemId = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.labelPhone = New System.Windows.Forms.Label()
        Me.txtPaymentDetails = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCreateNewMember = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txtCounty = New System.Windows.Forms.TextBox()
        Me.txtTown = New System.Windows.Forms.TextBox()
        Me.comboboxMemType = New System.Windows.Forms.ComboBox()
        Me.LabelMemType_ID = New System.Windows.Forms.Label()
        Me.txtStreet = New System.Windows.Forms.TextBox()
        Me.LabelStreet = New System.Windows.Forms.Label()
        Me.LabelSurname = New System.Windows.Forms.Label()
        Me.LabelFirstName = New System.Windows.Forms.Label()
        Me.txtboxLastName = New System.Windows.Forms.TextBox()
        Me.txtboxFirstName = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn6Exit
        '
        Me.btn6Exit.AccessibleDescription = "btn5Exit"
        Me.btn6Exit.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn6Exit.ForeColor = System.Drawing.Color.Red
        Me.btn6Exit.Location = New System.Drawing.Point(398, 490)
        Me.btn6Exit.Name = "btn6Exit"
        Me.btn6Exit.Size = New System.Drawing.Size(107, 27)
        Me.btn6Exit.TabIndex = 28
        Me.btn6Exit.Text = "Exit"
        Me.btn6Exit.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.AccessibleDescription = "btnBack"
        Me.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnBack.Location = New System.Drawing.Point(285, 490)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(107, 27)
        Me.btnBack.TabIndex = 27
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'labelLastName
        '
        Me.labelLastName.AccessibleDescription = "labelLastName"
        Me.labelLastName.AutoSize = True
        Me.labelLastName.Location = New System.Drawing.Point(24, 243)
        Me.labelLastName.Name = "labelLastName"
        Me.labelLastName.Size = New System.Drawing.Size(0, 13)
        Me.labelLastName.TabIndex = 20
        '
        'label1CreateMember
        '
        Me.label1CreateMember.AccessibleDescription = "label1CreateMember"
        Me.label1CreateMember.AutoSize = True
        Me.label1CreateMember.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1CreateMember.ForeColor = System.Drawing.Color.Blue
        Me.label1CreateMember.Location = New System.Drawing.Point(24, 9)
        Me.label1CreateMember.Name = "label1CreateMember"
        Me.label1CreateMember.Size = New System.Drawing.Size(171, 20)
        Me.label1CreateMember.TabIndex = 17
        Me.label1CreateMember.Text = "Create New Member"
        '
        'labelMemID
        '
        Me.labelMemID.AutoSize = True
        Me.labelMemID.Location = New System.Drawing.Point(25, 67)
        Me.labelMemID.Name = "labelMemID"
        Me.labelMemID.Size = New System.Drawing.Size(81, 13)
        Me.labelMemID.TabIndex = 29
        Me.labelMemID.Text = "Membership_ID"
        '
        'txtMemId
        '
        Me.txtMemId.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtMemId.Location = New System.Drawing.Point(125, 64)
        Me.txtMemId.Name = "txtMemId"
        Me.txtMemId.Size = New System.Drawing.Size(59, 20)
        Me.txtMemId.TabIndex = 30
        Me.txtMemId.Text = "0004"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtPhone)
        Me.GroupBox1.Controls.Add(Me.labelPhone)
        Me.GroupBox1.Controls.Add(Me.txtPaymentDetails)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnCreateNewMember)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.txtCounty)
        Me.GroupBox1.Controls.Add(Me.txtTown)
        Me.GroupBox1.Controls.Add(Me.comboboxMemType)
        Me.GroupBox1.Controls.Add(Me.LabelMemType_ID)
        Me.GroupBox1.Controls.Add(Me.txtStreet)
        Me.GroupBox1.Controls.Add(Me.LabelStreet)
        Me.GroupBox1.Controls.Add(Me.LabelSurname)
        Me.GroupBox1.Controls.Add(Me.LabelFirstName)
        Me.GroupBox1.Controls.Add(Me.txtboxLastName)
        Me.GroupBox1.Controls.Add(Me.txtboxFirstName)
        Me.GroupBox1.Location = New System.Drawing.Point(30, 108)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(308, 376)
        Me.GroupBox1.TabIndex = 44
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Enter Member Details"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(142, 132)
        Me.txtPhone.MaxLength = 11
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(137, 20)
        Me.txtPhone.TabIndex = 3
        '
        'labelPhone
        '
        Me.labelPhone.AutoSize = True
        Me.labelPhone.Location = New System.Drawing.Point(20, 135)
        Me.labelPhone.Name = "labelPhone"
        Me.labelPhone.Size = New System.Drawing.Size(78, 13)
        Me.labelPhone.TabIndex = 61
        Me.labelPhone.Text = "Phone Number"
        '
        'txtPaymentDetails
        '
        Me.txtPaymentDetails.Location = New System.Drawing.Point(142, 277)
        Me.txtPaymentDetails.MaxLength = 20
        Me.txtPaymentDetails.Name = "txtPaymentDetails"
        Me.txtPaymentDetails.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtPaymentDetails.Size = New System.Drawing.Size(137, 20)
        Me.txtPaymentDetails.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 280)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "Payment Details"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 217)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "County"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 190)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Town"
        '
        'btnCreateNewMember
        '
        Me.btnCreateNewMember.AccessibleDescription = "btnAddNewMember"
        Me.btnCreateNewMember.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnCreateNewMember.Location = New System.Drawing.Point(132, 342)
        Me.btnCreateNewMember.Name = "btnCreateNewMember"
        Me.btnCreateNewMember.Size = New System.Drawing.Size(107, 34)
        Me.btnCreateNewMember.TabIndex = 56
        Me.btnCreateNewMember.Text = "Create New Member"
        Me.btnCreateNewMember.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 243)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Date of Birth"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(142, 243)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(137, 20)
        Me.DateTimePicker1.TabIndex = 7
        '
        'txtCounty
        '
        Me.txtCounty.Location = New System.Drawing.Point(142, 217)
        Me.txtCounty.MaxLength = 25
        Me.txtCounty.Name = "txtCounty"
        Me.txtCounty.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtCounty.Size = New System.Drawing.Size(137, 20)
        Me.txtCounty.TabIndex = 6
        '
        'txtTown
        '
        Me.txtTown.Location = New System.Drawing.Point(142, 190)
        Me.txtTown.MaxLength = 25
        Me.txtTown.Name = "txtTown"
        Me.txtTown.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtTown.Size = New System.Drawing.Size(137, 20)
        Me.txtTown.TabIndex = 5
        '
        'comboboxMemType
        '
        Me.comboboxMemType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxMemType.FormattingEnabled = True
        Me.comboboxMemType.Items.AddRange(New Object() {"M12  Standard Year", "M6    Standard 6 Months", "M3    Standard 3 Months", "M1    Standard 1 Month", "S12   Student Year"})
        Me.comboboxMemType.Location = New System.Drawing.Point(142, 41)
        Me.comboboxMemType.Name = "comboboxMemType"
        Me.comboboxMemType.Size = New System.Drawing.Size(137, 21)
        Me.comboboxMemType.TabIndex = 0
        '
        'LabelMemType_ID
        '
        Me.LabelMemType_ID.AutoSize = True
        Me.LabelMemType_ID.Location = New System.Drawing.Point(18, 49)
        Me.LabelMemType_ID.Name = "LabelMemType_ID"
        Me.LabelMemType_ID.Size = New System.Drawing.Size(54, 13)
        Me.LabelMemType_ID.TabIndex = 50
        Me.LabelMemType_ID.Text = "MemType"
        '
        'txtStreet
        '
        Me.txtStreet.Location = New System.Drawing.Point(142, 162)
        Me.txtStreet.MaxLength = 25
        Me.txtStreet.Name = "txtStreet"
        Me.txtStreet.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtStreet.Size = New System.Drawing.Size(137, 20)
        Me.txtStreet.TabIndex = 4
        '
        'LabelStreet
        '
        Me.LabelStreet.AutoSize = True
        Me.LabelStreet.Location = New System.Drawing.Point(20, 165)
        Me.LabelStreet.Name = "LabelStreet"
        Me.LabelStreet.Size = New System.Drawing.Size(35, 13)
        Me.LabelStreet.TabIndex = 48
        Me.LabelStreet.Text = "Street"
        '
        'LabelSurname
        '
        Me.LabelSurname.AutoSize = True
        Me.LabelSurname.Location = New System.Drawing.Point(23, 105)
        Me.LabelSurname.Name = "LabelSurname"
        Me.LabelSurname.Size = New System.Drawing.Size(49, 13)
        Me.LabelSurname.TabIndex = 47
        Me.LabelSurname.Text = "Surname"
        '
        'LabelFirstName
        '
        Me.LabelFirstName.AutoSize = True
        Me.LabelFirstName.Location = New System.Drawing.Point(20, 81)
        Me.LabelFirstName.Name = "LabelFirstName"
        Me.LabelFirstName.Size = New System.Drawing.Size(57, 13)
        Me.LabelFirstName.TabIndex = 46
        Me.LabelFirstName.Text = "First Name"
        '
        'txtboxLastName
        '
        Me.txtboxLastName.Location = New System.Drawing.Point(142, 102)
        Me.txtboxLastName.MaxLength = 20
        Me.txtboxLastName.Name = "txtboxLastName"
        Me.txtboxLastName.Size = New System.Drawing.Size(137, 20)
        Me.txtboxLastName.TabIndex = 2
        '
        'txtboxFirstName
        '
        Me.txtboxFirstName.Location = New System.Drawing.Point(142, 76)
        Me.txtboxFirstName.MaxLength = 20
        Me.txtboxFirstName.Name = "txtboxFirstName"
        Me.txtboxFirstName.Size = New System.Drawing.Size(137, 20)
        Me.txtboxFirstName.TabIndex = 1
        '
        'frmCreateMember
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 529)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtMemId)
        Me.Controls.Add(Me.labelMemID)
        Me.Controls.Add(Me.btn6Exit)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.labelLastName)
        Me.Controls.Add(Me.label1CreateMember)
        Me.Name = "frmCreateMember"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Create New Member"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn6Exit As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents labelLastName As System.Windows.Forms.Label
    Friend WithEvents label1CreateMember As System.Windows.Forms.Label
    Friend WithEvents labelMemID As System.Windows.Forms.Label
    Friend WithEvents txtMemId As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtCounty As System.Windows.Forms.TextBox
    Friend WithEvents txtTown As System.Windows.Forms.TextBox
    Friend WithEvents comboboxMemType As System.Windows.Forms.ComboBox
    Friend WithEvents LabelMemType_ID As System.Windows.Forms.Label
    Friend WithEvents txtStreet As System.Windows.Forms.TextBox
    Friend WithEvents LabelStreet As System.Windows.Forms.Label
    Friend WithEvents LabelSurname As System.Windows.Forms.Label
    Friend WithEvents LabelFirstName As System.Windows.Forms.Label
    Friend WithEvents txtboxLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtboxFirstName As System.Windows.Forms.TextBox
    Friend WithEvents btnCreateNewMember As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPaymentDetails As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents labelPhone As System.Windows.Forms.Label
End Class
