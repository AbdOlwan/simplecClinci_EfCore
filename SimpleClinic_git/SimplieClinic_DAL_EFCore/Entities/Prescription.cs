using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplieClinic_DAL_EFCore.Entities
{
    public class Prescription
    {
        public int Id { get; set; }

        public int MedicalRecordID { get; set; }
        public string MedicationName { get; set; }
        public string Dosage {  get; set; }

        public short Frequency { get; set; }

        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public string SpecialInstructions { get; set; }

        public MedicalRecord MedicalRecord { get; set; }
    }
}
