Imports MySql.Data.MySqlClient
Public Class FrmRuangKelas
    '' =========================
    '' FORM LOAD
    '' =========================
    'Private Sub FrmRuangKelas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    Call TampilDataRuang()
    '    Call AktifkanDataGridKelas()
    '    Call KoneksiDb()

    'End Sub

    ''membuat data grid ruang kelas
    ''membuat tampian dataview
    'Sub AktifkanDataGridKelas()
    '    With DataGridKelas
    '        .EnableHeadersVisualStyles = False

    '        'mengatur properties pada data grid header
    '        .Font = New Font(DataGridKelas.Font, FontStyle.Bold)
    '        DataGridKelas.DefaultCellStyle.Font = New Font("Arial", 9)
    '        DataGridKelas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
    '        DataGridKelas.ColumnHeadersHeight = 35

    '        'memberikan nama header KODE RUANGAN
    '        DataGridKelas.Columns(0).Width = 150
    '        DataGridKelas.Columns(0).HeaderText = "KODE RUANGAN"
    '        DataGridKelas.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

    '        'memberikan nama header NAMA RUANGAN
    '        DataGridKelas.Columns(1).Width = 300
    '        DataGridKelas.Columns(1).HeaderText = "NAMA RUANGAN"
    '        DataGridKelas.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

    '        'memberikan nama header KAPASITAS
    '        DataGridKelas.Columns(2).Width = 120
    '        DataGridKelas.Columns(2).HeaderText = "KAPASITAS RUANGAN"
    '        DataGridKelas.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    '    End With
    'End Sub
    '' =========================
    '' TAMPIL DATA GRID
    '' =========================
    'Sub TampilDataRuang()
    '    Try
    '        Call KoneksiDb()

    '        DA = New MySqlDataAdapter(
    '        "SELECT 
    '            Kd_Ruangan,
    '            Nm_Ruangan,
    '            Jml_Kapasitas
    '         FROM tbl_ruangkelas
    '         ORDER BY Kd_Ruangan", DbKoneksi)

    '        DS = New DataSet
    '        DA.Fill(DS, "ruang")
    '        DataGridKelas.DataSource = DS.Tables("ruang")

    '        ' ⬅️ WAJIB PANGGIL SETELAH DATASOURCE
    '        AktifkanDataGridKelas()

    '    Catch ex As Exception
    '        MsgBox("Gagal menampilkan data ruang kelas : " & ex.Message, vbCritical)
    '    End Try
    'End Sub

    '' =========================
    '' CARI DATA RUANG
    '' =========================
    'Private Sub BTNCariKelas_Click(sender As Object, e As EventArgs) Handles BTNCariKelas.Click

    '    ' =========================
    '    ' JIKA KOSONG → TAMPIL SEMUA
    '    ' =========================
    '    If TXTCariJurusan.Text.Trim = "" Then
    '        TampilDataRuang()
    '        AktifkanDataGridKelas()
    '        Exit Sub
    '    End If

    '    Try
    '        Call KoneksiDb()
    '        DS = New DataSet

    '        ' =========================
    '        ' CARI BERDASARKAN KODE
    '        ' =========================
    '        If IsNumeric(TXTCariJurusan.Text.Trim) Then

    '            DA = New MySqlDataAdapter(
    '            "SELECT Kd_Ruangan, Nm_Ruangan, Jml_Kapasitas 
    '             FROM tbl_ruangkelas 
    '             WHERE Kd_Ruangan = @KdRuangan",
    '            DbKoneksi)

    '            DA.SelectCommand.Parameters.AddWithValue("@KdRuangan", TXTCariJurusan.Text.Trim)

    '        Else
    '            ' =========================
    '            ' CARI BERDASARKAN NAMA
    '            ' =========================
    '            DA = New MySqlDataAdapter(
    '            "SELECT Kd_Ruangan, Nm_Ruangan, Jml_Kapasitas 
    '             FROM tbl_ruangkelas 
    '             WHERE Nm_Ruangan LIKE @Nama",
    '            DbKoneksi)

    '            DA.SelectCommand.Parameters.AddWithValue("@Nama", "%" & TXTCariJurusan.Text.Trim & "%")
    '        End If

    '        DA.Fill(DS, "ruang")

    '        ' =========================
    '        ' VALIDASI DATA KOSONG
    '        ' =========================
    '        If DS.Tables("ruang").Rows.Count = 0 Then
    '            MsgBox("Data ruang kelas tidak ditemukan!", vbInformation)
    '            DataGridKelas.DataSource = Nothing
    '            Exit Sub
    '        End If

    '        ' =========================
    '        ' TAMPILKAN DATA
    '        ' =========================
    '        DataGridKelas.DataSource = DS.Tables("ruang")

    '        ' 🔴 PENTING: SETEL ULANG GRID
    '        AktifkanDataGridKelas()

    '    Catch ex As Exception
    '        MsgBox("Terjadi kesalahan saat pencarian ruang kelas : " & ex.Message, vbCritical)
    '    End Try

    'End Sub


    '' =========================
    '' TOMBOL TAMBAH DATA
    '' =========================
    'Private Sub BTNTambahKelas_Click(sender As Object, e As EventArgs) Handles BTNTambahKelas.Click
    '    With FrmInputRuangKelas
    '        .Mode = "SIMPAN"
    '        .KdRuangan = ""
    '        .ShowDialog()
    '    End With

    '    TampilDataRuang()
    'End Sub

    '' =========================
    '' DOUBLE CLICK → EDIT
    '' =========================
    'Private Sub DataGridKelas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridKelas.CellDoubleClick
    '    Try
    '        ' ===== VALIDASI KLIK =====
    '        If e.RowIndex < 0 Then Exit Sub
    '        If DataGridKelas.Rows.Count = 0 Then Exit Sub

    '        ' ===== AMBIL KODE RUANGAN =====
    '        Dim KdRuangan As String =
    '        DataGridKelas.Rows(e.RowIndex).Cells(0).Value.ToString()

    '        With FrmInputRuangKelas
    '            .Mode = "UBAH"
    '            .KdRuangan = KdRuangan
    '            .ShowDialog()

    '            ' ===== SAMAKAN LOGIKA WARNA TOMBOL =====
    '            .BTNSIMPANRUANGKELAS.Enabled = True
    '            .BTNSIMPANRUANGKELAS.Text = "UBAH"
    '            .BTNSIMPANRUANGKELAS.BackColor = Color.CornflowerBlue
    '            .BTNSIMPANRUANGKELAS.ForeColor = Color.Black

    '            .BTNKELUARRuangan.Enabled = True
    '            .BTNKELUARRuangan.Text = "BATAL"
    '            .BTNKELUARRuangan.BackColor = Color.CornflowerBlue
    '            .BTNKELUARRuangan.ForeColor = Color.Black

    '            .BTNHAPUSRuangan.Enabled = True
    '            .BTNHAPUSRuangan.BackColor = Color.CornflowerBlue
    '            .BTNHAPUSRuangan.ForeColor = Color.Black
    '        End With

    '        ' ===== QUERY DATABASE =====
    '        Call KoneksiDb()
    '        QUERY = "SELECT Kd_Ruangan, Nm_Ruangan, Jml_Kapasitas 
    '             FROM tbl_ruangkelas
    '             WHERE Kd_Ruangan = @KdRuangan"

    '        CMD = New MySqlCommand(QUERY, DbKoneksi)
    '        CMD.Parameters.AddWithValue("@KdRuangan", KdRuangan)
    '        DR = CMD.ExecuteReader()

    '        ' ===== ISI FORM =====
    '        If DR.Read() Then
    '            With FrmInputRuangKelas
    '                .LBKodeRuangan.Text = DR("Kd_Ruangan").ToString()
    '                .TXTNamaKelas.Text = DR("Nm_Ruangan").ToString()
    '                .TXTKapasitas.Text = DR("Jml_Kapasitas").ToString()
    '            End With
    '        Else
    '            MsgBox("Data ruang kelas tidak ditemukan!", vbExclamation)
    '        End If

    '        DR.Close()

    '    Catch ex As Exception
    '        MessageBox.Show(
    '        "Terjadi kesalahan saat menampilkan data ruang kelas : " & ex.Message,
    '        "Error",
    '        MessageBoxButtons.OK,
    '        MessageBoxIcon.Error
    '    )
    '    End Try
    'End Sub


    '' =========================
    '' KELUAR
    '' =========================
    'Private Sub BTNKeluarKelas_Click(sender As Object, e As EventArgs) Handles BTNKeluarKelas.Click
    '    If MsgBox("Yakin ingin keluar dari form ruang kelas?",
    '              vbYesNo + vbQuestion, "Informasi") = vbYes Then
    '        Me.Close()
    '    End If
    'End Sub


    Private repo As New RuangRepository()

    ' Poin GUI: Mengatur Header DataGrid
    Sub AktifkanDataGridKelas()
        With DataGridKelas
            .EnableHeadersVisualStyles = False
            .ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 9, FontStyle.Bold)
            .DefaultCellStyle.Font = New Font("Arial", 9)
            .ColumnHeadersHeight = 35

            ' Jika DataSource sudah terisi List(Of RuangKelas)
            If .Columns.Count >= 3 Then
                .Columns(0).HeaderText = "KODE RUANGAN"
                .Columns(0).Width = 150
                .Columns(1).HeaderText = "NAMA RUANGAN"
                .Columns(1).Width = 300
                .Columns(2).HeaderText = "KAPASITAS"
                .Columns(2).Width = 120
            End If
        End With
    End Sub

    Sub TampilDataRuang()
        ' Poin 5: Menggunakan List(Of T) sebagai DataSource
        Dim data As List(Of RuangKelas) = repo.AmbilSemua(TXTCariJurusan.Text.Trim())

        DataGridKelas.DataSource = Nothing
        DataGridKelas.DataSource = data
        AktifkanDataGridKelas()
    End Sub

    Private Sub FrmRuangKelas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilDataRuang()
    End Sub

    ' PENCARIAN
    Private Sub BTNCariKelas_Click(sender As Object, e As EventArgs) Handles BTNCariKelas.Click
        TampilDataRuang()
        If DataGridKelas.Rows.Count = 0 Then
            MsgBox("Data ruang kelas tidak ditemukan!", vbInformation)
        End If
    End Sub

    ' TAMBAH DATA
    Private Sub BTNTambahKelas_Click(sender As Object, e As EventArgs) Handles BTNTambahKelas.Click
        With FrmInputRuangKelas
            .Mode = "SIMPAN"
            .KdRuangan = ""
            ' Reset tampilan input
            .LBKodeRuangan.Text = "-"
            .TXTNamaKelas.Clear()
            .TXTKapasitas.Clear()
            .ShowDialog()
        End With
        TampilDataRuang()
    End Sub

    ' DOUBLE CLICK -> EDIT
    Private Sub DataGridKelas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridKelas.CellDoubleClick
        If e.RowIndex < 0 Then Exit Sub

        ' Cast baris menjadi Objek RuangKelas
        Dim terpilih As RuangKelas = CType(DataGridKelas.Rows(e.RowIndex).DataBoundItem, RuangKelas)

        With FrmInputRuangKelas
            .Mode = "UBAH"
            .KdRuangan = terpilih.KodeRuangan

            ' Mengirim data objek ke Form Input
            .LBKodeRuangan.Text = terpilih.KodeRuangan
            .TXTNamaKelas.Text = terpilih.NamaRuangan
            .TXTKapasitas.Text = terpilih.Kapasitas.ToString()

            ' Setting Visual Tombol
            .BTNSIMPANRUANGKELAS.Text = "UBAH"
            .BTNSIMPANRUANGKELAS.BackColor = Color.CornflowerBlue
            .BTNHAPUSRuangan.Enabled = True

            .ShowDialog()
        End With
        TampilDataRuang()
    End Sub

    Private Sub BTNKeluarKelas_Click(sender As Object, e As EventArgs) Handles BTNKeluarKelas.Click
        If MsgBox("Yakin ingin keluar?", vbYesNo + vbQuestion) = vbYes Then
            Me.Close()
        End If
    End Sub
