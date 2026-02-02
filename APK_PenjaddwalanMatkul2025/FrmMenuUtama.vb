Public Class FrmMenuUtama

    Private Sub LoginSistemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginSistemToolStripMenuItem.Click
        FrmLogin.Show()
        ' FrmLogin.MdiParent = Me
    End Sub

    Private Sub FrmMenuUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataMasterToolStripMenuItem.Enabled = False
        DataTransaksiToolStripMenuItem.Enabled = False
        DATALAPORANToolStripMenuItem.Enabled = False
        DataJurusanToolStripMenuItem.Enabled = False
        HELPToolStripMenuItem.Enabled = True
        LogoutToolStripMenuItem.Enabled = False
        LoginSistemToolStripMenuItem.Enabled = True
    End Sub

    Private Sub DataDosenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataDosenToolStripMenuItem.Click
        FrmDataDosenPagging.Show()
        'FrmDataDosenPagging.MdiParent = Me
    End Sub

    Private Sub TentangAplikasiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TentangAplikasiToolStripMenuItem.Click
        FrmTentangAplikasi.Show()
        'FrmTentangAplikasi.MdiParent = Me
    End Sub

    ' Menu Logout
    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        ' Menutup form login & form lain
        FrmLogin.Close()
        FrmDataDosenPagging.Close()
        FrmDataJurusan.Close()
        FrmTentangAplikasi.Close()

        ' Reset menu
        LoginSistemToolStripMenuItem.Enabled = True
        LogoutToolStripMenuItem.Enabled = False
        DataMasterToolStripMenuItem.Enabled = False
        DataJurusanToolStripMenuItem.Enabled = False
        HELPToolStripMenuItem.Enabled = False

        MsgBox("Anda Telah Logout Dari Sistem Ini.", vbInformation, "Logout")
    End Sub


    ' Menu Exit
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Pesan = MsgBox("Anda Yakin Ingin Keluar?", vbQuestion + vbYesNo, "Konfirmasi")
        If Pesan = vbYes Then
            Me.Close()
        End If
    End Sub

    ' Mengatur Akses Menu sesuai Level
    Public Sub AturAksesMenu(ByVal level As String, ByVal nama As String, ByVal nim As String)

        If level = "Administrator" Then
            DataMasterToolStripMenuItem.Enabled = True
            DataTransaksiToolStripMenuItem.Enabled = True
            DATALAPORANToolStripMenuItem.Enabled = True
            DataJurusanToolStripMenuItem.Enabled = True
            DataHariToolStripMenuItem.Enabled = True
            HELPToolStripMenuItem.Enabled = True
            LogoutToolStripMenuItem.Enabled = True
            LoginSistemToolStripMenuItem.Enabled = False

        ElseIf level = "Mahasiswa" Then
            ' Mahasiswa bisa klik Data Master (menu induk)
            DataMasterToolStripMenuItem.Enabled = True

            ' Mahasiswa bisa buka Data Jurusan (submenu)
            DataJurusanToolStripMenuItem.Enabled = True

            ' Mahasiswa tidak bisa klik Data Mahasiswa
            DataHariToolStripMenuItem.Enabled = False

            '======== YANG DIBETULKAN & DITAMBAHKAN ========
            FrmDataDosenPagging.BtnTambahData.Enabled = False  ' ← Mahasiswa tidak boleh tambah data prodi/jurusan
            FrmDataDosenPagging.BtnKeluar.Enabled = True   ' ← Tidak boleh hapus juga
            '==============================================

            HELPToolStripMenuItem.Enabled = True
            LogoutToolStripMenuItem.Enabled = True
            LoginSistemToolStripMenuItem.Enabled = False
        End If
    End Sub

    ' Menu Data Jurusan
    Private Sub DataJurusanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataJurusanToolStripMenuItem.Click
        FrmDataJurusan.Show()
        FrmDataJurusan.MdiParent = Me
    End Sub

    Private Sub DataHariToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataHariToolStripMenuItem.Click
        FrmDataHari.Show()
    End Sub
End Class