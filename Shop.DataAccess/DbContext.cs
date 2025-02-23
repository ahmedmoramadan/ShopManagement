using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Shop.DataAccess
{
    public class DbContext
    {
        private readonly SqlConnection _connection;

        public DbContext(string connectionString)
        {
            _connection = new SqlConnection(connectionString);
        }

        public DataTable ExecuteQuery(string cmdTxt, SqlParameter[] parameters = null)
        {
            using (SqlCommand cmd = new SqlCommand(cmdTxt, _connection))
            {
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public int ExecuteNonQuery(string cmdTxt, SqlParameter[] parameters = null)
        {
            using (SqlCommand cmd = new SqlCommand(cmdTxt, _connection))
            {
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }

                int affectedRows = 0;
                try
                {
                    _connection.Open();
                    affectedRows = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    // Log the exception (e.g., using a logging framework)
                    Console.WriteLine($"Error: {ex.Message}");
                }
                finally
                {
                    _connection.Close();
                }
                return affectedRows;
            }
        }

        public object ExecuteScalar(string cmdTxt, SqlParameter[] parameters = null)
        {
            using (SqlCommand cmd = new SqlCommand(cmdTxt, _connection))
            {
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }

                _connection.Open();
                object result = cmd.ExecuteScalar();
                _connection.Close();
                return result;
            }
        }
    }
}