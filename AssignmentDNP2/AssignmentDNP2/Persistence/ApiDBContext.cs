using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Models;


namespace AssignmentDNP2.Persistence

{
    public class ApiDbContext : DbContext
    {
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Adult> Adults { get; set; }
        
        
        public ApiDbContext(DbContextOptions<ApiDbContext> options)
            : base(options)
        {
            
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Adult>(entity =>
            {
                entity.ToTable("adult");

                entity.Property(e => e.Id);

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.EyeColor);

                entity.Property(e => e.FirstName);

                entity.Property(e => e.HairColor);

                entity.Property(e => e.Height).HasColumnName("height");

                entity.Property(e => e.JobTitle);

                entity.Property(e => e.LastName);

                entity.Property(e => e.Sex);

                entity.Property(e => e.Weight).HasColumnName("weight");
            });
            modelBuilder.Entity<User>(entity =>
            {
                
                entity.Property(e => e.Password);

                entity.Property(e => e.Role);
                

                entity.Property(e => e.SecurityLevel).HasColumnName("securityLevel");

                entity.Property(e => e.UserName);
            });
        }
    }
}