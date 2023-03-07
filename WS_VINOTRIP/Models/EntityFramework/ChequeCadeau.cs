using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_e_chequecadeau_cqc")]
    public partial class ChequeCadeau
    {
        [Required]
        [Column("bcd_id")]
        public int BonCadeauId { get; set; }

        [Required]
        [Column("cqc_montant")]
        public int montant { get; set; }

        [ForeignKey("BonCadeauId")]
        [InverseProperty("ChequeCadeauBonCadeau")]
        public virtual BonCadeau BonCadeauChequeCadeau { get; set; } = null!;
    }
}
