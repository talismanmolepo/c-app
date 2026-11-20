using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalPatientManagementSystem.Database
{
    public class DatabaseConnect
    {
        private static readonly string connectionString = "Data Source=.;Initial Catalog=HospitalPatientDB;Integrated Security=True; TrustServerCertificate=True";

        public static SqlConnection GetConnection() 
        {
            return new SqlConnection(connectionString);
        }


    }
}
