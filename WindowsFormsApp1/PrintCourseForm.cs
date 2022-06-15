using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace WindowsFormsApp1
{
    public partial class PrintCourseForm : Form
    {
        public PrintCourseForm()
        {
            InitializeComponent();
        }

        private void PrintCourseForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'viduDataSet3.course_table' table. You can move, or remove it, as needed.
            this.course_tableTableAdapter.Fill(this.viduDataSet3.course_table);
            FillGrid(new SqlCommand("SELECT * FROM course_table"));
        }
        Course course = new Course();
        public void FillGrid(SqlCommand cmd)
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = course.getCourse(cmd);
            dataGridView1.AllowUserToAddRows = false;
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

        public void ExportExcel(DataTable dt, string sheetName, string title, string fileName)
        {
            if (dt.Rows.Count > 0)
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
                    Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "D1");
                    head.MergeCells = true;
                    head.Value2 = title;
                    head.Font.Bold = true;
                    head.Font.Name = "Times New Roman";
                    head.Font.Size = "20";
                    head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                    // Tạo tiêu đề cột 
                    Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");
                    cl1.Value2 = "ID";
                    cl1.ColumnWidth = 6.0;

                    Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");
                    cl2.Value2 = "Course";
                    cl2.ColumnWidth = 30.0;

                    Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");
                    cl3.Value2 = "Period";
                    cl3.ColumnWidth = 6.0;

                    Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");
                    cl4.Value2 = "Description";
                    cl4.ColumnWidth = 30.0;

                    Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "D3");
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
            else
            {
                MessageBox.Show("No records to exported", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Exporttext()
        {
            if (dataGridView1.Rows.Count > 0)
            {
                String path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Manage Course.text";
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

        public void Export_Data_To_Word(DataGridView DGV, string Filename)
        {
            Word.Application oWord = new Word.Application();
            Word.Document oDoc = oWord.Documents.Add();
            oDoc.Application.Visible = true;
            oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;
            if (DGV.Rows.Count > 0)
            {
                int RowCount = DGV.Rows.Count;
                int ColumnCount = DGV.Columns.Count;
                Object[,] DataArray = new object[RowCount, ColumnCount];

                //add rows
                int r = 0;
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    for (r = 0; r <= RowCount - 1; r++)
                    {
                        DataArray[r, c] = DGV.Rows[r].Cells[c].Value;
                    }
                }

                //page orintation
                oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;
                dynamic oRange = oDoc.Content.Application.Selection.Range;
                string oTemp = "";
                for (r = 0; r <= RowCount - 1; r++)
                {
                    for (int c = 0; c <= ColumnCount - 1; c++)
                    {
                            oTemp = oTemp + DataArray[r, c] + "\t";
                    }
                }
                //table format
                oRange.Text = oTemp;
                object Separator = Word.WdTableFieldSeparator.wdSeparateByTabs;
                object ApplyBorders = true;
                object AutoFit = true;
                object AutoFitBehavior = Word.WdAutoFitBehavior.wdAutoFitContent;
                oRange.ConvertToTable(ref Separator, ref RowCount, ref ColumnCount,
                                      Type.Missing, Type.Missing, ref ApplyBorders,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, ref AutoFit, ref AutoFitBehavior, Type.Missing);
                oRange.Select();
                oDoc.Application.Selection.Tables[1].Select();
                oDoc.Application.Selection.Tables[1].Rows.AllowBreakAcrossPages = 0;
                oDoc.Application.Selection.Tables[1].Rows.Alignment = 0;
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.InsertRowsAbove(1);
                oDoc.Application.Selection.Tables[1].Rows[1].Select();

                //header row style
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Bold = 1;
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Name = "Times New Roman";
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Size = 14;

                //add header row manually
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = DGV.Columns[c].HeaderText;
                }

                //table style 
                oDoc.Application.Selection.Tables[1].set_Style("Grid Table 4 - Accent 4");
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;

                //header text
                foreach (Word.Section section in oDoc.Application.ActiveDocument.Sections)
                {
                    Word.Range headerRange = section.Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    headerRange.Fields.Add(headerRange, Word.WdFieldType.wdFieldPage);
                    headerRange.Text = "Manager Course";
                    headerRange.Font.Size = 20;
                    headerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                }
                oDoc.SaveAs2(Filename);
                oDoc.Close();
                oWord.Quit();
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
                sfd.FileName = "Manage_Course.pdf";
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
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText,normal));
                                pdfTable.AddCell(cell);
                            }
                            for(int i =0; i < dataGridView1.Rows.Count; i++)
                            {
                                for(int j= 0; j < dataGridView1.Columns.Count; j++)
                                {
                                    PdfPCell cell = new PdfPCell(new Phrase(dataGridView1.Rows[i].Cells[j].Value.ToString(),normal));
                                    pdfTable.AddCell(cell);
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
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
                MessageBox.Show("No records to exported", "Save",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void button_totext_Click(object sender, EventArgs e)
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
                            ExportExcel(dt, "Manage", "Manage Course", saveFileDialog1.FileName);
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
                        sfd.FileName = "Manage_Course.docx";
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
    }
}

