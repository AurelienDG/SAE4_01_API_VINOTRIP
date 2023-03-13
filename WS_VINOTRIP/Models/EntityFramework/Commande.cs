using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_e_commande_cmd")]
    public partial class Commande
    {
        [Key, Column("cmd_id"), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CommandeId { get; set; }
        [Required, Column("prs_id")]
        public int PersonneId { get; set; }
        [Column("usr_datenaissance", TypeName = "date")]
        public DateTime DateFacture { get; set; }
        [Required, Column("cmd_montantreduction")]
        public int MontantReduction { get; set; }

        [ForeignKey("PersonneId")]
        [InverseProperty("CommandeCompte")]
        public virtual User CompteCommande { get; set; } = null!;

        [InverseProperty("CommandePasse")]
        public virtual ICollection<Passe> PasseCommande { get; } = new List<Passe>();

    }
}
