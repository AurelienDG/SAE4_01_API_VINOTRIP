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

        public virtual DbSet<Sejour>? Sejours { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Server=localhost;port=5432;Database=VinotripDB; uid=postgres; password=postgres;"); //à changer

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Avis>(entity =>
            {
                entity.HasKey(e => new { e.AvisId })
                    .HasName("pk_avi");
            });

            modelBuilder.Entity<BonCadeau>(entity =>
            {
                entity.HasKey(e => new { e.BonCadeauId })
                    .HasName("pk_bcd");
            });

            modelBuilder.Entity<CatParticipant>(entity =>
            {
                entity.HasKey(e => new { e.CatParticipantId })
                    .HasName("pk_cpp");
            });

            modelBuilder.Entity<CatSejour>(entity =>
            {
                entity.HasKey(e => new { e.CatSejourId })
                    .HasName("pk_csj");
            });

            modelBuilder.Entity<CatVignoble>(entity =>
            {
                entity.HasKey(e => new { e.CatVignobleId })
                    .HasName("pk_cvg");
            });

            modelBuilder.Entity<ChequeCadeau>(entity =>
            {
                entity.HasKey(e => new { e.BonCadeauId })
                    .HasName("pk_cqc");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.HasKey(e => new { e.PersonneId })
                    .HasName("pk_clt");
            });

            modelBuilder.Entity<ClientCarte>(entity =>
            {
                entity.HasKey(e => new { e.PersonneId, e.CarteId })
                    .HasName("pk_clc");
            });

            modelBuilder.Entity<Comporte>(entity =>
            {
                entity.HasKey(e => new { e.SejourId, e.CatParticipantId })
                    .HasName("pk_cpt");

                entity.HasOne(d => d.SejourComporte).WithMany(p => p.ComporteSejour)
                    .HasForeignKey(d => d.SejourId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_cpt_sjr");

                entity.HasOne(d => d.CatParticipantComporte).WithMany(p => p.ComporteCatParticipant)
                    .HasForeignKey(d => d.CatParticipantId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_cpt_cpp");
            });

            modelBuilder.Entity<Compte>(entity =>
            {
                entity.HasKey(e => new { e.CompteId })
                    .HasName("pk_cmp");
            });

            modelBuilder.Entity<Concerne>(entity =>
            {
                entity.HasKey(e => new { e.EtapeId, e.ElementId })
                    .HasName("pk_ccr");

                entity.HasOne(d => d.EtapeConcerne).WithMany(p => p.ConcerneEtape)
                    .HasForeignKey(d => d.EtapeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_ccr_etp");

                entity.HasOne(d => d.ElementEtapeConcerne).WithMany(p => p.ConcerneElementEtape)
                    .HasForeignKey(d => d.ElementId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_ccr_ele");
            });

            modelBuilder.Entity<Contient>(entity =>
            {
                entity.HasKey(e => new { e.LienId, e.ElementId })
                    .HasName("pk_ctn");
            });

            modelBuilder.Entity<ElementEtape>(entity =>
            {
                entity.HasKey(e => new { e.ElementId })
                    .HasName("pk_ele");
            });

            modelBuilder.Entity<ElementVignoble>(entity =>
            {
                entity.HasKey(e => new { e.ElementVignobleId })
                    .HasName("pk_evg");
            });

            modelBuilder.Entity<Etape>(entity =>
            {
                entity.HasKey(e => new { e.EtapeId })
                    .HasName("pk_etp");
            });

            modelBuilder.Entity<Favori>(entity =>
            {
                entity.HasKey(e => new { e.SejourId, e.PersonneId })
                    .HasName("pk_fav");
            });

            modelBuilder.Entity<HistoriqueCadeau>(entity =>
            {
                entity.HasKey(e => new { e.PersonneId, e.BonCadeauId })
                    .HasName("pk_htc");
            });

            modelBuilder.Entity<Lien>(entity =>
            {
                entity.HasKey(e => new { e.LienId })
                    .HasName("pk_len");
            });

            modelBuilder.Entity<LienElementVignoble>(entity =>
            {
                entity.HasKey(e => new { e.LienId, e.ElementVignobleId })
                    .HasName("pk_lev");
            });

            modelBuilder.Entity<LienEtape>(entity =>
            {
                entity.HasKey(e => new { e.LienId, e.EtapeId })
                    .HasName("pk_lep");
            });

            modelBuilder.Entity<LienRouteDesVins>(entity =>
            {
                entity.HasKey(e => new { e.LienId, e.RouteDesVinsId })
                    .HasName("pk_lrv");
            });

            modelBuilder.Entity<LienSejour>(entity =>
            {
                entity.HasKey(e => new { e.LienId, e.SejourId })
                    .HasName("pk_lsj");
            });

            modelBuilder.Entity<MotDePasse>(entity =>
            {
                entity.HasKey(e => new { e.MdpId })
                    .HasName("pk_mdp");
            });

            modelBuilder.Entity<Panier>(entity =>
            {
                entity.HasKey(e => new { e.SejourId, e.PersonneId })
                    .HasName("pk_pnr");
            });

            modelBuilder.Entity<Partenaire>(entity =>
            {
                entity.HasKey(e => new { e.PersonneId })
                    .HasName("pk_ptn");
            });

            modelBuilder.Entity<PartenaireActivite>(entity =>
            {
                entity.HasKey(e => new { e.PersonneId })
                    .HasName("pk_pta");
            });

            modelBuilder.Entity<PartenaireCave>(entity =>
            {
                entity.HasKey(e => new { e.PersonneId })
                    .HasName("pk_ptc");
            });

            modelBuilder.Entity<PartenaireHebergement>(entity =>
            {
                entity.HasKey(e => new { e.PersonneId })
                    .HasName("pk_pth");
            });

            modelBuilder.Entity<PartenaireRestaurant>(entity =>
            {
                entity.HasKey(e => new { e.PersonneId })
                    .HasName("pk_ptr");
            });

            modelBuilder.Entity<Personne>(entity =>
            {
                entity.HasKey(e => new { e.PersonneId })
                    .HasName("pk_prs");
            });

            modelBuilder.Entity<RefCarteBancaire>(entity =>
            {
                entity.HasKey(e => new { e.CarteId })
                    .HasName("pk_rcb");
            });

            modelBuilder.Entity<Reported>(entity =>
            {
                entity.HasKey(e => new { e.AvisId, e.CompteId })
                    .HasName("pk_rep");
            });

            modelBuilder.Entity<RouteDesVins>(entity =>
            {
                entity.HasKey(e => new { e.RouteDesVinsId })
                    .HasName("pk_rdv");
            });

            modelBuilder.Entity<Sejour>(entity =>
            {
                entity.HasKey(e => new { e.SejourId })
                    .HasName("pk_sjr");

                entity.HasOne(d => d.RouteDesVinsSejour).WithMany(p => p.SejourRouteDesVins)
                    .HasForeignKey(d => d.RouteVinId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_sjr_rdv");

                entity.HasOne(d => d.SejourCatSejour).WithMany(p => p.CatSejoursSejour)
                    .HasForeignKey(d => d.CatSejourId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_sjr_csj");

                entity.HasOne(d => d.SejourCatVignoble).WithMany(p => p.CatVignobleSejour)
                    .HasForeignKey(d => d.CatVignobleId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_sjr_cvg");
            });

            modelBuilder.Entity<SejourCadeau>(entity =>
            {
                entity.HasKey(e => new { e.BonCadeauId })
                    .HasName("pk_sjc");
            });

            modelBuilder.Entity<TypeCompte>(entity =>
            {
                entity.HasKey(e => new { e.TypeCompteId })
                    .HasName("pk_tpc");
            });

            modelBuilder.Entity<TypeElement>(entity =>
            {
                entity.HasKey(e => new { e.TypeElementId })
                    .HasName("pk_tpe");
            });

            modelBuilder.Entity<Vignoble>(entity =>
            {
                entity.HasKey(e => new { e.VignobleId })
                    .HasName("pk_vgb");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
