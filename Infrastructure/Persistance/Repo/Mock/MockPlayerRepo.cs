using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tournamenttracker.template.Core.Application.Interface;
using tournamenttracker.template.Domain.Entities;

namespace tournamenttracker.template.Infrastructure.Persistance.Mock
{
    public class MockPlayerRepo : IPlayerRepo
    {

        public Player Create(Player player)
        {
            throw new NotImplementedException();
        }

        public Player GetPlayer(Guid id)
        {
            return MockRepo.Players.First(p => p.PlayerId == id);
        }
    }
}
