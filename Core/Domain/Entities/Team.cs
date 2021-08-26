using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tournamenttracker.template.Core.Application.Model;

namespace tournamenttracker.template.Domain.Entities
{
    public class Team : Auditable
    {
        public long Id { get; set; }
        public string Name { get; private set; }
        public string MembershipKey { get; private set; }
        public IList<Player> TeamMembers { get; private set; }
        public HomeOrAway HomeOrAway { get; set; }
        public IList<AppRequest<Player, Team>> Requests { get; set; }

        public Team()
        {
            Requests = new List<AppRequest<Player, Team>>();
            TeamMembers = new List<Player>();
        }
    }
}
