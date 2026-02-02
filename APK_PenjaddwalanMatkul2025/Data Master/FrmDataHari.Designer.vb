<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDataHari
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
        Me.BTNCariHari = New System.Windows.Forms.Button()
        Me.TXTCariHari = New System.Windows.Forms.TextBox()
        Me.BTNKeluarDataHari = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BTNTambahHari = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DataGridHari = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridHari, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSalmon
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(979, 61)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(433, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "::DATA HARI::"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Bisque
        Me.Panel2.Controls.Add(Me.BTNCariHari)
        Me.Panel2.Controls.Add(Me.TXTCariHari)
        Me.Panel2.Controls.Add(Me.BTNKeluarDataHari)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.BTNTambahHari)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 61)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(979, 71)
        Me.Panel2.TabIndex = 1
        '
        'BTNCariHari
        '
        Me.BTNCariHari.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCariHari.Location = New System.Drawing.Point(412, 17)
        Me.BTNCariHari.Name = "BTNCariHari"
        Me.BTNCariHari.Size = New System.Drawing.Size(90, 37)
        Me.BTNCariHari.TabIndex = 5
        Me.BTNCariHari.Text = "CARI"
        Me.BTNCariHari.UseVisualStyleBackColor = True
        '
        'TXTCariHari
        '
        Me.TXTCariHari.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCariHari.Location = New System.Drawing.Point(100, 25)
        Me.TXTCariHari.Multiline = True
        Me.TXTCariHari.Name = "TXTCariHari"
        Me.TXTCariHari.Size = New System.Drawing.Size(288, 20)
        Me.TXTCariHari.TabIndex = 4
        '
        'BTNKeluarDataHari
        '
        Me.BTNKeluarDataHari.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNKeluarDataHari.Location = New System.Drawing.Point(800, 17)
        Me.BTNKeluarDataHari.Name = "BTNKeluarDataHari"
        Me.BTNKeluarDataHari.Size = New System.Drawing.Size(90, 37)
        Me.BTNKeluarDataHari.TabIndex = 3
        Me.BTNKeluarDataHari.Text = "&KELUAR"
        Me.BTNKeluarDataHari.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NAMA HARI"
        '
        'BTNTambahHari
        '
        Me.BTNTambahHari.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNTambahHari.Location = New System.Drawing.Point(681, 17)
        Me.BTNTambahHari.Name = "BTNTambahHari"
        Me.BTNTambahHari.Size = New System.Drawing.Size(90, 37)
        Me.BTNTambahHari.TabIndex = 0
        Me.BTNTambahHari.Text = "TAMBAH"
        Me.BTNTambahHari.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkSalmon
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 400)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(979, 50)
        Me.Panel3.TabIndex = 2
        '
        'DataGridHari
        '
        Me.DataGridHari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridHari.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridHari.Location = New System.Drawing.Point(0, 132)
        Me.DataGridHari.Name = "DataGridHari"
        Me.DataGridHari.Size = New System.Drawing.Size(979, 268)
        Me.DataGridHari.TabIndex = 3
        '
        'FrmDataHari
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(979, 450)
        Me.Controls.Add(Me.DataGridHari)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmDataHari"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmHari"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridHari, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DataGridHari As DataGridView
    Friend WithEvents BTNTambahHari As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TXTCariHari As TextBox
    Friend WithEvents BTNKeluarDataHari As Button
    Friend WithEvents BTNCariHari As Button
End Class
