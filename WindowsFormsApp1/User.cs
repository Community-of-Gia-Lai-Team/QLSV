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
    internal class User
    {
        MY_DB db = new MY_DB();

        public DataTable getUserById(int userid)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM hr WHERE Id = @id",db.getConnection);
            cmd.Parameters.Add("@id",SqlDbType.Int).Value = userid;
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            return dt;
        }

        public bool insertUser (int id,string fname, string lname, string username, string password, MemoryStream picture,string email, string passemail)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO hr (id,fname,lname,uname,pwd,fig,email,pass_email) VALUES(@id,@fname,@lname,@username,@password,@pic,@email,@pemail)", db.getConnection);
            cmd.Parameters.Add("@id",SqlDbType.Int).Value=id;
            cmd.Parameters.Add("@fname",SqlDbType.NVarChar).Value = fname;
            cmd.Parameters.Add("@lname",SqlDbType.NVarChar).Value= lname;
            cmd.Parameters.Add("@username",SqlDbType.NChar).Value = username;
            cmd.Parameters.Add("@password",SqlDbType.NChar).Value= password;
            cmd.Parameters.Add("@pic",SqlDbType.Image).Value = picture.ToArray();
            cmd.Parameters.Add("@email",SqlDbType.VarChar).Value = email;
            cmd.Parameters.Add("@pemail", SqlDbType.VarChar).Value = passemail;

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

        public bool updateUser(int id,string fname, string lname, string password, MemoryStream picture)
        {
            SqlCommand cmd = new SqlCommand("UPDATE hr SET fname = @fname, lname = @lname, pwd = @password, fig = @pic WHERE Id = @id ", db.getConnection);
            cmd.Parameters.Add("@fname", SqlDbType.NVarChar).Value = fname;
            cmd.Parameters.Add("@lname", SqlDbType.NVarChar).Value = lname;
            cmd.Parameters.Add("@password", SqlDbType.NChar).Value = password;
            cmd.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            cmd.Parameters.Add("@id",SqlDbType.Int).Value = id;
            //cmd.Parameters.Add("@email",SqlDbType.VarChar).Value = email;
            //cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = username;

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

        public bool usernameExist (string username, string operation, int userid = 0)
        {
            string query = "";

            if(operation == "register")
            {
                query = "SELECT * FROM hr WHERE Id = @id OR uname = @username";
            }
            else if(operation == "edit")
            {
                query = "SELECT * FROM hr WHERE Id <> @id";
            }

            SqlCommand cmd = new SqlCommand(query, db.getConnection);

            cmd.Parameters.Add("@id",SqlDbType.Int).Value=userid;
            cmd.Parameters.Add("@username", SqlDbType.NChar).Value = username;
            
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

        public bool UsernameExistLogin(string username)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM log_in WHERE username = @username" ,db.getConnection);

            cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;

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
        
        public bool EmailExist(string email)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM hr WHERE email = @email", db.getConnection);

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

        public bool EmailExistLogin(string email)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM log_in WHERE email = @email", db.getConnection);

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
    }
}
