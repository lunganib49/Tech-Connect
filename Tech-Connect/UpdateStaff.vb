Public Class UpdateStaff
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()

    End Sub

    Private Sub UpdateStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TechConnect.Staff' table. You can move, or remove it, as needed.
        Me.StaffTableAdapter.Fill(Me.TechConnect.Staff)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        StaffBindingSource.EndEdit()
        StaffTableAdapter.Update(TechConnect.Staff)
        Me.StaffTableAdapter.Fill(Me.TechConnect.Staff)
    End Sub
End Class