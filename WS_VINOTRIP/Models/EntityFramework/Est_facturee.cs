using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_j_est_facturee_efc")]
    public partial class Est_facturee
    {
        //Property

        [Required, Column("rsv_id")]
        public int ReservationId { get; set; }
        [Required, Column("ads_id")]
        public int AdresseId { get; set; }

        //InverseProperty

        [ForeignKey("ReservationId")]
        [InverseProperty("Est_factureeReservation")]
        public virtual Reservation? ReservationEst_facturee { get; set; }

        [ForeignKey("AdresseId")]
        [InverseProperty("Est_factureeAdresse")]
        public virtual Adresse? AdresseEst_facturee { get; set; }
    }
}
