using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tournamenttracker.template.Domain.Entities;

namespace tournamenttracker.template.Core.Application.Interface.IData
{
    public interface IApplicationDbContext
    {
        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Tournament> Tournaments { get; set;}
        public DbSet<Match> Matches { get; set; }
    }
}
