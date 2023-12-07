<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_report
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
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_report))
        Me.lbl_lastmonth = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_todaySale = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.btn_close = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_Filter = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2DateTimePicker2 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.txt_search = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2DateTimePicker1 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2ShadowPanel2 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.Guna2ShadowPanel3 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2ShadowPanel1.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2ShadowPanel2.SuspendLayout()
        Me.Guna2ShadowPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_lastmonth
        '
        Me.lbl_lastmonth.AutoSize = True
        Me.lbl_lastmonth.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold)
        Me.lbl_lastmonth.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_lastmonth.Location = New System.Drawing.Point(11, 49)
        Me.lbl_lastmonth.Name = "lbl_lastmonth"
        Me.lbl_lastmonth.Size = New System.Drawing.Size(59, 31)
        Me.lbl_lastmonth.TabIndex = 2
        Me.lbl_lastmonth.Text = "0.00"
        Me.lbl_lastmonth.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Today Sales"
        '
        'lbl_todaySale
        '
        Me.lbl_todaySale.AutoSize = True
        Me.lbl_todaySale.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_todaySale.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_todaySale.Location = New System.Drawing.Point(9, 49)
        Me.lbl_todaySale.Name = "lbl_todaySale"
        Me.lbl_todaySale.Size = New System.Drawing.Size(59, 31)
        Me.lbl_todaySale.TabIndex = 0
        Me.lbl_todaySale.Text = "0.00"
        Me.lbl_todaySale.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridView1.ColumnHeadersHeight = 30
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10})
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle17
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(0, 282)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle18
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(1066, 383)
        Me.DataGridView1.TabIndex = 3
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "#"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 46
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle12.Format = "d"
        DataGridViewCellStyle12.NullValue = Nothing
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle12
        Me.Column2.HeaderText = "TRANSACTION DATE"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 172
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column3.HeaderText = "TRANSACTION NO"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 161
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column4.HeaderText = "TRANSACTION MONTH"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Visible = False
        Me.Column4.Width = 192
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column5.HeaderText = "FOOD CODE"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 118
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column6.HeaderText = "FOOD NAME"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle13.Format = "₹ #,##0.00"
        Me.Column7.DefaultCellStyle = DataGridViewCellStyle13
        Me.Column7.HeaderText = "PRICE"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 75
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column8.DefaultCellStyle = DataGridViewCellStyle14
        Me.Column8.HeaderText = "QTY"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 64
        '
        'Column9
        '
        Me.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle15.Format = "₹ #,##0.00"
        Me.Column9.DefaultCellStyle = DataGridViewCellStyle15
        Me.Column9.HeaderText = "TOTAL PRICE"
        Me.Column9.MinimumWidth = 6
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 119
        '
        'Column10
        '
        Me.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle16.Format = "₹ #,##0.00"
        Me.Column10.DefaultCellStyle = DataGridViewCellStyle16
        Me.Column10.HeaderText = "GRAND TOTAL"
        Me.Column10.MinimumWidth = 6
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Visible = False
        Me.Column10.Width = 131
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 50
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2ShadowPanel1
        '
        Me.Guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel1.Controls.Add(Me.Guna2ShadowPanel3)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Guna2ShadowPanel2)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Guna2Panel1)
        Me.Guna2ShadowPanel1.Controls.Add(Me.btn_close)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Label3)
        Me.Guna2ShadowPanel1.Controls.Add(Me.DataGridView1)
        Me.Guna2ShadowPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.Guna2ShadowPanel1.Location = New System.Drawing.Point(12, 12)
        Me.Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Me.Guna2ShadowPanel1.Radius = 10
        Me.Guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.Guna2ShadowPanel1.ShadowDepth = 0
        Me.Guna2ShadowPanel1.ShadowShift = 0
        Me.Guna2ShadowPanel1.Size = New System.Drawing.Size(1066, 680)
        Me.Guna2ShadowPanel1.TabIndex = 16
        '
        'btn_close
        '
        Me.btn_close.BorderRadius = 10
        Me.btn_close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_close.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_close.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_close.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_close.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_close.FillColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.btn_close.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_close.ForeColor = System.Drawing.Color.White
        Me.btn_close.Image = CType(resources.GetObject("btn_close.Image"), System.Drawing.Image)
        Me.btn_close.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btn_close.ImageSize = New System.Drawing.Size(16, 16)
        Me.btn_close.Location = New System.Drawing.Point(932, 25)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(94, 45)
        Me.btn_close.TabIndex = 35
        Me.btn_close.Text = "Back"
        Me.btn_close.TextOffset = New System.Drawing.Point(-10, 0)
        '
        'btn_Filter
        '
        Me.btn_Filter.BackColor = System.Drawing.Color.Transparent
        Me.btn_Filter.BorderRadius = 10
        Me.btn_Filter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Filter.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_Filter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_Filter.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_Filter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_Filter.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_Filter.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Filter.ForeColor = System.Drawing.Color.Black
        Me.btn_Filter.Image = CType(resources.GetObject("btn_Filter.Image"), System.Drawing.Image)
        Me.btn_Filter.ImageOffset = New System.Drawing.Point(-3, 0)
        Me.btn_Filter.ImageSize = New System.Drawing.Size(16, 16)
        Me.btn_Filter.Location = New System.Drawing.Point(837, 14)
        Me.btn_Filter.Name = "btn_Filter"
        Me.btn_Filter.Size = New System.Drawing.Size(118, 36)
        Me.btn_Filter.TabIndex = 34
        Me.btn_Filter.Text = "Filter"
        Me.btn_Filter.TextOffset = New System.Drawing.Point(2, 0)
        '
        'Guna2DateTimePicker2
        '
        Me.Guna2DateTimePicker2.BorderRadius = 10
        Me.Guna2DateTimePicker2.Checked = True
        Me.Guna2DateTimePicker2.FillColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Guna2DateTimePicker2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2DateTimePicker2.ForeColor = System.Drawing.Color.White
        Me.Guna2DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.Guna2DateTimePicker2.Location = New System.Drawing.Point(596, 14)
        Me.Guna2DateTimePicker2.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.Guna2DateTimePicker2.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.Guna2DateTimePicker2.Name = "Guna2DateTimePicker2"
        Me.Guna2DateTimePicker2.Size = New System.Drawing.Size(224, 36)
        Me.Guna2DateTimePicker2.TabIndex = 29
        Me.Guna2DateTimePicker2.Value = New Date(2023, 12, 6, 17, 29, 32, 440)
        '
        'txt_search
        '
        Me.txt_search.BorderColor = System.Drawing.Color.Transparent
        Me.txt_search.BorderRadius = 19
        Me.txt_search.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_search.DefaultText = ""
        Me.txt_search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_search.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.txt_search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_search.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_search.IconLeft = CType(resources.GetObject("txt_search.IconLeft"), System.Drawing.Image)
        Me.txt_search.IconLeftOffset = New System.Drawing.Point(22, 0)
        Me.txt_search.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.txt_search.Location = New System.Drawing.Point(36, 12)
        Me.txt_search.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_search.PlaceholderText = "Search"
        Me.txt_search.SelectedText = ""
        Me.txt_search.Size = New System.Drawing.Size(300, 40)
        Me.txt_search.TabIndex = 28
        Me.txt_search.TextOffset = New System.Drawing.Point(15, 0)
        '
        'Guna2DateTimePicker1
        '
        Me.Guna2DateTimePicker1.BorderRadius = 10
        Me.Guna2DateTimePicker1.Checked = True
        Me.Guna2DateTimePicker1.FillColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Guna2DateTimePicker1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2DateTimePicker1.ForeColor = System.Drawing.Color.White
        Me.Guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.Guna2DateTimePicker1.Location = New System.Drawing.Point(357, 14)
        Me.Guna2DateTimePicker1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.Guna2DateTimePicker1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.Guna2DateTimePicker1.Name = "Guna2DateTimePicker1"
        Me.Guna2DateTimePicker1.Size = New System.Drawing.Size(224, 36)
        Me.Guna2DateTimePicker1.TabIndex = 17
        Me.Guna2DateTimePicker1.Value = New Date(2023, 12, 6, 17, 29, 32, 440)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(33, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(182, 35)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Order Reports"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Black
        Me.Guna2Panel1.Controls.Add(Me.txt_search)
        Me.Guna2Panel1.Controls.Add(Me.Guna2DateTimePicker1)
        Me.Guna2Panel1.Controls.Add(Me.btn_Filter)
        Me.Guna2Panel1.Controls.Add(Me.Guna2DateTimePicker2)
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 93)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1066, 66)
        Me.Guna2Panel1.TabIndex = 36
        '
        'Guna2ShadowPanel2
        '
        Me.Guna2ShadowPanel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel2.Controls.Add(Me.Label1)
        Me.Guna2ShadowPanel2.Controls.Add(Me.lbl_todaySale)
        Me.Guna2ShadowPanel2.FillColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.Guna2ShadowPanel2.Location = New System.Drawing.Point(40, 174)
        Me.Guna2ShadowPanel2.Name = "Guna2ShadowPanel2"
        Me.Guna2ShadowPanel2.Radius = 5
        Me.Guna2ShadowPanel2.ShadowColor = System.Drawing.Color.Black
        Me.Guna2ShadowPanel2.ShadowDepth = 0
        Me.Guna2ShadowPanel2.ShadowShift = 0
        Me.Guna2ShadowPanel2.Size = New System.Drawing.Size(200, 93)
        Me.Guna2ShadowPanel2.TabIndex = 38
        '
        'Guna2ShadowPanel3
        '
        Me.Guna2ShadowPanel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel3.Controls.Add(Me.Label4)
        Me.Guna2ShadowPanel3.Controls.Add(Me.lbl_lastmonth)
        Me.Guna2ShadowPanel3.FillColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.Guna2ShadowPanel3.Location = New System.Drawing.Point(258, 174)
        Me.Guna2ShadowPanel3.Name = "Guna2ShadowPanel3"
        Me.Guna2ShadowPanel3.Radius = 5
        Me.Guna2ShadowPanel3.ShadowColor = System.Drawing.Color.Black
        Me.Guna2ShadowPanel3.ShadowDepth = 0
        Me.Guna2ShadowPanel3.ShadowShift = 0
        Me.Guna2ShadowPanel3.Size = New System.Drawing.Size(200, 93)
        Me.Guna2ShadowPanel3.TabIndex = 39
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(12, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Monthly Sales"
        '
        'frm_report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1090, 704)
        Me.Controls.Add(Me.Guna2ShadowPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_report"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_report"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2ShadowPanel1.ResumeLayout(False)
        Me.Guna2ShadowPanel1.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2ShadowPanel2.ResumeLayout(False)
        Me.Guna2ShadowPanel2.PerformLayout()
        Me.Guna2ShadowPanel3.ResumeLayout(False)
        Me.Guna2ShadowPanel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_todaySale As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lbl_lastmonth As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Guna2DateTimePicker1 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents txt_search As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2DateTimePicker2 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents btn_Filter As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_close As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2ShadowPanel3 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents Guna2ShadowPanel2 As Guna.UI2.WinForms.Guna2ShadowPanel
End Class
