using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tournamenttracker.template.Core.Application.Model;
using tournamenttracker.template.Domain.Entities;

namespace tournamenttracker.template.Core.Application.Interface
{
    public interface IRequesterService
    {
        public void RequestToJoinTeam(AppRequest<Player, Team> request);
        public void RequestToJoinTourney(AppRequest<Team, Tournament> request);
    }
}
