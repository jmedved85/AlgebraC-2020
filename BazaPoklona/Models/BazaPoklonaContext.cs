using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace BazaPoklona.Models
{
    public partial class BazaPoklonaContext : DbContext
    {
        public BazaPoklonaContext()
        {
        }

        public BazaPoklonaContext(DbContextOptions<BazaPoklonaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Poklon> Poklons { get; set; }
        public virtual DbSet<Trgovina> Trgovinas { get; set; }
        public virtual DbSet<VrstaRobe> VrstaRobes { get; set; }
        public virtual DbSet<OstvareniPrometPoklonModel> OstvareniPrometPoklonModels { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=BazaPoklona;Trusted_Connection=True;");
            }
        }
        // Data annotation ne radi, koristio je FLUENT API
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Croatian_CI_AS");

            modelBuilder.Entity<Poklon>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("PK__Poklon__2D443D4D5AEE092A");

                entity.ToTable("Poklon");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.Cijena);
                  
                entity.HasOne(d => d.VrstaRobeNavigation)
                    .WithMany(p => p.Poklons)
                    .HasForeignKey(d => d.VrstaRobe)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Poklon__VrstaRob__286302EC");
            });

            modelBuilder.Entity<Trgovina>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("PK__Trgovina__A41276705583ABF8");

                entity.ToTable("Trgovina");

                entity.Property(e => e.NazivTrgovina)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.HasOne(d => d.VrstaRobeNavigation)
                    .WithMany(p => p.Trgovinas)
                    .HasForeignKey(d => d.VrstaRobe)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Trgovina__VrstaR__29572725");
            });

            modelBuilder.Entity<VrstaRobe>(entity =>
            {
                entity.ToTable("VrstaRobe");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(40);
            });

            // modelBuilder.Entity<OstvareniPrometPoklonModel>().HasNoKey();

            modelBuilder.Entity<OstvareniPrometPoklonModel>
                (eb =>
                {
                    eb.HasNoKey();
                    eb.ToView("OstvareniPrometPoklonRawSQL");
                    eb.Property(v => v.Naziv).HasColumnName("Naziv");
                    eb.Property(v => v.VrstaRobe).HasColumnName("VrstaRobe");
                    eb.Property(v => v.Cijena).HasColumnName("Cijena");
                });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
