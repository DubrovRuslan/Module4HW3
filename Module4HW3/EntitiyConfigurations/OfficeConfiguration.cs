using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Module4HW3.Entities;

namespace Module4HW3.EntitiyConfigurations
{
    public class OfficeConfiguration : IEntityTypeConfiguration<Office>
    {
        public void Configure(EntityTypeBuilder<Office> builder)
        {
            builder.ToTable("Office").HasKey(o => o.OfficeId);
            builder.Property(o => o.OfficeId).HasColumnType("int").IsRequired().ValueGeneratedOnAdd();
            builder.Property(o => o.Title).HasColumnType("nvarchar").IsRequired().HasMaxLength(100);
            builder.Property(o => o.Location).HasColumnType("nvarchar").IsRequired().HasMaxLength(100);
        }
    }
}