End Class

' ============================================================
' 1. MODEL CLASS: RuangKelas (Encapsulation)
' ============================================================
Public Class RuangKelas
    Public Property KodeRuangan As String
    Public Property NamaRuangan As String
    Public Property Kapasitas As Integer
End Class

' ============================================================
' 2. REPOSITORY: RuangRepository (Poin 5: GUI Integration)
' ============================================================
Public Class RuangRepository
    Public Function AmbilSemua(Optional filter As String = "") As List(Of RuangKelas)
        Dim daftar As New List(Of RuangKelas)
        Try
            Call KoneksiDb()
            Dim sql As String = "SELECT Kd_Ruangan, Nm_Ruangan, Jml_Kapasitas FROM tbl_ruangkelas"

            ' Logika Pencarian Dinamis
            If filter <> "" Then
                If IsNumeric(filter) Then
                    sql &= " WHERE Kd_Ruangan = @f"
                Else
                    sql &= " WHERE Nm_Ruangan LIKE @f"
                End If
            End If
            sql &= " ORDER BY Kd_Ruangan ASC"

            Using cmd As New MySqlCommand(sql, DbKoneksi)
                If filter <> "" Then
                    If IsNumeric(filter) Then
                        cmd.Parameters.AddWithValue("@f", filter)
                    Else
                        cmd.Parameters.AddWithValue("@f", "%" & filter & "%")
                    End If
                End If

                Using dr As MySqlDataReader = cmd.ExecuteReader()
                    While dr.Read()
                        Dim r As New RuangKelas()
                        r.KodeRuangan = dr("Kd_Ruangan").ToString()
                        r.NamaRuangan = dr("Nm_Ruangan").ToString()
                        r.Kapasitas = Convert.ToInt32(dr("Jml_Kapasitas"))
                        daftar.Add(r)
                    End While
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Gagal ambil data: " & ex.Message)
        End Try
        Return daftar
    End Function
End Class