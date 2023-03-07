using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_e_avis_avi")]
    public partial class Avis
    {
        [Key]
        [Column("avi_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AvisId { get; set; }

        [Column("prs_id")]
        [Required]
        public int PersonneId { get; set; }

        [Column("avi_titre")]
        [StringLength(50)]
        [Required]
        public string? Titre { get; set; }

        [Column("avi_note")]
        [Required]
        public int Note { get; set; }

        [Column("avi_desvription", TypeName = "text")]
        [Required]
        public string? Description { get; set; }

        [Column("avi_dateavis", TypeName = "date")]
        [Required]
        public DateTime DateAvis { get; set; }

        [Column("sjr_id")]
        [Required]
        public int SejourId { get; set; }

        [Required]
        [Column("avi_reponse", TypeName = "text")]
        public string? Reponse { get; set; }

        [ForeignKey("SejourId")]
        [InverseProperty("AvisSejour")]
        public virtual Sejour SejourAvis { get; set; } = null!;

        [ForeignKey("PersonneId")]
        [InverseProperty("AvisPersonne")]
        public virtual Personne PersonneAvis { get; set; } = null!;

        [InverseProperty("AvisReported")]
        public virtual ICollection<Reported> ReportedAvis { get; } = new List<Reported>();

        [InverseProperty("AvisLienAvis")]
        public virtual ICollection<LiensAvis> LiensAvisAvis { get; } = new List<LiensAvis>();

    }
}
