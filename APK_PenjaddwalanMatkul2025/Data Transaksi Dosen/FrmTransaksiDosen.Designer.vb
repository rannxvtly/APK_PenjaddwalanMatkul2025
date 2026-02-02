<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmTransaksiDosen
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTransaksiDosen))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LBProdiPengampu = New System.Windows.Forms.Label()
        Me.BTNKeluarTransaksiPagging = New System.Windows.Forms.Button()
        Me.BTNTambahDataTransaksiDosen = New System.Windows.Forms.Button()
        Me.LBNamaDosenTransaksi = New System.Windows.Forms.Label()
        Me.LBNIDNTransaksi = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXTKodeDosenTransaksi = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CMBNamaSemester = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CMBJurusanTransksiDosen = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridTransaksiDosen = New System.Windows.Forms.DataGridView()
        Me.ComboBoxEntriesTransaksiDosen = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveNextItemTD = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItemTD = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItemTD = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveLastItemTD = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LBJumlahBarisData = New System.Windows.Forms.Label()
        Me.LBHalamanTransaksiDosen = New System.Windows.Forms.Label()
        Me.LBTotalBarisTransaksiDosen = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridTransaksiDosen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Salmon
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1413, 64)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(563, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(391, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "::DATA TRANSAKSI DOSEN PENGAMPU::"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkSalmon
        Me.Panel2.Controls.Add(Me.LBProdiPengampu)
        Me.Panel2.Controls.Add(Me.BTNKeluarTransaksiPagging)
        Me.Panel2.Controls.Add(Me.BTNTambahDataTransaksiDosen)
        Me.Panel2.Controls.Add(Me.LBNamaDosenTransaksi)
        Me.Panel2.Controls.Add(Me.LBNIDNTransaksi)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.TXTKodeDosenTransaksi)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.CMBNamaSemester)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.CMBJurusanTransksiDosen)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 64)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1413, 176)
        Me.Panel2.TabIndex = 1
        '
        'LBProdiPengampu
        '
        Me.LBProdiPengampu.BackColor = System.Drawing.Color.Bisque
        Me.LBProdiPengampu.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBProdiPengampu.Location = New System.Drawing.Point(144, 19)
        Me.LBProdiPengampu.Name = "LBProdiPengampu"
        Me.LBProdiPengampu.Size = New System.Drawing.Size(110, 23)
        Me.LBProdiPengampu.TabIndex = 12
        Me.LBProdiPengampu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BTNKeluarTransaksiPagging
        '
        Me.BTNKeluarTransaksiPagging.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNKeluarTransaksiPagging.Location = New System.Drawing.Point(1209, 69)
        Me.BTNKeluarTransaksiPagging.Name = "BTNKeluarTransaksiPagging"
        Me.BTNKeluarTransaksiPagging.Size = New System.Drawing.Size(147, 54)
        Me.BTNKeluarTransaksiPagging.TabIndex = 11
        Me.BTNKeluarTransaksiPagging.Text = "&KELUAR"
        Me.BTNKeluarTransaksiPagging.UseVisualStyleBackColor = True
        '
        'BTNTambahDataTransaksiDosen
        '
        Me.BTNTambahDataTransaksiDosen.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNTambahDataTransaksiDosen.Location = New System.Drawing.Point(1056, 69)
        Me.BTNTambahDataTransaksiDosen.Name = "BTNTambahDataTransaksiDosen"
        Me.BTNTambahDataTransaksiDosen.Size = New System.Drawing.Size(147, 54)
        Me.BTNTambahDataTransaksiDosen.TabIndex = 10
        Me.BTNTambahDataTransaksiDosen.Text = "TAMBAH DATA"
        Me.BTNTambahDataTransaksiDosen.UseVisualStyleBackColor = True
        '
        'LBNamaDosenTransaksi
        '
        Me.LBNamaDosenTransaksi.BackColor = System.Drawing.Color.Bisque
        Me.LBNamaDosenTransaksi.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBNamaDosenTransaksi.Location = New System.Drawing.Point(143, 130)
        Me.LBNamaDosenTransaksi.Name = "LBNamaDosenTransaksi"
        Me.LBNamaDosenTransaksi.Size = New System.Drawing.Size(142, 23)
        Me.LBNamaDosenTransaksi.TabIndex = 9
        Me.LBNamaDosenTransaksi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LBNIDNTransaksi
        '
        Me.LBNIDNTransaksi.BackColor = System.Drawing.Color.Bisque
        Me.LBNIDNTransaksi.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBNIDNTransaksi.Location = New System.Drawing.Point(143, 100)
        Me.LBNIDNTransaksi.Name = "LBNIDNTransaksi"
        Me.LBNIDNTransaksi.Size = New System.Drawing.Size(142, 23)
        Me.LBNIDNTransaksi.TabIndex = 8
        Me.LBNIDNTransaksi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 133)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 16)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Nama Dosen"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "NIDN"
        '
        'TXTKodeDosenTransaksi
        '
        Me.TXTKodeDosenTransaksi.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTKodeDosenTransaksi.Location = New System.Drawing.Point(143, 75)
        Me.TXTKodeDosenTransaksi.Multiline = True
        Me.TXTKodeDosenTransaksi.Name = "TXTKodeDosenTransaksi"
        Me.TXTKodeDosenTransaksi.Size = New System.Drawing.Size(142, 20)
        Me.TXTKodeDosenTransaksi.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Kode Dosen"
        '
        'CMBNamaSemester
        '
        Me.CMBNamaSemester.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBNamaSemester.FormattingEnabled = True
        Me.CMBNamaSemester.Location = New System.Drawing.Point(143, 45)
        Me.CMBNamaSemester.Name = "CMBNamaSemester"
        Me.CMBNamaSemester.Size = New System.Drawing.Size(142, 24)
        Me.CMBNamaSemester.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama Semester"
        '
        'CMBJurusanTransksiDosen
        '
        Me.CMBJurusanTransksiDosen.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBJurusanTransksiDosen.FormattingEnabled = True
        Me.CMBJurusanTransksiDosen.Location = New System.Drawing.Point(260, 18)
        Me.CMBJurusanTransksiDosen.Name = "CMBJurusanTransksiDosen"
        Me.CMBJurusanTransksiDosen.Size = New System.Drawing.Size(402, 24)
        Me.CMBJurusanTransksiDosen.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nama Jurusan"
        '
        'DataGridTransaksiDosen
        '
        Me.DataGridTransaksiDosen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridTransaksiDosen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridTransaksiDosen.Location = New System.Drawing.Point(0, 274)
        Me.DataGridTransaksiDosen.Name = "DataGridTransaksiDosen"
        Me.DataGridTransaksiDosen.Size = New System.Drawing.Size(1413, 443)
        Me.DataGridTransaksiDosen.TabIndex = 2
        '
        'ComboBoxEntriesTransaksiDosen
        '
        Me.ComboBoxEntriesTransaksiDosen.FormattingEnabled = True
        Me.ComboBoxEntriesTransaksiDosen.Location = New System.Drawing.Point(349, 246)
        Me.ComboBoxEntriesTransaksiDosen.Name = "ComboBoxEntriesTransaksiDosen"
        Me.ComboBoxEntriesTransaksiDosen.Size = New System.Drawing.Size(62, 21)
        Me.ComboBoxEntriesTransaksiDosen.TabIndex = 22
        Me.ComboBoxEntriesTransaksiDosen.Text = "10"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.DarkSalmon
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(267, 248)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 15)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Tampil Data:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.AutoSize = False
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorMoveNextItemTD
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItemTD, Me.BindingNavigatorMovePreviousItemTD, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItemTD, Me.BindingNavigatorMoveLastItemTD, Me.BindingNavigatorSeparator2})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 240)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItemTD
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItemTD
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItemTD
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItemTD
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(1413, 34)
        Me.BindingNavigator1.TabIndex = 20
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveNextItemTD
        '
        Me.BindingNavigatorMoveNextItemTD.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItemTD.Image = CType(resources.GetObject("BindingNavigatorMoveNextItemTD.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItemTD.Name = "BindingNavigatorMoveNextItemTD"
        Me.BindingNavigatorMoveNextItemTD.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItemTD.Size = New System.Drawing.Size(23, 31)
        Me.BindingNavigatorMoveNextItemTD.Text = "of {0}"
        '
        'BindingNavigatorMoveFirstItemTD
        '
        Me.BindingNavigatorMoveFirstItemTD.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItemTD.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItemTD.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItemTD.Name = "BindingNavigatorMoveFirstItemTD"
        Me.BindingNavigatorMoveFirstItemTD.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItemTD.Size = New System.Drawing.Size(23, 31)
        Me.BindingNavigatorMoveFirstItemTD.Text = "of {0}"
        '
        'BindingNavigatorMovePreviousItemTD
        '
        Me.BindingNavigatorMovePreviousItemTD.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItemTD.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItemTD.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItemTD.Name = "BindingNavigatorMovePreviousItemTD"
        Me.BindingNavigatorMovePreviousItemTD.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItemTD.Size = New System.Drawing.Size(23, 31)
        Me.BindingNavigatorMovePreviousItemTD.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 34)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 31)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 34)
        '
        'BindingNavigatorMoveLastItemTD
        '
        Me.BindingNavigatorMoveLastItemTD.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItemTD.Image = CType(resources.GetObject("BindingNavigatorMoveLastItemTD.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItemTD.Name = "BindingNavigatorMoveLastItemTD"
        Me.BindingNavigatorMoveLastItemTD.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItemTD.Size = New System.Drawing.Size(23, 31)
        Me.BindingNavigatorMoveLastItemTD.Text = "of {0}"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 34)
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Salmon
        Me.Panel3.Controls.Add(Me.LBJumlahBarisData)
        Me.Panel3.Controls.Add(Me.LBHalamanTransaksiDosen)
        Me.Panel3.Controls.Add(Me.LBTotalBarisTransaksiDosen)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 717)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1413, 100)
        Me.Panel3.TabIndex = 23
        '
        'LBJumlahBarisData
        '
        Me.LBJumlahBarisData.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBJumlahBarisData.AutoSize = True
        Me.LBJumlahBarisData.BackColor = System.Drawing.Color.Silver
        Me.LBJumlahBarisData.Location = New System.Drawing.Point(1144, 52)
        Me.LBJumlahBarisData.Name = "LBJumlahBarisData"
        Me.LBJumlahBarisData.Size = New System.Drawing.Size(83, 13)
        Me.LBJumlahBarisData.TabIndex = 25
        Me.LBJumlahBarisData.Text = "Jumlah Baris Ini:"
        '
        'LBHalamanTransaksiDosen
        '
        Me.LBHalamanTransaksiDosen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LBHalamanTransaksiDosen.BackColor = System.Drawing.Color.PeachPuff
        Me.LBHalamanTransaksiDosen.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBHalamanTransaksiDosen.ForeColor = System.Drawing.Color.Red
        Me.LBHalamanTransaksiDosen.Location = New System.Drawing.Point(144, 51)
        Me.LBHalamanTransaksiDosen.Name = "LBHalamanTransaksiDosen"
        Me.LBHalamanTransaksiDosen.Size = New System.Drawing.Size(141, 20)
        Me.LBHalamanTransaksiDosen.TabIndex = 24
        Me.LBHalamanTransaksiDosen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LBTotalBarisTransaksiDosen
        '
        Me.LBTotalBarisTransaksiDosen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LBTotalBarisTransaksiDosen.AutoSize = True
        Me.LBTotalBarisTransaksiDosen.BackColor = System.Drawing.Color.Silver
        Me.LBTotalBarisTransaksiDosen.Location = New System.Drawing.Point(66, 36)
        Me.LBTotalBarisTransaksiDosen.Name = "LBTotalBarisTransaksiDosen"
        Me.LBTotalBarisTransaksiDosen.Size = New System.Drawing.Size(63, 13)
        Me.LBTotalBarisTransaksiDosen.TabIndex = 22
        Me.LBTotalBarisTransaksiDosen.Text = "Total Baris :"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Silver
        Me.Label10.Location = New System.Drawing.Point(66, 55)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 13)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Jumlah Hal:"
        '
        'FrmTransaksiDosen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1413, 817)
        Me.Controls.Add(Me.DataGridTransaksiDosen)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.ComboBoxEntriesTransaksiDosen)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmTransaksiDosen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmTransaksiDosen"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridTransaksiDosen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGridTransaksiDosen As DataGridView
    Friend WithEvents ComboBoxEntriesTransaksiDosen As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents BindingNavigatorMoveNextItemTD As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItemTD As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItemTD As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveLastItemTD As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BTNKeluarTransaksiPagging As Button
    Friend WithEvents BTNTambahDataTransaksiDosen As Button
    Friend WithEvents LBNamaDosenTransaksi As Label
    Friend WithEvents LBNIDNTransaksi As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TXTKodeDosenTransaksi As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CMBNamaSemester As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CMBJurusanTransksiDosen As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents LBJumlahBarisData As Label
    Friend WithEvents LBHalamanTransaksiDosen As Label
    Friend WithEvents LBTotalBarisTransaksiDosen As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents LBProdiPengampu As Label
End Class
