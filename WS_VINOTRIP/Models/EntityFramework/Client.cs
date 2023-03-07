using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_e_client_clt")]
    public class Client
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("prs_id")]
        public int PersonneId { get; set; }

        [Required]
        [Column("ctl_titreclient", TypeName = "char(5)")]
        public string? TitreClient { get; set; }

        [Required]
        [Column("ctl_prenomclient")]
        public string? PrenomClient { get; set; }

        [InverseProperty("ClientCompte")]
        public virtual ICollection<Compte> CompteClient { get; } = new List<Compte>();

        [InverseProperty("ClientFavori")]
        public virtual ICollection<Favori> FavoriClient { get; } = new List<Favori>();

        [ForeignKey("PersonneId")]
        [InverseProperty("ClientPersonne")]
        public virtual Personne PersonneClient { get; set; } = null!;
    }
}