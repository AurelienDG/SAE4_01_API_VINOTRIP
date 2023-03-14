using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_e_historiquecadeau_htc")]
    public partial class HistoriqueCadeau
    {
        //Property

        [Required, Column("ctl_id")]
        public int PersonneId { get; set; }

        [Required, Column("bcd_id")]
        public int BonCadeauId { get; set; }

        [Required, Column("htc_typecadeau"), StringLength(30)]
        public string? TypeCadeau { get; set; }

        //InverseProperty

        [ForeignKey("PersonneId")]
        [InverseProperty("HistoriqueCadeauUser")]
        public virtual User? UserHistoriqueCadeau { get; set; }

        [ForeignKey("BonCadeauId")]
        [InverseProperty("HistoriqueCadeauBonCadeau")]
        public virtual BonCadeau? BonCadeauHistoriqueCadeau { get; set; }
    }
}
