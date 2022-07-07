<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMergePDF
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
        Dim MessageBoxSettings1 As Syncfusion.Windows.Forms.PdfViewer.MessageBoxSettings = New Syncfusion.Windows.Forms.PdfViewer.MessageBoxSettings()
        Dim PdfViewerPrinterSettings1 As Syncfusion.Windows.PdfViewer.PdfViewerPrinterSettings = New Syncfusion.Windows.PdfViewer.PdfViewerPrinterSettings()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMergePDF))
        Dim TextSearchSettings1 As Syncfusion.Windows.Forms.PdfViewer.TextSearchSettings = New Syncfusion.Windows.Forms.PdfViewer.TextSearchSettings()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PdfViewerControl1 = New Syncfusion.Windows.Forms.PdfViewer.PdfViewerControl()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnMergeAll = New Syncfusion.Windows.Forms.ButtonAdv()
        Me.btnMergePage = New Syncfusion.Windows.Forms.ButtonAdv()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.PdfViewerControl1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1030, 598)
        Me.Panel1.TabIndex = 0
        '
        'PdfViewerControl1
        '
        Me.PdfViewerControl1.CursorMode = Syncfusion.Windows.Forms.PdfViewer.PdfViewerCursorMode.SelectTool
        Me.PdfViewerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PdfViewerControl1.EnableContextMenu = True
        Me.PdfViewerControl1.EnableNotificationBar = True
        Me.PdfViewerControl1.HorizontalScrollOffset = 0
        Me.PdfViewerControl1.IsBookmarkEnabled = True
        Me.PdfViewerControl1.IsTextSearchEnabled = True
        Me.PdfViewerControl1.IsTextSelectionEnabled = True
        Me.PdfViewerControl1.Location = New System.Drawing.Point(0, 0)
        MessageBoxSettings1.EnableNotification = True
        Me.PdfViewerControl1.MessageBoxSettings = MessageBoxSettings1
        Me.PdfViewerControl1.MinimumZoomPercentage = 50
        Me.PdfViewerControl1.Name = "PdfViewerControl1"
        Me.PdfViewerControl1.PageBorderThickness = 1
        PdfViewerPrinterSettings1.Copies = 1
        PdfViewerPrinterSettings1.PageOrientation = Syncfusion.Windows.PdfViewer.PdfViewerPrintOrientation.[Auto]
        PdfViewerPrinterSettings1.PageSize = Syncfusion.Windows.PdfViewer.PdfViewerPrintSize.ActualSize
        PdfViewerPrinterSettings1.PrintLocation = CType(resources.GetObject("PdfViewerPrinterSettings1.PrintLocation"), System.Drawing.PointF)
        PdfViewerPrinterSettings1.ShowPrintStatusDialog = True
        Me.PdfViewerControl1.PrinterSettings = PdfViewerPrinterSettings1
        Me.PdfViewerControl1.ReferencePath = Nothing
        Me.PdfViewerControl1.ScrollDisplacementValue = 0
        Me.PdfViewerControl1.ShowHorizontalScrollBar = True
        Me.PdfViewerControl1.ShowToolBar = True
        Me.PdfViewerControl1.ShowVerticalScrollBar = True
        Me.PdfViewerControl1.Size = New System.Drawing.Size(1030, 598)
        Me.PdfViewerControl1.SpaceBetweenPages = 8
        Me.PdfViewerControl1.TabIndex = 0
        Me.PdfViewerControl1.Text = "PdfViewerControl1"
        TextSearchSettings1.CurrentInstanceColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(64, Byte), Integer))
        TextSearchSettings1.HighlightAllInstance = True
        TextSearchSettings1.OtherInstanceColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PdfViewerControl1.TextSearchSettings = TextSearchSettings1
        Me.PdfViewerControl1.ThemeName = "Default"
        Me.PdfViewerControl1.VerticalScrollOffset = 0
        Me.PdfViewerControl1.VisualStyle = Syncfusion.Windows.Forms.PdfViewer.VisualStyle.[Default]
        Me.PdfViewerControl1.ZoomMode = Syncfusion.Windows.Forms.PdfViewer.ZoomMode.[Default]
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnMergeAll)
        Me.Panel2.Controls.Add(Me.btnMergePage)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 597)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1032, 47)
        Me.Panel2.TabIndex = 0
        '
        'btnMergeAll
        '
        Me.btnMergeAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMergeAll.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnMergeAll.BeforeTouchSize = New System.Drawing.Size(124, 40)
        Me.btnMergeAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMergeAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMergeAll.ForeColor = System.Drawing.Color.White
        Me.btnMergeAll.Location = New System.Drawing.Point(905, 3)
        Me.btnMergeAll.Name = "btnMergeAll"
        Me.btnMergeAll.Size = New System.Drawing.Size(124, 40)
        Me.btnMergeAll.TabIndex = 1
        Me.btnMergeAll.Text = "Merge All"
        '
        'btnMergePage
        '
        Me.btnMergePage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMergePage.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnMergePage.BeforeTouchSize = New System.Drawing.Size(124, 40)
        Me.btnMergePage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMergePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMergePage.ForeColor = System.Drawing.Color.White
        Me.btnMergePage.Location = New System.Drawing.Point(775, 4)
        Me.btnMergePage.Name = "btnMergePage"
        Me.btnMergePage.Size = New System.Drawing.Size(124, 40)
        Me.btnMergePage.TabIndex = 0
        Me.btnMergePage.Text = "Merge Page"
        '
        'frmMergePDF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1032, 644)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmMergePDF"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Merge PDF Document with Syncfusion - coDe bY: Thongkorn Tubtimkrob"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PdfViewerControl1 As Syncfusion.Windows.Forms.PdfViewer.PdfViewerControl
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnMergePage As Syncfusion.Windows.Forms.ButtonAdv
    Friend WithEvents btnMergeAll As Syncfusion.Windows.Forms.ButtonAdv

End Class
