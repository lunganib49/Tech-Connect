Public Class Login
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        LoginTableAdapter.Fill(TechConnect.Login, TextBox1.Text, TextBox2.Text)
        If TechConnect.Login.Rows.Count > 0 Then
            If TextBox2.Text <> "" And TextBox1.Text <> "" Then
                MsgBox("Welcome " & TechConnect.Login.Rows(0).Item(0).ToString & vbLf & "You will now be directed to the system")

                Me.Hide()
                MainMenu.Show()
                TextBox1.ResetText()
                TextBox2.ResetText()

            Else
                Label3.Text = "Invalid login!!! try again"
                TextBox1.ResetText()
                TextBox2.ResetText()
            End If
        Else
            Label3.Text = "Invalid login!!! try again"
            TextBox1.ResetText()
            TextBox2.ResetText()
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TechConnect.Login' table. You can move, or remove it, as needed.
        'Me.LoginTableAdapter.Fill(Me.TechConnect.Login)

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        TextBox2.UseSystemPasswordChar = CheckBox1.Checked
    End Sub
End Class