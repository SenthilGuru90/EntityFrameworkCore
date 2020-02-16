using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EFDataFirst.Models
{
    public partial class RBEFCoreWorkContext : DbContext
    {
        //Scaffold-DbContext "Data Source=DESKTOP-0D3D54S;Initial Catalog=RBEFCoreWork;Trusted_Connection=True" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models
        public RBEFCoreWorkContext()
        {
        }

        public RBEFCoreWorkContext(DbContextOptions<RBEFCoreWorkContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Author> Author { get; set; }
        public virtual DbSet<Book> Book { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-0D3D54S;Initial Catalog=RBEFCoreWork;Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>(entity =>
            {
                entity.HasIndex(e => e.AuthorId);

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.Book)
                    .HasForeignKey(d => d.AuthorId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
