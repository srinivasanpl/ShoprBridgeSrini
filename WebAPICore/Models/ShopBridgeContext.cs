using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebAPICore.Models
{
    public partial class ShopBridgeContext : DbContext
    {
        public ShopBridgeContext()
        {
        }

        public ShopBridgeContext(DbContextOptions<ShopBridgeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<InventoryData> InventoryData { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // #warning 
                //To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=lmy-5cg7253f4h\\mssqlserver02;Database=ShopBridge;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InventoryData>(entity =>
            {
                entity.HasKey(e => e.InventoryId);

                entity.ToTable("Inventory_Data");

                entity.Property(e => e.InventoryId).HasColumnName("InventoryID");

                entity.Property(e => e.Description)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
