Public Class Add_Student

    Dim Email As Boolean
    Dim Email1 As Boolean
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Add_Button.Click

        'StudentTableAdapter1.Insert(txtID_No.Text, txtGrade.Text, txtFirst_Name.Text, txtLast_Name.Text, txtDOB.Text, txtGender.Text, txtEmail.Text, CInt(txtPhone_No.Text), txtName.Text, txtSurname.Text, txtRelationship.Text, CInt(txtContact_No.Text), txtName2.Text, txtSurname2.Text, txtRelationship2.Text, txtContact_No2.Text)
        Email = System.Text.RegularExpressions.Regex.IsMatch(txtEmail.Text, "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$")
        Email1 = System.Text.RegularExpressions.Regex.IsMatch(txtEmail.Text, "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$")
        If txtID_No.Text.Length <> 13 Or txtGrade.Text = "" Or txtFirst_Name.Text = "" Or txtLast_Name.Text = "" Or txtDOB.Text = "" Or txtGender.Text = "" Or txtEmail.Text = "" Or txtPhone_No.Text.Length <> 10 Or txtName.Text = "" Or txtSurname.Text = "" Or txtRelationship.Text = "" Or txtContact_No.Text.Length <> 10 Then
            Label5.Text = "Missing information!!! "
            Label5.ForeColor = Color.Red
            If Email And Email1 Then
            Else
                Label22.Text = "Invalid email address!!!"
                Label22.ForeColor = Color.Red
                txtEmail.Clear()
            End If
            If txtID_No.Text.Length <> 13 Then
                Label25.Text = "Invalid ID_No!!!"
                Label25.ForeColor = Color.Red
                txtID_No.Clear()
            End If


        Else
                If txtName2.Text = "" And txtSurname2.Text = "" And txtRelationship2.Text = "" And txtContact_No2.Text = "" Then
                txtName2.Text = vbNull
                txtSurname2.Text = vbNull
                txtRelationship2.Text = vbNull
                txtContact_No2.Text = vbNull

            End If


            If Email And Email1 Then

                StudentTableAdapter1.Insert(txtID_No.Text, txtGrade.Text, txtFirst_Name.Text, txtLast_Name.Text, txtDOB.Text, txtGender.Text, txtEmail.Text, CInt(txtPhone_No.Text), txtName.Text, txtSurname.Text, txtRelationship.Text, CInt(txtContact_No.Text), txtName2.Text, txtSurname2.Text, txtRelationship2.Text, CInt(txtContact_No2.Text))
                Me.StudentTableAdapter1.Fill(Me.TechConnect1.Student) '
                txtID_No.Clear()
                txtGrade.ResetText()
                txtFirst_Name.Clear()
                txtLast_Name.Clear()
                txtDOB.ResetText()
                txtGender.ResetText()
                txtEmail.Clear()
                txtPhone_No.Clear()
                txtName.Clear()
                txtSurname.Clear()
                txtRelationship.Clear()
                txtContact_No.Clear()
                txtName2.Clear()
                txtSurname2.Clear()
                txtContact_No2.Clear()
                txtRelationship2.Clear()
            Else
                Label22.Text = "Invalid email address!!!"
                Label22.ForeColor = Color.Red

            End If
        End If

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub StudentBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.StudentBindingSource.EndEdit()
        Me.TableAdapterManager1.UpdateAll(Me.TechConnect1)

    End Sub

    Private Sub StudentDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles StudentDataGridView.CellContentClick

    End Sub

    Private Sub Add_Student_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TechConnect1._Class' table. You can move, or remove it, as needed.
        Me.ClassTableAdapter1.Fill(Me.TechConnect1._Class)
        Me.StudentTableAdapter1.Fill(Me.TechConnect1.Student)


    End Sub

    Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
        Me.Hide()
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub txtContact_No2_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtContact_No2.MaskInputRejected

    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub
End Class