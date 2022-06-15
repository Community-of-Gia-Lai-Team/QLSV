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
using System.Drawing.Printing;
using Word = Microsoft.Office.Interop.Word;
using Aspose.Words;
using Aspose.Words.Tables;
using WindowsFormsApp1.Report.AsposeWordExtension;

namespace WindowsFormsApp1
{
    public partial class avgResultByScoreForm : Form
    {
        public avgResultByScoreForm()
        {
            InitializeComponent();
        }
        Student student = new Student();
        Score score = new Score();
        private void button_search_Click(object sender, EventArgs e)
        {
            if (textBox_search.Text.Trim() == "")
            {
                MessageBox.Show("Empty Field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dataGridView1.Columns.Clear();
                dataGridView1.DataSource = score.Searchstudentid(Convert.ToInt32(textBox_search.Text));
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.ReadOnly = true;
                dataGridView1.Columns[0].HeaderText = "ID";
                dataGridView1.Columns[1].HeaderText = "First name";
                dataGridView1.Columns[2].HeaderText = "Last name";
                dataGridView1.Columns[3].HeaderText = "Label";
                dataGridView1.Columns[4].HeaderText = "Score";
                DataGridViewColumn col = new DataGridViewColumn();
                DataGridViewCell cell = new DataGridViewTextBoxCell();
                col.HeaderText = "Result";
                col.Name = "result";
                col.CellTemplate = cell;
                dataGridView1.Columns.Add(col);
                DataGridViewColumn col1 = new DataGridViewColumn();
                DataGridViewCell cell1 = new DataGridViewTextBoxCell();
                col1.HeaderText = "Classification";
                col1.Name = "loai";
                col1.CellTemplate = cell1;
                dataGridView1.Columns.Add(col1);
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (Convert.ToDouble(dataGridView1.Rows[i].Cells["student_score"].Value) >= 5)
                    {
                        dataGridView1.Rows[i].Cells["result"].Value = "Pass";
                    }
                    else
                    {
                        dataGridView1.Rows[i].Cells["result"].Value = "Fail";
                    }
                }
                for (int j = 0; j < dataGridView1.Rows.Count; j++)
                {
                    double TB = Convert.ToDouble(dataGridView1.Rows[j].Cells["student_score"].Value);
                    if (TB <= 3)
                    {
                        dataGridView1.Rows[j].Cells["loai"].Value = "Yếu";
                    }
                    else if (TB > 3 && TB <= 6)
                    {
                        dataGridView1.Rows[j].Cells["loai"].Value = "Trung bình";
                    }
                    else if (TB > 6 && TB < 8)
                    {
                        dataGridView1.Rows[j].Cells["loai"].Value = "Khá";
                    }
                    else if (TB >= 8 && TB < 9)
                    {
                        dataGridView1.Rows[j].Cells["loai"].Value = "Giỏi";
                    }
                    else if (TB >= 9 && TB <= 10)
                    {
                        dataGridView1.Rows[j].Cells["loai"].Value = "Xuất xắc";
                    }
                }
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
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
                    Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "J1");
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
                    cl2.Value2 = "First name";
                    cl2.ColumnWidth = 20.0;

                    Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");
                    cl3.Value2 = "Last name";
                    cl3.ColumnWidth = 20.0;

                    Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");
                    cl4.Value2 = "C#";
                    cl4.ColumnWidth = 10.0;

                    Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");
                    cl5.Value2 = "Java";
                    cl5.ColumnWidth = 20.0;

                    Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");
                    cl6.Value2 = "Cloud Computing";
                    cl6.ColumnWidth = 30.0;

                    Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G3", "G3");
                    cl7.Value2 = "Machine Learning";
                    cl7.ColumnWidth = 30.0;

                    Microsoft.Office.Interop.Excel.Range cl8 = oSheet.get_Range("H3", "H3");
                    cl8.Value2 = "Average Score";
                    cl8.ColumnWidth = 30.0;

                    Microsoft.Office.Interop.Excel.Range cl9 = oSheet.get_Range("I3", "I3");
                    cl9.Value2 = "Result";
                    cl9.ColumnWidth = 20.0;

                    Microsoft.Office.Interop.Excel.Range cl10 = oSheet.get_Range("J3", "J3");
                    cl10.Value2 = "Classification";
                    cl10.ColumnWidth = 30.0;

                    Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "J3");
                    rowHead.Font.Bold = true;

