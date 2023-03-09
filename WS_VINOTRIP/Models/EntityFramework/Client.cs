using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_e_client_clt")]
    public class Client
    {
        [Key]
        [Column("prs_id")]
        public int PersonneId { get; set; }

        [Column("ctl_titreclient", TypeName = "char(5)")]
        public string? TitreClient { get; set; }

        [Required]
        [Column("ctl_prenomclient")]
        public string? PrenomClient { get; set; }

        [Column("ctl_datenaissance", TypeName = "date")]
        public DateTime DateNaissance { get; set; }

        [InverseProperty("ClientCompte")]
        public virtual ICollection<Compte> CompteClient { get; } = new List<Compte>();

        [InverseProperty("ClientFavori")]
        public virtual ICollection<Favori> FavoriClient { get; } = new List<Favori>();

        [InverseProperty("ClientClientCarte")]
        public virtual ICollection<CompteCarte> ClientCarteClient { get; } = new List<CompteCarte>();

        [InverseProperty("ClientHistoriqueCadeau")]
        public virtual ICollection<HistoriqueCadeau> HistoriqueCadeauClient { get; } = new List<HistoriqueCadeau>();

        [ForeignKey("PersonneId")]
        [InverseProperty("ClientPersonne")]
        public virtual Personne PersonneClient { get; set; } = null!;
    }
}