using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace TARge20.Core.Domain
{
    public partial class TARge20Context : DbContext
    {
        public TARge20Context()
        {
        }

        public TARge20Context(DbContextOptions<TARge20Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Töötaja> Töötaja { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Name=TARge20");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Estonian_CI_AS");

            modelBuilder.Entity<Töötaja>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}


