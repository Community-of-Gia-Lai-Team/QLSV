﻿using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using Aspose.Words;
using Aspose.Words.Tables;
using WindowsFormsApp1.Report.AsposeWordExtension;
using System.Drawing.Printing;

namespace WindowsFormsApp1
{
    public partial class PrintResultScore : Form
    {
        public PrintResultScore()
        {
            InitializeComponent();
        }
        Score score = new Score();
        private void PrintResultScore_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = score.getStudentScore();
            dataGridView1.Columns[0].HeaderText = "Student ID";
            dataGridView1.Columns[1].HeaderText = "First name";
            dataGridView1.Columns[2].HeaderText = "Last name";
            dataGridView1.Columns[3].HeaderText = "Course ID";
            dataGridView1.Columns[4].HeaderText = "Label";
            dataGridView1.Columns[5].HeaderText = "Score";
            dataGridView1.AllowUserToAddRows = false;
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            if (textBox_search.Text == "")
            {
                MessageBox.Show("Empty Fields", "Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dataGridView1.DataSource = score.getStudentScores(Convert.ToInt32(textBox_search.Text));
            }
        }

        public void ExportExcel(DataTable dt, string sheetName, string title, string fileName)
        {
                //Tạo các đối tượng Excel
                Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbooks oBooks;
                Microsoft.Office.Interop.Excel.Sheets oSheets;
                Microsoft.Office.Interop.Excel.Workbook oBook;
                Microsoft.Office.Interop.Excel.Worksheet oSheet;
                try
                {
                    //Tạo mới một Excel WorkBook 
                    oExcel.Visible = true;
                    oExcel.DisplayAlerts = false;
                    oExcel.Application.SheetsInNewWorkbook = 1;
                    oBooks = oExcel.Workbooks;
                    oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));
                    oSheets = oBook.Worksheets;
                    oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);
                    oSheet.Name = sheetName;

