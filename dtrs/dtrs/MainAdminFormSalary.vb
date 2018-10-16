Imports iTextSharp.text.pdf
Imports iTextSharp.text
Imports System.IO

Public Class MainAdminFormSalary
    Private Access As New DBControl

    Private Sub EmployeesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeesToolStripMenuItem.Click
        Me.Hide()
        MainAdminFormEmployees.Show()
    End Sub
    Private Sub PositionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PositionsToolStripMenuItem.Click
        Me.Hide()
        MainAdminFormPositions.Show()
    End Sub
    Private Sub AdminsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdminsToolStripMenuItem.Click
        Me.Hide()
        MainAdminFormAdmins.Show()
    End Sub

    Private Sub SalaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalaryToolStripMenuItem.Click
        Me.Hide()
        Me.Show()
    End Sub

    Private Sub MainAdminFormSalary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database3SADDataSet.tbl_salary_Query' table. You can move, or remove it, as needed.
        'Me.Tbl_salary_QueryTableAdapter.Fill(Me.Database3SADDataSet.tbl_salary_Query)

        Access.ExecQuery("SELECT * From tbl_payroll_period ORDER BY ID Desc")

        If Access.RecordCount > 0 Then
            For Each R In Access.DBDT.Rows
                ComboBox1.Items.Add(R("Start_Period") & " - " & R("End_Period"))
            Next
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' you must import itextsharp namespace into our form


        ' download links is available in the descriptions


        Dim Paragraph As New Paragraph ' declaration for new paragraph


        Dim PdfFile As New Document(PageSize.A4, 40, 40, 40, 20) ' set pdf page size

        Dim PdfTitle As String = ComboBox1.Text
        PdfTitle = PdfTitle.Replace("/", "_")


        PdfFile.AddTitle(PdfTitle) ' set our pdf title


        If Not Directory.Exists("export") Then
            Directory.CreateDirectory("export")
        End If

        Dim Write As PdfWriter = PdfWriter.GetInstance(PdfFile, New FileStream("export\" & PdfTitle & ".pdf", FileMode.Create))


        PdfFile.Open()


        ' declaration font type


        Dim pTitle As New Font(iTextSharp.text.Font.FontFamily.HELVETICA, 13, iTextSharp.text.Font.BOLD, BaseColor.BLACK)


        Dim pTable As New Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK)


        ' insert title into pdf file


        Paragraph = New Paragraph(New Chunk(PdfTitle, pTitle))


        Paragraph.Alignment = Element.ALIGN_CENTER


        Paragraph.SpacingAfter = 5.0F


        ' set and add page with current settings



        PdfFile.Add(Paragraph)


        ' create data into table


        Dim PdfTable As New PdfPTable(Tbl_salary_QueryDataGridView.Columns.Count)


        ' setting width of table


        PdfTable.TotalWidth = 500.0F


        PdfTable.LockedWidth = True


        Dim widths(0 To Tbl_salary_QueryDataGridView.Columns.Count - 1) As Single


        For i As Integer = 0 To Tbl_salary_QueryDataGridView.Columns.Count - 1


            widths(i) = 1.0F


        Next


        PdfTable.SetWidths(widths)


        PdfTable.HorizontalAlignment = 0


        PdfTable.SpacingBefore = 5.0F


        ' declaration pdf cells


        Dim pdfcell As PdfPCell = New PdfPCell


        ' create pdf header


        For i As Integer = 0 To Tbl_salary_QueryDataGridView.Columns.Count - 1


            pdfcell = New PdfPCell(New Phrase(New Chunk(Tbl_salary_QueryDataGridView.Columns(i).HeaderText, pTable)))


            ' alignment header table


            pdfcell.HorizontalAlignment = PdfPCell.ALIGN_LEFT


            ' add cells into pdf table


            PdfTable.AddCell(pdfcell)


        Next


        ' add data into pdf table


        For i As Integer = 0 To Tbl_salary_QueryDataGridView.Rows.Count - 2


            For j As Integer = 0 To Tbl_salary_QueryDataGridView.Columns.Count - 1


                pdfcell = New PdfPCell(New Phrase(Tbl_salary_QueryDataGridView(j, i).Value.ToString(), pTable))


                PdfTable.HorizontalAlignment = PdfPCell.ALIGN_LEFT


                PdfTable.AddCell(pdfcell)


            Next


        Next


        ' add pdf table into pdf document


        PdfFile.Add(PdfTable)


        PdfFile.Close() ' close all sessions


        ' show message if hasben exported


        MessageBox.Show("PDF format success exported !", "Informations", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Tbl_salary_QueryDataGridView.DataSource = ""

        Access.AddParam("Payroll_Period", ComboBox1.Text)

        Access.ExecQuery("SELECT * From tbl_salary_query WHERE Payroll_Period = @Payroll_Period")

        Tbl_salary_QueryDataGridView.DataSource = Access.DBDT

    End Sub

    Private Sub AddColumns()
        Tbl_salary_QueryDataGridView.Rows.Clear()

        Tbl_salary_QueryDataGridView.Columns.Add("Employee_ID", "Employee ID")

        Tbl_salary_QueryDataGridView.Columns.Add("Full_Name", "Full Name")

        Tbl_salary_QueryDataGridView.Columns.Add("Total_Hours", "Total Hours")

        Tbl_salary_QueryDataGridView.Columns.Add("Rate", "Rate")

        Tbl_salary_QueryDataGridView.Columns.Add("Position", "Position")

        Tbl_salary_QueryDataGridView.Columns.Add("Total_Salary", "Total Salary")

    End Sub

    Private Sub PayrollPeriodToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PayrollPeriodToolStripMenuItem.Click
        Me.Hide()
        MainAdminFormPayroll.Show()
    End Sub
End Class