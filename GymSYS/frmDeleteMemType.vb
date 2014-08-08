Public Class frmDeleteMemType

    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        Dim btnSelect As New frmDeleteMemTypeDetails
        btnSelect.Show()
        Me.Hide()
        
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        

        
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim btnBack As New frmMembershipTypes
        btnBack.Show()
        Me.Hide()
    End Sub

    Private Sub btn6Exit_Click(sender As Object, e As EventArgs) Handles btn6Exit.Click
        Me.Close()
        frmMembershipTypes.Close()
        frmMainMenu.Close()
        frmWelcomeScreen.Close()
    End Sub
End Class