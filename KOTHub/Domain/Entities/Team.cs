namespace Domain.Entities;

public class Team
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string LogoUrl { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }

    public ICollection<PlayerTeam> PlayerTeams { get; set; } = [];
}