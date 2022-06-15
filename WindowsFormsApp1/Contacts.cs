using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace WindowsFormsApp1
{
    internal class Contacts
    {
        MY_DB db = new MY_DB();

        public bool insertContact(int id,string fname, string lname, string phone, string address,string email,int groupid, MemoryStream picture, int userid)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Contact (id,fname,lname,group_id,phone,email,address,pic,userid) VALUES(@id,@fname,@lname,@group_id,@phone,@email,@address,@pic,@userid)", db.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@fname", SqlDbType.NVarChar).Value = fname;
            cmd.Parameters.Add("@lname", SqlDbType.NVarChar).Value = lname;
            cmd.Parameters.Add("@group_id", SqlDbType.Int).Value = groupid;
            cmd.Parameters.Add("@phone", SqlDbType.NChar).Value = phone;
            cmd.Parameters.Add("@email", SqlDbType.NChar).Value = email;
            cmd.Parameters.Add("@address", SqlDbType.NVarChar).Value = address;
            cmd.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            cmd.Parameters.Add("@userid", SqlDbType.Int).Value = userid;

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

        public bool updateContact(int id,string fname, string lname, string phone, string address, string email, int groupid, MemoryStream picture)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Contact SET fname = @fname, lname = @lname, group_id = @group_id, phone = @phone,email = @email,address = @address,pic = @pic WHERE id = @id ", db.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@fname", SqlDbType.NVarChar).Value = fname;
            cmd.Parameters.Add("@lname", SqlDbType.NVarChar).Value = lname;
            cmd.Parameters.Add("@group_id", SqlDbType.Int).Value = groupid;
            cmd.Parameters.Add("@phone", SqlDbType.NChar).Value = phone;
            cmd.Parameters.Add("@email", SqlDbType.NChar).Value = email;
            cmd.Parameters.Add("@address", SqlDbType.NVarChar).Value = address;
            cmd.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();

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

        public bool deleteContact(int id)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM Contact WHERE id = @id",db.getConnection);
            cmd.Parameters.Add("@id",SqlDbType.Int).Value = id;

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

        public bool CheckID(int id)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Contact WHERE id = @id", db.getConnection);

            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Checkemail(string email)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Contact WHERE email = @email", db.getConnection);

            cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = email;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Checkphone(string phone)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Contact WHERE phone = @phone", db.getConnection);

            cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = phone;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable SelectContactList(SqlCommand cmd)
        {
            cmd.Connection = db.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public DataTable GetContactByID (int id)
        {
            SqlCommand cmd = new SqlCommand("SELECT id, fname, lname, group_id, phone, email, address, pic, userid FROM Contact WHERE id = @id ", db.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public DataTable getnameContact()
        {
            SqlCommand cmd = new SqlCommand("SELECT id, CONCAT(fname,' ',lname)as name FROM Contact ", db.getConnection);            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public DataTable getStudentScoreByContact(int courseid,int idcontact)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = db.getConnection;
            cmd.CommandText = (@"SELECT score.student_id, std.fname, std.lname, score.course_id, course_table.label, score.student_score, Concat(Contact.fname,' ', Contact.lname) as namecontact 
                                FROM course_table INNER JOIN score on course_table.id = score.course_id INNER JOIN std ON score.student_id = std.id 
                                INNER JOIN Contact ON course_table.id_contact = Contact.id where Contact.id = " + idcontact + "AND course_table.id ="+courseid); ;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public DataTable getCourseByContact(int idcontact)
        { 
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = db.getConnection;
            cmd.CommandText = (@"SELECT id, course_table.label
                                FROM course_table WHERE id_contact =" + idcontact);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }
}
