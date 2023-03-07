using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_j_lienetape_lep")]
    public partial class LienEtape
    {
        [Key, Column("lep_id")]
        public int EtapeId { get; set; }
        [Key, Column("lep_id")]
        public int LienId { get; set; }

        [ForeignKey("EtapeId")]
        [InverseProperty("LienSejourRouteDesVins")]
        public virtual RouteDesVins RouteDesVinsLienSejour { get; set; } = null!;

        [ForeignKey("LienId")]
        [InverseProperty("LienSejourLien")]
        public virtual Lin LienLienSejour { get; set; } = null!;
    }
}
