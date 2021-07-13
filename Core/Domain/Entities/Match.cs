namespace tournamenttracker.template.Domain.Entities
{
    public class Match : Auditable
    {
        public long Id { get; set; }
        public Team TeamA { get; set; }
        public Team TeamB { get; set; }
    }
}