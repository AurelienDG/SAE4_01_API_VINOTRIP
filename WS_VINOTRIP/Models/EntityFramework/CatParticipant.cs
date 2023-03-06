using System.ComponentModel.DataAnnotations.Schema;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_e_catparticipant_cpp")]
    public partial class CatParticipant
    {
        public int CatParticipantId { get; set; }
        public string? LibelleCatVignoble { get; set; }
        public int LienId { get; set; }

        [InverseProperty("CatParticipantConcerne")]
        public virtual ICollection<Concerne> ConcerneCatParticipant { get; set; } = new List<Concerne>();
    }
}
