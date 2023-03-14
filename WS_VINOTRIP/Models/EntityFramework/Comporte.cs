using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_j_comporte_cpt")]
    public partial class Comporte
    {
        //Property

        [Required, Column("sjr_id")]
        public int SejourId { get; set; }

        [Required, Column("cpp_id")]
        public int CatParticipantId { get; set; }

        //InverseProperty

        [ForeignKey("SejourId")]
        [InverseProperty("ComporteSejour")]
        public virtual Sejour? SejourComporte { get; set; }

        [ForeignKey("CatParticipantId")]
        [InverseProperty("ComporteCatParticipant")]
        public virtual CatParticipant? CatParticipantComporte { get; set; }
    }
}
