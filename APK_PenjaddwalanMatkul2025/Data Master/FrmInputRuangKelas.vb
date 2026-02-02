Imports MySql.Data.MySqlClient
Public Class FrmInputRuangKelas
    '' =========================
    '' VARIABLE YANG WAJIB ADA
    '' =========================
    'Public Mode As String = "SIMPAN"   ' SIMPAN / UBAH
    'Public KdRuangan As String = ""

    '' =========================
    '' FORM LOAD
    '' =========================
    'Private Sub FrmInputRuangKelas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    If Mode = "SIMPAN" Then
    '        Bersih()
    '        AutoKodeRuangan()

    '        BTNSIMPANRUANGKELAS.Text = "SIMPAN"
    '        BTNSIMPANRUANGKELAS.Enabled = True
    '        BTNSIMPANRUANGKELAS.BackColor = Color.Red
    '        BTNSIMPANRUANGKELAS.ForeColor = Color.Black

    '        BTNHAPUSRuangan.Enabled = False
    '        BTNHAPUSRuangan.BackColor = Color.Red
    '        BTNHAPUSRuangan.ForeColor = Color.White

    '        BTNKELUARRuangan.Text = "BATAL"
    '        BTNKELUARRuangan.BackColor = Color.CornflowerBlue
    '        BTNKELUARRuangan.ForeColor = Color.Black

    '    ElseIf Mode = "UBAH" Then
    '        TampilDataRuang()

    '        BTNSIMPANRUANGKELAS.Text = "UBAH"
    '        BTNSIMPANRUANGKELAS.Enabled = True
    '        BTNSIMPANRUANGKELAS.BackColor = Color.CornflowerBlue
    '        BTNSIMPANRUANGKELAS.ForeColor = Color.Black

    '        BTNHAPUSRuangan.Enabled = True
    '        BTNHAPUSRuangan.BackColor = Color.CornflowerBlue
    '        BTNHAPUSRuangan.ForeColor = Color.Black

    '        BTNKELUARRuangan.Text = "BATAL"
    '        BTNKELUARRuangan.BackColor = Color.CornflowerBlue
    '        BTNKELUARRuangan.ForeColor = Color.Black
    '    End If
    'End Sub

    '' =========================
    '' BERSIHKAN FORM
    '' =========================
    'Sub Bersih()
    '    LBKodeRuangan.Text = ""
    '    TXTNamaKelas.Clear()
    '    TXTKapasitas.Clear()
    'End Sub

    '' =========================
    '' AUTO GENERATE KODE RUANGAN
    '' =========================
    'Sub AutoKodeRuangan()
    '    Try
    '        Call KoneksiDb()

    '        CMD = New MySqlCommand(
    '        "SELECT IFNULL(MAX(CAST(SUBSTRING(Kd_Ruangan,2,4) AS UNSIGNED)),0) + 1 
    '         FROM tbl_ruangkelas",
    '        DbKoneksi)

    '        Dim nomor As Integer = CMD.ExecuteScalar()

    '        LBKodeRuangan.Text = "R" & nomor.ToString("0000")

    '    Catch ex As Exception
    '        MsgBox("Gagal generate kode ruangan : " & ex.Message, vbCritical)
    '    End Try
    'End Sub



    '' =========================
    '' TAMPIL DATA (MODE UBAH)
    '' =========================
    'Sub TampilDataRuang()
    '    Try
    '        Call KoneksiDb()

    '        CMD = New MySqlCommand(
    '            "SELECT * FROM tbl_ruangkelas WHERE Kd_Ruangan =@KdRuangan",
    '            DbKoneksi)

    '        CMD.Parameters.AddWithValue("@KdRuangan", KdRuangan)
    '        DR = CMD.ExecuteReader()

    '        If DR.Read() Then
    '            LBKodeRuangan.Text = DR("Kd_Ruangan").ToString()
    '            TXTNamaKelas.Text = DR("Nm_Ruangan").ToString()
    '            TXTKapasitas.Text = DR("Jml_Kapasitas").ToString()
    '        End If

    '        DR.Close()
    '        BTNSIMPANRUANGKELAS.Text = "UBAH"

    '    Catch ex As Exception
    '        MsgBox("Gagal menampilkan data ruang kelas : " & ex.Message, vbCritical)
    '    End Try
    'End Sub

    '' =========================
    '' VALIDASI INPUT
    '' =========================
    'Function ValidasiInput() As Boolean
    '    If TXTNamaKelas.Text.Trim = "" Then
    '        MsgBox("Nama ruangan wajib diisi!", vbExclamation)
    '        TXTNamaKelas.Focus()
    '        Return False
    '    End If

    '    If TXTKapasitas.Text.Trim = "" OrElse Not IsNumeric(TXTKapasitas.Text) Then
    '        MsgBox("Kapasitas harus berupa angka!", vbExclamation)
    '        TXTKapasitas.Focus()
    '        Return False
    '    End If

    '    Return True
    'End Function

    '' =========================
    '' SIMPAN / UBAH
    '' =========================
    'Private Sub BTNSIMPANRUANGKELAS_Click(sender As Object, e As EventArgs) Handles BTNSIMPANRUANGKELAS.Click

    '    If Not ValidasiInput() Then Exit Sub

    '    Try
    '        Call KoneksiDb()

    '        If Mode = "SIMPAN" Then
    '            CMD = New MySqlCommand(
    '            "INSERT INTO tbl_ruangkelas 
    '             (Kd_Ruangan, Nm_Ruangan, Jml_Kapasitas) 
    '             VALUES (@KdRuangan, @NmRuangan, @JmlKapasitas)",
    '            DbKoneksi)

    '            CMD.Parameters.AddWithValue("@KdRuangan", LBKodeRuangan.Text)

    '        Else
    '            CMD = New MySqlCommand(
    '            "UPDATE tbl_ruangkelas SET 
    '             Nm_Ruangan=@NmRuangan,
    '             Jml_Kapasitas=@JmlKapasitas
    '             WHERE Kd_Ruangan=@KdRuangan",
    '            DbKoneksi)

    '            CMD.Parameters.AddWithValue("@KdRuangan", LBKodeRuangan.Text)
    '        End If

    '        CMD.Parameters.AddWithValue("@NmRuangan", TXTNamaKelas.Text.Trim)
    '        CMD.Parameters.AddWithValue("@JmlKapasitas", TXTKapasitas.Text.Trim)

    '        CMD.ExecuteNonQuery()
    '        MsgBox("Data ruang kelas berhasil disimpan!", vbInformation)
    '        Me.Close()

    '    Catch ex As Exception
    '        MsgBox("Gagal menyimpan data : " & ex.Message, vbCritical)
    '    End Try
    'End Sub

    '' =========================
    '' HAPUS
    '' =========================
    'Private Sub BTNHAPUSRuangan_Click(sender As Object, e As EventArgs) Handles BTNHAPUSRuangan.Click

    '    If MsgBox("Yakin ingin menghapus ruang kelas ini?",
    '          vbYesNo + vbQuestion) = vbNo Then Exit Sub

    '    Try
    '        Call KoneksiDb()

    '        CMD = New MySqlCommand(
    '        "DELETE FROM tbl_ruangkelas WHERE Kd_Ruangan=@KdRuangan",
    '        DbKoneksi)

    '        CMD.Parameters.AddWithValue("@KdRuangan", LBKodeRuangan.Text)
    '        CMD.ExecuteNonQuery()

    '        MsgBox("Data ruang kelas berhasil dihapus!", vbInformation)
    '        Me.Close()

    '    Catch ex As Exception
    '        MsgBox("Gagal menghapus data : " & ex.Message, vbCritical)
    '    End Try
    'End Sub

    '' =========================
    '' KELUAR
    '' =========================
    'Private Sub BTNKELUARRuangan_Click(sender As Object, e As EventArgs) Handles BTNKELUARRuangan.Click
    '    If BTNKELUARRuangan.Text = "&KELUAR" Then
    '        If MsgBox("Anda yakin ingin exit?", vbQuestion + vbYesNo, "Informasi") = vbYes Then
    '            Me.Close()
    '        End If
    '    Else
    '        BTNSIMPANRUANGKELAS.BackColor = Color.Red
    '        BTNSIMPANRUANGKELAS.Enabled = False
    '        BTNHAPUSRuangan.BackColor = Color.Red
    '        BTNKELUARRuangan.Text = "&KELUAR"
    '    End If
    'End Sub


    ' PILAR ENKAPSULASI: Komunikasi antar form
    Public Property Mode As String = "SIMPAN"
    Public Property KdRuangan As String = ""

    ' Instansiasi Objek
    Private objRuang As New RuangKelas()
    Private repo As New RuangInputRepository()

    Private Sub FrmInputRuangKelas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Mode = "SIMPAN" Then
            Bersih()
            LBKodeRuangan.Text = repo.GetAutoCode()
            SetupTombol("SIMPAN")
        Else
            ' Data sudah diisi dari FrmRuangKelas via property/objek
            SetupTombol("UBAH")
        End If
    End Sub

    ' --- LOGIKA UI ---
    Sub SetupTombol(st As String)
        If st = "SIMPAN" Then
            BTNSIMPANRUANGKELAS.Text = "SIMPAN"
            BTNSIMPANRUANGKELAS.BackColor = Color.Red
            BTNHAPUSRuangan.Enabled = False
            BTNHAPUSRuangan.BackColor = Color.Red
        Else
            BTNSIMPANRUANGKELAS.Text = "UBAH"
            BTNSIMPANRUANGKELAS.BackColor = Color.CornflowerBlue
            BTNHAPUSRuangan.Enabled = True
            BTNHAPUSRuangan.BackColor = Color.CornflowerBlue
        End If
        BTNKELUARRuangan.Text = "BATAL"
        BTNKELUARRuangan.BackColor = Color.CornflowerBlue
    End Sub

    Sub Bersih()
        TXTNamaKelas.Clear()
        TXTKapasitas.Clear()
        TXTNamaKelas.Focus()
    End Sub

    ' --- VALIDASI & PROSES ---
    Function Validasi() As Boolean
        If TXTNamaKelas.Text.Trim = "" OrElse TXTKapasitas.Text.Trim = "" Then
            MsgBox("Semua data wajib diisi!", vbExclamation)
            Return False
        End If
        If Not IsNumeric(TXTKapasitas.Text) Then
            MsgBox("Kapasitas harus angka!", vbExclamation)
            Return False
        End If
        Return True
    End Function

    Private Sub BTNSIMPANRUANGKELAS_Click(sender As Object, e As EventArgs) Handles BTNSIMPANRUANGKELAS.Click
        If Not Validasi() Then Exit Sub

        Try
            ' Mengisi data ke Objek (OOP)
            objRuang.KodeRuangan = LBKodeRuangan.Text
            objRuang.NamaRuangan = TXTNamaKelas.Text.Trim
            objRuang.Kapasitas = CInt(TXTKapasitas.Text)

            ' Kirim objek ke repository
            repo.Eksekusi(objRuang, Mode)

            MsgBox("Data ruang kelas berhasil diproses!", vbInformation)
            Me.Close()
        Catch ex As Exception
            MsgBox("Gagal simpan: " & ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub BTNHAPUSRuangan_Click(sender As Object, e As EventArgs) Handles BTNHAPUSRuangan.Click
        If MsgBox("Yakin hapus ruangan ini?", vbYesNo + vbQuestion) = vbYes Then
            objRuang.KodeRuangan = LBKodeRuangan.Text
            repo.Eksekusi(objRuang, "HAPUS")
            Me.Close()
        End If
    End Sub

    Private Sub BTNKELUARRuangan_Click(sender As Object, e As EventArgs) Handles BTNKELUARRuangan.Click
        If BTNKELUARRuangan.Text = "&KELUAR" Then
            Me.Close()
        Else
            ' Logika Batal -> Berubah jadi Keluar (Sesuai permintaan Anda)
            BTNSIMPANRUANGKELAS.BackColor = Color.Red
            BTNSIMPANRUANGKELAS.Enabled = False
            BTNHAPUSRuangan.BackColor = Color.Red
            BTNKELUARRuangan.Text = "&KELUAR"
        End If
    End Sub
End Class

Public Class RuangInputRepository
    ' Fungsi untuk Generate Kode Otomatis
    Public Function GetAutoCode() As String
        Dim code As String = "R0001"
        Try
            Call KoneksiDb()
            Dim sql As String = "SELECT IFNULL(MAX(CAST(SUBSTRING(Kd_Ruangan,2,4) AS UNSIGNED)),0) + 1 FROM tbl_ruangkelas"
            Using cmd As New MySqlCommand(sql, DbKoneksi)
                Dim nomor As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                code = "R" & nomor.ToString("0000")
            End Using
        Catch ex As Exception
        End Try
        Return code
    End Function

    ' Eksekusi CRUD menggunakan Objek (Poin 5)
    Public Sub Eksekusi(r As RuangKelas, mode As String)
        Call KoneksiDb()
        Dim sql As String = ""
        If mode = "SIMPAN" Then
            sql = "INSERT INTO tbl_ruangkelas (Kd_Ruangan, Nm_Ruangan, Jml_Kapasitas) VALUES (@id, @nm, @kp)"
        ElseIf mode = "UBAH" Then
            sql = "UPDATE tbl_ruangkelas SET Nm_Ruangan=@nm, Jml_Kapasitas=@kp WHERE Kd_Ruangan=@id"
        Else
            sql = "DELETE FROM tbl_ruangkelas WHERE Kd_Ruangan=@id"
        End If

        Using cmd As New MySqlCommand(sql, DbKoneksi)
            cmd.Parameters.AddWithValue("@id", r.KodeRuangan)
            cmd.Parameters.AddWithValue("@nm", r.NamaRuangan)
            cmd.Parameters.AddWithValue("@kp", r.Kapasitas)
            cmd.ExecuteNonQuery()
        End Using
    End Sub
End Class