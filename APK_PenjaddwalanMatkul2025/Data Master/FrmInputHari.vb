Imports MySql.Data.MySqlClient


Public Class FrmInputHari
    ''MODE FORM
    'Public Mode As String = "SIMPAN"   ' SIMPAN / UBAH
    'Public KdHari As String = ""

    ''========================
    '' FORM LOAD
    ''========================
    'Private Sub FrmInputHari_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    If Mode = "SIMPAN" Then
    '        Bersih()
    '        BTNHapusHari.Enabled = False
    '    Else
    '        TampilDataHari()
    '        BTNHapusHari.Enabled = True
    '    End If
    'End Sub
    'Function GenerateKodeHari(namaHari As String) As String
    '    If namaHari = "Senin" Then
    '        Return "HR001"
    '    ElseIf namaHari = "Selasa" Then
    '        Return "HR002"
    '    ElseIf namaHari = "Rabu" Then
    '        Return "HR003"
    '    ElseIf namaHari = "Kamis" Then
    '        Return "HR004"
    '    ElseIf namaHari = "Jumat" Then
    '        Return "HR005"
    '    ElseIf namaHari = "Minggu" Then
    '        Return "HR006"
    '    ElseIf namaHari = "Sabtu" Then
    '        Return "HR007"
    '    Else
    '        Return ""
    '    End If
    'End Function


    ''========================
    '' BERSIHKAN FORM
    ''========================
    'Sub Bersih()
    '    LBKodeHari.Text = ""
    '    TXTNamaHari.Clear()
    '    BTNSimpanHari.Text = "&SIMPAN"
    'End Sub

    ''========================
    '' TAMPIL DATA (MODE UBAH)
    ''========================
    'Sub TampilDataHari()
    '    Try
    '        Call KoneksiDb()

    '        QUERY = "SELECT * FROM tbl_hari WHERE Id_Hari=@id"
    '        CMD = New MySqlCommand(QUERY, DbKoneksi)
    '        CMD.Parameters.AddWithValue("@id", KdHari)

    '        DR = CMD.ExecuteReader()
    '        If DR.Read() Then
    '            LBKodeHari.Text = DR("Id_Hari").ToString()
    '            TXTNamaHari.Text = DR("Nm_Hari").ToString()
    '        End If
    '        DR.Close()

    '        BTNSimpanHari.Text = "&UBAH"

    '    Catch ex As Exception
    '        MsgBox("Gagal menampilkan data hari : " & ex.Message, vbCritical)
    '    End Try
    'End Sub

    ''========================
    '' VALIDASI DUPLIKAT HARI
    ''========================
    'Function HariSudahAda(namaHari As String) As Boolean
    '    Call KoneksiDb()

    '    If Mode = "SIMPAN" Then
    '        QUERY = "SELECT COUNT(*) FROM tbl_hari WHERE Nm_Hari=@nama"
    '        CMD = New MySqlCommand(QUERY, DbKoneksi)
    '        CMD.Parameters.AddWithValue("@nama", namaHari)
    '    Else
    '        QUERY = "SELECT COUNT(*) FROM tbl_hari 
    '             WHERE Nm_Hari=@nama AND Id_Hari<>@id"
    '        CMD = New MySqlCommand(QUERY, DbKoneksi)
    '        CMD.Parameters.AddWithValue("@nama", namaHari)
    '        CMD.Parameters.AddWithValue("@id", KdHari)
    '    End If

    '    Return CInt(CMD.ExecuteScalar()) > 0
    'End Function

    ''========================
    '' SIMPAN / UBAH DATA
    ''========================
    'Private Sub BTNSimpanHari_Click(sender As Object, e As EventArgs) Handles BTNSimpanHari.Click

    '    'VALIDASI 1: TIDAK BOLEH KOSONG
    '    If TXTNamaHari.Text.Trim() = "" Then
    '        MsgBox("Nama hari wajib diisi!", vbExclamation)
    '        TXTNamaHari.Focus()
    '        Exit Sub
    '    End If

    '    'VALIDASI 2: TIDAK BOLEH ANGKA
    '    If IsNumeric(TXTNamaHari.Text) Then
    '        MsgBox("Nama hari tidak boleh berupa angka!", vbCritical)
    '        TXTNamaHari.Focus()
    '        Exit Sub
    '    End If

    '    'VALIDASI 3: DUPLIKAT
    '    If HariSudahAda(TXTNamaHari.Text.Trim()) Then
    '        MsgBox("Nama hari sudah terdaftar!", vbCritical)
    '        Exit Sub
    '    End If

    '    Try
    '        Call KoneksiDb()

    '        If Mode = "SIMPAN" Then
    '            QUERY = "INSERT INTO tbl_hari (Nm_Hari) VALUES (@nama)"
    '            CMD = New MySqlCommand(QUERY, DbKoneksi)
    '            CMD.Parameters.AddWithValue("@nama", TXTNamaHari.Text.Trim())
    '        Else
    '            QUERY = "UPDATE tbl_hari SET Nm_Hari=@nama WHERE Id_Hari=@id"
    '            CMD = New MySqlCommand(QUERY, DbKoneksi)
    '            CMD.Parameters.AddWithValue("@id", KdHari)
    '            CMD.Parameters.AddWithValue("@nama", TXTNamaHari.Text.Trim())
    '        End If

    '        CMD.ExecuteNonQuery()
    '        MsgBox("Data hari berhasil disimpan!", vbInformation)
    '        Me.Close()

    '    Catch ex As Exception
    '        MsgBox("Gagal menyimpan data : " & ex.Message, vbCritical)
    '    End Try

    'End Sub

    ''========================
    '' HAPUS DATA
    ''========================
    'Private Sub BTNHapusHari_Click(sender As Object, e As EventArgs) Handles BTNHapusHari.Click
    '    If MsgBox("Yakin ingin menghapus data hari ini?",
    '              vbYesNo + vbQuestion) = vbNo Then Exit Sub

    '    Try
    '        Call KoneksiDb()

    '        QUERY = "DELETE FROM tbl_hari WHERE Id_Hari=@id"
    '        CMD = New MySqlCommand(QUERY, DbKoneksi)
    '        CMD.Parameters.AddWithValue("@id", KdHari)
    '        CMD.ExecuteNonQuery()

    '        MsgBox("Data hari berhasil dihapus!", vbInformation)
    '        Me.Close()

    '    Catch ex As Exception
    '        MsgBox("Gagal menghapus data : " & ex.Message, vbCritical)
    '    End Try
    'End Sub

    ''========================
    '' KELUAR FORM
    ''========================
    'Private Sub BTNKeluarHari_Click(sender As Object, e As EventArgs) Handles BTNKeluarHari.Click
    '    If BTNKeluarHari.Text = "&KELUAR" Then
    '        If MsgBox("Anda yakin ingin exit?", vbQuestion + vbYesNo, "Informasi") = vbYes Then
    '            Me.Close()
    '        End If
    '    Else
    '        BTNSimpanHari.BackColor = Color.Red
    '        BTNSimpanHari.Enabled = False
    '        BTNHapusHari.BackColor = Color.Red
    '        BTNKeluarHari.Text = "&KELUAR"
    '    End If
    'End Sub

    'Private Sub TXTNamaHari_TextChanged(sender As Object, e As EventArgs) Handles TXTNamaHari.TextChanged
    '    Dim Kode As String = GenerateKodeHari(TXTNamaHari.Text)

    '    If Kode <> "" Then
    '        LBKodeHari.Text = Kode
    '    Else
    '        LBKodeHari.Text = " "
    '    End If
    'End Sub




    ' PILAR ENKAPSULASI: Properti publik untuk akses data antar Form
    Public Property Mode As String = "SIMPAN"
    Public Property KdHari As String = ""

    ' INTERAKSI OBJEK: Instansiasi objek (Tugas Praktik poin b)
    ' Form hanya mengenal Objek Hari, bukan Query Database langsung
    Private objHari As New Hari()
    Private repo As New HariRepository()

    ' ============================================================
    ' 1. FORM LOAD (LOGIKA TAMPILAN)
    ' ============================================================
    Private Sub FrmInputHari_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' GUI INTEGRATION: Menyesuaikan tampilan berdasarkan status operasi
        If Mode = "UBAH" Then
            TampilDataKeForm()
            BTNHapusHari.Enabled = True
            BTNSimpanHari.Text = "&UBAH"
        Else
            Bersih()
            BTNHapusHari.Enabled = False
            BTNSimpanHari.Text = "&SIMPAN"
        End If
    End Sub

    ' ============================================================
    ' 2. LOGIKA BISNIS: GENERATE KODE OTOMATIS
    ' ============================================================
    Private Sub TXTNamaHari_TextChanged(sender As Object, e As EventArgs) Handles TXTNamaHari.TextChanged
        Try
            ' Mengirim input ke properti Class
            ' Validasi (bukan angka) otomatis dipicu di dalam Property Hari.vb
            objHari.NamaHari = TXTNamaHari.Text.Trim()

            ' Mengambil hasil kalkulasi kode dari logika di dalam Class
            LBKodeHari.Text = objHari.GenerateKode()
        Catch ex As Exception
            ' Jika validasi enkapsulasi gagal (input angka), label dikosongkan
            LBKodeHari.Text = ""
        End Try
    End Sub

    ' ============================================================
    ' 3. SIMPAN / UBAH DATA (CRUD OOP)
    ' ============================================================
    Private Sub BTNSimpanHari_Click(sender As Object, e As EventArgs) Handles BTNSimpanHari.Click
        Try
            ' Mengisi data objek
            objHari.Id = KdHari
            objHari.NamaHari = TXTNamaHari.Text.Trim()

            ' POLIMORFISME: Memanggil fungsi Validasi hasil Override
            If Not objHari.Validasi() Then
                MsgBox("Nama Hari tidak valid!", vbExclamation)
                Return
            End If

            ' ABSTRAKSI: Form tidak perlu tahu query INSERT/UPDATE
            ' Cukup panggil repository untuk mengeksekusi objek
            repo.Eksekusi(objHari, Mode)

            MsgBox("Data berhasil disimpan!", vbInformation)
            Me.Close()
        Catch ex As Exception
            ' Menangkap pesan error dari validasi Property
            MsgBox("Peringatan: " & ex.Message, vbCritical)
        End Try
    End Sub

    ' ============================================================
    ' 4. HAPUS DATA
    ' ============================================================
    Private Sub BTNHapusHari_Click(sender As Object, e As EventArgs) Handles BTNHapusHari.Click
        If MsgBox("Yakin ingin menghapus data ini?", vbYesNo + vbQuestion) = vbYes Then
            Try
                objHari.Id = KdHari
                repo.Eksekusi(objHari, "HAPUS")
                MsgBox("Data telah terhapus.", vbInformation)
                Me.Close()
            Catch ex As Exception
                MsgBox("Gagal hapus: " & ex.Message)
            End Try
        End If
    End Sub

    ' ============================================================
    ' 5. FUNGSI PEMBANTU (HELPERS)
    ' ============================================================
    Sub TampilDataKeForm()
        ' MANAJEMEN DATA: Mencari objek spesifik di dalam List memori
        Dim data = repo.AmbilSemua().Find(Function(x) x.Id = KdHari)
        If data IsNot Nothing Then
            LBKodeHari.Text = data.Id
            TXTNamaHari.Text = data.NamaHari
        End If
    End Sub

    Sub Bersih()
        LBKodeHari.Text = "-"
        TXTNamaHari.Clear()
        TXTNamaHari.Focus()
    End Sub

    Private Sub BTNKeluarHari_Click(sender As Object, e As EventArgs) Handles BTNKeluarHari.Click
        Me.Close()
    End Sub
