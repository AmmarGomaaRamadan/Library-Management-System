using Library_Management_System.GenericReposatory.Books;
using Library_Management_System.Reposatories.GenericReposatory;
using Library_Management_System.Services.Books;
using Microsoft.AspNetCore.Identity;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add controllers with views
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
// Add services to the container.
builder.Services.AddScoped(typeof(IReposatory<>), typeof(Reposatory<>));
builder.Services.AddScoped<IBookReposatory, BookReposatory>();
builder.Services.AddScoped<IBookService, BookServices>(); 

//Add Db connection string
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")).UseLazyLoadingProxies());
// Configure Identity
builder.Services.AddIdentity<AppUser, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();
//builder.Services.AddScoped<IBookService, BookServices>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.MapRazorPages();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
