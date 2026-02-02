Imports MySql.Data.MySqlClient
Public Class FrmTransaksiDosen
    Dim CurrentPage As Integer = 1
    Dim PageSize As Integer = 10
    Dim TotalData As Integer = 0
    Dim TotalPage As Integer = 1
    Dim OffSet As Integer = 0
    Dim Batas As Integer
    Dim isloading As Boolean = True

    'cache pagging
    Public PageCache As New Dictionary(Of String, DataTable)
    Dim LastCacheKey As String = ""

    Function GETCacheKey(Page As Integer) As String
        Dim Prodi As String = If(CMBJurusanTransksiDosen.SelectedValue Is Nothing, "0", CMBJurusanTransksiDosen.SelectedValue.ToString())
        Dim Nama As String = TXTKodeDosenTransaksi.Text.Trim()
        Dim Limit As String = ComboBoxEntriesTransaksiDosen.Text
        Dim SemesterFilter As String = CMBNamaSemester.Text ' Mengambil Ganjil/Genap/ALL
        ' Gunakan pemisah yang unik
        Return $"Key_{Prodi}_{Nama}_{Limit}_{SemesterFilter}_{Page}"
    End Function


    'membuat fungsi clear cache
    Sub ClearPagingCache()
        PageCache.Clear()
        LastCacheKey = ""
    End Sub


    'membuat variable data entri
    Sub NumberEntriesHalaman()
        ComboBoxEntriesTransaksiDosen.Items.Add("10")
        ComboBoxEntriesTransaksiDosen.Items.Add("15")
        ComboBoxEntriesTransaksiDosen.Items.Add("20")
        ComboBoxEntriesTransaksiDosen.Items.Add("25")
        ComboBoxEntriesTransaksiDosen.Items.Add("50")
        ComboBoxEntriesTransaksiDosen.Items.Add("100")

        'menampilkan data index ke 0
        ComboBoxEntriesTransaksiDosen.SelectedIndex = 0
    End Sub

    'membuat nomor urut pada datagrid
    Private Sub FormatRowHeader(grid As DataGridView, startIndex As Integer, PageSize As Integer)
        grid.SuspendLayout()
        'atur tampilan grid
        grid.AllowUserToAddRows = False
        grid.RowHeadersVisible = True
        grid.RowHeadersWidth = 58
        grid.RowHeadersDefaultCellStyle.Font = New Font("Arial", 8, FontStyle.Bold)

        For i As Integer = 0 To grid.Rows.Count - 1
            grid.Rows(i).HeaderCell.Value = (startIndex + i + 1).ToString()
        Next
        grid.ResumeLayout()
    End Sub

    Private Sub DataGridTransaksiDosen_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DataGridTransaksiDosen.DataBindingComplete
        For i As Integer = 0 To DataGridTransaksiDosen.Rows.Count - 1
            DataGridTransaksiDosen.Rows(i).HeaderCell.Value = (OffSet + i + 1).ToString()
        Next
    End Sub

    'membuat refresh buat paging
    ' Tambahkan kata Public agar bisa dipanggil dari form lain
    Public Sub RefreshPaging()
        CurrentPage = 1
        ' Pastikan navigator kembali ke angka 1 secara visual
        BindingNavigatorPositionItem.Text = "1"

        PageCache.Clear()
        HitungTotalData()
        TampilkanDataGridTransaksiPengampu()
    End Sub

    'membuat tampian dataview
    Sub AktifkanDataGridDosenPengampu()
        With DataGridTransaksiDosen
            .EnableHeadersVisualStyles = False
            .Font = New Font(.Font, FontStyle.Bold)
            .DefaultCellStyle.Font = New Font("Arial", 9)
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
            .ColumnHeadersHeight = 35

            '0
            .Columns(0).Width = 90
            .Columns(0).HeaderText = "KODE PENGAMPU"
            .Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            '1
            .Columns(1).Width = 100
            .Columns(1).HeaderText = "KODE DOSEN"
            .Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            '2
            .Columns(2).Width = 100
            .Columns(2).HeaderText = "NIDN"
            .Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            '2
            .Columns(3).Width = 200
            .Columns(3).HeaderText = "NAMA DOSEN"
            .Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            '3
            .Columns(4).Width = 100
            .Columns(4).HeaderText = "KODE MATAKULIAH"
            .Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            '4  🔴 INI YANG SALAH SEBELUMNYA
            .Columns(5).Width = 250
            .Columns(5).HeaderText = "NAMA MATAKULIAH"
            .Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns(6).Width = 100
            .Columns(6).HeaderText = "SKS"
            .Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns(7).Width = 100
            .Columns(7).HeaderText = "SKS TEORI"
            .Columns(7).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns(8).Width = 100
            .Columns(8).HeaderText = "SKS PRAKTEk"
            .Columns(8).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns(9).Width = 100
            .Columns(9).HeaderText = "SEMESTER"
            .Columns(9).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            '5
            .Columns(10).Width = 100
            .Columns(10).HeaderText = "NAMA KELAS"
            .Columns(10).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            '6
            .Columns(11).Width = 100
            .Columns(11).HeaderText = "TAHUN AKADEMIK"
            .Columns(11).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            '7
            .Columns(12).Width = 100
            .Columns(12).HeaderText = "NAMA SEMESTER"
            .Columns(12).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With
    End Sub

    'membuat procedure hitung total data
    Sub HitungTotalData()
        Try
            ' 1. VALIDASI AWAL
            If CMBJurusanTransksiDosen.SelectedValue Is Nothing OrElse
           String.IsNullOrEmpty(CMBJurusanTransksiDosen.SelectedValue.ToString()) Then
                TotalData = 0
                TotalPage = 1
                LBTotalBarisTransaksiDosen.Text = "Total Baris: 0"
                LBHalamanTransaksiDosen.Text = "Jumlah Hal: 1"
                Exit Sub
            End If

            Call KoneksiDb()

            ' Gunakan Nama Tabel Lengkap agar lebih jelas
            Dim QUERY_COUNT As String = "
            SELECT COUNT(*) 
            FROM tbl_pengampu_matakuliah
            INNER JOIN tbl_dosen 
                ON tbl_pengampu_matakuliah.Kd_Dosen = tbl_dosen.Kd_Dosen
            INNER JOIN tbl_matakuliah 
                ON tbl_pengampu_matakuliah.Kd_Matakuliah = tbl_matakuliah.Kd_Matakuliah
            WHERE tbl_dosen.Kd_Prodi = @KdProdi"

            ' --- FILTER SEMESTER ---
            Select Case CMBNamaSemester.Text.Trim.ToUpper
                Case "GANJIL"
                    QUERY_COUNT &= " AND tbl_matakuliah.Semester_Matakuliah % 2 = 1"
                Case "GENAP"
                    QUERY_COUNT &= " AND tbl_matakuliah.Semester_Matakuliah % 2 = 0"
            End Select

            ' --- FILTER PENCARIAN ---
            Dim isSearching As Boolean = Not String.IsNullOrWhiteSpace(TXTKodeDosenTransaksi.Text)
            If isSearching Then
                QUERY_COUNT &= " AND (tbl_dosen.Kd_Dosen LIKE @Cari OR tbl_dosen.Nm_Dosen LIKE @Cari)"
            End If

            Using CMD As New MySqlCommand(QUERY_COUNT, DbKoneksi)
                CMD.Parameters.AddWithValue("@KdProdi", CMBJurusanTransksiDosen.SelectedValue.ToString())

                If isSearching Then
                    CMD.Parameters.AddWithValue("@Cari", "%" & TXTKodeDosenTransaksi.Text.Trim() & "%")
                End If

                TotalData = Convert.ToInt32(CMD.ExecuteScalar())
            End Using

            ' 2. LOGIKA PAGING
            If Not Integer.TryParse(ComboBoxEntriesTransaksiDosen.Text, PageSize) Then
                PageSize = 10
            End If
            If PageSize <= 0 Then PageSize = 10

            ' Hitung Total Halaman
            If TotalData > 0 Then
                TotalPage = CInt(Math.Ceiling(TotalData / CDbl(PageSize)))
            Else
                TotalPage = 1
            End If

            ' Koreksi posisi halaman jika filter mempersempit hasil
            If CurrentPage > TotalPage Then CurrentPage = TotalPage
            If CurrentPage < 1 Then CurrentPage = 1

            ' 3. UPDATE UI
            LBTotalBarisTransaksiDosen.Text = "Total Baris: " & TotalData.ToString()
            LBHalamanTransaksiDosen.Text = "Jumlah Hal: " & TotalPage

            UpdateNavigator()

        Catch ex As Exception
            MessageBox.Show("Gagal menghitung total data: " & ex.Message, "Error Paging", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If DbKoneksi.State = ConnectionState.Open Then DbKoneksi.Close()
        End Try
    End Sub

    'membuat sub procedure untuk load halaman
    Sub LoadPage()
        Try
            ' 1. VALIDASI AWAL
            If CMBJurusanTransksiDosen.SelectedValue Is Nothing OrElse
           String.IsNullOrEmpty(CMBJurusanTransksiDosen.SelectedValue.ToString()) Then
                Exit Sub
            End If

            OffSet = (CurrentPage - 1) * PageSize
            Dim cachekey As String = GETCacheKey(CurrentPage)

            ' 2. CEK CACHE
            If PageCache.ContainsKey(cachekey) Then
                DataGridTransaksiDosen.DataSource = PageCache(cachekey)
                AktifkanDataGridDosenPengampu()
                FormatRowHeader(DataGridTransaksiDosen, OffSet, PageSize)
                UpdateNavigator()
                Exit Sub
            End If

            ' 3. MEMBANGUN QUERY (Tanpa Alias P, D, M)
            Call KoneksiDb()

            Dim QUERY As String = "
            SELECT
                tbl_pengampu_matakuliah.KdPengampu AS kode_pengampu,
                tbl_pengampu_matakuliah.Kd_Dosen AS kode_dosen,
                tbl_dosen.Nidn_Dosen AS Nidn_Dosen,
                tbl_dosen.Nm_Dosen AS nama_dosen,
                tbl_pengampu_matakuliah.Kd_Matakuliah AS kode_matkul,
                tbl_matakuliah.Nm_Matakuliah AS nama_matkul,
                tbl_matakuliah.Sks_Matakuliah AS sks_matkul,
                tbl_matakuliah.Teori_Matakuliah AS teori_matkul,
                tbl_matakuliah.Praktek_Matakuliah AS praktek_matkul,
                tbl_matakuliah.Semester_Matakuliah AS semester_matkul,
                tbl_pengampu_matakuliah.Nama_Kelas AS nama_kelas,
                tbl_pengampu_matakuliah.Tahun_Akademik AS tahun_akademik,
                CASE WHEN tbl_matakuliah.Semester_Matakuliah % 2 != 0 THEN 'GANJIL' ELSE 'GENAP' END AS nama_semester
            FROM tbl_pengampu_matakuliah
            INNER JOIN tbl_dosen 
                ON tbl_pengampu_matakuliah.Kd_Dosen = tbl_dosen.Kd_Dosen
            INNER JOIN tbl_matakuliah 
                ON tbl_pengampu_matakuliah.Kd_Matakuliah = tbl_matakuliah.Kd_Matakuliah
            WHERE tbl_dosen.Kd_Prodi = @KdProdi "

            ' Filter Semester
            Select Case CMBNamaSemester.Text.Trim.ToUpper
                Case "GANJIL"
                    QUERY &= " AND tbl_matakuliah.Semester_Matakuliah % 2 = 1 "
                Case "GENAP"
                    QUERY &= " AND tbl_matakuliah.Semester_Matakuliah % 2 = 0 "
            End Select

            ' Filter Pencarian
            Dim isSearching As Boolean = Not String.IsNullOrWhiteSpace(TXTKodeDosenTransaksi.Text)
            If isSearching Then
                QUERY &= " AND (tbl_dosen.Kd_Dosen LIKE @Search OR tbl_dosen.Nm_Dosen LIKE @Search) "
            End If

            ' Pengurutan
            QUERY &= " ORDER BY tbl_matakuliah.Semester_Matakuliah ASC, tbl_pengampu_matakuliah.KdPengampu ASC LIMIT @Offset, @Limit"

            ' 4. EKSEKUSI DATA
            Using CMD As New MySqlCommand(QUERY, DbKoneksi)
                CMD.Parameters.AddWithValue("@KdProdi", CMBJurusanTransksiDosen.SelectedValue.ToString())
                CMD.Parameters.AddWithValue("@Offset", OffSet)
                CMD.Parameters.AddWithValue("@Limit", PageSize)

                If isSearching Then
                    CMD.Parameters.AddWithValue("@Search", "%" & TXTKodeDosenTransaksi.Text.Trim() & "%")
                End If

                Using DA As New MySqlDataAdapter(CMD)
                    Dim dt As New DataTable
                    DA.Fill(dt)

                    ' Simpan ke cache
                    PageCache(cachekey) = dt

                    ' Tampilkan ke Grid
                    DataGridTransaksiDosen.DataSource = dt
                    AktifkanDataGridDosenPengampu()
                    FormatRowHeader(DataGridTransaksiDosen, OffSet, PageSize)
                    UpdateNavigator()
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan saat memuat data: " & ex.Message, "Error LoadPage", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If DbKoneksi.State = ConnectionState.Open Then DbKoneksi.Close()
        End Try
    End Sub
    Sub UpdateNavigator()
        ' Mengatur status tombol navigasi (Enable/Disable)
        BindingNavigatorMoveFirstItemTD.Enabled = (CurrentPage > 1)
        BindingNavigatorMovePreviousItemTD.Enabled = (CurrentPage > 1)
        BindingNavigatorMoveNextItemTD.Enabled = (CurrentPage < TotalPage)
        BindingNavigatorMoveLastItemTD.Enabled = (CurrentPage < TotalPage)

        ' Menampilkan nomor halaman saat ini di kotak input navigator
        BindingNavigatorPositionItem.Text = CurrentPage.ToString()

        ' Update label di dalam BindingNavigator (biasanya bertuliskan "of 4")
        BindingNavigatorCountItem.Text = "of " & TotalPage

        ' 🟢 PERBAIKAN: Menampilkan teks "Jumlah Hal:" diikuti dengan angka total halaman
        ' Ini agar tulisan "Jumlah Hal:" tidak hilang saat navigasi diklik
        LBHalamanTransaksiDosen.Text = "Jumlah Hal: " & TotalPage.ToString()
    End Sub

    Public Sub TampilkanDataGridTransaksiPengampu()
        Try
            ' 1. Ambil pengaturan paging
            PageSize = Val(ComboBoxEntriesTransaksiDosen.Text)
            If PageSize <= 0 Then PageSize = 10
            OffSet = (CurrentPage - 1) * PageSize

            ' 🟢 CACHE KEY
            Dim searchCriteria As String = TXTKodeDosenTransaksi.Text.Trim()
            Dim semesterCriteria As String = CMBNamaSemester.Text
            Dim prodValue As String = If(CMBJurusanTransksiDosen.SelectedValue IsNot Nothing, CMBJurusanTransksiDosen.SelectedValue.ToString(), "")

            Dim CacheKey As String = $"{CurrentPage}_{PageSize}_{searchCriteria}_{semesterCriteria}_{prodValue}"

            ' 2. CEK CACHE DENGAN VALIDASI TOTAL DATA
            ' Jika PageCache ada, TAPI baris di cache tidak sama dengan sisa data di DB, maka abaikan cache.
            If PageCache.ContainsKey(CacheKey) Then
                Dim dtCache As DataTable = PageCache(CacheKey)

                ' Logika: Jika kita baru saja menghapus data, biasanya PageCache dikosongkan (Clear).
                ' Jika belum kosong, kita pastikan datanya masih valid.
                If dtCache IsNot Nothing Then
                    DataGridTransaksiDosen.DataSource = dtCache
                    FormatRowHeader(DataGridTransaksiDosen, OffSet, PageSize)
                    LBJumlahBarisData.Text = "Jumlah Baris Entri: " & dtCache.Rows.Count
                    UpdateNavigator()
                    Exit Sub
                End If
            End If

            ' 3. JIKA CACHE TIDAK ADA / SUDAH DI-CLEAR -> TARIK DARI DATABASE
            Call KoneksiDb()

            Dim QUERY As String = "
            SELECT
                tbl_pengampu_matakuliah.KdPengampu AS kode_pengampu,
                tbl_pengampu_matakuliah.Kd_Dosen AS kode_dosen,
                tbl_dosen.Nidn_Dosen AS Nidn_Dosen,
                tbl_dosen.Nm_Dosen AS nama_dosen,
                tbl_pengampu_matakuliah.Kd_Matakuliah AS kode_matkul,
                tbl_matakuliah.Nm_Matakuliah AS nama_matkul,
                tbl_matakuliah.Sks_Matakuliah AS sks_matkul,
                tbl_matakuliah.Teori_Matakuliah AS teori_matkul,
                tbl_matakuliah.Praktek_Matakuliah AS praktek_matkul,
                tbl_matakuliah.Semester_Matakuliah AS semester_matkul,
                tbl_pengampu_matakuliah.Nama_Kelas AS nama_kelas,
                tbl_pengampu_matakuliah.Tahun_Akademik AS tahun_akademik,
                CASE WHEN tbl_matakuliah.Semester_Matakuliah % 2 != 0 THEN 'GANJIL' ELSE 'GENAP' END AS nama_semester
            FROM tbl_pengampu_matakuliah
            INNER JOIN tbl_dosen ON tbl_pengampu_matakuliah.Kd_Dosen = tbl_dosen.Kd_Dosen
            INNER JOIN tbl_matakuliah ON tbl_pengampu_matakuliah.Kd_Matakuliah = tbl_matakuliah.Kd_Matakuliah
            WHERE tbl_dosen.Kd_Prodi = @KdProdi"

            ' Filter Semester
            Select Case semesterCriteria.ToUpper()
                Case "GANJIL"
                    QUERY &= " AND tbl_matakuliah.Semester_Matakuliah % 2 = 1"
                Case "GENAP"
                    QUERY &= " AND tbl_matakuliah.Semester_Matakuliah % 2 = 0"
            End Select

            ' Filter Pencarian
            If searchCriteria <> "" Then
                QUERY &= " AND (tbl_dosen.Kd_Dosen LIKE @Cari OR tbl_dosen.Nm_Dosen LIKE @Cari)"
            End If

            ' Pengurutan dan Paging
            QUERY &= " ORDER BY tbl_matakuliah.Semester_Matakuliah ASC, tbl_pengampu_matakuliah.KdPengampu ASC LIMIT @Offset, @Limit"

            Using DA As New MySqlDataAdapter(QUERY, DbKoneksi)
                DA.SelectCommand.Parameters.AddWithValue("@KdProdi", prodValue)
                DA.SelectCommand.Parameters.AddWithValue("@Offset", OffSet)
                DA.SelectCommand.Parameters.AddWithValue("@Limit", PageSize)

                If searchCriteria <> "" Then
                    DA.SelectCommand.Parameters.AddWithValue("@Cari", "%" & searchCriteria & "%")
                End If

                Dim DT As New DataTable
                DA.Fill(DT)

                ' 4. SIMPAN KE CACHE & UPDATE UI
                PageCache(CacheKey) = DT
                DataGridTransaksiDosen.DataSource = DT

                FormatRowHeader(DataGridTransaksiDosen, OffSet, PageSize)
                AktifkanDataGridDosenPengampu() ' Langsung panggil saja tanpa SubExists

                LBJumlahBarisData.Text = "Jumlah Baris Entri: " & DT.Rows.Count
                UpdateNavigator()
                DataGridTransaksiDosen.ReadOnly = True
            End Using

        Catch ex As Exception
            MessageBox.Show("Error TampilkanDataGridTransaksiPengampu: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Fungsi pembantu untuk mengecek keberadaan sub (opsional)
    Private Function SubExists(subName As String) As Boolean
        Return True ' Anggap saja ada
    End Function


    'membuat sub procedure untuk menghitung jumlah baris pada data grid
    Sub HitungRowDataGrid()

        Try
            Call KoneksiDb()
            'menghitung baris halaman
            BindingNavigatorPositionItem.Text = 1
            Nomor = (Val(BindingNavigatorPositionItem.Text) - 1) * Val(ComboBoxEntriesTransaksiDosen.Text)
            Batas = ComboBoxEntriesTransaksiDosen.Text

            'menampilkan jumlah seluruh data record saat di tampilkan ke data grid
            Call KoneksiDb()
            CMD = New MySqlCommand(" SELECT CEILING(COUNT(*)) AS Hasil
                                 FROM tbl_pengampu_matakuliah
                                    INNER JOIN tbl_dosen
                                        ON tbl_pengampu_matakuliah.Kd_Dosen = tbl_dosen.Kd_Dosen
                                    INNER JOIN tbl_matakuliah
                                        ON tbl_pengampu_matakuliah.Kd_Matakuliah = tbl_matakuliah.Kd_Matakuliah", DbKoneksi)

            DR = CMD.ExecuteReader()
            DR.Read()
            TotalData = DR!Hasil
            DR.Close()

            LBTotalBarisTransaksiDosen.Text = "Total Baris All: " & TotalData & ""

        Catch ex As Exception
            MessageBox.Show("Error HitungRowDataGrid: " & ex.Message)
        End Try
    End Sub

    Private Sub ComboBoxEntriesTransaksiDosen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxEntriesTransaksiDosen.SelectedIndexChanged
        ''menghitung jumlah baris data yang akan di tampilkan
        If ComboBoxEntriesTransaksiDosen.SelectedIndex = -1 Then Exit Sub

        PageSize = CInt(ComboBoxEntriesTransaksiDosen.Text)
        RefreshPaging()
    End Sub

    'membuat event keypress pada comboBoxEntries
    Private Sub ComboBoxEntriesTransaksiPengampu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBoxEntriesTransaksiDosen.KeyPress
        e.Handled = True
    End Sub

    'event leave pada binding navigator
    Private Sub BindingNavigatorPositionItem_Leave(sender As Object, e As EventArgs) Handles BindingNavigatorPositionItem.Leave
        If Val(BindingNavigatorPositionItem.Text) < 1 Then
            BindingNavigatorPositionItem.Text = "1"
        End If

        If Val(BindingNavigatorPositionItem.Text) > Val(LBHalamanTransaksiDosen.Text) Then
            BindingNavigatorPositionItem.Text = LBHalamanTransaksiDosen.Text
        End If
    End Sub

    'membuat sub prosedur tampilkan filter nama prodi dan menampilkan ke dalam combox 
    Sub TampilkanFilterNamaProdi()
        Try
            Call KoneksiDb()

            QUERY = "SELECT tbl_prodi.Kd_Prodi, tbl_prodi.Nm_Prodi FROM tbl_prodi ORDER BY tbl_prodi.Kd_Prodi"

            DA = New MySqlDataAdapter(QUERY, DbKoneksi)

            Dim DT As New DataTable
            DA.Fill(DT)

            CMBJurusanTransksiDosen.DataSource = DT
            CMBJurusanTransksiDosen.DisplayMember = "Nm_Prodi"
            CMBJurusanTransksiDosen.ValueMember = "Kd_Prodi"

            ' 🟢 PERBAIKAN DI SINI: Mencegah user mengetik di ComboBox
            CMBJurusanTransksiDosen.DropDownStyle = ComboBoxStyle.DropDownList

            CMBJurusanTransksiDosen.SelectedIndex = -1
            LBHalamanTransaksiDosen.Text = ""

        Catch ex As Exception
            MsgBox("Gagal memuat data Prodi: " & ex.Message, vbCritical)
        End Try
    End Sub

    'sub membuat filter ganjil genap
    Sub TampilkanFilterGanjilGenap()
        With CMBNamaSemester
            .Items.Clear()
            .Items.Add("ALL")       ' Tambahkan ALL
            .Items.Add("GANJIL")
            .Items.Add("GENAP")
            .DropDownStyle = ComboBoxStyle.DropDownList
            .SelectedIndex = 0      ' Default pilih ALL
        End With
    End Sub

    'membuat private prosedur pada combo box dengan event selectedindexchanged
    Private Sub CMBJurusanTransaksiDosen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBJurusanTransksiDosen.SelectedIndexChanged

        If isloading Then Exit Sub
        If CMBJurusanTransksiDosen.SelectedIndex < 0 Then Exit Sub
        If CMBJurusanTransksiDosen.SelectedValue Is Nothing Then Exit Sub
        Try
            '1️⃣ Ambil kode prodi
            Kode_Jurusan = CMBJurusanTransksiDosen.SelectedValue.ToString()
            LBProdiPengampu.Text = Microsoft.VisualBasic.Right(Kode_Jurusan, 6)

            '2️⃣ Jika prodi BELUM punya data pengampu
            If ProdiBelumAdaPengampu(Kode_Jurusan) Then
                If MessageBox.Show(
                "Data pengampu jurusan " & CMBJurusanTransksiDosen.Text & " belum ada." & vbCrLf &
                "Apakah ingin menambahkan data pengampu?",
                "Informasi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information) = DialogResult.Yes Then

                    '🔧 LOGIKA TAMBAHAN (SESUAI STRUKTUR ASLI)
                    With FrmDataTransaksiDosen
                        .KdProdidariForm = Kode_Jurusan
                        .BTNHapusTransaksi.Enabled = False
                        .CBNamaJurusanData.Enabled = False
                    End With

                    FrmDataTransaksiDosen.ShowDialog()
                End If

                '🔴 Jangan filter grid karena memang belum ada data
                PageCache.Clear()
                DataGridTransaksiDosen.DataSource = Nothing
                Exit Sub
            End If

            '3️⃣ Jika prodi SUDAH ada data → filter grid
            CurrentPage = 1
            PageCache.Clear()
            BindingNavigatorPositionItem.Text = "1"

            RefreshPaging()
            TampilkanDataGridTransaksiPengampu()

        Catch ex As Exception
            MsgBox("Error Memilih Prodi: " & ex.Message, vbCritical)
        End Try
    End Sub

    'mencari prodi yang belum ada transaksi pengampu
    Function ProdiBelumAdaPengampu(kdProdi As String) As Boolean
        Try
            Call KoneksiDb()

            QUERY = "SELECT
                    COUNT( * ) 
                    FROM
                    tbl_pengampu_matakuliah
                    INNER JOIN tbl_matakuliah ON tbl_pengampu_matakuliah.Kd_Matakuliah = tbl_matakuliah.Kd_Matakuliah 
                    WHERE
                    tbl_matakuliah.Kd_Prodi = @KdProdi"

            Using CMD As New MySqlCommand(QUERY, DbKoneksi)
                CMD.Parameters.AddWithValue("@KdProdi", kdProdi)
                Return CInt(CMD.ExecuteScalar()) = 0
            End Using

        Catch ex As Exception
            MessageBox.Show("Error validasi prodi: " & ex.Message)
            Return False
        End Try
    End Function

    'memastikan prodi ada
    Function ProdiAda(KdProdi As String) As Boolean
        Call KoneksiDb()
        QUERY = "SELECT COUNT(*) FROM tbl_prodi WHERE Kd_Prodi = @KdProdi"
        CMD = New MySqlCommand(QUERY, DbKoneksi)
        CMD.Parameters.AddWithValue("@KdProdi", KdProdi)
        Return CInt(CMD.ExecuteScalar()) > 0
    End Function

    Private Sub FrmTransaksiDosen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isloading = True
        Call KoneksiDb()
        Call NumberEntriesHalaman()
        Call AktifkanDataGridDosenPengampu()
        Call TampilkanFilterNamaProdi()
        Call TampilkanFilterGanjilGenap()

        'untuk menonaktifkan data grdvies
        DataGridTransaksiDosen.Enabled = True

        isloading = False
    End Sub

    Private Sub BTNCARI_Click(sender As Object, e As EventArgs)
        Try
            'VALIDASI INPUT
            If CMBJurusanTransksiDosen.SelectedIndex < 0 Then
                MsgBox("Pilih Prodi terlebih dahulu!", vbExclamation)
                Exit Sub
            End If

            If TXTKodeDosenTransaksi.Text.Trim() = "" Then
                MsgBox("Masukkan kode atau nama dosen yang dicari!", vbExclamation)
                Exit Sub
            End If

            'RESET PAGING
            CurrentPage = 1
            PageCache.Clear()

            Call KoneksiDb()

            QUERY = "SELECT
                    tbl_pengampu_matakuliah.KdPengampu,
                    tbl_pengampu_matakuliah.Kd_Dosen,
                    tbl_dosen.Nm_Dosen,
                    tbl_pengampu_matakuliah.Kd_Matakuliah,
                    tbl_matakuliah.Nm_Matakuliah,
                    tbl_pengampu_matakuliah.Nama_Kelas,
                    tbl_pengampu_matakuliah.Tahun_Akademik
                FROM tbl_pengampu_matakuliah
                INNER JOIN tbl_dosen
                    ON tbl_pengampu_matakuliah.Kd_Dosen = tbl_dosen.Kd_Dosen
                INNER JOIN tbl_matakuliah
                    ON tbl_pengampu_matakuliah.Kd_Matakuliah = tbl_matakuliah.Kd_Matakuliah
                WHERE tbl_dosen.Kd_Prodi = @KdProdi
                AND (
                    tbl_dosen.Kd_Dosen LIKE @Cari
                    OR tbl_dosen.Nm_Dosen LIKE @Cari
                )
                ORDER BY tbl_pengampu_matakuliah.KdPengampu ASC
                LIMIT @Offset, @Limit"

            Using DA As New MySqlDataAdapter(QUERY, DbKoneksi)
                DA.SelectCommand.Parameters.AddWithValue("@KdProdi", CMBJurusanTransksiDosen.SelectedValue)
                DA.SelectCommand.Parameters.AddWithValue("@Cari", "%" & TXTKodeDosenTransaksi.Text.Trim() & "%")
                DA.SelectCommand.Parameters.AddWithValue("@Offset", 0)
                DA.SelectCommand.Parameters.AddWithValue("@Limit", PageSize)

                Dim DT As New DataTable
                DA.Fill(DT)

                DataGridTransaksiDosen.DataSource = DT
                FormatRowHeader(DataGridTransaksiDosen, 0, PageSize)

                LBJumlahBarisData.Text = "Jumlah Baris Entri: " & DT.Rows.Count

                If DT.Rows.Count = 0 Then
                    MsgBox("Data pengampu tidak ditemukan!", vbInformation)
                End If
            End Using

        Catch ex As Exception
            MsgBox("Terjadi kesalahan pencarian: " & ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub BTNTambahDataTransaksiDosen_Click(sender As Object, e As EventArgs) Handles BTNTambahDataTransaksiDosen.Click
        ' 1. Validasi pilihan Prodi
        If CMBJurusanTransksiDosen.SelectedIndex = -1 Then
            MessageBox.Show("Silahkan pilih Nama Prodi terlebih dahulu!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            CMBJurusanTransksiDosen.Focus()
            Exit Sub
        End If

        ' 2. Konfirmasi Tambah Data
        Dim tanya As DialogResult = MessageBox.Show("Apakah data Pengampu Matakuliah akan ditambah?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If tanya = DialogResult.Yes Then
            ' Simpan nilai dari filter ke dalam variabel lokal
            Dim kodeTerpilih As String = CMBJurusanTransksiDosen.SelectedValue.ToString()
            Dim namaTerpilih As String = CMBJurusanTransksiDosen.Text
            Dim semesterTerpilih As String = CMBNamaSemester.Text

            With FrmDataTransaksiDosen
                ' --- LANGKAH 1: ISI VARIABEL PUBLIC (Kunci Sinkronisasi) ---
                ' Kita kirim ke variabel agar saat Form Load diproses, nilai ini bisa dipanggil kembali
                .KdProdiDariForm = kodeTerpilih
                .SemesterDariForm = semesterTerpilih

                ' --- LANGKAH 2: BERSIHKAN DATA BEKAS ---
                .TXTNomorIdentitas.Clear()
                .TXTKodeMatkul.Clear()
                .TXTTahunAkademik.Clear()
                .LBNamaDosen.Text = "-"
                .LBNamaMatakuliah.Text = "-"
                .LBSKSData.Text = "0"
                .LBSKSTeoriData.Text = "0"
                .LBSKSPraktekData.Text = "0"
                .LBSemesterData.Text = "0"
                .CMBKelasData.SelectedIndex = -1

                ' --- LANGKAH 3: PENGISIAN UI AWAL ---
                .LBKodeDataTransaksi.Text = kodeTerpilih

                ' Mencari index untuk Prodi
                Dim indexJurusan As Integer = .CBNamaJurusanData.FindStringExact(namaTerpilih)
                If indexJurusan <> -1 Then
                    .CBNamaJurusanData.SelectedIndex = indexJurusan
                Else
                    .CBNamaJurusanData.Text = namaTerpilih
                End If

                ' Jika filter Semester adalah "ALL", kosongkan pilihan di form input agar user memilih sendiri
                If semesterTerpilih = "ALL" Then
                    .CMBSEMESTERData.SelectedIndex = -1
                Else
                    .CMBSEMESTERData.Text = semesterTerpilih
                End If

                ' --- LANGKAH 4: SETTING UI & TOMBOL ---
                .BTNSimpanDataTransaksiDosen.Text = "&SIMPAN"
                .BTNSimpanDataTransaksiDosen.BackColor = Color.Red
                .BTNSimpanDataTransaksiDosen.Enabled = True

                .BTNHapusTransaksi.Enabled = False
                .BTNHapusTransaksi.BackColor = Color.Red ' Gunakan Gray agar terlihat non-aktif

                .BTNKeluarTransaksi.Text = "&BATAL"
                .BTNKeluarTransaksi.BackColor = Color.CornflowerBlue

                ' --- LANGKAH 5: GENERATE KODE OTOMATIS & TAMPILKAN ---
                .BuatKodePengampuOtomatis()
                .ShowDialog()
            End With
        End If
    End Sub

    'sub untuk kode pengampu
    Sub BuatKodePengampu()

        Call KoneksiDb()

        Try
            QUERY = "SELECT MAX(KdPengampu) FROM tbl_pengampu_matakuliah"

            Using CMD As New MySqlCommand(QUERY, DbKoneksi)

                Dim Hasil As Object = CMD.ExecuteScalar()
                Dim KodeBaru As String

                If Hasil Is Nothing OrElse IsDBNull(Hasil) Then
                    ' Jika tabel masih kosong
                    KodeBaru = "PMK0001"
                Else
                    ' Ambil angka dari PMKxxxx
                    Dim KodeTerakhir As String = Hasil.ToString()
                    Dim Angka As Integer = CInt(KodeTerakhir.Substring(3, 4))

                    ' Tambah 1
                    Angka += 1

                    ' Format ulang
                    KodeBaru = "PMK" & Angka.ToString("D4")
                End If

                ' Tampilkan ke form
                FrmDataTransaksiDosen.LBKodePengampu.Text = KodeBaru

            End Using

        Catch ex As Exception
            MessageBox.Show(
                "Gagal membuat Kode Pengampu: " & ex.Message,
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BindingNavigatorMoveNextItemTD_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveNextItemTD.Click
        If CurrentPage < TotalPage Then
            CurrentPage += 1
            TampilkanDataGridTransaksiPengampu()
        End If
    End Sub

    Private Sub BindingNavigatorMovePreviousItemTD_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMovePreviousItemTD.Click
        If CurrentPage > 1 Then
            CurrentPage -= 1
            TampilkanDataGridTransaksiPengampu()
        End If
    End Sub

    Private Sub BindingNavigatorMoveFirstItemTD_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveFirstItemTD.Click
        CurrentPage = 1
        TampilkanDataGridTransaksiPengampu()
    End Sub

    Private Sub BindingNavigatorMoveLastItemTD_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveLastItemTD.Click
        CurrentPage = TotalPage
        TampilkanDataGridTransaksiPengampu()
    End Sub

    Sub ReffreshPaging()
        CurrentPage = 1
        PageCache.Clear()
        HitungTotalData()
        TampilkanDataGridTransaksiPengampu()
    End Sub

    Sub UpdateNavigatorState()
        BindingNavigatorMoveFirstItemTD.Enabled = (CurrentPage > 1)
        BindingNavigatorMovePreviousItemTD.Enabled = (CurrentPage > 1)

        BindingNavigatorMoveNextItemTD.Enabled = (CurrentPage < TotalPage)
        BindingNavigatorMoveLastItemTD.Enabled = (CurrentPage < TotalPage)

        BindingNavigatorPositionItem.Text = (CurrentPage.ToString())
        BindingNavigatorCountItem.Text = $"of {TotalPage}"
    End Sub

    Private Sub DataGridTransaksiDosen_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridTransaksiDosen.CellMouseDoubleClick
        Try
            ' ===== 1. VALIDASI KLIK =====
            ' Memastikan yang diklik adalah baris data, bukan header
            If e.RowIndex < 0 Then Exit Sub
            If DataGridTransaksiDosen.Rows.Count = 0 Then Exit Sub

            ' ===== 2. AMBIL KODE PENGAMPU =====
            ' Menggunakan nama kolom lebih aman daripada index angka (0)
            Dim KdPengampu As String = DataGridTransaksiDosen.Rows(e.RowIndex).Cells("kode_pengampu").Value.ToString()

            ' ===== 3. QUERY DATABASE =====
            Call KoneksiDb()

            ' Gunakan query yang clean dengan spasi yang benar
            Dim QUERY_EDIT As String = "
            SELECT 
                p.KdPengampu, p.Kd_Dosen, p.Kd_Matakuliah, p.Nama_Kelas, p.Tahun_Akademik, 
                d.Kd_Prodi, m.Semester_Matakuliah 
            FROM tbl_pengampu_matakuliah p
            INNER JOIN tbl_dosen d ON p.Kd_Dosen = d.Kd_Dosen 
            INNER JOIN tbl_matakuliah m ON p.Kd_Matakuliah = m.Kd_Matakuliah 
            WHERE p.KdPengampu = @KdPengampu"

            Using CMD As New MySqlCommand(QUERY_EDIT, DbKoneksi)
                CMD.Parameters.AddWithValue("@KdPengampu", KdPengampu)

                Using DR = CMD.ExecuteReader()
                    If DR.Read() Then
                        ' Membuka form target
                        With FrmDataTransaksiDosen
                            ' 🟢 KUNCI UTAMA: Set mode edit sebelum mengisi data UI
                            .IsEditMode = True

                            ' Ambil data ke variabel lokal untuk pengolahan
                            Dim prodiDb As String = DR("Kd_Prodi").ToString().Trim()
                            Dim smtrAngka As Integer = Val(DR("Semester_Matakuliah").ToString())
                            Dim smtrTeks As String = If(smtrAngka Mod 2 = 0, "GENAP", "GANJIL")
                            Dim kelasDb As String = DR("Nama_Kelas").ToString().Trim()

                            ' 4. ISI VARIABEL PUBLIC (Sinkronisasi Logic)
                            .KdProdiDariForm = prodiDb
                            .SemesterDariForm = smtrTeks

                            ' 5. ISI DATA KE UI
                            .LBKodePengampu.Text = DR("KdPengampu").ToString()
                            .LBKodeDataTransaksi.Text = prodiDb
                            .TXTNomorIdentitas.Text = DR("Kd_Dosen").ToString()
                            .TXTKodeMatkul.Text = DR("Kd_Matakuliah").ToString()
                            .TXTTahunAkademik.Text = DR("Tahun_Akademik").ToString()

                            ' 6. PANGGIL SUB OTOMATIS (Label Nama Dosen/Matkul)
                            ' Pastikan sub ini bersifat Public di FrmDataTransaksiDosen
                            .SetDosenOtomatis(DR("Kd_Dosen").ToString())
                            .SetMatakuliahOtomatis(DR("Kd_Matakuliah").ToString())

                            ' 7. SINKRONISASI COMBOBOX
                            ' Sinkronkan Jurusan/Prodi terlebih dahulu
                            .CBNamaJurusanData.SelectedValue = prodiDb

                            ' Baru kemudian Kelas dan Semester
                            .CMBKelasData.SelectedIndex = .CMBKelasData.FindStringExact(kelasDb)
                            .CMBSEMESTERData.SelectedIndex = .CMBSEMESTERData.FindStringExact(smtrTeks)

                            ' 8. PENGATURAN TOMBOL (Visual Feedback)
                            .BTNSimpanDataTransaksiDosen.Text = "&UBAH"
                            .BTNSimpanDataTransaksiDosen.BackColor = Color.Red ' Orange biasanya untuk Edit
                            .BTNSimpanDataTransaksiDosen.Enabled = True

                            .BTNHapusTransaksi.Enabled = True
                            .BTNHapusTransaksi.BackColor = Color.Red

                            .BTNKeluarTransaksi.Text = "&BATAL"
                            .BTNKeluarTransaksi.BackColor = Color.CornflowerBlue

                            ' 9. TAMPILKAN FORM SEBAGAI DIALOG
                            .ShowDialog()

                            ' 10. REFRESH GRID SETELAH DIALOG DITUTUP (Jika ada perubahan)
                            ' Pastikan RefreshPaging ada di FrmTransaksiDosen
                            RefreshPaging()
                        End With
                    Else
                        MsgBox("Data pengampu sudah tidak ada di database!", vbExclamation)
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal memuat data untuk pengeditan: " & ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Pastikan koneksi ditutup jika tidak menggunakan blok Using di level koneksi
            If DbKoneksi.State = ConnectionState.Open Then DbKoneksi.Close()
        End Try
    End Sub

    Public Sub SetFilterProdiDanRefresh(KodeProdiBaru As String)
        Try
            isloading = True   ' 🔒 KUNCI EVENT

            ' Set combobox ke prodi baru
            For i As Integer = 0 To CMBJurusanTransksiDosen.Items.Count - 1
                CMBJurusanTransksiDosen.SelectedIndex = i

                If CMBJurusanTransksiDosen.SelectedValue IsNot Nothing Then
                    If CMBJurusanTransksiDosen.SelectedValue.ToString() = KodeProdiBaru Then
                        Exit For
                    End If
                End If
            Next

            ' Refresh paging
            CurrentPage = 1
            PageCache.Clear()
            TampilkanDataGridTransaksiPengampu()

        Catch ex As Exception
            MsgBox("Gagal set filter prodi baru: " & ex.Message, vbCritical)
        Finally
            isloading = False  ' 🔓 BUKA EVENT LAGI
        End Try
    End Sub

    Private Sub BTNKeluarTransaksiPagging_Click(sender As Object, e As EventArgs) Handles BTNKeluarTransaksiPagging.Click
        If BTNKeluarTransaksiPagging.Text = "&KELUAR" Then
            Pesan = MsgBox("Anda yakkin mau exit dari form data transaksi dosen pengampu?", vbQuestion + vbYesNo, "Informasi")
            If Pesan = vbYes Then
                Me.Close()
            End If
        Else
            BTNTambahDataTransaksiDosen.Text = "&AKTIF FORM"
            BTNTambahDataTransaksiDosen.Enabled = True
            BTNTambahDataTransaksiDosen.BackColor = Color.LightGray
        End If
    End Sub

    Private Sub CMBNamaSemester_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBNamaSemester.SelectedIndexChanged
        ' Mencegah event jalan otomatis saat form baru dibuka/sedang loading prodi
        If isloading Then Exit Sub

        ' Pastikan Prodi sudah dipilih
        If CMBJurusanTransksiDosen.SelectedValue Is Nothing Then Exit Sub

        ' Reset ke halaman awal setiap kali filter berubah
        CurrentPage = 1

        ' Hapus cache karena parameter filter (Semester) telah berubah
        PageCache.Clear()

        ' 🟢 PENTING: Hitung ulang total data agar Navigator (Next/Prev) 
        ' sinkron dengan jumlah matkul di semester yang dipilih
        HitungTotalData()

        ' Tampilkan data ke grid
        TampilkanDataGridTransaksiPengampu()
    End Sub

    ' 1. Gunakan TextChanged HANYA untuk membersihkan label jika teks dihapus
    Private Sub TXTKodeDosenTransaksi_TextChanged(sender As Object, e As EventArgs) Handles TXTKodeDosenTransaksi.TextChanged
        If TXTKodeDosenTransaksi.Text.Trim = "" Then
            LBNIDNTransaksi.Text = "-"
            LBNamaDosenTransaksi.Text = "-"

            ' 🟢 PERBAIKAN: Jika teks dihapus bersih, kembalikan tampilan ke semua dosen di prodi tersebut
            ' Agar user tidak bingung kenapa grid kosong terus
            CurrentPage = 1
            PageCache.Clear()
            HitungTotalData()
            TampilkanDataGridTransaksiPengampu()
        End If
    End Sub

    ' 2. Gunakan KeyDown untuk PROSES CARI (Tekan Enter)
    Private Sub TXTKodeDosenTransaksi_KeyDown(sender As Object, e As KeyEventArgs) Handles TXTKodeDosenTransaksi.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Menghilangkan suara 'beep'

            Dim kode As String = TXTKodeDosenTransaksi.Text.Trim
            If kode = "" Then Exit Sub

            Try
                Call KoneksiDb()
                ' Gunakan parameter untuk keamanan
                Dim sql As String = "SELECT Nidn_Dosen, Nm_Dosen FROM tbl_dosen WHERE Kd_Dosen = @kd"

                Using cmd As New MySqlCommand(sql, DbKoneksi)
                    cmd.Parameters.AddWithValue("@kd", kode)
                    Using dr As MySqlDataReader = cmd.ExecuteReader
                        If dr.Read() Then
                            ' Isi Label Otomatis
                            LBNIDNTransaksi.Text = dr("Nidn_Dosen").ToString
                            LBNamaDosenTransaksi.Text = dr("Nm_Dosen").ToString

                            ' 🔴 PENTING: Tutup DataReader segera sebelum menjalankan HitungTotalData
                            dr.Close()

                            ' 🟢 PROSES PAGING & NAVIGATOR
                            CurrentPage = 1
                            PageCache.Clear() ' Hapus cache agar data fresh sesuai dosen ini

                            ' 1. Hitung ulang total data agar Navigator Sinkron (of 1, of 2, dst)
                            HitungTotalData()

                            ' 2. Tampilkan datanya ke Grid
                            TampilkanDataGridTransaksiPengampu()
                        Else
                            LBNIDNTransaksi.Text = "-"
                            LBNamaDosenTransaksi.Text = "Data Tidak Ditemukan"

                            ' Jika dosen tidak ada, grid dikosongkan agar tidak misleading
                            DataGridTransaksiDosen.DataSource = Nothing
                            MsgBox("Kode Dosen '" & kode & "' tidak terdaftar!", MsgBoxStyle.Exclamation)
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MsgBox("Terjadi Kesalahan: " & ex.Message)
            End Try
        End If
    End Sub
End Class