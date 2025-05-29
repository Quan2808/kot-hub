namespace Domain.Entities;

public class MatchEvent
{
    public int Id { get; set; }

    public int MatchId { get; set; }
    public Match Match { get; set; } = default!;

    public int? PlayerId { get; set; }
    public Player? Player { get; set; }

    public int TeamId { get; set; }
    public Team Team { get; set; } = default!;

    public MatchEventType EventType { get; set; }
    public TimeSpan EventTime { get; set; }
}

public enum MatchEventType
{
    Goal,
    Assist,
    YellowCard,
    RedCard,
    OwnGoal,
    Substitution
}
