Public Class frmCreateMember

    Private Sub label1_Click(sender As Object, e As EventArgs) Handles label1CreateMember.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub frmCreateMember_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtboxFirstName_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn6Exit_Click(sender As Object, e As EventArgs) Handles btn6Exit.Click
        Me.Close()
        frmMembers.Close()
        frmMainMenu.Close()
        frmWelcomeScreen.Close()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim btnBack As New frmMembers
        btnBack.Show()
        Me.Close()
    End Sub

    Private Sub btnCreateNewMember_Click(sender As Object, e As EventArgs)
     
    End Sub

    Private Sub btnCreateNewMember_Click_1(sender As Object, e As EventArgs) Handles btnCreateNewMember.Click
        If txtboxFirstName.Text = "" Then
            MessageBox.Show("First Name must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtboxFirstName.Focus()
            Exit Sub

        End If

        If txtboxLastName.Text = "" Then
            MessageBox.Show("Surname must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtboxLastName.Focus()
            Exit Sub
        End If

        If txtPhone.Text = "" Then
            MessageBox.Show("Phone Number must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPhone.Focus()
            Exit Sub

        End If


        If txtStreet.Text = "" Then
            MessageBox.Show("Street must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtStreet.Focus()
            Exit Sub
        End If

        If txtTown.Text = "" Then
            MessageBox.Show("Town must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTown.Focus()
            Exit Sub
        End If

        If txtCounty.Text = "" Then
            MessageBox.Show("County must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCounty.Focus()
            Exit Sub
        End If

        If txtPaymentDetails.Text = "" Then
            MessageBox.Show("Payment Details must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPaymentDetails.Focus()
            Exit Sub
        End If
        'display confirmation message
        MessageBox.Show("New Member Created", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)


        'reset form
        txtboxFirstName.Text = ""
        txtboxLastName.Text = ""
        txtPhone.Text = " "
        txtStreet.Text = " "
        txtTown.Text = " "
        txtCounty.Text = " "
        txtMemId.Text = Format(txtMemId.Text + 1, "0000")
        txtPaymentDetails.Text = " "
        txtboxFirstName.Focus()


    End Sub

    Private Sub txtMemId_TextChanged(sender As Object, e As EventArgs) Handles txtMemId.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles txtPhone.TextChanged

    End Sub
End Class