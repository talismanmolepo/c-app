using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using HospitalPatientManagementSystem.Database;
using HospitalPatientManagementSystem.Model;


namespace HospitalPatientManagementSystem.Repository
{
    public class BillingRepository
    {

        public List<Billing> GetBillings()
        {
            var billings = new List<Billing>();

            using (SqlConnection connection = DatabaseConnect.GetConnection()) 
            {
                connection.Open();
                string query = "SELECT * FROM Billing;";


                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader()) 
                {

                    while (reader.Read()) 
                    {
                        billings.Add(new Billing
                        {
                            BillingID = (int)reader["BillingID"],
                            AppointmentID = (int)reader["AppointmentID"],
                            Price = (decimal)reader["Price"]


                        });

                    }
                    

                }


            }


                


        return billings;

        }

       


    }
}
