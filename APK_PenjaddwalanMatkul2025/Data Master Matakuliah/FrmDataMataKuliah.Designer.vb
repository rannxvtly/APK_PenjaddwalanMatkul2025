<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDataMataKuliah
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDataMataKuliah))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LBJumlahBarisMatkul = New System.Windows.Forms.Label()
        Me.LBBagiHalamanMatkul = New System.Windows.Forms.Label()
        Me.LbTotalBarisMatkul = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LBPRODIMatkul = New System.Windows.Forms.Label()
        Me.CBSemesterMatkul = New System.Windows.Forms.ComboBox()
        Me.CMBJenisGanjilGenap = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BTNCariMatkul = New System.Windows.Forms.Button()
        Me.BtnKeluarMatkul = New System.Windows.Forms.Button()
        Me.BtnTambahMatkul = New System.Windows.Forms.Button()
        Me.TxtCariNamaMatkul = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CBNamaJurusanMatkul = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveNextItemMatkul = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItemMatkul = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItemMatkul = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveLastItemMatkul = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ComboBoxEntries = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DataGridMatkul = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.DataGridMatkul, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Salmon
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1436, 63)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(690, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(304, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "::DATA MASTER MATAKULIAH::"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkSalmon
        Me.Panel2.Controls.Add(Me.LBJumlahBarisMatkul)
        Me.Panel2.Controls.Add(Me.LBBagiHalamanMatkul)
        Me.Panel2.Controls.Add(Me.LbTotalBarisMatkul)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 622)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1436, 69)
        Me.Panel2.TabIndex = 1
        '
        'LBJumlahBarisMatkul
        '
        Me.LBJumlahBarisMatkul.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBJumlahBarisMatkul.AutoSize = True
        Me.LBJumlahBarisMatkul.BackColor = System.Drawing.Color.Silver
        Me.LBJumlahBarisMatkul.Location = New System.Drawing.Point(1111, 41)
        Me.LBJumlahBarisMatkul.Name = "LBJumlahBarisMatkul"
        Me.LBJumlahBarisMatkul.Size = New System.Drawing.Size(83, 13)
        Me.LBJumlahBarisMatkul.TabIndex = 21
        Me.LBJumlahBarisMatkul.Text = "Jumlah Baris Ini:"
        '
        'LBBagiHalamanMatkul
        '
        Me.LBBagiHalamanMatkul.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LBBagiHalamanMatkul.BackColor = System.Drawing.Color.PeachPuff
        Me.LBBagiHalamanMatkul.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBBagiHalamanMatkul.ForeColor = System.Drawing.Color.Red
        Me.LBBagiHalamanMatkul.Location = New System.Drawing.Point(111, 40)
        Me.LBBagiHalamanMatkul.Name = "LBBagiHalamanMatkul"
        Me.LBBagiHalamanMatkul.Size = New System.Drawing.Size(141, 20)
        Me.LBBagiHalamanMatkul.TabIndex = 20
        Me.LBBagiHalamanMatkul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LbTotalBarisMatkul
        '
        Me.LbTotalBarisMatkul.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LbTotalBarisMatkul.AutoSize = True
        Me.LbTotalBarisMatkul.BackColor = System.Drawing.Color.Silver
        Me.LbTotalBarisMatkul.Location = New System.Drawing.Point(33, 25)
        Me.LbTotalBarisMatkul.Name = "LbTotalBarisMatkul"
        Me.LbTotalBarisMatkul.Size = New System.Drawing.Size(63, 13)
        Me.LbTotalBarisMatkul.TabIndex = 18
        Me.LbTotalBarisMatkul.Text = "Total Baris :"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Silver
        Me.Label10.Location = New System.Drawing.Point(33, 44)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Jumlah Hal:"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkSalmon
        Me.Panel3.Controls.Add(Me.LBPRODIMatkul)
        Me.Panel3.Controls.Add(Me.CBSemesterMatkul)
        Me.Panel3.Controls.Add(Me.CMBJenisGanjilGenap)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.BTNCariMatkul)
        Me.Panel3.Controls.Add(Me.BtnKeluarMatkul)
        Me.Panel3.Controls.Add(Me.BtnTambahMatkul)
        Me.Panel3.Controls.Add(Me.TxtCariNamaMatkul)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.CBNamaJurusanMatkul)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 63)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1436, 90)
        Me.Panel3.TabIndex = 10
        '
        'LBPRODIMatkul
        '
        Me.LBPRODIMatkul.BackColor = System.Drawing.Color.Bisque
        Me.LBPRODIMatkul.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBPRODIMatkul.Location = New System.Drawing.Point(14, 39)
        Me.LBPRODIMatkul.Name = "LBPRODIMatkul"
        Me.LBPRODIMatkul.Size = New System.Drawing.Size(89, 23)
        Me.LBPRODIMatkul.TabIndex = 25
        Me.LBPRODIMatkul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CBSemesterMatkul
        '
        Me.CBSemesterMatkul.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBSemesterMatkul.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CBSemesterMatkul.FormattingEnabled = True
        Me.CBSemesterMatkul.Location = New System.Drawing.Point(612, 39)
        Me.CBSemesterMatkul.Name = "CBSemesterMatkul"
        Me.CBSemesterMatkul.Size = New System.Drawing.Size(87, 21)
        Me.CBSemesterMatkul.TabIndex = 10
        '
        'CMBJenisGanjilGenap
        '
        Me.CMBJenisGanjilGenap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBJenisGanjilGenap.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CMBJenisGanjilGenap.FormattingEnabled = True
        Me.CMBJenisGanjilGenap.Location = New System.Drawing.Point(519, 39)
        Me.CMBJenisGanjilGenap.Name = "CMBJenisGanjilGenap"
        Me.CMBJenisGanjilGenap.Size = New System.Drawing.Size(87, 21)
        Me.CMBJenisGanjilGenap.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(541, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 18)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Semester"
        '
        'BTNCariMatkul
        '
        Me.BTNCariMatkul.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTNCariMatkul.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCariMatkul.Location = New System.Drawing.Point(1049, 26)
        Me.BTNCariMatkul.Name = "BTNCariMatkul"
        Me.BTNCariMatkul.Size = New System.Drawing.Size(108, 34)
        Me.BTNCariMatkul.TabIndex = 6
        Me.BTNCariMatkul.Text = "CARI DATA"
        Me.BTNCariMatkul.UseVisualStyleBackColor = True
        '
        'BtnKeluarMatkul
        '
        Me.BtnKeluarMatkul.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BtnKeluarMatkul.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKeluarMatkul.Location = New System.Drawing.Point(1301, 25)
        Me.BtnKeluarMatkul.Name = "BtnKeluarMatkul"
        Me.BtnKeluarMatkul.Size = New System.Drawing.Size(123, 37)
        Me.BtnKeluarMatkul.TabIndex = 5
        Me.BtnKeluarMatkul.Text = "&KELUAR"
        Me.BtnKeluarMatkul.UseVisualStyleBackColor = True
        '
        'BtnTambahMatkul
        '
        Me.BtnTambahMatkul.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnTambahMatkul.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTambahMatkul.Location = New System.Drawing.Point(1172, 25)
        Me.BtnTambahMatkul.Name = "BtnTambahMatkul"
        Me.BtnTambahMatkul.Size = New System.Drawing.Size(123, 37)
        Me.BtnTambahMatkul.TabIndex = 4
        Me.BtnTambahMatkul.Text = "TAMBAH DATA"
        Me.BtnTambahMatkul.UseVisualStyleBackColor = True
        '
        'TxtCariNamaMatkul
        '
        Me.TxtCariNamaMatkul.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCariNamaMatkul.Location = New System.Drawing.Point(766, 40)
        Me.TxtCariNamaMatkul.Name = "TxtCariNamaMatkul"
        Me.TxtCariNamaMatkul.Size = New System.Drawing.Size(262, 20)
        Me.TxtCariNamaMatkul.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(763, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cari"
        '
        'CBNamaJurusanMatkul
        '
        Me.CBNamaJurusanMatkul.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBNamaJurusanMatkul.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CBNamaJurusanMatkul.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBNamaJurusanMatkul.FormattingEnabled = True
        Me.CBNamaJurusanMatkul.Location = New System.Drawing.Point(151, 38)
        Me.CBNamaJurusanMatkul.Name = "CBNamaJurusanMatkul"
        Me.CBNamaJurusanMatkul.Size = New System.Drawing.Size(343, 23)
        Me.CBNamaJurusanMatkul.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nama Prodi"
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.AutoSize = False
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorMoveNextItemMatkul
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItemMatkul, Me.BindingNavigatorMovePreviousItemMatkul, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItemMatkul, Me.BindingNavigatorMoveLastItemMatkul, Me.BindingNavigatorSeparator2})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 153)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItemMatkul
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItemMatkul
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItemMatkul
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItemMatkul
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(1436, 36)
        Me.BindingNavigator1.TabIndex = 17
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveNextItemMatkul
        '
        Me.BindingNavigatorMoveNextItemMatkul.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItemMatkul.Image = CType(resources.GetObject("BindingNavigatorMoveNextItemMatkul.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItemMatkul.Name = "BindingNavigatorMoveNextItemMatkul"
        Me.BindingNavigatorMoveNextItemMatkul.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItemMatkul.Size = New System.Drawing.Size(23, 33)
        Me.BindingNavigatorMoveNextItemMatkul.Text = "of {0}"
        '
        'BindingNavigatorMoveFirstItemMatkul
        '
        Me.BindingNavigatorMoveFirstItemMatkul.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItemMatkul.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItemMatkul.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItemMatkul.Name = "BindingNavigatorMoveFirstItemMatkul"
        Me.BindingNavigatorMoveFirstItemMatkul.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItemMatkul.Size = New System.Drawing.Size(23, 33)
        Me.BindingNavigatorMoveFirstItemMatkul.Text = "of {0}"
        '
        'BindingNavigatorMovePreviousItemMatkul
        '
        Me.BindingNavigatorMovePreviousItemMatkul.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItemMatkul.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItemMatkul.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItemMatkul.Name = "BindingNavigatorMovePreviousItemMatkul"
        Me.BindingNavigatorMovePreviousItemMatkul.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItemMatkul.Size = New System.Drawing.Size(23, 33)
        Me.BindingNavigatorMovePreviousItemMatkul.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 36)
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
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 33)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 36)
        '
        'BindingNavigatorMoveLastItemMatkul
        '
        Me.BindingNavigatorMoveLastItemMatkul.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItemMatkul.Image = CType(resources.GetObject("BindingNavigatorMoveLastItemMatkul.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItemMatkul.Name = "BindingNavigatorMoveLastItemMatkul"
        Me.BindingNavigatorMoveLastItemMatkul.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItemMatkul.Size = New System.Drawing.Size(23, 33)
        Me.BindingNavigatorMoveLastItemMatkul.Text = "of {0}"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 36)
        '
        'ComboBoxEntries
        '
        Me.ComboBoxEntries.FormattingEnabled = True
        Me.ComboBoxEntries.Location = New System.Drawing.Point(309, 159)
        Me.ComboBoxEntries.Name = "ComboBoxEntries"
        Me.ComboBoxEntries.Size = New System.Drawing.Size(62, 21)
        Me.ComboBoxEntries.TabIndex = 19
        Me.ComboBoxEntries.Text = "10"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(236, 162)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Tampil Data:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridMatkul
        '
        Me.DataGridMatkul.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridMatkul.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridMatkul.Location = New System.Drawing.Point(0, 189)
        Me.DataGridMatkul.Name = "DataGridMatkul"
        Me.DataGridMatkul.Size = New System.Drawing.Size(1436, 433)
        Me.DataGridMatkul.TabIndex = 20
        '
        'FrmDataMataKuliah
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Bisque
        Me.ClientSize = New System.Drawing.Size(1436, 691)
        Me.Controls.Add(Me.DataGridMatkul)
        Me.Controls.Add(Me.ComboBoxEntries)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "FrmDataMataKuliah"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmDataMataKuliah"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.DataGridMatkul, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BTNCariMatkul As Button
    Friend WithEvents BtnKeluarMatkul As Button
    Friend WithEvents BtnTambahMatkul As Button
    Friend WithEvents TxtCariNamaMatkul As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CBNamaJurusanMatkul As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CBSemesterMatkul As ComboBox
    Friend WithEvents CMBJenisGanjilGenap As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents LBJumlahBarisMatkul As Label
    Friend WithEvents LBBagiHalamanMatkul As Label
    Friend WithEvents LbTotalBarisMatkul As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents BindingNavigatorMoveNextItemMatkul As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItemMatkul As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItemMatkul As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveLastItemMatkul As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents ComboBoxEntries As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents LBPRODIMatkul As Label
    Friend WithEvents DataGridMatkul As DataGridView
End Class
