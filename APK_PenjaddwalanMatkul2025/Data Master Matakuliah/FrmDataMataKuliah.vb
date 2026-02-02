Imports MySql.Data.MySqlClient
Public Class FrmDataMataKuliah
    Dim CurrentPage As Integer = 1
    Dim PageSize As Integer = 10
    Dim TotalData As Integer = 0
    Dim TotalPage As Integer = 1
    Dim OffSet As Integer = 0
    Dim Batas As Integer
    Dim isloading As Boolean = True

    'cache pagging
    Dim PageCache As New Dictionary(Of String, DataTable)
    Dim LastCacheKey As String = ""

    Function GETCacheKey(Page As Integer) As String
        Dim Prodi As String = If(CBNamaJurusanMatkul.SelectedValue Is Nothing, "", CBNamaJurusanMatkul.SelectedValue.ToString())
        Dim Nama As String = TxtCariNamaMatkul.Text.Trim()
        Dim Limit As String = ComboBoxEntries.Text
        ' TAMBAHKAN FILTER SEMESTER KE KEY CACHE
        Dim Sem As String = If(CBSemesterMatkul.SelectedIndex >= 0, CBSemesterMatkul.Text, "ALL")
        Return Prodi & "|" & Nama & "|" & Sem & "|" & Limit & "|" & Page
    End Function

    'membuat fungsi clear cache
    Sub ClearPagingCache()
        PageCache.Clear()
        LastCacheKey = ""
    End Sub

    'membuat variable data entri
    Sub NumberEntriesHalaman()
        ComboBoxEntries.Items.Clear()
        ComboBoxEntries.Items.Add("10")
        ComboBoxEntries.Items.Add("15")
        ComboBoxEntries.Items.Add("20")
        ComboBoxEntries.Items.Add("25")
        ComboBoxEntries.Items.Add("50")
        ComboBoxEntries.Items.Add("100")

        'menampilkan data index ke 0
        ComboBoxEntries.SelectedIndex = 0
    End Sub

    '========================================
    ' Fungsi: Membuat nomor urut pada RowHeader DataGridView
    ' Digunakan untuk menampilkan nomor baris sesuai paging
    '========================================
    Private Sub FormatRowHeader(grid As DataGridView, startIndex As Integer, PageSize As Integer)
        grid.SuspendLayout()

        'atur tampilan dasar DataGridView
        grid.AllowUserToAddRows = False
        grid.RowHeadersVisible = True
        grid.RowHeadersWidth = 58
        grid.RowHeadersDefaultCellStyle.Font = New Font("Arial", 8, FontStyle.Bold)

        'mengisi nomor urut baris berdasarkan halaman aktif
        For i As Integer = 0 To grid.Rows.Count - 1
            grid.Rows(i).HeaderCell.Value = (startIndex + i + 1).ToString()
        Next

        grid.ResumeLayout()
    End Sub


    '====================================================
    ' Event: Setelah DataGridView Matakuliah selesai binding
    ' Fungsi: Menampilkan nomor urut sesuai paging (Offset)
    '====================================================
    Private Sub DataGridMatakuliah_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DataGridMatkul.DataBindingComplete

        For i As Integer = 0 To DataGridMatkul.Rows.Count - 1
            DataGridMatkul.Rows(i).HeaderCell.Value = (OffSet + i + 1).ToString()
        Next

    End Sub


    '====================================================
    ' Method: RefreshPaging
    ' Fungsi:
    ' - Mengulang paging ke halaman pertama
    ' - Membersihkan cache paging
    ' - Menghitung ulang total data
    ' - Memuat ulang data ke DataGridView
    '====================================================
    Sub ReffreshPaging()
        CurrentPage = 1
        PageCache.Clear()
        HitungTotalData()
        LoadPage()
    End Sub

    'membuat tampian dataview
    'membuat tampian dataview
    Sub AktifkanDataGridMatkul()
        With DataGridMatkul
            .EnableHeadersVisualStyles = False
            .AutoGenerateColumns = False ' Mencegah data melenceng ke kolom baru

            ' Mengatur properties pada data grid header
            .Font = New Font(DataGridMatkul.Font, FontStyle.Bold)
            .DefaultCellStyle.Font = New Font("Arial", 9)
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
            .ColumnHeadersHeight = 35

            ' Pastikan kolom tersedia (0-6)
            If .ColumnCount < 7 Then .ColumnCount = 7

            ' Memberikan nama header KODE
            .Columns(0).Width = 100
            .Columns(0).HeaderText = "KODE"
            .Columns(0).DataPropertyName = "Kd_Matakuliah" ' Mapping database
            .Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            ' Memberikan nama header NAMA MATAKULIAH
            .Columns(1).Width = 350
            .Columns(1).HeaderText = "NAMA MATAKULIAH"
            .Columns(1).DataPropertyName = "Nm_Matakuliah"
            .Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            ' Memberikan nama header SKS
            .Columns(2).Width = 80
            .Columns(2).HeaderText = "SKS"
            .Columns(2).DataPropertyName = "Sks_Matakuliah"
            .Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            ' Memberikan nama header SKS TEORI
            .Columns(3).Width = 100
            .Columns(3).HeaderText = "SKS TEORI"
            .Columns(3).DataPropertyName = "Teori_Matakuliah"
            .Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            ' Memberikan nama header SKS PRAKTIKUM
            .Columns(4).Width = 120
            .Columns(4).HeaderText = "SKS PRAKTIKUM"
            .Columns(4).DataPropertyName = "Praktek_Matakuliah"
            .Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            ' Memberikan nama header SEMESTER
            .Columns(5).Width = 100
            .Columns(5).HeaderText = "SEMESTER"
            .Columns(5).DataPropertyName = "Semester_Matakuliah"
            .Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            ' Memberikan nama header NAMA SEMESTER
            .Columns(6).Width = 150
            .Columns(6).HeaderText = "NAMA SEMESTER"
            .Columns(6).DataPropertyName = "Nama_Semester"
            .Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With
    End Sub

    '=========================================================
    ' Procedure : HitungTotalData
    ' Fungsi    : Menghitung jumlah total data mata kuliah
    '             berdasarkan Kode Prodi dan filter pencarian
    '             nama mata kuliah (jika diisi).
    ' Tujuan    : Digunakan untuk menentukan total halaman
    '             pada sistem paging DataGridView Matakuliah.
    '=========================================================
    Sub HitungTotalData()
        Try
            Call KoneksiDb()
            ' Query dasar
            QUERY = "SELECT COUNT(*) FROM tbl_matakuliah WHERE Kd_Prodi = @KdProdi"

            ' Filter Nama
            If TxtCariNamaMatkul.Text.Trim() <> "" Then
                QUERY &= " AND Nm_Matakuliah LIKE @NamaMatakuliah"
            End If

            ' Filter Semester (Ganjil/Genap/Angka)
            If CBSemesterMatkul.SelectedIndex >= 0 Then
                QUERY &= " AND Semester_Matakuliah = @Semester"
            End If

            Using CMD As New MySqlCommand(QUERY, DbKoneksi)
                CMD.Parameters.AddWithValue("@KdProdi", CBNamaJurusanMatkul.SelectedValue)
                If TxtCariNamaMatkul.Text.Trim() <> "" Then
                    CMD.Parameters.AddWithValue("@NamaMatakuliah", "%" & TxtCariNamaMatkul.Text.Trim() & "%")
                End If
                If CBSemesterMatkul.SelectedIndex >= 0 Then
                    CMD.Parameters.AddWithValue("@Semester", CBSemesterMatkul.Text)
                End If

                TotalData = CInt(CMD.ExecuteScalar())
            End Using

            ' Perhitungan Halaman
            PageSize = Val(ComboBoxEntries.Text)
            If PageSize <= 0 Then PageSize = 10
            TotalPage = Math.Ceiling(TotalData / PageSize)
            If TotalPage < 1 Then TotalPage = 1

            ' Update Tampilan Navigator
            LbTotalBarisMatkul.Text = "Total Baris: " & TotalData
            LBBagiHalamanMatkul.Text = "Jumlah Hal: " & TotalPage
            BindingNavigatorCountItem.Text = "of " & TotalPage

        Catch ex As Exception
            MessageBox.Show("Error Hitung Total: " & ex.Message)
        End Try
    End Sub

    '=========================================================
    ' Procedure : LoadPage
    ' Fungsi    : Menampilkan data mata kuliah ke DataGridView
    '             berdasarkan halaman aktif (paging),
    '             jumlah data per halaman, dan filter pencarian.
    ' Tujuan    : Mendukung navigasi halaman (Next, Prev, dll)
    '             serta meningkatkan performa dengan cache data.
    '=========================================================
    Sub LoadPage()
        OffSet = (CurrentPage - 1) * PageSize
        Dim cachekey As String = GETCacheKey(CurrentPage)

        If PageCache.ContainsKey(cachekey) Then
            DataGridMatkul.DataSource = PageCache(cachekey)
            AktifkanDataGridMatkul() ' Pastikan header diformat ulang
            Exit Sub
        End If

        Call KoneksiDb()

        ' Gunakan Query yang LENGKAP dan KONSISTEN
        QUERY = "SELECT 
                Kd_Matakuliah, 
                Nm_Matakuliah, 
                Sks_Matakuliah, 
                Teori_Matakuliah, 
                Praktek_Matakuliah, 
                Semester_Matakuliah,
                CASE WHEN Semester_Matakuliah % 2 = 1 THEN 'GANJIL' ELSE 'GENAP' END AS Nama_Semester
             FROM tbl_matakuliah 
             WHERE Kd_Prodi = @KdProdi"

        If TxtCariNamaMatkul.Text.Trim() <> "" Then
            QUERY &= " AND Nm_Matakuliah LIKE @NamaMatakuliah"
        End If

        QUERY &= " ORDER BY Kd_Matakuliah ASC LIMIT @OffSet, @Limit"

        Using DA As New MySqlDataAdapter(QUERY, DbKoneksi)
            DA.SelectCommand.Parameters.AddWithValue("@KdProdi", CBNamaJurusanMatkul.SelectedValue)
            DA.SelectCommand.Parameters.AddWithValue("@OffSet", OffSet)
            DA.SelectCommand.Parameters.AddWithValue("@Limit", PageSize)

            If TxtCariNamaMatkul.Text.Trim() <> "" Then
                DA.SelectCommand.Parameters.AddWithValue("@NamaMatakuliah", "%" & TxtCariNamaMatkul.Text.Trim() & "%")
            End If

            Dim dt As New DataTable
            DA.Fill(dt)
            PageCache(cachekey) = dt
            DataGridMatkul.DataSource = dt

            ' WAJIB PANGGIL INI SETIAP KALI DATASOURCE BERUBAH
            AktifkanDataGridMatkul()
            UpdateNavigator()
        End Using
    End Sub

    '=========================================================
    ' Procedure : UpdateNavigator
    ' Fungsi    : Mengatur status tombol navigasi paging
    '             (First, Previous, Next, Last) pada
    '             BindingNavigator berdasarkan halaman aktif.
    ' Tujuan    : Mencegah perpindahan halaman yang tidak valid
    '             dan menampilkan posisi halaman saat ini.
    '=========================================================
    Sub UpdateNavigator()

        ' Mengaktifkan atau menonaktifkan tombol navigasi awal
        ' dan sebelumnya jika halaman lebih dari halaman pertama
        BindingNavigatorMoveFirstItemMatkul.Enabled = (CurrentPage > 1)
        BindingNavigatorMovePreviousItemMatkul.Enabled = (CurrentPage > 1)

        ' Mengaktifkan atau menonaktifkan tombol navigasi
        ' berikutnya dan terakhir jika belum mencapai halaman terakhir
        BindingNavigatorMoveNextItemMatkul.Enabled = (CurrentPage < TotalPage)
        BindingNavigatorMoveLastItemMatkul.Enabled = (CurrentPage < TotalPage)

        ' Menampilkan nomor halaman aktif
        BindingNavigatorPositionItem.Text = CurrentPage.ToString()

        ' Menampilkan jumlah total halaman
        BindingNavigatorCountItem.Text = $"of {TotalPage}"
    End Sub

    '=========================================================
    ' Procedure : TampilkanDataGridMatakuliah
    ' Fungsi    : Menampilkan data mata kuliah ke dalam DataGridView
    '             dengan dukungan paging, pencarian nama,
    '             dan sistem cache untuk meningkatkan performa.
    ' Tujuan    : Menyediakan tampilan data mata kuliah yang efisien,
    '             terstruktur, dan mudah dinavigasi oleh user.
    '=========================================================
    Sub TampilkanDataGridMatakuliah()
        Try
            ' 1. GUARD: Jika prodi belum dipilih, tampilkan header kosong
            If CBNamaJurusanMatkul.SelectedIndex < 0 OrElse CBNamaJurusanMatkul.SelectedValue Is Nothing Then
                DataGridMatkul.DataSource = Nothing
                Call AktifkanDataGridMatkul()
                LBJumlahBarisMatkul.Text = "Jumlah Baris Entri: 0"
                Exit Sub
            End If

            ' 2. Pengaturan Paging
            PageSize = Val(ComboBoxEntries.Text)
            If PageSize <= 0 Then PageSize = 10
            OffSet = (CurrentPage - 1) * PageSize

            ' 3. Ambil Data
            Call KoneksiDb()

            QUERY = "SELECT Kd_Matakuliah, Nm_Matakuliah, Sks_Matakuliah, Teori_Matakuliah, " &
                "Praktek_Matakuliah, Semester_Matakuliah, " &
                "CASE WHEN Semester_Matakuliah % 2 = 1 THEN 'GANJIL' ELSE 'GENAP' END AS Nama_Semester " &
                "FROM tbl_matakuliah WHERE Kd_Prodi = @KdProdi"

            ' --- LOGIKA FILTER SEMESTER YANG DIPERBAIKI ---

            ' A. Jika user sudah memilih angka semester spesifik (misal: 3)
            If CBSemesterMatkul.SelectedIndex >= 0 AndAlso CBSemesterMatkul.Text <> "" Then
                QUERY &= " AND Semester_Matakuliah = @Semester"

                ' B. Jika user baru memilih kategori (GANJIL/GENAP) tapi belum pilih angka
            ElseIf CMBJenisGanjilGenap.Text = "GANJIL" Then
                QUERY &= " AND Semester_Matakuliah IN (1, 3, 5, 7)"
            ElseIf CMBJenisGanjilGenap.Text = "GENAP" Then
                QUERY &= " AND Semester_Matakuliah IN (2, 4, 6, 8)"
            End If

            ' Filter Pencarian Nama (Jika ada)
            If TxtCariNamaMatkul.Text.Trim() <> "" Then
                QUERY &= " AND Nm_Matakuliah LIKE @Nama"
            End If

            ' Pengurutan agar berurutan 1-8
            QUERY &= " ORDER BY Semester_Matakuliah ASC, Kd_Matakuliah ASC LIMIT @Offset, @Limit"

            Using DA As New MySqlDataAdapter(QUERY, DbKoneksi)
                DA.SelectCommand.Parameters.AddWithValue("@KdProdi", CBNamaJurusanMatkul.SelectedValue)
                DA.SelectCommand.Parameters.AddWithValue("@Offset", OffSet)
                DA.SelectCommand.Parameters.AddWithValue("@Limit", PageSize)

                If TxtCariNamaMatkul.Text.Trim() <> "" Then
                    DA.SelectCommand.Parameters.AddWithValue("@Nama", "%" & TxtCariNamaMatkul.Text.Trim() & "%")
                End If

                If CBSemesterMatkul.SelectedIndex >= 0 AndAlso CBSemesterMatkul.Text <> "" Then
                    DA.SelectCommand.Parameters.AddWithValue("@Semester", CBSemesterMatkul.Text)
                End If

                Dim DT As New DataTable
                DA.Fill(DT)

                ' Sinkronisasi tampilan grid agar tidak melenceng
                DataGridMatkul.DataSource = Nothing
                Call AktifkanDataGridMatkul()
                DataGridMatkul.DataSource = DT

                Call FormatRowHeader(DataGridMatkul, OffSet, PageSize)
                LBJumlahBarisMatkul.Text = "Jumlah Baris Entri: " & DT.Rows.Count
                Call UpdateNavigator()
            End Using

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
    '=========================================================
    ' Procedure : HitungRowDataGrid
    ' Fungsi    : Menghitung jumlah total baris data mata kuliah
    '             yang ada di database dan menampilkannya
    '             ke dalam label informasi.
    ' Tujuan    : Memberikan informasi jumlah seluruh data
    '             yang tersedia pada DataGridView Matakuliah.
    '=========================================================
    Sub HitungRowDataGrid()

        Try
            ' Membuka koneksi database
            Call KoneksiDb()

            ' Mengatur posisi awal halaman pada navigator
            BindingNavigatorPositionItem.Text = 1

            ' Menghitung nomor awal data berdasarkan halaman dan jumlah entri
            Nomor = (Val(BindingNavigatorPositionItem.Text) - 1) * Val(ComboBoxEntries.Text)
            Batas = ComboBoxEntries.Text

            ' Membuka koneksi database kembali
            Call KoneksiDb()

            ' Query untuk menghitung jumlah total data mata kuliah
            ' yang terhubung dengan tabel prodi
            CMD = New MySqlCommand("SELECT CEILING(COUNT(*)) AS Hasil
                                FROM tbl_matakuliah
                                INNER JOIN tbl_prodi
                                ON tbl_matakuliah.Kd_Prodi = tbl_prodi.Kd_Prodi", DbKoneksi)

            ' Menjalankan query dan membaca hasilnya
            DR = CMD.ExecuteReader()
            DR.Read()

            ' Menyimpan hasil jumlah total data
            TotalData = DR!Hasil
            DR.Close()

            ' Menampilkan jumlah total data ke label
            LbTotalBarisMatkul.Text = "Total Baris All: " & TotalData & ""

        Catch ex As Exception
            ' Menampilkan pesan error jika terjadi kesalahan
            MessageBox.Show("Error HitungRowDataGrid: " & ex.Message)
        End Try

    End Sub


    '=========================================================
    ' Event     : ComboBoxEntries_SelectedIndexChanged
    ' Fungsi    : Menangani perubahan jumlah entri data
    '             yang ditampilkan per halaman.
    ' Tujuan    : Memperbarui paging dan DataGridView
    '             sesuai jumlah entri yang dipilih user.
    '=========================================================
    Private Sub ComboBoxEntries_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxEntries.SelectedIndexChanged

        ' Keluar jika tidak ada item yang dipilih
        If ComboBoxEntries.SelectedIndex = -1 Then Exit Sub

        ' Mengatur jumlah data per halaman
        PageSize = CInt(ComboBoxEntries.Text)

        ' Memuat ulang paging dan data grid matakuliah
        RefreshPaging()
    End Sub


    '=========================================================
    ' Event     : ComboBoxEntries_KeyPress
    ' Fungsi    : Menonaktifkan input manual pada ComboBox.
    ' Tujuan    : Membatasi input agar hanya dapat memilih
    '             nilai yang tersedia di dalam daftar.
    '=========================================================
    Private Sub ComboBoxEntries_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBoxEntries.KeyPress

        ' Mencegah user mengetik secara manual
        e.Handled = True
    End Sub

    Private Sub BindingNavigatorPositionItem_Leave(sender As Object, e As EventArgs) Handles BindingNavigatorPositionItem.Leave

        ' Jika halaman kurang dari 1, set ke halaman pertama
        If Val(BindingNavigatorPositionItem.Text) < 1 Then
            BindingNavigatorPositionItem.Text = "1"
        End If

        ' Jika halaman melebihi total halaman, set ke halaman terakhir
        If Val(BindingNavigatorPositionItem.Text) > Val(LBBagiHalamanMatkul.Text) Then
            BindingNavigatorPositionItem.Text = LBBagiHalamanMatkul.Text
        End If
    End Sub

    '=========================================================
    ' Procedure : TampilkanFilterNamaProdi
    ' Fungsi    : Menampilkan daftar Program Studi (Prodi)
    '             ke dalam ComboBox sebagai filter data
    '             mata kuliah.
    ' Tujuan    : Memudahkan user memfilter data mata kuliah
    '             berdasarkan Prodi yang dipilih.
    '=========================================================
    Sub TampilkanFilterNamaProdi()

        Try
            ' Membuka koneksi database
            Call KoneksiDb()

            ' Query untuk mengambil data prodi
            QUERY = "SELECT tbl_prodi.Kd_Prodi, tbl_prodi.Nm_Prodi 
                 FROM tbl_prodi  
                 ORDER BY tbl_prodi.Kd_Prodi"

            ' Mengambil data menggunakan DataAdapter
            DA = New MySqlDataAdapter(QUERY, DbKoneksi)

            ' Menyimpan hasil query ke DataTable
            Dim DT As New DataTable
            DA.Fill(DT)

            ' Menampilkan data prodi ke ComboBox filter
            CBNamaJurusanMatkul.DataSource = DT
            CBNamaJurusanMatkul.DisplayMember = "Nm_Prodi"
            CBNamaJurusanMatkul.ValueMember = "Kd_Prodi"

            ' Mengosongkan pilihan awal ComboBox
            CBNamaJurusanMatkul.SelectedIndex = -1

            ' Mengosongkan label kode prodi
            LBPRODIMatkul.Text = ""

        Catch ex As Exception
            ' Menampilkan pesan error jika gagal memuat data prodi
            MsgBox("Gagal memuat data Prodi: " & ex.Message, vbCritical)
        End Try
    End Sub

    '=========================================================
    ' Event     : CBNamaProdi_SelectedIndexChanged
    ' Fungsi    : Menangani perubahan pilihan nama prodi
    '             pada ComboBox CBNamaProdi.
    ' Tujuan    :
    '   1. Mengambil kode prodi yang dipilih
    '   2. Mengecek apakah prodi tersebut sudah memiliki data mata kuliah
    '   3. Menyediakan alur penambahan data jika belum ada
    '   4. Menampilkan data mata kuliah pada DataGridView jika tersedia
    '=========================================================
    Private Sub CBNamaJurusanMatkul_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBNamaJurusanMatkul.SelectedIndexChanged
        If isloading Then Exit Sub
        If CBNamaJurusanMatkul.SelectedIndex < 0 OrElse CBNamaJurusanMatkul.SelectedValue Is Nothing Then Exit Sub

        Try
            Kode_Jurusan = CBNamaJurusanMatkul.SelectedValue.ToString()
            LBPRODIMatkul.Text = Kode_Jurusan

            ' Cek apakah prodi ini sudah punya data matakuliah
            If ProdiBelumAdaMatakuliah(Kode_Jurusan) Then
                ' Reset tampilan grid
                DataGridMatkul.DataSource = Nothing
                Call AktifkanDataGridMatkul() ' Tampilkan header saja

                ' Pesan Peringatan sesuai Gambar 13
                Dim isiPesan As String = "Data Matakuliah pada Jurusan : " & CBNamaJurusanMatkul.Text & " Belum Ada!!" & vbCrLf &
                                     "Silahkan Tambahkan Status Semester Terlebih Dahulu."

                MessageBox.Show(isiPesan, "PERINGATAN", MessageBoxButtons.OK, MessageBoxIcon.Stop)

                ' Fokuskan ke tombol Tambah Status (Asumsi nama button: BTNTambahStatus)
                BtnTambahMatkul.Focus()
                Exit Sub
            End If

            ' Jika data ada, muat seperti biasa
            Call TampilkanDataGridMatakuliah()

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical)
        End Try
    End Sub


    '=========================================================
    ' Function  : ProdiBelumAdaMatakuliah
    ' Parameter : KdProdi (String)
    ' Return    : Boolean
    ' Fungsi    : Mengecek apakah suatu program studi (prodi)
    '             belum memiliki data mata kuliah.
    ' Tujuan    : Digunakan untuk validasi sebelum menampilkan
    '             data pada DataGridView Matakuliah.
    '=========================================================
    Function ProdiBelumAdaMatakuliah(KdProdi As String) As Boolean
        Try
            ' Membuka koneksi database
            Call KoneksiDb()

            ' Query untuk menghitung jumlah mata kuliah per prodi
            QUERY = "SELECT COUNT(*) 
                 FROM tbl_matakuliah 
                 WHERE Kd_Prodi = @KdProdi"

            Using CMD As New MySqlCommand(QUERY, DbKoneksi)
                CMD.Parameters.AddWithValue("@KdProdi", KdProdi)

                ' Mengembalikan TRUE jika belum ada data mata kuliah
                Return CInt(CMD.ExecuteScalar()) = 0
            End Using

        Catch ex As Exception
            ' Menampilkan pesan error jika terjadi kesalahan
            MessageBox.Show("Error validasi prodi: " & ex.Message)
            Return False
        End Try
    End Function


    '=========================================================
    ' Function  : ProdiAda
    ' Parameter : KdProdi (String)
    ' Return    : Boolean
    ' Fungsi    : Mengecek apakah kode prodi tersedia
    '             di dalam tabel tbl_prodi.
    ' Tujuan    : Validasi data prodi sebelum digunakan
    '             pada proses filter atau transaksi.
    '=========================================================
    Function ProdiAda(KdProdi As String) As Boolean

        ' Membuka koneksi database
        Call KoneksiDb()

        ' Query untuk mengecek keberadaan prodi
        QUERY = "SELECT COUNT(*) 
             FROM tbl_prodi 
             WHERE Kd_Prodi = @KdProdi"

        CMD = New MySqlCommand(QUERY, DbKoneksi)
        CMD.Parameters.AddWithValue("@KdProdi", KdProdi)

        ' Mengembalikan TRUE jika prodi ditemukan
        Return CInt(CMD.ExecuteScalar()) > 0

    End Function

    '=========================================================
    ' Event     : FrmDataMataKuliah_Load
    ' Fungsi    : Menangani proses inisialisasi awal form
    '             FrmDataMataKuliah.
    ' Tujuan    :
    '   1. Membuka koneksi database
    '   2. Mengatur jumlah data per halaman
    '   3. Menampilkan daftar prodi ke ComboBox filter
    '   4. Mengaktifkan DataGridView dan navigasi
    '=========================================================
    Private Sub FrmDataMataKuliah_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' =========================
            ' 1. Tandai proses loading (Mencegah Trigger Event ComboBox)
            ' =========================
            isloading = True

            ' =========================
            ' 2. Persiapan Awal
            ' =========================
            Call KoneksiDb()
            Call NumberEntriesHalaman()

            ' =========================
            ' 3. Load filter PRODI
            ' =========================
            Call TampilkanFilterNamaProdi()
            ' Pastikan tidak ada prodi yang terpilih otomatis agar grid kosong
            CBNamaJurusanMatkul.SelectedIndex = -1

            ' =========================
            ' 4. Konfigurasi ComboBox Semester
            ' =========================
            CMBJenisGanjilGenap.Items.Clear()
            CMBJenisGanjilGenap.Items.Add("GANJIL")
            CMBJenisGanjilGenap.Items.Add("GENAP")
            CMBJenisGanjilGenap.SelectedIndex = -1

            CBSemesterMatkul.Items.Clear()
            CBSemesterMatkul.Enabled = False

            ' =========================
            ' 5. Setup Tampilan DataGrid Kosong (Hanya Header)
            ' =========================
            DataGridMatkul.DataSource = Nothing
            ' Kita buat kolom virtual agar AktifkanDataGridMatkul bisa bekerja
            ' memberikan format header (KODE, NAMA MATAKULIAH, dsb
            Call AktifkanDataGridMatkul()

            ' =========================
            ' 6. Pengaturan UI Lainnya
            ' =========================
            Me.AcceptButton = BTNCariMatkul
            DataGridMatkul.Enabled = True
            LBPRODIMatkul.Text = ""
            LBJumlahBarisMatkul.Text = "Jumlah Baris Entri: 0"
            LbTotalBarisMatkul.Text = "Total Baris All: 0"

            ' PENTING: Jangan memanggil TampilkanDataGridMatakuliah() di sini 
            ' jika ingin grid benar-benar kosong saat start.

        Catch ex As Exception
            MessageBox.Show("Error saat load FrmDataMataKuliah: " & ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' =========================
            ' 7. Selesai loading
            ' =========================
            isloading = False
        End Try
    End Sub


    '=========================================================
    ' Event     : BTNCARI_Click
    ' Fungsi    : Menangani proses pencarian data matakuliah
    '             berdasarkan nama matakuliah dan prodi.
    ' Tujuan    :
    '   1. Memvalidasi input pencarian
    '   2. Menjalankan query pencarian
    '   3. Menampilkan hasil ke DataGridView
    '=========================================================
    Private Sub BTNCariMatkul_Click(sender As Object, e As EventArgs) Handles BTNCariMatkul.Click
        Try
            ' 1. Validasi Input Prodi (Wajib pilih prodi dulu)
            If CBNamaJurusanMatkul.SelectedIndex < 0 OrElse CBNamaJurusanMatkul.SelectedValue Is Nothing Then
                MsgBox("Pilih Prodi terlebih dahulu!", vbExclamation)
                CBNamaJurusanMatkul.Focus()
                Exit Sub
            End If

            ' 2. Bersihkan Cache dan Reset Paging agar mencari dari awal
            Call ClearPagingCache()
            CurrentPage = 1

            ' 3. Jalankan Fungsi Utama
            ' Kita tidak perlu menulis QUERY baru di sini. 
            ' Cukup panggil TampilkanDataGridMatakuliah() karena di dalamnya 
            ' sudah ada logika filter TxtCariNamaMatkul.Text dan pemanggilan AktifkanDataGridMatkul().

            Call HitungTotalData() ' Update total baris berdasarkan kriteria cari
            Call TampilkanDataGridMatakuliah() ' Memuat data dan memformat header

            ' 4. Validasi jika data tidak ditemukan
            If DataGridMatkul.Rows.Count = 0 Then
                MsgBox("Data matakuliah tidak ditemukan!", vbInformation)
            End If

        Catch ex As Exception
            MsgBox("Terjadi kesalahan pencarian data: " & ex.Message, vbCritical)
        End Try
    End Sub

    '=========================================================
    ' Event     : BtnTambahData_Click
    ' Fungsi    : Menangani proses penambahan data matakuliah.
    ' Tujuan    :
    '   1. Memastikan prodi telah dipilih
    '   2. Membuat kode matakuliah otomatis
    '   3. Menyiapkan Form Matakuliah dalam mode tambah
    '=========================================================
    Private Sub BtnTambahMatkul_Click(sender As Object, e As EventArgs) Handles BtnTambahMatkul.Click
        Try
            Call KoneksiDb()

            ' 1. Validasi filter awal
            If CBNamaJurusanMatkul.SelectedIndex = -1 Then
                MessageBox.Show("Silahkan pilih Prodi terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If

            ' 2. Reset Kode Matkul manual
            Call BuatKodeMataKuliah("")

            With FrmInputMataKuliah
                ' ===== BAGIAN KRUSIAL: JANGAN GUNAKAN .Items.Clear() PADA PRODI =====

                ' A. Kirim nilai filter ke variabel Public agar dikenali Form Input
                .KdProdidariForm = "" ' Set kosong agar Form Input memanggil TampilNamaProdi() secara lengkap

                ' B. Tampilkan Form terlebih dahulu agar event Load (isi database) berjalan
                ' Gunakan .Show atau pastikan Load selesai sebelum mengatur nilai
                .Show()

                ' C. Pilih Prodi berdasarkan ID (SelectedValue) agar daftar prodi lain TIDAK HILANG
                .CMBProdiMatkul.SelectedValue = CBNamaJurusanMatkul.SelectedValue
                .LBKDPRODIMATKUL.Text = LBPRODIMatkul.Text

                ' D. Isi Semester (Ganjil/Genap)
                ' Untuk Semester & Angka, kita boleh pakai .Text karena isinya statis (bukan dari DB)
                .CMBSEMESTER.Text = CMBJenisGanjilGenap.Text

                ' E. Isi Angka Semester
                ' Panggil sub filter semester di form input agar item (1,3,5 / 2,4,6) muncul dulu
                ' Pastikan CMBSemesterMatkul.Items sudah terisi sebelum mengisi .Text
                .CMBSemesterMatkul.Items.Clear()
                .CMBSemesterMatkul.Items.Add(CBSemesterMatkul.Text)
                .CMBSemesterMatkul.SelectedIndex = 0

                ' F. Pastikan semua kontrol aktif
                .CMBProdiMatkul.Enabled = True
                .CMBSEMESTER.Enabled = True
                .CMBSemesterMatkul.Enabled = True

                ' 4. Konfigurasi Field & Tombol
                .TXTKodeMatkul.Clear()
                .TXTNamaMatkul.Clear()
                .TXTSKS.Clear()
                .BTNSimpanMatkul.Text = "&SIMPAN"
                .BTNSimpanMatkul.BackColor = Color.Red
                .BTNKeluarMatkul.Text = "&BATAL"

                .BTNHapusMatkul.Enabled = False
                .BTNHapusMatkul.BackColor = Color.Red

                .BTNKeluarMatkul.Enabled = True
                .BTNKeluarMatkul.Text = "&BATAL"
                .BTNKeluarMatkul.BackColor = Color.CornflowerBlue ' Biru awal Anda
                .TXTKodeMatkul.Focus()
            End With

        Catch ex As Exception
            MsgBox("Gagal memindahkan data: " & ex.Message, vbCritical)
        End Try
    End Sub

    '=========================================================
    ' Event     : BtnKeluar_Click
    ' Fungsi    : Menangani proses keluar dari form
    '             atau mengaktifkan kembali form.
    ' Tujuan    : Memberikan konfirmasi sebelum keluar
    '             dari form data matakuliah.
    '=========================================================
    Private Sub BtnKeluarMatkul_Click(sender As Object, e As EventArgs) Handles BtnKeluarMatkul.Click
        If BtnKeluarMatkul.Text = "&KELUAR" Then
            Pesan = MsgBox("Anda yakin mau keluar dari form data matakuliah?",
                       vbQuestion + vbYesNo, "Informasi")
            If Pesan = vbYes Then
                Me.Close()
            End If
        Else
            ' Mengaktifkan kembali tombol tambah data
            BtnTambahMatkul.Text = "&AKTIF FORM"
            BtnTambahMatkul.Enabled = True
            BtnTambahMatkul.BackColor = Color.LightGray
        End If
    End Sub

    '=========================================================
    ' Procedure : BuatKodeMataKuliah
    ' Parameter : KodeProdi (String)
    ' Fungsi    : Membuat kode matakuliah baru secara otomatis
    '             berdasarkan kode terakhir di database.
    ' Tujuan    : Menjamin kode matakuliah bersifat unik
    '             dan berurutan.
    '=========================================================
    Sub BuatKodeMataKuliah(ByVal KodeProdi As String)
        Try
            ' Menghapus semua logika perhitungan otomatis untuk menghindari error 'Long'
            ' Cukup kosongkan TextBox agar user bisa input manual sesuai gambar contoh

            FrmInputMataKuliah.TXTKodeMatkul.Text = ""
            FrmInputMataKuliah.TXTKodeMatkul.ReadOnly = False ' Pastikan tidak terkunci agar bisa diketik
            FrmInputMataKuliah.TXTKodeMatkul.Focus() ' Letakkan kursor di sini agar user langsung bisa mengetik

        Catch ex As Exception
            ' Tidak perlu logika rumit di sini karena input dilakukan secara manual
        End Try
    End Sub

    '=========================================================
    ' Event     : TxtCariNama_KeyDown
    ' Fungsi    : Menjalankan pencarian data matakuliah
    '             saat tombol Enter ditekan.
    ' Tujuan    : Mempermudah user melakukan pencarian
    '             tanpa harus menekan tombol Cari.
    '=========================================================
    Private Sub TxtCariNamaMatkul_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtCariNamaMatkul.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            BTNCariMatkul.PerformClick()
        End If
    End Sub

    '=========================================================
    ' Event     : BindingNavigatorMoveFirstItem_Click
    ' Fungsi    : Berpindah ke halaman pertama data.
    '=========================================================
    Private Sub BindingNavigatorMoveFirstItem_Click(sender As Object, e As EventArgs) _
    Handles BindingNavigatorMoveFirstItemMatkul.Click

        CurrentPage = 1
        BindingNavigatorPositionItem.Text = CurrentPage
        UpdateNavigatorState()
        TampilkanDataGridMatakuliah()
    End Sub


    '=========================================================
    ' Event     : BindingNavigatorMovePreviousItem_Click
    ' Fungsi    : Berpindah ke halaman sebelumnya.
    '=========================================================
    Private Sub BindingNavigatorMovePreviousItemMatkul_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMovePreviousItemMatkul.Click

        If CurrentPage > 1 Then
            CurrentPage -= 1
            BindingNavigatorPositionItem.Text = CurrentPage
            UpdateNavigator()
            TampilkanDataGridMatakuliah()
        End If
    End Sub


    '=========================================================
    ' Event     : BindingNavigatorMoveNextItem_Click
    ' Fungsi    : Berpindah ke halaman berikutnya.
    '=========================================================
    Private Sub BindingNavigatorMoveNextItemMatkul_Click(sender As Object, e As EventArgs) _
    Handles BindingNavigatorMoveNextItemMatkul.Click

        If CurrentPage < TotalPage Then
            CurrentPage += 1
            BindingNavigatorPositionItem.Text = CurrentPage
            UpdateNavigator()
            TampilkanDataGridMatakuliah()
        End If
    End Sub


    '=========================================================
    ' Event     : BindingNavigatorMoveLastItem_Click
    ' Fungsi    : Berpindah ke halaman terakhir data.
    '=========================================================
    Private Sub BindingNavigatorMoveLastItem_Click(sender As Object, e As EventArgs) _
    Handles BindingNavigatorMoveLastItemMatkul.Click

        CurrentPage = TotalPage
        BindingNavigatorPositionItem.Text = CurrentPage
        UpdateNavigator()
        TampilkanDataGridMatakuliah()
    End Sub

    '=========================================================
    ' Procedure : RefreshPaging
    ' Fungsi    : Mengatur ulang paging ke halaman awal.
    ' Tujuan    : Menampilkan ulang data matakuliah
    '             sesuai kondisi filter terbaru.
    '=========================================================
    Sub RefreshPaging()
        CurrentPage = 1
        PageCache.Clear()
        HitungTotalData()
        TampilkanDataGridMatakuliah()
    End Sub

    '=========================================================
    ' Procedure : UpdateNavigatorState
    ' Fungsi    : Mengatur status tombol navigasi paging.
    ' Tujuan    : Mencegah navigasi keluar dari batas halaman.
    '=========================================================
    Sub UpdateNavigatorState()
        BindingNavigatorMoveFirstItemMatkul.Enabled = (CurrentPage > 1)
        BindingNavigatorMovePreviousItemMatkul.Enabled = (CurrentPage > 1)

        BindingNavigatorMoveNextItemMatkul.Enabled = (CurrentPage < TotalPage)
        BindingNavigatorMoveLastItemMatkul.Enabled = (CurrentPage < TotalPage)

        BindingNavigatorPositionItem.Text = CurrentPage.ToString()
        BindingNavigatorCountItem.Text = $"of {TotalPage}"
    End Sub

    '================================================================================
    ' EVENT     : DataGridMataKuliah_CellMouseDoubleClick
    ' Fungsi    :
    ' - Mengambil data matakuliah yang diklik
    ' - Membuka Form Biodata Matakuliah
    ' - Mengisi field biodata berdasarkan data database
    ' Tujuan    :
    ' - Memudahkan proses edit data matakuliah
    '================================================================================
    Private Sub DataGridMatkul_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridMatkul.CellMouseDoubleClick
        Try
            ' 1. VALIDASI KLIK
            If e.RowIndex < 0 OrElse DataGridMatkul.Rows.Count = 0 Then Exit Sub

            ' 2. AMBIL KODE MATAKULIAH (Gunakan Index 0 untuk menghindari error "Column Not Found")
            Dim KdMatkul As String = DataGridMatkul.Rows(e.RowIndex).Cells(0).Value.ToString()

            ' 3. PERSIAPAN FORM & KONEKSI
            Call KoneksiDb()
            If DR IsNot Nothing Then DR.Close()

            ' 4. QUERY PILIHAN ANDA (Sangat bagus untuk akurasi data)
            QUERY = "SELECT DISTINCT " &
                "tbl_matakuliah.Kd_Matakuliah, " &
                "tbl_matakuliah.Nm_Matakuliah, " &
                "tbl_matakuliah.Sks_Matakuliah, " &
                "tbl_matakuliah.Teori_Matakuliah, " &
                "tbl_matakuliah.Praktek_Matakuliah, " &
                "tbl_matakuliah.Semester_Matakuliah, " &
                "tbl_matakuliah.Kd_Prodi " &
                "FROM tbl_matakuliah " &
                "INNER JOIN tbl_prodi ON tbl_matakuliah.Kd_Prodi = tbl_prodi.Kd_Prodi " &
                "WHERE tbl_prodi.Nm_Prodi = @NmProdi " &
                "AND tbl_matakuliah.Kd_Matakuliah = @KdMatkul"

            Using CMD As New MySqlCommand(QUERY, DbKoneksi)
                ' Ambil Nama Prodi dari ComboBox di Form Master
                CMD.Parameters.AddWithValue("@NmProdi", CBNamaJurusanMatkul.Text)
                CMD.Parameters.AddWithValue("@KdMatkul", KdMatkul)

                Using DR = CMD.ExecuteReader()
                    If DR.Read() Then
                        ' Tampilkan Form Input Terlebih Dahulu
                        FrmInputMataKuliah.Show()

                        With FrmInputMataKuliah
                            ' ===== A. ISI DATA DASAR =====
                            .TXTKodeMatkul.Text = DR("Kd_Matakuliah").ToString()
                            .TXTNamaMatkul.Text = DR("Nm_Matakuliah").ToString()
                            .TXTSKS.Text = DR("Sks_Matakuliah").ToString()
                            .TXTTeoriMatkul.Text = DR("Teori_Matakuliah").ToString()
                            .TXTPraktekMatkul.Text = DR("Praktek_Matakuliah").ToString()

                            ' ===== B. SINKRONISASI PRODI & SEMESTER =====
                            ' Kode Prodi diletakkan di label tersembunyi
                            .LBKDPRODIMATKUL.Text = DR("Kd_Prodi").ToString()
                            .CMBProdiMatkul.Text = CBNamaJurusanMatkul.Text

                            ' Logika Ganjil/Genap Otomatis berdasarkan Angka Semester
                            Dim angkasem As Integer = Val(DR("Semester_Matakuliah"))
                            .CMBSEMESTER.Text = If(angkasem Mod 2 = 1, "GANJIL", "GENAP")

                            ' ===== C. MENAMPILKAN ANGKA SEMESTER (PENTING AGAR TIDAK KOSONG) =====
                            .CMBSemesterMatkul.Items.Clear()
                            .CMBSemesterMatkul.Items.Add(DR("Semester_Matakuliah").ToString())
                            .CMBSemesterMatkul.SelectedIndex = 0

                            ' ===== D. SETTING WARNA & MODE EDIT (CornflowerBlue) =====
                            .TXTKodeMatkul.ReadOnly = True

                            .BTNSimpanMatkul.Enabled = True
                            .BTNSimpanMatkul.Text = "&UBAH"
                            .BTNSimpanMatkul.BackColor = Color.CornflowerBlue

                            .BTNKeluarMatkul.Enabled = True
                            .BTNKeluarMatkul.Text = "&BATAL"
                            .BTNKeluarMatkul.BackColor = Color.CornflowerBlue

                            .BTNHapusMatkul.Enabled = True
                            .BTNHapusMatkul.BackColor = Color.CornflowerBlue

                            .TXTNamaMatkul.Focus()
                        End With
                    Else
                        MsgBox("Data tidak ditemukan atau Prodi tidak sesuai!", vbExclamation)
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '================================================================================
    ' PROCEDURE : SetFilterProdiDanRefresh
    ' Parameter : KodeProdiBaru (String)
    ' Fungsi    :
    ' - Mengubah filter prodi dari form lain
    ' - Mengatur ulang paging matakuliah
    ' - Menghindari trigger event SelectedIndexChanged berulang
    ' Tujuan    :
    ' - Sinkronisasi filter prodi antar form
    '================================================================================
    ' Tambahkan ini di FrmDataMataKuliah
    Public Sub SetFilterProdiDanRefresh(idProdi As String)
        ' 1. Set ComboBox Prodi agar sesuai dengan data yang baru diinput
        CBNamaJurusanMatkul.SelectedValue = idProdi
        LBPRODIMatkul.Text = idProdi

        ' 2. WAJIB: Hapus cache agar data baru ditarik dari Database
        Call ClearPagingCache()

        ' 3. Reset navigasi ke halaman 1
        CurrentPage = 1

        ' 4. Hitung ulang total data dan muat Grid
        Call HitungTotalData()
        Call HitungRowDataGrid()
        Call TampilkanDataGridMatakuliah()
    End Sub

    ' Event saat Jenis Semester (Ganjil/Genap) dipilih
    Private Sub CMBJenisGanjilGenap_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBJenisGanjilGenap.SelectedIndexChanged
        If isloading Then Exit Sub

        CBSemesterMatkul.Items.Clear()
        CBSemesterMatkul.Enabled = True

        ' Isi angka semester berdasarkan pilihan Ganjil/Genap
        If CMBJenisGanjilGenap.Text = "GANJIL" Then
            CBSemesterMatkul.Items.AddRange(New Object() {"1", "3", "5", "7"})
        Else
            CBSemesterMatkul.Items.AddRange(New Object() {"2", "4", "6", "8"})
        End If

        ' Reset data karena filter berubah
        Call ClearPagingCache()
        CurrentPage = 1
        Call HitungTotalData()
        Call TampilkanDataGridMatakuliah()
    End Sub

    ' Event saat Angka Semester dipilih (Contoh: Ganjil -> 3)
    Private Sub CBSemesterMatkul_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBSemesterMatkul.SelectedIndexChanged
        ' 1. Mencegah eksekusi saat loading atau jika tidak ada angka semester
        If isloading OrElse CBSemesterMatkul.Text = "" Then Exit Sub

        Try
            ' 2. Panggil fungsi pengecekan yang baru kita buat di atas
            If Not CekDataMatkulExist(Kode_Jurusan, CBSemesterMatkul.Text) Then

                ' Tampilan Grid dikosongkan terlebih dahulu
                DataGridMatkul.DataSource = Nothing
                Call AktifkanDataGridMatkul() ' Tetap tampilkan header

                ' 3. Tampilkan Notifikasi PERINGATAN (Identik dengan Gambar 13)
                Dim isiPesan As String = "Data Matakuliah pada Jurusan : " & CBNamaJurusanMatkul.Text & vbCrLf &
                                     "Status Semester : " & CMBJenisGanjilGenap.Text & vbCrLf &
                                     "Semester : " & CBSemesterMatkul.Text & " Belum Ada!!" & vbCrLf &
                                     "Silahkan Inputkan Data Matakuliah Untuk Memasukan Data Matakuliah pada Semester " & CMBJenisGanjilGenap.Text & "!!"

                ' Menggunakan ikon Stop (Silang Merah) sesuai permintaan
                MessageBox.Show(isiPesan, "PERINGATAN", MessageBoxButtons.OK, MessageBoxIcon.Stop)

                ' 4. Alur Otomatis: Buka Form Input Data
                ' Pastikan BtnTambahMatkul_Click sudah menggunakan logika yang kita betulkan sebelumnya
                Call BtnTambahMatkul_Click(Nothing, Nothing)
                Exit Sub
            End If

            ' 5. Jika data ditemukan, lakukan prosedur normal
            Call ClearPagingCache()
            CurrentPage = 1
            Call HitungTotalData()
            Call TampilkanDataGridMatakuliah()

        Catch ex As Exception
            MsgBox("Error Filter Semester: " & ex.Message, vbCritical)
        End Try
    End Sub

    ' Fungsi untuk mengecek apakah ada data matakuliah untuk prodi dan semester tertentu
    Private Function CekDataMatkulExist(kdProdi As String, sem As String) As Boolean
        Dim adaData As Boolean = False
        Try
            Call KoneksiDb()
            ' Query untuk menghitung jumlah baris yang sesuai kriteria
            Dim sql As String = "SELECT COUNT(*) FROM tbl_matakuliah WHERE Kd_Prodi = @kd AND Semester_Matakuliah = @sem"
            Dim cmd As New MySqlCommand(sql, DbKoneksi)
            cmd.Parameters.AddWithValue("@kd", kdProdi)
            cmd.Parameters.AddWithValue("@sem", sem)

            Dim jumlah As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            If jumlah > 0 Then adaData = True
        Catch ex As Exception
            adaData = False
            MsgBox("Error Cek Data: " & ex.Message, vbCritical)
        End Try
        Return adaData
    End Function
End Class