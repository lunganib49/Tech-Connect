<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AssignSubjects
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdentityNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubjectCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AcademicYearDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AssignSubjectStudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TechConnect = New Tech_Connect.TechConnect()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBoxID = New System.Windows.Forms.ComboBox()
        Me.StudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBoxSubjectCode = New System.Windows.Forms.ComboBox()
        Me.SubjectBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.textGrade = New System.Windows.Forms.MaskedTextBox()
        Me.TextBoxAcademicY = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox4 = New System.Windows.Forms.MaskedTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.AssignSubjectStudentTableAdapter = New Tech_Connect.TechConnectTableAdapters.AssignSubjectStudentTableAdapter()
        Me.StaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaffTableAdapter = New Tech_Connect.TechConnectTableAdapters.StaffTableAdapter()
        Me.StudentTableAdapter = New Tech_Connect.TechConnectTableAdapters.StudentTableAdapter()
        Me.SubjectTableAdapter = New Tech_Connect.TechConnectTableAdapters.SubjectTableAdapter()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AssignSubjectStudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TechConnect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubjectBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdentityNoDataGridViewTextBoxColumn, Me.SubjectCodeDataGridViewTextBoxColumn, Me.AcademicYearDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.AssignSubjectStudentBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(505, 66)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(354, 469)
        Me.DataGridView1.TabIndex = 0
        '
        'IdentityNoDataGridViewTextBoxColumn
        '
        Me.IdentityNoDataGridViewTextBoxColumn.DataPropertyName = "Identity_No"
        Me.IdentityNoDataGridViewTextBoxColumn.HeaderText = "Identity_No"
        Me.IdentityNoDataGridViewTextBoxColumn.Name = "IdentityNoDataGridViewTextBoxColumn"
        '
        'SubjectCodeDataGridViewTextBoxColumn
        '
        Me.SubjectCodeDataGridViewTextBoxColumn.DataPropertyName = "Subject_Code"
        Me.SubjectCodeDataGridViewTextBoxColumn.HeaderText = "Subject_Code"
        Me.SubjectCodeDataGridViewTextBoxColumn.Name = "SubjectCodeDataGridViewTextBoxColumn"
        '
        'AcademicYearDataGridViewTextBoxColumn
        '
        Me.AcademicYearDataGridViewTextBoxColumn.DataPropertyName = "Academic_Year"
        Me.AcademicYearDataGridViewTextBoxColumn.HeaderText = "Academic_Year"
        Me.AcademicYearDataGridViewTextBoxColumn.Name = "AcademicYearDataGridViewTextBoxColumn"
        '
        'AssignSubjectStudentBindingSource
        '
        Me.AssignSubjectStudentBindingSource.DataMember = "AssignSubjectStudent"
        Me.AssignSubjectStudentBindingSource.DataSource = Me.TechConnect
        '
        'TechConnect
        '
        Me.TechConnect.DataSetName = "TechConnect"
        Me.TechConnect.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(135, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Identity Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(190, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Grade"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(148, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Subject Code"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(145, 220)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Subject Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(139, 263)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Academic Year"
        '
        'ComboBoxID
        '
        Me.ComboBoxID.DataSource = Me.StudentBindingSource
        Me.ComboBoxID.DisplayMember = "Identity_No"
        Me.ComboBoxID.FormattingEnabled = True
        Me.ComboBoxID.Location = New System.Drawing.Point(259, 85)
        Me.ComboBoxID.Name = "ComboBoxID"
        Me.ComboBoxID.Size = New System.Drawing.Size(200, 21)
        Me.ComboBoxID.TabIndex = 6
        '
        'StudentBindingSource
        '
        Me.StudentBindingSource.DataMember = "Student"
        Me.StudentBindingSource.DataSource = Me.TechConnect
        '
        'ComboBoxSubjectCode
        '
        Me.ComboBoxSubjectCode.DataSource = Me.SubjectBindingSource
        Me.ComboBoxSubjectCode.DisplayMember = "Subject_Code"
        Me.ComboBoxSubjectCode.FormattingEnabled = True
        Me.ComboBoxSubjectCode.Location = New System.Drawing.Point(259, 173)
        Me.ComboBoxSubjectCode.Name = "ComboBoxSubjectCode"
        Me.ComboBoxSubjectCode.Size = New System.Drawing.Size(200, 21)
        Me.ComboBoxSubjectCode.TabIndex = 7
        '
        'SubjectBindingSource
        '
        Me.SubjectBindingSource.DataMember = "Subject"
        Me.SubjectBindingSource.DataSource = Me.TechConnect
        '
        'textGrade
        '
        Me.textGrade.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "Grade", True))
        Me.textGrade.Location = New System.Drawing.Point(259, 129)
        Me.textGrade.Name = "textGrade"
        Me.textGrade.ReadOnly = True
        Me.textGrade.Size = New System.Drawing.Size(200, 20)
        Me.textGrade.TabIndex = 8
        '
        'TextBoxAcademicY
        '
        Me.TextBoxAcademicY.Location = New System.Drawing.Point(259, 260)
        Me.TextBoxAcademicY.Mask = "0000"
        Me.TextBoxAcademicY.Name = "TextBoxAcademicY"
        Me.TextBoxAcademicY.Size = New System.Drawing.Size(200, 20)
        Me.TextBoxAcademicY.TabIndex = 10
        '
        'MaskedTextBox4
        '
        Me.MaskedTextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SubjectBindingSource, "Subject_Name", True))
        Me.MaskedTextBox4.Location = New System.Drawing.Point(259, 217)
        Me.MaskedTextBox4.Name = "MaskedTextBox4"
        Me.MaskedTextBox4.ReadOnly = True
        Me.MaskedTextBox4.Size = New System.Drawing.Size(200, 20)
        Me.MaskedTextBox4.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(173, 333)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(266, 48)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "ASSIGN SUBJECTS"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'AssignSubjectStudentTableAdapter
        '
        Me.AssignSubjectStudentTableAdapter.ClearBeforeFill = True
        '
        'StaffBindingSource
        '
        Me.StaffBindingSource.DataMember = "Staff"
        Me.StaffBindingSource.DataSource = Me.TechConnect
        '
        'StaffTableAdapter
        '
        Me.StaffTableAdapter.ClearBeforeFill = True
        '
        'StudentTableAdapter
        '
        Me.StudentTableAdapter.ClearBeforeFill = True
        '
        'SubjectTableAdapter
        '
        Me.SubjectTableAdapter.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(173, 397)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(266, 42)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "CANCEL"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'AssignSubjects
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(962, 587)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ComboBoxID)
        Me.Controls.Add(Me.MaskedTextBox4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBoxSubjectCode)
        Me.Controls.Add(Me.TextBoxAcademicY)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.textGrade)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "AssignSubjects"
        Me.Text = "Assign Subject To Student"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AssignSubjectStudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TechConnect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubjectBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBoxID As ComboBox
    Friend WithEvents ComboBoxSubjectCode As ComboBox
    Friend WithEvents textGrade As MaskedTextBox
    Friend WithEvents TextBoxAcademicY As MaskedTextBox
    Friend WithEvents MaskedTextBox4 As MaskedTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TechConnect As TechConnect
    Friend WithEvents AssignSubjectStudentBindingSource As BindingSource
    Friend WithEvents AssignSubjectStudentTableAdapter As TechConnectTableAdapters.AssignSubjectStudentTableAdapter
    Friend WithEvents IdentityNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SubjectCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AcademicYearDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StaffBindingSource As BindingSource
    Friend WithEvents StaffTableAdapter As TechConnectTableAdapters.StaffTableAdapter
    Friend WithEvents StudentBindingSource As BindingSource
    Friend WithEvents StudentTableAdapter As TechConnectTableAdapters.StudentTableAdapter
    Friend WithEvents SubjectBindingSource As BindingSource
    Friend WithEvents SubjectTableAdapter As TechConnectTableAdapters.SubjectTableAdapter
    Friend WithEvents Button2 As Button
End Class
