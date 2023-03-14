using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_e_catparticipant_cpp")]
    public partial class CatParticipant
    {
        //Property

        [Key, Column("cpp_id"), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CatParticipantId { get; set; }

        [Required, Column("vgb_titre"), StringLength(30)]
        public string? Libelle { get; set; }

        [Required, Column("len_id")]
        public int LienId { get; set; }

        [InverseProperty("CatParticipantComporte")]
        public virtual ICollection<Comporte>? ComporteCatParticipant { get; }

        [ForeignKey("LienId")]
        [InverseProperty("CatParticipantLien")]
        public virtual Lien? LienCatParticipant { get; set; }
    }
}
