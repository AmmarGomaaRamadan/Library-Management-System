using Microsoft.EntityFrameworkCore;

namespace Library_Management_System.Models.Books
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Book> builder)
        {
            //configure Table name and primary key
            builder.ToTable("Books");
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Id)
               .ValueGeneratedOnAdd();
            //configure properties
            builder.Property(a => a.Title).IsRequired().HasMaxLength(100);
            builder.Property(b => b.PublishYear).IsRequired();
            builder.Property(b => b.Edition).HasDefaultValue(1);
            //builder.Property(b => b.CategoryId).IsRequired(false);
            //configure the relationship with the author
            builder.HasOne(a => a.Category).
                WithMany(b => b.Books).
                HasForeignKey(b => b.CategoryId).OnDelete(DeleteBehavior.NoAction);
            //configure the relationship with the author
            builder.HasOne(a=>a.Author).
                WithMany(b => b.Books).
                HasForeignKey(b => b.AuthorId).OnDelete(DeleteBehavior.Cascade);
            //configure the relationship with the Book images
            builder.HasMany(bi => bi.BookImages)
                .WithOne(b => b.Book).HasForeignKey(bi => bi.BookId);

        }
    }
}
