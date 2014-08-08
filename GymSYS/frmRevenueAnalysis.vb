Public Class frmRevenueAnalysis

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        frmTransactionsMenu.Close()
        frmMainMenu.Close()
        frmWelcomeScreen.Close()
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim btnBack As New frmTransactionsMenu
        btnBack.Show()
        Me.Hide()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PictureBoxBarGraph.Visible = True
    End Sub
End Class