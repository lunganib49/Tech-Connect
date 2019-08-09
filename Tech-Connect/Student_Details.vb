Public Class Student_Details
    Private Sub StudentBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.StudentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Group22DataSet)

    End Sub

    Private Sub Student_Details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TechConnect.Student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter1.Fill(Me.TechConnect.Student)
        'TODO: This line of code loads data into the 'Group22DataSet.Exam_Mark' table. You can move, or remove it, as needed.
        ' Me.Exam_MarkTableAdapter.Fill(Me.Group22DataSet.Exam_Mark)
        'TODO: This line of code loads data into the 'Group22DataSet.Student' table. You can move, or remove it, as needed.
        'Me.StudentTableAdapter.Fill(Me.Group22DataSet.Student)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox5.SelectedIndexChanged
        'StudentBindingSource.Filter = "Fname like'%" & ComboBox5.Text & "%'"
        Try
            StudentBindingSource.Filter = "Fname LIKE '*" & ComboBox5.SelectedItem & "*'"
        Catch
        End Try
    End Sub
End Class
