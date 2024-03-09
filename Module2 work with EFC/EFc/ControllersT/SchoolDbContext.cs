using EFc.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EFc.ControllersT;


public class SchoolDbContext : DbContext
{
    public DbSet<Student> Students { get; set; }
    public DbSet<Grade> Grades { get; set; }
    
    public DbSet<StudentAddress> StudentAddresses { get; set; }
    public DbSet<StudentCourse> StudentCourses { get; set; }
    public DbSet<Course> Courses { get; set; }
    

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Database=School;Username=alex;Password=123456");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // one to many
        modelBuilder.Entity<Grade>()
            .HasMany<Student>(g => g.Students)
            .WithOne(s => s.Grade)
            .HasForeignKey(s => s.GradeId)
            .OnDelete(DeleteBehavior.SetNull);
        // one to one
        modelBuilder.Entity<Student>()
            .HasOne<StudentAddress>( s => s.Address)
            .WithOne(a => a.Student)
            .HasForeignKey<StudentAddress>(ad => ad.StudentId);
        // one to one
        modelBuilder.Entity<StudentAddress>()
            .HasOne<Student>(ad => ad.Student)
            .WithOne(s => s.Address)
            .HasForeignKey<Student>(s => s.StudentAddressId);

        modelBuilder.Entity<StudentCourse>()
            .HasKey(sc => new { sc.StudentId, sc.CourseId });
    }
}

