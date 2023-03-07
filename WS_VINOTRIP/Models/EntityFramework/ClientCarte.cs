using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_e_clientcarte_clc")]
    public partial class ClientCarte
    {
        [Required]
        [Column("ctl_id")]
        public int PersonneId { get; set; }

        [Required]
        [Column("rcb_id")]
        public int CarteId { get; set; }

        [ForeignKey("PersonneId")]
        [InverseProperty("ClientCarteClient")]
        public virtual Client ClientClientCarte { get; set; } = null!;

        [ForeignKey("CarteId")]
        [InverseProperty("ClientCarteRefCarteBancaire")]
        public virtual RefCarteBancaire RefCarteBancaireClientCarte { get; set; } = null!;
    }
}
