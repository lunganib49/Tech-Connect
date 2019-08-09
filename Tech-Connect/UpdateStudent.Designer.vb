<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateStudent
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdateStudent))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtRelationship2 = New System.Windows.Forms.MaskedTextBox()
        Me.StudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TechConnect = New Tech_Connect.TechConnect()
        Me.txtContact_No2 = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSurname2 = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtName2 = New System.Windows.Forms.MaskedTextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtRelationship = New System.Windows.Forms.MaskedTextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtContact_No = New System.Windows.Forms.MaskedTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.label = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.txtName = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSurname = New System.Windows.Forms.MaskedTextBox()
        Me.Add_Button = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.txtID_No = New System.Windows.Forms.MaskedTextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPhone_No = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtLast_Name = New System.Windows.Forms.MaskedTextBox()
        Me.txtFirst_Name = New System.Windows.Forms.MaskedTextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtGender = New System.Windows.Forms.ComboBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdentityNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GradeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateOfBirthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GuardianNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GuardianSurnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GuardianRelationshipDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GuardianPhoneNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Guardian2NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Guardian2SurnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Guardian2RelationshipDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Guardian2PhoneNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentTableAdapter = New Tech_Connect.TechConnectTableAdapters.StudentTableAdapter()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TechConnect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(14, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1128, 827)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1120, 801)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Student Information"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.Cancel_Button)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Add_Button)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(105, 262)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(894, 533)
        Me.GroupBox1.TabIndex = 53
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Gaurdian Information"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtRelationship2)
        Me.GroupBox4.Controls.Add(Me.txtContact_No2)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.txtSurname2)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.txtName2)
        Me.GroupBox4.Controls.Add(Me.Button4)
        Me.GroupBox4.Controls.Add(Me.PictureBox1)
        Me.GroupBox4.Location = New System.Drawing.Point(22, 257)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(626, 210)
        Me.GroupBox4.TabIndex = 55
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Guardian2(Optional)"
        '
        'txtRelationship2
        '
        Me.txtRelationship2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "Guardian2_Relationship", True))
        Me.txtRelationship2.Location = New System.Drawing.Point(185, 94)
        Me.txtRelationship2.Name = "txtRelationship2"
        Me.txtRelationship2.Size = New System.Drawing.Size(176, 20)
        Me.txtRelationship2.TabIndex = 65
        '
        'StudentBindingSource
        '
        Me.StudentBindingSource.DataMember = "Student"
        Me.StudentBindingSource.DataSource = Me.TechConnect
        '
        'TechConnect
        '
        Me.TechConnect.DataSetName = "TechConnect"
        Me.TechConnect.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtContact_No2
        '
        Me.txtContact_No2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "Guardian2_Phone_No", True))
        Me.txtContact_No2.Location = New System.Drawing.Point(185, 124)
        Me.txtContact_No2.Name = "txtContact_No2"
        Me.txtContact_No2.Size = New System.Drawing.Size(176, 20)
        Me.txtContact_No2.TabIndex = 64
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(111, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(101, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "Surname"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(80, 94)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Relationship"
        '
        'txtSurname2
        '
        Me.txtSurname2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "Guardian2_Surname", True))
        Me.txtSurname2.Location = New System.Drawing.Point(185, 59)
        Me.txtSurname2.Name = "txtSurname2"
        Me.txtSurname2.Size = New System.Drawing.Size(176, 20)
        Me.txtSurname2.TabIndex = 61
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(80, 127)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Contact No."
        '
        'txtName2
        '
        Me.txtName2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "Guardian2_Name", True))
        Me.txtName2.Location = New System.Drawing.Point(185, 21)
        Me.txtName2.Name = "txtName2"
        Me.txtName2.Size = New System.Drawing.Size(176, 20)
        Me.txtName2.TabIndex = 60
        '
        'Button4
        '
        Me.Button4.Enabled = False
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(406, 178)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(87, 23)
        Me.Button4.TabIndex = 18
        Me.Button4.Text = "Browse"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(390, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(144, 146)
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel_Button.Location = New System.Drawing.Point(527, 475)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(121, 35)
        Me.Cancel_Button.TabIndex = 40
        Me.Cancel_Button.Text = "CANCEL"
        Me.Cancel_Button.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtRelationship)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.txtContact_No)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.label)
        Me.GroupBox2.Controls.Add(Me.Button6)
        Me.GroupBox2.Controls.Add(Me.PictureBox4)
        Me.GroupBox2.Controls.Add(Me.txtName)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtSurname)
        Me.GroupBox2.Location = New System.Drawing.Point(22, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(626, 232)
        Me.GroupBox2.TabIndex = 54
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Guardian1 "
        '
        'txtRelationship
        '
        Me.txtRelationship.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "Guardian_Relationship", True))
        Me.txtRelationship.Location = New System.Drawing.Point(185, 83)
        Me.txtRelationship.Name = "txtRelationship"
        Me.txtRelationship.Size = New System.Drawing.Size(176, 20)
        Me.txtRelationship.TabIndex = 64
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(123, 26)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(39, 13)
        Me.Label24.TabIndex = 50
        Me.Label24.Text = "Name"
        '
        'txtContact_No
        '
        Me.txtContact_No.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "Guardian_Phone_No", True))
        Me.txtContact_No.Location = New System.Drawing.Point(185, 111)
        Me.txtContact_No.Name = "txtContact_No"
        Me.txtContact_No.Size = New System.Drawing.Size(176, 20)
        Me.txtContact_No.TabIndex = 63
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(88, 112)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Contact No"
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Location = New System.Drawing.Point(83, 86)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(77, 13)
        Me.label.TabIndex = 1
        Me.label.Text = "Relationship"
        '
        'Button6
        '
        Me.Button6.Enabled = False
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(406, 190)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(87, 23)
        Me.Button6.TabIndex = 8
        Me.Button6.Text = "Browse"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(384, 26)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(144, 148)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 10
        Me.PictureBox4.TabStop = False
        '
        'txtName
        '
        Me.txtName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "Guardian_Name", True))
        Me.txtName.Location = New System.Drawing.Point(185, 26)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(176, 20)
        Me.txtName.TabIndex = 55
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(106, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Surname"
        '
        'txtSurname
        '
        Me.txtSurname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "Guardian_Surname", True))
        Me.txtSurname.Location = New System.Drawing.Point(185, 52)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(176, 20)
        Me.txtSurname.TabIndex = 54
        '
        'Add_Button
        '
        Me.Add_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Add_Button.Location = New System.Drawing.Point(379, 475)
        Me.Add_Button.Name = "Add_Button"
        Me.Add_Button.Size = New System.Drawing.Size(136, 35)
        Me.Add_Button.TabIndex = 39
        Me.Add_Button.Text = "UPDATE"
        Me.Add_Button.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.MaskedTextBox2)
        Me.GroupBox3.Controls.Add(Me.MaskedTextBox1)
        Me.GroupBox3.Controls.Add(Me.txtID_No)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.txtEmail)
        Me.GroupBox3.Controls.Add(Me.txtPhone_No)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.txtLast_Name)
        Me.GroupBox3.Controls.Add(Me.txtFirst_Name)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Me.Label30)
        Me.GroupBox3.Controls.Add(Me.txtGender)
        Me.GroupBox3.Controls.Add(Me.Label32)
        Me.GroupBox3.Controls.Add(Me.Label33)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(105, 29)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(894, 218)
        Me.GroupBox3.TabIndex = 52
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Student Details"
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "Grade", True))
        Me.MaskedTextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskedTextBox2.Location = New System.Drawing.Point(388, 108)
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(185, 20)
        Me.MaskedTextBox2.TabIndex = 83
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "Gender", True))
        Me.MaskedTextBox1.Location = New System.Drawing.Point(126, 110)
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(176, 20)
        Me.MaskedTextBox1.TabIndex = 82
        '
        'txtID_No
        '
        Me.txtID_No.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "First_Name", True))
        Me.txtID_No.Location = New System.Drawing.Point(126, 51)
        Me.txtID_No.Name = "txtID_No"
        Me.txtID_No.Size = New System.Drawing.Size(176, 20)
        Me.txtID_No.TabIndex = 81
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(60, 27)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(43, 13)
        Me.Label19.TabIndex = 78
        Me.Label19.Text = "ID_No"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(61, 169)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 13)
        Me.Label8.TabIndex = 72
        Me.Label8.Text = "Email"
        '
        'txtEmail
        '
        Me.txtEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "Email", True))
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(126, 169)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(176, 20)
        Me.txtEmail.TabIndex = 71
        '
        'txtPhone_No
        '
        Me.txtPhone_No.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "Phone_No", True))
        Me.txtPhone_No.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone_No.Location = New System.Drawing.Point(126, 142)
        Me.txtPhone_No.Name = "txtPhone_No"
        Me.txtPhone_No.Size = New System.Drawing.Size(176, 20)
        Me.txtPhone_No.TabIndex = 70
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(334, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "Grade"
        '
        'txtLast_Name
        '
        Me.txtLast_Name.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "Last_Name", True))
        Me.txtLast_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLast_Name.Location = New System.Drawing.Point(388, 54)
        Me.txtLast_Name.Name = "txtLast_Name"
        Me.txtLast_Name.Size = New System.Drawing.Size(185, 20)
        Me.txtLast_Name.TabIndex = 67
        '
        'txtFirst_Name
        '
        Me.txtFirst_Name.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "DateOfBirth", True))
        Me.txtFirst_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirst_Name.Location = New System.Drawing.Point(126, 79)
        Me.txtFirst_Name.Name = "txtFirst_Name"
        Me.txtFirst_Name.Size = New System.Drawing.Size(176, 20)
        Me.txtFirst_Name.TabIndex = 65
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(308, 58)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(67, 13)
        Me.Label21.TabIndex = 46
        Me.Label21.Text = "Last Name"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(36, 54)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(67, 13)
        Me.Label23.TabIndex = 45
        Me.Label23.Text = "First Name"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(35, 145)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(63, 13)
        Me.Label30.TabIndex = 36
        Me.Label30.Text = "Phone No"
        '
        'txtGender
        '
        Me.txtGender.DataSource = Me.StudentBindingSource
        Me.txtGender.DisplayMember = "Identity_No"
        Me.txtGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGender.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtGender.FormattingEnabled = True
        Me.txtGender.Location = New System.Drawing.Point(126, 19)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.Size = New System.Drawing.Size(176, 21)
        Me.txtGender.TabIndex = 27
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(55, 112)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(48, 13)
        Me.Label32.TabIndex = 14
        Me.Label32.Text = "Gender"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(19, 82)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(79, 13)
        Me.Label33.TabIndex = 3
        Me.Label33.Text = "Date of Birth"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.DataGridView1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1120, 801)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Display"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(890, 742)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(186, 37)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "CANCEL"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdentityNoDataGridViewTextBoxColumn, Me.GradeDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.DateOfBirthDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.PhoneNoDataGridViewTextBoxColumn, Me.GuardianNameDataGridViewTextBoxColumn, Me.GuardianSurnameDataGridViewTextBoxColumn, Me.GuardianRelationshipDataGridViewTextBoxColumn, Me.GuardianPhoneNoDataGridViewTextBoxColumn, Me.Guardian2NameDataGridViewTextBoxColumn, Me.Guardian2SurnameDataGridViewTextBoxColumn, Me.Guardian2RelationshipDataGridViewTextBoxColumn, Me.Guardian2PhoneNoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.StudentBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(31, 61)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1045, 675)
        Me.DataGridView1.TabIndex = 0
        '
        'IdentityNoDataGridViewTextBoxColumn
        '
        Me.IdentityNoDataGridViewTextBoxColumn.DataPropertyName = "Identity_No"
        Me.IdentityNoDataGridViewTextBoxColumn.HeaderText = "Identity_No"
        Me.IdentityNoDataGridViewTextBoxColumn.Name = "IdentityNoDataGridViewTextBoxColumn"
        '
        'GradeDataGridViewTextBoxColumn
        '
        Me.GradeDataGridViewTextBoxColumn.DataPropertyName = "Grade"
        Me.GradeDataGridViewTextBoxColumn.HeaderText = "Grade"
        Me.GradeDataGridViewTextBoxColumn.Name = "GradeDataGridViewTextBoxColumn"
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
        'DateOfBirthDataGridViewTextBoxColumn
        '
        Me.DateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth"
        Me.DateOfBirthDataGridViewTextBoxColumn.HeaderText = "DateOfBirth"
        Me.DateOfBirthDataGridViewTextBoxColumn.Name = "DateOfBirthDataGridViewTextBoxColumn"
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "Gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "Gender"
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        '
        'PhoneNoDataGridViewTextBoxColumn
        '
        Me.PhoneNoDataGridViewTextBoxColumn.DataPropertyName = "Phone_No"
        Me.PhoneNoDataGridViewTextBoxColumn.HeaderText = "Phone_No"
        Me.PhoneNoDataGridViewTextBoxColumn.Name = "PhoneNoDataGridViewTextBoxColumn"
        '
        'GuardianNameDataGridViewTextBoxColumn
        '
        Me.GuardianNameDataGridViewTextBoxColumn.DataPropertyName = "Guardian_Name"
        Me.GuardianNameDataGridViewTextBoxColumn.HeaderText = "Guardian_Name"
        Me.GuardianNameDataGridViewTextBoxColumn.Name = "GuardianNameDataGridViewTextBoxColumn"
        '
        'GuardianSurnameDataGridViewTextBoxColumn
        '
        Me.GuardianSurnameDataGridViewTextBoxColumn.DataPropertyName = "Guardian_Surname"
        Me.GuardianSurnameDataGridViewTextBoxColumn.HeaderText = "Guardian_Surname"
        Me.GuardianSurnameDataGridViewTextBoxColumn.Name = "GuardianSurnameDataGridViewTextBoxColumn"
        '
        'GuardianRelationshipDataGridViewTextBoxColumn
        '
        Me.GuardianRelationshipDataGridViewTextBoxColumn.DataPropertyName = "Guardian_Relationship"
        Me.GuardianRelationshipDataGridViewTextBoxColumn.HeaderText = "Guardian_Relationship"
        Me.GuardianRelationshipDataGridViewTextBoxColumn.Name = "GuardianRelationshipDataGridViewTextBoxColumn"
        '
        'GuardianPhoneNoDataGridViewTextBoxColumn
        '
        Me.GuardianPhoneNoDataGridViewTextBoxColumn.DataPropertyName = "Guardian_Phone_No"
        Me.GuardianPhoneNoDataGridViewTextBoxColumn.HeaderText = "Guardian_Phone_No"
        Me.GuardianPhoneNoDataGridViewTextBoxColumn.Name = "GuardianPhoneNoDataGridViewTextBoxColumn"
        '
        'Guardian2NameDataGridViewTextBoxColumn
        '
        Me.Guardian2NameDataGridViewTextBoxColumn.DataPropertyName = "Guardian2_Name"
        Me.Guardian2NameDataGridViewTextBoxColumn.HeaderText = "Guardian2_Name"
        Me.Guardian2NameDataGridViewTextBoxColumn.Name = "Guardian2NameDataGridViewTextBoxColumn"
        '
        'Guardian2SurnameDataGridViewTextBoxColumn
        '
        Me.Guardian2SurnameDataGridViewTextBoxColumn.DataPropertyName = "Guardian2_Surname"
        Me.Guardian2SurnameDataGridViewTextBoxColumn.HeaderText = "Guardian2_Surname"
        Me.Guardian2SurnameDataGridViewTextBoxColumn.Name = "Guardian2SurnameDataGridViewTextBoxColumn"
        '
        'Guardian2RelationshipDataGridViewTextBoxColumn
        '
        Me.Guardian2RelationshipDataGridViewTextBoxColumn.DataPropertyName = "Guardian2_Relationship"
        Me.Guardian2RelationshipDataGridViewTextBoxColumn.HeaderText = "Guardian2_Relationship"
        Me.Guardian2RelationshipDataGridViewTextBoxColumn.Name = "Guardian2RelationshipDataGridViewTextBoxColumn"
        '
        'Guardian2PhoneNoDataGridViewTextBoxColumn
        '
        Me.Guardian2PhoneNoDataGridViewTextBoxColumn.DataPropertyName = "Guardian2_Phone_No"
        Me.Guardian2PhoneNoDataGridViewTextBoxColumn.HeaderText = "Guardian2_Phone_No"
        Me.Guardian2PhoneNoDataGridViewTextBoxColumn.Name = "Guardian2PhoneNoDataGridViewTextBoxColumn"
        '
        'StudentTableAdapter
        '
        Me.StudentTableAdapter.ClearBeforeFill = True
        '
        'UpdateStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1148, 840)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "UpdateStudent"
        Me.Text = "Update Student"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TechConnect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtRelationship2 As MaskedTextBox
    Friend WithEvents txtContact_No2 As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtSurname2 As MaskedTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtName2 As MaskedTextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Cancel_Button As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtRelationship As MaskedTextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents txtContact_No As MaskedTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents label As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents txtName As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSurname As MaskedTextBox
    Friend WithEvents Add_Button As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtID_No As MaskedTextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone_No As MaskedTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtLast_Name As MaskedTextBox
    Friend WithEvents txtFirst_Name As MaskedTextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents txtGender As ComboBox
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents TechConnect As TechConnect
    Friend WithEvents StudentBindingSource As BindingSource
    Friend WithEvents StudentTableAdapter As TechConnectTableAdapters.StudentTableAdapter
    Friend WithEvents IdentityNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GradeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateOfBirthDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhoneNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GuardianNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GuardianSurnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GuardianRelationshipDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GuardianPhoneNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Guardian2NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Guardian2SurnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Guardian2RelationshipDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Guardian2PhoneNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaskedTextBox2 As MaskedTextBox
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
End Class
