<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPurchases
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
        Me.btn1PurchaseMembership = New System.Windows.Forms.Button()
        Me.btnListExpiringMembership = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn1PurchaseMembership
        '
        Me.btn1PurchaseMembership.AccessibleDescription = "btn1MemTypes"
        Me.btn1PurchaseMembership.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn1PurchaseMembership.Location = New System.Drawing.Point(325, 61)
        Me.btn1PurchaseMembership.Name = "btn1PurchaseMembership"
        Me.btn1PurchaseMembership.Size = New System.Drawing.Size(107, 103)
        Me.btn1PurchaseMembership.TabIndex = 2
        Me.btn1PurchaseMembership.Text = "Purchase Membership "
        Me.btn1PurchaseMembership.UseVisualStyleBackColor = False
        '
        'btnListExpiringMembership
        '
        Me.btnListExpiringMembership.AccessibleDescription = "btn1MemTypes"
        Me.btnListExpiringMembership.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnListExpiringMembership.Location = New System.Drawing.Point(325, 226)
        Me.btnListExpiringMembership.Name = "btnListExpiringMembership"
        Me.btnListExpiringMembership.Size = New System.Drawing.Size(107, 102)
        Me.btnListExpiringMembership.TabIndex = 3
        Me.btnListExpiringMembership.Text = "List Expiring Memberships"
        Me.btnListExpiringMembership.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.AccessibleDescription = "btnExit"
        Me.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnExit.ForeColor = System.Drawing.Color.Red
        Me.btnExit.Location = New System.Drawing.Point(370, 386)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(107, 27)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.AccessibleDescription = "btnBack"
        Me.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnBack.Location = New System.Drawing.Point(12, 386)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(107, 27)
        Me.btnBack.TabIndex = 8
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.GymSYS.My.Resources.Resources.Purchases_Menu
        Me.PictureBox1.Location = New System.Drawing.Point(30, 73)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(213, 205)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'frmPurchases
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 425)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnListExpiringMembership)
        Me.Controls.Add(Me.btn1PurchaseMembership)
        Me.Name = "frmPurchases"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Purchases Menu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn1PurchaseMembership As System.Windows.Forms.Button
    Friend WithEvents btnListExpiringMembership As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
End Class
