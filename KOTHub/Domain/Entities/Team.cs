namespace Domain.Entities;

using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Team : BaseEntity<int>
{
    [Required]
    [MaxLength(100)]
    public string Name { get; set; } = string.Empty;

    [MaxLength(500)]
    public string? LogoUrl { get; set; }

    public ICollection<PlayerTeam> PlayerTeams { get; set; } = new List<PlayerTeam>();
}