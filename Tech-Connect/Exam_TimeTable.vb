Public Class Exam_TimeTable
    Private Sub Exam_TimeTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TechConnect.Subject' table. You can move, or remove it, as needed.
        Me.SubjectTableAdapter.Fill(Me.TechConnect.Subject)
        'TODO: This line of code loads data into the 'TechConnect._Class' table. You can move, or remove it, as needed.
        Me.ClassTableAdapter.Fill(Me.TechConnect._Class)
        'TODO: This line of code loads data into the 'TechConnect.Exam_Timetable' table. You can move, or remove it, as needed.
        Me.Exam_TimetableTableAdapter.Fill(Me.TechConnect.Exam_Timetable)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Exam_TimetableTableAdapter.InsertQuery(ComboBoxGrade.Text, DateTimePicker1.Text, txtTime.Text, ComboBoxSubject.Text, txtVenue.Text)
            Me.Exam_TimetableTableAdapter.Fill(Me.TechConnect.Exam_Timetable)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub
End Class