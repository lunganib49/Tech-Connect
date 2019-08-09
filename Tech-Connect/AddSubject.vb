Public Class AddSubject
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SubjectTableAdapter.Insert(txtScode.Text, txtSName.Text)
        Me.SubjectTableAdapter.Fill(Me.TechConnect.Subject)
    End Sub

    Private Sub AddSubject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TechConnect.Subject' table. You can move, or remove it, as needed.
        Me.SubjectTableAdapter.Fill(Me.TechConnect.Subject)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub
End Class