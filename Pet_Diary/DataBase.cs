using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Pet_Diary
{
    public class DataBase
    {
        private readonly Connector connector;
        public DataBase()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Pet_Diary"].ConnectionString;
            connector = new Connector(connectionString);
        }
        public DataTable ExecuteQuery(string query, params SqlParameter[] parameters)
        {
            return connector.ExecuteQuery(query, parameters);
        }


        public int ExecuteNonQuery(string query, params SqlParameter[] parameters)
        {
            return connector.ExecuteNonQuery(query, parameters);
        }


        public object ExecuteScalar(string query, params SqlParameter[] parameters)
        {
            return connector.ExecuteScalar(query, parameters);
        }
    }
}