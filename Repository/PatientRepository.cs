using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using HospitalPatientManagementSystem.Database;
using HospitalPatientManagementSystem.Model;

namespace HospitalPatientManagementSystem.Repository
{

    public class PatientRepository
    {

        public List<Patient> GetAllPatients() 
        {
            var patients = new List<Patient>();

            using (SqlConnection connection = DatabaseConnect.GetConnection()) 
            {
                connection.Open();
                string query = "SELECT * FROM Patient";


                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader()) 
                {
                    while (reader.Read()) 
                    {
                        patients.Add(new Patient 
                        {
                            PatientID = (int)reader["PatientID"],
                            FirstName = reader["FirstName"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            Gender = reader["Gender"].ToString(),
                            DateOfBirth = (DateTime)reader["DateOfBirth"]

                        });
                        
                    }
                }    

               
            }
            return patients;


        }
    

    }

    

}
