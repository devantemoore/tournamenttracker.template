using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tournamenttracker.template.Domain.Entities
{
    public class Team
    {
        public long Id { get; set; }
        public IList<Player> TeamMembers { get; set; }
    }
}
