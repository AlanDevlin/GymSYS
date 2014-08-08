Public Class frmMembers

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        frmMainMenu.Close()
        frmWelcomeScreen.Close()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim btnExit As New frmMainMenu
        frmMainMenu.Show()
        Me.Close()
    End Sub

    Private Sub btnCreateMembers_Click(sender As Object, e As EventArgs) Handles btnCreateMembers.Click
        Dim btnCreate As New frmCreateMember
        btnCreate.Show()
        Me.Close()
    End Sub

    Private Sub btnDeleteMembers_Click(sender As Object, e As EventArgs) Handles btnDeleteMembers.Click
        Dim btnDelete As New frmDeleteMembers
        btnDelete.Show()
        Me.Close()
    End Sub

    Private Sub btnEditMembers_Click(sender As Object, e As EventArgs) Handles btnEditMembers.Click
        Dim btnEdit As New frmEditMembersEnterID
        btnEdit.Show()
        Me.Close()
    End Sub

    Private Sub btnViewMember_Click(sender As Object, e As EventArgs) Handles btnViewMember.Click
        Dim btnView As New frmViewMembers
        btnView.Show()
        Me.Close()
    End Sub
End Class