Imports MySql.Data.MySqlClient
Public Class FrmDataDosenPagging
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
        Dim Prodi As String = If(CBNamaJurusan.SelectedValue Is Nothing, "", CBNamaJurusan.SelectedValue.ToString())
        Dim Nama As String = TxtCariNama.Text.Trim()
        Dim Limit As String = ComboBoxEntries.Text
        Return Prodi & "|" & Nama & "|" & Limit & "|" & Page
    End Function


    'membuat fungsi clear cache
    Sub ClearPagingCache()
        PageCache.Clear()
        LastCacheKey = ""
    End Sub

    'membuat variable data entri
    Sub NumberEntriesHalaman()
        ComboBoxEntries.Items.Add("10")
        ComboBoxEntries.Items.Add("15")
        ComboBoxEntries.Items.Add("20")
        ComboBoxEntries.Items.Add("25")
        ComboBoxEntries.Items.Add("50")
        ComboBoxEntries.Items.Add("100")

        'menampilkan data index ke 0
        ComboBoxEntries.SelectedIndex = 0
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


    Private Sub DataGridDosen_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DataGridDosen.DataBindingComplete
        For i As Integer = 0 To DataGridDosen.Rows.Count - 1
            DataGridDosen.Rows(i).HeaderCell.Value = (OffSet + i + 1).ToString()
        Next
    End Sub

    'membuat refresh buat paging
    Sub RefreshPaging()
        CurrentPage = 1
        PageCache.Clear()
        HitungTotalData()
        LoadPage()
    End Sub

    'membuat tampian dataview
    Sub AktifkanDataGridDosen()
        With DataGridDosen
            .EnableHeadersVisualStyles = False

            'mengatur properties pada data grid header
            .Font = New Font(DataGridDosen.Font, FontStyle.Bold)
            DataGridDosen.DefaultCellStyle.Font = New Font("Arial", 9)
            DataGridDosen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
            DataGridDosen.ColumnHeadersHeight = 35

            'memberikan nama header Kode Dosen
            DataGridDosen.Columns(0).Width = 120
            DataGridDosen.Columns(0).HeaderText = "KODE DOSEN"
            DataGridDosen.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            'memberikan nama header KODE PRODI
            DataGridDosen.Columns(1).Width = 120
            DataGridDosen.Columns(1).HeaderText = "KODE PRODI"
            DataGridDosen.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            'memberikan nama header NIDN
            DataGridDosen.Columns(2).Width = 200
            DataGridDosen.Columns(2).HeaderText = "NIDN DOSEN"
            DataGridDosen.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            'memberikan nama header NAMA DOSEN
            DataGridDosen.Columns(3).Width = 150
            DataGridDosen.Columns(3).HeaderText = "NAMA DOSEN"
            DataGridDosen.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            'memberikan nama header JENIS KELAMIN
            DataGridDosen.Columns(4).Width = 200
            DataGridDosen.Columns(4).HeaderText = "JENIS KELAMIN"
            DataGridDosen.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            'memberikan nama header NO HP
            DataGridDosen.Columns(5).Width = 300
            DataGridDosen.Columns(5).HeaderText = "NO HP DOSEN"
            DataGridDosen.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            'memberikan nama header EMAIL
            DataGridDosen.Columns(6).Width = 300
            DataGridDosen.Columns(6).HeaderText = "EMAIL DOSEN"
            DataGridDosen.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With
    End Sub

    'membuat procedure hitung total data
    Sub HitungTotalData()
        Try
            Call KoneksiDb()
            QUERY = "SELECT COUNT(*)
                        FROM tbl_dosen
                        WHERE Kd_Prodi = @KdProdi"

            If TxtCariNama.Text <> "" Then
                QUERY &= " AND Nm_Dosen LIKE @NamaDosen"
            End If

            Using CMD As New MySqlCommand(QUERY, DbKoneksi)
                CMD.Parameters.AddWithValue("@KdProdi", CBNamaJurusan.SelectedValue)
                If TxtCariNama.Text <> "" Then
                    CMD.Parameters.AddWithValue("@NamaDosen", "%" & TxtCariNama.Text & "%")
                End If

                TotalData = CInt(CMD.ExecuteScalar())
            End Using

            TotalPage = Math.Ceiling(TotalData / PageSize)
            If TotalPage < 1 Then TotalPage = 1

            'Update label
            LbTotalBaris.Text = "Total Baris Halaman: " & TotalData
            LbHasilbagihalaman.Text = "Jumlah Hal: " & TotalPage
        Catch ex As Exception
            MessageBox.Show("Error Hitung Totak Data: " & ex.Message)
        End Try
    End Sub

    'membuat sub procedure untuk load halaman
    Sub LoadPage()
        OffSet = (CurrentPage - 1) * PageSize
        Dim cachekey As String = $"{CurrentPage}-{PageSize}-{TxtCariNama.Text}"

        'CACHE
        If PageCache.ContainsKey(cachekey) Then
            DataGridDosen.DataSource = PageCache(cachekey)
            Exit Sub
        End If

        Call KoneksiDb()

        QUERY = "Select
                    Kd_Dosen,
                    Kd_Prodi,
                    Nidn_Dosen,
                    Nm_Dosen,
                    Jk_Dosen,
                    Nohp_Dosen,
                    Email_Dosen 
                    FROM tbl_dosen
                    WHERE Kd_Prodi = @KdProdi"

        If TxtCariNama.Text <> "" Then
            QUERY &= " AND Nm_Dosen LIKE @NamaDosen"
        End If

        QUERY &= " ORDER BY Kd_Dosen ASC LIMIT @Offset, @Limit"

        Using DA As New MySqlDataAdapter(QUERY, DbKoneksi)
            DA.SelectCommand.Parameters.AddWithValue("@KdProdi", CBNamaJurusan.SelectedValue)
            DA.SelectCommand.Parameters.AddWithValue("@OffSet", OffSet)
            DA.SelectCommand.Parameters.AddWithValue("@Limit", PageSize)

            If TxtCariNama.Text <> "" Then
                DA.SelectCommand.Parameters.AddWithValue("@NamaDosen", "%" & TxtCariNama.Text & "%")
            End If

            Dim dt As New DataTable
            DA.Fill(dt)

            PageCache(cachekey) = dt
            DataGridDosen.DataSource = dt

            UpdateNavigator()
        End Using
    End Sub

    'membuat update navigator
    Sub UpdateNavigator()
        BindingNavigatorMoveFirstItem.Enabled = (CurrentPage > 1)
        BindingNavigatorMovePreviousItem.Enabled = (CurrentPage > 1)
        BindingNavigatorMoveNextItem.Enabled = (CurrentPage < TotalPage)
        BindingNavigatorMoveLastItem.Enabled = (CurrentPage < TotalPage)

        BindingNavigatorPositionItem.Text = CurrentPage.ToString()
        BindingNavigatorCountItem.Text = $"of {TotalPage}"
    End Sub

    Sub TampilkanDataGridDosen()

        Try
            'hitung nilai paging
            PageSize = Val(ComboBoxEntries.Text)
            OffSet = (CurrentPage - 1) * PageSize

            Dim CacheKey As String = GETCacheKey(CurrentPage)

            'Ambil dari cache
            If PageCache.ContainsKey(CacheKey) Then
                Dim dtCache As DataTable = PageCache(CacheKey)

                DataGridDosen.DataSource = dtCache
                FormatRowHeader(DataGridDosen, OffSet, PageSize)
                LabelJumlahBaris.Text = "Jumlah Baris Entri: " & dtCache.Rows.Count
                UpdateNavigator()
            End If

            Call KoneksiDb()

            QUERY = "SELECT DISTINCT
                        tbl_dosen.Kd_Dosen,
                        tbl_dosen.Kd_Prodi,
                        tbl_dosen.Nidn_Dosen,
                        tbl_dosen.Nm_Dosen,
                        tbl_dosen.Jk_Dosen,
                        tbl_dosen.Nohp_Dosen,
                        tbl_dosen.Email_Dosen 
                        FROM tbl_dosen
                        INNER JOIN tbl_prodi ON tbl_dosen.Kd_Prodi = tbl_prodi.Kd_Prodi 
                        WHERE tbl_prodi.Kd_Prodi = @KdProdi"

            If TxtCariNama.Text <> "" Then
                QUERY &= " AND tbl_dosen.Nm_Dosen LIKE @NamaDosen"
            End If

            QUERY &= " ORDER BY tbl_dosen.Kd_Dosen ASC LIMIT @Offset, @Limit"

            Using DA As New MySqlDataAdapter(QUERY, DbKoneksi)
                DA.SelectCommand.Parameters.AddWithValue("@KdProdi", CBNamaJurusan.SelectedValue)
                DA.SelectCommand.Parameters.AddWithValue("@Offset", OffSet)
                DA.SelectCommand.Parameters.AddWithValue("@Limit", PageSize)

                If TxtCariNama.Text <> "" Then
                    DA.SelectCommand.Parameters.AddWithValue("@NamaDosen", "%" & TxtCariNama.Text & "%")
                End If

                Dim DT As New DataTable
                DA.Fill(DT)

                'isi cache
                PageCache(CacheKey) = DT

                DataGridDosen.DataSource = DT
                'Nomor Urut di sisi kiri
                FormatRowHeader(DataGridDosen, OffSet, PageSize)

                LabelJumlahBaris.Text = "Jumlah Baris Entri: " & DT.Rows.Count
                UpdateNavigator()
                DataGridDosen.ReadOnly = True
            End Using

        Catch ex As Exception
            MessageBox.Show("Error TampilkanDataGridDosen: " & ex.Message)
        End Try

        AktifkanDataGridDosen()

    End Sub

    'membuat sub procedure untuk menghitung jumlah baris pada data grid
    Sub HitungRowDataGrid()

        Try
            Call KoneksiDb()
            'menghitung baris halaman
            BindingNavigatorPositionItem.Text = 1
            Nomor = (Val(BindingNavigatorPositionItem.Text) - 1) * Val(ComboBoxEntries.Text)
            Batas = ComboBoxEntries.Text

            'menampilkan jumlah seluruh data record saat di tampilkan ke data grid
            Call KoneksiDb()
            CMD = New MySqlCommand(" SELECT CEILING(COUNT(*)) AS Hasil
                                     FROM tbl_dosen
                                        INNER JOIN tbl_prodi
                                        ON tbl_dosen.Kd_Prodi = tbl_prodi.Kd_Prodi", DbKoneksi)

            DR = CMD.ExecuteReader()
            DR.Read()
            TotalData = DR!Hasil
            DR.Close()

            LbTotalBaris.Text = "Total Baris All: " & TotalData & ""

        Catch ex As Exception
            MessageBox.Show("Error HitungRowDataGrid: " & ex.Message)
        End Try

    End Sub

    Private Sub ComboBoxEntries_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxEntries.SelectedIndexChanged
        ''menghitung jumlah baris data yang akan di tampilkan
        If ComboBoxEntries.SelectedIndex = -1 Then Exit Sub

        PageSize = CInt(ComboBoxEntries.Text)
        RefreshPaging()
    End Sub

    'membuat event keypress pada comboBoxEntries
    Private Sub ComboBoxEntries_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBoxEntries.KeyPress
        e.Handled = True
    End Sub

    'event leave pada binding navigator
    Private Sub BindingNavigatorPositionItem_Leave(sender As Object, e As EventArgs) Handles BindingNavigatorPositionItem.Leave
        If Val(BindingNavigatorPositionItem.Text) < 1 Then
            BindingNavigatorPositionItem.Text = "1"
        End If

        If Val(BindingNavigatorPositionItem.Text) > Val(LbHasilbagihalaman.Text) Then
            BindingNavigatorPositionItem.Text = LbHasilbagihalaman.Text
        End If
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

            CBNamaJurusan.DataSource = DT
            CBNamaJurusan.DisplayMember = "Nm_Prodi"
            CBNamaJurusan.ValueMember = "Kd_Prodi"
            CBNamaJurusan.SelectedIndex = -1 'data sebelum memilih
            LBProdi.Text = ""

        Catch ex As Exception
            MsgBox("Gagal memuat data Prodi: " & ex.Message, vbCritical)
        End Try
    End Sub

    'membuat private prosedur pada combo box dengan event selectediindexchanged
    Private Sub CbNmJurusan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBNamaJurusan.SelectedIndexChanged
        If isloading Then Exit Sub
        If CBNamaJurusan.SelectedIndex < 0 Then Exit Sub
        If CBNamaJurusan.SelectedValue Is Nothing Then Exit Sub

        Try
            '1️⃣ Ambil kode prodi
            Kode_Jurusan = CBNamaJurusan.SelectedValue.ToString()
            LBProdi.Text = Kode_Jurusan

            '2️⃣ Jika prodi BELUM punya dosen
            If ProdiBelumAdaDosen(Kode_Jurusan) Then
                If MessageBox.Show(
                "Data dosen jurusan " & CBNamaJurusan.Text & " belum ada." & vbCrLf &
                "Apakah ingin menambahkan data dosen?",
                "Informasi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information) = DialogResult.Yes Then

                    '🔧 LOGIKA TAMBAHAN (INTI PERBAIKAN)
                    With FrmBiodataDosen
                        .KdProdidariForm = Kode_Jurusan        'kirim kode prodi hasil filter
                        .BTNHAPUSBiodata.Enabled = False
                        .CMBJurusan.Enabled = False
                    End With

                    '🔧 BUAT KODE DOSEN (LANJUT DARI 139999 → 140001)
                    Call BuatKodeDosen(Kode_Jurusan)

                    FrmBiodataDosen.ShowDialog()
                End If

                '🔴 Jangan filter grid karena memang belum ada data
                PageCache.Clear()
                DataGridDosen.DataSource = Nothing
                Exit Sub
            End If

            '3️⃣ Jika prodi SUDAH ada data → filter grid
            CurrentPage = 1
            PageCache.Clear()
            BindingNavigatorPositionItem.Text = "1"

            RefreshPaging()
            TampilkanDataGridDosen()

        Catch ex As Exception
            MsgBox("Error Memilih Prodi: " & ex.Message, vbCritical)
        End Try
    End Sub


    'membuat fungsi untuk mencari prodi yang belum ada data dosen
    Function ProdiBelumAdaDosen(kdProdi As String) As Boolean
        Try
            Call KoneksiDb()

            QUERY = "SELECT COUNT(*) FROM tbl_dosen WHERE Kd_Prodi = @KdProdi"

            Using CMD As New MySqlCommand(QUERY, DbKoneksi)
                CMD.Parameters.AddWithValue("@KdProdi", kdProdi)
                Return CInt(CMD.ExecuteScalar()) = 0
            End Using

        Catch ex As Exception
            MessageBox.Show("Error validasi prodi: " & ex.Message)
            Return False
        End Try
    End Function

    'membuat fungsi validasi data prodi jika tidak ada
    Function ProdiAda(KdProdi As String) As Boolean
        Call KoneksiDb()
        QUERY = "SELECT COUNT(*) FROM tbl_prodi WHERE Kd_Prodi = @KdProdi"
        CMD = New MySqlCommand(QUERY, DbKoneksi)
        CMD.Parameters.AddWithValue("@KdProdi", KdProdi)
        Return CInt(CMD.ExecuteScalar()) > 0
    End Function

    Private Sub FrmDataDosenPagging_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isloading = True
        Call KoneksiDb()
        'Call HitungRowDataGrid()
        Call NumberEntriesHalaman()
        Call AktifkanDataGridDosen()
        Call TampilkanFilterNamaProdi()
        Me.AcceptButton = BTNCARI

        'untuk menoonaktifkan data gridview
        DataGridDosen.Enabled = True

        isloading = False
    End Sub

    Private Sub BTNCARI_Click(sender As Object, e As EventArgs) Handles BTNCARI.Click
        Try
            Call KoneksiDb()
            Call RefreshPaging()

            '1.validasi input cari nama kosong
            If TxtCariNama.Text = "" Then
                MsgBox("Silahkan Inputkan nama yang akan dicari dahulu!", vbExclamation)
                TxtCariNama.Focus()
                Exit Sub
            End If

            '2.validasi pada saat belum di pilih combobox
            If CBNamaJurusan.Text = "" Then
                MsgBox("Pilih Prodi terlebih dahulu!", vbExclamation)
                CBNamaJurusan.Focus()
                Exit Sub
            End If

            '3.buat query sql untuk menari data
            QUERY = "Select DISTINCT
                        tbl_dosen.Kd_Dosen,
                        tbl_dosen.Kd_Prodi,
                        tbl_dosen.Nidn_Dosen,
                        tbl_dosen.Nm_Dosen,
                        tbl_dosen.Jk_Dosen,
                        tbl_dosen.Nohp_Dosen,
                        tbl_dosen.Email_Dosen 
                        FROM tbl_dosen
                        INNER Join tbl_prodi ON tbl_dosen.Kd_Prodi = tbl_prodi.Kd_Prodi 
                        WHERE tbl_prodi.Nm_Prodi = @NmProdi 
                        And tbl_dosen.Nm_Dosen Like @NamaDosen"

            DA = New MySqlDataAdapter(QUERY, DbKoneksi)
            DA.SelectCommand.Parameters.AddWithValue("@NmProdi", CBNamaJurusan.Text)
            DA.SelectCommand.Parameters.AddWithValue("@NamaDosen", "%" & TxtCariNama.Text & "%")

            DS = New DataSet
            DA.Fill(DS)

            DataGridDosen.DataSource = DS.Tables(0)
            DataGridDosen.Enabled = True

            '4. Validasi jika data kosong
            If DS.Tables(0).Rows.Count = 0 Then
                MsgBox("Data dosen tidak ditemukan!", vbInformation)
            End If

        Catch ex As Exception
            MsgBox("Terjadi kesalahan saat pencarian data: " & ex.Message, vbCritical)
        End Try
    End Sub


    Private Sub BtnTambahData_Click(sender As Object, e As EventArgs) Handles BtnTambahData.Click
        Call KoneksiDb()

        If CBNamaJurusan.SelectedIndex = -1 Then
            MsgBox("Silahkan Pilih Nama Prodi terlebih Dahulu!!", vbCritical + vbYes, "Peringatan")
            CBNamaJurusan.Focus()
        Else
            Call BuatKodeDosen(LBProdi.Text)

            With FrmBiodataDosen
                ' ===== MODE TAMBAH =====
                .KdProdidariForm = CBNamaJurusan.SelectedValue.ToString()

                .BTNSIMPANBiodata.Text = "&SIMPAN"
                .BTNSIMPANBiodata.Enabled = True
                .BTNSIMPANBiodata.BackColor = Color.Red   ' 🔥 WAJIB

                .BTNHAPUSBiodata.Enabled = False
                .BTNHAPUSBiodata.BackColor = Color.Red

                .BTNKELUARBiodata.Text = "&BATAL"
                .BTNKELUARBiodata.Enabled = True
                .BTNKELUARBiodata.BackColor = Color.CornflowerBlue

                .CMBJurusan.Enabled = False

                ' 🔹 Kosongkan input (penting!)
                .TXTNIDN.Clear()
                .TXTNamaDosen.Clear()
                .TXTNoHp.Clear()
                .TXTEmailDosen.Clear()
                .CMBJKDosen.SelectedIndex = -1

                .ShowDialog()
            End With
        End If

    End Sub

    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        If BtnKeluar.Text = "&KELUAR" Then
            Pesan = MsgBox("Anda yakkin mau exit dari form data dosen?", vbQuestion + vbYesNo, "Informasi")
            If Pesan = vbYes Then
                Me.Close()
            End If
        Else
            BtnTambahData.Text = "&AKTIF FORM"
            BtnTambahData.Enabled = True
            BtnTambahData.BackColor = Color.LightGray
        End If
    End Sub

    'membuat kode dosen baru
    Sub BuatKodeDosen(KodeProdi As String)

        Call KoneksiDb()

        Try
            QUERY = "SELECT MAX(Kd_Dosen) FROM tbl_dosen"

            Using CMD As New MySqlCommand(QUERY, DbKoneksi)

                Dim Hasil As Object = CMD.ExecuteScalar()
                Dim KodeBaru As Long

                If Hasil Is Nothing OrElse IsDBNull(Hasil) Then
                    ' Jika tabel masih kosong
                    KodeBaru = 140001

                Else
                    Dim KodeTerakhir As Long = CLng(Hasil)

                    ' 🔴 LOGIKA PENTING
                    If KodeTerakhir < 140000 Then
                        KodeBaru = 140001
                    Else
                        KodeBaru = KodeTerakhir + 1
                    End If
                End If

                ' tampilkan ke form biodata
                FrmBiodataDosen.LBKodeDosen.Text = KodeBaru.ToString()

            End Using

        Catch ex As Exception
            MessageBox.Show(
            "Gagal membuat Kode Dosen: " & ex.Message,
            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    'mencari nama menggunakan enter
    Private Sub TxtCariNama_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtCariNama.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            BTNCARI.PerformClick()
        End If
    End Sub

    'event click pada binding move first
    Private Sub BindingNavigatorMoveFirstItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveFirstItem.Click
        CurrentPage = 1
        BindingNavigatorPositionItem.Text = CurrentPage
        UpdateNavigator()
        TampilkanDataGridDosen()
    End Sub

    'event click binding navigator move previous
    Private Sub BindingNavigatorMovePreviousItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMovePreviousItem.Click
        If CurrentPage > 1 Then
            CurrentPage -= 1
            BindingNavigatorPositionItem.Text = CurrentPage
            UpdateNavigator()
            TampilkanDataGridDosen()
        End If
    End Sub

    'event click binding navigator move next
    Private Sub BindingNavigatorMoveNextItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveNextItem.Click
        If CurrentPage < TotalPage Then
            CurrentPage += 1
            BindingNavigatorPositionItem.Text = CurrentPage
            UpdateNavigator()
            TampilkanDataGridDosen()
        End If
    End Sub

    'event click binding navigator move last 
    Private Sub BindingNavigatorMoveLastItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveLastItem.Click
        CurrentPage = TotalPage
        BindingNavigatorPositionItem.Text = CurrentPage
        UpdateNavigator()
        TampilkanDataGridDosen()
    End Sub

    Sub ReffreshPaging()
        CurrentPage = 1
        PageCache.Clear()
        HitungTotalData()
        TampilkanDataGridDosen()
    End Sub

    Sub UpdateNavigatorState()
        BindingNavigatorMoveFirstItem.Enabled = (CurrentPage > 1)
        BindingNavigatorMovePreviousItem.Enabled = (CurrentPage > 1)

        BindingNavigatorMoveNextItem.Enabled = (CurrentPage < TotalPage)
        BindingNavigatorMoveLastItem.Enabled = (CurrentPage < TotalPage)

        BindingNavigatorPositionItem.Text = (CurrentPage.ToString())
        BindingNavigatorCountItem.Text = $"of {TotalPage}"
    End Sub

    Private Sub DataGridDosen_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridDosen.CellMouseDoubleClick
        Try
            ' ===== VALIDASI KLIK =====
            If e.RowIndex < 0 Then Exit Sub
            If DataGridDosen.Rows.Count = 0 Then Exit Sub

            ' ===== AMBIL KODE DOSEN =====
            Dim KdDosen As String = DataGridDosen.Rows(e.RowIndex).Cells("Kd_Dosen").Value.ToString()

            ' ===== TAMPILKAN FORM BIODATA DOSEN =====
            FrmBiodataDosen.Show()
            Me.Enabled = True

            With FrmBiodataDosen
                .BTNSIMPANBiodata.Enabled = True
                .BTNSIMPANBiodata.Text = "&UBAH"
                .BTNSIMPANBiodata.BackColor = Color.CornflowerBlue

                .BTNKELUARBiodata.Enabled = True
                .BTNKELUARBiodata.Text = "&BATAL"
                .BTNKELUARBiodata.BackColor = Color.CornflowerBlue

                .BTNHAPUSBiodata.Enabled = True
                .BTNHAPUSBiodata.BackColor = Color.CornflowerBlue
            End With

            ' ===== QUERY DATABASE =====
            Call KoneksiDb()

            ' Pastikan DataReader sebelumnya ditutup
            If DR IsNot Nothing Then
                DR.Close()
            End If

            QUERY = "SELECT DISTINCT
                    tbl_dosen.Kd_Dosen,
                    tbl_dosen.Nidn_Dosen,
                    tbl_dosen.Nm_Dosen,
                    tbl_dosen.Jk_Dosen,
                    tbl_dosen.Nohp_Dosen,
                    tbl_dosen.Email_Dosen,
                    tbl_dosen.Kd_Prodi
                 FROM tbl_dosen
                 INNER JOIN tbl_prodi 
                    ON tbl_dosen.Kd_Prodi = tbl_prodi.Kd_Prodi
                 WHERE tbl_prodi.Nm_Prodi = @NmProdi
                 AND tbl_dosen.Kd_Dosen = @KdDosen"

            Using CMD = New MySqlCommand(QUERY, DbKoneksi)
                CMD.Parameters.AddWithValue("@NmProdi", CBNamaJurusan.Text)
                CMD.Parameters.AddWithValue("@KdDosen", KdDosen)

                Using DR = CMD.ExecuteReader()
                    If DR.Read() Then
                        With FrmBiodataDosen
                            .LBKodeDosen.Text = DR("Kd_Dosen").ToString()
                            .TXTNIDN.Text = DR("Nidn_Dosen").ToString()
                            .TXTNamaDosen.Text = DR("Nm_Dosen").ToString()
                            .CMBJKDosen.Text = DR("Jk_Dosen").ToString()
                            .TXTNoHp.Text = If(IsDBNull(DR("Nohp_Dosen")), "", DR("Nohp_Dosen").ToString())
                            .TXTEmailDosen.Text = If(IsDBNull(DR("Email_Dosen")), "", DR("Email_Dosen").ToString())

                            ' 🔹 Set Prodi combobox agar bisa diubah
                            .SetProdiOtomatis(DR("Kd_Prodi").ToString())
                        End With
                    Else
                        MsgBox("Data dosen tidak ditemukan!", vbExclamation)
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show(
                "Terjadi kesalahan saat menampilkan data dosen : " & ex.Message,
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub SetFilterProdiDanRefresh(KodeProdiBaru As String)
        Try
            isloading = True   ' 🔒 kunci event

            ' 🔥 SET COMBO LANGSUNG VIA SelectedValue
            CBNamaJurusan.SelectedValue = KodeProdiBaru

            ' 🔥 SET LABEL KODE PRODI SECARA MANUAL
            LBProdi.Text = KodeProdiBaru

            ' refresh paging
            CurrentPage = 1
            PageCache.Clear()
            RefreshPaging()

        Catch ex As Exception
            MsgBox("Gagal set filter prodi baru: " & ex.Message, vbCritical)
        Finally
            isloading = False  ' 🔓 buka event lagi
        End Try
    End Sub

End Class