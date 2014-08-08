Public Class frmEditMembers2

    Private Sub btnCreateNewMember_Click(sender As Object, e As EventArgs)
        MessageBox.Show("Edit changes confirmed", "Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information)


    End Sub
    
    Private Sub btnBack_Click(sender As Object, e As EventArgs)
        Dim btnBack As New frmEditMembersEnterID
        btnBack.Show()
        Me.Close()
    End Sub

    Private Sub btn6Exit_Click(sender As Object, e As EventArgs)
        Me.Close()
        frmEditMembersEnterID.Close()
        frmMembers.Close()
        frmMainMenu.Close()
        frmWelcomeScreen.Close()
    End Sub

    Private Sub btnBack_Click_1(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim btnBack As New frmMembers
        btnBack.Show()
        Me.Close()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn6Exit_Click_1(sender As Object, e As EventArgs) Handles btn6Exit.Click
        Me.Close()
        frmEditMembersEnterID.Close()
        frmMembers.Close()
        frmMainMenu.Close()
        frmWelcomeScreen.Close()
    End Sub

    Private Sub labelMemID_Click(sender As Object, e As EventArgs) Handles labelMemID.Click

    End Sub

    Private Sub txtMemId_TextChanged(sender As Object, e As EventArgs) Handles txtMemId.TextChanged

    End Sub

    Private Sub label1CreateMember_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnCreateNewMember_Click_1(sender As Object, e As EventArgs)
        MessageBox.Show("Changes Confirmed", "Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Dim btnConfirm As New frmMainMenu
        btnConfirm.Show()
        Me.Close()
    End Sub

    Private Sub frmEditMembers2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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





        MessageBox.Show("Changes Confirmed", "Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information)

    

        Dim btnConfirm As New frmMainMenu
        btnConfirm.Show()
        Me.Close()
    End Sub
End Class