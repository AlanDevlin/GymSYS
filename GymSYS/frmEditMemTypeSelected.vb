Public Class frmEditMemTypeSelected

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim btnBack As New frmEditMemType
        btnBack.Show()
        Me.Close()
    End Sub

    Private Sub btn6Exit_Click(sender As Object, e As EventArgs) Handles btn6Exit.Click
        Me.Close()
        frmEditMemType.Close()
        frmMembershipTypes.Close()
        frmMainMenu.Close()
        frmWelcomeScreen.Close()
    End Sub

    Private Sub btnAddNewMemberType_Click(sender As Object, e As EventArgs)
        
    End Sub

    Private Sub cboDuration_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDuration.SelectedIndexChanged
        MessageBox.Show("Edited changes confirmed", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Dim btnAccept As New frmMainMenu
        btnAccept.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtMemType.Text = "" Then
            MessageBox.Show("Mem Type must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtMemType.Focus()
            Exit Sub

        End If

        If txtDesc.Text = "" Then
            MessageBox.Show("Description must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDesc.Focus()
            Exit Sub

        End If

        If txtCost.Text = "" Then
            MessageBox.Show("Cost must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCost.Focus()
            Exit Sub

        End If





        MessageBox.Show("Edited changes confirmed", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Dim btnAccept As New frmMainMenu
        btnAccept.Show()
        Me.Close()
    End Sub
End Class