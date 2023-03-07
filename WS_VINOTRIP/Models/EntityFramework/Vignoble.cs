using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_e_vignoble_vgb")]
    public partial class Vignoble
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column("vgb_id")]
        public int VignobleId { get; set; }
        [StringLength(50), Required, Column("vgb_titre", TypeName = "varchar(50)")]
        public string? Titre { get; set; }
        [Required, Column("vgb_description", TypeName = "text")]
        public string? Description { get; set; }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column("len_id")]
        public int LienId { get; set; }

        [InverseProperty("VignobleRouteDesVins")]
        public virtual ICollection<RouteDesVins> RouteDesVinsVignoble { get; set; } = new List<RouteDesVins>();

        [ForeignKey("LienId")]
        [InverseProperty("VignobleLien")]
        public virtual Lien LienVignoble { get; set; } = null!;
    }
}
