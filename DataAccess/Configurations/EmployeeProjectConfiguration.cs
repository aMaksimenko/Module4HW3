using System;
using HomeWork.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HomeWork.DataAccess.Configurations
{
    public class EmployeeProjectConfiguration : IEntityTypeConfiguration<EmployeeProject>
    {
        public void Configure(EntityTypeBuilder<EmployeeProject> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Rate).HasColumnType("money").IsRequired();
            builder.Property(p => p.StartedDate).HasColumnType("datetime2").HasMaxLength(7).IsRequired();

            builder.HasOne(p => p.Project)
                .WithMany(p => p.EmployeeProjects)
                .HasForeignKey(p => p.ProjectId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(p => p.Employee)
                .WithMany(p => p.EmployeeProjects)
                .HasForeignKey(p => p.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasData(
                new EmployeeProject()
                {
                    Id = 1,
                    Rate = 1000,
                    StartedDate = new DateTime(1990, 1, 1),
                    EmployeeId = 1,
                    ProjectId = 1
                },
                new EmployeeProject()
                {
                    Id = 2,
                    Rate = 3000,
                    StartedDate = new DateTime(1995, 1, 1),
                    EmployeeId = 1,
                    ProjectId = 2
                },
                new EmployeeProject()
                {
                    Id = 3,
                    Rate = 55555,
                    StartedDate = new DateTime(2005, 1, 1),
                    EmployeeId = 3,
                    ProjectId = 3
                },
                new EmployeeProject()
                {
                    Id = 4,
                    Rate = 55555,
                    StartedDate = new DateTime(2005, 1, 1),
                    EmployeeId = 1,
                    ProjectId = 4
                },
                new EmployeeProject()
                {
                    Id = 5,
                    Rate = 55555,
                    StartedDate = new DateTime(2005, 1, 1),
                    EmployeeId = 4,
                    ProjectId = 5
                });
        }
    }
}