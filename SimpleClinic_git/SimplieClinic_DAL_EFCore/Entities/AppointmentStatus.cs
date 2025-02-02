using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplieClinic_DAL_EFCore.Entities
{
    public class AppointmentStatus
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public IList< Appointment> Appointment { get; set; }
    }
}
