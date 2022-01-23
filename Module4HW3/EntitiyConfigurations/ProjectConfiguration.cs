using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Module4HW3.Entities;

namespace Module4HW3.EntitiyConfigurations
{
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.ToTable("Project").HasKey(p => p.ProjectId);
            builder.Property(p => p.ProjectId).IsRequired().ValueGeneratedOnAdd();
            builder.Property(p => p.Name).HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            builder.Property(p => p.Budget).HasColumnType("money").IsRequired();
            builder.Property(p => p.StartedDate).HasColumnType("datetime2").IsRequired().HasMaxLength(7);
            builder.HasOne(p => p.Client)
                .WithMany(c => c.Projects)
                .HasForeignKey(p => p.ClientId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasData(new List<Project>()
            {
                new Project() { ProjectId = 1, Budget = 1000, Name = "Tesla", ClientId = 1, StartedDate = DateTime.Now },
                new Project() { ProjectId = 2, Budget = 2000, Name = "Facebook", ClientId = 2, StartedDate = DateTime.Now },
                new Project() { ProjectId = 3, Budget = 3000, Name = "Linux", ClientId = 3, StartedDate = DateTime.Now },
                new Project() { ProjectId = 4, Budget = 4000, Name = "Windows XP", ClientId = 4, StartedDate = DateTime.Now },
                new Project() { ProjectId = 5, Budget = 5000, Name = "Blue Origin", ClientId = 5, StartedDate = DateTime.Now }
            });
        }
    }
}
