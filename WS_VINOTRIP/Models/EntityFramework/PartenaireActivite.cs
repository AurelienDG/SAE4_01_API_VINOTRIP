using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_e_partenaireactivite_pta")]
    public class PartenaireActivite
    {
        [Key]
        [Column("pta_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PartenaireActiviteId { get; set; }

        [Required]
        [Column("ptn_id")]
        public int PersonneId { get; set; }

        [Required]
        [StringLength(30)]
        [Column("pta_typeactivite")]
        public string? TypeActivite { get; set; }

        [StringLength(100)]
        [Column("pta_lieurdv")]
        public string? LieuRdv { get; set; }

        [ForeignKey("PersonneId")]
        [InverseProperty("PartenairePartenaireActivite")]
        public virtual Partenaire PartenaireActivitePartenaire { get; set; } = null!;

    }
}