End Class

' ============================================================
' 1. PILAR ABSTRAKSI (Requirement Poin 4)
' ============================================================
Public MustInherit Class MasterData
    Private _id As String
    ' PILAR ENKAPSULASI (Poin 1): Property dengan Access Spesifier
    Public Property Id() As String
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property

    Public MustOverride Function Validasi() As Boolean
End Class

' ============================================================
' 2. PILAR INHERITANCE & POLYMORPHISM (Poin 2 & 3)
' ============================================================
Public Class Hari
    Inherits MasterData ' Pewarisan dari MasterData

    Private _namaHari As String
    Public Property NamaHari() As String
        Get
            Return _namaHari
        End Get
        Set(ByVal value As String)
            ' Validasi Enkapsulasi (Poin 1)
            If IsNumeric(value) Then Throw New Exception("Nama hari tidak boleh angka!")
            _namaHari = value
        End Set
    End Property

    ' Polimorfisme: Mendefinisikan ulang fungsi induk
    Public Overrides Function Validasi() As Boolean
        Return Not String.IsNullOrEmpty(NamaHari)
    End Function

    ' Logika Bisnis: Generate Kode Otomatis
    Public Function GenerateKode() As String
        Select Case NamaHari
            Case "Senin" : Return "HR001"
            Case "Selasa" : Return "HR002"
            Case "Rabu" : Return "HR003"
            Case "Kamis" : Return "HR004"
            Case "Jumat" : Return "HR005"
            Case "Sabtu" : Return "HR006"
            Case "Minggu" : Return "HR007"
            Case Else : Return ""
        End Select
    End Function
