using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_j_concerne_ccr")]
    public partial class Concerne
    {
        [Key]
        [Column("etp_id")]
        public int EtapeId { get; set; }

        [Key]
        [Column("ele_id")]
        public int ElementId { get; set; }
        
        [Column("ccr_horaire", TypeName = "time")]
        [Required]
        public DateTime Horaire { get; set; }

        [ForeignKey("EtapeId")]
        [InverseProperty("ConcerneEtape")]
        public virtual Sejour EtapeConcerne { get; set; }

        [ForeignKey("ElementId")]
        [InverseProperty("ConcerneElementEtape")]
        public virtual Sejour ElemenEtapeConcerne{ get; set; }
    }
}