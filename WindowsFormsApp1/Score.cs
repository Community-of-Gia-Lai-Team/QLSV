using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApp1
{
    internal class Score
    {
        MY_DB db = new MY_DB();

        public bool insertScore(int studentid, int courseid , float score, string description)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO score (student_id,course_id,student_score,description)" + "VALUES (@student_id,@course_id,@score,@description)", db.getConnection);
            cmd.Parameters.Add("@student_id", SqlDbType.Int).Value = studentid;
            cmd.Parameters.Add("@course_id", SqlDbType.Int).Value = courseid;
            cmd.Parameters.Add("@score", SqlDbType.Float).Value = score;
            cmd.Parameters.Add("@description", SqlDbType.NVarChar).Value = description;


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

        public bool studentScoreExist(int studentid, int courseid) 
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM score WHERE student_id = @student_id AND course_id = @course_id",db.getConnection);
                cmd.Parameters.Add("@student_id",SqlDbType.Int).Value = studentid;
                cmd.Parameters.Add("@course_id",SqlDbType.Int).Value=courseid;
                
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt= new DataTable();
                adapter.Fill(dt);
                
                if(dt.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        } 

        public DataTable getAvg()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = db.getConnection;

            cmd.CommandText = "SELECT course_table.label, AVG(score.student_score) as AverageGrade FROM course_table, score WHERE course_table.id =" +
                "score.course_id GROUP BY course_table.label";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public bool deleteScore(int studentid,int courseid)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM score WHERE student_id = @sid AND course_id = @cid", db.getConnection);
            cmd.Parameters.Add("@sid", SqlDbType.Int).Value = studentid;
            cmd.Parameters.Add("@cid", SqlDbType.Int).Value = courseid;

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

        public DataTable getStudentScore()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection= db.getConnection;
            cmd.CommandText = (@"SELECT score.student_id, std.fname, std.lname, score.course_id, course_table.label, score.student_score 
                                FROM course_table INNER JOIN score on course_table.id = score.course_id INNER JOIN std ON score.student_id = std.id");
            SqlDataAdapter  adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public DataTable getStudentScores(int studentid)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = db.getConnection;
            cmd.CommandText = (@"SELECT score.student_id, std.fname, std.lname, score.course_id, course_table.label, score.student_score 
                                FROM course_table INNER JOIN score on course_table.id = score.course_id INNER JOIN std ON score.student_id = std.id where score.student_id = " + studentid); ;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public DataTable getCourseScore(int courseid)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = db.getConnection;
            cmd.CommandText = (@"SELECT score.student_id, std.fname, std.lname, score.course_id, course_table.label, score.student_score 
                                FROM course_table INNER JOIN score on course_table.id = score.course_id INNER JOIN std ON score.student_id = std.id where score.course_id =" + courseid);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public DataTable getAvgScorezz()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = db.getConnection;
            cmd.CommandText = @"SELECT score.student_id, std.fname, std.lname, course_table.label, score.student_score 
                                FROM course_table INNER JOIN score on course_table.id = score.course_id INNER JOIN std ON score.student_id = std.id";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public DataTable Searchstudentid(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = db.getConnection;
            cmd.CommandText = @"SELECT score.student_id, std.fname, std.lname, course_table.label, score.student_score 
                                FROM course_table INNER JOIN score on course_table.id = score.course_id INNER JOIN std ON score.student_id = std.id
                                WHERE score.student_id = "+id;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public DataTable TinhdiemTB(int id)
        {
            SqlCommand cmd = new SqlCommand("SELECT AVG(score.student_score) as AVG FROM score WHERE score.student_id =" + id, db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public string execCount(string query)
        {
            SqlCommand cmd = new SqlCommand(query, db.getConnection);
            db.openConnection();
            string count = cmd.ExecuteScalar().ToString();
            db.closeConnection();
            return count;
        }

        public string totalPasstudent()
        {
            return execCount("select count(*) as Counts from (select student_id, avg(student_score) as AVG from score group by student_id) as B where B.AVG >=5");
        }

        public string totalFailStudent()
        {
            return execCount("select count(*) as Counts from (select student_id, avg(student_score) as AVG from score group by student_id) as B where B.AVG  < 5");
        }

        public string totalYstudent()
        {
            return execCount("select count(*) as Counts from (select student_id, avg(student_score) as AVG from score group by student_id) as B where B.AVG <= 3");
        }

        public string totalTBstudent()
        {
            return execCount("select count(*) as Counts from (select student_id, avg(student_score) as AVG from score group by student_id) as B where B.AVG > 3 and B.AVG <=6");
        }

        public string totalKstudent()
        {
            return execCount("select count(*) as Counts from (select student_id, avg(student_score) as AVG from score group by student_id) as B where B.AVG > 6 and B.AVG <8");
        }

        public string totalGstudent()
        {
            return execCount("select count(*) as Counts from (select student_id, avg(student_score) as AVG from score group by student_id) as B where B.AVG >= 8 and B.AVG <9");
        }

        public string totalXXstudent()
        {
            return execCount("select count(*) as Counts from (select student_id, avg(student_score) as AVG from score group by student_id) as B where B.AVG >= 9 and B.AVG <10");
        }
    }
}
