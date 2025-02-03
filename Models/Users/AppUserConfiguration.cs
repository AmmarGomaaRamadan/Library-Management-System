using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library_Management_System.Models.Users
{
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.Property(u => u.qualifaction).IsRequired(false);
            builder.Property(u => u.personalImagePath).IsRequired(false);
        }
    }
}
