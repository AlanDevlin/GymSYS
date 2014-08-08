Public Class frmMembershipTypes

    Private Sub btn1MemTypes_Click(sender As Object, e As EventArgs) Handles btn1MemTypes.Click
        Dim createMemType As New frmCreateMemType
        createMemType.Show()
        Me.Hide()
    End Sub

    Private Sub btn5Back_Click(sender As Object, e As EventArgs) Handles btn5Back.Click
        Dim mainMenu As New frmMainMenu
        mainMenu.Show()
        Me.Hide()
    End Sub

    Private Sub btn6Exit_Click(sender As Object, e As EventArgs) Handles btn6Exit.Click
        Me.Close()
        frmMainMenu.Close()
        frmWelcomeScreen.Close()
    End Sub

    Private Sub btn2DeleteMemTypes_Click(sender As Object, e As EventArgs) Handles btn2DeleteMemTypes.Click
        Dim btn2DeleteMemTypes As New frmDeleteMemType
        btn2DeleteMemTypes.Show()
        Me.Hide()
    End Sub

    Private Sub btn3Edit_Click(sender As Object, e As EventArgs) Handles btn3Edit.Click
        Dim btnEdit As New frmEditMemType
        btnEdit.Show()
        Me.Hide()
    End Sub

    Private Sub btn4List_Click(sender As Object, e As EventArgs) Handles btn4List.Click
        Dim btnList As New frmListMemType
        btnList.Show()
        Me.Close()
    End Sub
End Class