using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Module4HW3.Entities;

namespace Module4HW3.EntitiyConfigurations
{
    public class TitleConfiguration : IEntityTypeConfiguration<Title>
    {
        public void Configure(EntityTypeBuilder<Title> builder)
        {
            builder.ToTable("Title").HasKey(t => t.TitleId);
            builder.Property(t => t.TitleId).HasColumnType("int").IsRequired().ValueGeneratedOnAdd();
            builder.Property(t => t.Name).HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
        }
    }
}
