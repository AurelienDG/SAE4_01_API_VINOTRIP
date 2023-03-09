using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_e_reservation_rsv")]
    public partial class Reservation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("rsv_id")]
        public int ReservationId { get; set; }

        [Column("sjr_id")]
        [Required]
        public int SejourId { get; set; }

        [Column("rsv_nbadultes")]
        [Required]
        public int NbAdultes { get; set; }

        [Column("rsv_nbenfants")]
        [Required]
        public int NbEnfants { get; set; }

        [Column("rsv_nbchambres")]
        [Required]
        public int NbChambres { get; set; }

        [Column("rsv_id", TypeName = "numeric(9,2)")]
        [Required]
        public double PrixTotal { get; set; }

        [Column("rsv_datedebutresa", TypeName = "date")]
        [Required]
        public DateTime DateDebutResa{ get; set; }

        [Column("rsv_datefinresa", TypeName = "date")]
        [Required]
        public DateTime DateFinResa{ get; set; }

        [Column("bcd_id")]
        public int BonCadeauId { get; set; }

        [Column("rsv_datefacture")]
        [Required]
        public DateTime DateFacture { get; set; }

        [ForeignKey("SejourId")]
        [InverseProperty("ReservationsSejour")]
        public virtual Sejour SejourReservation { get; set; } = null!;

        [ForeignKey("BonCadeauId")]
        [InverseProperty("ReservationBonCadeau")]
        public virtual Sejour BonCadeauReservation { get; set; } = null!;
    }
}
