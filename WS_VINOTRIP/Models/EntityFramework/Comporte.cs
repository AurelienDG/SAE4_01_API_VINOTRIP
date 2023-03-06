using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_j_comporte_cpt")]
    public partial class Comporte
    {
        [Key]
        [Column("sjr_id")]
        public int SejourId { get; set; }

        [Key]
        [Column("cpp_id")]
        public int CatParticipantId { get; set; }

        [ForeignKey("SejourId")]
        [InverseProperty("CatVignobleSejour")]
        public virtual Sejour SejourConcerne { get; set; } = null!;

        [ForeignKey("CatParticipantId")]
        [InverseProperty("ConcerneCatParticipant")]
        public virtual CatParticipant CatParticipantConcerne { get; set; } = null!;
    }
}
