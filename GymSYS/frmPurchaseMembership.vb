Public Class frmPurchaseMembership

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim txtbox1 As New frmPurchaseMembership2
        txtbox1.Show()
        Me.Close()
    End Sub
End Class