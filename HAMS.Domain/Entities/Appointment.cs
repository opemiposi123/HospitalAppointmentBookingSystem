using HAMS.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HAMS.Domain.Entities
{
    public class Appointment : BaseEntity
    {
        public string DoctorID { get; set; }
        public Doctor Doctor { get; set; }
        public string PatientID { get; set; }
        public Patient Patient { get; set; }
        public DateTime DateAndTime { get; set; }
        public Department Department { get; set; }
        public string ReasonForVisit { get; set; }
        public AppointmentStatus Status { get; set; } 
        public AppointmentType AppointmentType { get; set; } 
    }
}

