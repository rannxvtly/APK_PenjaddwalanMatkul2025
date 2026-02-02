Imports MySql.Data.MySqlClient
Public Class FrmDataTransaksiDosen
    Public KdProdiDariForm As String = ""
    Public SemesterDariForm As String = ""
    Public IsEditMode As Boolean = False

    Private Sub FrmDataTransaksiDosen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 1. Tentukan Mode di awal (Paling Penting!)
        ' Ini agar event SelectedIndexChanged tahu apakah harus generate kode baru atau tidak
        If BTNSimpanDataTransaksiDosen.Text.Contains("UBAH") Then
            IsEditMode = True
        Else
            IsEditMode = False
        End If

        ' 2. Pengaturan DropDownStyle (Agar tidak bisa diketik)
        CMBKelasData.DropDownStyle = ComboBoxStyle.DropDownList
        CMBSEMESTERData.DropDownStyle = ComboBoxStyle.DropDownList
        CBNamaJurusanData.DropDownStyle = ComboBoxStyle.DropDownList

        ' 3. Isi Item ComboBox (Jika kosong)
        If CMBKelasData.Items.Count = 0 Then
            CMBKelasData.Items.AddRange(New Object() {"Reguler", "Karyawan"})
        End If

        If CMBSEMESTERData.Items.Count = 0 Then
            CMBSEMESTERData.Items.AddRange(New Object() {"GANJIL", "GENAP"})
        End If

        ' 4. Muat Data Master Prodi
        Call SetDaftarProdi()

        ' 5. SINKRONISASI DATA (Proses ini akan memicu SelectedIndexChanged)

        ' Sinkronisasi Prodi
        If Not String.IsNullOrEmpty(KdProdiDariForm) Then
            CBNamaJurusanData.SelectedValue = KdProdiDariForm
            LBKodeDataTransaksi.Text = KdProdiDariForm
        End If

        ' Sinkronisasi Semester
        If Not String.IsNullOrEmpty(SemesterDariForm) AndAlso SemesterDariForm <> "ALL" Then
            CMBSEMESTERData.SelectedIndex = CMBSEMESTERData.FindStringExact(SemesterDariForm)
        End If

        ' 6. PENANGANAN KODE PENGAMPU
        If IsEditMode Then
            ' Jika mode UBAH, pastikan ComboBox Kelas juga sinkron dengan teks yang sudah masuk
            If Not String.IsNullOrEmpty(CMBKelasData.Text) Then
                CMBKelasData.SelectedIndex = CMBKelasData.FindStringExact(CMBKelasData.Text)
            End If
            ' BTNHapusTransaksi diaktifkan jika mode ubah
            BTNHapusTransaksi.Enabled = True
        Else
            ' Jika mode TAMBAH, panggil kode otomatis jika belum terisi
            ' (Hanya jika belum terisi oleh SelectedIndexChanged prodi)
            If LBKodePengampu.Text = "..." Or LBKodePengampu.Text = "" Then
                Call BuatKodePengampuOtomatis()
            End If
            BTNHapusTransaksi.Enabled = False
        End If
    End Sub
    ' Fungsi untuk mengisi DataSource Prodi
    Sub SetDaftarProdi()
        Call KoneksiDb()
        Try
            Dim DT As New DataTable
            ' Gunakan Order By Kd_Prodi agar urutan konsisten dengan Form Utama
            QUERY = "SELECT Kd_Prodi, Nm_Prodi FROM tbl_prodi ORDER BY Kd_Prodi"
            Using DA As New MySqlDataAdapter(QUERY, DbKoneksi)
                DA.Fill(DT)
            End Using

            CBNamaJurusanData.DataSource = DT
            CBNamaJurusanData.DisplayMember = "Nm_Prodi"
            CBNamaJurusanData.ValueMember = "Kd_Prodi"

            ' Jangan set SelectedIndex = -1 di sini karena akan menghapus kiriman dari Form Utama
        Catch ex As Exception
            MsgBox("Gagal memuat daftar prodi: " & ex.Message)
        End Try
    End Sub
    Sub SetProdiOtomatis(KdProdi As String)
        Call KoneksiDb()

        QUERY = "SELECT Kd_Prodi, Nm_Prodi FROM tbl_prodi ORDER BY Nm_Prodi"

        Dim DT As New DataTable
        Using DA As New MySqlDataAdapter(QUERY, DbKoneksi)
            DA.Fill(DT)
        End Using

        CBNamaJurusanData.DataSource = DT
        CBNamaJurusanData.DisplayMember = "Nm_Prodi"
        CBNamaJurusanData.ValueMember = "Kd_Prodi"

        CBNamaJurusanData.SelectedValue = KdProdi
    End Sub

    Sub TampilNamaProdi()
        Call KoneksiDb()

        Try
            QUERY = "SELECT Nm_Prodi FROM tbl_prodi ORDER BY Kd_Prodi"

            Using CMD As New MySqlCommand(QUERY, DbKoneksi)
                Using DR = CMD.ExecuteReader()
                    CBNamaJurusanData.Items.Clear()

                    While DR.Read()
                        CBNamaJurusanData.Items.Add(DR("Nm_Prodi").ToString())
                    End While
                End Using
            End Using

        Catch ex As Exception
            MsgBox("Gagal menampilkan nama prodi: " & ex.Message, vbCritical)
        End Try
    End Sub

    Sub SetMatakuliahOtomatis(KdMatkul As String)
        Try
            Call KoneksiDb()

            ' Query mengambil detail matakuliah
            QUERY = "SELECT Nm_Matakuliah, Sks_Matakuliah, Teori_Matakuliah, " &
                "Praktek_Matakuliah, Semester_Matakuliah " &
                "FROM tbl_matakuliah WHERE Kd_Matakuliah = @KdMatkul"

            Using CMD As New MySqlCommand(QUERY, DbKoneksi)
                CMD.Parameters.AddWithValue("@KdMatkul", KdMatkul)

                Using DR As MySqlDataReader = CMD.ExecuteReader()
                    If DR.Read() Then
                        ' === ISI KE LABEL OTOMATIS ===
                        LBNamaMatakuliah.Text = DR("Nm_Matakuliah").ToString()
                        LBSKSData.Text = DR("Sks_Matakuliah").ToString()
                        LBSKSTeoriData.Text = DR("Teori_Matakuliah").ToString()
                        LBSKSPraktekData.Text = DR("Praktek_Matakuliah").ToString()

                        ' Mengisi Label Angka Semester (misal: 1, 2, 3...)
                        LBSemesterData.Text = DR("Semester_Matakuliah").ToString()
                    Else
                        ' === KOSONGKAN JIKA TIDAK ADA ===
                        LBNamaMatakuliah.Text = "-"
                        LBSKSData.Text = "0"
                        LBSKSTeoriData.Text = "0"
                        LBSKSPraktekData.Text = "0"
                        LBSemesterData.Text = "0"

                        MsgBox("Kode Matakuliah tidak ditemukan!", vbExclamation)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error Matkul Otomatis: " & ex.Message, vbCritical)
        End Try
    End Sub

    Sub SetDosenOtomatis(KdDosen As String)
        Try
            Call KoneksiDb()
            ' Query untuk mengambil NIDN dan Nama Dosen
            QUERY = "SELECT Nidn_Dosen, Nm_Dosen FROM tbl_dosen WHERE Kd_Dosen = @KdDosen"

            Using CMD As New MySqlCommand(QUERY, DbKoneksi)
                CMD.Parameters.AddWithValue("@KdDosen", KdDosen)

                Using DR As MySqlDataReader = CMD.ExecuteReader()
                    If DR.Read() Then
                        ' === DATA DITEMUKAN: ISI KE LABEL ===
                        LBNIDNData.Text = DR("Nidn_Dosen").ToString()
                        LBNamaDosen.Text = DR("Nm_Dosen").ToString()
                    Else
                        ' === DATA TIDAK ADA: KOSONGKAN LABEL ===
                        LBNIDNData.Text = "-"
                        LBNamaDosen.Text = "-"
                        MsgBox("Kode Dosen '" & KdDosen & "' tidak ditemukan dalam database!", vbExclamation, "Data Tidak Ada")
                        TXTNomorIdentitas.Focus()
                    End If
                End Using
            End Using

        Catch ex As Exception
            MsgBox("Gagal mengambil data dosen: " & ex.Message, vbCritical)
        Finally
            ' Pastikan koneksi ditutup jika diperlukan, tergantung struktur koneksi Anda
        End Try
    End Sub

    Private Sub CBNamaJurusanData_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBNamaJurusanData.SelectedIndexChanged
        ' 1. Validasi agar tidak error saat DataSource sedang dimuat
        If CBNamaJurusanData.SelectedValue IsNot Nothing AndAlso Not CBNamaJurusanData.SelectedValue.ToString.Contains("DataRowView") Then

            ' Tampilkan Kode Prodi di label kecil
            LBKodeDataTransaksi.Text = CBNamaJurusanData.SelectedValue.ToString()

            ' 🟢 PERBAIKAN: Gunakan IsEditMode sebagai penjaga
            ' Jika IsEditMode = True (berarti sedang Double Click/Ubah), JANGAN buat kode baru.
            If IsEditMode = False Then
                Call BuatKodePengampuOtomatis()
            End If

        End If
    End Sub

    Sub BuatKodePengampuOtomatis()
        Call KoneksiDb()
        Try
            ' Nama kolom diganti menjadi KdPengampu sesuai hasil DESC database Anda
            QUERY = "SELECT MAX(CAST(SUBSTRING(KdPengampu, 4) AS UNSIGNED)) FROM tbl_pengampu_matakuliah"

            Using CMD As New MySqlCommand(QUERY, DbKoneksi)
                Dim hasil = CMD.ExecuteScalar()
                Dim noUrut As Integer

                If hasil Is DBNull.Value Or hasil Is Nothing Then
                    noUrut = 1
                Else
                    noUrut = Convert.ToInt32(hasil) + 1
                End If

                ' Format: PMK + 4 digit angka (Contoh: PMK0001, PMK0028)
                LBKodePengampu.Text = "PMK" & noUrut.ToString("0000")
            End Using

        Catch ex As Exception
            MsgBox("Gagal generate kode: " & ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub BTNKeluarTransaksi_Click(sender As Object, e As EventArgs) Handles BTNKeluarTransaksi.Click
        If BTNKeluarTransaksi.Text = "&KELUAR" Then
            If MsgBox("Anda yakin ingin exit?", vbQuestion + vbYesNo, "Informasi") = vbYes Then
                Me.Close()
            End If
        Else
            BTNSimpanDataTransaksiDosen.BackColor = Color.Red
            BTNSimpanDataTransaksiDosen.Enabled = False
            BTNHapusTransaksi.BackColor = Color.Red
            BTNKeluarTransaksi.Text = "&KELUAR"
        End If
    End Sub

    Private Sub BTNCariKodeDosen_Click(sender As Object, e As EventArgs) Handles BTNCariKodeDosen.Click
        ' Validasi jika TextBox kosong
        If TXTNomorIdentitas.Text.Trim() = "" Then
            MessageBox.Show("Silakan isi Kode Dosen (Nomor Identitas) terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TXTNomorIdentitas.Focus()
            Exit Sub
        End If

        ' Panggil Sub untuk mengisi label otomatis berdasarkan kode dosen yang diinput
        Call SetDosenOtomatis(TXTNomorIdentitas.Text.Trim())
    End Sub

    Private Sub TXTNomorIdentitas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTNomorIdentitas.KeyPress
        ' Jika tombol yang ditekan adalah ENTER (Ascii 13)
        If Asc(e.KeyChar) = 13 Then
            BTNCariKodeDosen.PerformClick()
        End If
    End Sub

    Private Sub BTNCariKodeMatkul_Click(sender As Object, e As EventArgs) Handles BTNCariKodeMatkul.Click
        ' Validasi jika TextBox Kode Matkul kosong
        If TXTKodeMatkul.Text.Trim() = "" Then
            MessageBox.Show("Silakan isi Kode Matakuliah terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TXTKodeMatkul.Focus()
            Exit Sub
        End If

        ' Panggil Sub untuk mengisi label otomatis berdasarkan kode matkul yang diinput
        Call SetMatakuliahOtomatis(TXTKodeMatkul.Text.Trim())
    End Sub

    ' Contoh validasi sederhana saat user selesai mengetik
    Private Sub TXTTahunAkademik_Leave(sender As Object, e As EventArgs) Handles TXTTahunAkademik.Leave
        If TXTTahunAkademik.Text <> "" AndAlso Not TXTTahunAkademik.Text.Contains("/") Then
            MsgBox("Format Tahun Akademik disarankan: 2024/2025", vbInformation)
        End If
    End Sub

    Private Sub BTNSimpanDataTransaksiDosen_Click(sender As Object, e As EventArgs) Handles BTNSimpanDataTransaksiDosen.Click
        Try
            ' 1. VALIDASI INPUT
            If TXTNomorIdentitas.Text = "" Or TXTKodeMatkul.Text = "" Or TXTTahunAkademik.Text = "" Then
                MsgBox("Mohon lengkapi data terlebih dahulu!", vbExclamation, "Peringatan")
                Exit Sub
            End If

            Call KoneksiDb()
            Dim sql As String = ""

            ' 2. MODE SIMPAN / UBAH
            If BTNSimpanDataTransaksiDosen.Text.Contains("SIMPAN") Then
                sql = "INSERT INTO tbl_pengampu_matakuliah (KdPengampu, Kd_Dosen, Kd_Matakuliah, Nama_Kelas, Tahun_Akademik) " &
                  "VALUES (@kdP, @kdD, @kdM, @kls, @thn)"
            Else
                sql = "UPDATE tbl_pengampu_matakuliah SET Kd_Dosen=@kdD, Kd_Matakuliah=@kdM, " &
                  "Nama_Kelas=@kls, Tahun_Akademik=@thn WHERE KdPengampu=@kdP"
            End If

            Using CMD As New MySqlCommand(sql, DbKoneksi)
                CMD.Parameters.AddWithValue("@kdP", LBKodePengampu.Text)
                CMD.Parameters.AddWithValue("@kdD", TXTNomorIdentitas.Text)
                CMD.Parameters.AddWithValue("@kdM", TXTKodeMatkul.Text)
                CMD.Parameters.AddWithValue("@kls", CMBKelasData.Text)
                CMD.Parameters.AddWithValue("@thn", TXTTahunAkademik.Text)
                CMD.ExecuteNonQuery()
            End Using

            ' 3. PROSES REFRESH DATA (Kunci agar data langsung muncul)
            ' Kita gunakan blok Try-Catch kecil untuk memastikan form utama ditemukan
            Try
                ' A. Hapus Cache agar form mengambil data segar dari Database
                FrmTransaksiDosen.PageCache.Clear()

                ' B. Jika simpan baru, arahkan ke halaman 1 (biasanya data terbaru muncul di sana/tergantung Order By)
                ' Jika Anda ingin data terbaru di baris paling atas, pastikan Query di LoadPage menggunakan ORDER BY KdPengampu DESC

                ' C. Panggil prosedur refresh yang sudah kita buat di Form Utama
                FrmTransaksiDosen.RefreshPaging()
            Catch ex As Exception
                ' Log error jika form utama tidak merespon
            End Try

            MsgBox("Data berhasil disimpan dan daftar telah diperbarui!", vbInformation, "Sukses")
            Me.Close()

        Catch ex As Exception
            MsgBox("Gagal menyimpan data: " & ex.Message, vbCritical, "Error")
        Finally
            If DbKoneksi.State = ConnectionState.Open Then DbKoneksi.Close()
        End Try
    End Sub

    Private Sub BTNHapusTransaksi_Click(sender As Object, e As EventArgs) Handles BTNHapusTransaksi.Click
        Try
            ' 1. Pastikan Kode Pengampu tidak kosong
            If String.IsNullOrEmpty(LBKodePengampu.Text) Then
                MsgBox("Pilih data yang akan dihapus terlebih dahulu!", vbExclamation, "Peringatan")
                Exit Sub
            End If

            ' 2. Konfirmasi Hapus
            Dim Konfirmasi As DialogResult
            Konfirmasi = MessageBox.Show($"Anda yakin akan menghapus data pengampu dengan kode {LBKodePengampu.Text}?",
                                     "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If Konfirmasi = DialogResult.Yes Then
                Call KoneksiDb()

                ' 3. Hapus data berdasarkan Kode Pengampu (Bukan Kode Matkul)
                Dim SQLHapus As String = "DELETE FROM tbl_pengampu_matakuliah WHERE KdPengampu = @Kd"

                Using CMD As New MySqlCommand(SQLHapus, DbKoneksi)
                    CMD.Parameters.AddWithValue("@Kd", LBKodePengampu.Text)

                    Dim rowsAffected As Integer = CMD.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        ' ✅ 4. MEMBERSIHKAN CACHE (Sangat Penting!)
                        ' Agar grid di form utama menarik data segar dari MySQL
                        If FrmTransaksiDosen.PageCache IsNot Nothing Then
                            FrmTransaksiDosen.PageCache.Clear()
                        End If

                        MsgBox("Data transaksi pengampu berhasil dihapus.", vbInformation, "Sukses")

                        ' 5. REFRESH FORM UTAMA
                        ' Update total data dan gambar ulang grid
                        FrmTransaksiDosen.HitungTotalData()
                        FrmTransaksiDosen.TampilkanDataGridTransaksiPengampu()

                        ' 6. Tutup Form Input
                        Me.Close()
                    Else
                        MsgBox("Data tidak ditemukan atau sudah dihapus sebelumnya.", vbExclamation, "Gagal")
                    End If
                End Using
            End If

        Catch ex As Exception
            MsgBox("Gagal menghapus data transaksi: " & ex.Message, vbCritical, "Error")
        Finally
            ' Tutup koneksi jika diperlukan sesuai struktur koneksi Anda
        End Try
    End Sub
End Class