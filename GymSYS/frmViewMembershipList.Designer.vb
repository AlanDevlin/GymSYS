<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewMembershipList
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
        Dim ListViewItem11 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"M12", "0001", "Walsh", "Jessica", "03/01/2013", "03/01/2014"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
        Dim ListViewItem12 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"C6", "0002", "Hegarthy", "David", "03/01/2013", "03/07/2013"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
        Dim ListViewItem13 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"M6", "0003", "Rogers", "Sarah", "03/01/2013", "03/07/2013"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
        Dim ListViewItem14 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"O6", "0004", "Murphy", "Frank", "03/01/2013", "03/07/2013"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
        Dim ListViewItem15 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"S6", "0005", "Howley", "Mary", "03/01/2013", "03/07/2013"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
        Dim ListViewItem16 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"M3", "0006", "Murphy", "Alan", "03/01/2013", "03/04/2013"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
        Dim ListViewItem17 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"M3", "0007", "Smith", "John", "03/01/2013", "03/04/2013"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
        Dim ListViewItem18 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"M3", "0008", "Cameron", "Jerome", "04/01/2013", "04/04/2013"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
        Dim ListViewItem19 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"M3", "0009", "Butler", "William", "04/01/2013", "04/04/2013"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
        Dim ListViewItem20 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"M1", "0010", "Crowley", "Pat", "04/01/2013", "04/02/2013"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnMore = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListViewMembers = New System.Windows.Forms.ListView()
        Me.MemType_ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Mem_ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Surname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Forename = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Start_Date = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.End_Date = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(12, 381)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 11
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnMore
        '
        Me.btnMore.Location = New System.Drawing.Point(402, 281)
        Me.btnMore.Name = "btnMore"
        Me.btnMore.Size = New System.Drawing.Size(75, 25)
        Me.btnMore.TabIndex = 10
        Me.btnMore.Text = "More >>"
        Me.btnMore.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 18)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "List of Members"
        '
        'ListViewMembers
        '
        Me.ListViewMembers.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.MemType_ID, Me.Mem_ID, Me.Surname, Me.Forename, Me.Start_Date, Me.End_Date})
        Me.ListViewMembers.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem11, ListViewItem12, ListViewItem13, ListViewItem14, ListViewItem15, ListViewItem16, ListViewItem17, ListViewItem18, ListViewItem19, ListViewItem20})
        Me.ListViewMembers.Location = New System.Drawing.Point(12, 72)
        Me.ListViewMembers.Name = "ListViewMembers"
        Me.ListViewMembers.Size = New System.Drawing.Size(465, 203)
        Me.ListViewMembers.TabIndex = 8
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
        'Start_Date
        '
        Me.Start_Date.Text = "Start Date"
        Me.Start_Date.Width = 78
        '
        'End_Date
        '
        Me.End_Date.Text = "End Date"
        Me.End_Date.Width = 90
        '
        'btnExit
        '
        Me.btnExit.AccessibleDescription = "btnExit"
        Me.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnExit.ForeColor = System.Drawing.Color.Red
        Me.btnExit.Location = New System.Drawing.Point(361, 381)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(107, 32)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'frmViewMembershipList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 425)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnMore)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListViewMembers)
        Me.Name = "frmViewMembershipList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View Membership List"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnMore As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ListViewMembers As System.Windows.Forms.ListView
    Friend WithEvents MemType_ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents Mem_ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents Surname As System.Windows.Forms.ColumnHeader
    Friend WithEvents Forename As System.Windows.Forms.ColumnHeader
    Friend WithEvents Start_Date As System.Windows.Forms.ColumnHeader
    Friend WithEvents End_Date As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnExit As System.Windows.Forms.Button
End Class
