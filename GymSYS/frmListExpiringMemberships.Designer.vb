<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListExpiringMemberships
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
        Dim ListViewItem21 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"M12", "0001", "Walsh", "Jessica", "03/01/2013", "03/01/2014"}, -1)
        Dim ListViewItem22 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"M12", "0013", "Fox", "Dermot", "06/01/2013", "06/01/2014"}, -1)
        Dim ListViewItem23 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"M12", "0015", "Higgins", "Jamie", "06/01/2013", "06/01/2014"}, -1)
        Dim ListViewItem24 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"O6", "0125", "Smith", "Frank", "18/07/2013", "18/01/2014"}, -1)
        Dim ListViewItem25 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"S6", "0128", "Howley", "Sarah", "18/07/2013", "18/01/2014"}, -1)
        Dim ListViewItem26 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"M6", "0142", "Morgan", "Alan", "25/07/2013", "25/01/2014"}, -1)
        Dim ListViewItem27 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"M3", "0212", "Phillips", "John", "26/10/2013", "26/01/2014"}, -1)
        Dim ListViewItem28 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"M3", "0219", "Sobezky", "Pavel", "31/10/2013", "31/01/2014"}, -1)
        Dim ListViewItem29 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"M1", "0355", "Winters", "Mary", "01/01/2014", "31/01/2014"}, -1)
        Dim ListViewItem30 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"M1", "0352", "Crowley", "Pat", "01/01/2014", "31/01/2014"}, -1)
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.MemType_ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Mem_ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Surname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Forename = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Start_Date = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.End_Date = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnExitMainMenu = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.MemType_ID, Me.Mem_ID, Me.Surname, Me.Forename, Me.Start_Date, Me.End_Date})
        Me.ListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem21, ListViewItem22, ListViewItem23, ListViewItem24, ListViewItem25, ListViewItem26, ListViewItem27, ListViewItem28, ListViewItem29, ListViewItem30})
        Me.ListView1.Location = New System.Drawing.Point(4, 89)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(473, 221)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'MemType_ID
        '
        Me.MemType_ID.Text = "MemType_ID"
        Me.MemType_ID.Width = 91
        '
        'Mem_ID
        '
        Me.Mem_ID.Text = "Mem_ID"
        '
        'Surname
        '
        Me.Surname.Text = "Surname"
        '
        'Forename
        '
        Me.Forename.Text = "Forename"
        Me.Forename.Width = 87
        '
        'Start_Date
        '
        Me.Start_Date.Text = "Start Date"
        Me.Start_Date.Width = 91
        '
        'End_Date
        '
        Me.End_Date.Text = "End Date"
        Me.End_Date.Width = 188
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(327, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "List of Memberships Expiring in the Next Month"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(36, 387)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnExitMainMenu
        '
        Me.btnExitMainMenu.ForeColor = System.Drawing.Color.Red
        Me.btnExitMainMenu.Location = New System.Drawing.Point(389, 387)
        Me.btnExitMainMenu.Name = "btnExitMainMenu"
        Me.btnExitMainMenu.Size = New System.Drawing.Size(75, 23)
        Me.btnExitMainMenu.TabIndex = 8
        Me.btnExitMainMenu.Text = "Exit"
        Me.btnExitMainMenu.UseVisualStyleBackColor = True
        '
        'frmListExpiringMemberships
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 425)
        Me.Controls.Add(Me.btnExitMainMenu)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListView1)
        Me.Name = "frmListExpiringMemberships"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "List of Expiring Memberships"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents MemType_ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents Mem_ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents Surname As System.Windows.Forms.ColumnHeader
    Friend WithEvents Forename As System.Windows.Forms.ColumnHeader
    Friend WithEvents Start_Date As System.Windows.Forms.ColumnHeader
    Friend WithEvents End_Date As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnExitMainMenu As System.Windows.Forms.Button
End Class
