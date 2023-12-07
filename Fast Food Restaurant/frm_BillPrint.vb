Imports System.IO
Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Public Class frm_BillPrint

    Private Sub frm_BillPrint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        Me.ReportViewer1.RefreshReport()
        load_reportPrint()
    End Sub

    Sub load_reportPrint()
        Dim rptDS As ReportDataSource
        Me.ReportViewer1.RefreshReport()
        ReportViewer1.LocalReport.DataSources.Clear()
        Try
            'ReportViewer1.LocalReport.ReportPath = Application.StartupPath & "\Report\Report1.rdlc "
            ReportViewer1.LocalReport.ReportPath = "C:\Users\Dell\Downloads\Fast Food Restaurant\Fast Food Restaurant\Report\Report1.rdlc"
            ReportViewer1.LocalReport.DataSources.Clear()
            Dim ds As New DataSet1
            Dim da As New MySqlDataAdapter

            da.SelectCommand = New MySqlCommand("SELECT * FROM `tbl_pos` WHERE transno='" & Form1.txt_transno.Text & "'", conn)
            da.Fill(ds.Tables("DataTable1"))

            rptDS = New ReportDataSource("DataSet1", ds.Tables("DataTable1"))
            ReportViewer1.LocalReport.DataSources.Add(rptDS)
            ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            ReportViewer1.ZoomMode = ZoomMode.Percent
            ReportViewer1.ZoomPercent = 100
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            conn.Close()
        End Try
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub
End Class