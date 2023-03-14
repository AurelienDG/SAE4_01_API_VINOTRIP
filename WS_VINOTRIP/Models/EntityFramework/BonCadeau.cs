using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_e_boncadeau_bcd")]
    public partial class BonCadeau
    {

        //Property

        [Key, Column("bcd_id"), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BonCadeauId { get; set; }

        [Required, Column("bcd_dateexpirationbon", TypeName = "date")]
        public DateTime DateExpirationBon { get; set; }

        [Required, Column("bcd_codereduction", TypeName = "char(8)")]
        public string? CodeReduction { get; set; }

        //InverseProperty

        [InverseProperty("BonCadeauHistoriqueCadeau")]
        public virtual ICollection<HistoriqueCadeau>? HistoriqueCadeauBonCadeau { get; set; }

        [InverseProperty("BonCadeauSejourCadeau")]
        public virtual ICollection<SejourCadeau>? SejourCadeauBonCadeau { get; set; }

        [InverseProperty("BonCadeauChequeCadeau")]
        public virtual ICollection<ChequeCadeau>? ChequeCadeauBonCadeau { get; set; }

        [InverseProperty("BonCadeauReservation")]
        public virtual ICollection<Reservation>? ReservationBonCadeau { get; set; }

    }
}
