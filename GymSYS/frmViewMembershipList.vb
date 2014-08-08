Public Class frmViewMembershipList

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim btnBack As New frmTransactionsMenu
        btnBack.Show()
        Me.Close()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        frmTransactionsMenu.Close()
        frmMainMenu.Close()
        frmWelcomeScreen.Close()
    End Sub
End Class