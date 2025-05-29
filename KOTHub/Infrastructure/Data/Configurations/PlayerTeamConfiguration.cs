using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations;

public class PlayerTeamConfiguration : IEntityTypeConfiguration<PlayerTeam>
{
    public void Configure(EntityTypeBuilder<PlayerTeam> builder)
    {
        builder.HasKey(pt => pt.Id);

        builder.HasOne(pt => pt.Player)
            .WithMany(p => p.PlayerTeams)
            .HasForeignKey(pt => pt.PlayerId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(pt => pt.Team)
            .WithMany(t => t.PlayerTeams)
            .HasForeignKey(pt => pt.TeamId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}