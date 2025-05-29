namespace Domain.Entities;

using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Match : BaseEntity<int>
{
    [Required]
    public DateTime StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public MatchStatus Status { get; set; }

    [Required]
    public int TeamAId { get; set; }

    [Required]
    public int TeamBId { get; set; }

    public int? WinningTeamId { get; set; }

    [Range(0, int.MaxValue)]
    public int ScoreTeamA { get; set; }

    [Range(0, int.MaxValue)]
    public int ScoreTeamB { get; set; }

    [Required]
    public Team TeamA { get; set; } = default!;

    [Required]
    public Team TeamB { get; set; } = default!;

    public Team? WinningTeam { get; set; }

    public ICollection<MatchStats> Stats { get; set; } = new List<MatchStats>();
}

public enum MatchStatus
{
    Scheduled,
    Ongoing,
    Completed,
    Cancelled
}