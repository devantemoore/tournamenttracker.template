using System;

namespace tournamenttracker.template.Domain.Entities
{
    public class Player : User
    {
        public Guid PlayerId { get; set; }
        public TeamRole teamRole { get; set; }
    }

    public enum TeamRole
    {
        player = 1,
        lead = 2,
    }
}