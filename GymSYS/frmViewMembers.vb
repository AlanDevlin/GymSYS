Public Class frmViewMembers

    Private Sub frmViewMembers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim btnBack As New frmMembers
        btnBack.Show()
        Me.Close()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        frmMembers.Close()
        frmMainMenu.Close()
        frmWelcomeScreen.Close()
    End Sub
End Class