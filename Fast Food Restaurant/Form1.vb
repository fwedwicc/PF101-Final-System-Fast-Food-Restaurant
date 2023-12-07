Imports System.IO
Imports MySql.Data.MySqlClient
Imports System.Drawing
Imports System.Drawing.Printing

Public Class Form1
    Private WithEvents pan As Panel
    Private WithEvents pan_top As Panel
    Private WithEvents foodcode As Label
    Private WithEvents foodname As Label
    Private WithEvents price As Label
    Private WithEvents img As CirclePicturBox

    '---------------Print
    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Dim longpaper As Integer
    '---------------Print
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        lbl_date.Text = Date.Now.ToString("yyyy-MM-dd")
        DataGridView1.RowTemplate.Height = 30
        Load_Foods()
        auto_Transno()
    End Sub
    '---------------Print
    Sub changelongpaper()
        Dim rowcount As Integer
        longpaper = 0
        rowcount = DataGridView1.Rows.Count
        longpaper = rowcount * 15
        longpaper = longpaper + 500
    End Sub
    '---------------Print

    Sub auto_Transno()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM `tbl_pos` order by id desc", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = True Then
                txt_transno.Text = dr.Item("transno").ToString + 1

            Else
                txt_transno.Text = Date.Now.ToString("yyyyMM") & "001"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub


    Sub Load_controls()
        Dim len As Long = dr.GetBytes(0, 0, Nothing, 0, 0)
        Dim array(CInt(len)) As Byte
        dr.GetBytes(0, 0, array, 0, CInt(len))

        Dim margin As Integer = 5
        Dim padding As Integer = 10
        pan = New Panel
        With pan
            .Width = 149
            .Height = 230
            .BackColor = Color.FromArgb(27,27,27)
            .Tag = dr.Item("foodcode").ToString
            .Padding = New Padding(padding)
            .Margin = New Padding(Margin)
        End With
        pan_top = New Panel
        With pan_top
            .Width = 150
            .Height = 10
            .BackColor = Color.FromArgb(27, 27, 27)
            .Dock = DockStyle.Top
            .Tag = dr.Item("foodcode").ToString
        End With

        img = New CirclePicturBox
        With img
            .Height = 120
            .BackgroundImageLayout = ImageLayout.Zoom
            .Dock = DockStyle.Top
            .Tag = dr.Item("foodcode").ToString
        End With

        Dim topPadding As Integer = 12
        foodcode = New Label
        With foodcode
            .Padding = New Padding(0, topPadding, 0, 0)
            .ForeColor = Color.Orange
            .Font = New Font("Segoe UI", 8, FontStyle.Bold)
            .TextAlign = ContentAlignment.MiddleLeft
            .Dock = DockStyle.Top
            .Tag = dr.Item("foodcode").ToString
        End With
        foodname = New Label
        With foodname
            .ForeColor = Color.White
            .Font = New Font("Segoe UI", 8, FontStyle.Bold)
            .TextAlign = ContentAlignment.MiddleLeft
            .Dock = DockStyle.Top
            .Tag = dr.Item("foodcode").ToString
        End With

        price = New Label
        With price
            .ForeColor = Color.White
            .Font = New Font("Segoe UI", 15, FontStyle.Bold)
            .TextAlign = ContentAlignment.MiddleLeft
            .Dock = DockStyle.Top
            .Tag = dr.Item("foodcode").ToString
        End With

        Dim ms As New System.IO.MemoryStream(array)
        Dim bitmap As New System.Drawing.Bitmap(ms)
        img.BackgroundImage = bitmap

        foodcode.Text = "Code: " & dr.Item("foodcode").ToString
        foodname.Text = dr.Item("foodname").ToString
        price.Text = "₱" & dr.Item("price").ToString

        pan.Controls.Add(price)
        pan.Controls.Add(foodname)
        pan.Controls.Add(foodcode)
        pan.Controls.Add(img)


        pan.Controls.Add(pan_top)
        FlowLayoutPanel1.Controls.Add(pan)

        AddHandler foodcode.Click, AddressOf Selectimg_Click
        AddHandler foodname.Click, AddressOf Selectimg_Click
        AddHandler price.Click, AddressOf Selectimg_Click
        AddHandler img.Click, AddressOf Selectimg_Click
        AddHandler pan.Click, AddressOf Selectimg_Click
    End Sub
    Public Sub Selectimg_Click(sender As Object, e As EventArgs)
        conn.Open()
        Try
            cmd = New MySqlCommand("SELECT `foodcode`, `foodname`, `price` FROM `tbl_food` WHERE `foodcode` like '" & sender.tag.ToString & "%' ", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                Dim exist As Boolean = False, numrow As Integer = 0, numtext As Integer
                For Each itm As DataGridViewRow In DataGridView1.Rows
                    If itm.Cells(1).Value IsNot Nothing Then
                        If itm.Cells(1).Value.ToString = dr.Item("foodcode") Then
                            exist = True
                            numrow = itm.Index
                            numtext = CInt(itm.Cells(4).Value)
                            Exit For
                        End If
                    End If
                Next
                If exist = False Then
                    Dim price As Decimal = dr("price")
                    Dim subtotalprice As Double
                    subtotalprice = price * 1
                    DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("foodcode"), dr.Item("foodname"), dr.Item("price"), 1, subtotalprice)
                Else
                    DataGridView1.Rows(numrow).Cells(4).Value = CInt("1") + numtext
                    DataGridView1.Rows(numrow).Cells(5).Value = DataGridView1.Rows(numrow).Cells(3).Value * DataGridView1.Rows(numrow).Cells(4).Value
                End If

            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        dr.Dispose()
        conn.Close()

    End Sub
    Sub Load_Foods()
        FlowLayoutPanel1.Controls.Clear()
        FlowLayoutPanel1.AutoScroll = True
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT `img`, `foodcode`, `foodname`, `price` FROM `tbl_food`", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                Load_controls()
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Sub Get_grandTotal()
        Try
            Dim grandtotal As Double = 0
            For i As Double = 0 To DataGridView1.Rows.Count() - 1 Step +1
                grandtotal = grandtotal + DataGridView1.Rows(i).Cells(5).Value

            Next
            lbl_overallTotal.Text = Format(CDec(grandtotal), "₱ #,##0.00")
            lbl_GrandTotal.Text = Format(CDec(grandtotal), "₱ #,##0.00")
            lbl_tot.Text = grandtotal
        Catch ex As Exception

        End Try
    End Sub

    Sub Get_pricedata()
        Try
            Dim noofProducts As Double = 0

            For i As Double = 0 To DataGridView1.Rows.Count() - 1 Step +1
                noofProducts = noofProducts + DataGridView1.Rows(i).Cells(4).Value

            Next
            lbl_noOfProducts.Text = noofProducts
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Get_grandTotal()
        Get_pricedata()

        lbl_date1.Text = Date.Now.ToString("ddd, dd-MM-yyyy")
        lbl_time.Text = Date.Now.ToString("hh:mm:ss tt")
    End Sub
    Sub new_order()
        Load_Foods()
        DataGridView1.Rows.Clear()
        lbl_date.Text = Date.Now.ToString("yyyy-MM-dd")
        auto_Transno()
        txt_BalanceAmount.Clear()
        txt_receivedAmount.Clear()
    End Sub

    '---------------------All of the buttons in Form1 below---------------------

    'Button for Managing Foods / Manage Foods Button
    Private Sub btn_ManageFoods_Click(sender As Object, e As EventArgs) Handles btn_ManageFoods.Click
        frm_ManageFoods.ShowDialog()
    End Sub

    'Button for new orders / New Order Button
    Private Sub btn_NewOrder_Click(sender As Object, e As EventArgs) Handles btn_NewOrder.Click
        new_order()
    End Sub

    'Button for canceling Order / Cancel Order Button
    Private Sub btn_CancelOrder_Click(sender As Object, e As EventArgs) Handles btn_CancelOrder.Click
        frm_CancelOrder.ShowDialog()
    End Sub

    'Button for viewing the reports / Reports Button
    Private Sub btn_Report_Click(sender As Object, e As EventArgs) Handles btn_Report.Click
        frm_report.ShowDialog()
    End Sub

    'Button for paying the items / Pay Button
    Private Sub btn_Pay_Click(sender As Object, e As EventArgs) Handles btn_Pay.Click
        If MsgBox("Are You Sure Order Conform ?", vbQuestion + vbYesNo) = vbYes Then
            If txt_receivedAmount.Text = String.Empty Then
                MsgBox("Please Enter Receive Amount !", vbExclamation)
                Return
            ElseIf txt_BalanceAmount.Text < 0 Then
                MsgBox("Infinity Balance !" & vbNewLine & txt_receivedAmount.Text & " ₹", MsgBoxStyle.Exclamation)
                Return
            Else
                Try
                    conn.Open()
                    cmd = New MySqlCommand("INSERT INTO `tbl_pos`(`transno`, `transdate`, `transmonth`, `foodcode`, `foodname`, `price`, `qty`, `totalprice`, `grandtotal`, `nooffoods`) VALUES (@transno,@transdate,@transmonth,@foodcode,@foodname,@price,@qty,@totalprice,@grandtotal,@nooffoods)", conn)
                    For j As Integer = 0 To DataGridView1.Rows.Count - 1 Step +1
                        cmd.Parameters.Clear()
                        cmd.Parameters.AddWithValue("@transno", txt_transno.Text)
                        cmd.Parameters.AddWithValue("@transdate", CDate(lbl_date.Text))
                        cmd.Parameters.AddWithValue("@transmonth", Date.Now.ToString("MM"))
                        cmd.Parameters.AddWithValue("@foodcode", DataGridView1.Rows(j).Cells(1).Value)
                        cmd.Parameters.AddWithValue("@foodname", DataGridView1.Rows(j).Cells(2).Value)
                        cmd.Parameters.AddWithValue("@price", DataGridView1.Rows(j).Cells(3).Value)
                        cmd.Parameters.AddWithValue("@qty", DataGridView1.Rows(j).Cells(4).Value)
                        cmd.Parameters.AddWithValue("@totalprice", DataGridView1.Rows(j).Cells(5).Value)
                        cmd.Parameters.AddWithValue("@grandtotal", lbl_tot.Text)
                        cmd.Parameters.AddWithValue("@nooffoods", lbl_noOfProducts.Text)
                        i = cmd.ExecuteNonQuery
                    Next
                    If i > 0 Then
                        If MsgBox("Print Bill ?", vbQuestion + vbYesNo) = vbYes Then
                            '---------------Print
                            'frm_BillPrint.ShowDialog()

                            changelongpaper()
                            PPD.Document = PD
                            PPD.ShowDialog()
                            '---------------Print
                        End If
                    Else
                        MsgBox("Warning : Some Failure !", vbExclamation)
                    End If
                Catch ex As Exception

                End Try
                conn.Close()
            End If
        Else
            Return
        End If
        new_order()
    End Sub

    '---------------Print
    Private Sub PD_BeginPrint(sender As Object, e As PrintEventArgs) Handles PD.BeginPrint
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("Custom", 415, longpaper)
        PD.DefaultPageSettings = pagesetup
    End Sub
    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage
        Dim f8 As New Font("Calibri", 8, FontStyle.Regular)
        Dim f10 As New Font("Calibri", 10, FontStyle.Bold)
        Dim f14 As New Font("Calibri", 14, FontStyle.Bold)

        Dim leftmargin As Integer = PD.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PD.DefaultPageSettings.PaperSize.Width

        Dim right As New StringFormat
        Dim center As New StringFormat

        right.Alignment = StringAlignment.Far
        center.Alignment = StringAlignment.Center

        Dim line As String
        line = "_____________________________________________________________________"

        Dim image As Image = Image.FromFile("C:\Users\Dell\Downloads\PF101 - Final System Assets\foodhub-logo.png")

        Dim desiredWidth As Integer = 110
        Dim desiredHeight As Integer = 31
        Dim printAreaX As Integer = (e.PageBounds.Width - desiredWidth) / 2
        Dim printAreaY As Integer = 25


        e.Graphics.Clear(Color.FromArgb(37, 37, 37))
        e.Graphics.DrawImage(image, New Rectangle(printAreaX, printAreaY, desiredWidth, desiredHeight))


        e.Graphics.DrawString("Transaction No.", f8, Brushes.White, 10, 75)
        e.Graphics.DrawString(":", f8, Brushes.White, 85, 75)
        e.Graphics.DrawString(txt_transno.Text, f10, Brushes.White, 95, 75)

        e.Graphics.DrawString("Cashier", f8, Brushes.White, 10, 90)
        e.Graphics.DrawString(":", f8, Brushes.White, 85, 90)
        e.Graphics.DrawString("Admin", f10, Brushes.White, 95, 90)

        e.Graphics.DrawString("Date", f8, Brushes.White, 10, 105)
        e.Graphics.DrawString(":", f8, Brushes.White, 85, 105)
        e.Graphics.DrawString(Date.Now().ToString("yyyy-MM-dd"), f10, Brushes.White, 95, 105)

        e.Graphics.DrawString(line, f8, Brushes.White, 11, 120)

        ' Draw the DataGridView
        Dim dgv As DataGridView = DataGridView1
        Dim startX As Integer = 10
        Dim startY As Integer = 140
        Dim lineHeight As Integer = 18
        Dim columnWidths As New List(Of Integer)
        Dim headerMargin As Integer = 13
        Dim dataMargin As Integer = 13

        ' Draw column headers
        For col As Integer = 0 To dgv.ColumnCount - 1
            Dim headerText As String = dgv.Columns(col).HeaderText
            Dim headerWidth As Integer = CInt(e.Graphics.MeasureString(headerText, f8).Width) + 2 * headerMargin
            columnWidths.Add(headerWidth)
            e.Graphics.DrawString(headerText, f8, Brushes.White, startX + headerMargin, startY)
            startX += headerWidth
        Next

        ' Draw data
        startY += lineHeight
        Dim dgvHeight As Integer = dgv.RowCount * lineHeight
        For row As Integer = 0 To dgv.RowCount - 1
            startX = 10
            For col As Integer = 0 To dgv.ColumnCount - 1
                Dim cellValue As String = dgv.Rows(row).Cells(col).FormattedValue.ToString()
                Dim cellWidth As Integer = columnWidths(col)
                e.Graphics.DrawString(cellValue, f8, Brushes.White, startX + dataMargin, startY)
                startX += cellWidth
            Next
            startY += lineHeight
        Next

        ' Calculate Y-axis position for the line based on the height of the DataGridView
        Dim lineY As Integer = startY + 1

        ' Draw the line
        e.Graphics.DrawString(line, f8, Brushes.White, 11, lineY)

        e.Graphics.DrawString("Items", f8, Brushes.White, 10, lineY + 20)
        e.Graphics.DrawString(":", f8, Brushes.White, 85, lineY + 20)
        e.Graphics.DrawString(lbl_noOfProducts.Text, f10, Brushes.White, 95, lineY + 20)

        e.Graphics.DrawString("Total", f8, Brushes.White, 10, lineY + 35)
        e.Graphics.DrawString(":", f8, Brushes.White, 85, lineY + 35)
        e.Graphics.DrawString("₱" & lbl_tot.Text, f10, Brushes.White, 95, lineY + 35)

        e.Graphics.DrawString("Cash", f8, Brushes.White, 10, lineY + 50)
        e.Graphics.DrawString(":", f8, Brushes.White, 85, lineY + 50)
        e.Graphics.DrawString("₱" & txt_receivedAmount.Text, f10, Brushes.White, 95, lineY + 50)

        e.Graphics.DrawString("Change", f8, Brushes.White, 10, lineY + 65)
        e.Graphics.DrawString(":", f8, Brushes.White, 85, lineY + 65)
        e.Graphics.DrawString("₱" & txt_BalanceAmount.Text, f10, Brushes.White, 95, lineY + 65)

        e.Graphics.DrawString("Thank you! Come again.", f14, Brushes.White, centermargin, lineY + 130, center)


    End Sub
    '---------------Print

    '---------------------All of the buttons in Form1 above---------------------

    Private Sub txt_search_TextChanged_1(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        FlowLayoutPanel1.Controls.Clear()
        FlowLayoutPanel1.AutoScroll = True
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT `img`, `foodcode`, `foodname`, `price` FROM `tbl_food` WHERE foodcode like '%" & txt_search.Text & "%' or foodname like '%" & txt_search.Text & "%' or price like '%" & txt_search.Text & "%'", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                Load_controls()
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub


    Private Sub txt_receivedAmount_TextChanged(sender As Object, e As EventArgs) Handles txt_receivedAmount.TextChanged
        Try
            Dim grandtotal As Double = 0
            For i As Double = 0 To DataGridView1.Rows.Count() - 1 Step +1
                grandtotal = grandtotal + DataGridView1.Rows(i).Cells(5).Value

            Next
            txt_BalanceAmount.Text = txt_receivedAmount.Text - Format(CDec(grandtotal), "#,##0.00")
            lbl_tot.Text = grandtotal
        Catch ex As Exception

        End Try

    End Sub

    'Button for logging out / Exit Button
    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        If MsgBox("Are you sure Exit !", vbQuestion + vbYesNo) = vbYes Then
            End
        Else
            Return
        End If
        End
    End Sub

    'Button for clearing the food cart / Clear Button
    Private Sub btn_Clear_Click(sender As Object, e As EventArgs) Handles btn_Clear.Click
        DataGridView1.Rows.Clear()
        txt_BalanceAmount.Clear()
        txt_receivedAmount.Clear()
    End Sub

End Class
