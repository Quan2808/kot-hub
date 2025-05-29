namespace Domain.Entities;

using Domain.Entities.Base;
using System.ComponentModel.DataAnnotations;

public class MatchStats : BaseEntity<int>
{
    [Required]
    public int MatchId { get; set; }

    [Required]
    public Match Match { get; set; } = default!;

    [Required]
    public int PlayerId { get; set; }

    [Required]
    public Player Player { get; set; } = default!;

    [Required]
    public int TeamId { get; set; }

    [Required]
    public Team Team { get; set; } = default!;

    [Range(0, int.MaxValue)]
    public int Goals { get; set; }

    [Range(0, int.MaxValue)]
    public int ShotsOnTarget { get; set; }

    [Range(0, int.MaxValue)]
    public int Assists { get; set; }

    [Range(0, int.MaxValue)]
    public int Passes { get; set; }

    [Range(0, int.MaxValue)]
    public int Dribbles { get; set; }

    [Range(0, int.MaxValue)]
    public int Tackles { get; set; }

    [Range(0, int.MaxValue)]
    public int Blocks { get; set; }
}