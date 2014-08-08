Public Class frmWelcomeScreen

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEnterMainMenu.Click
        Dim mainMenu As New frmMainMenu
        mainMenu.Show()
        Me.Close()
    End Sub

    Private Sub frmWelcomeScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnExitWelcomeScreen_Click(sender As Object, e As EventArgs) Handles btnExitWelcomeScreen.Click
        Me.Close()

    End Sub
End Class
