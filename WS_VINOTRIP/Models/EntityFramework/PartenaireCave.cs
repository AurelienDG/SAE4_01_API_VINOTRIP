using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_e_partenairecave_ptc")]
    public class PartenaireCave
    {
        [Key]
        [Column("ptc_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PartenaireCaveId { get; set; }

        [Required]
        [Column("ptn_id")]
        public int PersonneId { get; set; }

        [Required]
        [StringLength(50)]
        [Column("ptc_typedegustation")]
        public string? TypeDegustation { get; set; }

        [ForeignKey("PersonneId")]
        [InverseProperty("PartenairesCavePartenaire")]
        public virtual Partenaire PartenairePartenaireCave { get; set; } = null!;

    }
}
