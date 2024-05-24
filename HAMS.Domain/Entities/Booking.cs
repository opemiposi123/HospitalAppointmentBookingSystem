using HAMS.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HAMS.Domain.Entities
{
    public class Booking : BaseEntity
    {
        public string AppointmentID { get; set; }
        public Appointment Appointment { get; set; }
        public string PatientID { get; set; }
        public Patient Patient { get; set; }
        public DateTime DateAndTime { get; set; }
        public BookingStatus Status { get; set; } 
    }
}
