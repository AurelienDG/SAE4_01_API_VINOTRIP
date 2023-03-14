using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_e_commande_cmd")]
    public partial class Commande
    {
        //Property

        [Key, Column("cmd_id"), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CommandeId { get; set; }

        [Required, Column("prs_id")]
        public int PersonneId { get; set; }

        [Required, Column("cmd_datefacture", TypeName = "date")]
        public DateTime DateFacture { get; set; }

        [Column("cmd_montantreduction")]
        public int? MontantReduction { get; set; }

        //InverseProperty

        [ForeignKey("PersonneId")]
        [InverseProperty("CommandeUser")]
        public virtual User? UserCommande { get; set; }

        [InverseProperty("CommandePasse")]
        public virtual ICollection<Passe>? PasseCommande { get; }

    }
}
