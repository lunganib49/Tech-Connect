Public Class Add_Staff
    Dim Email As Boolean
    Dim Email1 As Boolean
    Private Sub StaffBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.StaffBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TechConnect)

    End Sub

    Private Sub Add_Teacher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TechConnect.Staff' table. You can move, or remove it, as needed.
        Me.StaffTableAdapter.Fill(Me.TechConnect.Staff)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Me.StaffTableAdapter.Insert(First_NameTextBox.Text, Last_NameTextBox.Text, QualificationTextBox.Text, Phone_NoTextBox.Text, Email_AddressTextBox.Text, GenderComboBox.Text, DateOfBirthDateTimePicker.Text, Year_EmployedDateTimePicker.Text, PositionComboBox.Text, StatusComboBox.Text)
        'Me.StaffTableAdapter.Fill(Me.TechConnect.Staff)

        Email = System.Text.RegularExpressions.Regex.IsMatch(Email_AddressTextBox.Text, "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$")
        Email1 = System.Text.RegularExpressions.Regex.IsMatch(Email_AddressTextBox.Text, "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$")
        If First_NameTextBox.Text = "" Or Last_NameTextBox.Text = "" Or QualificationComboBox.Text = "" Or Phone_NoTextBox.Text = "" Or Email_AddressTextBox.Text = "" Or GenderComboBox.Text = "" Or PositionComboBox.Text = "" Or StatusComboBox.Text = "" Then
            ' MsgBox("Hi!!!")
            Label16.Text = "Missing information!!! "
            Label16.ForeColor = Color.Red



        Else
            If Email And Email1 Then

                Me.StaffTableAdapter.Insert(First_NameTextBox.Text, Last_NameTextBox.Text, QualificationComboBox.Text, Phone_NoTextBox.Text, Email_AddressTextBox.Text, GenderComboBox.Text, DateOfBirthDateTimePicker.Text, Year_EmployedDateTimePicker.Text, PositionComboBox.Text, StatusComboBox.Text)
                Me.StaffTableAdapter.Fill(Me.TechConnect.Staff)

                First_NameTextBox.Clear()
                Last_NameTextBox.Clear()
                DateOfBirthDateTimePicker.ResetText()
                QualificationComboBox.SelectedText = ""
                GenderComboBox.SelectedText = ""
                Email_AddressTextBox.Clear()
                Phone_NoTextBox.Clear()
                StatusComboBox.SelectedText = ""
                PositionComboBox.SelectedText = ""
                Year_EmployedDateTimePicker.ResetText()
            Else
                MsgBox("Hi!!!")
                Label17.Text = "Invalid email address!!!"
                Label17.ForeColor = Color.Red
                Email_AddressTextBox.Clear()

            End If
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()

    End Sub
End Class