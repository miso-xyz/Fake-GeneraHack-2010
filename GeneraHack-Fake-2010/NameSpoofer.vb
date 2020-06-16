Public Class NameSpoofer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "Insert Desired Name" Then
            MessageBox.Show("pls Insert a valid name", "Spoof Error")
        Else
            MessageBox.Show("The Name " & TextBox1.Text & " has been changed successfully", "Name Spoofer")
        End If
    End Sub
End Class