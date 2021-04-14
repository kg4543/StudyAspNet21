using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LoginWebApp.Models
{
    public class Repository
    {
        private SqlConnection conn;

        public Repository()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString);
        }

        public int AddUser(string userId,string Password)
        {
            SqlCommand cmd = new SqlCommand("WriteUsers",conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UserID",userId);
            cmd.Parameters.AddWithValue("@Password",Password);

            conn.Open();
            var result = cmd.ExecuteNonQuery();
            conn.Close();

            return result;

        }

        internal bool IsCorretUser(string userId, string password)
        {
            bool result = false;
            SqlCommand cmd = new SqlCommand("select * from Users Where UserID = @UserID AND Password = @Password", conn);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.AddWithValue("@UserID",userId);
            cmd.Parameters.AddWithValue("@Password",password);

            conn.Open();
            var dr = cmd.ExecuteReader();
            
            if (dr.Read())
            {
                result = true;
            }
            dr.Close();
            conn.Close();
            return result;
        }

        public Users GetUserByUserId(string userId)
        {
            var U = new Users();
            SqlCommand cmd = new SqlCommand("Select * from Users Where UserID = @UserID",conn);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.AddWithValue("@UserID", userId);

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                U.UID = Convert.ToInt32(reader["UID"]);
                U.UserId = reader["Password"].ToString();
                U.Password = reader["UserID"].ToString();
            }
            conn.Close();
            return U;
        }
    }
}