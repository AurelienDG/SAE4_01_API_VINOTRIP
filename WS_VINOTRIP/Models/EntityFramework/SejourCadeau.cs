using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_e_sejourcadeau_sjc")]
    public partial class SejourCadeau
    {
        [Required]
        [Column("bcd_id")]
        public int BonCadeauId { get; set; }

        [Required]
        [Column("sjr_id")]
        public int SejourId { get; set; }

        [Required]
        [StringLength(100)]
        [Column("sjc_choixdestination")]
        public string? ChoixDestination { get; set; }

        [ForeignKey("BonCadeauId")]
        [InverseProperty("SejourCadeauBonCadeau")]
        public virtual BonCadeau BonCadeauSejourCadeau { get; set; } = null!;

        [ForeignKey("SejourId")]
        [InverseProperty("SejourCadeauSejour")]
        public virtual Sejour SejourSejourCadeau{ get; set; } = null!;
    }
}
