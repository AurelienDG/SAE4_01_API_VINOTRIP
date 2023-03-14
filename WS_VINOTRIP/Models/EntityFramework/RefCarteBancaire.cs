using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_e_refcartebancaire_rcb")]
    public partial class RefCarteBancaire
    {
        //Property

        [Key, Column("rcb_id"), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CarteId { get; set; }

        [Required, Column("rcb_numcarte"), StringLength(250)]
        public string? NumCarte { get; set; }

        [Required, Column("rcb_dateexpirationcarte", TypeName = "date")]
        public DateTime DateExpirationCarte { get; set; }

        [Required, Column("rcb_nomcarte"), StringLength(30)]
        public string? NomCarte { get; set; }

        //InverseProperty

        [InverseProperty("RefCarteBancaireCompteCarte")]
        public virtual ICollection<CompteCarte>? CompteCarteRefCarteBancaire { get; }
    }
}
