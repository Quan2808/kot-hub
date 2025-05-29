namespace Domain.Entities;

public class MatchStats
{
    public int Id { get; set; }

    public int MatchId { get; set; }
    public Match Match { get; set; } = default!;

    public int TeamId { get; set; }
    public Team Team { get; set; } = default!;

    public int Shots { get; set; }
    public int ShotsOnTarget { get; set; }
    public double Possession { get; set; }
    public int Passes { get; set; }
    public int Fouls { get; set; }
    public int Corners { get; set; }
}
