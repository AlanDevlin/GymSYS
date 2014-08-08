Public Class frmDeleteMemTypeDetails

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnYes_Click(sender As Object, e As EventArgs)
        Dim btnYes As New frmMemberDeleted
        btnYes.Show()
        Me.Close()
    End Sub

    Private Sub btnNo_Click(sender As Object, e As EventArgs)
        Dim btnNo As New frmDeleteMembers
        btnNo.Show()
        Me.Close()
    End Sub

    Private Sub frmDeleteMemberAreYouSure_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim btnBack As New frmDeleteMemType
        btnBack.Show()
        Me.Close()
    End Sub

    Private Sub btnCreateNewMember_Click(sender As Object, e As EventArgs) Handles btnCreateNewMember.Click
        MessageBox.Show("Mem Type Deleted", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Dim btnOk As New frmDeleteMemType
        btnOk.Show()
    End Sub
End Class