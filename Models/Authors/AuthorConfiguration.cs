using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library_Management_System.Models.Authors
{
    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            //configur table name
            builder.ToTable("Authors");
            //  configure primary key
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id)
               .ValueGeneratedOnAdd();
            //configure properties
            builder.Property(a => a.Name).IsRequired().HasMaxLength(100);
            builder.Property(a=>a.Nationality).HasMaxLength(100);
            builder.Property(a=>a.personalImage).IsRequired(false).HasMaxLength(200);
            //configure the one to many relationship for the two edges
            builder.HasMany(a=>a.Books).
                WithOne(b=>b.Author).
                HasForeignKey(b=>b.AuthorId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
