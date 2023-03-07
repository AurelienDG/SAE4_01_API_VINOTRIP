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

        [Column("etp_titre")]
        [Required]
        [StringLength(100)]
        public string? Titre { get; set; }

        [Column("etp_description", TypeName = "text")]
        public string? Description { get; set; }

        [ForeignKey("SejourId")]
        [InverseProperty("EtapesSejour")]
        public virtual Sejour SejourEtape { get; set; } = null!;

        [InverseProperty("EtapeConcerne")]
        public virtual ICollection<Concerne>? ConcerneEtape { get; set; } = null!;
    }
}
