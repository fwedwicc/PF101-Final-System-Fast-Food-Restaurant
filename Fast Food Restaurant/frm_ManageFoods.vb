Imports System.IO
Imports MySql.Data.MySqlClient
Public Class frm_ManageFoods

    Private Sub frm_ManageFoods_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        DataGridView1.RowTemplate.Height = 30
        auto_foodcode()
        Load_fooddata()
    End Sub
    Sub Load_fooddata()
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT `foodcode`, `foodname`, `price` FROM `tbl_food`", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("foodcode"), dr.Item("foodname"), dr.Item("price"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub
    Private Sub pic_foodimg_Click(sender As Object, e As EventArgs) Handles pic_foodimg.Click
        Dim pop As OpenFileDialog = New OpenFileDialog
        If pop.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            pic_foodimg.Image = Image.FromFile(pop.FileName)
        End If
    End Sub
    Sub auto_foodcode()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM `tbl_food` order by id desc", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = True Then
                txt_foodcode.Text = dr.Item("foodcode").ToString + 1

            Else
                txt_foodcode.Text = Date.Now.ToString("yyyyMM") & "001"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Sub clear()
        txt_foodname.Clear()
        txt_price.Clear()
        pic_foodimg.Image = Nothing
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT `foodcode`, `foodname`, `price` FROM `tbl_food` WHERE foodcode like '%" & TextBox1.Text & "%' or foodname like '%" & TextBox1.Text & "%' or price like '%" & TextBox1.Text & "%'", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("foodcode"), dr.Item("foodname"), dr.Item("price"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()

    End Sub

    'Button for saving the items in manage foods form / Save Button
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO `tbl_food`(`foodcode`, `foodname`, `price`, `img`) VALUES (@foodcode,@foodname,@price,@img)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@foodcode", txt_foodcode.Text)
            cmd.Parameters.AddWithValue("@foodname", txt_foodname.Text)
            cmd.Parameters.AddWithValue("@price", CDec(txt_price.Text))
            Dim FileSize As New UInt32
            Dim mstream As New System.IO.MemoryStream
            pic_foodimg.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim picture() As Byte = mstream.GetBuffer
            FileSize = mstream.Length
            mstream.Close()
            cmd.Parameters.AddWithValue("@img", picture)

            Dim i As Integer
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("New Food Save Successfully !", vbInformation, "FAST FOOD")
            Else
                MsgBox("Warning : Food Save Failed !", vbCritical, "FAST FOOD")
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        clear()
        auto_foodcode()
        Load_fooddata()
        Form1.Load_Foods()
    End Sub

    'Button for editing an item in manage foods form / Edit Button
    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("UPDATE `tbl_food` SET `foodname`=@foodname,`price`=@price,`img`=@img WHERE `foodcode`=@foodcode", conn)
            cmd.Parameters.Clear()

            cmd.Parameters.AddWithValue("@foodname", txt_foodname.Text)
            cmd.Parameters.AddWithValue("@price", CDec(txt_price.Text))
            Dim FileSize As New UInt32
            Dim mstream As New System.IO.MemoryStream
            pic_foodimg.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim picture() As Byte = mstream.GetBuffer
            FileSize = mstream.Length
            mstream.Close()
            cmd.Parameters.AddWithValue("@img", picture)
            cmd.Parameters.AddWithValue("@foodcode", txt_foodcode.Text)
            Dim i As Integer
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("Food Edit Successfully !", vbInformation, "FAST FOOD")
            Else
                MsgBox("Warning : Food Edit Failed !", vbCritical, "FAST FOOD")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        clear()
        auto_foodcode()
        Load_fooddata()
        Form1.Load_Foods()
    End Sub

    'Button for deleting an item in manage foods form / Delete Button
    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If MsgBox("Are you Sure Delete this Food Product !", vbQuestion + vbYesNo, "FAST FOOD") = vbYes Then
            Try
                conn.Open()
                cmd = New MySqlCommand("DELETE FROM `tbl_food` WHERE `foodcode`=@foodcode", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@foodcode", txt_foodcode.Text)
                Dim i As Integer
                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("Food Delete Successfully !", vbInformation, "FAST FOOD")
                Else
                    MsgBox("Warning : Food Delete Failed !", vbCritical, "FAST FOOD")
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conn.Close()
            clear()
            clear()
            auto_foodcode()
            Load_fooddata()
            Form1.Load_Foods()
        Else
            Return

        End If
    End Sub

    'Button for closing the manage foods form / Back Button
    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub btn_find_Click(sender As Object, e As EventArgs) Handles btn_find.Click
        clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM `tbl_food` WHERE `foodcode`=@foodcode", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@foodcode", txt_found.Text)
            dr = cmd.ExecuteReader
            While dr.Read
                Dim foodcode As String = dr.Item("foodcode")
                Dim foodname As String = dr.Item("foodname")
                Dim price As Decimal = dr.Item("price")

                txt_foodcode.Text = foodcode
                txt_foodname.Text = foodname
                txt_price.Text = price
                Dim bytes As [Byte]() = dr.Item("img")
                Dim ms As New MemoryStream(bytes)
                pic_foodimg.Image = Image.FromStream(ms)

            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

End Class