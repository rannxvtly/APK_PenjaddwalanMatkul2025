Imports MySql.Data.MySqlClient
Public Class FrmDataHari 'GUI Integration
    '' =========================
    '' FORM LOAD
    '' =========================
    'Private Sub FrmDataHari_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    TampilDataHari()
    'End Sub

    '' =========================
    '' TAMPIL DATA GRID
    '' =========================
    'Sub TampilDataHari()
    '    Call KoneksiDb()

    '    DA = New MySqlDataAdapter(
    '        "SELECT Id_Hari AS kode_hari, Nm_Hari AS nama_hari 
    '         FROM tbl_hari 
    '         ORDER BY Id_Hari",
    '        DbKoneksi)

    '    DS = New DataSet
    '    DA.Fill(DS, "hari")
    '    DataGridHari.DataSource = DS.Tables("hari")
    'End Sub

    '' =========================
    '' CARI DATA HARI
    '' =========================
    'Private Sub BTNCariHari_Click(sender As Object, e As EventArgs) Handles BTNCariHari.Click
    '    Call KoneksiDb()

    '    DA = New MySqlDataAdapter(
    '        "SELECT Id_Hari AS kode_hari, Nm_Hari AS nama_hari 
    '         FROM tbl_hari 
    '         WHERE Nm_Hari LIKE '%" & TXTCariHari.Text & "%'",
    '        DbKoneksi)

    '    DS = New DataSet
    '    DA.Fill(DS, "hari")
    '    DataGridHari.DataSource = DS.Tables("hari")
    'End Sub

    '' =========================
    '' TOMBOL TAMBAH DATA
    '' =========================
    'Private Sub BTNTambahHari_Click(sender As Object, e As EventArgs) Handles BTNTambahHari.Click
    '    With FrmInputHari
    '        .Mode = "SIMPAN"
    '        .KdHari = ""
    '        .ShowDialog()
    '    End With

    '    TampilDataHari() ' refresh setelah simpan
    'End Sub

    '' =========================
    '' DOUBLE CLICK → EDIT
    '' =========================
    'Private Sub DataGridHari_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridHari.CellDoubleClick
    '    If e.RowIndex < 0 Then Exit Sub

    '    With FrmInputHari
    '        .Mode = "UBAH"
    '        .KdHari = DataGridHari.Rows(e.RowIndex).Cells("kode_hari").Value.ToString
    '        .ShowDialog()
    '    End With

    '    TampilDataHari()
    'End Sub

    '' =========================
    '' KELUAR
    '' =========================
    'Private Sub BTNKeluarDataHari_Click(sender As Object, e As EventArgs) Handles BTNKeluarDataHari.Click
    '    If BTNKeluarDataHari.Text = "&KELUAR" Then
    '        Pesan = MsgBox("Anda yakkin mau exit dari form data hari?", vbQuestion + vbYesNo, "Informasi")
    '        If Pesan = vbYes Then
    '            Me.Close()
    '        End If
    '    Else
    '        BTNTambahHari.Text = "&AKTIF FORM"
    '        BTNTambahHari.Enabled = True
    '        BTNTambahHari.BackColor = Color.LightGray
    '    End If
    'End Sub

    ' Instansiasi Repository
    Private repoHari As New HariRepository()

    Private Sub FrmDataHari_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilDataHari()
    End Sub

    ' --- GUI INTEGRATION ---
    Sub TampilDataHari(Optional filter As String = "")
        ' Mengambil data dalam bentuk List of Objects
        Dim data = repoHari.AmbilData(filter)

        DataGridHari.DataSource = Nothing
        DataGridHari.DataSource = data

        ' Pengaturan Header
        If DataGridHari.Columns.Count > 0 Then
            DataGridHari.Columns("Id").HeaderText = "KODE HARI"
            DataGridHari.Columns("NamaHari").HeaderText = "NAMA HARI"
            DataGridHari.Columns("NamaHari").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        End If
    End Sub

    Private Sub BTNCariHari_Click(sender As Object, e As EventArgs) Handles BTNCariHari.Click
        TampilDataHari(TXTCariHari.Text)
    End Sub

    Private Sub BTNTambahHari_Click(sender As Object, e As EventArgs) Handles BTNTambahHari.Click
        With FrmInputHari
            .Mode = "SIMPAN"
            .KdHari = ""
            .ShowDialog()
        End With
        TampilDataHari()
    End Sub

    Private Sub DataGridHari_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridHari.CellDoubleClick
        If e.RowIndex < 0 Then Exit Sub

        ' Polymorphism: Mengambil item sebagai objek Hari
        Dim hariTerpilih As Hari = CType(DataGridHari.Rows(e.RowIndex).DataBoundItem, Hari)

        With FrmInputHari
            .Mode = "UBAH"
            .KdHari = hariTerpilih.Id
            .ShowDialog()
        End With
        TampilDataHari()
    End Sub

    Private Sub BTNKeluarDataHari_Click(sender As Object, e As EventArgs) Handles BTNKeluarDataHari.Click
        If MsgBox("Apakah Anda yakin ingin keluar?", vbQuestion + vbYesNo) = vbYes Then
            Me.Close()
        End If
    End Sub

    ' File: Hari.vb
    Public MustInherit Class EntitasMaster 'abstraksi class
        Private _id As String 'encapsulation access sppesifire and property
        Public Property Id() As String
            Get
                Return _id
            End Get
            Set(ByVal value As String)
                _id = value
            End Set
        End Property
        Public MustOverride Function CekValidasi() As Boolean 'polymorphism method overriding
    End Class

    Public Class Hari 'inheritance base and derived class
        Inherits EntitasMaster 'inheritance base and derived class

        Private _namaHari As String 'encapsulation access sppesifire and property
        Public Property NamaHari() As String 'encapsulation access sppesifire and property
            Get
                Return _namaHari
            End Get
            Set(ByVal value As String)
                _namaHari = value
            End Set
        End Property

        Public Overrides Function CekValidasi() As Boolean
            Return Not String.IsNullOrEmpty(NamaHari)
        End Function
    End Class

    Public Class HariRepository
        Public Function AmbilData(Optional filterNama As String = "") As List(Of Hari) 'untuk menampung sekumpulan objek hasil
            'query dari database sebelum ditampilkan ke DataGridView.
            Dim daftarHari As New List(Of Hari)
            Try
                ' Pastikan Modul KoneksiDb sudah ada di project Anda
                Call KoneksiDb()

                Dim query As String = "SELECT Id_Hari, Nm_Hari FROM tbl_hari"
                If filterNama <> "" Then
                    query &= " WHERE Nm_Hari LIKE @nama"
                End If
                query &= " ORDER BY Id_Hari"

                Using cmd As New MySqlCommand(query, DbKoneksi)
                    If filterNama <> "" Then cmd.Parameters.AddWithValue("@nama", "%" & filterNama & "%")
                    Using dr As MySqlDataReader = cmd.ExecuteReader()
                        While dr.Read()
                            Dim h As New Hari()
                            h.Id = dr("Id_Hari").ToString()
                            h.NamaHari = dr("Nm_Hari").ToString()
                            daftarHari.Add(h)
                        End While
                    End Using
                End Using
            Catch ex As Exception
                MsgBox("Gagal Load Data: " & ex.Message)
            End Try
            Return daftarHari
        End Function
    End Class
End Class