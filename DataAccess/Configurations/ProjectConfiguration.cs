using System;
using HomeWork.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HomeWork.DataAccess.Configurations
{
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name).HasMaxLength(50).IsRequired();
            builder.Property(p => p.Budget).HasColumnType("money").IsRequired();
            builder.Property(p => p.StartedDate).HasColumnType("datetime2").HasMaxLength(7).IsRequired();

            builder.HasOne(p => p.Client)
                .WithMany(p => p.Projects)
                .HasForeignKey(p => p.ClientId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasData(
                new Project() { Id = 1, Name = "First project", Budget = 1000, StartedDate = DateTime.Now.AddDays(-7), ClientId = 1 },
                new Project() { Id = 2, Name = "Second project", Budget = 1000, StartedDate = DateTime.Now.AddDays(-570), ClientId = 2 },
                new Project() { Id = 3, Name = "Third project", Budget = 1000, StartedDate = DateTime.Now.AddDays(-100), ClientId = 3 },
                new Project() { Id = 4, Name = "Fourth project", Budget = 1000, StartedDate = DateTime.Now.AddDays(-50), ClientId = 4 },
                new Project() { Id = 5, Name = "Fifth project", Budget = 1000, StartedDate = DateTime.Now.AddDays(-180), ClientId = 5 });
        }
    }
}