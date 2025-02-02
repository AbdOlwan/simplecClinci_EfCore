using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplieClinic_DAL_EFCore.Entities
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateOnly DateOfBirth { get; set; }

        public char Gendor { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public IList<Appointment> Appointments { get; set; }
        public IList<Payment> Payments { get; set; }
        public IList<MedicalRecord> MedicalRecords { get; set; }
    }
}
