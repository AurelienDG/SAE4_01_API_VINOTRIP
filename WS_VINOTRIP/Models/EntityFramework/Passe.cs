using System.ComponentModel.DataAnnotations.Schema;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_j_passe_pss")]
    public partial class Passe
    {
        [Column("cmd_id")]
        public int CommandeId { get; set; }
        [Column("rsv_id")]
        public int ReservationId { get; set; }


        [ForeignKey("CommandeId")]
        [InverseProperty("PasseCommande")]
        public virtual Commande CommandePasse { get; set; } = null!;

        [ForeignKey("ReservationId")]
        [InverseProperty("PasseReservation")]
        public virtual Reservation ReservationPasse { get; set; } = null!;
    }
}
