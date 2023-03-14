using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_e_routedesvins_rdv")]
    public partial class RouteDesVins
    {
        //Property

        [Key, Column("rdv_id"), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RouteDesVinsId { get; set; }
        [Column("vgb_id")]
        public int? VignobleId { get; set; }
        [Required, Column("rdv_titre", TypeName = "varchar(30)"), StringLength(30)]
        public string? Titre { get; set; }
        [Required, Column("rdv_description", TypeName = "text")]
        public String? Description { get; set; }

        //InverseProperty

        [InverseProperty("RouteDesVinsSejour")]
        public virtual ICollection<Sejour>? SejourRouteDesVins { get; }

        [InverseProperty("RouteDesVinsLienRouteDesVins")]
        public virtual ICollection<LienRouteDesVins>? LienRouteDesVinsRouteDesVins { get; }

        [ForeignKey("VignobleId")]
        [InverseProperty("RouteDesVinsVignoble")]
        public virtual Vignoble? VignobleRouteDesVins { get; set; }
    }
}
