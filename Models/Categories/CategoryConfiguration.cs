using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library_Management_System.Models.Categories
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            //table name and primary key configuratin
            builder.ToTable("Categories");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id)
               .ValueGeneratedOnAdd();
            //configure properties
            builder.Property(c=>c.Name).IsRequired().HasMaxLength(150);
            builder.Property(c => c.Description).HasMaxLength(500).HasDefaultValue(null);
            

        }
    }
}
