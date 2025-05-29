using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations;

public class MatchStatsConfiguration : IEntityTypeConfiguration<MatchStats>
{
    public void Configure(EntityTypeBuilder<MatchStats> builder)
    {
        builder.HasOne(s => s.Match)
            .WithMany(m => m.Stats)
            .HasForeignKey(s => s.MatchId);

        builder.HasOne(s => s.Team)
            .WithMany()
            .HasForeignKey(s => s.TeamId);
    }
}