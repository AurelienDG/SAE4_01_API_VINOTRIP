using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_e_historiquecadeau_htc")]
    public partial class HistoriqueCadeau
    {
        [Required]
        [Column("ctl_id")]
        public int PersonneId { get; set; }

        [Required]
        [Column("bcd_id")]
        public int BonCadeauId { get; set; }

        [Required]
        [StringLength(30)]
        [Column("htc_typecadeau")]
        public string? TypeCadeau { get; set; }

        [ForeignKey("PersonneId")]
        [InverseProperty("HistoriqueCadeauClient")]
        public virtual Client ClientHistoriqueCadeau { get; set; } = null!;

        [ForeignKey("BonCadeauId")]
        [InverseProperty("HistoriqueCadeauBonCadeau")]
        public virtual BonCadeau BonCadeauHistoriqueCadeau { get; set; } = null!;
    }
}
