using System;

namespace tournamenttracker.template.Domain.Entities
{
    public class Player : User
    {
        public Guid PlayerId { get; set; }
        public TeamRole teamRole { get; private set; }

        public Player()
        {
            PlayerId = Guid.NewGuid();
            teamRole = TeamRole.player;
        }

        public void PromotePlayerToTeamLead()
        {
            this.teamRole = TeamRole.lead;
        }
    }

    public enum TeamRole
    {
        player = 1,
        lead = 2,
    }
}