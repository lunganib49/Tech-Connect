Public Class Student_Deatails
    Private Sub StudentBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.StudentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TechConnect)

    End Sub

    Private Sub Student_Deatails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TechConnect.Student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter.Fill(Me.TechConnect.Student)
        TextBox1.Enabled = False

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        If RadioButton1.Checked = True Then
            StudentBindingSource.Filter = "First_Name LIKE '*" & TextBox1.Text & "*'"

        Else RadioButton2.Checked = True
            TextBox1.Enabled = True
            StudentBindingSource.Filter = "Last_Name LIKE '*" & TextBox1.Text & "*'"
        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        TextBox1.Enabled = True

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        TextBox1.Enabled = True

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub
End Class