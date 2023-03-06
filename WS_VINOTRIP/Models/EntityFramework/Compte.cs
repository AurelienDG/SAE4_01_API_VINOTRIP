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
        public int CompteId { get; set; }

        [Required]
        [Column("mdp_id")]
        public int MdpId { get; set; }

        [Required]
        [Column("tpc_id")]
        public int TypeCompteId { get; set; }

        [Required]
        [Column("prs_id")]
        public int PersonneId { get; set; }

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

        [ForeignKey("TypeCompteId")]
        [InverseProperty("CompteTypeCompte")]
        public virtual Compte TypeCompteCompte { get; set; } = null!;

        [ForeignKey("MdpId")]
        [InverseProperty("CompteMDP")]
        public virtual Compte MDPCompte { get; set; } = null!;

        [ForeignKey("PersonneId")]
        [InverseProperty("ComptePersonne")]
        public virtual Compte PersonneCompte { get; set; } = null!;

        [InverseProperty("ComptePanier")]
        public virtual ICollection<Panier> PanierCompte { get; } = new List<Panier>();
    }
}
