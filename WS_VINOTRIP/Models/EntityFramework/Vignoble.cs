using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_e_vignoble_vgb")]
    public partial class Vignoble
    {
        //Property

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column("vgb_id")]
        public int VignobleId { get; set; }
        [Required, Column("vgb_titre"), StringLength(50)]
        public string? Titre { get; set; }
        [Required, Column("vgb_description", TypeName = "text")]
        public string? Description { get; set; }
        [Column("len_id")]
        public int LienId { get; set; }

        //InverseProperty

        [InverseProperty("VignobleRouteDesVins")]
        public virtual ICollection<RouteDesVins>? RouteDesVinsVignoble { get; set; }

        [InverseProperty("VignobleElementVignoble")]
        public virtual ICollection<ElementVignoble>? ElementVignobleVignoble { get; set; }

        [ForeignKey("LienId")]
        [InverseProperty("VignobleLien")]
        public virtual Lien? LienVignoble { get; set; }
    }
}
