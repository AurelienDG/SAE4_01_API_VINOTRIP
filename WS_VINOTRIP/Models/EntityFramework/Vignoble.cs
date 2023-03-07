using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_e_vignoble_vgb")]
    public partial class Vignoble
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column("vgb_id")]
        public int VignobleId { get; set; }
        public string? Titre { get; set; }
        public string? Description { get; set; }
        public int LienId { get; set; }

        [InverseProperty("VignobleRouteDesVins")]
        public virtual ICollection<RouteDesVins> RouteDesVinsVignoble { get; set; } = new List<RouteDesVins>();

        [ForeignKey("LienId")]
        [InverseProperty("VignobleLien")]
        public virtual Lien LienVignoble { get; set; } = null!;
    }
}
