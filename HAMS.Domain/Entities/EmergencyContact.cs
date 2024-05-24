using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HAMS.Domain.Entities
{
    public class EmergencyContact : BaseEntity
    {
        public string Name { get; set; }
        public string Relationship { get; set; }
        public string Phone { get; set; }
    }
}
