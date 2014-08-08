Public Class frmTransactionsMenu

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        frmMainMenu.Close()
        frmWelcomeScreen.Close()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim btnBack As New frmMainMenu
        btnBack.Show()
        Me.Close()
    End Sub

    Private Sub btnViewMemLists_Click(sender As Object, e As EventArgs) Handles btnViewMemLists.Click
        Dim btnViewList As New frmViewMembershipList
        btnViewList.Show()
        Me.Close()
    End Sub

    Private Sub btnRevenueAnalysis_Click(sender As Object, e As EventArgs) Handles btnRevenueAnalysis.Click
        Dim btnRevenue As New frmRevenueAnalysis
        btnRevenue.Show()
        Me.Close()
    End Sub
End Class