using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_e_boncadeau_bcd")]
    public partial class BonCadeau
    {
        [Key]
        [Required]
        [Column("bcd_id")]
        public int BonCadeauId { get; set; }

        [Required]
        [Column("bcd_dateexpirationbon", TypeName = "date")]
        public DateTime DateExpirationBon { get; set; }

        [Required]
        [Column("bcd_codereduction", TypeName = "char(8)")]
        public string? CodeReduction { get; set; }

        [InverseProperty("BonCadeauHistoriqueCadeau")]
        public virtual ICollection<HistoriqueCadeau> HistoriqueCadeauBonCadeau { get; } = new List<HistoriqueCadeau>();

        [InverseProperty("BonCadeauSejourCadeau")]
        public virtual ICollection<SejourCadeau> SejourCadeauHistoriqueCadeau { get; } = new List<SejourCadeau>();

        [InverseProperty("BonCadeauChequeCadeau")]
        public virtual ICollection<ChequeCadeau> ChequeCadeauHistoriqueCadeau { get; } = new List<ChequeCadeau>();
    }
}
