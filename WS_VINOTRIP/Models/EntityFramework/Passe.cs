using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations.Schema;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_j_passe_pss")]
    public partial class Passe
    {
        //Property

        [Required, Column("cmd_id")]
        public int CommandeId { get; set; }
        [Required, Column("rsv_id")]
        public int ReservationId { get; set; }

        //InverseProperty

        [ForeignKey("CommandeId")]
        [InverseProperty("PasseCommande")]
        public virtual Commande? CommandePasse { get; set; }

        [ForeignKey("ReservationId")]
        [InverseProperty("PasseReservation")]
        public virtual Reservation? ReservationPasse { get; set; }
    }
}
