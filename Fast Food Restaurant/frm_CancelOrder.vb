Imports System.IO
Imports MySql.Data.MySqlClient
Public Class frm_CancelOrder

    Private Sub frm_CancelOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        DataGridView1.RowTemplate.Height = 30
        Load_cancelOrder()
    End Sub
    Sub Load_cancelOrder()
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT `transno`, `transdate`, `transmonth`, `foodcode`, `foodname`, `price`, `qty`, `totalprice`, `grandtotal`, `nooffoods` FROM `tbl_pos` GROUP BY transno", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("transdate"), dr.Item("transno"), dr.Item("grandtotal"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            Dim colName As String = DataGridView1.Columns(e.ColumnIndex).Name
            If colName = "Column5" Then
                If MsgBox("Are you sure you want to Delete this Order?", vbYesNo + vbQuestion) = vbYes Then
                    conn.Open()
                    Dim cmd As New MySqlCommand("DELETE FROM `tbl_pos` WHERE `transno`= '" & DataGridView1.CurrentRow.Cells(2).Value & "'", conn)
                    cmd.ExecuteNonQuery()
                    conn.Close()
                    MsgBox("Order has been successfully Deleted.", vbInformation)
                End If
            End If
        Catch ex As Exception
            conn.Close()
            MsgBox("Warning: " & ex.Message, vbCritical)
        End Try
        Load_cancelOrder()
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT `transno`, `transdate`, `transmonth`, `foodcode`, `foodname`, `price`, `qty`, `totalprice`, `grandtotal`, `nooffoods` FROM `tbl_pos` WHERE transno like '%" & txt_search.Text & "%' GROUP BY transno ", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("transdate"), dr.Item("transno"), dr.Item("grandtotal"))
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