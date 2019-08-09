Public Class Staff_Details
    Private Sub StaffBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.StaffBindingSource.EndEdit()
        Me.TableAdapterManager1.UpdateAll(Me.TechConnect)

    End Sub

    Private Sub Staff_Details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TechConnect.Staff' table. You can move, or remove it, as needed.
        Me.StaffTableAdapter.Fill(Me.TechConnect.Staff)
        TextBox1.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If RadioButton1.Checked = True Then
            StaffBindingSource.Filter = "First_Name LIKE '*" & TextBox1.Text & "*'"

        Else RadioButton2.Checked = True
            TextBox1.Enabled = True
            StaffBindingSource.Filter = "Last_Name LIKE '*" & TextBox1.Text & "*'"
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        TextBox1.Enabled = True
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        TextBox1.Enabled = True
    End Sub
End Class