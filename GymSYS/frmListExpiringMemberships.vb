Public Class frmListExpiringMemberships

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim btnBack As New frmPurchases
        btnBack.Show()
        Me.Close()
    End Sub

    Private Sub btnExitMainMenu_Click(sender As Object, e As EventArgs) Handles btnExitMainMenu.Click
        Me.Close()
        frmPurchases.Close()
        frmMainMenu.Close()
        frmWelcomeScreen.Close()
    End Sub
End Class