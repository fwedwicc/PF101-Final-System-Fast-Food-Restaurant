<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_transno = New System.Windows.Forms.TextBox()
        Me.lbl_overallTotal = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txt_BalanceAmount = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_receivedAmount = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lbl_tot = New System.Windows.Forms.Label()
        Me.btn_Clear = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_Pay = New Guna.UI2.WinForms.Guna2Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_GrandTotal = New System.Windows.Forms.Label()
        Me.lbl_TotalPrice = New System.Windows.Forms.Label()
        Me.lbl_noOfProducts = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_ManageFoods = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_NewOrder = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_CancelOrder = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_Report = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.txt_search = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2ShadowPanel2 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.btn_Exit = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2ShadowPanel3 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_time = New System.Windows.Forms.Label()
        Me.lbl_date1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2ShadowPanel1.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2ShadowPanel2.SuspendLayout()
        Me.Guna2ShadowPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.ForeColor = System.Drawing.Color.White
        Me.lbl_date.Location = New System.Drawing.Point(635, 8)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(40, 19)
        Me.lbl_date.TabIndex = 18
        Me.lbl_date.Text = "Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(592, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 19)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Date : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(279, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 19)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Transaction Number:"
        '
        'txt_transno
        '
        Me.txt_transno.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.txt_transno.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_transno.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_transno.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_transno.Location = New System.Drawing.Point(403, 4)
        Me.txt_transno.Multiline = True
        Me.txt_transno.Name = "txt_transno"
        Me.txt_transno.Size = New System.Drawing.Size(169, 24)
        Me.txt_transno.TabIndex = 15
        '
        'lbl_overallTotal
        '
        Me.lbl_overallTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_overallTotal.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_overallTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_overallTotal.Location = New System.Drawing.Point(217, 28)
        Me.lbl_overallTotal.Name = "lbl_overallTotal"
        Me.lbl_overallTotal.Size = New System.Drawing.Size(171, 40)
        Me.lbl_overallTotal.TabIndex = 5
        Me.lbl_overallTotal.Text = "00.00"
        Me.lbl_overallTotal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.FlowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(208, 156)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(822, 569)
        Me.FlowLayoutPanel1.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.txt_BalanceAmount)
        Me.Panel4.Controls.Add(Me.txt_receivedAmount)
        Me.Panel4.Controls.Add(Me.lbl_tot)
        Me.Panel4.Controls.Add(Me.btn_Clear)
        Me.Panel4.Controls.Add(Me.btn_Pay)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.lbl_GrandTotal)
        Me.Panel4.Controls.Add(Me.lbl_TotalPrice)
        Me.Panel4.Controls.Add(Me.lbl_noOfProducts)
        Me.Panel4.Location = New System.Drawing.Point(11, 478)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(385, 211)
        Me.Panel4.TabIndex = 5
        '
        'txt_BalanceAmount
        '
        Me.txt_BalanceAmount.BorderRadius = 7
        Me.txt_BalanceAmount.BorderThickness = 0
        Me.txt_BalanceAmount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_BalanceAmount.DefaultText = ""
        Me.txt_BalanceAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_BalanceAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_BalanceAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_BalanceAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_BalanceAmount.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.txt_BalanceAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_BalanceAmount.Font = New System.Drawing.Font("Segoe UI Black", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txt_BalanceAmount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_BalanceAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_BalanceAmount.Location = New System.Drawing.Point(82, 112)
        Me.txt_BalanceAmount.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_BalanceAmount.Name = "txt_BalanceAmount"
        Me.txt_BalanceAmount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_BalanceAmount.PlaceholderText = ""
        Me.txt_BalanceAmount.SelectedText = ""
        Me.txt_BalanceAmount.Size = New System.Drawing.Size(295, 31)
        Me.txt_BalanceAmount.TabIndex = 26
        '
        'txt_receivedAmount
        '
        Me.txt_receivedAmount.BorderRadius = 7
        Me.txt_receivedAmount.BorderThickness = 0
        Me.txt_receivedAmount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_receivedAmount.DefaultText = ""
        Me.txt_receivedAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_receivedAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_receivedAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_receivedAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_receivedAmount.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.txt_receivedAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_receivedAmount.Font = New System.Drawing.Font("Segoe UI Black", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txt_receivedAmount.ForeColor = System.Drawing.Color.White
        Me.txt_receivedAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_receivedAmount.Location = New System.Drawing.Point(82, 75)
        Me.txt_receivedAmount.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_receivedAmount.Name = "txt_receivedAmount"
        Me.txt_receivedAmount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_receivedAmount.PlaceholderText = ""
        Me.txt_receivedAmount.SelectedText = ""
        Me.txt_receivedAmount.Size = New System.Drawing.Size(295, 31)
        Me.txt_receivedAmount.TabIndex = 25
        '
        'lbl_tot
        '
        Me.lbl_tot.AutoSize = True
        Me.lbl_tot.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lbl_tot.Location = New System.Drawing.Point(3, 143)
        Me.lbl_tot.Name = "lbl_tot"
        Me.lbl_tot.Size = New System.Drawing.Size(50, 19)
        Me.lbl_tot.TabIndex = 23
        Me.lbl_tot.Text = "Label7"
        Me.lbl_tot.Visible = False
        '
        'btn_Clear
        '
        Me.btn_Clear.BackColor = System.Drawing.Color.Transparent
        Me.btn_Clear.BorderRadius = 10
        Me.btn_Clear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Clear.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_Clear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_Clear.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_Clear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_Clear.FillColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btn_Clear.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Clear.ForeColor = System.Drawing.Color.White
        Me.btn_Clear.Location = New System.Drawing.Point(196, 162)
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.Size = New System.Drawing.Size(185, 45)
        Me.btn_Clear.TabIndex = 24
        Me.btn_Clear.Text = "Clear"
        '
        'btn_Pay
        '
        Me.btn_Pay.BorderRadius = 10
        Me.btn_Pay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Pay.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_Pay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_Pay.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_Pay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_Pay.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_Pay.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Pay.ForeColor = System.Drawing.Color.Black
        Me.btn_Pay.Location = New System.Drawing.Point(0, 162)
        Me.btn_Pay.Name = "btn_Pay"
        Me.btn_Pay.Size = New System.Drawing.Size(185, 45)
        Me.btn_Pay.TabIndex = 10
        Me.btn_Pay.Text = "Pay"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(-4, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 25)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Change:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(-5, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 25)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Cash:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(-4, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 25)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Total:"
        '
        'lbl_GrandTotal
        '
        Me.lbl_GrandTotal.AutoSize = True
        Me.lbl_GrandTotal.Font = New System.Drawing.Font("Segoe UI Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_GrandTotal.ForeColor = System.Drawing.Color.White
        Me.lbl_GrandTotal.Location = New System.Drawing.Point(77, 49)
        Me.lbl_GrandTotal.Name = "lbl_GrandTotal"
        Me.lbl_GrandTotal.Size = New System.Drawing.Size(51, 25)
        Me.lbl_GrandTotal.TabIndex = 6
        Me.lbl_GrandTotal.Text = "0.00"
        '
        'lbl_TotalPrice
        '
        Me.lbl_TotalPrice.AutoSize = True
        Me.lbl_TotalPrice.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TotalPrice.ForeColor = System.Drawing.Color.White
        Me.lbl_TotalPrice.Location = New System.Drawing.Point(-4, 18)
        Me.lbl_TotalPrice.Name = "lbl_TotalPrice"
        Me.lbl_TotalPrice.Size = New System.Drawing.Size(70, 25)
        Me.lbl_TotalPrice.TabIndex = 5
        Me.lbl_TotalPrice.Text = "Items: "
        '
        'lbl_noOfProducts
        '
        Me.lbl_noOfProducts.AutoSize = True
        Me.lbl_noOfProducts.Font = New System.Drawing.Font("Segoe UI Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_noOfProducts.ForeColor = System.Drawing.Color.White
        Me.lbl_noOfProducts.Location = New System.Drawing.Point(77, 18)
        Me.lbl_noOfProducts.Name = "lbl_noOfProducts"
        Me.lbl_noOfProducts.Size = New System.Drawing.Size(51, 25)
        Me.lbl_noOfProducts.TabIndex = 4
        Me.lbl_noOfProducts.Text = "0.00"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridView1.ColumnHeadersHeight = 30
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle13
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(12, 89)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(376, 390)
        Me.DataGridView1.TabIndex = 3
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
        Me.Column2.Visible = False
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
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "₹ #,##0.00"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle10
        Me.Column4.HeaderText = "Price"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 69
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle11
        Me.Column5.HeaderText = "QTY"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 64
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle12.Format = "₹ #,##0.00"
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle12
        Me.Column6.HeaderText = "Total"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 69
        '
        'btn_ManageFoods
        '
        Me.btn_ManageFoods.BorderRadius = 10
        Me.btn_ManageFoods.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_ManageFoods.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_ManageFoods.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_ManageFoods.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_ManageFoods.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_ManageFoods.FillColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btn_ManageFoods.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_ManageFoods.ForeColor = System.Drawing.Color.White
        Me.btn_ManageFoods.Image = CType(resources.GetObject("btn_ManageFoods.Image"), System.Drawing.Image)
        Me.btn_ManageFoods.ImageOffset = New System.Drawing.Point(2, 0)
        Me.btn_ManageFoods.ImageSize = New System.Drawing.Size(20, 15)
        Me.btn_ManageFoods.Location = New System.Drawing.Point(10, 138)
        Me.btn_ManageFoods.Name = "btn_ManageFoods"
        Me.btn_ManageFoods.Size = New System.Drawing.Size(170, 45)
        Me.btn_ManageFoods.TabIndex = 6
        Me.btn_ManageFoods.Text = "   Manage Foods"
        '
        'btn_NewOrder
        '
        Me.btn_NewOrder.BorderRadius = 10
        Me.btn_NewOrder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_NewOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_NewOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_NewOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_NewOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_NewOrder.FillColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btn_NewOrder.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_NewOrder.ForeColor = System.Drawing.Color.White
        Me.btn_NewOrder.Image = CType(resources.GetObject("btn_NewOrder.Image"), System.Drawing.Image)
        Me.btn_NewOrder.ImageOffset = New System.Drawing.Point(-7, 0)
        Me.btn_NewOrder.ImageSize = New System.Drawing.Size(17, 17)
        Me.btn_NewOrder.Location = New System.Drawing.Point(10, 195)
        Me.btn_NewOrder.Name = "btn_NewOrder"
        Me.btn_NewOrder.Size = New System.Drawing.Size(170, 45)
        Me.btn_NewOrder.TabIndex = 7
        Me.btn_NewOrder.Text = "New Order"
        Me.btn_NewOrder.TextOffset = New System.Drawing.Point(-3, 0)
        '
        'btn_CancelOrder
        '
        Me.btn_CancelOrder.BorderRadius = 10
        Me.btn_CancelOrder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_CancelOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_CancelOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_CancelOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_CancelOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_CancelOrder.FillColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btn_CancelOrder.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_CancelOrder.ForeColor = System.Drawing.Color.White
        Me.btn_CancelOrder.Image = CType(resources.GetObject("btn_CancelOrder.Image"), System.Drawing.Image)
        Me.btn_CancelOrder.ImageOffset = New System.Drawing.Point(-5, 0)
        Me.btn_CancelOrder.Location = New System.Drawing.Point(10, 252)
        Me.btn_CancelOrder.Name = "btn_CancelOrder"
        Me.btn_CancelOrder.Size = New System.Drawing.Size(170, 45)
        Me.btn_CancelOrder.TabIndex = 8
        Me.btn_CancelOrder.Text = "Cancel Order"
        Me.btn_CancelOrder.TextOffset = New System.Drawing.Point(-2, 0)
        '
        'btn_Report
        '
        Me.btn_Report.BorderRadius = 10
        Me.btn_Report.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Report.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_Report.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_Report.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_Report.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_Report.FillColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btn_Report.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_Report.ForeColor = System.Drawing.Color.White
        Me.btn_Report.Image = CType(resources.GetObject("btn_Report.Image"), System.Drawing.Image)
        Me.btn_Report.ImageOffset = New System.Drawing.Point(-12, 0)
        Me.btn_Report.Location = New System.Drawing.Point(10, 309)
        Me.btn_Report.Name = "btn_Report"
        Me.btn_Report.Size = New System.Drawing.Size(170, 45)
        Me.btn_Report.TabIndex = 9
        Me.btn_Report.Text = "Reports"
        Me.btn_Report.TextOffset = New System.Drawing.Point(-9, 0)
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 50
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2ShadowPanel1
        '
        Me.Guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel1.Controls.Add(Me.Guna2Panel1)
        Me.Guna2ShadowPanel1.Controls.Add(Me.txt_search)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2ShadowPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.Guna2ShadowPanel1.Location = New System.Drawing.Point(12, 29)
        Me.Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Me.Guna2ShadowPanel1.Radius = 10
        Me.Guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.Guna2ShadowPanel1.ShadowDepth = 0
        Me.Guna2ShadowPanel1.ShadowShift = 0
        Me.Guna2ShadowPanel1.Size = New System.Drawing.Size(1018, 121)
        Me.Guna2ShadowPanel1.TabIndex = 10
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.Guna2Panel1.Controls.Add(Me.Label2)
        Me.Guna2Panel1.Controls.Add(Me.txt_transno)
        Me.Guna2Panel1.Controls.Add(Me.Label3)
        Me.Guna2Panel1.Controls.Add(Me.lbl_date)
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 89)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1018, 31)
        Me.Guna2Panel1.TabIndex = 27
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
        Me.txt_search.Location = New System.Drawing.Point(283, 25)
        Me.txt_search.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_search.PlaceholderText = "Search Food"
        Me.txt_search.SelectedText = ""
        Me.txt_search.Size = New System.Drawing.Size(478, 40)
        Me.txt_search.TabIndex = 26
        Me.txt_search.TextOffset = New System.Drawing.Point(15, 0)
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackgroundImage = CType(resources.GetObject("Guna2PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.Guna2PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(35, 15)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(173, 62)
        Me.Guna2PictureBox1.TabIndex = 25
        Me.Guna2PictureBox1.TabStop = False
        '
        'Guna2ShadowPanel2
        '
        Me.Guna2ShadowPanel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel2.BackgroundImage = CType(resources.GetObject("Guna2ShadowPanel2.BackgroundImage"), System.Drawing.Image)
        Me.Guna2ShadowPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Guna2ShadowPanel2.Controls.Add(Me.btn_Exit)
        Me.Guna2ShadowPanel2.Controls.Add(Me.btn_ManageFoods)
        Me.Guna2ShadowPanel2.Controls.Add(Me.btn_NewOrder)
        Me.Guna2ShadowPanel2.Controls.Add(Me.btn_CancelOrder)
        Me.Guna2ShadowPanel2.Controls.Add(Me.btn_Report)
        Me.Guna2ShadowPanel2.FillColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.Guna2ShadowPanel2.Location = New System.Drawing.Point(12, 161)
        Me.Guna2ShadowPanel2.Name = "Guna2ShadowPanel2"
        Me.Guna2ShadowPanel2.Radius = 10
        Me.Guna2ShadowPanel2.ShadowColor = System.Drawing.Color.Black
        Me.Guna2ShadowPanel2.ShadowDepth = 0
        Me.Guna2ShadowPanel2.ShadowShift = 0
        Me.Guna2ShadowPanel2.Size = New System.Drawing.Size(190, 564)
        Me.Guna2ShadowPanel2.TabIndex = 24
        '
        'btn_Exit
        '
        Me.btn_Exit.BorderRadius = 10
        Me.btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Exit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_Exit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_Exit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_Exit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_Exit.FillColor = System.Drawing.Color.Transparent
        Me.btn_Exit.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_Exit.ForeColor = System.Drawing.Color.White
        Me.btn_Exit.Image = CType(resources.GetObject("btn_Exit.Image"), System.Drawing.Image)
        Me.btn_Exit.ImageOffset = New System.Drawing.Point(-1, 0)
        Me.btn_Exit.ImageSize = New System.Drawing.Size(18, 18)
        Me.btn_Exit.Location = New System.Drawing.Point(10, 512)
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.Size = New System.Drawing.Size(170, 45)
        Me.btn_Exit.TabIndex = 10
        Me.btn_Exit.Text = "Logout"
        Me.btn_Exit.TextOffset = New System.Drawing.Point(2, 0)
        '
        'Guna2ShadowPanel3
        '
        Me.Guna2ShadowPanel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel3.Controls.Add(Me.Label6)
        Me.Guna2ShadowPanel3.Controls.Add(Me.Panel4)
        Me.Guna2ShadowPanel3.Controls.Add(Me.lbl_overallTotal)
        Me.Guna2ShadowPanel3.Controls.Add(Me.DataGridView1)
        Me.Guna2ShadowPanel3.FillColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.Guna2ShadowPanel3.Location = New System.Drawing.Point(1039, 29)
        Me.Guna2ShadowPanel3.Name = "Guna2ShadowPanel3"
        Me.Guna2ShadowPanel3.Radius = 10
        Me.Guna2ShadowPanel3.ShadowColor = System.Drawing.Color.Black
        Me.Guna2ShadowPanel3.ShadowDepth = 0
        Me.Guna2ShadowPanel3.ShadowShift = 0
        Me.Guna2ShadowPanel3.Size = New System.Drawing.Size(401, 696)
        Me.Guna2ShadowPanel3.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(14, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(130, 35)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Food Cart"
        '
        'lbl_time
        '
        Me.lbl_time.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_time.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_time.ForeColor = System.Drawing.Color.White
        Me.lbl_time.Location = New System.Drawing.Point(-23, -1)
        Me.lbl_time.Name = "lbl_time"
        Me.lbl_time.Size = New System.Drawing.Size(137, 31)
        Me.lbl_time.TabIndex = 19
        Me.lbl_time.Text = "00.00"
        Me.lbl_time.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_date1
        '
        Me.lbl_date1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_date1.BackColor = System.Drawing.Color.Transparent
        Me.lbl_date1.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date1.ForeColor = System.Drawing.Color.White
        Me.lbl_date1.Location = New System.Drawing.Point(95, -1)
        Me.lbl_date1.Name = "lbl_date1"
        Me.lbl_date1.Size = New System.Drawing.Size(130, 31)
        Me.lbl_date1.TabIndex = 23
        Me.lbl_date1.Text = "00.00"
        Me.lbl_date1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(1385, 5)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 20)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Close"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1453, 737)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Guna2ShadowPanel3)
        Me.Controls.Add(Me.Guna2ShadowPanel2)
        Me.Controls.Add(Me.Guna2ShadowPanel1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.lbl_time)
        Me.Controls.Add(Me.lbl_date1)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fast Food Restaurant"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2ShadowPanel1.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2ShadowPanel2.ResumeLayout(False)
        Me.Guna2ShadowPanel3.ResumeLayout(False)
        Me.Guna2ShadowPanel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents lbl_overallTotal As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lbl_GrandTotal As System.Windows.Forms.Label
    Friend WithEvents lbl_TotalPrice As System.Windows.Forms.Label
    Friend WithEvents lbl_noOfProducts As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_transno As System.Windows.Forms.TextBox
    Friend WithEvents lbl_date As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btn_ManageFoods As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_NewOrder As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_CancelOrder As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_Report As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_Clear As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_Pay As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2ShadowPanel2 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents txt_search As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lbl_tot As Label
    Friend WithEvents txt_receivedAmount As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2ShadowPanel3 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents txt_BalanceAmount As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lbl_date1 As Label
    Friend WithEvents lbl_time As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_Exit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Label7 As Label
End Class
