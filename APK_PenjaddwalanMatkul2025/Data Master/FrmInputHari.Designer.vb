<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmInputHari
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TXTNamaHari = New System.Windows.Forms.TextBox()
        Me.LBKodeHari = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BTNKeluarHari = New System.Windows.Forms.Button()
        Me.BTNHapusHari = New System.Windows.Forms.Button()
        Me.BTNSimpanHari = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSalmon
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(566, 62)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(221, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "::DATA HARI::"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Bisque
        Me.Panel2.Controls.Add(Me.TXTNamaHari)
        Me.Panel2.Controls.Add(Me.LBKodeHari)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 62)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(566, 198)
        Me.Panel2.TabIndex = 1
        '
        'TXTNamaHari
        '
        Me.TXTNamaHari.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNamaHari.Location = New System.Drawing.Point(146, 105)
        Me.TXTNamaHari.Multiline = True
        Me.TXTNamaHari.Name = "TXTNamaHari"
        Me.TXTNamaHari.Size = New System.Drawing.Size(245, 20)
        Me.TXTNamaHari.TabIndex = 3
        '
        'LBKodeHari
        '
        Me.LBKodeHari.BackColor = System.Drawing.Color.LightSalmon
        Me.LBKodeHari.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBKodeHari.Location = New System.Drawing.Point(146, 71)
        Me.LBKodeHari.Name = "LBKodeHari"
        Me.LBKodeHari.Size = New System.Drawing.Size(183, 23)
        Me.LBKodeHari.TabIndex = 2
        Me.LBKodeHari.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(39, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 18)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "NAMA HARI"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(39, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "KODE HARI"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkSalmon
        Me.Panel3.Controls.Add(Me.BTNKeluarHari)
        Me.Panel3.Controls.Add(Me.BTNHapusHari)
        Me.Panel3.Controls.Add(Me.BTNSimpanHari)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 260)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(566, 87)
        Me.Panel3.TabIndex = 2
        '
        'BTNKeluarHari
        '
        Me.BTNKeluarHari.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNKeluarHari.Location = New System.Drawing.Point(358, 17)
        Me.BTNKeluarHari.Name = "BTNKeluarHari"
        Me.BTNKeluarHari.Size = New System.Drawing.Size(111, 49)
        Me.BTNKeluarHari.TabIndex = 3
        Me.BTNKeluarHari.Text = "&KELUAR"
        Me.BTNKeluarHari.UseVisualStyleBackColor = True
        '
        'BTNHapusHari
        '
        Me.BTNHapusHari.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNHapusHari.Location = New System.Drawing.Point(223, 17)
        Me.BTNHapusHari.Name = "BTNHapusHari"
        Me.BTNHapusHari.Size = New System.Drawing.Size(111, 49)
        Me.BTNHapusHari.TabIndex = 2
        Me.BTNHapusHari.Text = "&HAPUS"
        Me.BTNHapusHari.UseVisualStyleBackColor = True
        '
        'BTNSimpanHari
        '
        Me.BTNSimpanHari.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNSimpanHari.Location = New System.Drawing.Point(89, 17)
        Me.BTNSimpanHari.Name = "BTNSimpanHari"
        Me.BTNSimpanHari.Size = New System.Drawing.Size(111, 49)
        Me.BTNSimpanHari.TabIndex = 1
        Me.BTNSimpanHari.Text = "&SIMPAN"
        Me.BTNSimpanHari.UseVisualStyleBackColor = True
        '
        'FrmInputHari
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 347)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmInputHari"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmHari"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents TXTNamaHari As TextBox
    Friend WithEvents LBKodeHari As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BTNKeluarHari As Button
    Friend WithEvents BTNHapusHari As Button
    Friend WithEvents BTNSimpanHari As Button
End Class
