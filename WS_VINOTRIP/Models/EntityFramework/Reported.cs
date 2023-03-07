using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_j_reported_rep")]
    public partial class Reported
    {
        [Column("cmp_id")]
        [Required]
        public int CompteId { get; set; }

        [Column("avi_id")]
        [Required]
        public int AvisId { get; set; }

        [Column("rep_a_signale")]
        [Required]
        public bool A_Signale { get; set; }

        [ForeignKey("CompteId")]
        [InverseProperty("ReportedCompte")]
        public virtual Compte CompteReported { get; set; } = null!;

        [ForeignKey("AvisId")]
        [InverseProperty("ReportedAvis")]
        public virtual Avis AvisReported { get; set; } = null!;

    }
}
