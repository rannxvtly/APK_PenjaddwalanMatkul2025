<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRuangKelas
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.BTNCariKelas = New System.Windows.Forms.Button()
        Me.BTNKeluarKelas = New System.Windows.Forms.Button()
        Me.BTNTambahKelas = New System.Windows.Forms.Button()
        Me.TXTCariJurusan = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridKelas = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.DataGridKelas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkSalmon
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 466)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(781, 43)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 56)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(781, 78)
        Me.Panel3.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Bisque
        Me.Panel4.Controls.Add(Me.BTNCariKelas)
        Me.Panel4.Controls.Add(Me.BTNKeluarKelas)
        Me.Panel4.Controls.Add(Me.BTNTambahKelas)
        Me.Panel4.Controls.Add(Me.TXTCariJurusan)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(781, 90)
        Me.Panel4.TabIndex = 7
        '
        'BTNCariKelas
        '
        Me.BTNCariKelas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTNCariKelas.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCariKelas.Location = New System.Drawing.Point(336, 27)
        Me.BTNCariKelas.Name = "BTNCariKelas"
        Me.BTNCariKelas.Size = New System.Drawing.Size(71, 31)
        Me.BTNCariKelas.TabIndex = 6
        Me.BTNCariKelas.Text = "CARI"
        Me.BTNCariKelas.UseVisualStyleBackColor = True
        '
        'BTNKeluarKelas
        '
        Me.BTNKeluarKelas.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BTNKeluarKelas.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNKeluarKelas.Location = New System.Drawing.Point(632, 24)
        Me.BTNKeluarKelas.Name = "BTNKeluarKelas"
        Me.BTNKeluarKelas.Size = New System.Drawing.Size(123, 37)
        Me.BTNKeluarKelas.TabIndex = 5
        Me.BTNKeluarKelas.Text = "&KELUAR"
        Me.BTNKeluarKelas.UseVisualStyleBackColor = True
        '
        'BTNTambahKelas
        '
        Me.BTNTambahKelas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNTambahKelas.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNTambahKelas.Location = New System.Drawing.Point(503, 24)
        Me.BTNTambahKelas.Name = "BTNTambahKelas"
        Me.BTNTambahKelas.Size = New System.Drawing.Size(123, 37)
        Me.BTNTambahKelas.TabIndex = 4
        Me.BTNTambahKelas.Text = "TAMBAH DATA"
        Me.BTNTambahKelas.UseVisualStyleBackColor = True
        '
        'TXTCariJurusan
        '
        Me.TXTCariJurusan.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCariJurusan.Location = New System.Drawing.Point(127, 32)
        Me.TXTCariJurusan.Name = "TXTCariJurusan"
        Me.TXTCariJurusan.Size = New System.Drawing.Size(190, 20)
        Me.TXTCariJurusan.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cari Kelas"
        '
        'DataGridKelas
        '
        Me.DataGridKelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridKelas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridKelas.Location = New System.Drawing.Point(0, 134)
        Me.DataGridKelas.Name = "DataGridKelas"
        Me.DataGridKelas.Size = New System.Drawing.Size(781, 332)
        Me.DataGridKelas.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(293, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "::DATA RUANG KELAS::"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSalmon
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(781, 56)
        Me.Panel1.TabIndex = 0
        '
        'FrmRuangKelas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Bisque
        Me.ClientSize = New System.Drawing.Size(781, 509)
        Me.Controls.Add(Me.DataGridKelas)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmRuangKelas"
        Me.Text = "FrmRuangKelas"
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.DataGridKelas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents BTNCariKelas As Button
    Friend WithEvents BTNKeluarKelas As Button
    Friend WithEvents BTNTambahKelas As Button
    Friend WithEvents TXTCariJurusan As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridKelas As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
End Class
