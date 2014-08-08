<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditMemTypeSelected
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
        Me.labelCost = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cboDuration = New System.Windows.Forms.ComboBox()
        Me.labelDuration = New System.Windows.Forms.Label()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.txtMemType = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.labelDescription = New System.Windows.Forms.Label()
        Me.label2MemTypeID = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn6Exit
        '
        Me.btn6Exit.AccessibleDescription = "btn5Exit"
        Me.btn6Exit.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn6Exit.ForeColor = System.Drawing.Color.Red
        Me.btn6Exit.Location = New System.Drawing.Point(370, 386)
        Me.btn6Exit.Name = "btn6Exit"
        Me.btn6Exit.Size = New System.Drawing.Size(107, 27)
        Me.btn6Exit.TabIndex = 29
        Me.btn6Exit.Text = "Exit"
        Me.btn6Exit.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.AccessibleDescription = "btnBack"
        Me.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnBack.Location = New System.Drawing.Point(244, 386)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(107, 27)
        Me.btnBack.TabIndex = 28
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'labelCost
        '
        Me.labelCost.AccessibleDescription = "labelCost"
        Me.labelCost.AutoSize = True
        Me.labelCost.Location = New System.Drawing.Point(-32, 200)
        Me.labelCost.Name = "labelCost"
        Me.labelCost.Size = New System.Drawing.Size(28, 13)
        Me.labelCost.TabIndex = 22
        Me.labelCost.Text = "Cost"
        '
        'label1
        '
        Me.label1.AccessibleDescription = "label1"
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.Blue
        Me.label1.Location = New System.Drawing.Point(24, 9)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(186, 20)
        Me.label1.TabIndex = 19
        Me.label1.Text = "Edit Membership Type"
        '
        'txtDesc
        '
        Me.txtDesc.Location = New System.Drawing.Point(134, 101)
        Me.txtDesc.MaxLength = 20
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(217, 20)
        Me.txtDesc.TabIndex = 1
        Me.txtDesc.Text = "Standard"
        '
        'Button1
        '
        Me.Button1.AccessibleDescription = "btnAddNewMemberType"
        Me.Button1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Button1.Location = New System.Drawing.Point(288, 169)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(63, 26)
        Me.Button1.TabIndex = 39
        Me.Button1.Text = "Confirm"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'cboDuration
        '
        Me.cboDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDuration.FormattingEnabled = True
        Me.cboDuration.Items.AddRange(New Object() {"12 Month", "6 Month", "3 Month", "1 Month"})
        Me.cboDuration.Location = New System.Drawing.Point(134, 138)
        Me.cboDuration.Name = "cboDuration"
        Me.cboDuration.Size = New System.Drawing.Size(138, 21)
        Me.cboDuration.TabIndex = 2
        '
        'labelDuration
        '
        Me.labelDuration.AccessibleDescription = "labelDuration"
        Me.labelDuration.AutoSize = True
        Me.labelDuration.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelDuration.Location = New System.Drawing.Point(24, 135)
        Me.labelDuration.Name = "labelDuration"
        Me.labelDuration.Size = New System.Drawing.Size(70, 20)
        Me.labelDuration.TabIndex = 38
        Me.labelDuration.Text = "Duration"
        '
        'txtCost
        '
        Me.txtCost.Location = New System.Drawing.Point(134, 173)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(138, 20)
        Me.txtCost.TabIndex = 3
        Me.txtCost.Text = "600"
        '
        'txtMemType
        '
        Me.txtMemType.Location = New System.Drawing.Point(134, 63)
        Me.txtMemType.MaxLength = 4
        Me.txtMemType.Multiline = True
        Me.txtMemType.Name = "txtMemType"
        Me.txtMemType.Size = New System.Drawing.Size(60, 27)
        Me.txtMemType.TabIndex = 0
        Me.txtMemType.Text = "M12"
        '
        'Label2
        '
        Me.Label2.AccessibleDescription = "labelCost"
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 20)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Cost"
        '
        'labelDescription
        '
        Me.labelDescription.AccessibleDescription = "labelDescription"
        Me.labelDescription.AutoSize = True
        Me.labelDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelDescription.Location = New System.Drawing.Point(24, 99)
        Me.labelDescription.Name = "labelDescription"
        Me.labelDescription.Size = New System.Drawing.Size(89, 20)
        Me.labelDescription.TabIndex = 35
        Me.labelDescription.Text = "Description"
        '
        'label2MemTypeID
        '
        Me.label2MemTypeID.AccessibleDescription = "label2MemTypeID"
        Me.label2MemTypeID.AutoSize = True
        Me.label2MemTypeID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2MemTypeID.Location = New System.Drawing.Point(24, 63)
        Me.label2MemTypeID.Name = "label2MemTypeID"
        Me.label2MemTypeID.Size = New System.Drawing.Size(104, 20)
        Me.label2MemTypeID.TabIndex = 33
        Me.label2MemTypeID.Text = "MemType_ID"
        '
        'frmEditMemTypeSelected
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 425)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cboDuration)
        Me.Controls.Add(Me.labelDuration)
        Me.Controls.Add(Me.txtCost)
        Me.Controls.Add(Me.txtMemType)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.labelDescription)
        Me.Controls.Add(Me.label2MemTypeID)
        Me.Controls.Add(Me.btn6Exit)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.labelCost)
        Me.Controls.Add(Me.label1)
        Me.Name = "frmEditMemTypeSelected"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Membership Type Edited"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn6Exit As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents labelCost As System.Windows.Forms.Label
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents txtDesc As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cboDuration As System.Windows.Forms.ComboBox
    Friend WithEvents labelDuration As System.Windows.Forms.Label
    Friend WithEvents txtCost As System.Windows.Forms.TextBox
    Friend WithEvents txtMemType As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents labelDescription As System.Windows.Forms.Label
    Friend WithEvents label2MemTypeID As System.Windows.Forms.Label
End Class
