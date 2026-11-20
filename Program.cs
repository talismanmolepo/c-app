using HospitalPatientManagementSystem.Model;
using HospitalPatientManagementSystem.Repository;

namespace HospitalPatientManagementSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            var patientRepository = new PatientRepository();
            var patients = patientRepository.GetAllPatients();

            Console.WriteLine("\n--- Patients ---\n");

            foreach (var patient in patients) 
            {
                Console.WriteLine($"PatientID : {patient.PatientID}\n" +
                    $"First Name : {patient.FirstName}\n" +
                    $"Last Name : {patient.LastName}\n" +
                    $"Gender : {patient.Gender}\n" +
                    $"Date Of Birth : {patient.DateOfBirth}\n");

            }



            var doctorRepository = new DoctorRepository();
            var doctors = doctorRepository.GetDoctorsInformation();

            Console.WriteLine("\n--- List of Doctors mate ---\n");

            foreach (var doctor in doctors) 
            {
                Console.WriteLine($"DoctorID : {doctor.DoctorID}\n" +
                    $"Name : {doctor.DoctorName}\n" +
                    $"Email : {doctor.Email}\n" +
                    $"Field Of Expertise : {doctor.Field}\n\n");

            }



            var appointmentRepository = new AppointmentRepository();
            var appointments = appointmentRepository.GetAppointments();

            Console.WriteLine("\n--- Appointments ---\n");
                        
            foreach (var appointment in appointments) 
            {
                Console.WriteLine($"AppointmentID : {appointment.AppointmentID}\n" +
                    $"PatientID: {appointment.PatientID}\n" +
                    $"DoctorID : {appointment.DoctorID}\n" +
                    $"Appointment Time : {appointment.AppointmentTime}\n" +
                    $"Status : {appointment.Status}\n");

            }


            var billingRepository = new BillingRepository();
            var billings = billingRepository.GetBillings();

            Console.WriteLine("\n--- Payments and dem tings there  --- \n");

            foreach (var billing in billings) 
            {
                Console.WriteLine($"BillingID : {billing.BillingID}\n" +
                    $"AppointmentID : {billing.AppointmentID}\n" +
                    $"Price : R{billing.Price}\n");
                
            }




        }
    }
}
