using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_e_motdepasse_mdp")]
    public partial class MotDePasse
    {
        [Key]
        [Required]
        [Column("mdp_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdMdp { get; set; }

        [Required]
        [Column("mdp_mdp")]
        [StringLength(100)]
        public string? Mdp { get; set; }

        [InverseProperty("CompteMDP")]
        public virtual ICollection<Compte> MotDePasses { get; } = new List<Compte>();
    }
}
