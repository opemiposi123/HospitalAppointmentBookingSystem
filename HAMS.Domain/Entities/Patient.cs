using HAMS.Domain.Enums;

namespace HAMS.Domain.Entities
{
    public class Patient : BaseEntity
    {
        public string Name { get; set; }
        public ContactDetails ContactDetails { get; set; }
        public string Address { get; set; }
        public string MedicalHistory { get; set; } 
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public EmergencyContact EmergencyContact { get; set; }
        public List<MedicalRecords> MedicalRecords { get; set; } 

        public Patient()
        {
            MedicalRecords = new List<MedicalRecords>();
        }
    }
}
