<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDataTransaksiDosen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BTNKeluarTransaksi = New System.Windows.Forms.Button()
        Me.BTNHapusTransaksi = New System.Windows.Forms.Button()
        Me.BTNSimpanDataTransaksiDosen = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LBKodePengampu = New System.Windows.Forms.Label()
        Me.CBNamaJurusanData = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXTNomorIdentitas = New System.Windows.Forms.TextBox()
        Me.BTNCariKodeDosen = New System.Windows.Forms.Button()
        Me.LBNIDNData = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LBNamaDosen = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BTNCariKodeMatkul = New System.Windows.Forms.Button()
        Me.TXTKodeMatkul = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LBNamaMatakuliah = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LBSKSData = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LBSKSTeoriData = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.LBSKSPraktekData = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.LBSemesterData = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.CMBSEMESTERData = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CMBKelasData = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TXTTahunAkademik = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.LBKodeDataTransaksi = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSalmon
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(676, 64)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(182, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(294, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "::DATA DOSEN PENGAMPU::"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkSalmon
        Me.Panel2.Controls.Add(Me.BTNKeluarTransaksi)
        Me.Panel2.Controls.Add(Me.BTNHapusTransaksi)
        Me.Panel2.Controls.Add(Me.BTNSimpanDataTransaksiDosen)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 596)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(676, 122)
        Me.Panel2.TabIndex = 1
        '
        'BTNKeluarTransaksi
        '
        Me.BTNKeluarTransaksi.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNKeluarTransaksi.Location = New System.Drawing.Point(403, 43)
        Me.BTNKeluarTransaksi.Name = "BTNKeluarTransaksi"
        Me.BTNKeluarTransaksi.Size = New System.Drawing.Size(114, 51)
        Me.BTNKeluarTransaksi.TabIndex = 2
        Me.BTNKeluarTransaksi.Text = "&KELUAR"
        Me.BTNKeluarTransaksi.UseVisualStyleBackColor = True
        '
        'BTNHapusTransaksi
        '
        Me.BTNHapusTransaksi.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNHapusTransaksi.Location = New System.Drawing.Point(267, 43)
        Me.BTNHapusTransaksi.Name = "BTNHapusTransaksi"
        Me.BTNHapusTransaksi.Size = New System.Drawing.Size(114, 51)
        Me.BTNHapusTransaksi.TabIndex = 1
        Me.BTNHapusTransaksi.Text = "HAPUS"
        Me.BTNHapusTransaksi.UseVisualStyleBackColor = True
        '
        'BTNSimpanDataTransaksiDosen
        '
        Me.BTNSimpanDataTransaksiDosen.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNSimpanDataTransaksiDosen.Location = New System.Drawing.Point(130, 43)
        Me.BTNSimpanDataTransaksiDosen.Name = "BTNSimpanDataTransaksiDosen"
        Me.BTNSimpanDataTransaksiDosen.Size = New System.Drawing.Size(114, 51)
        Me.BTNSimpanDataTransaksiDosen.TabIndex = 0
        Me.BTNSimpanDataTransaksiDosen.Text = "&SIMPAN"
        Me.BTNSimpanDataTransaksiDosen.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Kode Pengampu"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(35, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Jurusan"
        '
        'LBKodePengampu
        '
        Me.LBKodePengampu.BackColor = System.Drawing.Color.DarkSalmon
        Me.LBKodePengampu.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBKodePengampu.Location = New System.Drawing.Point(169, 110)
        Me.LBKodePengampu.Name = "LBKodePengampu"
        Me.LBKodePengampu.Size = New System.Drawing.Size(103, 23)
        Me.LBKodePengampu.TabIndex = 4
        Me.LBKodePengampu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CBNamaJurusanData
        '
        Me.CBNamaJurusanData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBNamaJurusanData.FormattingEnabled = True
        Me.CBNamaJurusanData.Location = New System.Drawing.Point(275, 140)
        Me.CBNamaJurusanData.Name = "CBNamaJurusanData"
        Me.CBNamaJurusanData.Size = New System.Drawing.Size(348, 21)
        Me.CBNamaJurusanData.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(35, 170)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Nomor Identitas"
        '
        'TXTNomorIdentitas
        '
        Me.TXTNomorIdentitas.Location = New System.Drawing.Point(169, 169)
        Me.TXTNomorIdentitas.Name = "TXTNomorIdentitas"
        Me.TXTNomorIdentitas.Size = New System.Drawing.Size(100, 20)
        Me.TXTNomorIdentitas.TabIndex = 7
        '
        'BTNCariKodeDosen
        '
        Me.BTNCariKodeDosen.BackColor = System.Drawing.Color.DarkSalmon
        Me.BTNCariKodeDosen.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCariKodeDosen.Location = New System.Drawing.Point(275, 165)
        Me.BTNCariKodeDosen.Name = "BTNCariKodeDosen"
        Me.BTNCariKodeDosen.Size = New System.Drawing.Size(61, 27)
        Me.BTNCariKodeDosen.TabIndex = 8
        Me.BTNCariKodeDosen.Text = "Cari"
        Me.BTNCariKodeDosen.UseVisualStyleBackColor = False
        '
        'LBNIDNData
        '
        Me.LBNIDNData.BackColor = System.Drawing.Color.DarkSalmon
        Me.LBNIDNData.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBNIDNData.Location = New System.Drawing.Point(169, 201)
        Me.LBNIDNData.Name = "LBNIDNData"
        Me.LBNIDNData.Size = New System.Drawing.Size(103, 23)
        Me.LBNIDNData.TabIndex = 10
        Me.LBNIDNData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(35, 201)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 16)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "NIDN"
        '
        'LBNamaDosen
        '
        Me.LBNamaDosen.BackColor = System.Drawing.Color.DarkSalmon
        Me.LBNamaDosen.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBNamaDosen.Location = New System.Drawing.Point(169, 233)
        Me.LBNamaDosen.Name = "LBNamaDosen"
        Me.LBNamaDosen.Size = New System.Drawing.Size(167, 23)
        Me.LBNamaDosen.TabIndex = 12
        Me.LBNamaDosen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(35, 233)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 16)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Nama Dosen"
        '
        'BTNCariKodeMatkul
        '
        Me.BTNCariKodeMatkul.BackColor = System.Drawing.Color.DarkSalmon
        Me.BTNCariKodeMatkul.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCariKodeMatkul.Location = New System.Drawing.Point(275, 264)
        Me.BTNCariKodeMatkul.Name = "BTNCariKodeMatkul"
        Me.BTNCariKodeMatkul.Size = New System.Drawing.Size(136, 27)
        Me.BTNCariKodeMatkul.TabIndex = 15
        Me.BTNCariKodeMatkul.Text = "Cari Kode Matkul"
        Me.BTNCariKodeMatkul.UseVisualStyleBackColor = False
        '
        'TXTKodeMatkul
        '
        Me.TXTKodeMatkul.Location = New System.Drawing.Point(169, 268)
        Me.TXTKodeMatkul.Name = "TXTKodeMatkul"
        Me.TXTKodeMatkul.Size = New System.Drawing.Size(100, 20)
        Me.TXTKodeMatkul.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(35, 269)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 16)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Kode Matakuliah"
        '
        'LBNamaMatakuliah
        '
        Me.LBNamaMatakuliah.BackColor = System.Drawing.Color.DarkSalmon
        Me.LBNamaMatakuliah.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBNamaMatakuliah.Location = New System.Drawing.Point(169, 300)
        Me.LBNamaMatakuliah.Name = "LBNamaMatakuliah"
        Me.LBNamaMatakuliah.Size = New System.Drawing.Size(167, 23)
        Me.LBNamaMatakuliah.TabIndex = 17
        Me.LBNamaMatakuliah.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(35, 300)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(119, 16)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Nama Matakuliah"
        '
        'LBSKSData
        '
        Me.LBSKSData.BackColor = System.Drawing.Color.DarkSalmon
        Me.LBSKSData.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBSKSData.Location = New System.Drawing.Point(169, 333)
        Me.LBSKSData.Name = "LBSKSData"
        Me.LBSKSData.Size = New System.Drawing.Size(103, 23)
        Me.LBSKSData.TabIndex = 19
        Me.LBSKSData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(35, 333)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 16)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "SKS"
        '
        'LBSKSTeoriData
        '
        Me.LBSKSTeoriData.BackColor = System.Drawing.Color.DarkSalmon
        Me.LBSKSTeoriData.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBSKSTeoriData.Location = New System.Drawing.Point(169, 367)
        Me.LBSKSTeoriData.Name = "LBSKSTeoriData"
        Me.LBSKSTeoriData.Size = New System.Drawing.Size(103, 23)
        Me.LBSKSTeoriData.TabIndex = 21
        Me.LBSKSTeoriData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(35, 367)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(78, 16)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "SKS-TEORI"
        '
        'LBSKSPraktekData
        '
        Me.LBSKSPraktekData.BackColor = System.Drawing.Color.DarkSalmon
        Me.LBSKSPraktekData.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBSKSPraktekData.Location = New System.Drawing.Point(169, 401)
        Me.LBSKSPraktekData.Name = "LBSKSPraktekData"
        Me.LBSKSPraktekData.Size = New System.Drawing.Size(103, 23)
        Me.LBSKSPraktekData.TabIndex = 23
        Me.LBSKSPraktekData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(35, 401)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(100, 16)
        Me.Label15.TabIndex = 22
        Me.Label15.Text = "SKS-PRAKTEK"
        '
        'LBSemesterData
        '
        Me.LBSemesterData.BackColor = System.Drawing.Color.DarkSalmon
        Me.LBSemesterData.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBSemesterData.Location = New System.Drawing.Point(169, 436)
        Me.LBSemesterData.Name = "LBSemesterData"
        Me.LBSemesterData.Size = New System.Drawing.Size(103, 23)
        Me.LBSemesterData.TabIndex = 25
        Me.LBSemesterData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(35, 436)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(45, 16)
        Me.Label17.TabIndex = 24
        Me.Label17.Text = "SMTR"
        '
        'CMBSEMESTERData
        '
        Me.CMBSEMESTERData.FormattingEnabled = True
        Me.CMBSEMESTERData.Location = New System.Drawing.Point(169, 474)
        Me.CMBSEMESTERData.Name = "CMBSEMESTERData"
        Me.CMBSEMESTERData.Size = New System.Drawing.Size(167, 21)
        Me.CMBSEMESTERData.TabIndex = 27
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(35, 475)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 16)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "SEMESTER"
        '
        'CMBKelasData
        '
        Me.CMBKelasData.FormattingEnabled = True
        Me.CMBKelasData.Location = New System.Drawing.Point(169, 501)
        Me.CMBKelasData.Name = "CMBKelasData"
        Me.CMBKelasData.Size = New System.Drawing.Size(167, 21)
        Me.CMBKelasData.TabIndex = 29
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(35, 502)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 16)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Kelas"
        '
        'TXTTahunAkademik
        '
        Me.TXTTahunAkademik.Location = New System.Drawing.Point(169, 528)
        Me.TXTTahunAkademik.Name = "TXTTahunAkademik"
        Me.TXTTahunAkademik.Size = New System.Drawing.Size(103, 20)
        Me.TXTTahunAkademik.TabIndex = 31
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(35, 529)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(123, 16)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "TAHUN AKADEMIK"
        '
        'LBKodeDataTransaksi
        '
        Me.LBKodeDataTransaksi.BackColor = System.Drawing.Color.DarkSalmon
        Me.LBKodeDataTransaksi.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBKodeDataTransaksi.Location = New System.Drawing.Point(169, 140)
        Me.LBKodeDataTransaksi.Name = "LBKodeDataTransaksi"
        Me.LBKodeDataTransaksi.Size = New System.Drawing.Size(103, 23)
        Me.LBKodeDataTransaksi.TabIndex = 32
        Me.LBKodeDataTransaksi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmDataTransaksiDosen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Bisque
        Me.ClientSize = New System.Drawing.Size(676, 718)
        Me.Controls.Add(Me.LBKodeDataTransaksi)
        Me.Controls.Add(Me.TXTTahunAkademik)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.CMBKelasData)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.CMBSEMESTERData)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LBSemesterData)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.LBSKSPraktekData)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.LBSKSTeoriData)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.LBSKSData)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.LBNamaMatakuliah)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.BTNCariKodeMatkul)
        Me.Controls.Add(Me.TXTKodeMatkul)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LBNamaDosen)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.LBNIDNData)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BTNCariKodeDosen)
        Me.Controls.Add(Me.TXTNomorIdentitas)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CBNamaJurusanData)
        Me.Controls.Add(Me.LBKodePengampu)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmDataTransaksiDosen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmDataTransaksiDosen"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BTNSimpanDataTransaksiDosen As Button
    Friend WithEvents BTNKeluarTransaksi As Button
    Friend WithEvents BTNHapusTransaksi As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LBKodePengampu As Label
    Friend WithEvents CBNamaJurusanData As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TXTNomorIdentitas As TextBox
    Friend WithEvents BTNCariKodeDosen As Button
    Friend WithEvents LBNIDNData As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LBNamaDosen As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents BTNCariKodeMatkul As Button
    Friend WithEvents TXTKodeMatkul As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents LBNamaMatakuliah As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents LBSKSData As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents LBSKSTeoriData As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents LBSKSPraktekData As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents LBSemesterData As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents CMBSEMESTERData As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents CMBKelasData As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TXTTahunAkademik As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents LBKodeDataTransaksi As Label
End Class
