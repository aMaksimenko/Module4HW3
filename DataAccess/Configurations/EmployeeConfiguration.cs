using System;
using HomeWork.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HomeWork.DataAccess.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.FirstName).HasMaxLength(50).IsRequired();
            builder.Property(p => p.LastName).HasMaxLength(50).IsRequired();
            builder.Property(p => p.HiredDate).HasColumnType("datetime2").HasMaxLength(7).IsRequired();
            builder.Property(p => p.DateOfBirth).HasColumnType("date");

            builder.HasOne(p => p.Title)
                .WithMany(p => p.Employees)
                .HasForeignKey(p => p.TitleId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(p => p.Office)
                .WithMany(p => p.Employees)
                .HasForeignKey(p => p.OfficeId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasData(
                new Employee()
                {
                    Id = 1, FirstName = "Bob", LastName = "Marley", DateOfBirth = new DateTime(1990, 1, 1),
                    HiredDate = new DateTime(2020, 1, 1),
                    OfficeId = 1,
                    TitleId = 1
                },
                new Employee()
                {
                    Id = 2, FirstName = "Bob", LastName = "Marley", DateOfBirth = new DateTime(1995, 1, 1),
                    HiredDate = new DateTime(2020, 1, 1),
                    OfficeId = 2,
                    TitleId = 1
                },
                new Employee()
                {
                    Id = 3, FirstName = "James", LastName = "Ollof", DateOfBirth = new DateTime(1960, 1, 1),
                    HiredDate = new DateTime(2020, 1, 1),
                    OfficeId = 1,
                    TitleId = 3
                },
                new Employee()
                {
                    Id = 4, FirstName = "Arthur", LastName = "Martin", DateOfBirth = new DateTime(1994, 1, 1),
                    HiredDate = new DateTime(2020, 1, 1),
                    OfficeId = 2,
                    TitleId = 3
                },
                new Employee()
                {
                    Id = 5, FirstName = "Bill", LastName = "Gates", DateOfBirth = new DateTime(1998, 1, 1),
                    HiredDate = new DateTime(2020, 1, 1),
                    OfficeId = 3,
                    TitleId = 2
                });
        }
    }
}