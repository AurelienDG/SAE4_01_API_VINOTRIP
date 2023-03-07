using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_j_lienelementvignoble_lev")]
    public class LienElementVignoble
    {
        [Key, Column("evg_id")]
        public int ElementVignobleId { get; set; }
        [Key, Column("len_id")]
        public int LienId { get; set; }

        [ForeignKey("ElementVignobleId")]
        [InverseProperty("LienElementVignobleElementVignoble")]
        public virtual ElementVignoble ElementVignobleLienElementVignoble { get; set; } = null!;

        [ForeignKey("LienId")]
        [InverseProperty("LienElementVignobleLien")]
        public virtual Lien LienLienElementVignoble { get; set; } = null!;

    }
}
