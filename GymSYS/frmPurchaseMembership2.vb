Public Class frmPurchaseMembership2

    Private Sub LabelFirstName_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim btnBack As New frmPurchaseMembership
        btnBack.Show()
        Me.Close()
    End Sub

    Private Sub btn6Exit_Click(sender As Object, e As EventArgs) Handles btn6Exit.Click
        Me.Close()
        frmPurchaseMembership.Close()
        frmMainMenu.Close()
        frmWelcomeScreen.Close()
    End Sub

 

    Private Sub btnCreateNewMember_Click(sender As Object, e As EventArgs) Handles btnCreateNewMember.Click
        If txtPaymentDetails.Text = "" Then
            MessageBox.Show("Purchase Amount must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPaymentDetails.Focus()
            Exit Sub

        End If

        If txtboxPurchaseAmount.Text = "" Then
            MessageBox.Show("Purchase Amount must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPaymentDetails.Focus()
            Exit Sub

        End If

        MessageBox.Show("Membership Purchased", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)

        txtboxPurchaseID.Text = Format(txtboxPurchaseID.Text + 1, "0000")

        txtPaymentDetails.Text = " "
        txtboxPurchaseAmount.Text = " "
        txtPaymentDetails.Focus()
        Dim btnConfirm As New frmPurchases
        btnConfirm.Show()
        Me.Close()

    End Sub
End Class