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
using Word = Microsoft.Office.Interop.Word;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class ManageScore : Form
    {
        public ManageScore()
        {
            InitializeComponent();
        }

        Score score = new Score();
        Course course = new Course();   
        Student student = new Student();
        Contacts contacts = new Contacts();
        string data = "score";

        private void ManageScore_Load(object sender, EventArgs e)
        {
            int id = Contact_Full_List_Form.idcontact;
            if (id > 0)
            {
                dataGridView1.DataSource = contacts.getCourseByContact(Contact_Full_List_Form.idcontact);
                dataGridView1.ReadOnly = true;
                dataGridView1.Columns[0].HeaderText = "ID";
                dataGridView1.Columns[1].HeaderText = "Course name";
                data = "contact";
            }
            else
            {
                dataGridView1.ReadOnly = true;
                dataGridView1.DataSource = score.getStudentScore();
                dataGridView1.Columns[0].HeaderText = "Student ID";
                dataGridView1.Columns[1].HeaderText = "First name";
                dataGridView1.Columns[2].HeaderText = "Last name";
                dataGridView1.Columns[3].HeaderText = "Course ID";
                dataGridView1.Columns[4].HeaderText = "Label";
                dataGridView1.Columns[5].HeaderText = "Score";
                dataGridView1.AllowUserToAddRows = false;
            }

            comboBox_course.DataSource = course.getAllCourses();
            comboBox_course.DisplayMember = "label";
            comboBox_course.ValueMember = "id";
            dataGridView1.AllowUserToAddRows = false;

            comboBox_contact.DataSource = contacts.getnameContact();
            comboBox_contact.DisplayMember = "name";
            comboBox_contact.ValueMember = "id";
        }

        private void button_showscore_Click(object sender, EventArgs e)
        {
            data = "score";
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = score.getStudentScore();
            dataGridView1.Columns[0].HeaderText = "Student ID";
            dataGridView1.Columns[1].HeaderText = "First name";
            dataGridView1.Columns[2].HeaderText = "Last name";
            dataGridView1.Columns[3].HeaderText = "Course ID";
            dataGridView1.Columns[4].HeaderText = "Label";
            dataGridView1.Columns[5].HeaderText = "Score";
            dataGridView1.AllowUserToAddRows = false;
        }

        private void button_showstudent_Click(object sender, EventArgs e)
        {
            data = "std";
            dataGridView1.ReadOnly=true;
            SqlCommand cmd = new SqlCommand("SELECT id, fname, lname, bdate FROM std ORDER BY id ASC");
            dataGridView1.DataSource = student.getStudent(cmd);
            dataGridView1.Columns[0].HeaderText = "Student ID";
            dataGridView1.Columns[1].HeaderText = "First name";
            dataGridView1.Columns[2].HeaderText = "Last name";
            dataGridView1.Columns[3].HeaderText = "BirthDate";
            dataGridView1.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void getDataFromDatagridview()
        {
            if (data == "std")
            {
                textBox_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            }
            else if (data == "score")
            {
                textBox_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                comboBox_course.SelectedValue = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            }
            else if (data == "contact")
            {
                int idcourse = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                int idd = Contact_Full_List_Form.idcontact;
                if (idd > 0)
                {
                    dataGridView1.DataSource = contacts.getStudentScoreByContact(idcourse, Contact_Full_List_Form.idcontact);
                }
                else
                {
                    int idcontact = Convert.ToInt32(comboBox_contact.SelectedValue);
                    dataGridView1.DataSource = contacts.getStudentScoreByContact(idcourse,idcontact);
                }
                dataGridView1.ReadOnly = true;
                dataGridView1.Columns[0].HeaderText = "Student ID";
                dataGridView1.Columns[1].HeaderText = "First name";
                dataGridView1.Columns[2].HeaderText = "Last name";
                dataGridView1.Columns[3].HeaderText = "Course ID";
                dataGridView1.Columns[4].HeaderText = "Label";
                dataGridView1.Columns[5].HeaderText = "Score";
                dataGridView1.Columns[6].HeaderText = "Name Contact";
                dataGridView1.AllowUserToAddRows = false;
                data = "";
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            getDataFromDatagridview();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                int studentid = Convert.ToInt32(textBox_id.Text);
                int courseid = Convert.ToInt32(comboBox_course.SelectedValue);
                float scores = Convert.ToInt32(textBox_score.Text);
                string des = textBox_des.Text;
                if (scores > 10)
                {
                    MessageBox.Show("Score cannot exceed 10", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!score.studentScoreExist(studentid, courseid))
                {
                    if (score.insertScore(studentid, courseid, scores, des))
                    {
                        MessageBox.Show("Student Score Inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Student Score Not Inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
                else
                {
                    MessageBox.Show("The Score For This Course Are Already Set", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            int studentid = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            int courseid = int.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
            try
            {
                if ((MessageBox.Show("Are You Sure You Want To Delete This Course ", "Delete Course", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
                {
                    if (score.deleteScore(studentid, courseid))
                    {
                        MessageBox.Show("Score Deleted", "Delete Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Score Not Deleted", "Delete Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Please Enter A Valid Course ID and Student ID", "Delete Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_avgscore_Click(object sender, EventArgs e)
        {
            avgScoreByCourseForm avg = new avgScoreByCourseForm();
            avg.Show(this);
        }

        private void button_find_Click(object sender, EventArgs e)
        {
            data = "contact";
            int id = Convert.ToInt32(comboBox_contact.SelectedValue);
            dataGridView1.DataSource = contacts.getCourseByContact(id);
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Columns[0].HeaderText = "Course Name";
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
                    headerRange.Text = "Manager";
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

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Word Documents (*.docx)|*.docx";
            sfd.FileName = "Manager.docx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Export_Data_To_Word(dataGridView1, sfd.FileName);
            }
        }

        private void textBox_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider_id.SetError(textBox_id, "Do not use letter!");
            }
            else
            {
                errorProvider_id.SetError(textBox_id, null);
            }
        }

        private void textBox_score_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider_score.SetError(textBox_score, "Do not use letter!");
            }
            else
            {
                errorProvider_score.SetError(textBox_score, null);
            }
        }
    }
}
