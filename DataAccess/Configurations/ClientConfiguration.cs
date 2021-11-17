using HomeWork.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HomeWork.DataAccess.Configurations
{
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Title).HasMaxLength(100).IsRequired();
            builder.Property(p => p.Email).HasMaxLength(100).IsRequired();
            builder.Property(p => p.PhoneNumber).HasMaxLength(20).IsRequired();
            builder.Property(p => p.CountryFrom).HasMaxLength(50).IsRequired();

            builder.HasData(
                new Client() { Id = 1, Email = "firstBox@gmail.com", Title = "Microsoft", CountryFrom = "USA", PhoneNumber = 111111 },
                new Client() { Id = 2, Email = "secondBox@gmail.com", Title = "Google", CountryFrom = "Germany", PhoneNumber = 222222 },
                new Client() { Id = 3, Email = "third@gmail.com", Title = "Apple", CountryFrom = "Denmark", PhoneNumber = 333333 },
                new Client() { Id = 4, Email = "fourthBox@gmail.com", Title = "Tesla", CountryFrom = "Ukraine", PhoneNumber = 444444 },
                new Client() { Id = 5, Email = "fifthBox@gmail.com", Title = "Amazon", CountryFrom = "Turkey", PhoneNumber = 555555 });
        }
    }
}