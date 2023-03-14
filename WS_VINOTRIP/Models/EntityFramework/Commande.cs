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
        [Column("cmd_datefacture", TypeName = "date")]
        public DateTime DateFacture { get; set; }
        [Column("cmd_montantreduction")]
        public int? MontantReduction { get; set; }

        [ForeignKey("PersonneId")]
        [InverseProperty("CommandeUser")]
        public virtual User UserCommande { get; set; } = null!;

        [InverseProperty("CommandePasse")]
        public virtual ICollection<Passe> PasseCommande { get; } = new List<Passe>();

    }
}
