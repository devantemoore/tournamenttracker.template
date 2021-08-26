using System;

namespace tournamenttracker.template.Domain.Entities
{
    public class Match : Auditable
    {
        public long Id { get; set; }
        public Team Home { get; set; }
        public Team Away { get; set; }
        public DateTime DateOfMatch { get; set; }
        public HomeOrAway Winner { get; set; }

        public Match(Team home, Team away, DateTime dateOfMatch)
        {
            Home = home;
            Away = away;
            DateOfMatch = dateOfMatch;
            Winner = HomeOrAway.TBD;
        }
    }

    public enum HomeOrAway
    {
        Home,
        Away,
        TBD
    }
}