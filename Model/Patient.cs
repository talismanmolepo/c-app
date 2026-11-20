using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using HospitalPatientManagementSystem.Database;
using HospitalPatientManagementSystem.Repository;


namespace HospitalPatientManagementSystem.Model
{
    public class Patient
    {
        public int PatientID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
