namespace Domain.Entities;

public class PlayerTeam
{
    public int Id { get; set; }

    public int PlayerId { get; set; }
    public Player Player { get; set; } = default!;

    public int TeamId { get; set; }
    public Team Team { get; set; } = default!;

    public bool IsCaptain { get; set; }
    public DateTime JoinedAt { get; set; }
}
