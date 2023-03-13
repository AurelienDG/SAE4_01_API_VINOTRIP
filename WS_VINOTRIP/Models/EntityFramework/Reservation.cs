using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_e_reservation_rsv")]
    public partial class Reservation
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column("rsv_id")]
        public int ReservationId { get; set; }

        [Required, Column("sjr_id")]
        public int SejourId { get; set; }

        [Column("bcd_id")]
        public int BonCadeauId { get; set; }

        [Required, Column("rsv_nbadultes")]
        public int NbAdultes { get; set; }

        [Required, Column("rsv_nbenfants")]
        public int NbEnfants { get; set; }

        [Required, Column("rsv_nbchambres")]
        public int NbChambres { get; set; }

        [Required, Column("rsv_prixtotal", TypeName = "numeric(9,2)")]
        public double PrixTotal { get; set; }

        [Required, Column("rsv_datedebutresa", TypeName = "date")]
        public DateTime DateDebutResa{ get; set; }

        [Required, Column("rsv_datefinresa", TypeName = "date")]
        public DateTime DateFinResa{ get; set; }

        [Required, Column("rsv_datefacture", TypeName = "date")]
        public DateTime DateFacture { get; set; }

        [ForeignKey("SejourId")]
        [InverseProperty("ReservationsSejour")]
        public virtual Sejour SejourReservation { get; set; } = null!;

        [ForeignKey("BonCadeauId")]
        [InverseProperty("ReservationBonCadeau")]
        public virtual BonCadeau BonCadeauReservation { get; set; } = null!;

        [InverseProperty("ReservationPasse")]
        public virtual ICollection<Passe> PasseReservation { get; } = new List<Passe>();

        [InverseProperty("ReservationEst_facturee")]
        public virtual ICollection<Est_facturee> Est_factureeReservation { get; } = new List<Est_facturee>();
    }
}
