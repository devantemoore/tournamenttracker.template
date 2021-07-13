using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tournamenttracker.template.Domain.Entities
{
    public class Tournament : Auditable
    {
        public Tournament()
        {
            Rounds = new List<List<Match>>();
        }
        public long Id { get; set; }
        public int NumberOfTeams { get; set; }
        public int NumberOfRounds { get; private set; }
        public IList<List<Match>> Rounds { get; private set; }
        public string Style { get; set; }
        public string TournamentKey { get; set; }
    }
}
