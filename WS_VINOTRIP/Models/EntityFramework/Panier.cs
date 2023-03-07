using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_e_panier_pnr")]
    public partial class Panier
    {
        [Key]
        [Required]
        [Column("pnr_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PersonneId { get; set; }

        [Required]
        [Column("sjr_id")]
        public int SejourId { get; set; }

        [Required]
        [Column("pnr_nbadultes")]
        public int NbAdultes { get; set; }

        [Required]
        [Column("pnr_nbenfants")]
        public int NbEnfants{ get; set; }

        [Required]
        [Column("pnr_nbchambres")]
        public int NbChambres { get; set; }

        [Required]
        [Column("pnr_offert")]
        public bool Offert { get; set; }

        [Required]
        [Column("pnr_prixtotal", TypeName = "numeric(9,2)")]
        public string PrixTotal { get; set; }

        [Column("pnr_datesejour", TypeName = "date")]
        public DateTime DateSejour { get; set; }

        [ForeignKey("SejourId")]
        [InverseProperty("PanierSejour")]
        public virtual Sejour SejourPanier { get; set; } = null!;

        [ForeignKey("CompteId")]
        [InverseProperty("PanierCompte")]
        public virtual Compte ComptePanier { get; set; } = null!;
    }
}
