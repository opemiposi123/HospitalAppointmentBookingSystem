using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HAMS.Domain.Entities
{
    public class MedicalRecords : BaseEntity
    {
        public string PatientID { get; set; }
        public Patient Patient { get; set; }
        public DateTime RecordDate { get; set; }
        public string Diagnoses { get; set; }
        public string Treatments { get; set; }
        public string Medications { get; set; }
        public string Allergies { get; set; }
        public string? Notes { get; set; }
        public List<Prescriptions> Prescriptions { get; set; } // Navigation property

        public MedicalRecords()
        {
            Prescriptions = new List<Prescriptions>();
        }
    }
}
