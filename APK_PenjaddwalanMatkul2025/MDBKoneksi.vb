Imports MySql.Data.MySqlClient
Module MDBKoneksi
    'Membuat variabel koneksi MySQL
    Public DbKoneksi As MySqlConnection
    Public DA As MySqlDataAdapter
    Public DS As DataSet
    Public CMD As MySqlCommand
    Public DR As MySqlDataReader
    Public DT As DataTable

    'Variabel Bantuan Operasional
    Public Hitung As Integer = 1
    Public Nomor As Integer
    Public QUERY As String
    Public LokasiDatabase As String

    'Variabel Penampung Kode (Sesuai Kebutuhan Form)
    Public Kode_Jurusan As String
    Public Kode_semester As String
    Public Kode_Dosen As String
    Public Kode_Matkul As String
    Public Kode_Pengampu As String

    '=== VARIABEL LOGIN (Identitas User yang sedang aktif) ===
    Public LoginNama As String
    Public LoginID As String 'Disesuaikan dari Id_User pada tbl_user
    Public LoginLevel As String

    'Variabel Perintah SQL dan Pesan
    Public SQLInsert As String
    Public SQLUpdate As String
    Public SQLHapus As String
    Public Pesan As String

    'Prosedur untuk Membuka Koneksi ke Database
    Public Sub KoneksiDb()
        Try
            'Disesuaikan dengan nama database akademik Anda
            LokasiDatabase = "Server=Localhost;Uid=root;Pwd=;Database=uasdb04009;CharSet=utf8mb4;"
            DbKoneksi = New MySqlConnection(LokasiDatabase)

            If DbKoneksi.State = ConnectionState.Closed Then
                DbKoneksi.Open()
            End If
        Catch ex As Exception
            MsgBox("Koneksi Gagal: " & ex.Message, vbExclamation, "Error Database")
        End Try
    End Sub

    'Fungsi untuk Memutuskan Koneksi
    Public Function Diskonek() As MySqlConnection
        If DbKoneksi IsNot Nothing Then
            If DbKoneksi.State = ConnectionState.Open Then
                DbKoneksi.Close()
            End If
        End If
        Return DbKoneksi
    End Function

    'Fungsi untuk Mengatasi Input Karakter Petik (') agar tidak Error SQL Injection
    Public Function Rep(ByVal kata As String) As String
        Return Replace(kata, "'", "''")
    End Function
End Module
