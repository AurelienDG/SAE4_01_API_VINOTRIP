using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_e_lien_len")]
    public partial class Lien
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column("len_id")]
        public int LienId { get; set; }

        [Required, Column("len_url"), StringLength(150)]
        public string? Url { get; set; }

        [Required, Column("len_type"), StringLength(30)]
        public string? Type { get; set; }

        [InverseProperty("LienVignoble")]
        public virtual ICollection<Vignoble> VignobleLien { get; set; } = new List<Vignoble>();

        [InverseProperty("LienCatSejour")]
        public virtual ICollection<CatSejour> CatSejourLien { get; set; } = new List<CatSejour>();

        [InverseProperty("LienCatParticipant")]
        public virtual ICollection<CatParticipant> CatParticipantLien { get; set; } = new List<CatParticipant>();

        [InverseProperty("LienLienElementVignoble")]
        public virtual ICollection<LienElementVignoble> LienElementVignobleLien { get; set; } = new List<LienElementVignoble>();

        [InverseProperty("LienLienSejour")]
        public virtual ICollection<LienSejour> LienSejourLien { get; set; } = new List<LienSejour>();

        [InverseProperty("LienLienRouteDesVins")]
        public virtual ICollection<LienRouteDesVins> LienRouteDesVinsLien { get; set; } = new List<LienRouteDesVins>();

        [InverseProperty("LienLienEtape")]
        public virtual ICollection<LienEtape> LienEtapeLien { get; set; } = new List<LienEtape>();

        [InverseProperty("LienContient")]
        public virtual ICollection<Contient> ContientLien { get; set; } = new List<Contient>();

        [InverseProperty("LienLienAvis")]
        public virtual ICollection<LienAvis> LiensAvisLien { get; set; } = new List<LienAvis>();


    }
}
