using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_e_compte_cmp")]
    public partial class Compte
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

        [InverseProperty("CompteReside")]
        public virtual ICollection<Reside> ResideCompte { get; set; } = new List<Reside>();

        [ForeignKey("TypeCompteId"), InverseProperty("CompteTypeCompte")]
        public virtual TypeCompte TypeCompteCompte { get; set; } = null!;

        [InverseProperty("ComptePanier")]
        public virtual ICollection<Panier> PanierCompte { get; } = new List<Panier>();

        [InverseProperty("CompteReported")]
        public virtual ICollection<Reported> ReportedCompte { get; } = new List<Reported>();

        [InverseProperty("CompteFavori")]
        public virtual ICollection<Favori> FavoriCompte { get; } = new List<Favori>();

        [InverseProperty("CompteCompteCarte")]
        public virtual ICollection<CompteCarte> CompteCarteCompte { get; } = new List<CompteCarte>();

        [InverseProperty("CompteHistoriqueCadeau")]
        public virtual ICollection<HistoriqueCadeau> CompteHistoriqueCadeau { get; } = new List<HistoriqueCadeau>();
        //
        [InverseProperty("CompteCommande")]
        public virtual ICollection<Commande> CommandeCompte { get; } = new List<Commande>();
        
        [ForeignKey("PersonneId")]
        [InverseProperty("ComptePersonne")]
        public virtual Personne PersonneCompte { get; set; } = null!;

    }
}
