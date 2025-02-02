using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplieClinic_DAL_EFCore.Entities
{
    public class Payment
    {
        public int Id { get; set; }
        public int PatientID { get; set; }

        public DateOnly PaymentDate {  get; set; }
        public string Paymentmethod { get; set; }

        public int AmountPaid { get; set; }

        public string? Note { get; set; }

        public Patient Patient { get; set; }
    }
}
