using HomeWork.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HomeWork.DataAccess.Configurations
{
    public class OfficeConfiguration : IEntityTypeConfiguration<Office>
    {
        public void Configure(EntityTypeBuilder<Office> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Title).HasMaxLength(100).IsRequired();
            builder.Property(p => p.Location).HasMaxLength(100).IsRequired();

            builder.HasData(
                new Office()
                {
                    Id = 1,
                    Title = "Office #1",
                    Location = "Alekseevka"
                },
                new Office()
                {
                    Id = 2,
                    Title = "Office #3",
                    Location = "Saltovka"
                },
                new Office()
                {
                    Id = 3,
                    Title = "Office #5",
                    Location = "Bot Sad"
                });
        }
    }
}