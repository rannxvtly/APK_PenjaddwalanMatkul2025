Imports MySql.Data.MySqlClient
Public Class FrmDataJurusan
    'Sub AktifdatagridJurusan()
    '    With DataGridJurusan
    '        .EnableHeadersVisualStyles = False
    '        .ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 9, FontStyle.Bold)
    '        .DefaultCellStyle.Font = New Font("Arial", 9)
    '        .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
    '        .ColumnHeadersHeight = 35


    '        .Columns(0).Width = 130
    '        .Columns(0).HeaderText = "KODE PRODI"
    '        .Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

    '        .Columns(1).Width = 290
    '        .Columns(1).HeaderText = "NAMA JURUSAN"
    '        .Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    '    End With
    'End Sub

    '' Sub untuk menampilin data jurusan ke Grid jurusan
    'Sub TampilkanDataJurusan()
    '    Call KoneksiDb()
    '    DA = New MySqlDataAdapter("SELECT * FROM tbl_prodi ORDER BY Kd_Prodi ASC", DbKoneksi)
    '    DS = New DataSet
    '    DS.Clear()
    '    DA.Fill(DS)
    '    DataGridJurusan.Columns.Clear()
    '    DataGridJurusan.DataSource = DS.Tables(0)
    '    DataGridJurusan.ReadOnly = True
    '    Call AktifdatagridJurusan()
    'End Sub

    'Private Sub FrmDataJurusan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    Call KoneksiDb()
    '    Call TampilkanDataJurusan()
    'End Sub

    '' Tombol Untuk Cari Jurusan
    'Private Sub BTNCariJurusan_Click(sender As Object, e As EventArgs) Handles BTNCariJurusan.Click
    '    Call KoneksiDb()
    '    DA = New MySqlDataAdapter("SELECT * FROM tbl_prodi WHERE Nm_Prodi LIKE '%" & TXTCariJurusan.Text & "%'", DbKoneksi)
    '    DS = New DataSet
    '    DS.Clear()
    '    DA.Fill(DS)

    '    'Jika tidak ada data yang ditemukan
    '    If DS.Tables(0).Rows.Count = 0 Then
    '        MsgBox("Jurusan tidak ditemukan. Silakan tambah prodi terlebih dahulu.", vbExclamation, "Peringatan")
    '        DataGridJurusan.Columns.Clear()
    '        Exit Sub
    '    End If

    '    'Tampilkan data ke DataGrid
    '    DataGridJurusan.Columns.Clear()
    '    DataGridJurusan.DataSource = DS.Tables(0)

    '    'Panggil aktif data grid jurusan
    '    Call AktifdatagridJurusan()
    'End Sub


    ''Double klik untuk edit data jurusan
    'Private Sub DataGridJurusan_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridJurusan.CellMouseDoubleClick
    '    ' Agar tidak error jika klik header
    '    If e.RowIndex < 0 Then Exit Sub
    '    On Error Resume Next

    '    FrmJurusan.Show()
    '    Me.Enabled = False
    '    FrmJurusan.MdiParent = FrmMenuUtama

    '    ' Tombol Simpan/Ubah biru
    '    FrmJurusan.BTNSIMPANJURUSAN.Enabled = True
    '    FrmJurusan.BTNSIMPANJURUSAN.Text = "UBAH"
    '    FrmJurusan.BTNSIMPANJURUSAN.BackColor = Color.CornflowerBlue
    '    FrmJurusan.BTNSIMPANJURUSAN.ForeColor = Color.Black

    '    ' Tombol Hapus biru
    '    FrmJurusan.BTNHAPUSJurusan.Enabled = True
    '    FrmJurusan.BTNHAPUSJurusan.BackColor = Color.CornflowerBlue
    '    FrmJurusan.BTNHAPUSJurusan.ForeColor = Color.Black

    '    ' Tombol Batal biru
    '    FrmJurusan.BTNKELUARKode.Enabled = True
    '    FrmJurusan.BTNKELUARKode.BackColor = Color.CornflowerBlue
    '    FrmJurusan.BTNKELUARKode.ForeColor = Color.Black
    '    FrmJurusan.BTNKELUARKode.Text = "BATAL"

    '    ' Ambil data dari grid
    '    Dim baris As Integer = DataGridJurusan.CurrentRow.Index
    '    FrmJurusan.LBLKODE.Text = DataGridJurusan.Rows(baris).Cells(0).Value
    '    FrmJurusan.TxtNAMAPRODI.Text = DataGridJurusan.Rows(baris).Cells(1).Value

    '    ' Cek kode Prodi di database
    '    Call KoneksiDb()
    '    CMD = New MySqlCommand("SELECT * FROM tbl_prodi WHERE Kd_Prodi='" & FrmJurusan.LBLKODE.Text & "'", DbKoneksi)
    '    DR = CMD.ExecuteReader
    '    If DR.HasRows Then
    '        FrmJurusan.LBLKODE.Enabled = False   ' Valid, tidak bisa diedit
    '    Else
    '        FrmJurusan.LBLKODE.Enabled = True    ' Salah/baru, bisa diedit
    '        MsgBox("Kode Prodi tidak ditemukan, silakan perbaiki.", vbExclamation)
    '    End If
    '    DR.Close()
    'End Sub

    ''tambah jurusan
    'Private Sub BTNTambahJurusan_Click(sender As Object, e As EventArgs) Handles BTNTambahJurusan.Click
    '    FrmJurusan.Show()
    '    Me.Enabled = False

    '    ' Kosongkan form dulu
    '    FrmJurusan.Kosongkan()

    '    ' ✅ TAMBAHAN: Generate kode otomatis di FrmDataJurusan
    '    Call KoneksiDb()
    '    CMD = New MySqlCommand("SELECT Kd_Prodi FROM tbl_prodi ORDER BY Kd_Prodi DESC LIMIT 1", DbKoneksi)
    '    DR = CMD.ExecuteReader
    '    DR.Read()

    '    If Not DR.HasRows Then
    '        ' Jika belum ada data, mulai dari PR005
    '        FrmJurusan.LBLKODE.Text = "PR005"
    '    Else
    '        ' Ambil 3 angka terakhir + 1
    '        Dim Hitung As Long = Val(Microsoft.VisualBasic.Right(DR.GetString(0), 3)) + 1
    '        FrmJurusan.LBLKODE.Text = "PR" & Microsoft.VisualBasic.Right("000" & Hitung, 3)
    '    End If

    '    DR.Close()

    '    ' ==== SETTING TOMBOL TAMBAH MODE SIMPAN ====
    '    FrmJurusan.BTNSIMPANJURUSAN.Enabled = True
    '    FrmJurusan.BTNSIMPANJURUSAN.Text = "SIMPAN"
    '    FrmJurusan.BTNSIMPANJURUSAN.BackColor = Color.CornflowerBlue

    '    FrmJurusan.BTNHAPUSJurusan.Enabled = False
    '    FrmJurusan.BTNHAPUSJurusan.BackColor = Color.CornflowerBlue

    '    FrmJurusan.BTNKELUARKode.Enabled = True
    '    FrmJurusan.BTNKELUARKode.Text = "BATAL"
    '    FrmJurusan.BTNKELUARKode.BackColor = Color.CornflowerBlue
    'End Sub


    ''Konfirmasi keluar
    'Private Sub BTNKeluarJurusan_Click(sender As Object, e As EventArgs) Handles BTNKeluarJurusan.Click
    '    If MsgBox("Yakin mau tutup data jurusan?", vbQuestion + vbYesNo, "Konfirmasi") = vbYes Then
    '        Me.Close()
    '    End If
    'End Sub

    'Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    'End Sub


    ' Interaksi Objek
    Private repo As New JurusanRepository()

    Sub AktifdatagridJurusan()
        With DataGridJurusan
            .EnableHeadersVisualStyles = False
            .ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 9, FontStyle.Bold)
            .DefaultCellStyle.Font = New Font("Arial", 9)
            .ColumnHeadersHeight = 35

            ' Mengatur tampilan kolom (List Of T otomatis memetakan nama Property)
            If .Columns.Count >= 2 Then
                .Columns(0).Width = 130
                .Columns(0).HeaderText = "KODE PRODI"
                .Columns(1).Width = 290
                .Columns(1).HeaderText = "NAMA JURUSAN"
            End If
        End With
    End Sub

    Sub TampilkanDataJurusan()
        ' POIN 5: Menggunakan List(Of T) sebagai DataSource, bukan DataSet/DataTable langsung
        Dim data As List(Of Jurusan) = repo.AmbilSemua(TXTCariJurusan.Text)

        DataGridJurusan.DataSource = Nothing
        DataGridJurusan.DataSource = data
        AktifdatagridJurusan()
    End Sub

    Private Sub FrmDataJurusan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilkanDataJurusan()
    End Sub

    Private Sub BTNCariJurusan_Click(sender As Object, e As EventArgs) Handles BTNCariJurusan.Click
        TampilkanDataJurusan()
        ' Cek jika data kosong
        If DataGridJurusan.Rows.Count = 0 Then
            MsgBox("Jurusan tidak ditemukan.", vbExclamation)
        End If
    End Sub

    ' TAMBAH DATA
    Private Sub BTNTambahJurusan_Click(sender As Object, e As EventArgs) Handles BTNTambahJurusan.Click
        ' Logic Generate Kode tetap bisa ditaruh di sini atau dipindah ke Model
        Call KoneksiDb()
        Dim cmd As New MySqlCommand("SELECT Kd_Prodi FROM tbl_prodi ORDER BY Kd_Prodi DESC LIMIT 1", DbKoneksi)
        Dim dr As MySqlDataReader = cmd.ExecuteReader

        Dim kodeBaru As String = ""
        If Not dr.HasRows Then
            kodeBaru = "PR005"
        Else
            dr.Read()
            Dim Hitung As Long = Val(Microsoft.VisualBasic.Right(dr.GetString(0), 3)) + 1
            kodeBaru = "PR" & Microsoft.VisualBasic.Right("000" & Hitung, 3)
        End If
        dr.Close()

        With FrmJurusan
            .Kosongkan()
            .LBLKODE.Text = kodeBaru
            .BTNSIMPANJURUSAN.Text = "SIMPAN"
            .BTNSIMPANJURUSAN.Enabled = True
            .ShowDialog() ' Gunakan ShowDialog agar form refresh setelah input selesai
        End With
        TampilkanDataJurusan()
        Me.Enabled = True
    End Sub

    ' DOUBLE CLICK EDIT
    Private Sub DataGridJurusan_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridJurusan.CellMouseDoubleClick
        If e.RowIndex < 0 Then Exit Sub

        ' Mengambil data objek dari baris yang diklik
        Dim terpilih As Jurusan = CType(DataGridJurusan.Rows(e.RowIndex).DataBoundItem, Jurusan)

        With FrmJurusan
            .LBLKODE.Text = terpilih.KodeProdi
            .TxtNAMAPRODI.Text = terpilih.NamaJurusan
            .BTNSIMPANJURUSAN.Text = "UBAH"
            .BTNHAPUSJurusan.Enabled = True
            .ShowDialog()
        End With
        TampilkanDataJurusan()
        Me.Enabled = True
    End Sub

    Private Sub BTNKeluarJurusan_Click(sender As Object, e As EventArgs) Handles BTNKeluarJurusan.Click
        If MsgBox("Yakin mau tutup data jurusan?", vbQuestion + vbYesNo) = vbYes Then
            Me.Close()
        End If
    End Sub
