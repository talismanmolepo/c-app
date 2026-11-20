using System;
using System.Collections.Generic;
using System.Text;
using HospitalPatientManagementSystem.Database;
using HospitalPatientManagementSystem.Repository;


namespace HospitalPatientManagementSystem.Model
{
    public class Doctor
    {
        public int DoctorID { get; set; }
        public string DoctorName { get; set; }
        public string Email { get; set; }
        public string Field {  get; set; }
    }
}
