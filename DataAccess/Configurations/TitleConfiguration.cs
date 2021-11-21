using HomeWork.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HomeWork.DataAccess.Configurations
{
    public class TitleConfiguration : IEntityTypeConfiguration<Title>
    {
        public void Configure(EntityTypeBuilder<Title> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name).HasMaxLength(50).IsRequired();

            builder.HasData(
                new Title()
                {
                    Id = 1,
                    Name = "Developer"
                },
                new Title()
                {
                    Id = 2,
                    Name = "Manager"
                },
                new Title()
                {
                    Id = 3,
                    Name = "QA"
                });
        }
    }
}