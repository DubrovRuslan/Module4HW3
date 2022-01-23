using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Module4HW3.Entities;

namespace Module4HW3.EntitiyConfigurations
{
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.ToTable("Client").HasKey(t => t.ClientId);
            builder.Property(c => c.ClientId).IsRequired().ValueGeneratedOnAdd();
            builder.Property(c => c.FirstName).IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            builder.Property(c => c.LastName).IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            builder.Property(c => c.Email).IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
            builder.HasData(new List<Client>()
            {
                new Client() { ClientId = 1, FirstName = "Elon", LastName = "Musk", Email = "boss@tesla.com" },
                new Client() { ClientId = 1, FirstName = "Mark", LastName = "Zuckerberg", Email = "boss@facebook.com" },
                new Client() { ClientId = 1, FirstName = "Linus", LastName = "Torvalds", Email = "boss@linux.com" },
                new Client() { ClientId = 1, FirstName = "Bill", LastName = "Gates", Email = "boss@microsoft.com" },
                new Client() { ClientId = 1, FirstName = "Jeffrey", LastName = "Bezos", Email = "boss@amazon.com" }
            });
        }
    }
}
