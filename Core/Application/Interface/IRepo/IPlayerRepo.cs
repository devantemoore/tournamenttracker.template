using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tournamenttracker.template.Domain.Entities;

namespace tournamenttracker.template.Core.Application.Interface
{
    public interface IPlayerRepo
    {
        public User Create(Player player);
        public User GetPlayer(long id);
    }
}
