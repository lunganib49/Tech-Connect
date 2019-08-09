<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UpdateStaff
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Year_EmployedLabel As System.Windows.Forms.Label
        Dim Last_NameLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Dim PositionLabel As System.Windows.Forms.Label
        Dim DateOfBirthLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim Email_AddressLabel As System.Windows.Forms.Label
        Dim Phone_NoLabel As System.Windows.Forms.Label
        Dim QualificationLabel As System.Windows.Forms.Label
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Me.Phone_NoTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.StaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TechConnect = New Tech_Connect.TechConnect()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Last_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.StaffDataGridView = New System.Windows.Forms.DataGridView()
        Me.StaffNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QualificationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailAddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateOfBirthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YearEmployedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PositionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusComboBox = New System.Windows.Forms.ComboBox()
        Me.Email_AddressTextBox = New System.Windows.Forms.TextBox()
        Me.First_NameTextBox = New System.Windows.Forms.TextBox()
        Me.StaffTableAdapter = New Tech_Connect.TechConnectTableAdapters.StaffTableAdapter()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Year_EmployedLabel = New System.Windows.Forms.Label()
        Last_NameLabel = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        PositionLabel = New System.Windows.Forms.Label()
        DateOfBirthLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        Email_AddressLabel = New System.Windows.Forms.Label()
        Phone_NoLabel = New System.Windows.Forms.Label()
        QualificationLabel = New System.Windows.Forms.Label()
        First_NameLabel = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TechConnect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Year_EmployedLabel
        '
        Year_EmployedLabel.AutoSize = True
        Year_EmployedLabel.Location = New System.Drawing.Point(37, 286)
        Year_EmployedLabel.Name = "Year_EmployedLabel"
        Year_EmployedLabel.Size = New System.Drawing.Size(95, 13)
        Year_EmployedLabel.TabIndex = 72
        Year_EmployedLabel.Text = "Year Employed:"
        '
        'Last_NameLabel
        '
        Last_NameLabel.AutoSize = True
        Last_NameLabel.Location = New System.Drawing.Point(63, 106)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(71, 13)
        Last_NameLabel.TabIndex = 70
        Last_NameLabel.Text = "Last Name:"
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Location = New System.Drawing.Point(382, 312)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(47, 13)
        StatusLabel.TabIndex = 65
        StatusLabel.Text = "Status:"
        '
        'PositionLabel
        '
        PositionLabel.AutoSize = True
        PositionLabel.Location = New System.Drawing.Point(76, 312)
        PositionLabel.Name = "PositionLabel"
        PositionLabel.Size = New System.Drawing.Size(56, 13)
        PositionLabel.TabIndex = 63
        PositionLabel.Text = "Position:"
        '
        'DateOfBirthLabel
        '
        DateOfBirthLabel.AutoSize = True
        DateOfBirthLabel.Location = New System.Drawing.Point(44, 258)
        DateOfBirthLabel.Name = "DateOfBirthLabel"
        DateOfBirthLabel.Size = New System.Drawing.Size(85, 13)
        DateOfBirthLabel.TabIndex = 61
        DateOfBirthLabel.Text = "Date Of Birth:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Location = New System.Drawing.Point(80, 227)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(52, 13)
        GenderLabel.TabIndex = 59
        GenderLabel.Text = "Gender:"
        '
        'Email_AddressLabel
        '
        Email_AddressLabel.AutoSize = True
        Email_AddressLabel.Location = New System.Drawing.Point(42, 198)
        Email_AddressLabel.Name = "Email_AddressLabel"
        Email_AddressLabel.Size = New System.Drawing.Size(90, 13)
        Email_AddressLabel.TabIndex = 57
        Email_AddressLabel.Text = "Email Address:"
        '
        'Phone_NoLabel
        '
        Phone_NoLabel.AutoSize = True
        Phone_NoLabel.Location = New System.Drawing.Point(65, 169)
        Phone_NoLabel.Name = "Phone_NoLabel"
        Phone_NoLabel.Size = New System.Drawing.Size(67, 13)
        Phone_NoLabel.TabIndex = 56
        Phone_NoLabel.Text = "Phone No:"
        '
        'QualificationLabel
        '
        QualificationLabel.AutoSize = True
        QualificationLabel.Location = New System.Drawing.Point(52, 136)
        QualificationLabel.Name = "QualificationLabel"
        QualificationLabel.Size = New System.Drawing.Size(82, 13)
        QualificationLabel.TabIndex = 55
        QualificationLabel.Text = "Qualification:"
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.Location = New System.Drawing.Point(64, 76)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(71, 13)
        First_NameLabel.TabIndex = 53
        First_NameLabel.Text = "First Name:"
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.Location = New System.Drawing.Point(47, 44)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(85, 13)
        Label11.TabIndex = 94
        Label11.Text = "Staff Number:"
        '
        'Phone_NoTextBox
        '
        Me.Phone_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Phone_No", True))
        Me.Phone_NoTextBox.Location = New System.Drawing.Point(151, 166)
        Me.Phone_NoTextBox.Name = "Phone_NoTextBox"
        Me.Phone_NoTextBox.Size = New System.Drawing.Size(189, 20)
        Me.Phone_NoTextBox.TabIndex = 91
        '
        'StaffBindingSource
        '
        Me.StaffBindingSource.DataMember = "Staff"
        Me.StaffBindingSource.DataSource = Me.TechConnect
        '
        'TechConnect
        '
        Me.TechConnect.DataSetName = "TechConnect"
        Me.TechConnect.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.Red
        Me.Label17.Location = New System.Drawing.Point(347, 172)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(0, 13)
        Me.Label17.TabIndex = 90
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(371, 28)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(0, 13)
        Me.Label16.TabIndex = 89
        '
        'Last_NameTextBox
        '
        Me.Last_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Last_Name", True))
        Me.Last_NameTextBox.Location = New System.Drawing.Point(152, 99)
        Me.Last_NameTextBox.Name = "Last_NameTextBox"
        Me.Last_NameTextBox.Size = New System.Drawing.Size(187, 20)
        Me.Last_NameTextBox.TabIndex = 71
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(765, 713)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(161, 43)
        Me.Button2.TabIndex = 69
        Me.Button2.Text = "CANCEL"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(591, 713)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(151, 43)
        Me.Button1.TabIndex = 68
        Me.Button1.Text = "UPDATE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'StaffDataGridView
        '
        Me.StaffDataGridView.AutoGenerateColumns = False
        Me.StaffDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StaffDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StaffNoDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.QualificationDataGridViewTextBoxColumn, Me.PhoneNoDataGridViewTextBoxColumn, Me.EmailAddressDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.DateOfBirthDataGridViewTextBoxColumn, Me.YearEmployedDataGridViewTextBoxColumn, Me.PositionDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn})
        Me.StaffDataGridView.DataSource = Me.StaffBindingSource
        Me.StaffDataGridView.Location = New System.Drawing.Point(12, 354)
        Me.StaffDataGridView.Name = "StaffDataGridView"
        Me.StaffDataGridView.Size = New System.Drawing.Size(914, 353)
        Me.StaffDataGridView.TabIndex = 67
        '
        'StaffNoDataGridViewTextBoxColumn
        '
        Me.StaffNoDataGridViewTextBoxColumn.DataPropertyName = "Staff_No"
        Me.StaffNoDataGridViewTextBoxColumn.HeaderText = "Staff_No"
        Me.StaffNoDataGridViewTextBoxColumn.Name = "StaffNoDataGridViewTextBoxColumn"
        Me.StaffNoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "First_Name"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "First_Name"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "Last_Name"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "Last_Name"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        '
        'QualificationDataGridViewTextBoxColumn
        '
        Me.QualificationDataGridViewTextBoxColumn.DataPropertyName = "Qualification"
        Me.QualificationDataGridViewTextBoxColumn.HeaderText = "Qualification"
        Me.QualificationDataGridViewTextBoxColumn.Name = "QualificationDataGridViewTextBoxColumn"
        '
        'PhoneNoDataGridViewTextBoxColumn
        '
        Me.PhoneNoDataGridViewTextBoxColumn.DataPropertyName = "Phone_No"
        Me.PhoneNoDataGridViewTextBoxColumn.HeaderText = "Phone_No"
        Me.PhoneNoDataGridViewTextBoxColumn.Name = "PhoneNoDataGridViewTextBoxColumn"
        '
        'EmailAddressDataGridViewTextBoxColumn
        '
        Me.EmailAddressDataGridViewTextBoxColumn.DataPropertyName = "Email_Address"
        Me.EmailAddressDataGridViewTextBoxColumn.HeaderText = "Email_Address"
        Me.EmailAddressDataGridViewTextBoxColumn.Name = "EmailAddressDataGridViewTextBoxColumn"
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "Gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "Gender"
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        '
        'DateOfBirthDataGridViewTextBoxColumn
        '
        Me.DateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth"
        Me.DateOfBirthDataGridViewTextBoxColumn.HeaderText = "DateOfBirth"
        Me.DateOfBirthDataGridViewTextBoxColumn.Name = "DateOfBirthDataGridViewTextBoxColumn"
        '
        'YearEmployedDataGridViewTextBoxColumn
        '
        Me.YearEmployedDataGridViewTextBoxColumn.DataPropertyName = "Year_Employed"
        Me.YearEmployedDataGridViewTextBoxColumn.HeaderText = "Year_Employed"
        Me.YearEmployedDataGridViewTextBoxColumn.Name = "YearEmployedDataGridViewTextBoxColumn"
        '
        'PositionDataGridViewTextBoxColumn
        '
        Me.PositionDataGridViewTextBoxColumn.DataPropertyName = "Position"
        Me.PositionDataGridViewTextBoxColumn.HeaderText = "Position"
        Me.PositionDataGridViewTextBoxColumn.Name = "PositionDataGridViewTextBoxColumn"
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "Status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        '
        'StatusComboBox
        '
        Me.StatusComboBox.DataSource = Me.StaffBindingSource
        Me.StatusComboBox.DisplayMember = "Staff_No"
        Me.StatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.StatusComboBox.FormattingEnabled = True
        Me.StatusComboBox.Location = New System.Drawing.Point(153, 41)
        Me.StatusComboBox.Name = "StatusComboBox"
        Me.StatusComboBox.Size = New System.Drawing.Size(188, 21)
        Me.StatusComboBox.TabIndex = 66
        '
        'Email_AddressTextBox
        '
        Me.Email_AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Email_Address", True))
        Me.Email_AddressTextBox.Location = New System.Drawing.Point(152, 198)
        Me.Email_AddressTextBox.Name = "Email_AddressTextBox"
        Me.Email_AddressTextBox.Size = New System.Drawing.Size(188, 20)
        Me.Email_AddressTextBox.TabIndex = 58
        '
        'First_NameTextBox
        '
        Me.First_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "First_Name", True))
        Me.First_NameTextBox.Location = New System.Drawing.Point(152, 73)
        Me.First_NameTextBox.Name = "First_NameTextBox"
        Me.First_NameTextBox.Size = New System.Drawing.Size(188, 20)
        Me.First_NameTextBox.TabIndex = 54
        '
        'StaffTableAdapter
        '
        Me.StaffTableAdapter.ClearBeforeFill = True
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "DateOfBirth", True))
        Me.MaskedTextBox1.Location = New System.Drawing.Point(151, 251)
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(189, 20)
        Me.MaskedTextBox1.TabIndex = 97
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Year_Employed", True))
        Me.TextBox1.Location = New System.Drawing.Point(152, 283)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(188, 20)
        Me.TextBox1.TabIndex = 96
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Gender", True))
        Me.TextBox2.Location = New System.Drawing.Point(151, 225)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(188, 20)
        Me.TextBox2.TabIndex = 98
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Position", True))
        Me.TextBox3.Location = New System.Drawing.Point(151, 309)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(188, 20)
        Me.TextBox3.TabIndex = 99
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Status", True))
        Me.TextBox4.Location = New System.Drawing.Point(453, 309)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(188, 20)
        Me.TextBox4.TabIndex = 100
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Qualification", True))
        Me.TextBox5.Location = New System.Drawing.Point(152, 133)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(187, 20)
        Me.TextBox5.TabIndex = 101
        '
        'UpdateStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(953, 773)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Label11)
        Me.Controls.Add(Me.Phone_NoTextBox)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Year_EmployedLabel)
        Me.Controls.Add(Last_NameLabel)
        Me.Controls.Add(Me.Last_NameTextBox)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.StaffDataGridView)
        Me.Controls.Add(StatusLabel)
        Me.Controls.Add(Me.StatusComboBox)
        Me.Controls.Add(PositionLabel)
        Me.Controls.Add(DateOfBirthLabel)
        Me.Controls.Add(GenderLabel)
        Me.Controls.Add(Email_AddressLabel)
        Me.Controls.Add(Me.Email_AddressTextBox)
        Me.Controls.Add(Phone_NoLabel)
        Me.Controls.Add(QualificationLabel)
        Me.Controls.Add(First_NameLabel)
        Me.Controls.Add(Me.First_NameTextBox)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "UpdateStaff"
        Me.Text = "Update Staff"
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TechConnect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Phone_NoTextBox As MaskedTextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Last_NameTextBox As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents StaffDataGridView As DataGridView
    Friend WithEvents StatusComboBox As ComboBox
    Friend WithEvents Email_AddressTextBox As TextBox
    Friend WithEvents First_NameTextBox As TextBox
    Friend WithEvents TechConnect As TechConnect
    Friend WithEvents StaffBindingSource As BindingSource
    Friend WithEvents StaffTableAdapter As TechConnectTableAdapters.StaffTableAdapter
    Friend WithEvents StaffNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QualificationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhoneNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailAddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateOfBirthDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents YearEmployedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PositionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
End Class
