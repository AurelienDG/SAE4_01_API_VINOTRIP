using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_j_contient_ctn")]
    public partial class Contient
    {
        [Column("ele_id")]
        public int ElementId { get; set; }
        [Column("len_id")]
        public int LienId { get; set; }

        [ForeignKey("ElementId")]
        [InverseProperty("ContientElementEtape")]
        public virtual ElementEtape ElementEtapeContient { get; set; } = null!;

        [ForeignKey("LienId")]
        [InverseProperty("ContientLien")]
        public virtual Lien LienContient { get; set; } = null!;
    }
}
