using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_e_compte_cmp")]
    public partial class Compte
    {
        [Key]
        [Column("cmp_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCompte { get; set; }

        [Key]
        [Column("mdp_id")]
        public int IdMdp { get; set; }

        [Key]
        [Column("tpc_id")]
        public int IdTypeCompte { get; set; }

        [Key]
        [Column("prs_id")]
        public int IdPersonne { get; set; }

        [Column("cmp_telcompte", TypeName = "char(10)")]
        [RegularExpression(@"^0[0-9]{9}$", ErrorMessage = "…")]
        public string? TelCompte { get; set; }

        [Column("cmp_newsletter")]
        public bool Newsletter { get; set; }

        [Column("cmp_estverifie")]
        public bool EstVerifie { get; set; }

        [Column("cmp_estadmin")]
        public bool EstAdmin { get; set; }

        [Column("cmp_dateconnexion", TypeName = "date")]
        public DateTime DateConnexion { get; set; }
    }
}
