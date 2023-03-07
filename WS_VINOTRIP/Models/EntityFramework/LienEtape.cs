using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_j_lienetape_lep")]
    public partial class LienEtape
    {
        [Key, Column("etp_id")]
        public int EtapeId { get; set; }
        [Key, Column("len_id")]
        public int LienId { get; set; }

        [ForeignKey("EtapeId")]
        [InverseProperty("LienEtapeEtape")]
        public virtual Etape EtapeLienEtape { get; set; } = null!;

        [ForeignKey("LienId")]
        [InverseProperty("LienEtapeLien")]
        public virtual Lien LienLienEtape { get; set; } = null!;
    }
}
