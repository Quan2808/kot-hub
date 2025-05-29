namespace Domain.Entities;

public class Player
{
    public int Id { get; set; }
    public string Username { get; set; } = string.Empty;
    public string DisplayName { get; set; } = string.Empty;
    public PlayerPosition Position { get; set; }
    public int SkillLevel { get; set; }
    public bool IsActive { get; set; }

    public ICollection<PlayerTeam> PlayerTeams { get; set; } = [];
}

public enum PlayerPosition
{
    GK,
    DEF,
    MID,
    FWD
}