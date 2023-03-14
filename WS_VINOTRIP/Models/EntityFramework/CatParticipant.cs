using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_e_catparticipant_cpp")]
    public partial class CatParticipant
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column("cpp_id")]
        public int CatParticipantId { get; set; }
        [StringLength(30), Required, Column("vgb_titre", TypeName = "varchar(30)")]
        public string? Libelle { get; set; }
        [Column("len_id")]
        public int LienId { get; set; }

        [InverseProperty("CatParticipantComporte")]
        public virtual ICollection<Comporte>? ComporteCatParticipant { get; set; }

        [ForeignKey("LienId")]
        [InverseProperty("CatParticipantLien")]
        public virtual Lien LienCatParticipant { get; set; } = null!;
    }
}
