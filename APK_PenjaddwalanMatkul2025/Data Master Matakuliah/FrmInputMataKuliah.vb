Imports MySql.Data.MySqlClient
Public Class FrmInputMataKuliah
    ' Menyimpan kode prodi yang dikirim dari FrmDataMataKuliah
    Public KdProdidariForm As String = ""

    '=========================================================
    ' Event     : FrmInputDataMataKuliah_Load
    ' Fungsi    : Menangani proses awal saat form input
    '             data matakuliah dibuka.
    ' Tujuan    :
    '   1. Membuka koneksi database
    '   2. Mengisi ComboBox Prodi
    '   3. Mengunci pilihan prodi jika data
    '      berasal dari FrmDataMataKuliah (paging)
    '=========================================================
    Private Sub FrmInputDataMataKuliah_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Call KoneksiDb()

            ' JIKA ADA DATA DARI FILTER FORM MASTER
            If KdProdidariForm <> "" Then
                ' Set Kode Prodi ke Label
                LBKDPRODIMATKUL.Text = KdProdidariForm

                ' Pastikan pilihan angka semester tersedia di background (Ganjil atau Genap)
                ' agar saat .Text diisi dari Form Master, angkanya tidak ditolak
                If CMBSEMESTER.Text = "GANJIL" Then
                    CMBSemesterMatkul.Items.Clear()
                    CMBSemesterMatkul.Items.AddRange(New Object() {"1", "3", "5", "7"})
                ElseIf CMBSEMESTER.Text = "GENAP" Then
                    CMBSemesterMatkul.Items.Clear()
                    CMBSemesterMatkul.Items.AddRange(New Object() {"2", "4", "6", "8"})
                End If

                ' Pastikan Enabled tetap True
                CMBProdiMatkul.Enabled = True
                CMBSEMESTER.Enabled = True
                CMBSemesterMatkul.Enabled = True
            Else
                ' JIKA DIBUKA TANPA FILTER (NORMAL)
                Call TampilNamaProdi()
                Call SemesterGanjilGenap()
            End If

        Catch ex As Exception
            MsgBox("Error Load Form Input: " & ex.Message, vbCritical)
        End Try
    End Sub

    '=========================================================
    ' Procedure : SemesterGanjilGenap
    ' Fungsi    : Mengisi ComboBox jenis semester
    '             (GANJIL / GENAP)
    '=========================================================
    Sub SemesterGanjilGenap()
        CMBSEMESTER.Items.Clear()
        CMBSEMESTER.Items.Add("GANJIL")
        CMBSEMESTER.Items.Add("GENAP")
        CMBSEMESTER.SelectedIndex = -1

        CMBSemesterMatkul.Items.Clear()
        CMBSemesterMatkul.SelectedIndex = -1
    End Sub


    '=========================================================
    ' Procedure : TampilNamaProdi
    ' Fungsi    : Menampilkan daftar nama prodi
    '             ke dalam ComboBox Jurusan
    ' Tujuan    : Digunakan saat input data matakuliah
    '             tanpa filter dari form sebelumnya
    '=========================================================
    Sub TampilNamaProdi()
        Call KoneksiDb()

        Dim DA As New MySqlDataAdapter(
        "SELECT Kd_Prodi, Nm_Prodi 
         FROM tbl_prodi 
         ORDER BY Kd_Prodi",
        DbKoneksi)

        Dim DT As New DataTable
        DA.Fill(DT)

        CMBProdiMatkul.DataSource = DT
        CMBProdiMatkul.DisplayMember = "Nm_Prodi"
        CMBProdiMatkul.ValueMember = "Kd_Prodi"
        CMBProdiMatkul.SelectedIndex = -1
    End Sub

    '=========================================================
    ' Event     : BTNKELUARInput_Click
    ' Fungsi    : Membatalkan proses input atau keluar form
    ' Tujuan    : Mengatur status tombol & keluar form
    '=========================================================
    Private Sub BTNKELUARMatkul_Click(sender As Object, e As EventArgs) Handles BTNKeluarMatkul.Click
        If BTNKeluarMatkul.Text = "&KELUAR" Then
            If MsgBox("Anda yakin ingin exit?", vbQuestion + vbYesNo, "Informasi") = vbYes Then
                Me.Close()
            End If
        Else
            BTNSimpanMatkul.BackColor = Color.Red
            BTNSimpanMatkul.Enabled = False
            BTNHapusMatkul.BackColor = Color.Red
            BTNKeluarMatkul.Text = "&KELUAR"
        End If
    End Sub

    '=========================================================
    ' Event     : BTNSIMPANInput_Click
    ' Fungsi    : Menyimpan atau mengubah data matakuliah
    ' Tujuan    : Insert / Update data ke tbl_matakuliah
    '=========================================================
    Private Sub BTNSIMPANMatkul_Click(sender As Object, e As EventArgs) Handles BTNSimpanMatkul.Click
        Try
            ' 🔴 VALIDASI INPUT
            If Not ValidasiInputMataKuliah() Then Exit Sub
            Call KoneksiDb()

            Dim sql As String = ""

            ' 🔹 MODE SIMPAN / UBAH
            If BTNSimpanMatkul.Text = "&SIMPAN" Then
                sql = "INSERT INTO tbl_matakuliah (Kd_Matakuliah, Nm_Matakuliah, Sks_Matakuliah, Teori_Matakuliah, Praktek_Matakuliah, Semester_Matakuliah, Kd_Prodi) " &
                  "VALUES (@KdMatkul, @NamaMatkul, @SKS, @Teori, @Praktek, @Semester, @KdProdi)"
            Else
                sql = "UPDATE tbl_matakuliah SET Nm_Matakuliah=@NamaMatkul, Sks_Matakuliah=@SKS, Teori_Matakuliah=@Teori, " &
                  "Praktek_Matakuliah=@Praktek, Semester_Matakuliah=@Semester, Kd_Prodi=@KdProdi WHERE Kd_Matakuliah=@KdMatkul"
            End If

            CMD = New MySqlCommand(sql, DbKoneksi)
            CMD.Parameters.AddWithValue("@KdMatkul", TXTKodeMatkul.Text)
            CMD.Parameters.AddWithValue("@NamaMatkul", TXTNamaMatkul.Text)
            CMD.Parameters.AddWithValue("@SKS", TXTSKS.Text)
            CMD.Parameters.AddWithValue("@Teori", TXTTeoriMatkul.Text)
            CMD.Parameters.AddWithValue("@Praktek", TXTPraktekMatkul.Text)
            CMD.Parameters.AddWithValue("@Semester", CMBSemesterMatkul.Text)
            CMD.Parameters.AddWithValue("@KdProdi", LBKDPRODIMATKUL.Text)
            CMD.ExecuteNonQuery()

            ' 🔹 REFRESH FORM MASTER
            ' Mencari form data matakuliah yang sedang terbuka
            Dim frmMaster As FrmDataMataKuliah = My.Application.OpenForms.OfType(Of FrmDataMataKuliah)().FirstOrDefault()

            If frmMaster IsNot Nothing Then
                ' Panggil fungsi refresh yang sudah kita buat di langkah 1
                frmMaster.SetFilterProdiDanRefresh(LBKDPRODIMATKUL.Text)
            End If

            MsgBox("Data berhasil disimpan dan daftar telah diperbarui!", vbInformation, "Sukses")
            Me.Close()

        Catch ex As Exception
            MsgBox("Gagal menyimpan data: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub

    '=========================================================
    ' Event     : BTNHAPUSInput_Click
    ' Fungsi    : Menghapus data matakuliah
    '=========================================================
    Private Sub BTNHapusMatkul_Click(sender As Object, e As EventArgs) Handles BTNHapusMatkul.Click
        Try
            Call KoneksiDb()
            Dim Konfirmasi As String
            Konfirmasi = MsgBox("Anda yakin akan menghapus data ini?", vbYesNo + vbQuestion, "Informasi")

            If Konfirmasi = vbYes Then
                ' Hapus data dari database
                SQLHapus = "DELETE FROM tbl_matakuliah WHERE Kd_Matakuliah = @KdMatkul"
                CMD = New MySqlCommand(SQLHapus, DbKoneksi)
                CMD.Parameters.AddWithValue("@KdMatkul", TXTKodeMatkul.Text)
                CMD.ExecuteNonQuery()

                ' Pesan berhasil
                MsgBox("Data matakuliah berhasil dihapus.", vbInformation, "Informasi")

                ' Refresh DataGrid jika FrmDataMataKuliah terbuka
                If FrmDataMataKuliah IsNot Nothing Then
                    FrmDataMataKuliah.TampilkanDataGridMatakuliah()
                End If

                ' Nonaktifkan tombol setelah hapus
                BTNSimpanMatkul.Enabled = False
                BTNSimpanMatkul.BackColor = Color.Red

                BTNHapusMatkul.Enabled = False
                BTNHapusMatkul.BackColor = Color.Red

                ' ✅ Tutup form langsung setelah hapus
                Me.Close()
            End If

        Catch ex As Exception
            MsgBox("Gagal menghapus data: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub CMBProdiMatkul_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBProdiMatkul.SelectedIndexChanged
        If CMBProdiMatkul.SelectedIndex < 0 Then Exit Sub
        If CMBProdiMatkul.SelectedValue Is Nothing Then Exit Sub

        LBKDPRODIMATKUL.Text = CMBProdiMatkul.SelectedValue.ToString()
    End Sub

    Private Sub CMBProdiMatkul_DropDown(sender As Object, e As EventArgs) Handles CMBProdiMatkul.DropDown
        ' Jangan reset pilihan jika sudah dikunci dari filter
        If KdProdidariForm <> "" Then Exit Sub
    End Sub

    '=========================================================
    ' Procedure : SetProdiOtomatis
    ' Fungsi    : Menyesuaikan ComboBox Prodi otomatis
    '=========================================================
    Sub SetProdiOtomatis(KdProdi As String)
        Try
            Call KoneksiDb()

            CMD = New MySqlCommand(
        "SELECT Kd_Prodi, Nm_Prodi FROM tbl_prodi WHERE Kd_Prodi=@KdProdi",
        DbKoneksi)

            CMD.Parameters.AddWithValue("@KdProdi", KdProdi)
            DR = CMD.ExecuteReader()

            If DR.Read() Then
                LBKDPRODIMATKUL.Text = DR("Kd_Prodi").ToString()
                CMBProdiMatkul.SelectedValue = DR("Kd_Prodi").ToString()
            End If

            DR.Close()
        Catch ex As Exception
            MsgBox("Gagal set Prodi otomatis: " & ex.Message, vbCritical)
        End Try
    End Sub

    '=========================================================
    ' Function  : ValidasiInputMataKuliah
    ' Fungsi    : Validasi form input matakuliah
    '=========================================================
    Function ValidasiInputMataKuliah() As Boolean
        ErrorProvider1.Clear()

        If TXTNamaMatkul.Text.Trim = "" Then
            ErrorProvider1.SetError(TXTNamaMatkul, "Nama matakuliah wajib diisi ❌")
            TXTNamaMatkul.Focus()
            Return False
        End If

        If TXTSKS.Text = "" Then
            ErrorProvider1.SetError(TXTSKS, "SKS wajib dipilih ❌")
            TXTSKS.Focus()
            Return False
        End If

        If CMBSEMESTER.Text = "" Then
            ErrorProvider1.SetError(CMBSEMESTER, "Semester wajib dipilih ❌")
            CMBSEMESTER.Focus()
            Return False
        End If


        If LBKDPRODIMATKUL.Text = "" Then
            ErrorProvider1.SetError(CMBProdiMatkul, "Prodi wajib dipilih ❌")
            CMBProdiMatkul.Focus()
            Return False
        End If

        If CMBSemesterMatkul.Text = "" Then
            ErrorProvider1.SetError(CMBSemesterMatkul, "Semester angka wajib dipilih ❌")
            CMBSemesterMatkul.Focus()
            Return False
        End If

        Return True
    End Function

    Sub HitungMenit()
        Dim teori As Integer = 0
        Dim praktek As Integer = 0

        Integer.TryParse(TXTTeoriMatkul.Text, teori)
        Integer.TryParse(TXTPraktekMatkul.Text, praktek)

        Dim menitTeori As Integer = teori * 50
        Dim menitPraktek As Integer = praktek * 120

        LBMenitTeori.Text = menitTeori & " menit"
        LBMenitPraktek.Text = menitPraktek & " menit"
        LBTotalTeoriPraktek.Text = (menitTeori + menitPraktek) & " menit"
    End Sub


    '=========================================================
    ' Event     : CMBJenisGanjilGenap_SelectedIndexChanged
    ' Fungsi    : Filter isi semester (ganjil / genap)
    '=========================================================
    Private Sub CMBSEMESTER_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBSEMESTER.SelectedIndexChanged
        If CMBSEMESTER.SelectedIndex < 0 Then Exit Sub

        CMBSemesterMatkul.Items.Clear()

        Select Case CMBSEMESTER.Text
            Case "GANJIL"
                CMBSemesterMatkul.Items.Add("1")
                CMBSemesterMatkul.Items.Add("3")
                CMBSemesterMatkul.Items.Add("5")
                CMBSemesterMatkul.Items.Add("7")

            Case "GENAP"
                CMBSemesterMatkul.Items.Add("2")
                CMBSemesterMatkul.Items.Add("4")
                CMBSemesterMatkul.Items.Add("6")
                CMBSemesterMatkul.Items.Add("8")
        End Select

        CMBSemesterMatkul.SelectedIndex = -1
    End Sub

    Private Sub TXTTeoriMatkul_TextChanged(sender As Object, e As EventArgs) Handles TXTTeoriMatkul.TextChanged
        HitungMenit()
    End Sub

    Private Sub TXTPraktekMatkul_TextChanged(sender As Object, e As EventArgs) Handles TXTPraktekMatkul.TextChanged
        HitungMenit()
    End Sub
End Class