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
        }
    }
}