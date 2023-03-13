using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_e_user_usr")]
    public partial class User
    {
        [Key, Required, Column("prs_id")]
        public int PersonneId { get; set; }

        [Required, Column("tpc_id")]
        public int TypeCompteId { get; set; }

        [Required, Column("cmp_telcompte", TypeName = "char(10)"), RegularExpression(@"^0[0-9]{9}$", ErrorMessage = "Numéro de téléphone non valide")]
        public string? Tel { get; set; }

        [Required, Column("cmp_newsletter")]
        public bool Newsletter { get; set; }

        [Required, Column("cmp_estverifie")]
        public bool EstVerifie { get; set; }

        [Required, Column("cmp_estadmin")]
        public bool EstAdmin { get; set; }

        [Required, Column("cmp_dateconnexion", TypeName = "date")]
        public DateTime DateConnexion { get; set; }

        [Column("cmp_titreclient", TypeName = "char(5)")]
        public string? Titre { get; set; }

        [Required, Column("cmp_prenomclient")]
        public string? Prenom { get; set; }

        [Column("cmp_datenaissance", TypeName = "date")]
        public DateTime DateNaissance { get; set; }

        [Required, Column("cmp_mdp"), StringLength(100)]
        public string? Mdp { get; set; }

        [InverseProperty("UserReside")]
        public virtual ICollection<Reside> ResideUser { get; set; } = new List<Reside>();

        [ForeignKey("TypeCompteId"), InverseProperty("UserTypeCompte")]
        public virtual TypeCompte TypeCompteUser { get; set; } = null!;

        [InverseProperty("UserPanier")]
        public virtual ICollection<Panier> PanierUser { get; } = new List<Panier>();

        [InverseProperty("UserReported")]
        public virtual ICollection<Reported> ReportedUser { get; } = new List<Reported>();

        [InverseProperty("UserFavori")]
        public virtual ICollection<Favori> FavoriUser { get; } = new List<Favori>();

        [InverseProperty("UserCompteCarte")]
        public virtual ICollection<CompteCarte> CompteCarteUser { get; } = new List<CompteCarte>();

        [InverseProperty("UserHistoriqueCadeau")]
        public virtual ICollection<HistoriqueCadeau> HistoriqueCadeauUser { get; } = new List<HistoriqueCadeau>();
        
        [InverseProperty("UserCommande")]
        public virtual ICollection<Commande> CommandeUser { get; } = new List<Commande>();
        
        [ForeignKey("PersonneId")]
        [InverseProperty("UserPersonne")]
        public virtual Personne PersonneUser { get; set; } = null!;

    }
}
