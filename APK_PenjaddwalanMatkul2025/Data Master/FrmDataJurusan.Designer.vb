<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDataJurusan
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
        Me.DataGridJurusan = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BTNCariJurusan = New System.Windows.Forms.Button()
        Me.BTNKeluarJurusan = New System.Windows.Forms.Button()
        Me.BTNTambahJurusan = New System.Windows.Forms.Button()
        Me.TXTCariJurusan = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.DataGridJurusan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridJurusan
        '
        Me.DataGridJurusan.AllowUserToDeleteRows = False
        Me.DataGridJurusan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridJurusan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridJurusan.Location = New System.Drawing.Point(0, 147)
        Me.DataGridJurusan.Name = "DataGridJurusan"
        Me.DataGridJurusan.ReadOnly = True
        Me.DataGridJurusan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridJurusan.Size = New System.Drawing.Size(934, 270)
        Me.DataGridJurusan.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSalmon
        Me.Panel1.Controls.Add(Me.BTNCariJurusan)
        Me.Panel1.Controls.Add(Me.BTNKeluarJurusan)
        Me.Panel1.Controls.Add(Me.BTNTambahJurusan)
        Me.Panel1.Controls.Add(Me.TXTCariJurusan)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 57)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(934, 90)
        Me.Panel1.TabIndex = 6
        '
        'BTNCariJurusan
        '
        Me.BTNCariJurusan.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTNCariJurusan.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCariJurusan.Location = New System.Drawing.Point(336, 27)
        Me.BTNCariJurusan.Name = "BTNCariJurusan"
        Me.BTNCariJurusan.Size = New System.Drawing.Size(71, 31)
        Me.BTNCariJurusan.TabIndex = 6
        Me.BTNCariJurusan.Text = "CARI"
        Me.BTNCariJurusan.UseVisualStyleBackColor = True
        '
        'BTNKeluarJurusan
        '
        Me.BTNKeluarJurusan.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BTNKeluarJurusan.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNKeluarJurusan.Location = New System.Drawing.Point(785, 24)
        Me.BTNKeluarJurusan.Name = "BTNKeluarJurusan"
        Me.BTNKeluarJurusan.Size = New System.Drawing.Size(123, 37)
        Me.BTNKeluarJurusan.TabIndex = 5
        Me.BTNKeluarJurusan.Text = "&KELUAR"
        Me.BTNKeluarJurusan.UseVisualStyleBackColor = True
        '
        'BTNTambahJurusan
        '
        Me.BTNTambahJurusan.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNTambahJurusan.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNTambahJurusan.Location = New System.Drawing.Point(656, 24)
        Me.BTNTambahJurusan.Name = "BTNTambahJurusan"
        Me.BTNTambahJurusan.Size = New System.Drawing.Size(123, 37)
        Me.BTNTambahJurusan.TabIndex = 4
        Me.BTNTambahJurusan.Text = "TAMBAH DATA"
        Me.BTNTambahJurusan.UseVisualStyleBackColor = True
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
        Me.Label3.Size = New System.Drawing.Size(98, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cari Jurusan"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Salmon
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(934, 57)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "DATA JURUSAN"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Salmon
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(0, 417)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(934, 33)
        Me.Label4.TabIndex = 8
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmDataJurusan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 450)
        Me.Controls.Add(Me.DataGridJurusan)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Name = "FrmDataJurusan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmDataJurusan"
        CType(Me.DataGridJurusan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridJurusan As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BTNCariJurusan As Button
    Friend WithEvents BTNKeluarJurusan As Button
    Friend WithEvents BTNTambahJurusan As Button
    Friend WithEvents TXTCariJurusan As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
End Class
