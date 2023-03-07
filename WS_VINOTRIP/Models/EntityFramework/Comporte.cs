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

        [Column("cpp_id")]
        public int CatParticipantId { get; set; }

        [ForeignKey("SejourId")]
        [InverseProperty("ComporteSejour")]
        public virtual Sejour SejourComporte { get; set; } = null!;

        [ForeignKey("CatParticipantId")]
        [InverseProperty("ComporteCatParticipant")]
        public virtual CatParticipant CatParticipantComporte { get; set; } = null!;
    }
}
