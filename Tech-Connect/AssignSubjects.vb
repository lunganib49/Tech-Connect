Public Class AssignSubjects
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TechConnect.Subject' table. You can move, or remove it, as needed.
        Me.SubjectTableAdapter.Fill(Me.TechConnect.Subject)
        'TODO: This line of code loads data into the 'TechConnect.Student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter.Fill(Me.TechConnect.Student)
        'TODO: This line of code loads data into the 'TechConnect.Staff' table. You can move, or remove it, as needed.
        Me.StaffTableAdapter.Fill(Me.TechConnect.Staff)
        'TODO: This line of code loads data into the 'TechConnect.AssignSubjectStudent' table. You can move, or remove it, as needed.
        Me.AssignSubjectStudentTableAdapter.Fill(Me.TechConnect.AssignSubjectStudent)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            AssignSubjectStudentTableAdapter.Insert(ComboBoxID.Text, ComboBoxSubjectCode.Text, TextBoxAcademicY.Text)
            Me.AssignSubjectStudentTableAdapter.Fill(Me.TechConnect.AssignSubjectStudent)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()

    End Sub
End Class