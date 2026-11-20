using System;
using System.Collections.Generic;
using System.Text;
using HospitalPatientManagementSystem.Database;
using HospitalPatientManagementSystem.Repository;

namespace HospitalPatientManagementSystem.Model
{
    public class Billing
    {
        public int BillingID { get; set; }
        public int AppointmentID { get; set; }
        public decimal Price { get; set; }


    }
}
