using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_e_comptecarte_cpc")]
    public partial class CompteCarte
    {
        [Required]
        [Column("ctl_id")]
        public int PersonneId { get; set; }

        [Required]
        [Column("rcb_id")]
        public int CarteId { get; set; }

        [ForeignKey("PersonneId")]
        [InverseProperty("CompteCarteCompte")]
        public virtual User CompteCompteCarte { get; set; } = null!;

        [ForeignKey("CarteId")]
        [InverseProperty("CompteCarteRefCarteBancaire")]
        public virtual RefCarteBancaire RefCarteBancaireCompteCarte { get; set; } = null!;
    }
}
