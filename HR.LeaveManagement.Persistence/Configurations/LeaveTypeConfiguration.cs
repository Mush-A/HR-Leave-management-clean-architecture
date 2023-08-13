using HR.LeaveManagement.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HR.LeaveManagement.Persistence.Configurations;

public class LeaveTypeConfiguration : IEntityTypeConfiguration<LeaveType>
{
    public void Configure(EntityTypeBuilder<LeaveType> builder)
    {
        builder.HasData(
            new LeaveType
            {
                Id = 1,
                Name = "Vacations",
                DefaultDays = 7,
                DateCreated = DateTime.Now,
                DateModified = DateTime.Now,
            }
        );

        // DB level restriction - Different than what we did with fluent validation, which is stopping it before it goes to the DB
        builder.Property(q => q.Name)
            .IsRequired()
            .HasMaxLength(100);
    }
}
