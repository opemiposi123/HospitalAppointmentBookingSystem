namespace HAMS.Domain.Entities
{
    public class Doctor : BaseEntity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public Department Department { get; set; }
        public string DepartmentId { get; set; }
        public Specialties Specialties { get; set; }
        public string SpecialtiesId { get; set; }
        public ContactDetails ContactDetails { get; set; }
        public List<DoctorAvailability> DoctorAvailabilities { get; set; }

        public Doctor()
        {
            DoctorAvailabilities = new List<DoctorAvailability>();
        }
    }
}
