using System;
using System.Collections.Generic;
using System.Text;
using HospitalPatientManagementSystem.Database;
using HospitalPatientManagementSystem.Repository;

namespace HospitalPatientManagementSystem.Model
{
    public class Appointment
    {
        public int AppointmentID { get; set; }
        public int PatientID { get; set; }
        public int DoctorID { get; set; }
        public DateTime AppointmentTime {  get; set; }
        public string Status {  get; set; }

    }
}
