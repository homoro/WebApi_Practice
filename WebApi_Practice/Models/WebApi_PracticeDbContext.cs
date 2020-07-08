using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApi_Practice.Models
{
    public partial class WebApi_PracticeDbContext : DbContext
    {
         
        public WebApi_PracticeDbContext(DbContextOptions<WebApi_PracticeDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customer { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.City).HasMaxLength(150);

                entity.Property(e => e.Email).HasMaxLength(150);

                entity.Property(e => e.FirstName).HasMaxLength(150);

                entity.Property(e => e.LastName).HasMaxLength(150);

                entity.Property(e => e.Phone).HasMaxLength(150);

                entity.Property(e => e.ZipCode).HasMaxLength(150);
            });
             
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
