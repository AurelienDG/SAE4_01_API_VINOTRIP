using Microsoft.EntityFrameworkCore.Infrastructure;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_e_sejour_sjr")]
    public partial class Sejour
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column("sjr_id")]
        public int SejourId { get; set; }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column("rdv_id")]
        public int RouteVinId { get; set; }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column("csj_id")]
        public int CatSejourId { get; set; }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column("cvg_id")]
        public int CatVignobleId { get; set; }

        [StringLength(100), Required, Column("sjr_titre", TypeName = "varchar(100)")]
        public string? Titre { get; set; }
        [Required, Column("sjr_description", TypeName = "text")]
        public string? Description { get; set; }
        [Required, Column("sjr_prix", TypeName = "numeric(7,2)")]
        public double Prix { get; set; }
        [Required, Column("sjr_nbjour", TypeName = "numeric(3,2)")]
        public double NbJour { get; set; }
        [Required, Column("sjr_nbnuit")]
        public int NbNuit { get; set; }
        [Column("sjr_promotion")]
        public int Promotion { get; set; }
        [Column("sjr_est_valide")]
        public bool Est_Valide { get; set; }

         
        [ForeignKey("RouteVinId")]
        [InverseProperty("RouteDesVinsSejour")]
        public virtual RouteDesVins SejourRouteDesVins { get; set; } = null!;

        [ForeignKey("CatSejourId")]
        [InverseProperty("CatSejoursSejour")]
        public virtual CatSejour SejourCatSejour { get; set; } = null!;

        [ForeignKey("CatVignobleId")]
        [InverseProperty("CatVignobleSejour")]
        public virtual CatVignoble SejourCatVignoble { get; set; } = null!;

        [InverseProperty("SejourEtape")]
        public virtual ICollection<Etape> EtapesSejour { get; set; } = new List<Etape>();

        [InverseProperty("SejourPanier")]
        public virtual ICollection<Panier> PanierSejour { get; set; } = new List<Panier>();
        
        [InverseProperty("SejourComporte")]
        public virtual ICollection<Comporte> ComporteSejour { get; set; } = new List<Comporte>();

         [InverseProperty("SejourFavori")]
        public virtual ICollection<Favori> FavoriSejour { get; set; } = new List<Favori>();


    }
}
