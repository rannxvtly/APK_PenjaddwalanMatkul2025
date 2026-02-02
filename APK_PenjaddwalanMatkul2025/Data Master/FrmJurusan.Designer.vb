<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmJurusan
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
        Me.LBLKODE = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BTNKELUARKode = New System.Windows.Forms.Button()
        Me.BTNHAPUSJurusan = New System.Windows.Forms.Button()
        Me.BTNSIMPANJURUSAN = New System.Windows.Forms.Button()
        Me.TxtNAMAPRODI = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LbJurusan = New System.Windows.Forms.Label()
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
        Me.Panel1.Size = New System.Drawing.Size(613, 54)
        Me.Panel1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(251, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "INPUT JURUSAN"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Bisque
        Me.Panel2.Controls.Add(Me.LBLKODE)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.TxtNAMAPRODI)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.LbJurusan)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(613, 303)
        Me.Panel2.TabIndex = 5
        '
        'LBLKODE
        '
        Me.LBLKODE.BackColor = System.Drawing.Color.DarkSalmon
        Me.LBLKODE.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLKODE.Location = New System.Drawing.Point(136, 92)
        Me.LBLKODE.Name = "LBLKODE"
        Me.LBLKODE.Size = New System.Drawing.Size(426, 23)
        Me.LBLKODE.TabIndex = 19
        Me.LBLKODE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkSalmon
        Me.Panel3.Controls.Add(Me.BTNKELUARKode)
        Me.Panel3.Controls.Add(Me.BTNHAPUSJurusan)
        Me.Panel3.Controls.Add(Me.BTNSIMPANJURUSAN)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 208)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(613, 95)
        Me.Panel3.TabIndex = 18
        '
        'BTNKELUARKode
        '
        Me.BTNKELUARKode.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNKELUARKode.Location = New System.Drawing.Point(362, 18)
        Me.BTNKELUARKode.Name = "BTNKELUARKode"
        Me.BTNKELUARKode.Size = New System.Drawing.Size(108, 55)
        Me.BTNKELUARKode.TabIndex = 2
        Me.BTNKELUARKode.Text = "&KELUAR"
        Me.BTNKELUARKode.UseVisualStyleBackColor = True
        '
        'BTNHAPUSJurusan
        '
        Me.BTNHAPUSJurusan.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNHAPUSJurusan.Location = New System.Drawing.Point(228, 18)
        Me.BTNHAPUSJurusan.Name = "BTNHAPUSJurusan"
        Me.BTNHAPUSJurusan.Size = New System.Drawing.Size(108, 55)
        Me.BTNHAPUSJurusan.TabIndex = 1
        Me.BTNHAPUSJurusan.Text = "HAPUS"
        Me.BTNHAPUSJurusan.UseVisualStyleBackColor = True
        '
        'BTNSIMPANJURUSAN
        '
        Me.BTNSIMPANJURUSAN.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNSIMPANJURUSAN.Location = New System.Drawing.Point(98, 18)
        Me.BTNSIMPANJURUSAN.Name = "BTNSIMPANJURUSAN"
        Me.BTNSIMPANJURUSAN.Size = New System.Drawing.Size(102, 55)
        Me.BTNSIMPANJURUSAN.TabIndex = 0
        Me.BTNSIMPANJURUSAN.Text = "&SIMPAN"
        Me.BTNSIMPANJURUSAN.UseVisualStyleBackColor = True
        '
        'TxtNAMAPRODI
        '
        Me.TxtNAMAPRODI.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNAMAPRODI.Location = New System.Drawing.Point(139, 137)
        Me.TxtNAMAPRODI.Multiline = True
        Me.TxtNAMAPRODI.Name = "TxtNAMAPRODI"
        Me.TxtNAMAPRODI.Size = New System.Drawing.Size(423, 20)
        Me.TxtNAMAPRODI.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(37, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "NAMA PRODI"
        '
        'LbJurusan
        '
        Me.LbJurusan.AutoSize = True
        Me.LbJurusan.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbJurusan.Location = New System.Drawing.Point(37, 95)
        Me.LbJurusan.Name = "LbJurusan"
        Me.LbJurusan.Size = New System.Drawing.Size(89, 16)
        Me.LbJurusan.TabIndex = 0
        Me.LbJurusan.Text = "KODE PRODI"
        '
        'FrmJurusan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(613, 303)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "FrmJurusan"
        Me.Text = "FrmJurusan"
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
    Friend WithEvents LBLKODE As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BTNKELUARKode As Button
    Friend WithEvents BTNHAPUSJurusan As Button
    Friend WithEvents BTNSIMPANJURUSAN As Button
    Friend WithEvents TxtNAMAPRODI As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents LbJurusan As Label
End Class
