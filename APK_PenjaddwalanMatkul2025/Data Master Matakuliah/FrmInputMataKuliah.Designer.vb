<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInputMataKuliah
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BTNKeluarMatkul = New System.Windows.Forms.Button()
        Me.BTNHapusMatkul = New System.Windows.Forms.Button()
        Me.BTNSimpanMatkul = New System.Windows.Forms.Button()
        Me.LBKDPRODIMATKUL = New System.Windows.Forms.Label()
        Me.CMBProdiMatkul = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CMBSEMESTER = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXTKodeMatkul = New System.Windows.Forms.TextBox()
        Me.TXTNamaMatkul = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CMBSemesterMatkul = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TXTTeoriMatkul = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LBMenitTeori = New System.Windows.Forms.Label()
        Me.LBMenitPraktek = New System.Windows.Forms.Label()
        Me.TXTPraktekMatkul = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LBTotalTeoriPraktek = New System.Windows.Forms.Label()
        Me.TXTSKS = New System.Windows.Forms.TextBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSalmon
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(665, 70)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(146, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(366, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "::INPUT DATA MASTER MATAKULIAH::"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkSalmon
        Me.Panel2.Controls.Add(Me.BTNKeluarMatkul)
        Me.Panel2.Controls.Add(Me.BTNHapusMatkul)
        Me.Panel2.Controls.Add(Me.BTNSimpanMatkul)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 430)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(665, 98)
        Me.Panel2.TabIndex = 1
        '
        'BTNKeluarMatkul
        '
        Me.BTNKeluarMatkul.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNKeluarMatkul.Location = New System.Drawing.Point(412, 21)
        Me.BTNKeluarMatkul.Name = "BTNKeluarMatkul"
        Me.BTNKeluarMatkul.Size = New System.Drawing.Size(108, 55)
        Me.BTNKeluarMatkul.TabIndex = 5
        Me.BTNKeluarMatkul.Text = "&KELUAR"
        Me.BTNKeluarMatkul.UseVisualStyleBackColor = True
        '
        'BTNHapusMatkul
        '
        Me.BTNHapusMatkul.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNHapusMatkul.Location = New System.Drawing.Point(278, 21)
        Me.BTNHapusMatkul.Name = "BTNHapusMatkul"
        Me.BTNHapusMatkul.Size = New System.Drawing.Size(108, 55)
        Me.BTNHapusMatkul.TabIndex = 4
        Me.BTNHapusMatkul.Text = "HAPUS"
        Me.BTNHapusMatkul.UseVisualStyleBackColor = True
        '
        'BTNSimpanMatkul
        '
        Me.BTNSimpanMatkul.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNSimpanMatkul.Location = New System.Drawing.Point(148, 21)
        Me.BTNSimpanMatkul.Name = "BTNSimpanMatkul"
        Me.BTNSimpanMatkul.Size = New System.Drawing.Size(102, 55)
        Me.BTNSimpanMatkul.TabIndex = 3
        Me.BTNSimpanMatkul.Text = "&SIMPAN"
        Me.BTNSimpanMatkul.UseVisualStyleBackColor = True
        '
        'LBKDPRODIMATKUL
        '
        Me.LBKDPRODIMATKUL.BackColor = System.Drawing.Color.DarkSalmon
        Me.LBKDPRODIMATKUL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBKDPRODIMATKUL.Location = New System.Drawing.Point(183, 102)
        Me.LBKDPRODIMATKUL.Name = "LBKDPRODIMATKUL"
        Me.LBKDPRODIMATKUL.Size = New System.Drawing.Size(89, 23)
        Me.LBKDPRODIMATKUL.TabIndex = 24
        Me.LBKDPRODIMATKUL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CMBProdiMatkul
        '
        Me.CMBProdiMatkul.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBProdiMatkul.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CMBProdiMatkul.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBProdiMatkul.FormattingEnabled = True
        Me.CMBProdiMatkul.Location = New System.Drawing.Point(278, 102)
        Me.CMBProdiMatkul.Name = "CMBProdiMatkul"
        Me.CMBProdiMatkul.Size = New System.Drawing.Size(341, 24)
        Me.CMBProdiMatkul.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 16)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "NAMA JURUSAN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 16)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "NAMA SEMESTER"
        '
        'CMBSEMESTER
        '
        Me.CMBSEMESTER.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBSEMESTER.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBSEMESTER.FormattingEnabled = True
        Me.CMBSEMESTER.Location = New System.Drawing.Point(183, 132)
        Me.CMBSEMESTER.Name = "CMBSEMESTER"
        Me.CMBSEMESTER.Size = New System.Drawing.Size(100, 24)
        Me.CMBSEMESTER.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 16)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "KODE MATKUL"
        '
        'TXTKodeMatkul
        '
        Me.TXTKodeMatkul.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTKodeMatkul.Location = New System.Drawing.Point(183, 159)
        Me.TXTKodeMatkul.Multiline = True
        Me.TXTKodeMatkul.Name = "TXTKodeMatkul"
        Me.TXTKodeMatkul.Size = New System.Drawing.Size(100, 20)
        Me.TXTKodeMatkul.TabIndex = 28
        '
        'TXTNamaMatkul
        '
        Me.TXTNamaMatkul.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNamaMatkul.Location = New System.Drawing.Point(183, 185)
        Me.TXTNamaMatkul.Multiline = True
        Me.TXTNamaMatkul.Name = "TXTNamaMatkul"
        Me.TXTNamaMatkul.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TXTNamaMatkul.Size = New System.Drawing.Size(436, 74)
        Me.TXTNamaMatkul.TabIndex = 30
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 189)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 16)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "NAMA MATKUL"
        '
        'CMBSemesterMatkul
        '
        Me.CMBSemesterMatkul.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBSemesterMatkul.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBSemesterMatkul.FormattingEnabled = True
        Me.CMBSemesterMatkul.Location = New System.Drawing.Point(186, 272)
        Me.CMBSemesterMatkul.Name = "CMBSemesterMatkul"
        Me.CMBSemesterMatkul.Size = New System.Drawing.Size(129, 24)
        Me.CMBSemesterMatkul.TabIndex = 32
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 272)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 16)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "SEMESTER"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(24, 310)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 16)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "SKS"
        '
        'TXTTeoriMatkul
        '
        Me.TXTTeoriMatkul.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTTeoriMatkul.Location = New System.Drawing.Point(189, 344)
        Me.TXTTeoriMatkul.Multiline = True
        Me.TXTTeoriMatkul.Name = "TXTTeoriMatkul"
        Me.TXTTeoriMatkul.Size = New System.Drawing.Size(48, 20)
        Me.TXTTeoriMatkul.TabIndex = 36
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(24, 344)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 16)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "TEORI MATKUL"
        '
        'LBMenitTeori
        '
        Me.LBMenitTeori.BackColor = System.Drawing.Color.DarkSalmon
        Me.LBMenitTeori.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBMenitTeori.Location = New System.Drawing.Point(243, 344)
        Me.LBMenitTeori.Name = "LBMenitTeori"
        Me.LBMenitTeori.Size = New System.Drawing.Size(43, 23)
        Me.LBMenitTeori.TabIndex = 37
        Me.LBMenitTeori.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LBMenitPraktek
        '
        Me.LBMenitPraktek.BackColor = System.Drawing.Color.DarkSalmon
        Me.LBMenitPraktek.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBMenitPraktek.Location = New System.Drawing.Point(243, 377)
        Me.LBMenitPraktek.Name = "LBMenitPraktek"
        Me.LBMenitPraktek.Size = New System.Drawing.Size(43, 23)
        Me.LBMenitPraktek.TabIndex = 40
        Me.LBMenitPraktek.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TXTPraktekMatkul
        '
        Me.TXTPraktekMatkul.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPraktekMatkul.Location = New System.Drawing.Point(189, 377)
        Me.TXTPraktekMatkul.Multiline = True
        Me.TXTPraktekMatkul.Name = "TXTPraktekMatkul"
        Me.TXTPraktekMatkul.Size = New System.Drawing.Size(48, 20)
        Me.TXTPraktekMatkul.TabIndex = 39
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(24, 377)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(126, 16)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "PRAKTEK MATKUL"
        '
        'LBTotalTeoriPraktek
        '
        Me.LBTotalTeoriPraktek.BackColor = System.Drawing.Color.DarkSalmon
        Me.LBTotalTeoriPraktek.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBTotalTeoriPraktek.Location = New System.Drawing.Point(292, 377)
        Me.LBTotalTeoriPraktek.Name = "LBTotalTeoriPraktek"
        Me.LBTotalTeoriPraktek.Size = New System.Drawing.Size(43, 23)
        Me.LBTotalTeoriPraktek.TabIndex = 41
        Me.LBTotalTeoriPraktek.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TXTSKS
        '
        Me.TXTSKS.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTSKS.Location = New System.Drawing.Point(183, 310)
        Me.TXTSKS.Multiline = True
        Me.TXTSKS.Name = "TXTSKS"
        Me.TXTSKS.Size = New System.Drawing.Size(100, 20)
        Me.TXTSKS.TabIndex = 42
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'FrmInputMataKuliah
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Bisque
        Me.ClientSize = New System.Drawing.Size(665, 528)
        Me.Controls.Add(Me.TXTSKS)
        Me.Controls.Add(Me.LBTotalTeoriPraktek)
        Me.Controls.Add(Me.TXTNamaMatkul)
        Me.Controls.Add(Me.LBMenitPraktek)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TXTKodeMatkul)
        Me.Controls.Add(Me.TXTPraktekMatkul)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CMBSemesterMatkul)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.CMBSEMESTER)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LBMenitTeori)
        Me.Controls.Add(Me.LBKDPRODIMATKUL)
        Me.Controls.Add(Me.CMBProdiMatkul)
        Me.Controls.Add(Me.TXTTeoriMatkul)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmInputMataKuliah"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmInputMataKuliah"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LBKDPRODIMATKUL As Label
    Friend WithEvents CMBProdiMatkul As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CMBSEMESTER As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TXTKodeMatkul As TextBox
    Friend WithEvents TXTNamaMatkul As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents CMBSemesterMatkul As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TXTTeoriMatkul As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents LBMenitTeori As Label
    Friend WithEvents LBMenitPraktek As Label
    Friend WithEvents TXTPraktekMatkul As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents LBTotalTeoriPraktek As Label
    Friend WithEvents BTNKeluarMatkul As Button
    Friend WithEvents BTNHapusMatkul As Button
    Friend WithEvents BTNSimpanMatkul As Button
    Friend WithEvents TXTSKS As TextBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
