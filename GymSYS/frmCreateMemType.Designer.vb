<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCreateMemType
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
        Me.label1 = New System.Windows.Forms.Label()
        Me.label2MemTypeID = New System.Windows.Forms.Label()
        Me.labelDescription = New System.Windows.Forms.Label()
        Me.labelLastName = New System.Windows.Forms.Label()
        Me.labelCost = New System.Windows.Forms.Label()
        Me.txtMemType = New System.Windows.Forms.TextBox()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.labelDuration = New System.Windows.Forms.Label()
        Me.cboDuration = New System.Windows.Forms.ComboBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btn6Exit = New System.Windows.Forms.Button()
        Me.btnAddNewMemberType = New System.Windows.Forms.Button()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AccessibleDescription = "label1"
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.Blue
        Me.label1.Location = New System.Drawing.Point(13, 13)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(247, 20)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Create New Membership Type"
        '
        'label2MemTypeID
        '
        Me.label2MemTypeID.AccessibleDescription = "label2MemTypeID"
        Me.label2MemTypeID.AutoSize = True
        Me.label2MemTypeID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2MemTypeID.Location = New System.Drawing.Point(12, 98)
        Me.label2MemTypeID.Name = "label2MemTypeID"
        Me.label2MemTypeID.Size = New System.Drawing.Size(104, 20)
        Me.label2MemTypeID.TabIndex = 1
        Me.label2MemTypeID.Text = "MemType_ID"
        '
        'labelDescription
        '
        Me.labelDescription.AccessibleDescription = "labelDescription"
        Me.labelDescription.AutoSize = True
        Me.labelDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelDescription.Location = New System.Drawing.Point(12, 134)
        Me.labelDescription.Name = "labelDescription"
        Me.labelDescription.Size = New System.Drawing.Size(89, 20)
        Me.labelDescription.TabIndex = 2
        Me.labelDescription.Text = "Description"
        '
        'labelLastName
        '
        Me.labelLastName.AccessibleDescription = "labelLastName"
        Me.labelLastName.AutoSize = True
        Me.labelLastName.Location = New System.Drawing.Point(14, 173)
        Me.labelLastName.Name = "labelLastName"
        Me.labelLastName.Size = New System.Drawing.Size(0, 13)
        Me.labelLastName.TabIndex = 3
        '
        'labelCost
        '
        Me.labelCost.AccessibleDescription = "labelCost"
        Me.labelCost.AutoSize = True
        Me.labelCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelCost.Location = New System.Drawing.Point(14, 206)
        Me.labelCost.Name = "labelCost"
        Me.labelCost.Size = New System.Drawing.Size(42, 20)
        Me.labelCost.TabIndex = 4
        Me.labelCost.Text = "Cost"
        '
        'txtMemType
        '
        Me.txtMemType.Location = New System.Drawing.Point(122, 98)
        Me.txtMemType.MaxLength = 4
        Me.txtMemType.Multiline = True
        Me.txtMemType.Name = "txtMemType"
        Me.txtMemType.Size = New System.Drawing.Size(60, 27)
        Me.txtMemType.TabIndex = 0
        '
        'txtCost
        '
        Me.txtCost.Location = New System.Drawing.Point(122, 208)
        Me.txtCost.MaxLength = 6
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(138, 20)
        Me.txtCost.TabIndex = 3
        '
        'labelDuration
        '
        Me.labelDuration.AccessibleDescription = "labelDuration"
        Me.labelDuration.AutoSize = True
        Me.labelDuration.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelDuration.Location = New System.Drawing.Point(12, 170)
        Me.labelDuration.Name = "labelDuration"
        Me.labelDuration.Size = New System.Drawing.Size(70, 20)
        Me.labelDuration.TabIndex = 9
        Me.labelDuration.Text = "Duration"
        '
        'cboDuration
        '
        Me.cboDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDuration.FormattingEnabled = True
        Me.cboDuration.Items.AddRange(New Object() {"12 Month", "6 Month", "3 Month", "1 Month"})
        Me.cboDuration.Location = New System.Drawing.Point(122, 173)
        Me.cboDuration.Name = "cboDuration"
        Me.cboDuration.Size = New System.Drawing.Size(138, 21)
        Me.cboDuration.TabIndex = 2
        '
        'btnBack
        '
        Me.btnBack.AccessibleDescription = "btnBack"
        Me.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnBack.Location = New System.Drawing.Point(298, 386)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(66, 27)
        Me.btnBack.TabIndex = 15
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btn6Exit
        '
        Me.btn6Exit.AccessibleDescription = "btn5Exit"
        Me.btn6Exit.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn6Exit.ForeColor = System.Drawing.Color.Red
        Me.btn6Exit.Location = New System.Drawing.Point(370, 386)
        Me.btn6Exit.Name = "btn6Exit"
        Me.btn6Exit.Size = New System.Drawing.Size(66, 27)
        Me.btn6Exit.TabIndex = 16
        Me.btn6Exit.Text = "Exit"
        Me.btn6Exit.UseVisualStyleBackColor = False
        '
        'btnAddNewMemberType
        '
        Me.btnAddNewMemberType.AccessibleDescription = "btnAddNewMemberType"
        Me.btnAddNewMemberType.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnAddNewMemberType.Location = New System.Drawing.Point(276, 206)
        Me.btnAddNewMemberType.Name = "btnAddNewMemberType"
        Me.btnAddNewMemberType.Size = New System.Drawing.Size(63, 26)
        Me.btnAddNewMemberType.TabIndex = 18
        Me.btnAddNewMemberType.Text = "Add"
        Me.btnAddNewMemberType.UseVisualStyleBackColor = False
        '
        'txtDesc
        '
        Me.txtDesc.Location = New System.Drawing.Point(122, 136)
        Me.txtDesc.MaxLength = 20
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(217, 20)
        Me.txtDesc.TabIndex = 1
        '
        'frmCreateMemType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 425)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.btnAddNewMemberType)
        Me.Controls.Add(Me.btn6Exit)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.cboDuration)
        Me.Controls.Add(Me.labelDuration)
        Me.Controls.Add(Me.txtCost)
        Me.Controls.Add(Me.txtMemType)
        Me.Controls.Add(Me.labelCost)
        Me.Controls.Add(Me.labelLastName)
        Me.Controls.Add(Me.labelDescription)
        Me.Controls.Add(Me.label2MemTypeID)
        Me.Controls.Add(Me.label1)
        Me.Name = "frmCreateMemType"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Create New Membership Type"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents label2MemTypeID As System.Windows.Forms.Label
    Friend WithEvents labelDescription As System.Windows.Forms.Label
    Friend WithEvents labelLastName As System.Windows.Forms.Label
    Friend WithEvents labelCost As System.Windows.Forms.Label
    Friend WithEvents txtMemType As System.Windows.Forms.TextBox
    Friend WithEvents txtCost As System.Windows.Forms.TextBox
    Friend WithEvents labelDuration As System.Windows.Forms.Label
    Friend WithEvents cboDuration As System.Windows.Forms.ComboBox
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btn6Exit As System.Windows.Forms.Button
    Friend WithEvents btnAddNewMemberType As System.Windows.Forms.Button
    Friend WithEvents txtDesc As System.Windows.Forms.TextBox
End Class
