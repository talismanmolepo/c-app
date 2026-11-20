using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using HospitalPatientManagementSystem.Database;
using HospitalPatientManagementSystem.Model;
        

namespace HospitalPatientManagementSystem.Repository
{
    public class AppointmentRepository
    {
        public List<Appointment> GetAppointments() 
        {
            var appointments = new List<Appointment>();

            using (SqlConnection connection = DatabaseConnect.GetConnection()) 
            {
                connection.Open();

                string query = "SELECT * FROM Appointment;";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {

                    while (reader.Read()) 
                    {
                        appointments.Add(new Appointment
                        {
                            AppointmentID = (int)reader["AppointmentID"],
                            PatientID = (int)reader["PatientID"],
                            DoctorID = (int)reader["DoctorID"],
                            AppointmentTime = (DateTime)reader["AppointmentTime"],
                            Status = reader["Status"].ToString()



                        });
                    }

                    
                }

                 


            }

            return appointments;

        }



    }
}
