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
    internal class GroupClass
    {
        MY_DB db = new MY_DB();

        public bool insertGroup(int id, string name, int userid)
        {
            SqlCommand cmd = new SqlCommand(@"INSERT INTO gp (id,name,userid) VALUES (@id,@name,@userid)", db.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
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

        public bool updateGroup(int id, string name)
        {
            SqlCommand cmd = new SqlCommand("Update gp Set name = @name WHERE id = @id", db.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;

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

        public bool deleteGroup(int id)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM gp WHERE id = @id", db.getConnection);
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

        public DataTable getGroup(int id)
        {
            SqlCommand cmd = new SqlCommand("SELECT id,name FROM gp WHERE userid = @id", db.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public bool GroupExist(string name, string operation, int userid = 0, int groupid = 0)
        {
            string query = "";
            SqlCommand cmd = new SqlCommand();
            if (operation == "Add")
            {
                query = "SELECT * FROM gp WHERE name = @name AND userid = @userid";
                cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
                cmd.Parameters.Add("@userid", SqlDbType.Int).Value = userid;
            }
            else if (operation == "Edit")
            {
                query = @"SELECT * FROM gp WHERE id <> @id AND name = @name AND userid = @userid";
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = groupid;
                cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
                cmd.Parameters.Add("@userid", SqlDbType.Int).Value = userid;
            }
            cmd.Connection = db.getConnection;
            cmd.CommandText = query;
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

        public bool IDGroupExist (int id, string name)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM gp WHERE id = @id OR name = @name ", db.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
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
