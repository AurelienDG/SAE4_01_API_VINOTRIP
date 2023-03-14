using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_j_contient_ctn")]
    public partial class Contient
    {
        //Property

        [Required, Column("ele_id")]
        public int ElementId { get; set; }

        [Required, Column("len_id")]
        public int LienId { get; set; }

        //InverseProperty

        [ForeignKey("ElementId")]
        [InverseProperty("ContientElementEtape")]
        public virtual ElementEtape? ElementEtapeContient { get; set; }

        [ForeignKey("LienId")]
        [InverseProperty("ContientLien")]
        public virtual Lien? LienContient { get; set; }
    }
}
