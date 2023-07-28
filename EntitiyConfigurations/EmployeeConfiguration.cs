using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Module4HW3.Entities;

namespace Module4HW3.EntitiyConfigurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employee").HasKey(e => e.EmployeeId);
            builder.Property(e => e.EmployeeId).HasColumnType("int").IsRequired().ValueGeneratedOnAdd();
            builder.Property(e => e.FirstName).HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            builder.Property(e => e.LastName).HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            builder.Property(e => e.HiredDate).HasColumnType("datetime2").IsRequired().HasMaxLength(7);
            builder.Property(e => e.DateOfBirth).HasColumnType("date").IsRequired(false);
            builder.Property(e => e.OfficeId).HasColumnType("int").IsRequired();
            builder.Property(e => e.TitleId).HasColumnType("int").IsRequired();
            builder.HasOne(e => e.Office)
                .WithMany(o => o.Employees)
                .HasForeignKey(o => o.OfficeId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(e => e.Title)
                .WithMany(t => t.Employees)
                .HasForeignKey(e => e.TitleId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
