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
            var createdPlayer = new Player
            {
                Username = player.Username,
                FirstName = player.FirstName,
                LastName = player.LastName,
            };
            MockRepo.Players.Add(createdPlayer);
            return createdPlayer;
        }

        public Player GetPlayer(Guid id)
        {
            return MockRepo.Players.First(p => p.PlayerId == id);
        }

        public ICollection<Player> GetPlayers()
        {
            return MockRepo.Players.ToList();
        }
    }
}
