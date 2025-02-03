using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library_Management_System.Models.UserPreferedBooks
{
    public class UserPreferedBookConfiguration : IEntityTypeConfiguration<UserPreferedBook>
    {
        public void Configure(EntityTypeBuilder<UserPreferedBook> builder)
        {
            builder.ToTable("UserPereferedBooks");
            builder.HasKey(ub => new { ub.userId, ub.BookId });

            builder.Property(ub=>ub.PreferDate).IsRequired();

            builder.HasOne(a => a.book).
              WithMany(b => b.UserPreferedBooks).
              HasForeignKey(b => b.BookId).OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(a => a.user).
             WithMany(b => b.UserPreferedBooks).
             HasForeignKey(b => b.userId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
