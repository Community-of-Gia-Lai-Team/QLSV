using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApp1
{
    internal class Register
    {
        MY_DB db = new MY_DB();
        public bool insertLog_in(string user, string pass,string email, string pass_email)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO log_in (username, password,email,pass_email)" + "VALUES(@username,@password,@email,@pass_email)",db.getConnection);
            cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = user;
            cmd.Parameters.Add("@password",SqlDbType.VarChar).Value = pass;
            cmd.Parameters.Add("@email",SqlDbType.VarChar).Value = email;
            cmd.Parameters.Add("@pass_email",SqlDbType.VarChar).Value = pass_email;

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

        public bool usernameExistContact(string username)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM hr WHERE uname = @username",db.getConnection);
            cmd.Parameters.Add ("@username",SqlDbType.VarChar).Value =username;
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
    }
}
