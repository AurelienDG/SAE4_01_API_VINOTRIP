using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_j_liensejour_lsj")]
    public partial class LienSejour
    {
        [Key, Column("lsj_id")]
        public int SejourId { get; set; }
        [Key, Column("lsj_id")]
        public int LienId { get; set; }


        [ForeignKey("SejourId")]
        [InverseProperty("LienSejourSejour")]
        public virtual Sejour SejourLienSejour { get; set; } = null!;

        [ForeignKey("LienId")]
        [InverseProperty("LienSejourLien")]
        public virtual Sejour LienLienSejour { get; set; } = null!;


    }
}
