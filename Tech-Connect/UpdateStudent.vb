Public Class UpdateStudent
    Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
        Me.Hide()

    End Sub

    Private Sub UpdateStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TechConnect.Student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter.Fill(Me.TechConnect.Student)

    End Sub

    Private Sub Add_Button_Click(sender As Object, e As EventArgs) Handles Add_Button.Click
        StudentBindingSource.EndEdit()
        StudentTableAdapter.Update(TechConnect.Student)
        Me.StudentTableAdapter.Fill(Me.TechConnect.Student)
    End Sub
End Class