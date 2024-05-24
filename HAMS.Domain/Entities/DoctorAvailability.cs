using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HAMS.Domain.Entities
{
    public class DoctorAvailability : BaseEntity
    {
        public int DoctorAvailabilityID { get; set; }
        public int DoctorID { get; set; }
        public Doctor Doctor { get; set; } // Navigation property
        public string DayOfWeek { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public bool IsAvailable { get; set; }
        public string Notes { get; set; } // Optional
    }
}
