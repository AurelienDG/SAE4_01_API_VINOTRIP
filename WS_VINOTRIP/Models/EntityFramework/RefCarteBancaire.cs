using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_e_refcartebancaire_rcb")]
    public class RefCarteBancaire
    {
        [Key]
        [Required]
        [Column("rcb_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CarteId { get; set; }

        [Required]
        [StringLength(250)]
        [Column("rcb_numcarte")]
        public string? NumCarte { get; set; }

        [Required]
        [Column("rcb_dateexpirationcarte", TypeName = "date")]
        public DateTime DateExpirationCarte { get; set; }

        [Required]
        [StringLength(30)]
        [Column("rcb_nomcarte")]
        public string? NomCarte { get; set; }

        [InverseProperty("RefCarteBancaireClientCarte")]
        public virtual ClientCarte ClientCarteRefCarteBancaire { get; set; } = null!;
    }
}
