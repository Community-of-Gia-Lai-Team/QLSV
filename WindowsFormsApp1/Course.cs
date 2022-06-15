using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    internal class Course
    {
        MY_DB db = new MY_DB();

        public bool checkCourseName(string courseName, int courseID = 0)
        {
            SqlCommand cmd = new SqlCommand("Select * From course_table Where label = @name and id <> @id", db.getConnection);
            cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = courseName;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = courseID;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool insertCourse(int courseid, string label, int period, string description,int idcontact)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO course_table (id,label,period,descriptions,id_contact)" + "VALUES (@id,@label,@period,@descriptions,@id_contact)", db.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = courseid;
            cmd.Parameters.Add("@label", SqlDbType.NVarChar).Value = label;
            cmd.Parameters.Add("@period", SqlDbType.Int).Value = period;
            cmd.Parameters.Add("@descriptions", SqlDbType.NVarChar).Value = description;
            cmd.Parameters.Add("@id_contact",SqlDbType.Int).Value = idcontact;

            db.openConnection();

            if (cmd.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }

        public bool deleteCourse(int id)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM course_table WHERE id = @id", db.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            db.openConnection();
            if (cmd.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }

        public bool updateCourse(int course, string label, int period, string description,int idcontact)
        {
            SqlCommand cmd = new SqlCommand("UPDATE course_table SET label = @label, period = @period, descriptions = @des, id_contact = @idcontact WHERE id = @course ", db.getConnection);
            cmd.Parameters.Add("@course", SqlDbType.Int).Value = course;
            cmd.Parameters.Add("@label", SqlDbType.NVarChar).Value = label;
            cmd.Parameters.Add("@period", SqlDbType.Int).Value = period;
            cmd.Parameters.Add("@des", SqlDbType.NVarChar).Value = description;
            cmd.Parameters.Add("@idcontact",SqlDbType.Int).Value=idcontact;

            db.openConnection();

            if (cmd.ExecuteNonQuery() == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable getAllCourses()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM course_table",db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public DataTable getCourseID(int courseid)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM course_table WHERE id = @id",db.getConnection);
            cmd.Parameters.Add("@id",SqlDbType.VarChar).Value = courseid;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        string execCount(string query)
        {
            SqlCommand cmd= new SqlCommand(query,db.getConnection);
            db.openConnection();
            string count = cmd.ExecuteScalar().ToString();
            db.closeConnection();
            return count;
        }
        public string totalCourse()
        {
            return execCount("Select count(*) from course_table");
        }

        public DataTable getCourse(SqlCommand cmd)
        {
            cmd.Connection = db.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    } 
}
