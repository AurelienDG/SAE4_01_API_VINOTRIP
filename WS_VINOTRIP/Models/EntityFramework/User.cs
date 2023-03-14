using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_e_user_usr")]
    public partial class User
    {
        //Property

        [Key, Column("prs_id")]
        public int PersonneId { get; set; }

        [Required, StringLength(30), Column("usr_pseudo")]
        public string? Pseudo { get; set; }

        [Required, Column("tpc_id")]
        public int TypeCompteId { get; set; }

        [Column("usr_tel", TypeName = "char(10)"), RegularExpression(@"^0[0-9]{9}$", ErrorMessage = "Numéro de téléphone non valide")]
        public string? Tel { get; set; }

        [Required, Column("usr_newsletter")]
        public bool Newsletter { get; set; }

        [Required, Column("usr_estverifie")]
        public bool EstVerifie { get; set; }

        [Required, Column("usr_estadmin")]
        public string? UserRole { get; set; }

        [Required, Column("usr_dateconnexion", TypeName = "date")]
        public DateTime DateConnexion { get; set; }

        [Column("usr_titreclient"), StringLength(5)]
        public string? Titre { get; set; }

        [Required, Column("usr_prenomclient")]
        public string? Prenom { get; set; }

        [Column("usr_datenaissance", TypeName = "date")]
        public DateTime DateNaissance { get; set; }

        [Required, Column("usr_mdp"), StringLength(100)]
        public string? Mdp { get; set; }

        //InverseProperty

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
        public virtual Personne? PersonneUser { get; set; };
    }
}