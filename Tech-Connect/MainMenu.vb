Public Class MainMenu
    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AddStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddStudentToolStripMenuItem.Click
        Add_Student.Show()

    End Sub

    Private Sub StudentDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentDetailsToolStripMenuItem.Click
        Student_Deatails.Show()

    End Sub

    Private Sub AddClassToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddClassToolStripMenuItem.Click
        Add_Staff.Show()

    End Sub

    Private Sub ExamTimeTableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExamTimeTableToolStripMenuItem.Click
        Exam_TimeTable.Show()

    End Sub

    Private Sub AddSubjectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddSubjectToolStripMenuItem.Click
        AddSubject.Show()

    End Sub

    Private Sub AssignSubjectToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AssignSubjectToolStripMenuItem1.Click
        AssignSubjects.Show()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim choice As DialogResult = MessageBox.Show("ARE YOU SURE ?", "CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If choice = DialogResult.Yes Then
            Me.Hide()
            Login.Show()
        End If

    End Sub

    Private Sub ClassDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClassDetailsToolStripMenuItem.Click
        Staff_Details.Show()

    End Sub

    Private Sub UpdateStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateStudentToolStripMenuItem.Click
        UpdateStudent.Show()

    End Sub

    Private Sub UpdateStaffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateStaffToolStripMenuItem.Click
        UpdateStaff.Show()

    End Sub
End Class