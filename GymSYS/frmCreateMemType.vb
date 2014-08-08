Public Class frmCreateMemType

    Private Sub btn6Exit_Click(sender As Object, e As EventArgs) Handles btn6Exit.Click
        Me.Close()
        frmMainMenu.Close()
        frmWelcomeScreen.Close()
        frmMembershipTypes.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim backButton As New frmMembershipTypes
        frmMembershipTypes.Show()
        Me.Close()
    End Sub

    Private Sub btnAddNewMemberType_Click(sender As Object, e As EventArgs) Handles btnAddNewMemberType.Click
        'add new membership type to table

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

        'display message box to confirm the transaction
        MessageBox.Show("New Membership Type Added", "Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Clear_Form()

    End Sub

    Private Sub Clear_form()
        txtMemType.Text = ""
        txtDesc.Text = ""
        cboDuration.Text = ""
        txtCost.Text = ""
        txtMemType.Focus()
    End Sub

    Private Sub txtMemType_TextChanged(sender As Object, e As EventArgs) Handles txtMemType.TextChanged

    End Sub
End Class