using MassTransit;

namespace HAMS.Domain.Entities
{
    public class BaseEntity
    {
        
        public string Id { get; set; } = NewId.Next().ToSequentialGuid().ToString();
        public bool IsDeleted { get; set; }
        public string? CreatedBy { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Modified { get; set; }
    }
}
