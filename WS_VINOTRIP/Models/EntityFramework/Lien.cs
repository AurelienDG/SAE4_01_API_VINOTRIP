using System.ComponentModel.DataAnnotations.Schema;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_e_lien_len")]
    public partial class Lien
    {
        public int LienId { get; set; }
        public string? url { get; set; }
        public string? type { get; set; }


        [InverseProperty("LienVignoble")]
        public virtual ICollection<Vignoble> VignobleLien { get; set; } = new List<Vignoble>();
        
        [InverseProperty("LienCatSejour")]
        public virtual ICollection<CatSejour> CatSejourLien { get; set; } = new List<CatSejour>();

        [InverseProperty("LienCatParticipant")]
        public virtual ICollection<CatParticipant> CatParticipantLien { get; set; } = new List<CatParticipant>();

    }
}
