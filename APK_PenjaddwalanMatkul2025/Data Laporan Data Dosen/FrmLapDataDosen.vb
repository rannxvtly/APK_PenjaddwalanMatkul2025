Imports MySql.Data.MySqlClient
Imports System.Data.Odbc
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class FrmLapDataDosen
    Private Sub BTNKeluarLapData_Click(sender As Object, e As EventArgs) Handles BTNKeluarLapData.Click
        If BTNKeluarLapData.Text = "&KELUAR" Then
            Pesan = MsgBox("Anda yakin ingin keluar dari form ini?", vbQuestion + vbYesNo, "Informasi")
            If Pesan = vbYes Then
                Me.Close()
            End If
        End If
    End Sub

    Private Sub     Frmlapdatamahasiswa_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call KoneksiDb()
        Call TampilkanFilterNamaProdi()
        'Call TampilkanTahunAngkatan()
    End Sub

    'membuat sub prosedur tampilkan filter nama prodi dan menampilkan ke dalam combox 
    Sub TampilkanFilterNamaProdi()

        Try
            Call KoneksiDb()

            QUERY = "SELECT tbl_prodi.Kd_Prodi, tbl_prodi.Nm_Prodi 
                 FROM tbl_prodi  
                 ORDER BY tbl_prodi.Kd_Prodi"

            DA = New MySqlDataAdapter(QUERY, DbKoneksi)

            Dim DT As New DataTable
            DA.Fill(DT)

            CBNamaJurusanLapData.DataSource = DT
            CBNamaJurusanLapData.DisplayMember = "Nm_Prodi"
            CBNamaJurusanLapData.ValueMember = "Kd_Prodi"
            CBNamaJurusanLapData.SelectedIndex = -1 'data sebelum memilih

        Catch ex As Exception
            MsgBox("Gagal memuat data Prodi: " & ex.Message, vbCritical)
        End Try
    End Sub

    'membuat fungsi validasi data 
    Function ValidasiDataLaporan() As Boolean
        Try
            Call KoneksiDb()

            ' QUERY diubah untuk menghitung data dari tbl_dosen berdasarkan Prodi
            QUERY = "SELECT COUNT(*) FROM tbl_dosen " &
                    "INNER JOIN tbl_prodi ON tbl_dosen.Kd_Prodi = tbl_prodi.Kd_Prodi " &
                    "WHERE tbl_prodi.Kd_Prodi = @KdProdi"

            CMD = New MySqlCommand(QUERY, DbKoneksi)

            ' Menggunakan nama control CBNamaJurusanLapData sesuai gambar Document Outline Anda
            CMD.Parameters.AddWithValue("@KdProdi", CBNamaJurusanLapData.SelectedValue)

            ' Menghitung jumlah data
            Dim jumlah As Integer = Convert.ToInt32(CMD.ExecuteScalar())

            If jumlah > 0 Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox("Kesalahan validasi laporan : " & ex.Message, vbCritical)
            Return False
        End Try
    End Function

    Private Sub BTNCETAKLapDataDosen_Click(sender As Object, e As EventArgs) Handles BTNCETAKLapDataDosen.Click
        Call KoneksiDb()

        Try
            ' 1. PENGECEKAN DATA
            ' Tetap gunakan query SQL Anda untuk validasi keberadaan data
            Dim sql As String = "SELECT v_dosen.* FROM v_dosen " &
                          "WHERE Nm_Prodi = '" & CBNamaJurusanLapData.Text & "'"

            CMD = New MySqlCommand(sql, DbKoneksi)
            DR = CMD.ExecuteReader

            If DR.HasRows Then
                DR.Close()

                ' 2. PENYIAPAN PATH FILE
                Dim CryLapDosenPath As String = Application.StartupPath & "\Data Laporan Data Dosen\CryRptLaporanDataDosen.rpt"

                If Not IO.File.Exists(CryLapDosenPath) Then
                    MsgBox("File laporan tidak ditemukan!", vbCritical)
                    Exit Sub
                End If

                ' 3. LOADING REPORT KE VIEWER
                Dim LapDataDosen As New ReportDocument
                LapDataDosen.Load(CryLapDosenPath)

                ' Atur sumber laporan
                CrystalReportViewer1.ReportSource = LapDataDosen

                ' PERBAIKAN: Gunakan v_dosen1 sesuai gambar Field Explorer Anda
                CrystalReportViewer1.SelectionFormula = "{v_dosen1.Nm_Prodi} = '" & CBNamaJurusanLapData.Text & "'"

                CrystalReportViewer1.RefreshReport()
            Else
                DR.Close()
                MsgBox("Data untuk jurusan " & CBNamaJurusanLapData.Text & " tidak ditemukan.", vbInformation)
                CrystalReportViewer1.ReportSource = Nothing
            End If

        Catch ex As Exception
            MsgBox("Gagal mencetak: " & ex.Message, vbCritical)
        Finally
            If DbKoneksi.State = ConnectionState.Open Then DbKoneksi.Close()
        End Try
    End Sub
    Private Sub CBNamaJurusanLapData_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBNamaJurusanLapData.SelectedIndexChanged
        ' 1. Mencegah error pada saat form load awal atau saat data kosong
        If CBNamaJurusanLapData.SelectedIndex < 0 Then Exit Sub
        If CBNamaJurusanLapData.SelectedValue Is Nothing Then Exit Sub

        Try
            ' 2. Mengambil nilai Kode Prodi yang dipilih
            ' Pastikan variabel Kode_Jurusan sudah dideklarasikan secara global atau lokal
            Kode_Jurusan = CBNamaJurusanLapData.SelectedValue.ToString()

            ' 3. Opsional: Reset viewer jika user mengganti jurusan agar data lama tidak tertampil
            ' CrystalReportViewer1.ReportSource = Nothing

        Catch ex As Exception
            MsgBox("Error memilih prodi: " & ex.Message, vbCritical)
        End Try
    End Sub
End Class