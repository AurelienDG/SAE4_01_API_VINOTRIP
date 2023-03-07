using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_e_lien_len")]
    public partial class Lien
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column("len_id")]
        public int LienId { get; set; }
        [StringLength(150), Required, Column("len_url", TypeName = "varchar(150)")]
        public string? url { get; set; }
        [StringLength(30), Required, Column("len_type", TypeName = "varchar(30)")]
        public string? type { get; set; }


        [InverseProperty("LienVignoble")]
        public virtual ICollection<Vignoble> VignobleLien { get; set; } = new List<Vignoble>();

        [InverseProperty("LienCatSejour")]
        public virtual ICollection<CatSejour> CatSejourLien { get; set; } = new List<CatSejour>();

        [InverseProperty("LienCatParticipant")]
        public virtual ICollection<CatParticipant> CatParticipantLien { get; set; } = new List<CatParticipant>();

        [InverseProperty("ElementVignobleLienLien")]
        public virtual ICollection<LienElementVignoble> LienElementVignobleLien { get; set; } = new List<LienElementVignoble>();

        [InverseProperty("LienLienSejour")]
        public virtual ICollection<LienSejour> LienSejourLien { get; set; } = new List<LienSejour>();

        [InverseProperty("LienLienRouteDesVins")]
        public virtual ICollection<LienRouteDesVins> LienRouteDesVinsLien { get; set; } = new List<LienRouteDesVins>();

    }
}
