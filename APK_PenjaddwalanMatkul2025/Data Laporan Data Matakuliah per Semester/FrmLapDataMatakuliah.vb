Imports MySql.Data.MySqlClient
Imports System.Data.Odbc
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class FrmLapDataMatakuliah
    Private Sub BTNKeluarLapDataMatkul_Click(sender As Object, e As EventArgs) Handles BTNKeluarLapDataMatkul.Click
        If BTNKeluarLapDataMatkul.Text = "&KELUAR" Then
            Pesan = MsgBox("Anda yakin ingin keluar dari form ini?", vbQuestion + vbYesNo, "Informasi")
            If Pesan = vbYes Then
                Me.Close()
            End If
        End If
    End Sub

    ' --- 1. PROSEDUR TAMPILKAN PRODI ---
    Sub TampilkanFilterNamaProdi()
        Try
            Call KoneksiDb()
            Dim sql As String = "SELECT Kd_Prodi, Nm_Prodi FROM tbl_prodi ORDER BY Kd_Prodi"
            ' Menggunakan DataTable secara mandiri agar koneksi cepat dilepas
            Using daProdi As New MySqlDataAdapter(sql, DbKoneksi)
                Dim dtProdi As New DataTable
                daProdi.Fill(dtProdi)
                CBNamaJurusanLapDataMatkul.DataSource = dtProdi
                CBNamaJurusanLapDataMatkul.DisplayMember = "Nm_Prodi"
                CBNamaJurusanLapDataMatkul.ValueMember = "Kd_Prodi"
            End Using
            CBNamaJurusanLapDataMatkul.SelectedIndex = -1
        Catch ex As Exception
            MsgBox("Gagal muat prodi: " & ex.Message)
        Finally
            If DbKoneksi.State = ConnectionState.Open Then DbKoneksi.Close()
        End Try
    End Sub

    ' --- 2. LOAD FORM ---
    Private Sub FrmLapDataMatakuliah_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call TampilkanFilterNamaProdi()
        CMBSemester.Items.Clear()
        CMBSemester.Items.Add("Ganjil")
        CMBSemester.Items.Add("Genap")
        CMBSemester.SelectedIndex = 0
    End Sub

    ' --- 3. TOMBOL CETAK (KOREKSI VENDOR CODE 1267 & FATAL ERROR) ---
    Private Sub BTNCETAKLapDataMatkul_Click(sender As Object, e As EventArgs) Handles BTNCETAKLapDataMatkul.Click
        If CBNamaJurusanLapDataMatkul.SelectedIndex = -1 Then
            MsgBox("Pilih Program Studi terlebih dahulu!", vbExclamation)
            Exit Sub
        End If

        Try
            ' Bersihkan koneksi (Cegah Fatal Error)
            If DbKoneksi.State = ConnectionState.Open Then DbKoneksi.Close()
            MySql.Data.MySqlClient.MySqlConnection.ClearAllPools()

            Dim FullPath As String = Application.StartupPath & "\Data Laporan Data Matakuliah per Semester\CryRptLaporanDataMatakuliah.rpt"

            Dim rptDoc As New ReportDocument
            rptDoc.Load(FullPath)

            ' Filter berdasarkan Field Explorer
            ' Pastikan Nm_Prodi dan Status_Semester sesuai dengan teks di Form
            Dim formula As String = "{v_matakuliah_semester1.Nm_Prodi} = '" & CBNamaJurusanLapDataMatkul.Text & "' " &
                               "AND {v_matakuliah_semester1.Status_Semester} = '" & CMBSemester.Text & "'"

            CrystalReportViewer1.ReportSource = rptDoc
            CrystalReportViewer1.SelectionFormula = formula
            CrystalReportViewer1.RefreshReport()

        Catch ex As Exception
            MsgBox("Kesalahan: " & ex.Message, vbCritical)
        End Try
    End Sub
End Class