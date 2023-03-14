using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_e_avis_avi")]
    public partial class Avis
    {
        //Property

        [Key, Column("avi_id"), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AvisId { get; set; }

        [Required, Column("prs_id")]
        public int PersonneId { get; set; }

        [Required, Column("sjr_id")]
        public int SejourId { get; set; }

        [Required, Column("avi_titre"), StringLength(50)]
        public string? Titre { get; set; }

        [Required, Column("avi_note")]
        public int Note { get; set; }

        [Required, Column("avi_description", TypeName = "text")]
        public string? Description { get; set; }

        [Required, Column("avi_dateavis", TypeName = "date")]
        public DateTime DateAvis { get; set; }

        [Column("avi_reponse", TypeName = "text")]
        public string? Reponse { get; set; }

        //InverseProperty

        [ForeignKey("SejourId")]
        [InverseProperty("AvisSejour")]
        public virtual Sejour? SejourAvis { get; set; }

        [ForeignKey("PersonneId")]
        [InverseProperty("AvisPersonne")]
        public virtual Personne? PersonneAvis { get; set; }

        [InverseProperty("AvisReported")]
        public virtual ICollection<Reported>? ReportedAvis { get; }

        [InverseProperty("AvisLienAvis")]
        public virtual ICollection<LienAvis>? LiensAvisAvis { get; }

    }
}
