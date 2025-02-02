using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplieClinic_DAL_EFCore.Entities
{
    public class MedicalRecord
    {
        public int ID { get; set; }
        public int PatientID { get; set; }
        public int DoctorID { get; set; }
        public DateOnly VisitDate {  get; set; }
        public string Description { get; set; }
        public string Diagnosis { get; set; }
        public string Notes { get; set; }


        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }

        public Prescription Prescription { get; set; }

    }
}
