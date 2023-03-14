using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_j_liensejour_lsj")]
    public partial class LienSejour
    {
        //Property

        [Required, Column("sjr_id")]
        public int SejourId { get; set; }
        [Required, Column("len_id")]
        public int LienId { get; set; }

        //InverseProperty

        [ForeignKey("SejourId")]
        [InverseProperty("LienSejourSejour")]
        public virtual Sejour? SejourLienSejour { get; set; }

        [ForeignKey("LienId")]
        [InverseProperty("LienSejourLien")]
        public virtual Lien? LienLienSejour { get; set; }


    }
}
