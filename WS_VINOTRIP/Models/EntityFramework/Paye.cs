using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations.Schema;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_j_paye_pay")]
    public partial class Paye
    {
        //Property

        [Required, Column("rsv_id")]
        public int ReservationId { get; set; }

        [Required, Column("tpa_id")]
        public int TypePayementId { get; set; }

        //InverseProperty

        [ForeignKey("ReservationId")]
        [InverseProperty("PayeReservation")]
        public virtual Reservation? ReservationPaye { get; set; }

        [ForeignKey("TypePayementId")]
        [InverseProperty("PayeTypePayement")]
        public virtual TypePayement? TypePayementPaye { get; set; }
    }
}
