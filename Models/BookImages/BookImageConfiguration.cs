using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library_Management_System.Models.BookImages
{
    public class BookImageConfiguration : IEntityTypeConfiguration<BookImage>
    {
        public void Configure(EntityTypeBuilder<BookImage> builder)
        {
            //table name and primary key configuratin
            builder.ToTable("BookImages");
            builder.HasKey(bi=>bi.Id);
            builder.Property(bi => bi.Id)
               .ValueGeneratedOnAdd();
            //configure properties
            builder.Property(bi=>bi.Path).IsRequired().HasMaxLength(300);

        }
    }
}
