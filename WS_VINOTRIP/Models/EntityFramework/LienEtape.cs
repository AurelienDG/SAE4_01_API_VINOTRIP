using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_j_lienetape_lep")]
    public partial class LienEtape
    {
        //Property

        [Required, Column("etp_id")]
        public int EtapeId { get; set; }

        [Required, Column("len_id")]
        public int LienId { get; set; }

        //InverseProperty

        [ForeignKey("EtapeId")]
        [InverseProperty("LienEtapeEtape")]
        public virtual Etape? EtapeLienEtape { get; set; }

        [ForeignKey("LienId")]
        [InverseProperty("LienEtapeLien")]
        public virtual Lien? LienLienEtape { get; set; }
    }
}
