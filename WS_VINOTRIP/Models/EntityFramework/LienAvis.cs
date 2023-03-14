using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_j_lienavis_lav")]
    public partial class LienAvis
    {
        //Property

        [Required, Column("len_id")]
        public int LienId { get; set; }

        [Required, Column("avi_id")]
        public int AvisId { get; set; }

        //InverseProperty

        [ForeignKey("LienId")]
        [InverseProperty("LiensAvisLien")]
        public virtual Lien? LienLienAvis { get; set; }

        [ForeignKey("AvisId")]
        [InverseProperty("LiensAvisAvis")]
        public virtual Avis? AvisLienAvis { get; set; }
    }
}
