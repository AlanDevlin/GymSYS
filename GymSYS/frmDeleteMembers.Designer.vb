<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeleteMembers
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
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"M12", "0001", "Ahern", "Jessica", "086-1231883", "23 High Street", "Tralee", "Co.Kerry", "Direct Debit"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"C6", "0002", "Browne", "David", "087-0938634", "The Grove", "Tralee", "Co.Kerry", "Cash"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"M6", "0003", "Rogers", "Sarah", "085-2349030", "15 Main Street", "Listowel", "Co.Kerry", "Cash"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"O6", "0004", "Murphy", "Frank", "083-9041823", "67 Ashley Downs", "Tralee", "Co.Kerry", "Cheque"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"S6", "0005", "Howley", "Mary", "087-1691283", "27 Oakview Park", "Tralee", "Co.Kerry", "Cheque"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
        Dim ListViewItem7 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
        Dim ListViewItem8 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
        Dim ListViewItem9 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
        Dim ListViewItem10 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ListViewMembers = New System.Windows.Forms.ListView()
        Me.MemType_ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Mem_ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Surname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Forename = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Phone_Number = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Street = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Town = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.County = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Payment_Details = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.grpMember = New System.Windows.Forms.GroupBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnCreateNewMember = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txtCounty = New System.Windows.Forms.TextBox()
        Me.txtTown = New System.Windows.Forms.TextBox()
        Me.LabelMemType_ID = New System.Windows.Forms.Label()
        Me.txtStreet = New System.Windows.Forms.TextBox()
        Me.LabelAddress = New System.Windows.Forms.Label()
        Me.LabelSurname = New System.Windows.Forms.Label()
        Me.LabelFirstName = New System.Windows.Forms.Label()
        Me.txtboxLastName = New System.Windows.Forms.TextBox()
        Me.txtboxFirstName = New System.Windows.Forms.TextBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.grpMember.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(331, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Select the Member you would like to delete"
        '
        'btnBack
        '
        Me.btnBack.AccessibleDescription = "btnBack"
        Me.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnBack.Location = New System.Drawing.Point(384, 588)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(107, 32)
        Me.btnBack.TabIndex = 8
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.AccessibleDescription = "btnExit"
        Me.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnExit.ForeColor = System.Drawing.Color.Red
        Me.btnExit.Location = New System.Drawing.Point(497, 588)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(107, 32)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'ListViewMembers
        '
        Me.ListViewMembers.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.ListViewMembers.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.MemType_ID, Me.Mem_ID, Me.Surname, Me.Forename, Me.Phone_Number, Me.Street, Me.Town, Me.County, Me.Payment_Details})
        Me.ListViewMembers.FullRowSelect = True
        Me.ListViewMembers.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4, ListViewItem5, ListViewItem6, ListViewItem7, ListViewItem8, ListViewItem9, ListViewItem10})
        Me.ListViewMembers.Location = New System.Drawing.Point(38, 49)
        Me.ListViewMembers.Name = "ListViewMembers"
        Me.ListViewMembers.Size = New System.Drawing.Size(548, 127)
        Me.ListViewMembers.TabIndex = 10
        Me.ListViewMembers.UseCompatibleStateImageBehavior = False
        Me.ListViewMembers.View = System.Windows.Forms.View.Details
        '
        'MemType_ID
        '
        Me.MemType_ID.Text = "MemType_ID"
        Me.MemType_ID.Width = 79
        '
        'Mem_ID
        '
        Me.Mem_ID.Text = "Mem_ID"
        '
        'Surname
        '
        Me.Surname.Text = "Surname"
        Me.Surname.Width = 77
        '
        'Forename
        '
        Me.Forename.Text = "Forename"
        Me.Forename.Width = 87
        '
        'Phone_Number
        '
        Me.Phone_Number.Text = "Phone Number"
        '
        'Street
        '
        Me.Street.Text = "Street"
        Me.Street.Width = 85
        '
        'Town
        '
        Me.Town.Text = "Town"
        '
        'County
        '
        Me.County.Text = "County"
        '
        'Payment_Details
        '
        Me.Payment_Details.Text = "Payment Details"
        '
        'grpMember
        '
        Me.grpMember.Controls.Add(Me.DateTimePicker2)
        Me.grpMember.Controls.Add(Me.Label7)
        Me.grpMember.Controls.Add(Me.TextBox3)
        Me.grpMember.Controls.Add(Me.Label6)
        Me.grpMember.Controls.Add(Me.TextBox2)
        Me.grpMember.Controls.Add(Me.Label5)
        Me.grpMember.Controls.Add(Me.Label4)
        Me.grpMember.Controls.Add(Me.Label3)
        Me.grpMember.Controls.Add(Me.TextBox1)
        Me.grpMember.Controls.Add(Me.btnCreateNewMember)
        Me.grpMember.Controls.Add(Me.Label2)
        Me.grpMember.Controls.Add(Me.DateTimePicker1)
        Me.grpMember.Controls.Add(Me.txtCounty)
        Me.grpMember.Controls.Add(Me.txtTown)
        Me.grpMember.Controls.Add(Me.LabelMemType_ID)
        Me.grpMember.Controls.Add(Me.txtStreet)
        Me.grpMember.Controls.Add(Me.LabelAddress)
        Me.grpMember.Controls.Add(Me.LabelSurname)
        Me.grpMember.Controls.Add(Me.LabelFirstName)
        Me.grpMember.Controls.Add(Me.txtboxLastName)
        Me.grpMember.Controls.Add(Me.txtboxFirstName)
        Me.grpMember.Location = New System.Drawing.Point(182, 191)
        Me.grpMember.Name = "grpMember"
        Me.grpMember.Size = New System.Drawing.Size(331, 391)
        Me.grpMember.TabIndex = 45
        Me.grpMember.TabStop = False
        Me.grpMember.Text = "Member Details"
        Me.grpMember.Visible = False
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(157, 134)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(137, 20)
        Me.TextBox3.TabIndex = 63
        Me.TextBox3.Text = "083-9041883"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 141)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 13)
        Me.Label6.TabIndex = 62
        Me.Label6.Text = "Phone Number"
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(159, 285)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(137, 20)
        Me.TextBox2.TabIndex = 61
        Me.TextBox2.Text = "Cheque"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 288)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 13)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "Payment Details"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 226)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "County"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 196)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "Town"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(157, 51)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(137, 20)
        Me.TextBox1.TabIndex = 57
        Me.TextBox1.Text = "O6   Over 65 6 month"
        '
        'btnCreateNewMember
        '
        Me.btnCreateNewMember.AccessibleDescription = "btnAddNewMember"
        Me.btnCreateNewMember.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnCreateNewMember.Location = New System.Drawing.Point(135, 351)
        Me.btnCreateNewMember.Name = "btnCreateNewMember"
        Me.btnCreateNewMember.Size = New System.Drawing.Size(107, 34)
        Me.btnCreateNewMember.TabIndex = 56
        Me.btnCreateNewMember.Text = "Delete"
        Me.btnCreateNewMember.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 256)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Date of Birth"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Location = New System.Drawing.Point(159, 256)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(137, 20)
        Me.DateTimePicker1.TabIndex = 54
        Me.DateTimePicker1.Value = New Date(1977, 11, 14, 13, 43, 0, 0)
        '
        'txtCounty
        '
        Me.txtCounty.Enabled = False
        Me.txtCounty.Location = New System.Drawing.Point(159, 223)
        Me.txtCounty.Name = "txtCounty"
        Me.txtCounty.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtCounty.Size = New System.Drawing.Size(137, 20)
        Me.txtCounty.TabIndex = 53
        Me.txtCounty.Text = "Co.Kerry"
        '
        'txtTown
        '
        Me.txtTown.Enabled = False
        Me.txtTown.Location = New System.Drawing.Point(157, 193)
        Me.txtTown.Name = "txtTown"
        Me.txtTown.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtTown.Size = New System.Drawing.Size(137, 20)
        Me.txtTown.TabIndex = 52
        Me.txtTown.Text = "Tralee"
        '
        'LabelMemType_ID
        '
        Me.LabelMemType_ID.AutoSize = True
        Me.LabelMemType_ID.Location = New System.Drawing.Point(20, 58)
        Me.LabelMemType_ID.Name = "LabelMemType_ID"
        Me.LabelMemType_ID.Size = New System.Drawing.Size(61, 13)
        Me.LabelMemType_ID.TabIndex = 50
        Me.LabelMemType_ID.Text = "MemType"
        '
        'txtStreet
        '
        Me.txtStreet.Enabled = False
        Me.txtStreet.Location = New System.Drawing.Point(159, 161)
        Me.txtStreet.Name = "txtStreet"
        Me.txtStreet.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtStreet.Size = New System.Drawing.Size(137, 20)
        Me.txtStreet.TabIndex = 49
        Me.txtStreet.Text = "67 Ashley Downs"
        '
        'LabelAddress
        '
        Me.LabelAddress.AutoSize = True
        Me.LabelAddress.Location = New System.Drawing.Point(18, 168)
        Me.LabelAddress.Name = "LabelAddress"
        Me.LabelAddress.Size = New System.Drawing.Size(41, 13)
        Me.LabelAddress.TabIndex = 48
        Me.LabelAddress.Text = "Street"
        '
        'LabelSurname
        '
        Me.LabelSurname.AutoSize = True
        Me.LabelSurname.Location = New System.Drawing.Point(18, 112)
        Me.LabelSurname.Name = "LabelSurname"
        Me.LabelSurname.Size = New System.Drawing.Size(56, 13)
        Me.LabelSurname.TabIndex = 47
        Me.LabelSurname.Text = "Surname"
        '
        'LabelFirstName
        '
        Me.LabelFirstName.AutoSize = True
        Me.LabelFirstName.Location = New System.Drawing.Point(18, 86)
        Me.LabelFirstName.Name = "LabelFirstName"
        Me.LabelFirstName.Size = New System.Drawing.Size(67, 13)
        Me.LabelFirstName.TabIndex = 46
        Me.LabelFirstName.Text = "First Name"
        '
        'txtboxLastName
        '
        Me.txtboxLastName.Enabled = False
        Me.txtboxLastName.Location = New System.Drawing.Point(157, 105)
        Me.txtboxLastName.Name = "txtboxLastName"
        Me.txtboxLastName.Size = New System.Drawing.Size(137, 20)
        Me.txtboxLastName.TabIndex = 45
        Me.txtboxLastName.Text = "Murphy"
        '
        'txtboxFirstName
        '
        Me.txtboxFirstName.Enabled = False
        Me.txtboxFirstName.Location = New System.Drawing.Point(157, 79)
        Me.txtboxFirstName.Name = "txtboxFirstName"
        Me.txtboxFirstName.Size = New System.Drawing.Size(137, 20)
        Me.txtboxFirstName.TabIndex = 44
        Me.txtboxFirstName.Text = "Frank"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(167, 311)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(137, 20)
        Me.DateTimePicker2.TabIndex = 64
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 317)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(143, 13)
        Me.Label7.TabIndex = 65
        Me.Label7.Text = "Membership Expiry Date"
        '
        'frmDeleteMembers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 622)
        Me.Controls.Add(Me.grpMember)
        Me.Controls.Add(Me.ListViewMembers)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmDeleteMembers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Delete Members"
        Me.grpMember.ResumeLayout(False)
        Me.grpMember.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents ListViewMembers As System.Windows.Forms.ListView
    Friend WithEvents MemType_ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents Mem_ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents Surname As System.Windows.Forms.ColumnHeader
    Friend WithEvents Forename As System.Windows.Forms.ColumnHeader
    Friend WithEvents Street As System.Windows.Forms.ColumnHeader
    Friend WithEvents grpMember As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnCreateNewMember As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtCounty As System.Windows.Forms.TextBox
    Friend WithEvents txtTown As System.Windows.Forms.TextBox
    Friend WithEvents LabelMemType_ID As System.Windows.Forms.Label
    Friend WithEvents txtStreet As System.Windows.Forms.TextBox
    Friend WithEvents LabelAddress As System.Windows.Forms.Label
    Friend WithEvents LabelSurname As System.Windows.Forms.Label
    Friend WithEvents LabelFirstName As System.Windows.Forms.Label
    Friend WithEvents txtboxLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtboxFirstName As System.Windows.Forms.TextBox
    Friend WithEvents Phone_Number As System.Windows.Forms.ColumnHeader
    Friend WithEvents Town As System.Windows.Forms.ColumnHeader
    Friend WithEvents County As System.Windows.Forms.ColumnHeader
    Friend WithEvents Payment_Details As System.Windows.Forms.ColumnHeader
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
