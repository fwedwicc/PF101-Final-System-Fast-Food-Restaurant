Imports System.IO
Imports MySql.Data.MySqlClient
Imports System.Drawing
Public Class frm_report

    Private Sub frm_report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        DataGridView1.RowTemplate.Height = 30
        Load_report()
    End Sub

    Sub Load_report()
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT `transno`, `transdate`, `transmonth`, `foodcode`, `foodname`, `price`, `qty`, `totalprice`, `grandtotal` FROM `tbl_pos`", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("transdate"), dr.Item("transno"), dr.Item("transmonth"), dr.Item("foodcode"), dr.Item("foodname"), dr.Item("price"), dr.Item("qty"), dr.Item("totalprice"), dr.Item("grandtotal"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub ReleaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub
    Sub Get_Dashboard()

        Try
            conn.Open()

            cmd = New MySqlCommand("SELECT SUM(`totalprice`),`transdate` FROM `tbl_pos` WHERE `transdate`='" & Date.Now.ToString("yyyy-MM-dd") & "'", conn)
            lbl_todaySale.Text = cmd.ExecuteScalar

            cmd = New MySqlCommand("SELECT SUM(`totalprice`),`transmonth` FROM `tbl_pos` WHERE `transmonth`='" & Date.Now.ToString("MM") & "'", conn)
            lbl_lastmonth.Text = cmd.ExecuteScalar

            conn.Close()
        Catch ex As Exception

        End Try
        conn.Close()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Get_Dashboard()
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT `transno`, `transdate`, `transmonth`, `foodcode`, `foodname`, `price`, `qty`, `totalprice`, `grandtotal` FROM `tbl_pos` WHERE transno like '%" & txt_search.Text & "%' or foodcode like '%" & txt_search.Text & "%' or foodname like '%" & txt_search.Text & "%'", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("transdate"), dr.Item("transno"), dr.Item("transmonth"), dr.Item("foodcode"), dr.Item("foodname"), dr.Item("price"), dr.Item("qty"), dr.Item("totalprice"), dr.Item("grandtotal"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub btn_Filter_Click(sender As Object, e As EventArgs) Handles btn_Filter.Click
        Dim date1 As String = Guna2DateTimePicker1.Value.ToString("yyyy-MM-dd")
        Dim date2 As String = Guna2DateTimePicker2.Value.ToString("yyyy-MM-dd")

        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT `transno`, `transdate`, `transmonth`, `foodcode`, `foodname`, `price`, `qty`, `totalprice`, `grandtotal` FROM `tbl_pos` WHERE transdate between '" & date1 & "' and '" & date2 & "'", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("transdate"), dr.Item("transno"), dr.Item("transmonth"), dr.Item("foodcode"), dr.Item("foodname"), dr.Item("price"), dr.Item("qty"), dr.Item("totalprice"), dr.Item("grandtotal"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub
End Class