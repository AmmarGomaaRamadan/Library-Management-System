using Library_Management_System.Models.UserBooks;
using Library_Management_System.Models.UserPreferedBooks;
using Library_Management_System.Seeders;

namespace Library_Management_System.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(CategorySeeder.categories);
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new AuthorConfiguration());
            modelBuilder.ApplyConfiguration(new BookConfiguration());
            modelBuilder.ApplyConfiguration(new BookImageConfiguration());
            // modelBuilder.ApplyConfiguration(new AppUserConfiguration());
            modelBuilder.ApplyConfiguration(new UserBookConfiguration());
            modelBuilder.ApplyConfiguration(new UserPreferedBookConfiguration());
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookImage> BookImages { get; set; }
        public DbSet<UserBook> UserBooks { get; set; }
        public DbSet<UserPreferedBook> UserPreferedBooks { get; set; }  
        

        
    }
}
