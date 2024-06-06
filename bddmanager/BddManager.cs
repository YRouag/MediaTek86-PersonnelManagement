using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace MediaTek86.bddmanager
{
    public class BddManager
    {
        private string connectionString;

        public BddManager(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public DataTable ExecuteQuery(string query, List<SqlParameter> parameters = null)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters.ToArray());
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        public int ExecuteNonQuery(string query, List<SqlParameter> parameters = null)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters.ToArray());
                }

                connection.Open();
                return command.ExecuteNonQuery();
            }
        }
    }
}
