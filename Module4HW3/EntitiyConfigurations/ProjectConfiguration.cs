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
            builder.Property(p => p.ProjectId).HasColumnType("int").IsRequired().ValueGeneratedOnAdd();
            builder.Property(p => p.Name).HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            builder.Property(p => p.Budget).HasColumnType("money").IsRequired();
            builder.Property(p => p.StartedDate).HasColumnType("datetime2").IsRequired().HasMaxLength(7);
        }
    }
}
