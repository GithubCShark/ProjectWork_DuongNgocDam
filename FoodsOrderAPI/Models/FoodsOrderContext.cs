using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FoodsOrderAPI.Models
{
    public partial class FoodsOrderContext : DbContext
    {
        public FoodsOrderContext()
        {
        }

        public FoodsOrderContext(DbContextOptions<FoodsOrderContext> options)
            : base(options)
        {
        }

        public virtual DbSet<FoodItem> FoodItem { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=NGDAM;Database=FoodsOrder;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FoodItem>(entity =>
            {
                entity.Property(e => e.Desc).HasMaxLength(250);

                entity.Property(e => e.ImgSource)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Title).HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
