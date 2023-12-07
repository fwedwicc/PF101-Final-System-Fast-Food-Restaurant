<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_ManageFoods
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ManageFoods))
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btn_find = New Guna.UI2.WinForms.Guna2Button()
        Me.txt_found = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btn_delete = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_edit = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_save = New Guna.UI2.WinForms.Guna2Button()
        Me.txt_price = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_foodname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_foodcode = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.pic_foodimg = New Fast_Food_Restaurant.CirclePicturBox()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.btn_close = New Guna.UI2.WinForms.Guna2Button()
        Me.TabControl1 = New Guna.UI2.WinForms.Guna2TabControl()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.pic_foodimg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2ShadowPanel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(33, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(185, 35)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Manage Foods"
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.TextBox1)
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 44)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(5)
        Me.TabPage1.Size = New System.Drawing.Size(810, 423)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Food List"
        '
        'TextBox1
        '
        Me.TextBox1.BorderColor = System.Drawing.Color.Transparent
        Me.TextBox1.BorderRadius = 19
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox1.DefaultText = ""
        Me.TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox1.IconLeft = CType(resources.GetObject("TextBox1.IconLeft"), System.Drawing.Image)
        Me.TextBox1.IconLeftOffset = New System.Drawing.Point(22, 0)
        Me.TextBox1.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.TextBox1.Location = New System.Drawing.Point(23, 18)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox1.PlaceholderText = "Search"
        Me.TextBox1.SelectedText = ""
        Me.TextBox1.Size = New System.Drawing.Size(300, 40)
        Me.TextBox1.TabIndex = 27
        Me.TextBox1.TextOffset = New System.Drawing.Point(15, 0)
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        DataGridViewCellStyle21.ForeColor = System.Drawing.Color.White
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle21
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle22.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle22.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle22
        Me.DataGridView1.ColumnHeadersHeight = 30
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        DataGridViewCellStyle24.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle24.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        DataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle24
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(-4, 74)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle25.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle25.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle25
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(818, 349)
        Me.DataGridView1.TabIndex = 2
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "Number"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 89
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column2.HeaderText = "Food Code"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 105
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "Food Name"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle23.Format = "₹ #,##0.00"
        DataGridViewCellStyle23.NullValue = Nothing
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle23
        Me.Column4.HeaderText = "Price"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 69
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.btn_find)
        Me.TabPage2.Controls.Add(Me.txt_found)
        Me.TabPage2.Controls.Add(Me.btn_delete)
        Me.TabPage2.Controls.Add(Me.btn_edit)
        Me.TabPage2.Controls.Add(Me.btn_save)
        Me.TabPage2.Controls.Add(Me.txt_price)
        Me.TabPage2.Controls.Add(Me.txt_foodname)
        Me.TabPage2.Controls.Add(Me.txt_foodcode)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.ShapeContainer1)
        Me.TabPage2.Controls.Add(Me.pic_foodimg)
        Me.TabPage2.Location = New System.Drawing.Point(4, 44)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(810, 423)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Manage Foods"
        '
        'btn_find
        '
        Me.btn_find.BackColor = System.Drawing.Color.Transparent
        Me.btn_find.BorderRadius = 10
        Me.btn_find.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_find.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_find.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_find.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_find.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_find.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_find.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_find.ForeColor = System.Drawing.Color.Black
        Me.btn_find.Location = New System.Drawing.Point(484, 23)
        Me.btn_find.Name = "btn_find"
        Me.btn_find.Size = New System.Drawing.Size(68, 40)
        Me.btn_find.TabIndex = 33
        Me.btn_find.Text = "Find"
        '
        'txt_found
        '
        Me.txt_found.BorderColor = System.Drawing.Color.Transparent
        Me.txt_found.BorderRadius = 19
        Me.txt_found.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_found.DefaultText = ""
        Me.txt_found.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_found.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_found.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_found.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_found.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.txt_found.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_found.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_found.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_found.IconLeft = CType(resources.GetObject("txt_found.IconLeft"), System.Drawing.Image)
        Me.txt_found.IconLeftOffset = New System.Drawing.Point(22, 0)
        Me.txt_found.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.txt_found.Location = New System.Drawing.Point(256, 23)
        Me.txt_found.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_found.Name = "txt_found"
        Me.txt_found.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_found.PlaceholderText = "Search"
        Me.txt_found.SelectedText = ""
        Me.txt_found.Size = New System.Drawing.Size(250, 40)
        Me.txt_found.TabIndex = 32
        Me.txt_found.TextOffset = New System.Drawing.Point(15, 0)
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.Transparent
        Me.btn_delete.BorderRadius = 10
        Me.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_delete.FillColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btn_delete.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.ForeColor = System.Drawing.Color.White
        Me.btn_delete.Location = New System.Drawing.Point(484, 339)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(146, 45)
        Me.btn_delete.TabIndex = 31
        Me.btn_delete.Text = "Delete"
        '
        'btn_edit
        '
        Me.btn_edit.BackColor = System.Drawing.Color.Transparent
        Me.btn_edit.BorderRadius = 10
        Me.btn_edit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_edit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_edit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_edit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_edit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_edit.FillColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btn_edit.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_edit.ForeColor = System.Drawing.Color.White
        Me.btn_edit.Location = New System.Drawing.Point(324, 339)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(146, 45)
        Me.btn_edit.TabIndex = 30
        Me.btn_edit.Text = "Edit"
        '
        'btn_save
        '
        Me.btn_save.BorderRadius = 10
        Me.btn_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_save.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_save.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_save.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_save.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.Black
        Me.btn_save.Location = New System.Drawing.Point(164, 339)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(146, 45)
        Me.btn_save.TabIndex = 29
        Me.btn_save.Text = "Save"
        '
        'txt_price
        '
        Me.txt_price.BorderRadius = 7
        Me.txt_price.BorderThickness = 0
        Me.txt_price.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_price.DefaultText = ""
        Me.txt_price.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_price.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_price.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_price.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_price.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.txt_price.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_price.Font = New System.Drawing.Font("Segoe UI Black", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txt_price.ForeColor = System.Drawing.Color.White
        Me.txt_price.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_price.Location = New System.Drawing.Point(372, 252)
        Me.txt_price.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_price.PlaceholderText = ""
        Me.txt_price.SelectedText = ""
        Me.txt_price.Size = New System.Drawing.Size(229, 31)
        Me.txt_price.TabIndex = 28
        '
        'txt_foodname
        '
        Me.txt_foodname.BorderRadius = 7
        Me.txt_foodname.BorderThickness = 0
        Me.txt_foodname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_foodname.DefaultText = ""
        Me.txt_foodname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_foodname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_foodname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_foodname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_foodname.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.txt_foodname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_foodname.Font = New System.Drawing.Font("Segoe UI Black", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txt_foodname.ForeColor = System.Drawing.Color.White
        Me.txt_foodname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_foodname.Location = New System.Drawing.Point(371, 188)
        Me.txt_foodname.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_foodname.Name = "txt_foodname"
        Me.txt_foodname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_foodname.PlaceholderText = ""
        Me.txt_foodname.SelectedText = ""
        Me.txt_foodname.Size = New System.Drawing.Size(229, 31)
        Me.txt_foodname.TabIndex = 27
        '
        'txt_foodcode
        '
        Me.txt_foodcode.BorderRadius = 7
        Me.txt_foodcode.BorderThickness = 0
        Me.txt_foodcode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_foodcode.DefaultText = ""
        Me.txt_foodcode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_foodcode.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_foodcode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_foodcode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_foodcode.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.txt_foodcode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_foodcode.Font = New System.Drawing.Font("Segoe UI Black", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txt_foodcode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_foodcode.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_foodcode.Location = New System.Drawing.Point(370, 123)
        Me.txt_foodcode.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_foodcode.Name = "txt_foodcode"
        Me.txt_foodcode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_foodcode.PlaceholderText = ""
        Me.txt_foodcode.SelectedText = ""
        Me.txt_foodcode.Size = New System.Drawing.Size(229, 31)
        Me.txt_foodcode.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(369, 232)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 19)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Price"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(369, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 19)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Food Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(369, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 19)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Food Code"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(3, 3)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Size = New System.Drawing.Size(804, 417)
        Me.ShapeContainer1.TabIndex = 12
        Me.ShapeContainer1.TabStop = False
        '
        'pic_foodimg
        '
        Me.pic_foodimg.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.pic_foodimg.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic_foodimg.Location = New System.Drawing.Point(186, 135)
        Me.pic_foodimg.Name = "pic_foodimg"
        Me.pic_foodimg.Size = New System.Drawing.Size(140, 133)
        Me.pic_foodimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_foodimg.TabIndex = 0
        Me.pic_foodimg.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 15
        Me.LineShape1.X2 = 692
        Me.LineShape1.Y1 = 78
        Me.LineShape1.Y2 = 78
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 50
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2ShadowPanel1
        '
        Me.Guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel1.Controls.Add(Me.btn_close)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Label4)
        Me.Guna2ShadowPanel1.Controls.Add(Me.TabControl1)
        Me.Guna2ShadowPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.Guna2ShadowPanel1.Location = New System.Drawing.Point(12, 12)
        Me.Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Me.Guna2ShadowPanel1.Radius = 10
        Me.Guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.Guna2ShadowPanel1.ShadowDepth = 0
        Me.Guna2ShadowPanel1.ShadowShift = 0
        Me.Guna2ShadowPanel1.Size = New System.Drawing.Size(818, 579)
        Me.Guna2ShadowPanel1.TabIndex = 10
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
        Me.btn_close.Location = New System.Drawing.Point(683, 27)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(94, 45)
        Me.btn_close.TabIndex = 32
        Me.btn_close.Text = "Back"
        Me.btn_close.TextOffset = New System.Drawing.Point(-10, 0)
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.ItemSize = New System.Drawing.Size(180, 40)
        Me.TabControl1.Location = New System.Drawing.Point(0, 98)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(818, 471)
        Me.TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty
        Me.TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.TabControl1.TabButtonHoverState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White
        Me.TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty
        Me.TabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.Black
        Me.TabControl1.TabButtonIdleState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.TabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.Black
        Me.TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty
        Me.TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.Black
        Me.TabControl1.TabButtonSelectedState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White
        Me.TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TabControl1.TabButtonSize = New System.Drawing.Size(180, 40)
        Me.TabControl1.TabIndex = 11
        Me.TabControl1.TabMenuBackColor = System.Drawing.Color.Black
        Me.TabControl1.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop
        '
        'frm_ManageFoods
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(844, 606)
        Me.Controls.Add(Me.Guna2ShadowPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_ManageFoods"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manage Foods"
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.pic_foodimg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2ShadowPanel1.ResumeLayout(False)
        Me.Guna2ShadowPanel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents pic_foodimg As Fast_Food_Restaurant.CirclePicturBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents TabControl1 As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents txt_foodcode As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_price As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_foodname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btn_save As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_delete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_edit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_close As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txt_found As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btn_find As Guna.UI2.WinForms.Guna2Button
End Class