                    // Kẻ viền
                    rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

                    // Thiết lập màu nền
                    rowHead.Interior.ColorIndex = 15;
                    rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                    // Tạo mẳng đối tượng để lưu dữ toàn bồ dữ liệu trong DataTable,
                    // vì dữ liệu được được gán vào các Cell trong Excel phải thông qua object thuần.
                    object[,] arr = new object[dt.Rows.Count, dt.Columns.Count + 2];

                    //Chuyển dữ liệu từ DataTable vào mảng đối tượng
                    for (int r = 0; r < dt.Rows.Count; r++)
                    {
                        DataRow dr = dt.Rows[r];
                        for (int c = 0; c < dt.Columns.Count; c++)
                        {
                             arr[r, c] = dr[c];
                        }
                    }

                    for (int rr = 0; rr < dt.Rows.Count; rr++)
                    {
                        for (int c = 8; c < 10; c++)
                        {
                            if (c == 8)
                            {
                                if (Convert.ToDouble(arr[rr, 7].ToString()) >= 5)
                                {
                                    arr[rr, c] = "Pass";
                                }
                                else
                                {
                                    arr[rr, c] = "Fail";
                                }
                            }
                            else if(c == 9)
                            {
                                if (Convert.ToDouble(arr[rr,7].ToString()) <= 3)
                                {
                                    arr[rr,c] = "Yếu";
                                }
                                else if (Convert.ToDouble(arr[rr, 7].ToString()) > 3 && Convert.ToDouble(arr[rr, 7].ToString()) <= 6)
                                {
                                    arr[rr, c] = "Trung bình";
                                }
                                else if (Convert.ToDouble(arr[rr, 7].ToString()) > 6 && Convert.ToDouble(arr[rr, 7].ToString()) < 8)
                                {
                                    arr[rr, c] = "Khá";
                                }
                                else if (Convert.ToDouble(arr[rr, 7].ToString()) >= 8 && Convert.ToDouble(arr[rr, 7].ToString()) < 9)
                                {
                                    arr[rr, c] = "Giỏi";
                                }
                                else if (Convert.ToDouble(arr[rr, 7].ToString()) >= 9 && Convert.ToDouble(arr[rr, 7].ToString()) < 10)
                                {
                                    arr[rr, c] = "Xuất xắc";
                                }
                            }
                        }
                    }

                    //Thiết lập vùng điền dữ liệu
                    int rowStart = 4;
                    int columnStart = 1;
                    int rowEnd = rowStart + dt.Rows.Count - 1;
                    int columnEnd = dt.Columns.Count + 2;

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

