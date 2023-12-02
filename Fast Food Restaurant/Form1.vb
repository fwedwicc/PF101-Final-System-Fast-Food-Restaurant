Imports System.IO
Imports MySql.Data.MySqlClient
Imports System.Drawing
Public Class Form1
    Private WithEvents pan As Panel
    Private WithEvents pan_top As Panel
    Private WithEvents foodcode As Label
    Private WithEvents foodname As Label
    Private WithEvents price As Label
    Private WithEvents img As CirclePicturBox
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        lbl_date.Text = Date.Now.ToString("yyyy-MM-dd")
        DataGridView1.RowTemplate.Height = 30
        Load_Foods()
        auto_Transno()
    End Sub

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

        Dim margin As Integer = 6
        Dim padding As Integer = 8
        pan = New Panel
        With pan
            .Width = 146.7
            .Height = 230
            .BackColor = Color.FromArgb(40, 40, 40)
            .Tag = dr.Item("foodcode").ToString
            .Padding = New Padding(padding)
            .Margin = New Padding(Margin)
        End With
        pan_top = New Panel
        With pan_top
            .Width = 150
            .Height = 10
            .BackColor = Color.FromArgb(40, 40, 40)
            .Dock = DockStyle.Top
            .Tag = dr.Item("foodcode").ToString
        End With

        img = New CirclePicturBox
        With img
            .Height = 120
            .BackgroundImageLayout = ImageLayout.Stretch
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
                            frm_BillPrint.ShowDialog()
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

    'Button for logging out / Exit Button
    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        If MsgBox("Are you sure Exit !", vbQuestion + vbYesNo) = vbYes Then
            End
        Else
            Return
        End If
        End
    End Sub

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

End Class
