using System.ComponentModel.DataAnnotations.Schema;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_j_comporte_cpt")]
    public partial class Comporte
    {
        [ForeignKey("CatVignobleId")]
        [InverseProperty("CatVignobleSejour")]
        public virtual Sejour SejourConcerne { get; set; } = null!;

        [ForeignKey("CatVignobleId")]
        [InverseProperty("ConcerneCatParticipant")]
        public virtual CatParticipant CatParticipantConcerne { get; set; } = null!;
    }
}
