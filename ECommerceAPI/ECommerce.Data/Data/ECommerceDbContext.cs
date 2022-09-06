using ECommerce.Entities;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Data.Data
{
    public partial class ECommerceDbContext : DbContext
    {
        //Generated from migration with scalfold
        public ECommerceDbContext()
        {
        
        }
        
        public ECommerceDbContext(DbContextOptions<ECommerceDbContext> options) : base(options)
        {

        }
        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer();
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasIndex(e => e.CategoryId, "IX_Products_CategoryId");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                //entity.HasOne(d => d.Category)
                //    .WithMany(p => p.Products)
                //    .HasForeignKey(d => d.CategoryId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
