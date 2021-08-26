using System;

namespace tournamenttracker.template.Domain.Entities
{
    public class Player 
    {
        public Guid PlayerId { get; set; }
        public TeamRole teamRole { get; private set; }
        public string Name { get; set; }
        public string Number { get; set; }

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
        player,
        lead,
    }
}