End Class

' ============================================================
' 3. REPOSITORY: GUI INTEGRATION (Poin 5)
' ============================================================
' Definisi Repository harus ada di sini agar tidak Error BC30002
Public Class HariRepository
    ' Menggunakan List(Of T) sesuai Instruksi Poin 5
    Public Function AmbilSemua() As List(Of Hari)
        Dim daftar As New List(Of Hari)
        Try
            Call KoneksiDb() ' Pastikan Module Koneksi sudah ada
            Using cmd As New MySqlCommand("SELECT * FROM tbl_hari", DbKoneksi)
                Using dr As MySqlDataReader = cmd.ExecuteReader()
                    While dr.Read()
                        Dim h As New Hari()
                        h.Id = dr("Id_Hari").ToString()
                        h.NamaHari = dr("Nm_Hari").ToString()
                        daftar.Add(h)
                    End While
                End Using
            End Using
        Catch ex As Exception
        End Try
        Return daftar
    End Function

    Public Sub Eksekusi(h As Hari, mode As String)
        Call KoneksiDb()
        Dim sql As String = ""
        If mode = "SIMPAN" Then
            sql = "INSERT INTO tbl_hari (Nm_Hari) VALUES (@n)"
        ElseIf mode = "UBAH" Then
            sql = "UPDATE tbl_hari SET Nm_Hari=@n WHERE Id_Hari=@id"
        Else
            sql = "DELETE FROM tbl_hari WHERE Id_Hari=@id"
        End If

        Using cmd As New MySqlCommand(sql, DbKoneksi)
            cmd.Parameters.AddWithValue("@n", h.NamaHari)
            cmd.Parameters.AddWithValue("@id", h.Id)
            cmd.ExecuteNonQuery()
        End Using
    End Sub
End Class