        //        public void Export_Data_To_Word(DataGridView DGV, string Filename)
//        {
//            Word.Application oWord = new Word.Application();
//            Word.Document oDoc = oWord.Documents.Add();
//            oDoc.Application.Visible = true;
//            oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;
//            if (DGV.Rows.Count > 0)
//            {
//                int RowCount = DGV.Rows.Count;
//                int ColumnCount = DGV.Columns.Count;
//                Object[,] DataArray = new object[RowCount, ColumnCount];

//                //add rows
//                int r = 0;
//                for (int c = 0; c <= ColumnCount - 1; c++)
//                {
//                    for (r = 0; r <= RowCount - 1; r++)
//                    {
//                        DataArray[r, c] = DGV.Rows[r].Cells[c].Value;
//                    }
//                }

//                //page orintation
//                oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;
//                dynamic oRange = oDoc.Content.Application.Selection.Range;
//                string oTemp = "";

//                for (r = 0; r <= RowCount - 1; r++)
//                {
//                    for (int c = 0; c <= ColumnCount - 1; c++)
//                    {
//                        oTemp = oTemp + DataArray[r, c] + "\t";
//                    }
//                }

//                //table format
//                oRange.Text = oTemp;
//                object Separator = Word.WdTableFieldSeparator.wdSeparateByTabs;
//                object ApplyBorders = true;
//                object AutoFit = true;
//                object AutoFitBehavior = Word.WdAutoFitBehavior.wdAutoFitContent;
//                oRange.ConvertToTable(ref Separator, ref RowCount, ref ColumnCount,
//                                      Type.Missing, Type.Missing, ref ApplyBorders,
//                                      Type.Missing, Type.Missing, Type.Missing,
//                                      Type.Missing, Type.Missing, Type.Missing,
//                                      Type.Missing, ref AutoFit, ref AutoFitBehavior, Type.Missing);
//                oRange.Select();
//                oDoc.Application.Selection.Tables[1].Select();
//                oDoc.Application.Selection.Tables[1].Rows.AllowBreakAcrossPages = 0;
//                oDoc.Application.Selection.Tables[1].Rows.Alignment = 0;
//                oDoc.Application.Selection.Tables[1].Rows[1].Select();
//                oDoc.Application.Selection.InsertRowsAbove(1);
//;                oDoc.Application.Selection.Tables[1].Rows[1].Select();

//                //header row style
//                oDoc.Application.Selection.Tables[1].Rows[1].Range.Bold = 1;
//                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Name = "Times New Roman";
//                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Size = 14;

//                //add header row manually
//                for (int c = 0; c <= ColumnCount - 1; c++)
//                {
//                    oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = DGV.Columns[c].HeaderText;
//                }

//                //table style 
//                oDoc.Application.Selection.Tables[1].set_Style("Grid Table 4 - Accent 4");
//                oDoc.Application.Selection.Tables[1].Rows[1].Select();
//                oDoc.Application.Selection.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;

//                //header text
//                foreach (Word.Section section in oDoc.Application.ActiveDocument.Sections)
//                {
//                    Word.Range headerRange = section.Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
//                    headerRange.Fields.Add(headerRange, Word.WdFieldType.wdFieldPage);
//                    headerRange.Text = "Trường Đại học Sư Phạm Kỹ Thuật TP.HCM";
//                    headerRange.Font.Size = 16;
//                    headerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
//                }

//                oDoc.SaveAs2(Filename);
//                oDoc.Close();
//                oWord.Quit();
//                MessageBox.Show("Save the Word file successfully", "Save file", MessageBoxButtons.OK, MessageBoxIcon.Information);
//            }
//            else
//            {
//                MessageBox.Show("No records to exported", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }

