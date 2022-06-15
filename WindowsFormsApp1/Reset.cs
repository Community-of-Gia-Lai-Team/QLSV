using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApp1
{
    internal class Reset
    {
        MY_DB db = new MY_DB();

        public static string Randd()
        {
            string randss = "";
            Random r = new Random();
            randss = r.Next(111111,999999).ToString();
            return randss;
        }
        public bool updatepass(string user,string email,string pass)
        {
            SqlCommand cmd = new SqlCommand("UPDATE log_in SET password = @pass WHERE username = @user and email = @email", db.getConnection);
            cmd.Parameters.Add("@user",SqlDbType.VarChar).Value = user;
            cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
            cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = pass;

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

        public DataTable getemaillog_in(string username,string email)
        {
            SqlCommand cmd = new SqlCommand("SELECT email, pass_email FROM log_in WHERE username = @username AND email = @email",db.getConnection);
            cmd.Parameters.Add("@username",SqlDbType.VarChar).Value=username;
            cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public bool getuser_email(string username, string email)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM log_in WHERE username = @username AND email = @email",db.getConnection);
            cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
            cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
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

        public DataTable getemailhr(string username, string email)
        {
            SqlCommand cmd = new SqlCommand("SELECT email, pass_email FROM hr WHERE uname = @username AND email = @email", db.getConnection);
            cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
            cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public bool getuser_emailHR(string username, string email,int id)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM hr WHERE Id = @id AND uname = @username AND email = @email", db.getConnection);
            cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
            cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
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
    }
}
