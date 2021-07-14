using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tournamenttracker.template.Core.Application.Model;
using tournamenttracker.template.Domain.Entities;

namespace tournamenttracker.template.Core.Application.Interface.IServices
{
    public interface IPlayerService
    {
        public void ApproveRequest(AppRequest<Player, Team> request);
    }
}
