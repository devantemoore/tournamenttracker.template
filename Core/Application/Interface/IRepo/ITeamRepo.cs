using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tournamenttracker.template.Domain.Entities;

namespace tournamenttracker.template.Core.Application.Interface
{
    public interface ITeamRepo
    {
        public Team GetTeam(long id);
        public Team Create(Team team);
    }
}
