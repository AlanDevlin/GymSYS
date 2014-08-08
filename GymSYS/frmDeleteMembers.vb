Public Class frmDeleteMembers

    Private Sub ListViewMembers_DoubleClick(sender As Object, e As EventArgs)
        Dim btnSelect As New frmDeleteMemTypeDetails
        btnSelect.Show()
        Me.Close()
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim btnBack As New frmMembers
        btnBack.Show()
        Me.Close()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        frmMembers.Close()
        frmMainMenu.Close()
        frmWelcomeScreen.Close()
    End Sub

    Private Sub ListViewMembers_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ListViewMembers_DoubleClick1(sender As Object, e As EventArgs) Handles ListViewMembers.DoubleClick
       grpMember.Visible = True
    End Sub

    Private Sub btnCreateNewMember_Click(sender As Object, e As EventArgs) Handles btnCreateNewMember.Click
        'display confirmation message
        MessageBox.Show("Member Deleted", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)


        'reset form
        grpMember.Visible = False


    End Sub

    Private Sub grpMember_Enter(sender As Object, e As EventArgs) Handles grpMember.Enter

    End Sub
End Class