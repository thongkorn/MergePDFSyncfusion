#Region "ABOUT"
' / -----------------------------------------------------------------------------------------------
' / Developer : Mr.Surapon Yodsanga (Thongkorn Tubtimkrob)
' / eMail : thongkorn@hotmail.com
' / URL: http://www.g2gnet.com (Khon Kaen - Thailand)
' / Facebook: https://www.facebook.com/g2gnet (For Thailand only)
' / Facebook: https://www.facebook.com/commonindy (Worldwide)
' / More Info: http://www.g2gnet.com/webboard
' /
' / Purpose: Merge PDF Files with Syncfusion Community License.
' / Microsoft Visual Basic .Net 2010 + Service Pack 1
' / Syncfusion Community Free License.
' /
' / This is open source code under @Copyleft by Thongkorn Tubtimkrob.
' / You can modify and/or distribute without to inform the developer.
' / -----------------------------------------------------------------------------------------------
#End Region

Imports Syncfusion.Pdf.Parsing
Imports Syncfusion.Pdf
Imports System.IO

Public Class frmMergePDF

    Dim GetPath As String = MyPath(Application.StartupPath) & "PDF\"
    '// พาธและชื่อไฟล์ที่เป็นเอ้าพุท
    Dim PdfMergePage As String = GetPath & "SampleMergePage.pdf"
    Dim PdfMergeAll As String = GetPath & "SampleMergeAll.pdf"

    ' / -----------------------------------------------------------------------------------------------
    ' / Merge PDF select pages.
    Private Sub btnMergePage_Click(sender As System.Object, e As System.EventArgs) Handles btnMergePage.Click
        '/ Loads a document.
        Dim FirstDocument As New PdfLoadedDocument(GetPath & "FirstPDF.pdf")
        Dim SecondDocument As New PdfLoadedDocument(GetPath & "SecondPDF.pdf")
        '/ Create a new document.
        Dim Document As New PdfDocument()
        Try
            '/ เลือกหน้าแรกของไฟล์ตัวอย่าง FirstPDF.PDF
            Document.ImportPage(FirstDocument, 0)
            '/ Save the document.
            Document.Save(PdfMergePage)

            '// หรือโหลดไฟล์ PDF ตัวแรก แล้ววนรอบตามจำนวนหน้าที่ต้องการ 
            '// เป็นการเลือกหมายเลขหน้า มาทำการจัดเรียง หรือสร้างในไฟล์ PDF ตัวใหม่
            'For i As Integer = 0 To FirstDocument.Pages.Count - 1
            '/ Imports loaded document page to the new document
            'Document.ImportPage(FirstDocument, i)
            '/ Save the document
            'Document.Save(PdfMergePage)
            'Next

            '// การนำเอกสารไฟล์ PDF ชุดที่ 2 เข้ามา Merge
            With Document
                '/ ดึงไฟล์ PDF ตัวที่ 2 เข้ามา ตัวอย่างคือเลือกแค่หน้าแรกมาต่อท้ายเข้าไป
                .ImportPage(SecondDocument, 0)  '<-- เพิ่มหน้าแรกสุด
                '.ImportPage(SecondDocument, 2) '<-- เพิ่มหน้าที่ 3 (Index = 2)
                '/ บันทึก Document
                .Save(PdfMergePage)
                '/ Closes the document.
                .Close(True)
            End With
            FirstDocument.Close(True)
            SecondDocument.Close(True)
            '/ Display new PDF.
            Me.PdfViewerControl1.Load(PdfMergePage, "")
            '//
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Document.Dispose()
        FirstDocument.Dispose()
        SecondDocument.Dispose()
    End Sub

    ' / -----------------------------------------------------------------------------------------------
    ' / Merge PDF all pages.
    Private Sub btnMergeAll_Click(sender As System.Object, e As System.EventArgs) Handles btnMergeAll.Click
        Try
            Dim FinalDoc As New PdfDocument()
            '/ Creates a string array of source files to be merged.
            Dim Source As String() = {GetPath & "FirstPDF.pdf", GetPath & "SecondPDF.pdf"}
            '/ Merges PDFDocument.
            PdfDocument.Merge(FinalDoc, Source)
            '/ Saves the final document.
            FinalDoc.Save(PdfMergeAll)
            '/ Closes the document.
            FinalDoc.Close(True)
            '/ Display new PDF.
            Me.PdfViewerControl1.Load(PdfMergeAll, "")
            '//
            FinalDoc.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ' / -----------------------------------------------------------------------------------------------
    Function MyPath(ByVal AppPath As String) As String
        '/ Return Value
        MyPath = AppPath.ToLower.Replace("\bin\debug", "\").Replace("\bin\release", "\").Replace("\bin\x86\debug", "\").Replace("\bin\x86\release", "\")
        '// If not found folder then put the \ (BackSlash ASCII Code = 92) at the end.
        If Microsoft.VisualBasic.Right(MyPath, 1) <> Chr(92) Then MyPath = MyPath & Chr(92)
    End Function

    Private Sub frmMergePDF_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
        GC.SuppressFinalize(Me)
        Application.Exit()
    End Sub

End Class
