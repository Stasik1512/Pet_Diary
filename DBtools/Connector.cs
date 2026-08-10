using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet_Diary

{

    public class Connector

    {

        private readonly string connectionString;

        public Connector(string connectionString)

        {

            this.connectionString = connectionString;

        }

        public DataTable ExecuteQuery(string query, params SqlParameter[] parameters)

        {

            using (SqlConnection connection = new SqlConnection(connectionString))

            using (SqlCommand command = new SqlCommand(query, connection))

            using (SqlDataAdapter adapter = new SqlDataAdapter(command))

            {

                if (parameters != null)

                    command.Parameters.AddRange(parameters);

                DataTable table = new DataTable();

                adapter.Fill(table);

                return table;

            }

        }

        public int ExecuteNonQuery(string query, params SqlParameter[] parameters)

        {

            using (SqlConnection connection = new SqlConnection(connectionString))

            using (SqlCommand command = new SqlCommand(query, connection))

            {

                if (parameters != null)

                    command.Parameters.AddRange(parameters);

                connection.Open();

                return command.ExecuteNonQuery();

            }

        }

        public object ExecuteScalar(string query, params SqlParameter[] parameters)

        {

            using (SqlConnection connection = new SqlConnection(connectionString))

            using (SqlCommand command = new SqlCommand(query, connection))

            {

                if (parameters != null)

                    command.Parameters.AddRange(parameters);

                connection.Open();

                return command.ExecuteScalar();

            }

        }

    }

}
