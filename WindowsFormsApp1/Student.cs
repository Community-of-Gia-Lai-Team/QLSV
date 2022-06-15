using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;


namespace WindowsFormsApp1
{
    internal class Student
    {
        MY_DB db = new MY_DB();

        public bool insertStudent(int Id, string fname,string lname, DateTime bdate,string gender, string phone, string address, MemoryStream picture)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO std (id,fname,lname,bdate,gender,phone,address,picture)" + "VALUES (@id,@fn,@ln,@bd,@gdr,@phn,@adrs,@pic)", db.getConnection);
            cmd.Parameters.Add("@id",SqlDbType.Int).Value = Id;
            cmd.Parameters.Add("@fn",SqlDbType.NVarChar).Value = fname;
            cmd.Parameters.Add("@ln",SqlDbType.NVarChar).Value= lname;
            cmd.Parameters.Add("@bd",SqlDbType.DateTime).Value = bdate;
            cmd.Parameters.Add("@gdr",SqlDbType.NChar).Value = gender;
            cmd.Parameters.Add("@phn", SqlDbType.NChar).Value = phone;
            cmd.Parameters.Add("@adrs", SqlDbType.NVarChar).Value = address;
            cmd.Parameters.Add("@pic",SqlDbType.Image).Value = picture.ToArray();

            db.openConnection();

            if(cmd.ExecuteNonQuery() == 1)
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

        public bool updateStudent(int Id, string fname, string lname, DateTime bdate, string gender, string phone, string address, MemoryStream picture)
        {
            SqlCommand cmd = new SqlCommand("UPDATE std SET fname = @fn,lname = @ln,bdate = @bd,gender = @gdr,phone = @phn,address = @adrs,picture = @pic WHERE Id = @id", db.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = Id;
            cmd.Parameters.Add("@fn", SqlDbType.NVarChar).Value = fname;
            cmd.Parameters.Add("@ln", SqlDbType.NVarChar).Value = lname;
            cmd.Parameters.Add("@bd", SqlDbType.DateTime).Value = bdate;
            cmd.Parameters.Add("@gdr", SqlDbType.NChar).Value = gender;
            cmd.Parameters.Add("@phn", SqlDbType.NChar).Value = phone;
            cmd.Parameters.Add("@adrs", SqlDbType.NVarChar).Value = address;
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

        public bool deleteStudent(int id)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM std WHERE id = @id", db.getConnection);
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

        public bool PhoneExist(string phone)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM std WHERE phone = @phone",db.getConnection);
            cmd.Parameters.Add("@phone", SqlDbType.NChar).Value = phone;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if(dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable getStudent(SqlCommand cmd)
        {
            cmd.Connection = db.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public string execCount(string query)
        {
            SqlCommand cmd = new SqlCommand(query, db.getConnection);
            db.openConnection();
            string count = cmd.ExecuteScalar().ToString();
            db.closeConnection();
            return count;
        }

        public string totalStudent()
        {
            return execCount("SELECT COUNT(*) FROM std");
        }

        public string totalMaleStudent()
        {
            return execCount("SELECT COUNT(*) FROM std WHERE gender = 'Male'");
        }

        public string totalFemaleStudent()
        {
            return execCount("SELECT COUNT(*) FROM std WHERE gender = 'Female'");
        }
    }
}
