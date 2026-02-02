Imports MySql.Data.MySqlClient
Public Class FrmLogin
    Private Sub BTNLOGIN_Click(sender As Object, e As EventArgs) Handles BTNLOGIN.Click
        Call KoneksiDb()


        ' Validasi input user dan password
        If TxtUSER.Text = "" Then
            MsgBox("Nama User Tidak Boleh Kosong", vbExclamation, "Kosong")
            TxtUSER.Focus()
            Exit Sub
        ElseIf TxtPASSWORD.Text = "" Then
            MsgBox("Password Tidak Boleh Kosong", vbExclamation, "Kosong")
            TxtPASSWORD.Focus()
            Exit Sub
        End If

        ' Cek username
        CMD = New MySqlCommand("SELECT * FROM tbl_user WHERE Nm_User='" & TxtUSER.Text & "'", DbKoneksi)
        DR = CMD.ExecuteReader()

        If DR.HasRows Then
            DR.Read()
            LoginNama = DR("Nm_User").ToString()
            LoginID = DR("Id_User").ToString()
            LoginLevel = DR("Level_User").ToString()
        Else
            DR.Close()
            MsgBox("Kamu tidak terdaftar, daftar dulu.", vbCritical + vbOKOnly, "Warning")
            TxtUSER.Text = ""
            TxtPASSWORD.Text = ""
            TxtUSER.Focus()
            Exit Sub
        End If
        DR.Close()

        ' Cek password
        CMD = New MySqlCommand("SELECT * FROM tbl_user WHERE Nm_User='" & TxtUSER.Text & "' AND Pass_User='" & TxtPASSWORD.Text & "'", DbKoneksi)
        DR = CMD.ExecuteReader()

        If DR.HasRows Then
            DR.Read()
            DR.Close()

            ' ======= BAGIAN DITAMBAHKAN UNTUK ATUR MENU =======
            If LoginLevel = "Administrator" Or LoginLevel = "Mahasiswa" Then
                ' Tampilkan FrmMenuUtama dan atur akses berdasarkan level
                With FrmMenuUtama
                    .Show()
                    .AturAksesMenu(LoginLevel, LoginNama, LoginID) '✅ DITAMBAHKAN: panggil sub AturAksesMenu
                End With
                Me.Close() ' Tutup form login setelah login sukses
            Else
                MsgBox("Anda tidak dapat menggunakan program ini.", vbCritical, "Akses Ditolak")
                TxtUSER.Text = ""
                TxtPASSWORD.Text = ""
                TxtUSER.Focus()
            End If
            ' ======= SELESAI BAGIAN DITAMBAHKAN =======

        Else
            ' Password salah
            DR.Close()
            If Hitung < 2 Then
                MsgBox("Password anda salah, silahkan ulangi: " & Hitung, vbCritical + vbOKOnly, "Warning")
                TxtPASSWORD.Text = ""
                TxtPASSWORD.Focus()
                Hitung += 1
            Else
                MsgBox("Kamu Bukan User Yang Berhak", vbCritical + vbOKOnly, "Warning")
                Me.Close()
                Hitung = 1
            End If
        End If
    End Sub

    ' Tombol Batal Login
    Private Sub BTNBATAL_Click(sender As Object, e As EventArgs) Handles BTNBATAL.Click
        Dim Pesan As Integer
        Pesan = MsgBox("Anda Yakin Ingin Batal Login?", vbQuestion + vbYesNo, "Konfirmasi")
        If Pesan = vbYes Then
            Me.Close()
        Else
            Exit Sub
        End If
    End Sub
End Class
