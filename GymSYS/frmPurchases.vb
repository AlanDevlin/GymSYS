Public Class frmPurchases

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

    Private Sub btn1PurchaseMembership_Click(sender As Object, e As EventArgs) Handles btn1PurchaseMembership.Click
        Dim btnPurchaseMembership As New frmPurchaseMembership
        btnPurchaseMembership.Show()
        Me.Close()
    End Sub

    Private Sub btnListExpiringMembership_Click(sender As Object, e As EventArgs) Handles btnListExpiringMembership.Click
        Dim btnList As New frmListExpiringMemberships
        btnList.Show()
        Me.Close()
    End Sub
End Class