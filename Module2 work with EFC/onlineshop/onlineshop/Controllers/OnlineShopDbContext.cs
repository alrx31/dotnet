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
        
        // one to one relationship between ProductVariant and CardItem
        
        modelBuilder.Entity<CardItem>()
            .HasOne<ProductVariant>(ci => ci.ProductVariant)
            .WithOne(pv => pv.CardItem)
            .HasForeignKey<ProductVariant>(pv => pv.ProductId);
        
        // one to many relationship between Product and ProductVariant
        
        modelBuilder.Entity<ProductVariant>()
            .HasOne<Product>(pv => pv.Product)
            .WithMany(p => p.ProductVariants)
            .HasForeignKey(pv => pv.ProductId);
        
        // one to many relationship between Size and ProductVariant
        
        modelBuilder.Entity<ProductVariant>()
            .HasOne<Size>(pv => pv.Size)
            .WithMany(s => s.ProductVariants)
            .HasForeignKey(pv => pv.SizeId);
        
        // one to many relationship between Color and ProductVariant
        
        modelBuilder.Entity<ProductVariant>()
            .HasOne<Color>(pv => pv.Color)
            .WithMany(c => c.ProductVariants)
            .HasForeignKey(pv => pv.ColorId);
        
        // one to many relationship between CardItem and User

        modelBuilder.Entity<CardItem>()
            .HasOne<User>(ci => ci.User)
            .WithMany(u => u.CardItems)
            .HasForeignKey(ci => ci.UserId);
        
        // one to many relationship between Address and User
        
        modelBuilder.Entity<Address>()
            .HasOne<User>(a => a.User)
            .WithMany(u => u.Addresses)
            .HasForeignKey(a => a.UserId);
        
        // one to many relationship between Order and User
        
        modelBuilder.Entity<Order>()
            .HasOne<User>(o => o.User)
            .WithMany(u => u.Orders)
            .HasForeignKey(o => o.UserId);
        
        // one to many relationship between Order and Address
        
        modelBuilder.Entity<Order>()
            .HasOne<Address>(o => o.Address)
            .WithMany(a => a.Orders)
            .HasForeignKey(o => o.AddressId);
        
        //  one to one relationship between Order and OrderTransaction
        
        modelBuilder.Entity<OrderTransaction>()
            .HasOne<Order>(ot => ot.Order)
            .WithOne(o => o.OrderTransaction)
            .HasForeignKey<Order>(o => o.OrderId);
        
        // one to many relationship between OrderItem and Order

        modelBuilder.Entity<OrderItem>()
            .HasOne<Order>(oi => oi.Order)
            .WithMany(o => o.OrderItems)
            .HasForeignKey(oi => oi.OrderId);
        
        // one to one relationship between OrderItem and ProductVariant
        
        modelBuilder.Entity<OrderItem>()
            .HasOne<ProductVariant>(oi => oi.ProductVariant)
            .WithOne(pv => pv.OrderItem)
            .HasForeignKey<OrderItem>(oi => oi.ProductVariantId);
    }
    
    
    public DbSet<Product> Products { get; set; }
    public DbSet<Brand> Brands { get; set; }
    public DbSet<Media> Medias { get; set; } 
    
    public DbSet<Category> Categories { get; set; }
    public DbSet<Section> Sections { get; set; }
    public DbSet<SectionCategory> SectionCategories { get; set; }
    
    public DbSet<Review> Reviews { get; set; }
    public DbSet<User> Users { get; set; }
    
    public DbSet<ProductVariant> ProductVariants { get; set; }
    public DbSet<Size> Sizes { get; set; }
    public DbSet<Color> Colors { get; set; }
    
    public DbSet<CardItem> CardItems { get; set; }
    
    public DbSet<Address> Addresses { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderTransaction> OrderTransactions { get; set; } 
    
    public DbSet<OrderItem> OrderItems { get; set; }
}