                    // Tạo phần đầu nếu muốn
                    Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "F1");
                    head.MergeCells = true;
                    head.Value2 = title;
                    head.Font.Bold = true;
                    head.Font.Name = "Times New Roman";
                    head.Font.Size = "20";
                    head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                    // Tạo tiêu đề cột 
                    Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");
                    cl1.Value2 = "Student ID";
                    cl1.ColumnWidth = 10.0;

                    Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");
                    cl2.Value2 = "First Name";
                    cl2.ColumnWidth = 15.0;

                    Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");
                    cl3.Value2 = "Last name";
                    cl3.ColumnWidth = 15.0;

                    Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");
                    cl4.Value2 = "Course ID";
                    cl4.ColumnWidth = 10.0;

                    Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");
                    cl5.Value2 = "Label";
                    cl5.ColumnWidth = 30.0;

                    Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");
                    cl6.Value2 = "Score";
                    cl6.ColumnWidth = 8.0;

                    Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "F3");
                    rowHead.Font.Bold = true;

                    // Kẻ viền
                    rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

                    // Thiết lập màu nền
                    rowHead.Interior.ColorIndex = 15;
                    rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                    // Tạo mẳng đối tượng để lưu dữ toàn bồ dữ liệu trong DataTable,
                    // vì dữ liệu được được gán vào các Cell trong Excel phải thông qua object thuần.
                    object[,] arr = new object[dt.Rows.Count, dt.Columns.Count];

                    //Chuyển dữ liệu từ DataTable vào mảng đối tượng
                    for (int r = 0; r < dt.Rows.Count; r++)
                    {
                        DataRow dr = dt.Rows[r];
                        for (int c = 0; c < dt.Columns.Count; c++)
                        {
                            arr[r, c] = dr[c];
                        }
                    }

                    //Thiết lập vùng điền dữ liệu
                    int rowStart = 4;
                    int columnStart = 1;
                    int rowEnd = rowStart + dt.Rows.Count - 1;
                    int columnEnd = dt.Columns.Count;

                    // Ô bắt đầu điền dữ liệu
                    Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];
                    // Ô kết thúc điền dữ liệu
                    Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];
                    // Lấy về vùng điền dữ liệu
                    Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);
                    //Điền dữ liệu vào vùng đã thiết lập
                    range.Value2 = arr;
                    // Kẻ viền
                    range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

                    // Căn giữa cột STT
                    Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnStart];
                    Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range(c1, c3);
                    oSheet.get_Range(c3, c4).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                    oBook.SaveAs(fileName);
                    //đóng workbook
                    oBook.Close();
                    oExcel.Quit();
                    MessageBox.Show("Save the Excel file successfully", "Save file", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    oBook = null;
                    oSheet = null;
                }
        }

        public void Exporttext()
        {
            if (dataGridView1.Rows.Count > 0)
            {
                String path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Manage Score.text";
                using (TextWriter writer = new StreamWriter(path))
                {

                    if (!File.Exists(path))
                    {
                        File.Create(path);
                    }
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            if (j == dataGridView1.Columns.Count - 1)
                            {
                                writer.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString());
                            }
                            else
                            {
                                writer.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                            }
                        }
                        writer.WriteLine("");
                        writer.WriteLine("-------------------------------------------------------------------------------------------------------");
                    }
                    writer.Close();
                    MessageBox.Show("Save the Text file successfully", "Save file", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("No records to exported", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //public void Export_Data_To_Word(DataGridView DGV, string Filename)
        //{
        //    Word.Application oWord = new Word.Application();
        //    Word.Document oDoc = oWord.Documents.Add();
        //    oDoc.Application.Visible = true;
        //    oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;
        //    if (DGV.Rows.Count > 0)
        //    {
        //        int RowCount = DGV.Rows.Count;
        //        int ColumnCount = DGV.Columns.Count;
        //        Object[,] DataArray = new object[RowCount, ColumnCount];

        //        //add rows
        //        int r = 0;
        //        for (int c = 0; c <= ColumnCount - 1; c++)
        //        {
        //            for (r = 0; r <= RowCount - 1; r++)
        //            {
        //                DataArray[r, c] = DGV.Rows[r].Cells[c].Value;
        //            }
        //        }

        //        //page orintation
        //        oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;
        //        dynamic oRange = oDoc.Content.Application.Selection.Range;
        //        string oTemp = "";
        //        for (r = 0; r <= RowCount - 1; r++)
        //        {
        //            for (int c = 0; c <= ColumnCount - 1; c++)
        //            {
        //                oTemp = oTemp + DataArray[r, c] + "\t";
        //            }
        //        }
        //        //table format
        //        oRange.Text = oTemp;
        //        object Separator = Word.WdTableFieldSeparator.wdSeparateByTabs;
        //        object ApplyBorders = true;
        //        object AutoFit = true;
        //        object AutoFitBehavior = Word.WdAutoFitBehavior.wdAutoFitContent;
        //        oRange.ConvertToTable(ref Separator, ref RowCount, ref ColumnCount,
        //                              Type.Missing, Type.Missing, ref ApplyBorders,
        //                              Type.Missing, Type.Missing, Type.Missing,
        //                              Type.Missing, Type.Missing, Type.Missing,
        //                              Type.Missing, ref AutoFit, ref AutoFitBehavior, Type.Missing);
        //        oRange.Select();
        //        oDoc.Application.Selection.Tables[1].Select();
        //        oDoc.Application.Selection.Tables[1].Rows.AllowBreakAcrossPages = 0;
        //        oDoc.Application.Selection.Tables[1].Rows.Alignment = 0;
        //        oDoc.Application.Selection.Tables[1].Rows[1].Select();
        //        oDoc.Application.Selection.InsertRowsAbove(1);
        //        oDoc.Application.Selection.Tables[1].Rows[1].Select();

        //        //header row style
        //        oDoc.Application.Selection.Tables[1].Rows[1].Range.Bold = 1;
        //        oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Name = "Times New Roman";
        //        oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Size = 14;

        //        //add header row manually
        //        for (int c = 0; c <= ColumnCount - 1; c++)
        //        {
        //            oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = DGV.Columns[c].HeaderText;
        //        }

        //        //table style 
        //        oDoc.Application.Selection.Tables[1].set_Style("Grid Table 4 - Accent 4");
        //        oDoc.Application.Selection.Tables[1].Rows[1].Select();
        //        oDoc.Application.Selection.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;

        //        //header text
        //        foreach (Word.Section section in oDoc.Application.ActiveDocument.Sections)
        //        {
        //            Word.Range headerRange = section.Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
        //            headerRange.Fields.Add(headerRange, Word.WdFieldType.wdFieldPage);
        //            headerRange.Text = "Result";
        //            headerRange.Font.Size = 20;
        //            headerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
        //        }
        //        oDoc.SaveAs2(Filename);
        //        oDoc.Close();
        //        oWord.Quit();
        //        MessageBox.Show("Save the Word file successfully", "Save file", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    else
        //    {
        //        MessageBox.Show("No records to exported", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        public void Export_Data_To_Word(DataGridView DGV, string Filname)
        {
            if (DGV.Rows.Count > 0)
            {
                var homNay = DateTime.Now;
                Aspose.Words.Document baoCao = new Aspose.Words.Document(@"C:\Users\nguye\Downloads\Mau_Bao_Cao1.doc");


                    //Bước 2: Điền các thông tin cố định
                    baoCao.MailMerge.Execute(new[] { "Ngay_Thang_Nam_BC" }, new[] { string.Format("TP. Hồ Chí Minh, ngày {0} tháng {1} năm {2}", homNay.Day, homNay.Month, homNay.Year) });
                baoCao.MailMerge.Execute(new[] { "ID" }, new[] { DGV.CurrentRow.Cells[0].Value.ToString() });
                baoCao.MailMerge.Execute(new[] { "Ho_Ten" }, new[] { DGV.CurrentRow.Cells[1].Value.ToString() + " " + DGV.CurrentRow.Cells[2].Value.ToString() });

                Table bangdiem = baoCao.GetChild(NodeType.Table, 1, true) as Table;
                int hangHienTai = 1;
                bangdiem.InsertRows(hangHienTai, hangHienTai, DGV.Rows.Count - 1);
                for (int i = 0; i < DGV.Rows.Count; i++)
                {
                    for (int j = 0; j < DGV.Columns.Count; j++)
                    {
                        bangdiem.PutValue(hangHienTai, j, DGV.Rows[i].Cells[j].Value.ToString());
                    }
                    hangHienTai++;
                }

                baoCao.Save(Filname);
                MessageBox.Show("Save the Word file successfully", "Save file", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No records to exported", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportPDF()
        {
            string arialuniTff = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "vuTimes.TTF");
            BaseFont arial = BaseFont.CreateFont(arialuniTff, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font normal = new iTextSharp.text.Font(arial, 12, iTextSharp.text.Font.NORMAL);
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Manage_Score.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show(ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dataGridView1.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in dataGridView1.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, normal));
                                pdfTable.AddCell(cell);
                            }
                            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                            {
                                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                                {
                                    PdfPCell cell = new PdfPCell(new Phrase(dataGridView1.Rows[i].Cells[j].Value.ToString(), normal));
                                    pdfTable.AddCell(cell);
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                iTextSharp.text.Document pdfDoc = new iTextSharp.text.Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Save the PDF file successfully", "Save file", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No records to exported", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)dataGridView1.DataSource;
            try
            {
                if (comboBox_file.SelectedItem.ToString() == "Excel")
                {
                    if (dataGridView1.Rows.Count > 0)
                    {
                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            ExportExcel(dt, "Manage", "Manage Score", saveFileDialog1.FileName);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No records to exported", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (comboBox_file.SelectedItem.ToString() == "Text")
                {
                    Exporttext();
                }
                else if (comboBox_file.SelectedItem.ToString() == "Word")
                {

                        SaveFileDialog sfd = new SaveFileDialog();
                        sfd.Filter = "Word Documents (.docx)|.docx";
                        sfd.FileName = "Manage_Score.docx";
                        if (sfd.ShowDialog() == DialogResult.OK)
                        {
                            Export_Data_To_Word(dataGridView1, sfd.FileName);
                        }
                }
                else if (comboBox_file.SelectedItem.ToString() == "PDF")
                {
                    ExportPDF();
                }
            }
            catch
            {
                MessageBox.Show("Please select the file type to save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider_id.SetError(textBox_search, "Do not use letter!");
            }
            else
            {
                errorProvider_id.SetError(textBox_search, null);
            }
        }

        private void button_print_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printdocument = new PrintDocument();
            printdocument.DocumentName = "Print Document";
            printDialog.Document = printdocument;
            printDialog.AllowSelection = true;
            printDialog.AllowSomePages = true;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printdocument.Print();
            }
        }
    }
}
