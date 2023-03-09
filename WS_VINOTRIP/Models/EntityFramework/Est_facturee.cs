using System.ComponentModel.DataAnnotations.Schema;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_j_est_facturee_efc")]
    public partial class Est_facturee
    {
        [Column("rsv_id")]
        public int ReservationId { get; set; }
        [Column("ads_id")]
        public int AdresseId { get; set; }

        [ForeignKey("ReservationId")]
        [InverseProperty("Est_factureeReservation")]
        public virtual Reservation ReservationEst_facturee { get; set; } = null!;

        [ForeignKey("AdresseId")]
        [InverseProperty("Est_factureeAdresse")]
        public virtual Adresse AdresseEst_facturee { get; set; } = null!;
    }
}
