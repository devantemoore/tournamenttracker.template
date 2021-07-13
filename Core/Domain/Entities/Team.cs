using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tournamenttracker.template.Domain.Entities
{
    public class Team
    {
        public long Id { get; set; }
        public string Name { get; private set; }
        public string MembershipKey { get; private set; }
        public IList<Player> TeamMembers { get; private set; }

        public Team()
        {
            TeamMembers = new List<Player>();
        }
    }
}
