namespace Domain.Entities;


public class Match
{
    public int Id { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime? EndTime { get; set; }
    public MatchStatus Status { get; set; }

    public int TeamAId { get; set; }
    public int TeamBId { get; set; }
    public int? WinningTeamId { get; set; }

    public int ScoreTeamA { get; set; }
    public int ScoreTeamB { get; set; }

    public Team TeamA { get; set; } = default!;
    public Team TeamB { get; set; } = default!;
    public Team? WinningTeam { get; set; }

    public ICollection<MatchEvent> Events { get; set; } = [];
    public ICollection<MatchStats> Stats { get; set; } = [];
}

public enum MatchStatus
{
    Scheduled,
    Ongoing,
    Completed,
    Cancelled
}