<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Exam_TimeTable
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txtVenue = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxGrade = New System.Windows.Forms.ComboBox()
        Me.ClassBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TechConnect = New Tech_Connect.TechConnect()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBoxSubject = New System.Windows.Forms.ComboBox()
        Me.SubjectBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtTime = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Grade = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GradeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubjectCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VenueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExamTimetableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Exam_TimetableTableAdapter = New Tech_Connect.TechConnectTableAdapters.Exam_TimetableTableAdapter()
        Me.ClassTableAdapter = New Tech_Connect.TechConnectTableAdapters.ClassTableAdapter()
        Me.SubjectTableAdapter = New Tech_Connect.TechConnectTableAdapters.SubjectTableAdapter()
        Me.ExamTimetableBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ClassBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TechConnect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubjectBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExamTimetableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExamTimetableBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.txtVenue)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ComboBoxGrade)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ComboBoxSubject)
        Me.GroupBox1.Controls.Add(Me.txtTime)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Grade)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(48, 58)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(800, 159)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Exam TimeTable"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(476, 46)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(299, 21)
        Me.DateTimePicker1.TabIndex = 11
        '
        'txtVenue
        '
        Me.txtVenue.Location = New System.Drawing.Point(82, 120)
        Me.txtVenue.Mask = "?-????????????"
        Me.txtVenue.Name = "txtVenue"
        Me.txtVenue.Size = New System.Drawing.Size(220, 21)
        Me.txtVenue.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 15)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Venue"
        '
        'ComboBoxGrade
        '
        Me.ComboBoxGrade.DataSource = Me.ClassBindingSource
        Me.ComboBoxGrade.DisplayMember = "Grade"
        Me.ComboBoxGrade.FormattingEnabled = True
        Me.ComboBoxGrade.Location = New System.Drawing.Point(82, 46)
        Me.ComboBoxGrade.Name = "ComboBoxGrade"
        Me.ComboBoxGrade.Size = New System.Drawing.Size(220, 23)
        Me.ComboBoxGrade.TabIndex = 7
        '
        'ClassBindingSource
        '
        Me.ClassBindingSource.DataMember = "Class"
        Me.ClassBindingSource.DataSource = Me.TechConnect
        '
        'TechConnect
        '
        Me.TechConnect.DataSetName = "TechConnect"
        Me.TechConnect.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(426, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Date"
        '
        'ComboBoxSubject
        '
        Me.ComboBoxSubject.DataSource = Me.SubjectBindingSource
        Me.ComboBoxSubject.DisplayMember = "Subject_Code"
        Me.ComboBoxSubject.FormattingEnabled = True
        Me.ComboBoxSubject.Location = New System.Drawing.Point(476, 80)
        Me.ComboBoxSubject.Name = "ComboBoxSubject"
        Me.ComboBoxSubject.Size = New System.Drawing.Size(299, 23)
        Me.ComboBoxSubject.TabIndex = 8
        '
        'SubjectBindingSource
        '
        Me.SubjectBindingSource.DataMember = "Subject"
        Me.SubjectBindingSource.DataSource = Me.TechConnect
        '
        'txtTime
        '
        Me.txtTime.Location = New System.Drawing.Point(82, 80)
        Me.txtTime.Mask = "90:00"
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(220, 21)
        Me.txtTime.TabIndex = 6
        Me.txtTime.ValidatingType = GetType(Date)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Time"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(362, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Subject Code"
        '
        'Grade
        '
        Me.Grade.AutoSize = True
        Me.Grade.Location = New System.Drawing.Point(21, 46)
        Me.Grade.Name = "Grade"
        Me.Grade.Size = New System.Drawing.Size(46, 15)
        Me.Grade.TabIndex = 1
        Me.Grade.Text = "Grade"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(363, 541)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(231, 35)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "ADD"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.GradeDataGridViewTextBoxColumn, Me.DateDataGridViewTextBoxColumn, Me.TimeDataGridViewTextBoxColumn, Me.SubjectCodeDataGridViewTextBoxColumn, Me.VenueDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ExamTimetableBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(168, 244)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(632, 277)
        Me.DataGridView1.TabIndex = 11
        '
        'GradeDataGridViewTextBoxColumn
        '
        Me.GradeDataGridViewTextBoxColumn.DataPropertyName = "Grade"
        Me.GradeDataGridViewTextBoxColumn.HeaderText = "Grade"
        Me.GradeDataGridViewTextBoxColumn.Name = "GradeDataGridViewTextBoxColumn"
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "Date"
        Me.DateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        '
        'TimeDataGridViewTextBoxColumn
        '
        Me.TimeDataGridViewTextBoxColumn.DataPropertyName = "Time"
        Me.TimeDataGridViewTextBoxColumn.HeaderText = "Time"
        Me.TimeDataGridViewTextBoxColumn.Name = "TimeDataGridViewTextBoxColumn"
        '
        'SubjectCodeDataGridViewTextBoxColumn
        '
        Me.SubjectCodeDataGridViewTextBoxColumn.DataPropertyName = "Subject_Code"
        Me.SubjectCodeDataGridViewTextBoxColumn.HeaderText = "Subject_Code"
        Me.SubjectCodeDataGridViewTextBoxColumn.Name = "SubjectCodeDataGridViewTextBoxColumn"
        '
        'VenueDataGridViewTextBoxColumn
        '
        Me.VenueDataGridViewTextBoxColumn.DataPropertyName = "Venue"
        Me.VenueDataGridViewTextBoxColumn.HeaderText = "Venue"
        Me.VenueDataGridViewTextBoxColumn.Name = "VenueDataGridViewTextBoxColumn"
        '
        'ExamTimetableBindingSource
        '
        Me.ExamTimetableBindingSource.DataMember = "Exam_Timetable"
        Me.ExamTimetableBindingSource.DataSource = Me.TechConnect
        '
        'Exam_TimetableTableAdapter
        '
        Me.Exam_TimetableTableAdapter.ClearBeforeFill = True
        '
        'ClassTableAdapter
        '
        Me.ClassTableAdapter.ClearBeforeFill = True
        '
        'SubjectTableAdapter
        '
        Me.SubjectTableAdapter.ClearBeforeFill = True
        '
        'ExamTimetableBindingSource1
        '
        Me.ExamTimetableBindingSource1.DataMember = "Exam_Timetable"
        Me.ExamTimetableBindingSource1.DataSource = Me.TechConnect
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(363, 582)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(231, 34)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "CANCEL"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Exam_TimeTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(908, 632)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Exam_TimeTable"
        Me.Text = "Exam_TimeTable"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ClassBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TechConnect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubjectBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExamTimetableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExamTimetableBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBoxGrade As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBoxSubject As ComboBox
    Friend WithEvents txtTime As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Grade As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TechConnect As TechConnect
    Friend WithEvents ExamTimetableBindingSource As BindingSource
    Friend WithEvents Exam_TimetableTableAdapter As TechConnectTableAdapters.Exam_TimetableTableAdapter
    Friend WithEvents txtVenue As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GradeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SubjectCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VenueDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClassBindingSource As BindingSource
    Friend WithEvents ClassTableAdapter As TechConnectTableAdapters.ClassTableAdapter
    Friend WithEvents SubjectBindingSource As BindingSource
    Friend WithEvents SubjectTableAdapter As TechConnectTableAdapters.SubjectTableAdapter
    Friend WithEvents ExamTimetableBindingSource1 As BindingSource
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Button2 As Button
End Class
