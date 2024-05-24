using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HAMS.Domain.Entities
{
    public class Prescriptions : BaseEntity
    {
        public string MedicalRecordID { get; set; }
        public MedicalRecords MedicalRecord { get; set; }
        public DateTime PrescriptionDate { get; set; }
        public string MedicationName { get; set; }
        public string Dosage { get; set; }
        public string Frequency { get; set; }
        public int DurationInDays { get; set; }
        public string? Instructions { get; set; } 
    }
}
