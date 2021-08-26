using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tournamenttracker.template.Domain.Entities;
using tournamenttracker.template.Infrastructure.Persistance.Mock;

namespace tournamenttracker.template.Infrastructure.Persistance
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            AddPlayers(modelBuilder);
            // AddTeams(modelBuilder);
            // AddTournaments(modelBuilder);
        }

        private static void AddPlayers(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>().HasData(MockRepo.Players);
        }
        private static void AddTeams(ModelBuilder modelBuilder)
        {
            throw new NotImplementedException();
        }
        private static void AddTournaments(ModelBuilder modelBuilder)
        {
            throw new NotImplementedException();
        }

        

        
    }
}
