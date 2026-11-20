using HospitalPatientManagementSystem.Model;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using HospitalPatientManagementSystem.Database;
using HospitalPatientManagementSystem.Model;


namespace HospitalPatientManagementSystem.Repository
{
    public class DoctorRepository
    {

        public List<Doctor> GetDoctorsInformation()
        {
            var doctors = new List<Doctor>();

            using (SqlConnection connection = DatabaseConnect.GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM Doctor;";


                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        doctors.Add(new Doctor 
                        {
                            DoctorID = (int)reader["DoctorID"],
                            DoctorName = reader["DoctorName"].ToString(),
                            Email = reader["Email"].ToString(),
                            Field = reader["Field"].ToString()


                        });


                    }


                }





            }

            return doctors;



        }
    }
}
