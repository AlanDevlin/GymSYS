Public Class frmMemberDeleted

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim btnOK As New frmMainMenu
        btnOK.Show()
        Me.Close()
    End Sub
End Class