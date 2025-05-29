namespace Domain.Entities;

using Domain.Entities.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Player : BaseEntity<int>
{
    [Required]
    [MaxLength(50)]
    public string Username { get; set; } = string.Empty;

    [Required]
    [MaxLength(100)]
    public string DisplayName { get; set; } = string.Empty;

    [Range(0, 100)]
    public int SkillLevel { get; set; }

    public bool IsActive { get; set; }

    public ICollection<PlayerTeam> PlayerTeams { get; set; } = new List<PlayerTeam>();
}