using System;
using System.Collections.Generic;
using tournamenttracker.template.Domain.Entities;

namespace tournamenttracker.template.Infrastructure.Persistance.Mock
{
    public static class MockRepo
    {
        public static ICollection<Player> Players = new List<Player>
        {
            new Player
            {
                PlayerId = Guid.Parse("687094d3-87ec-4b93-8e95-0f4463e63e4c"),
                Username = "DullerLobster",
                FirstName = "Tim",
                LastName = "Duncan",
            },

            new Player
            {
                Username = "NauticalSalmon",
                FirstName = "James",
                LastName = "Harden",
            }
            ,

            new Player
            {
                Username = "RidgySea",
                FirstName = "Larry",
                LastName = "Bird",
            }
            ,

            new Player
            {
                Username = "QuantLord",
                FirstName = "Sam",
                LastName = "Darnold",
            }
            ,

            new Player
            {
                Username = "RoaringKitty",
                FirstName = "Demar",
                LastName = "DeRozan",
            }
            ,

            new Player
            {
                Username = "OptionAddict",
                FirstName = "Mo",
                LastName = "Bamba",
            }
        };
    }
}