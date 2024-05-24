using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HAMS.Domain.Entities
{
    public  class Specialties : BaseEntity
    {
        public string Name { get; set; }
        public string? Description { get; set; } = default;
    }
}
