Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "Tamara Toko Punya" And TextBox2.Text = "derrentoko" Then
            MessageBox.Show("Berhasil Login", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim frm2 As New Form2
            nama = TextBox1.Text
            frm2.Show()
            Me.Close()
        Else MessageBox.Show("Salah tolol", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


    End Sub
End Class
