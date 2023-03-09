using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_j_lienavis_lav")]
    public partial class LienAvis
    {
        [Required]
        [Column("len_id")]
        public int LienId { get; set; }

        [Required]
        [Column("avi_id")]
        public int AvisId { get; set; }

        [ForeignKey("LienId")]
        [InverseProperty("LiensAvisLien")]
        public virtual Lien LienLienAvis { get; set; } = null!;

        [ForeignKey("AvisId")]
        [InverseProperty("LiensAvisAvis")]
        public virtual Avis AvisLienAvis { get; set; } = null!;
    }
}
