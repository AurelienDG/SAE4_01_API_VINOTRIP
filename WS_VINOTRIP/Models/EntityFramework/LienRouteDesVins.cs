using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_j_lienroutedesvins_lrv")]
    public partial class LienRouteDesVins
    {
        [Column("rdv_id")]
        public int RouteDesVinsId { get; set; }
        [Column("len_id")]
        public int LienId { get; set; }

        [ForeignKey("RouteDesVinsId")]
        [InverseProperty("LienRouteDesVinsRouteDesVins")]
        public virtual RouteDesVins RouteDesVinsLienRouteDesVins { get; set; } = null!;

        [ForeignKey("LienId")]
        [InverseProperty("LienRouteDesVinsLien")]
        public virtual Lien LienLienRouteDesVins { get; set; } = null!;
    }
}
