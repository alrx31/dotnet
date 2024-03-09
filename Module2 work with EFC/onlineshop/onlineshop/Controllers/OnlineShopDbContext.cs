using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using onlineshop.Models;
namespace onlineshop.Controllers;

public class OnlineShopDbContext: DbContext

{
    
    
    
    // create configuration
    private IConfiguration _configuration;
    public OnlineShopDbContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    
    
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(_configuration.GetConnectionString("DefaultConnection"));
    }
    
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // many to many relationship between Section and Category
        modelBuilder.Entity<SectionCategory>()
            .HasKey(sc => new {sc.SectionId, sc.CategoryId});
        
        // one to many relationship between Category and Product
        
        modelBuilder.Entity<Product>()
            .HasOne<Category>(p => p.Category)
            .WithMany(c => c.Products)
            .HasForeignKey(p => p.CategoryId);
        
        // one to many relationship between Brand and Product
        
        modelBuilder.Entity<Brand>()
            .HasMany<Product>(b => b.Products)
            .WithOne(p => p.Brand)
            .HasForeignKey(p => p.BrandId);
        
        // one to many relationship between Product and Media

        modelBuilder.Entity<Media>()
            .HasOne<Product>(m => m.Product)
            .WithMany(p => p.Medias)
            .HasForeignKey(m => m.ProductId);
        // one to many relationship between Review and Product
        modelBuilder.Entity<Review>()
            .HasOne<Product>(r => r.Product)
            .WithMany(p => p.Reviews)
            .HasForeignKey(r => r.ProductId);
        // one to many relationship between User and Review
        modelBuilder.Entity<Review>()
            .HasOne<User>(r => r.User)
            .WithMany(u => u.Reviews)
            .HasForeignKey(r => r.UserId);
    }
    
    
    public DbSet<Product> Products { get; set; }
    public DbSet<Brand> Brands { get; set; }
    public DbSet<Media> Medias { get; set; } 
    
    public DbSet<Category> Categories { get; set; }
    public DbSet<Section> Sections { get; set; }
    public DbSet<SectionCategory> SectionCategories { get; set; }
    
    public DbSet<Review> Reviews { get; set; }
    public DbSet<User> Users { get; set; }
    
}