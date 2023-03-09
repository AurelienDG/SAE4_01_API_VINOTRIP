using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_j_concerne_ccr")]
    public partial class Concerne
    {
        [Column("etp_id")]
        public int EtapeId { get; set; }

        [Column("ele_id")]
        public int ElementId { get; set; }
        
        [Column("ccr_horaire", TypeName = "time"), Required]
        public TimeOnly Horaire { get; set; }

        [InverseProperty("ConcerneEtape"), ForeignKey("EtapeId")]
        public virtual Etape EtapeConcerne { get; set; } = null!;

        [InverseProperty("ConcerneElementEtape"), ForeignKey("ElementId")]
        public virtual ElementEtape ElementEtapeConcerne { get; set; } = null!;
    }
}