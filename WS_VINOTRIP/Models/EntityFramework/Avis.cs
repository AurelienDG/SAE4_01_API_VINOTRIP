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

        [Key]
        [Column("prs_id")]
        public int PersonneId { get; set; }

        [Column("avi_titreavis")]
        [StringLength(50)]
        [Required]
        public string? TitreAvis { get; set; }

        [Column("avi_note")]
        [Required]
        public int Note { get; set; }

        [Column("avi_desvriptionavis", TypeName = "text")]
        [Required]
        public string? DescriptionAvis { get; set; }

        [Column("avi_dateavis", TypeName = "date")]
        [Required]
        public DateTime DateAvis { get; set; }

        [Column("sjr_id")]
        [Required]
        public int SjourId { get; set; }

        [Required]
        [Column("avi_reponse", TypeName = "text")]
        public string? Reponse { get; set; }


    }
}
