<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLapDataMatakuliah
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
        Me.CMBSemester = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BTNCETAKLapDataMatkul = New System.Windows.Forms.Button()
        Me.BTNKeluarLapDataMatkul = New System.Windows.Forms.Button()
        Me.CBNamaJurusanLapDataMatkul = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSalmon
        Me.Panel1.Controls.Add(Me.CMBSemester)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.BTNCETAKLapDataMatkul)
        Me.Panel1.Controls.Add(Me.BTNKeluarLapDataMatkul)
        Me.Panel1.Controls.Add(Me.CBNamaJurusanLapDataMatkul)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 69)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1296, 64)
        Me.Panel1.TabIndex = 6
        '
        'CMBSemester
        '
        Me.CMBSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBSemester.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CMBSemester.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBSemester.FormattingEnabled = True
        Me.CMBSemester.Location = New System.Drawing.Point(681, 21)
        Me.CMBSemester.Name = "CMBSemester"
        Me.CMBSemester.Size = New System.Drawing.Size(106, 23)
        Me.CMBSemester.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(586, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 18)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Semester"
        '
        'BTNCETAKLapDataMatkul
        '
        Me.BTNCETAKLapDataMatkul.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNCETAKLapDataMatkul.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCETAKLapDataMatkul.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTNCETAKLapDataMatkul.Location = New System.Drawing.Point(935, 12)
        Me.BTNCETAKLapDataMatkul.Name = "BTNCETAKLapDataMatkul"
        Me.BTNCETAKLapDataMatkul.Size = New System.Drawing.Size(175, 37)
        Me.BTNCETAKLapDataMatkul.TabIndex = 7
        Me.BTNCETAKLapDataMatkul.Text = "CETAK LAPORAN"
        Me.BTNCETAKLapDataMatkul.UseVisualStyleBackColor = True
        '
        'BTNKeluarLapDataMatkul
        '
        Me.BTNKeluarLapDataMatkul.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BTNKeluarLapDataMatkul.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNKeluarLapDataMatkul.Location = New System.Drawing.Point(1126, 13)
        Me.BTNKeluarLapDataMatkul.Name = "BTNKeluarLapDataMatkul"
        Me.BTNKeluarLapDataMatkul.Size = New System.Drawing.Size(123, 37)
        Me.BTNKeluarLapDataMatkul.TabIndex = 6
        Me.BTNKeluarLapDataMatkul.Text = "&KELUAR"
        Me.BTNKeluarLapDataMatkul.UseVisualStyleBackColor = True
        '
        'CBNamaJurusanLapDataMatkul
        '
        Me.CBNamaJurusanLapDataMatkul.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBNamaJurusanLapDataMatkul.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CBNamaJurusanLapDataMatkul.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBNamaJurusanLapDataMatkul.FormattingEnabled = True
        Me.CBNamaJurusanLapDataMatkul.Location = New System.Drawing.Point(117, 21)
        Me.CBNamaJurusanLapDataMatkul.Name = "CBNamaJurusanLapDataMatkul"
        Me.CBNamaJurusanLapDataMatkul.Size = New System.Drawing.Size(432, 23)
        Me.CBNamaJurusanLapDataMatkul.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Prodi"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Salmon
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1296, 69)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "CETAK DATA LAPORAN MATAKULIAH PERSEMESTER"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 133)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ShowCloseButton = False
        Me.CrystalReportViewer1.ShowCopyButton = False
        Me.CrystalReportViewer1.ShowGotoPageButton = False
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.ShowLogo = False
        Me.CrystalReportViewer1.ShowParameterPanelButton = False
        Me.CrystalReportViewer1.ShowTextSearchButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1296, 502)
        Me.CrystalReportViewer1.TabIndex = 7
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'FrmLapDataMatakuliah
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1296, 635)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmLapDataMatakuliah"
        Me.Text = "FrmLapDataMatakuliah"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BTNCETAKLapDataMatkul As Button
    Friend WithEvents BTNKeluarLapDataMatkul As Button
    Friend WithEvents CBNamaJurusanLapDataMatkul As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CMBSemester As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
