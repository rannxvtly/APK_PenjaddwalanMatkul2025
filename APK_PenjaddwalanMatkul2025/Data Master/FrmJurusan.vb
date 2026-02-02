Imports MySql.Data.MySqlClient
Public Class FrmJurusan
    'Sub Kosongkan()
    '    LBLKODE.Text = ""
    '    TxtNAMAPRODI.Text = ""
    '    TxtNAMAPRODI.Focus()
    'End Sub

    '' Private Sub FrmJurusan_Load(...)  Call KodeOtomatis() ← tidak dipakai lagi

    'Private Sub FrmJurusan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    ' ✅ DIBETULKAN: Jangan panggil KodeOtomatis() di sini lagi ←
    'End Sub

    'Private Sub BTNSIMPANJURUSAN_Click(sender As Object, e As EventArgs) Handles BTNSIMPANJURUSAN.Click
    '    If TxtNAMAPRODI.Text = "" Then
    '        MsgBox("Nama Prodi tidak boleh kosong!", vbExclamation)
    '        Exit Sub
    '    End If

    '    Call KoneksiDb()
    '    On Error Resume Next

    '    If BTNSIMPANJURUSAN.Text = "SIMPAN" Then
    '        Dim SQL As String = "INSERT INTO tbl_prodi VALUES('" & LBLKODE.Text & "','" & TxtNAMAPRODI.Text & "')"
    '        CMD = New MySqlCommand(SQL, DbKoneksi)
    '        CMD.ExecuteNonQuery()
    '        MsgBox("Data Jurusan Berhasil Disimpan", vbInformation)

    '    ElseIf BTNSIMPANJURUSAN.Text = "UBAH" Then
    '        Dim SQL As String = "UPDATE tbl_prodi SET Nm_Prodi='" & TxtNAMAPRODI.Text & "' WHERE Kd_Prodi='" & LBLKODE.Text & "'"
    '        CMD = New MySqlCommand(SQL, DbKoneksi)
    '        CMD.ExecuteNonQuery()
    '        MsgBox("Data Jurusan Berhasil Diubah", vbInformation)
    '    End If

    '    FrmDataJurusan.TampilkanDataJurusan()
    '    FrmDataJurusan.Enabled = True
    '    Me.Close()
    'End Sub

    'Private Sub BTNHAPUSJurusan_Click(sender As Object, e As EventArgs) Handles BTNHAPUSJurusan.Click
    '    If MsgBox("Yakin ingin menghapus jurusan " & TxtNAMAPRODI.Text & "?", vbQuestion + vbYesNo, "Konfirmasi") = vbYes Then
    '        Call KoneksiDb()
    '        On Error Resume Next

    '        Dim SQL As String = "DELETE FROM tbl_prodi WHERE Kd_Prodi='" & LBLKODE.Text & "'"
    '        CMD = New MySqlCommand(SQL, DbKoneksi)
    '        CMD.ExecuteNonQuery()
    '        MsgBox("Data Terhapus", vbInformation)

    '        FrmDataJurusan.TampilkanDataJurusan()
    '        FrmDataJurusan.Enabled = True
    '        Me.Close()
    '    End If
    'End Sub

    ''===============================================
    '' Tombol BATAL berubah menjadi KELUAR
    ''===============================================
    'Private Sub BTNKELUARKode_Click(sender As Object, e As EventArgs) Handles BTNKELUARKode.Click
    '    FrmDataJurusan.Enabled = True
    '    On Error Resume Next

    '    If BTNKELUARKode.Text = "BATAL" Then  '← sebelumnya salah penulisan kontrol
    '        ' ✅ DITAMBAH: Saat BATAL, tombol UBAH/HAPUS jadi MERAH ←

    '        With BTNSIMPANJURUSAN
    '            .Enabled = True
    '            .Text = "UBAH"
    '            .BackColor = Color.Red  '← Diubah jadi merah
    '            .ForeColor = Color.White
    '            .FlatStyle = FlatStyle.Flat
    '        End With

    '        With BTNHAPUSJurusan
    '            .Enabled = True
    '            .Text = "HAPUS"
    '            .BackColor = Color.Red  '← Diubah jadi merah
    '            .ForeColor = Color.White
    '            .FlatStyle = FlatStyle.Flat
    '        End With

    '        ' ✅ Tombol BATAL jadi KELUAR tetap BIRU ←
    '        With BTNKELUARKode
    '            .Enabled = True
    '            .Text = "KELUAR" '← berubah jadi keluar
    '            .BackColor = Color.CornflowerBlue '← tetap CornflowerBlue
    '            .ForeColor = Color.White
    '            .FlatStyle = FlatStyle.Flat
    '        End With

    '    ElseIf BTNKELUARKode.Text = "KELUAR" Then '← admin/mahasiswa bisa keluar form
    '        Me.Close()
    '    End If
    'End Sub


    Private objJurusan As New JurusanModel()
    Private repo As New JurusanInputRepository()

    Sub Kosongkan()
        LBLKODE.Text = ""
        TxtNAMAPRODI.Clear()
        TxtNAMAPRODI.Focus()
    End Sub

    Private Sub FrmJurusan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Desain awal tombol saat load (Visual logic)
        If BTNSIMPANJURUSAN.Text = "SIMPAN" Then
            BTNHAPUSJurusan.Enabled = False
        End If
    End Sub

    ' --- TOMBOL SIMPAN / UBAH ---
    Private Sub BTNSIMPANJURUSAN_Click(sender As Object, e As EventArgs) Handles BTNSIMPANJURUSAN.Click
        Try
            ' Mengisi Objek
            objJurusan.Id = LBLKODE.Text
            objJurusan.NamaProdi = TxtNAMAPRODI.Text.Trim()

            ' Validasi Polimorfisme
            If Not objJurusan.Validasi() Then
                MsgBox("Nama Prodi wajib diisi!", vbExclamation)
                Return
            End If

            ' Eksekusi via Repository
            Dim modeAktif As String = If(BTNSIMPANJURUSAN.Text = "SIMPAN", "SIMPAN", "UBAH")
            repo.Eksekusi(objJurusan, modeAktif)

            MsgBox("Data Berhasil di-" & modeAktif, vbInformation)

            ' Refresh Grid di form data
            FrmDataJurusan.TampilkanDataJurusan()
            FrmDataJurusan.Enabled = True
            Me.Close()

        Catch ex As Exception
            MsgBox("Kesalahan: " & ex.Message, vbCritical)
        End Try
    End Sub

    ' --- TOMBOL HAPUS ---
    Private Sub BTNHAPUSJurusan_Click(sender As Object, e As EventArgs) Handles BTNHAPUSJurusan.Click
        If MsgBox("Yakin ingin menghapus prodi ini?", vbQuestion + vbYesNo) = vbYes Then
            Try
                objJurusan.Id = LBLKODE.Text
                repo.Eksekusi(objJurusan, "HAPUS")

                MsgBox("Data Terhapus", vbInformation)
                FrmDataJurusan.TampilkanDataJurusan()
                FrmDataJurusan.Enabled = True
                Me.Close()
            Catch ex As Exception
                MsgBox("Gagal Hapus: " & ex.Message)
            End Try
        End If
    End Sub

    ' --- TOMBOL KELUAR / BATAL ---
    Private Sub BTNKELUARKode_Click(sender As Object, e As EventArgs) Handles BTNKELUARKode.Click
        If BTNKELUARKode.Text = "BATAL" Then
            ' Perubahan Visual sesuai keinginan Anda
            BTNSIMPANJURUSAN.BackColor = Color.Red
            BTNSIMPANJURUSAN.ForeColor = Color.White
            BTNHAPUSJurusan.BackColor = Color.Red
            BTNHAPUSJurusan.ForeColor = Color.White

            BTNKELUARKode.Text = "KELUAR"
            BTNKELUARKode.BackColor = Color.CornflowerBlue
        Else
            FrmDataJurusan.Enabled = True
            Me.Close()
        End If
    End Sub

    ' ============================================================
    ' 1. MODEL CLASS (Inheritance & Encapsulation)
    ' ============================================================
    Public Class JurusanModel
        Inherits MasterData ' Mewarisi properti Id dari MasterData

        Private _namaProdi As String
        Public Property NamaProdi() As String
            Get
                Return _namaProdi
            End Get
            Set(ByVal value As String)
                ' Validasi Enkapsulasi: Nama prodi tidak boleh mengandung angka
                If IsNumeric(value) Then Throw New Exception("Nama Prodi tidak valid!")
                _namaProdi = value
            End Set
        End Property

        ' Polimorfisme: Override fungsi Validasi
        Public Overrides Function Validasi() As Boolean
            Return Not String.IsNullOrEmpty(NamaProdi)
        End Function
    End Class

    ' ============================================================
    ' 2. REPOSITORY (Pemisahan Logika Database)
    ' ============================================================
    Public Class JurusanInputRepository
        Public Sub Eksekusi(j As JurusanModel, mode As String)
            Call KoneksiDb()
            Dim sql As String = ""

            If mode = "SIMPAN" Then
                sql = "INSERT INTO tbl_prodi (Kd_Prodi, Nm_Prodi) VALUES (@id, @nm)"
            ElseIf mode = "UBAH" Then
                sql = "UPDATE tbl_prodi SET Nm_Prodi=@nm WHERE Kd_Prodi=@id"
            ElseIf mode = "HAPUS" Then
                sql = "DELETE FROM tbl_prodi WHERE Kd_Prodi=@id"
            End If

            Using cmd As New MySqlCommand(sql, DbKoneksi)
                cmd.Parameters.AddWithValue("@id", j.Id)
                cmd.Parameters.AddWithValue("@nm", j.NamaProdi)
                cmd.ExecuteNonQuery()
            End Using
        End Sub
    End Class
End Class