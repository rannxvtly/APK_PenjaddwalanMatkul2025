<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLapDataDosen
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
        Me.BTNCETAKLapDataDosen = New System.Windows.Forms.Button()
        Me.BTNKeluarLapData = New System.Windows.Forms.Button()
        Me.CBNamaJurusanLapData = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSalmon
        Me.Panel1.Controls.Add(Me.BTNCETAKLapDataDosen)
        Me.Panel1.Controls.Add(Me.BTNKeluarLapData)
        Me.Panel1.Controls.Add(Me.CBNamaJurusanLapData)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 69)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1204, 64)
        Me.Panel1.TabIndex = 3
        '
        'BTNCETAKLapDataDosen
        '
        Me.BTNCETAKLapDataDosen.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNCETAKLapDataDosen.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCETAKLapDataDosen.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTNCETAKLapDataDosen.Location = New System.Drawing.Point(843, 12)
        Me.BTNCETAKLapDataDosen.Name = "BTNCETAKLapDataDosen"
        Me.BTNCETAKLapDataDosen.Size = New System.Drawing.Size(175, 37)
        Me.BTNCETAKLapDataDosen.TabIndex = 7
        Me.BTNCETAKLapDataDosen.Text = "CETAK LAPORAN"
        Me.BTNCETAKLapDataDosen.UseVisualStyleBackColor = True
        '
        'BTNKeluarLapData
        '
        Me.BTNKeluarLapData.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BTNKeluarLapData.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNKeluarLapData.Location = New System.Drawing.Point(1034, 13)
        Me.BTNKeluarLapData.Name = "BTNKeluarLapData"
        Me.BTNKeluarLapData.Size = New System.Drawing.Size(123, 37)
        Me.BTNKeluarLapData.TabIndex = 6
        Me.BTNKeluarLapData.Text = "&KELUAR"
        Me.BTNKeluarLapData.UseVisualStyleBackColor = True
        '
        'CBNamaJurusanLapData
        '
        Me.CBNamaJurusanLapData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBNamaJurusanLapData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CBNamaJurusanLapData.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBNamaJurusanLapData.FormattingEnabled = True
        Me.CBNamaJurusanLapData.Location = New System.Drawing.Point(117, 21)
        Me.CBNamaJurusanLapData.Name = "CBNamaJurusanLapData"
        Me.CBNamaJurusanLapData.Size = New System.Drawing.Size(432, 23)
        Me.CBNamaJurusanLapData.TabIndex = 2
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
        Me.Label1.Size = New System.Drawing.Size(1204, 69)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "LAPORAN DATA DOSEN PERPRODI"
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
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1204, 518)
        Me.CrystalReportViewer1.TabIndex = 2
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'FrmLapDataDosen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1204, 651)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmLapDataDosen"
        Me.Text = "FrmLapDataDosen"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BTNCETAKLapDataDosen As Button
    Friend WithEvents BTNKeluarLapData As Button
    Friend WithEvents CBNamaJurusanLapData As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
