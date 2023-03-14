using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_e_lien_len")]
    public partial class Lien
    {
        //Property

        [Key, Column("len_id"), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LienId { get; set; }

        [Required, Column("len_url"), StringLength(150)]
        public string? Url { get; set; }

        [Required, Column("len_type"), StringLength(30)]
        public string? Type { get; set; }

        //InverseProperty

        [InverseProperty("LienVignoble")]
        public virtual ICollection<Vignoble>? VignobleLien { get; }

        [InverseProperty("LienCatSejour")]
        public virtual ICollection<CatSejour>? CatSejourLien { get; }

        [InverseProperty("LienCatParticipant")]
        public virtual ICollection<CatParticipant>? CatParticipantLien { get; }

        [InverseProperty("LienLienElementVignoble")]
        public virtual ICollection<LienElementVignoble>? LienElementVignobleLien { get; }

        [InverseProperty("LienLienSejour")]
        public virtual ICollection<LienSejour>? LienSejourLien { get; } 

        [InverseProperty("LienLienRouteDesVins")]
        public virtual ICollection<LienRouteDesVins>? LienRouteDesVinsLien { get; }

        [InverseProperty("LienLienEtape")]
        public virtual ICollection<LienEtape>? LienEtapeLien { get; }

        [InverseProperty("LienContient")]
        public virtual ICollection<Contient>? ContientLien { get; }

        [InverseProperty("LienLienAvis")]
        public virtual ICollection<LienAvis>? LiensAvisLien { get; }


    }
}
