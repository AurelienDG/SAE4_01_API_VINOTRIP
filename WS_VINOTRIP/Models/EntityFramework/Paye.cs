using System.ComponentModel.DataAnnotations.Schema;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_j_paye_pay")]
    public class Paye
    {
        [Column("res_id")]
        public int ReservationId { get; set; }

        [Column("tpa_id")]
        public int TypePayementId { get; set; }

        [ForeignKey("ReservationId")]
        [InverseProperty("PayeReservation")]
        public virtual Reservation ReservationPaye { get; set; } = null!;

        [ForeignKey("TypePayementId")]
        [InverseProperty("PayeTypePayement")]
        public virtual TypePayement TypePayementPaye { get; set; } = null!;
    }
}
