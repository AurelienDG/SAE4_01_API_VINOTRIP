using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_e_comptecarte_cpc")]
    public partial class CompteCarte
    {
        //Property

        [Required, Column("ctl_id")] 
        public int PersonneId { get; set; }

        [Required, Column("rcb_id")]
        public int CarteId { get; set; }

        //InverseProperty

        [ForeignKey("PersonneId")]
        [InverseProperty("CompteCarteUser")]
        public virtual User? UserCompteCarte { get; set; }

        [ForeignKey("CarteId")]
        [InverseProperty("CompteCarteRefCarteBancaire")]
        public virtual RefCarteBancaire? RefCarteBancaireCompteCarte { get; set; }
    }
}
