using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_e_compte_cmp")]
    public partial class Compte
    {
        [Key]
        [Required]
        [Column("cmp_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCompte { get; set; }

        [Key]
        [Required]
        [Column("mdp_id")]
        public int IdMdp { get; set; }

        [Key]
        [Required]
        [Column("tpc_id")]
        public int IdTypeCompte { get; set; }

        [Key]
        [Required]
        [Column("prs_id")]
        public int IdPersonne { get; set; }

        [Required]
        [Column("cmp_telcompte", TypeName = "char(10)")]
        [RegularExpression(@"^0[0-9]{9}$", ErrorMessage = "…")]
        public string? TelCompte { get; set; }

        [Required]
        [Column("cmp_newsletter")]
        public bool Newsletter { get; set; }

        [Required]
        [Column("cmp_estverifie")]
        public bool EstVerifie { get; set; }

        [Required]
        [Column("cmp_estadmin")]
        public bool EstAdmin { get; set; }

        [Required]
        [Column("cmp_dateconnexion", TypeName = "date")]
        public DateTime DateConnexion { get; set; }

        [ForeignKey("IdTypeCompte")]
        [InverseProperty("TypeComptes")]
        public virtual Compte CompteTypeCompte { get; set; } = null!;

        [ForeignKey("IdMdp")]
        [InverseProperty("MotDePasses")]
        public virtual Compte CompteMDP { get; set; } = null!;

        [ForeignKey("IdPersonne")]
        [InverseProperty("Personnes")]
        public virtual Compte ComptePersonne { get; set; } = null!;
    }
}