        public void Export_Data_To_Word(DataGridView DGV,string Filname)
        {
            if (DGV.Rows.Count > 0)
            {
                string XL = "";
                var homNay = DateTime.Now;
                Document baoCao = new Document(@"C:\Users\nguye\Downloads\Mau_Bao_Cao.doc");
                if (textBox_search.Text.Trim() != "")
                {
                    DataTable dt = score.TinhdiemTB(Convert.ToInt32(textBox_search.Text));
                    double TB = Convert.ToDouble(dt.Rows[0]["AVG"].ToString());
                    if (TB <= 3)
                    {
                        XL = "Yếu";
                    }
                    else if (TB > 3 && TB <= 6)
                    {
                        XL = "Trung bình";
                    }
                    else if (TB > 6 && TB < 8)
                    {
                        XL = "Khá";
                    }
                    else if (TB >= 8 && TB < 9)
                    {
                        XL = "Giỏi";
                    }
                    else if (TB >= 9 && TB <= 10)
                    {
                        XL = "Xuất xắc";
                    }

                    //Bước 2: Điền các thông tin cố định
                    baoCao.MailMerge.Execute(new[] { "Ngay_Thang_Nam_BC" }, new[] { string.Format("TP. Hồ Chí Minh, ngày {0} tháng {1} năm {2}", homNay.Day, homNay.Month, homNay.Year) });
                    baoCao.MailMerge.Execute(new[] { "ID" }, new[] { DGV.CurrentRow.Cells[0].Value.ToString() });
                    baoCao.MailMerge.Execute(new[] { "Ho_Ten" }, new[] { DGV.CurrentRow.Cells[1].Value.ToString() + " " + DGV.CurrentRow.Cells[2].Value.ToString() });
                    baoCao.MailMerge.Execute(new[] { "TB" }, new[] { dt.Rows[0]["AVG"].ToString() });
                    baoCao.MailMerge.Execute(new[] { "XL" }, new[] { XL });
                }
                else
                {
                    baoCao.MailMerge.Execute(new[] { "Ngay_Thang_Nam_BC" }, new[] { string.Format("TP. Hồ Chí Minh, ngày {0} tháng {1} năm {2}", homNay.Day, homNay.Month, homNay.Year) });
                    baoCao.MailMerge.Execute(new[] { "ID" }, new[] { XL });
                    baoCao.MailMerge.Execute(new[] { "Ho_Ten" }, new[] { XL });
                    baoCao.MailMerge.Execute(new[] { "TB" }, new[] { XL });
                    baoCao.MailMerge.Execute(new[] { "XL" }, new[] { XL });
                }
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

        private void button_save_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)dataGridView1.DataSource;
            try
            {
                if (comboBox_file.SelectedItem.ToString() == "Excel")
                {

                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            ExportExcel(dt, "Result", "Result Score", saveFileDialog1.FileName);
                        }
                }
                else if (comboBox_file.SelectedItem.ToString() == "Word")
                {
                    SaveFileDialog sfd = new SaveFileDialog();

                    sfd.Filter = "Word Documents (*.docx)|*.docx";
                    sfd.FileName = "Result_Score.docx";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        Export_Data_To_Word(dataGridView1, sfd.FileName);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void avgResultByScoreForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = score.getAvgScorezz();
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "First name";
            dataGridView1.Columns[2].HeaderText = "Last name";
            dataGridView1.Columns[3].HeaderText = "Label";
            dataGridView1.Columns[4].HeaderText = "Score";
            DataGridViewColumn col = new DataGridViewColumn();
            DataGridViewCell cell = new DataGridViewTextBoxCell();
             col.HeaderText = "Result";
            col.Name = "result";
            col.CellTemplate = cell;
            dataGridView1.Columns.Add(col);
            DataGridViewColumn col1 = new DataGridViewColumn();
            DataGridViewCell cell1 = new DataGridViewTextBoxCell();
            col1.HeaderText = "Classification";
            col1.Name = "loai";
            col1.CellTemplate = cell1;
            dataGridView1.Columns.Add(col1);
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (Convert.ToDouble(dataGridView1.Rows[i].Cells["student_score"].Value) >= 5)
                {
                    dataGridView1.Rows[i].Cells["result"].Value = "Pass";
                }
                else
                {
                    dataGridView1.Rows[i].Cells["result"].Value = "Fail";
                }
            }
            for (int j = 0; j < dataGridView1.Rows.Count; j++)
            {
                double TB = Convert.ToDouble(dataGridView1.Rows[j].Cells["student_score"].Value);
                if (TB <= 3)
                {
                    dataGridView1.Rows[j].Cells["loai"].Value = "Yếu";
                }
                else if (TB > 3 && TB <= 6)
                {
                    dataGridView1.Rows[j].Cells["loai"].Value = "Trung bình";
                }
                else if (TB > 6 && TB < 8)
                {
                    dataGridView1.Rows[j].Cells["loai"].Value = "Khá";
                }
                else if (TB >= 8 && TB < 9)
                {
                    dataGridView1.Rows[j].Cells["loai"].Value = "Giỏi";
                }
                else if (TB >= 9 && TB <= 10)
                {
                    dataGridView1.Rows[j].Cells["loai"].Value = "Xuất xắc";
                }
            }
        }

        private void dataGridView1_Click_1(object sender, EventArgs e)
        {
            textBox_id.Text = dataGridView1.CurrentRow.Cells["student_id"].Value.ToString();
            textBox_firstname.Text = dataGridView1.CurrentRow.Cells["fname"].Value.ToString();
            textBox_lastname.Text = dataGridView1.CurrentRow.Cells["lname"].Value.ToString();
        }
    }
}
