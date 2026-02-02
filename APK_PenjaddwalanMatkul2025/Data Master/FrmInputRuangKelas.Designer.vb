<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInputRuangKelas
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
        Me.BTNKELUARRuangan = New System.Windows.Forms.Button()
        Me.BTNHAPUSRuangan = New System.Windows.Forms.Button()
        Me.BTNSIMPANRUANGKELAS = New System.Windows.Forms.Button()
        Me.TXTNamaKelas = New System.Windows.Forms.TextBox()
        Me.LBKodeRuangan = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXTKapasitas = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
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
        Me.Panel1.Size = New System.Drawing.Size(586, 56)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(175, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(237, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "::INPUT RUANG KELAS::"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkSalmon
        Me.Panel2.Controls.Add(Me.BTNKELUARRuangan)
        Me.Panel2.Controls.Add(Me.BTNHAPUSRuangan)
        Me.Panel2.Controls.Add(Me.BTNSIMPANRUANGKELAS)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 259)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(586, 105)
        Me.Panel2.TabIndex = 2
        '
        'BTNKELUARRuangan
        '
        Me.BTNKELUARRuangan.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNKELUARRuangan.Location = New System.Drawing.Point(363, 25)
        Me.BTNKELUARRuangan.Name = "BTNKELUARRuangan"
        Me.BTNKELUARRuangan.Size = New System.Drawing.Size(108, 55)
        Me.BTNKELUARRuangan.TabIndex = 5
        Me.BTNKELUARRuangan.Text = "&KELUAR"
        Me.BTNKELUARRuangan.UseVisualStyleBackColor = True
        '
        'BTNHAPUSRuangan
        '
        Me.BTNHAPUSRuangan.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNHAPUSRuangan.Location = New System.Drawing.Point(232, 25)
        Me.BTNHAPUSRuangan.Name = "BTNHAPUSRuangan"
        Me.BTNHAPUSRuangan.Size = New System.Drawing.Size(108, 55)
        Me.BTNHAPUSRuangan.TabIndex = 4
        Me.BTNHAPUSRuangan.Text = "HAPUS"
        Me.BTNHAPUSRuangan.UseVisualStyleBackColor = True
        '
        'BTNSIMPANRUANGKELAS
        '
        Me.BTNSIMPANRUANGKELAS.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNSIMPANRUANGKELAS.Location = New System.Drawing.Point(107, 25)
        Me.BTNSIMPANRUANGKELAS.Name = "BTNSIMPANRUANGKELAS"
        Me.BTNSIMPANRUANGKELAS.Size = New System.Drawing.Size(102, 55)
        Me.BTNSIMPANRUANGKELAS.TabIndex = 3
        Me.BTNSIMPANRUANGKELAS.Text = "&SIMPAN"
        Me.BTNSIMPANRUANGKELAS.UseVisualStyleBackColor = True
        '
        'TXTNamaKelas
        '
        Me.TXTNamaKelas.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNamaKelas.Location = New System.Drawing.Point(179, 154)
        Me.TXTNamaKelas.Multiline = True
        Me.TXTNamaKelas.Name = "TXTNamaKelas"
        Me.TXTNamaKelas.Size = New System.Drawing.Size(245, 20)
        Me.TXTNamaKelas.TabIndex = 7
        '
        'LBKodeRuangan
        '
        Me.LBKodeRuangan.BackColor = System.Drawing.Color.LightSalmon
        Me.LBKodeRuangan.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBKodeRuangan.Location = New System.Drawing.Point(179, 119)
        Me.LBKodeRuangan.Name = "LBKodeRuangan"
        Me.LBKodeRuangan.Size = New System.Drawing.Size(183, 23)
        Me.LBKodeRuangan.TabIndex = 6
        Me.LBKodeRuangan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(38, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "NAMA RUANGAN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "KODE RUANGAN"
        '
        'TXTKapasitas
        '
        Me.TXTKapasitas.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTKapasitas.Location = New System.Drawing.Point(179, 191)
        Me.TXTKapasitas.Multiline = True
        Me.TXTKapasitas.Name = "TXTKapasitas"
        Me.TXTKapasitas.Size = New System.Drawing.Size(245, 20)
        Me.TXTKapasitas.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(38, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 18)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "KAPASITAS"
        '
        'FrmInputRuangKelas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Bisque
        Me.ClientSize = New System.Drawing.Size(586, 364)
        Me.Controls.Add(Me.TXTKapasitas)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TXTNamaKelas)
        Me.Controls.Add(Me.LBKodeRuangan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmInputRuangKelas"
        Me.Text = "FrmInputRuangKelas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BTNKELUARRuangan As Button
    Friend WithEvents BTNHAPUSRuangan As Button
    Friend WithEvents BTNSIMPANRUANGKELAS As Button
    Friend WithEvents TXTNamaKelas As TextBox
    Friend WithEvents LBKodeRuangan As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TXTKapasitas As TextBox
    Friend WithEvents Label4 As Label
End Class
