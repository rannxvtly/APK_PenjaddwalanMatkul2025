<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBiodataDosen
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
        Me.components = New System.ComponentModel.Container()
        Me.BTNKELUARBiodata = New System.Windows.Forms.Button()
        Me.BTNSIMPANBiodata = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BTNHAPUSBiodata = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TXTNoHp = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TXTNamaDosen = New System.Windows.Forms.TextBox()
        Me.CMBJurusan = New System.Windows.Forms.ComboBox()
        Me.TXTNIDN = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LbNIK = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LBKodeProdi = New System.Windows.Forms.Label()
        Me.LBKodeDosen = New System.Windows.Forms.Label()
        Me.TXTEmailDosen = New System.Windows.Forms.TextBox()
        Me.CMBJKDosen = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTNKELUARBiodata
        '
        Me.BTNKELUARBiodata.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNKELUARBiodata.Location = New System.Drawing.Point(389, 20)
        Me.BTNKELUARBiodata.Name = "BTNKELUARBiodata"
        Me.BTNKELUARBiodata.Size = New System.Drawing.Size(108, 55)
        Me.BTNKELUARBiodata.TabIndex = 2
        Me.BTNKELUARBiodata.Text = "&KELUAR"
        Me.BTNKELUARBiodata.UseVisualStyleBackColor = True
        '
        'BTNSIMPANBiodata
        '
        Me.BTNSIMPANBiodata.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNSIMPANBiodata.Location = New System.Drawing.Point(125, 20)
        Me.BTNSIMPANBiodata.Name = "BTNSIMPANBiodata"
        Me.BTNSIMPANBiodata.Size = New System.Drawing.Size(102, 55)
        Me.BTNSIMPANBiodata.TabIndex = 0
        Me.BTNSIMPANBiodata.Text = "&SIMPAN"
        Me.BTNSIMPANBiodata.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkSalmon
        Me.Panel3.Controls.Add(Me.BTNKELUARBiodata)
        Me.Panel3.Controls.Add(Me.BTNHAPUSBiodata)
        Me.Panel3.Controls.Add(Me.BTNSIMPANBiodata)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 364)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(669, 96)
        Me.Panel3.TabIndex = 6
        '
        'BTNHAPUSBiodata
        '
        Me.BTNHAPUSBiodata.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNHAPUSBiodata.Location = New System.Drawing.Point(255, 20)
        Me.BTNHAPUSBiodata.Name = "BTNHAPUSBiodata"
        Me.BTNHAPUSBiodata.Size = New System.Drawing.Size(108, 55)
        Me.BTNHAPUSBiodata.TabIndex = 1
        Me.BTNHAPUSBiodata.Text = "HAPUS"
        Me.BTNHAPUSBiodata.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(35, 220)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 16)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "E-Mail Dosen"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(35, 192)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 16)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "NOHP"
        '
        'TXTNoHp
        '
        Me.TXTNoHp.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNoHp.Location = New System.Drawing.Point(143, 185)
        Me.TXTNoHp.Name = "TXTNoHp"
        Me.TXTNoHp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TXTNoHp.Size = New System.Drawing.Size(261, 22)
        Me.TXTNoHp.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(35, 163)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 16)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Jenis Kelamin"
        '
        'TXTNamaDosen
        '
        Me.TXTNamaDosen.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNamaDosen.Location = New System.Drawing.Point(143, 127)
        Me.TXTNamaDosen.Name = "TXTNamaDosen"
        Me.TXTNamaDosen.Size = New System.Drawing.Size(261, 22)
        Me.TXTNamaDosen.TabIndex = 8
        '
        'CMBJurusan
        '
        Me.CMBJurusan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBJurusan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CMBJurusan.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBJurusan.FormattingEnabled = True
        Me.CMBJurusan.Location = New System.Drawing.Point(241, 69)
        Me.CMBJurusan.Name = "CMBJurusan"
        Me.CMBJurusan.Size = New System.Drawing.Size(341, 24)
        Me.CMBJurusan.TabIndex = 7
        '
        'TXTNIDN
        '
        Me.TXTNIDN.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNIDN.Location = New System.Drawing.Point(143, 99)
        Me.TXTNIDN.Name = "TXTNIDN"
        Me.TXTNIDN.Size = New System.Drawing.Size(121, 22)
        Me.TXTNIDN.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(35, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 16)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Nama Dosen"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(36, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 16)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "NIDN"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(36, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "KODE PRODI"
        '
        'LbNIK
        '
        Me.LbNIK.AutoSize = True
        Me.LbNIK.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNIK.Location = New System.Drawing.Point(36, 36)
        Me.LbNIK.Name = "LbNIK"
        Me.LbNIK.Size = New System.Drawing.Size(93, 16)
        Me.LbNIK.TabIndex = 0
        Me.LbNIK.Text = "KODE DOSEN"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Bisque
        Me.Panel2.Controls.Add(Me.LBKodeProdi)
        Me.Panel2.Controls.Add(Me.LBKodeDosen)
        Me.Panel2.Controls.Add(Me.TXTEmailDosen)
        Me.Panel2.Controls.Add(Me.CMBJKDosen)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.TXTNoHp)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.TXTNamaDosen)
        Me.Panel2.Controls.Add(Me.CMBJurusan)
        Me.Panel2.Controls.Add(Me.TXTNIDN)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.LbNIK)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 54)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(669, 406)
        Me.Panel2.TabIndex = 5
        '
        'LBKodeProdi
        '
        Me.LBKodeProdi.BackColor = System.Drawing.Color.DarkSalmon
        Me.LBKodeProdi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBKodeProdi.Location = New System.Drawing.Point(140, 68)
        Me.LBKodeProdi.Name = "LBKodeProdi"
        Me.LBKodeProdi.Size = New System.Drawing.Size(95, 23)
        Me.LBKodeProdi.TabIndex = 21
        Me.LBKodeProdi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LBKodeDosen
        '
        Me.LBKodeDosen.BackColor = System.Drawing.Color.DarkSalmon
        Me.LBKodeDosen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBKodeDosen.Location = New System.Drawing.Point(140, 33)
        Me.LBKodeDosen.Name = "LBKodeDosen"
        Me.LBKodeDosen.Size = New System.Drawing.Size(95, 23)
        Me.LBKodeDosen.TabIndex = 20
        Me.LBKodeDosen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TXTEmailDosen
        '
        Me.TXTEmailDosen.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTEmailDosen.Location = New System.Drawing.Point(143, 217)
        Me.TXTEmailDosen.Name = "TXTEmailDosen"
        Me.TXTEmailDosen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TXTEmailDosen.Size = New System.Drawing.Size(261, 22)
        Me.TXTEmailDosen.TabIndex = 19
        '
        'CMBJKDosen
        '
        Me.CMBJKDosen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBJKDosen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CMBJKDosen.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBJKDosen.FormattingEnabled = True
        Me.CMBJKDosen.Location = New System.Drawing.Point(143, 155)
        Me.CMBJKDosen.Name = "CMBJKDosen"
        Me.CMBJKDosen.Size = New System.Drawing.Size(121, 24)
        Me.CMBJKDosen.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(264, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "::BIODATA DOSEN::"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSalmon
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(669, 54)
        Me.Panel1.TabIndex = 4
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ErrorProvider2
        '
        Me.ErrorProvider2.ContainerControl = Me
        '
        'FrmBiodataDosen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 460)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.IsMdiContainer = True
        Me.Name = "FrmBiodataDosen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmBiodata"
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BTNKELUARBiodata As Button
    Friend WithEvents BTNSIMPANBiodata As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BTNHAPUSBiodata As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TXTNoHp As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TXTNamaDosen As TextBox
    Friend WithEvents CMBJurusan As ComboBox
    Friend WithEvents TXTNIDN As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LbNIK As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CMBJKDosen As ComboBox
    Friend WithEvents TXTEmailDosen As TextBox
    Friend WithEvents LBKodeDosen As Label
    Friend WithEvents LBKodeProdi As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ErrorProvider2 As ErrorProvider
End Class
