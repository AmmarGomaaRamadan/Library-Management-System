using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library_Management_System.Models.UserBooks
{
    public class UserBookConfiguration : IEntityTypeConfiguration<UserBook>
    {
        public void Configure(EntityTypeBuilder<UserBook> builder)
        {
            builder.ToTable("UserBooks");
            builder.HasKey(ub => new { ub.UserId, ub.BookId });

            builder.Property(ub=>ub.startRead).IsRequired();
            builder.Property(ub=>ub.pageNum).HasDefaultValue(1);
            builder.Property(ub => ub.status).HasDefaultValue("Start Reading");

            builder.HasOne(a => a.book).
               WithMany(b => b.UserBooks).
               HasForeignKey(b => b.BookId).OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(a => a.user).
              WithMany(b => b.UserBooks).
              HasForeignKey(b => b.UserId).OnDelete(DeleteBehavior.NoAction);

        }
    }
}
