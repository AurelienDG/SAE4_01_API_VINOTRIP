using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_e_partenairehebergement_pth")]
    public class PartenaireHebergement
    {
        [Key]
        [Column("pth_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PartenaireHebergementId { get; set; }

        [Required]
        [Column("ptn_id")]
        public int PersonneId { get; set; }

        [Required]
        [StringLength(30)]
        [Column("pth_typehebergement")]
        public string? TypeHebergement { get; set; }

        [Column("pth_nbchambre")]
        public int NbChambre { get; set; }

        [Column("pth_etoileshebergement")]
        public int EtoilesHebergement { get; set; }

        [ForeignKey("PersonneId")]
        [InverseProperty("PartenairePartenaireHebergement")]
        public virtual Partenaire PartenaireHebergementPartenaire { get; set; } = null!;

    }
}