End Class

' ============================================================
' 1. CLASS MODEL (Sesuai Poin 1, 2, 3 Ketentuan UAS)
' ============================================================
Public Class Jurusan
    ' ENKAPSULASI: Property untuk menampung data
    Public Property KodeProdi As String
    Public Property NamaJurusan As String
End Class

' ============================================================
' 2. REPOSITORY (Poin 5: GUI Integration & List Of T)
' ============================================================
Public Class JurusanRepository
    Public Function AmbilSemua(Optional filter As String = "") As List(Of Jurusan)
        Dim daftar As New List(Of Jurusan)
        Try
            Call KoneksiDb()
            Dim sql As String = "SELECT Kd_Prodi, Nm_Prodi FROM tbl_prodi"
            If filter <> "" Then sql &= " WHERE Nm_Prodi LIKE @f"
            sql &= " ORDER BY Kd_Prodi ASC"

            Using cmd As New MySqlCommand(sql, DbKoneksi)
                If filter <> "" Then cmd.Parameters.AddWithValue("@f", "%" & filter & "%")
                Using dr As MySqlDataReader = cmd.ExecuteReader()
                    While dr.Read()
                        Dim j As New Jurusan()
                        j.KodeProdi = dr("Kd_Prodi").ToString()
                        j.NamaJurusan = dr("Nm_Prodi").ToString()
                        daftar.Add(j)
                    End While
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error Repository: " & ex.Message)
        End Try
        Return daftar
    End Function
End Class