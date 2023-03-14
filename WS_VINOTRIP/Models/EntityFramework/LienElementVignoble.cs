using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_j_lienelementvignoble_lev")]
    public partial class LienElementVignoble
    {
        //Property

        [Required, Column("evg_id")]
        public int ElementVignobleId { get; set; }
        [Required, Column("len_id")]
        public int LienId { get; set; }

        //InverseProperty

        [ForeignKey("ElementVignobleId")]
        [InverseProperty("LienElementVignobleElementVignoble")]
        public virtual ElementVignoble? ElementVignobleLienElementVignoble { get; set; }

        [ForeignKey("LienId")]
        [InverseProperty("LienElementVignobleLien")]
        public virtual Lien? LienLienElementVignoble { get; set; }

    }
}
