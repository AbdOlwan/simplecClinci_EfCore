using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplieClinic_DAL_EFCore.Entities
{
    public class Appointment
    {
        public int Id { get; set; }
        public int PatientID { get; set; }
        public int DoctorID { get; set; }   
        public DateOnly appointDate { get; set; }
        public TimeOnly  appointTime { get; set; }

        public int appointStatus { get; set; }


        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }
        public AppointmentStatus AppointmentStatus { get; set; }
    }
}
