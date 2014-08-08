Public Class frmEditMembersEnterID

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim btnSelect As New frmEditMembers2
        btnSelect.Show()
        Me.Close()
    End Sub
End Class