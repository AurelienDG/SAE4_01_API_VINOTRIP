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

        public virtual DbSet<Sejour> Sejours { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Server=localhost;port=5432;Database=VinotripDB; uid=postgres; password=postgres;"); //à changer

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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

            modelBuilder.Entity<CompteCarte>(entity =>
            {
                entity.HasKey(e => new { e.PersonneId, e.CarteId })
                    .HasName("pk_clc");
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

                entity.HasOne(d => d.PartenaireElementEtape).WithMany(p => p.ElementsEtapePartenaire)
                    .HasForeignKey(d => d.PersonneId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_ele_ptn");

                entity.HasOne(d => d.TypeElementEtapeElementEtape).WithMany(p => p.ElementEtapeTypeElementetape)
                    .HasForeignKey(d => d.TypeElementId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_ele_tpe");
            });

            modelBuilder.Entity<ElementVignoble>(entity =>
            {
                entity.HasKey(e => new { e.ElementVignobleId })
                    .HasName("pk_evg");

                entity.HasOne(d => d.VignobleElementVignoble).WithMany(p => p.ElementVignobleVignoble)
                    .HasForeignKey(d => d.VignobleId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_evg_vgb");
            });

            modelBuilder.Entity<Etape>(entity =>
            {
                entity.HasKey(e => new { e.EtapeId })
                    .HasName("pk_etp");

                entity.HasOne(d => d.SejourEtape).WithMany(p => p.EtapesSejour)
                    .HasForeignKey(d => d.SejourId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_etp_sjr");
            });

            modelBuilder.Entity<Favori>(entity =>
            {
                entity.HasKey(e => new { e.SejourId, e.PersonneId })
                    .HasName("pk_fav");

                entity.HasOne(d => d.SejourFavori).WithMany(p => p.FavoriSejour)
                    .HasForeignKey(d => d.SejourId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_fav_sjr");

                entity.HasOne(d => d.ClientFavori).WithMany(p => p.FavoriClient)
                    .HasForeignKey(d => d.PersonneId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_fav_clt");
            });

            modelBuilder.Entity<HistoriqueCadeau>(entity =>
            {
                entity.HasKey(e => new { e.PersonneId, e.BonCadeauId })
                    .HasName("pk_htc");

                entity.HasOne(d => d.ClientHistoriqueCadeau).WithMany(p => p.HistoriqueCadeauClient)
                    .HasForeignKey(d => d.PersonneId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_htc_clt");

                entity.HasOne(d => d.BonCadeauHistoriqueCadeau).WithMany(p => p.HistoriqueCadeauBonCadeau)
                    .HasForeignKey(d => d.BonCadeauId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_htc_bcd");
            });

            modelBuilder.Entity<LienElementVignoble>(entity =>
            {
                entity.HasKey(e => new { e.LienId, e.ElementVignobleId })
                    .HasName("pk_lev");

                entity.HasOne(d => d.LienLienElementVignoble).WithMany(p => p.LienElementVignobleLien)
                    .HasForeignKey(d => d.LienId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_lev_len");

                entity.HasOne(d => d.ElementVignobleLienElementVignoble).WithMany(p => p.LienElementVignobleElementVignoble)
                    .HasForeignKey(d => d.ElementVignobleId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_lev_evg");
            });

            modelBuilder.Entity<LienEtape>(entity =>
            {
                entity.HasKey(e => new { e.LienId, e.EtapeId })
                    .HasName("pk_lep");

                entity.HasOne(d => d.LienLienEtape).WithMany(p => p.LienEtapeLien)
                    .HasForeignKey(d => d.LienId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_lep_len");

                entity.HasOne(d => d.EtapeLienEtape).WithMany(p => p.LienEtapeEtape)
                    .HasForeignKey(d => d.EtapeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_lep_etp");
            });

            modelBuilder.Entity<LienRouteDesVins>(entity =>
            {
                entity.HasKey(e => new { e.LienId, e.RouteDesVinsId })
                    .HasName("pk_lrv");

                entity.HasOne(d => d.LienLienRouteDesVins).WithMany(p => p.LienRouteDesVinsLien)
                    .HasForeignKey(d => d.LienId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_lrv_len");

                entity.HasOne(d => d.RouteDesVinsLienRouteDesVins).WithMany(p => p.LienRouteDesVinsRouteDesVins)
                    .HasForeignKey(d => d.RouteDesVinsId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_lrv_rdv");
            });

            modelBuilder.Entity<LienSejour>(entity =>
            {
                entity.HasKey(e => new { e.LienId, e.SejourId })
                    .HasName("pk_lsj");

                entity.HasOne(d => d.LienLienSejour).WithMany(p => p.LienSejourLien)
                    .HasForeignKey(d => d.LienId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_lsj_len");

                entity.HasOne(d => d.SejourLienSejour).WithMany(p => p.LienSejourSejour)
                    .HasForeignKey(d => d.SejourId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_lsj_sjr");
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

                entity.HasOne(d => d.SejourPanier).WithMany(p => p.PanierSejour)
                    .HasForeignKey(d => d.SejourId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_pnr_sjr");

                entity.HasOne(d => d.ComptePanier).WithMany(p => p.PanierCompte)
                    .HasForeignKey(d => d.PersonneId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_pnr_cmp");
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

                entity.HasOne(d => d.PartenairePartenaireActivite).WithMany(p => p.PartenairesActivitePartenaire)
                    .HasForeignKey(d => d.PersonneId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_pta_ptn");
            });

            modelBuilder.Entity<PartenaireCave>(entity =>
            {
                entity.HasKey(e => new { e.PersonneId })
                    .HasName("pk_ptc");

                entity.HasOne(d => d.PartenairePartenaireCave).WithMany(p => p.PartenairesCavePartenaire)
                    .HasForeignKey(d => d.PersonneId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_ptc_ptn");
            });

            modelBuilder.Entity<PartenaireHebergement>(entity =>
            {
                entity.HasKey(e => new { e.PersonneId })
                    .HasName("pk_pth");

                entity.HasOne(d => d.PartenairePartenaireHebergement).WithMany(p => p.PartenairesHebergementPartenaire)
                    .HasForeignKey(d => d.PersonneId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_pth_ptn");
            });

            modelBuilder.Entity<PartenaireRestaurant>(entity =>
            {
                entity.HasKey(e => new { e.PersonneId })
                    .HasName("pk_ptr");

                entity.HasOne(d => d.PartenairePartenaireRestaurant).WithMany(p => p.PartenairesRestaurantPartenaire)
                    .HasForeignKey(d => d.PersonneId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_ptr_ptn");
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

                entity.HasOne(d => d.AvisReported).WithMany(p => p.ReportedAvis)
                    .HasForeignKey(d => d.AvisId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_rep_avi");

                entity.HasOne(d => d.CompteReported).WithMany(p => p.ReportedCompte)
                    .HasForeignKey(d => d.CompteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_rep_cmp");
            });

            modelBuilder.Entity<RouteDesVins>(entity =>
            {
                entity.HasKey(e => new { e.RouteDesVinsId })
                    .HasName("pk_rdv");

                entity.HasOne(d => d.VignobleRouteDesVins).WithMany(p => p.RouteDesVinsVignoble)
                    .HasForeignKey(d => d.VignobleId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_rdv_vgb");
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

                entity.HasOne(d => d.BonCadeauSejourCadeau).WithMany(p => p.SejourCadeauBonCadeau)
                    .HasForeignKey(d => d.BonCadeauId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_sjc_bcd");

                entity.HasOne(d => d.SejourSejourCadeau).WithMany(p => p.SejourCadeauSejour)
                    .HasForeignKey(d => d.SejourId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_sjc_sjr");
            });

            modelBuilder.Entity<TypeCompte>(entity =>
            {
                entity.HasKey(e => new { e.TypeCompteId })
                    .HasName("pk_tpc");
            });

            modelBuilder.Entity<TypeElementEtape>(entity =>
            {
                entity.HasKey(e => new { e.TypeElementEtapeId })
                    .HasName("pk_tpe");
            });

            modelBuilder.Entity<Vignoble>(entity =>
            {
                entity.HasKey(e => new { e.VignobleId })
                    .HasName("pk_vgb");

                entity.HasOne(d => d.LienVignoble).WithMany(p => p.VignobleLien)
                    .HasForeignKey(d => d.LienId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_vgb_len");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
