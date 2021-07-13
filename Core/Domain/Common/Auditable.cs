using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tournamenttracker.template.Domain.Entities
{
    public class Auditable
    {
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
