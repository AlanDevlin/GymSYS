Public Class frmListMemType

    Private Sub frmListMemType_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim btnBack As New frmMembershipTypes
        btnBack.Show()
        Me.Close()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        MessageBox.Show("Mem Type List has been sent to the printer", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Dim btnOk As New frmMainMenu
        btnOk.Show()
        Me.Close()
    End Sub

    Private Sub btn6Exit_Click(sender As Object, e As EventArgs) Handles btn6Exit.Click
        Me.Close()
        frmMembershipTypes.Close()
        frmMainMenu.Close()
        frmWelcomeScreen.Close()

    End Sub
End Class