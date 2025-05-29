namespace Domain.Entities;

using Domain.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations;

public class PlayerTeam : BaseEntity<int>
{
    [Required]
    public int PlayerId { get; set; }

    [Required]
    public Player Player { get; set; } = default!;

    [Required]
    public int TeamId { get; set; }

    [Required]
    public Team Team { get; set; } = default!;

    public bool IsCaptain { get; set; }

    [Required]
    public DateTime JoinedAt { get; set; }
}