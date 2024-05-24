using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HAMS.Domain.Entities
{
    public class Schedule : BaseEntity
    {
        public string DoctorID { get; set; }
        public Doctor Doctor { get; set; }
        public string PatientID { get; set; }
        public Patient Patient { get; set; }
        public string AppointmentID { get; set; }
        public Appointment Appointment { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Notes { get; set; } 
    }
}
