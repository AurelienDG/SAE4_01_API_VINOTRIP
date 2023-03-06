using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_e_etape_etp")]
    public partial class Etape
    {
        [Key]
        [Column("etp_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EtapeId { get; set; }

        [Key]
        [Column("sjr_id")]
        public int SejourId { get; set; }

        [Column("etp_titreetape")]
        [Required]
        [StringLength(100)]
        public string? TitreEtape { get; set; }

        [Column("etp_descriptionetape", TypeName = "text")]
        public string? DescriptionEtape { get; set; }

        [ForeignKey("SejourId")]
        [InverseProperty("EtapesSejour")]
        public virtual Sejour SejourEtape { get; set; }

        [InverseProperty("EtapeConcerne")]
        public virtual ICollection<Concerne>? ConcerneEtape { get; set; }
    }
}
