Imports MySql.Data.MySqlClient
Public Class FrmBiodataDosen

    Public KdProdidariForm As String = ""


    ' === Load Form ===
    Private Sub FrmBiodataDosen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Call KoneksiDb()
            Call JenisKelamin()

            '🔹 JIKA DATANG DARI FRMDATADOSENPAGGING (SUDAH DIFILTER)
            If KdProdidariForm <> "" Then
                'isi nama prodi & kode prodi otomatis
                CMD = New MySqlCommand(
                "SELECT Nm_Prodi FROM tbl_prodi WHERE Kd_Prodi = @KdProdi",
                DbKoneksi)

                CMD.Parameters.AddWithValue("@KdProdi", KdProdidariForm)
                DR = CMD.ExecuteReader()

                If DR.Read() Then
                    CMBJurusan.Items.Clear()
                    CMBJurusan.Items.Add(DR("Nm_Prodi").ToString())
                    CMBJurusan.SelectedIndex = 0

                    LBKodeProdi.Text = KdProdidariForm
                    Call SetProdiOtomatis(KdProdidariForm)
                    CMBJurusan.Enabled = False '🔒 kunci karena sudah difilter
                End If
                DR.Close()

            Else
                '🔹 JIKA FORM DIBUKA LANGSUNG (TIDAK DARI PAGGING)
                Call TampilNamaProdi()
            End If

        Catch ex As Exception
            MsgBox("Terjadi kesalahan saat load form: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub

    ' === ComboBox Jenis Kelamin ===
    Sub JenisKelamin()
        CMBJKDosen.Items.Clear()
        CMBJKDosen.Items.Add("LAKI-LAKI")
        CMBJKDosen.Items.Add("PEREMPUAN")
    End Sub

    Sub TampilNamaProdi()
        Call KoneksiDb()

        Dim DA As New MySqlDataAdapter(
        "SELECT Kd_Prodi, Nm_Prodi FROM tbl_prodi ORDER BY Kd_Prodi",
        DbKoneksi)

        Dim DT As New DataTable
        DA.Fill(DT)

        CMBJurusan.DataSource = DT
        CMBJurusan.DisplayMember = "Nm_Prodi"
        CMBJurusan.ValueMember = "Kd_Prodi"
        CMBJurusan.SelectedIndex = -1
    End Sub


    ' === Tombol Batal / Keluar ===
    Private Sub BTNKELUARBiodata_Click(sender As Object, e As EventArgs) Handles BTNKELUARBiodata.Click
        If BTNKELUARBiodata.Text = "&KELUAR" Then
            If MsgBox("Anda yakin ingin exit?", vbQuestion + vbYesNo, "Informasi") = vbYes Then
                Me.Close()
            End If
        Else
            BTNSIMPANBiodata.BackColor = Color.Red
            BTNSIMPANBiodata.Enabled = False
            BTNHAPUSBiodata.BackColor = Color.Red
            BTNKELUARBiodata.Text = "&KELUAR"
        End If
    End Sub



    ' === Tombol Simpan / Ubah ===
    Private Sub BTNSIMPANBiodata_Click(sender As Object, e As EventArgs) Handles BTNSIMPANBiodata.Click
        Try
            ' 🔴 VALIDASI INPUT
            If Not ValidasiInputDosen() Then Exit Sub
            Call KoneksiDb()

            ' 🔹 tetap pakai query INSERT / UPDATE seperti sebelumnya
            Dim sql As String = ""
            If BTNSIMPANBiodata.Text = "&SIMPAN" Then
                sql = "INSERT INTO tbl_dosen (Kd_Dosen, Kd_Prodi, Nidn_Dosen, Nm_Dosen, JK_Dosen, NoHP_Dosen, Email_Dosen) " &
                      "VALUES (@KdDosen, @KdProdi, @Nidn, @Nama, @JK, @NoHp, @Email)"
            ElseIf BTNSIMPANBiodata.Text = "&UBAH" Then
                sql = "UPDATE tbl_dosen SET " &
                      "Kd_Prodi = @KdProdi, Nidn_Dosen = @Nidn, Nm_Dosen = @Nama, " &
                      "JK_Dosen = @JK, NoHP_Dosen = @NoHp, Email_Dosen = @Email " &
                      "WHERE Kd_Dosen = @KdDosen"
            End If

            CMD = New MySqlCommand(sql, DbKoneksi)
            CMD.Parameters.AddWithValue("@KdDosen", LBKodeDosen.Text)
            CMD.Parameters.AddWithValue("@KdProdi", LBKodeProdi.Text)  ' ✅ tetap pakai kode prodi sesuai combobox
            CMD.Parameters.AddWithValue("@Nidn", TXTNIDN.Text)
            CMD.Parameters.AddWithValue("@Nama", TXTNamaDosen.Text)
            CMD.Parameters.AddWithValue("@JK", CMBJKDosen.Text)
            CMD.Parameters.AddWithValue("@NoHp", If(TXTNoHp.Text = "", DBNull.Value, TXTNoHp.Text))
            CMD.Parameters.AddWithValue("@Email", If(TXTEmailDosen.Text = "", DBNull.Value, TXTEmailDosen.Text))
            CMD.ExecuteNonQuery()

            ' 🔹 Tampilkan pesan jika ubah
            If BTNSIMPANBiodata.Text = "&UBAH" Then
                MsgBox("Data berhasil diubah.", vbInformation, "Informasi")
            End If

            ' 🔹 REFRESH DATAGRID SESUAI PRODI BARU
            If FrmDataDosenPagging IsNot Nothing Then
                FrmDataDosenPagging.SetFilterProdiDanRefresh(LBKodeProdi.Text)
            End If

            Me.Close() ' tutup form

        Catch ex As Exception
            MsgBox("Gagal menyimpan data: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub

    ' === Tombol Hapus ===
    Private Sub BTNHAPUSBiodata_Click(sender As Object, e As EventArgs) Handles BTNHAPUSBiodata.Click
        Try
            Call KoneksiDb()
            Dim Konfirmasi As String
            Konfirmasi = MsgBox("Anda yakin akan menghapus data ini?", vbYesNo + vbQuestion, "Informasi")

            If Konfirmasi = vbYes Then
                SQLHapus = "DELETE FROM tbl_dosen WHERE Kd_Dosen = @KdDosen"
                CMD = New MySqlCommand(SQLHapus, DbKoneksi)
                CMD.Parameters.AddWithValue("@KdDosen", LBKodeDosen.Text)
                CMD.ExecuteNonQuery()

                ' Refresh DataGrid jika FrmDataDosenPagging terbuka
                If FrmDataDosenPagging IsNot Nothing Then
                    FrmDataDosenPagging.TampilkanDataGridDosen()
                End If

                ' Tombol tetap diatur sesuai permintaan
                BTNSIMPANBiodata.Enabled = False
                BTNSIMPANBiodata.BackColor = Color.Red

                BTNHAPUSBiodata.Enabled = False
                BTNHAPUSBiodata.BackColor = Color.Red

            Else
                If FrmDataDosenPagging IsNot Nothing Then
                    FrmDataDosenPagging.TampilkanDataGridDosen()
                End If

                BTNHAPUSBiodata.Enabled = False
                BTNHAPUSBiodata.BackColor = Color.Red
            End If

        Catch ex As Exception
            MsgBox("Gagal menghapus data: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub CMBJurusan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBJurusan.SelectedIndexChanged
        If CMBJurusan.SelectedIndex < 0 Then Exit Sub
        If CMBJurusan.SelectedValue Is Nothing Then Exit Sub

        LBKodeProdi.Text = CMBJurusan.SelectedValue.ToString()
    End Sub

    Private Sub CMBJurusan_DropDown(sender As Object, e As EventArgs) Handles CMBJurusan.DropDown
        'Jangan reset pilihan jika sudah dikunci dari filter
        If KdProdidariForm <> "" Then Exit Sub
    End Sub

    Sub SetProdiOtomatis(KdProdi As String)
        Try
            Call KoneksiDb()

            CMD = New MySqlCommand(
            "SELECT Kd_Prodi, Nm_Prodi FROM tbl_prodi WHERE Kd_Prodi=@KdProdi",
            DbKoneksi)

            CMD.Parameters.AddWithValue("@KdProdi", KdProdi)
            DR = CMD.ExecuteReader()

            If DR.Read() Then
                LBKodeProdi.Text = DR("Kd_Prodi").ToString()
                CMBJurusan.SelectedValue = DR("Kd_Prodi").ToString() '🔥 INTI FIX
            End If

            DR.Close()
        Catch ex As Exception
            MsgBox("Gagal set Prodi otomatis: " & ex.Message, vbCritical)
        End Try
    End Sub


    Function ValidasiInputDosen() As Boolean
        ErrorProvider1.Clear()

        If TXTNIDN.Text.Trim = "" Then
            ErrorProvider1.SetError(TXTNIDN, "NIDN wajib diisi ❌")
            TXTNIDN.Focus()
            Return False
        End If

        If TXTNamaDosen.Text.Trim = "" Then
            ErrorProvider1.SetError(TXTNamaDosen, "Nama dosen wajib diisi ❌")
            TXTNamaDosen.Focus()
            Return False
        End If

        If CMBJKDosen.Text = "" Then
            ErrorProvider1.SetError(CMBJKDosen, "Pilih jenis kelamin ❌")
            CMBJKDosen.Focus()
            Return False
        End If

        If TXTNoHp.Text.Trim = "" Then
            ErrorProvider1.SetError(TXTNoHp, "No HP wajib diisi ❌")
            TXTNoHp.Focus()
            Return False
        End If

        If TXTEmailDosen.Text.Trim = "" Then
            ErrorProvider1.SetError(TXTEmailDosen, "Email wajib diisi ❌")
            TXTEmailDosen.Focus()
            Return False
        End If

        ' 🔴 VALIDASI EMAIL KHUSUS @gmail.com
        If Not TXTEmailDosen.Text.ToLower.EndsWith("@gmail.com") Then
            ErrorProvider1.SetError(
            TXTEmailDosen,
            "Email harus menggunakan @gmail.com ❌"
        )
            TXTEmailDosen.Focus()
            Return False
        End If

        Return True
    End Function

    '================ ANGKA SAJA =================
    Private Sub TXTNIDN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTNIDN.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.Handled = True
    End Sub

    Private Sub TXTNoHp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTNoHp.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.Handled = True
    End Sub



End Class