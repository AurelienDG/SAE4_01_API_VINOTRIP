using Microsoft.EntityFrameworkCore;

namespace WS_VINOTRIP.Models.EntityFramework
{
    public partial class VinotripDBContext : DbContext
    {
        public VinotripDBContext()
        { }

        public VinotripDBContext(DbContextOptions<VinotripDBContext> options)
        : base(options)
        { }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Server=localhost;port=5432;Database=EnseignantsDB; uid=postgres; password=postgres;"); //à changer

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comporte>(entity =>
            {
                entity.HasKey(e => new { e.CoursId, e.EnseignantId })
                    .HasName("pk_crs");

                entity.HasOne(d => d.EnseignantDuCours).WithMany(p => p.CoursEnseigne)
                    .HasForeignKey(d => d.EnseignantId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_crs_ens");
            });

            modelBuilder.Entity<Enseignant>(entity =>
            {
                entity.HasKey(b => b.EnseignantId).HasName("pk_ens");

                entity.HasIndex(b => b.Numen).IsUnique();

                entity.Property(b => b.Universite).HasDefaultValue("USMB");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
