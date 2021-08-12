using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tournamenttracker.template.Core.Application.Interface;
using tournamenttracker.template.Core.Application.Model;
using tournamenttracker.template.Domain.Entities;

namespace tournamenttracker.template.Infrastructure.Services
{
    public class RequesterService : IRequesterService
    {
        public void RequestToJoinTeam(AppRequest<Player, Team> request)
        {
            throw new NotImplementedException();
        }

        public void RequestToJoinTourney(AppRequest<Team, Tournament> request)
        {
            throw new NotImplementedException();
        }
    }
}
