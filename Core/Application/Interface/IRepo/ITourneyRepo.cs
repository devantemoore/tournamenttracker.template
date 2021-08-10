using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tournamenttracker.template.Domain.Entities;

namespace tournamenttracker.template.Core.Application.Interface
{
    public interface ITourneyRepo
    {
        public ICollection<Tournament> GetAll();
        public Tournament GetTournament(long id);
        public Tournament Create(Tournament tournament);
    }
}
