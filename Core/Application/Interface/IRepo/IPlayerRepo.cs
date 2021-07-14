using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tournamenttracker.template.Domain.Entities;

namespace tournamenttracker.template.Core.Application.Interface
{
    public interface IPlayerRepo
    {
        public Player Create(Player player);
        public Player GetPlayer(Guid id);
    }
}
