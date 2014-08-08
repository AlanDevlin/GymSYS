Public Class frmMainMenu

    Private Sub frmMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnMembershipTypes_Click(sender As Object, e As EventArgs) Handles btnMembershipTypes.Click
        Dim membershipTypes As New frmMembershipTypes
        membershipTypes.Show()
        Me.Hide()
    End Sub

    Private Sub txtboxMainMenu_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnMembers_Click(sender As Object, e As EventArgs) Handles btnMembers.Click
        Dim btnMembers As New frmMembers
        btnMembers.Show()
        Me.Close()
    End Sub

    Private Sub btnPurchases_Click(sender As Object, e As EventArgs) Handles btnPurchases.Click
        Dim btnPurchases As New frmPurchases
        btnPurchases.Show()
        Me.Close()
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        Dim btnReports As New frmTransactionsMenu
        btnReports.Show()
        Me.Close()
    End Sub

    Private Sub btnExitMainMenu_Click(sender As Object, e As EventArgs) Handles btnExitMainMenu.Click
        Me.Close()
        frmWelcomeScreen.Close()
    End Sub
End Class