using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Module4HW3.Entities;

namespace Module4HW3.EntitiyConfigurations
{
    public class EmployeeProjectConfiguration : IEntityTypeConfiguration<EmployeeProject>
    {
        public void Configure(EntityTypeBuilder<EmployeeProject> builder)
        {
            builder.ToTable("EmployeeProject").HasKey(e => e.EmployeeProjectId);
            builder.Property(e => e.EmployeeProjectId).HasColumnType("int").IsRequired().ValueGeneratedOnAdd();
            builder.Property(e => e.Rate).HasColumnType("money").IsRequired();
            builder.Property(e => e.StartDate).HasColumnType("datetime2").IsRequired().HasMaxLength(7);
            builder.Property(e => e.EmployeeId).HasColumnType("int").IsRequired();
            builder.Property(e => e.ProjectId).HasColumnType("int").IsRequired();
        }
    }
}
