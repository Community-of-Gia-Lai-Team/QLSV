using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Drawing.Printing;
using Word = Microsoft.Office.Interop.Word;
using iTextSharp.text.pdf;
using iTextSharp.text;
using Aspose.Words;
using Aspose.Words.Tables;
using WindowsFormsApp1.Report.AsposeWordExtension;


namespace WindowsFormsApp1
{
    public partial class Print : Form
    {
        public Print()
        {
            InitializeComponent();
        }
        Student student = new Student();
        public void FillGrid(SqlCommand cmd)
        {
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = student.getStudent(cmd);
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void Print_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'viduDataSet2.std' table. You can move, or remove it, as needed.
            this.stdTableAdapter.Fill(this.viduDataSet2.std);
            dataGridView1.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
            SqlCommand cmd = new SqlCommand("SELECT * FROM std");
            FillGrid(cmd);
            if (radioButton_No.Checked)
            {
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
            }
        }

        private void radioButton_yes_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
        }

        private void radioButton_No_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
        }

        private void button_check_Click(object sender, EventArgs e)
        {
            SqlCommand cmd;
            String query;
            if (radioButton_yes.Checked)
            {
                string date1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string date2 = dateTimePicker2.Value.ToString("yyyy-MM-dd");

                if (radioButton_male.Checked)
                {
                    query = "SELECT * FROM std WHERE gender = 'Male' and bdate BETWEEN '"+ date1 + "'and'" + date2 + "'";
                }
                else if (radioButton_female.Checked)
                {
                    query = "SELECT * FROM std WHERE gender = 'Female' and bdate BETWEEN '" + date1 + "'and'" + date2 + "'";
                }
                else
                {
                    query = "SELECT * FROM std WHERE bdate BETWEEN '" + date1 + "'and'" + date2 + "'";
                }
                cmd = new SqlCommand(query);
                FillGrid(cmd);
            }
            else
            {
                if (radioButton_male.Checked)
                {
                    query = "SELECT * FROM std WHERE gender = 'Male'";
                }
                else if (radioButton_female.Checked)
                {
                    query = "SELECT * FROM std WHERE gender = 'Female'";
                }
                else
                {
                    query = "SELECT * FROM std ";
                }
                cmd = new SqlCommand(query);
                FillGrid(cmd);
            }
        }

        private void Exporttext()
        {
            if (dataGridView1.Rows.Count > 0)
            {
                String path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\student_list.txt";
                using (TextWriter writer = new StreamWriter(path))
                {
                    if (!File.Exists(path))
                    {
                        File.Create(path);
                    }

                    DateTime bdate;
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count - 1; j++)
                        {
                            if (j == 3)
                            {
                                bdate = Convert.ToDateTime(dataGridView1.Rows[i].Cells[j].Value.ToString());
                                writer.Write("\t" + bdate.ToString("dd-MM-yyyy") + "\t" + "|");
                            }
                            else if (j == dataGridView1.Columns.Count - 2)
                            {
                                writer.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString());
                            }
                            else
                            {
                                writer.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                            }
                        }
                        writer.WriteLine("");
                        writer.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------------------");
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

        public System.Drawing.Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            System.Drawing.Image returnImage = System.Drawing.Image.FromStream(ms);
            return returnImage;
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
                Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "H1");
                head.MergeCells = true;
                head.Value2 = title;
                head.Font.Bold = true;
                head.Font.Name = "Times New Roman";
                head.Font.Size = "20";
                head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                // Tạo tiêu đề cột 
                Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A2", "A2");
                cl1.Value2 = "ID";
                cl1.ColumnWidth = 6.0;

                Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B2", "B2");
                cl2.Value2 = "First name";
                cl2.ColumnWidth = 10.0;

                Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C2", "C2");
                cl3.Value2 = "Last name";
                cl3.ColumnWidth = 10.0;

                Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D2", "D2");
                cl4.Value2 = "Birthdate";
                cl4.EntireColumn.NumberFormat = "dd-MM-yyyy";
                cl4.ColumnWidth = 15.0;

                Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E2", "E2");
                cl5.Value2 = "Gender";
                cl5.ColumnWidth = 10.0;

                Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F2", "F2");
                cl6.Value2 = "Phone";
                cl6.ColumnWidth = 10.0;

                Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G2", "G2");
                cl7.Value2 = "Address";
                cl7.ColumnWidth = 10.0;

                Microsoft.Office.Interop.Excel.Range cl8 = oSheet.get_Range("H2", "H2");
                cl8.Value2 = "Picture";

                Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A2", "H2");
                rowHead.Font.Bold = true;

                // Kẻ viền
                rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

                // Thiết lập màu nền
                rowHead.Interior.ColorIndex = 15;
                rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                // Tạo mẳng đối tượng để lưu dữ toàn bồ dữ liệu trong DataTable,
                // vì dữ liệu được được gán vào các Cell trong Excel phải thông qua object thuần.
                object[,] arr = new object[dt.Rows.Count, dt.Columns.Count - 1];

                //Chuyển dữ liệu từ DataTable vào mảng đối tượng
                for (int r = 0; r < dt.Rows.Count; r++)
                {
                    DataRow dr = dt.Rows[r];
                    for (int c = 0; c < dt.Columns.Count - 1; c++)
                    {
                            arr[r, c] = dr[c];
                    }
                }

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                        dataGridView1.Rows[i].Cells[7].Value.GetType();
                        System.Drawing.Image image1 = byteArrayToImage((byte[])dataGridView1.Rows[i].Cells[7].Value);
                        image1.Save(@"C:\Users\nguye\Downloads\test.PNG");
                        Microsoft.Office.Interop.Excel.Range test = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[i+3,8];
                        float Left = (float)((double)test.Left);
                        float Top = (float)((double)test.Top);
                        oSheet.Shapes.AddPicture(@"C:\Users\nguye\Downloads\test.PNG", Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, Left, Top, 32, 32);
                        test.RowHeight = 36;
                        File.Delete(@"C:\Users\nguye\Downloads\test.PNG");
                }

                //Thiết lập vùng điền dữ liệu
                int rowStart = 3;
                int columnStart = 1;
                int rowEnd = rowStart + dt.Rows.Count - 1;
                int columnEnd = dt.Columns.Count - 1;

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

        //public void Export_Data_To_Word(DataGridView DGV,string Filename)
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
        //        for (int c = 0; c <= ColumnCount -2; c++)
        //        {
        //            for ( r = 0; r <= RowCount - 1 ; r++)
        //            {
        //                    DataArray[r, c] = DGV.Rows[r].Cells[c].Value;
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
        //                if (c == 3)
        //                {
        //                    oTemp = oTemp + Convert.ToDateTime(DataArray[r, c]).ToString("dd/MM/yyyy") + "\t";
        //                }
        //                else
        //                {
        //                    oTemp = oTemp + DataArray[r, c] + "\t";
        //                }
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

        //        for (int c = 0; c <= ColumnCount - 1; c++)
        //        {
        //            for (r = 0; r <= RowCount - 1; r++)
        //            {
        //                if (c == 7)
        //                {

        //                    Object oMissing = oDoc.Tables[1].Cell(r + 1, 8).Range; 
        //                    System.Drawing.Image sparePicture = byteArrayToImage((byte[])DGV.Rows[r].Cells[c].Value);
        //                    Clipboard.SetImage(sparePicture);
        //                    Word.Paragraph oPara2 = oDoc.Content.Paragraphs.Add(ref oMissing);
        //                    oPara2.Range.Paste();
        //                    oPara2.Range.InsertParagraphAfter();
        //                }
        //            }
        //        }
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
        //            headerRange.Text = "Manager Student";
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

        public void Export_Data_To_Word(DataGridView DGV, string Filename)
        {
            if (DGV.Rows.Count > 0)
            {
                var homNay = DateTime.Now;
                Aspose.Words.Document baoCao = new Aspose.Words.Document(@"C:\Users\nguye\Downloads\Student.doc");
                baoCao.MailMerge.Execute(new[] { "Ngay_Thang_Nam_BC" }, new[] { string.Format("TP. Hồ Chí Minh, ngày {0} tháng {1} năm {2}", homNay.Day, homNay.Month, homNay.Year) });
                DocumentBuilder builder = new DocumentBuilder(baoCao);
                Table bangdiem = baoCao.GetChild(NodeType.Table, 1, true) as Table;
                int hangHienTai = 1;
                bangdiem.InsertRows(hangHienTai, hangHienTai, DGV.Rows.Count - 1);
                for (int i = 0; i < DGV.Rows.Count; i++)
                {
                    byte[] pic;
                    pic = (byte[])DGV.Rows[i].Cells[7].Value;
                    MemoryStream ms = new MemoryStream(pic);
                    for (int j = 0; j < DGV.Columns.Count - 1; j++)
                    {
                        if (j == 3)
                        {

                            bangdiem.PutValue(hangHienTai, j, Convert.ToDateTime(DGV.Rows[i].Cells[j].Value).ToString("dd/MM/yyyy"));
                        }
                        else
                        {
                            bangdiem.PutValue(hangHienTai, j, DGV.Rows[i].Cells[j].Value.ToString());
                        }
                        builder.MoveToCell(1, hangHienTai, j, 0);
                    }
                    builder.MoveToCell(1, hangHienTai, 7, 0);
                    builder.ParagraphFormat.Alignment = ParagraphAlignment.Center;
                    builder.InsertImage(new Bitmap(System.Drawing.Image.FromStream(ms), new Size(100, 100)));
                    builder.RowFormat.Height = builder.CellFormat.Width;

                    hangHienTai++;
                }
                baoCao.Save(Filename);
                MessageBox.Show("Save the Word file successfully", "Save file", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No records to exported", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ExportPDF() 
        {
            string arialuniTff = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "vuTimes.TTF");
            BaseFont arial = BaseFont.CreateFont(arialuniTff, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font normal = new iTextSharp.text.Font(arial, 12, iTextSharp.text.Font.NORMAL);
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Manage_Student.pdf";
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
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
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
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);

                            }

                            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                            {
                                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                                {
                                    if (j == 7)
                                    {
                                        byte[] imageByte = (byte[])dataGridView1.Rows[i].Cells[j].Value;
                                        iTextSharp.text.Image Image = iTextSharp.text.Image.GetInstance(imageByte);
                                        pdfTable.AddCell(Image);
                                    }
                                    else if(j == 3)
                                    {
                                        PdfPCell cell = new PdfPCell(new Phrase (Convert.ToDateTime(dataGridView1.Rows[i].Cells[j].Value).ToString("dd/MM/yyyy"),normal));
                                        pdfTable.AddCell(cell);
                                    }
                                    else
                                    {
                                        PdfPCell cell = new PdfPCell(new Phrase(dataGridView1.Rows[i].Cells[j].Value.ToString(), normal));
                                        pdfTable.AddCell(cell);
                                    }
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
                        MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
                      else
                    {
                    MessageBox.Show("No Record To Export !!!", "Info");
                    }
                }

        private void button_savetofile_Click(object sender, EventArgs e)
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

                    sfd.Filter = "Word Documents (*.docx)|*.docx";
                    sfd.FileName = "Manager_Student.docx";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        Export_Data_To_Word(dataGridView1,sfd.FileName);
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

        private void button_toprinter_Click(object sender, EventArgs e)
        {
           PrintDialog printDialog = new PrintDialog();
            PrintDocument printdocument = new PrintDocument();
            printdocument.DocumentName = "Print Document";
            printDialog.Document = printdocument;
            printDialog.AllowSelection = true;
            printDialog.AllowSomePages = true;

            if(printDialog.ShowDialog() == DialogResult.OK)
            {
                printdocument.Print();
            }
        }
    }
}


