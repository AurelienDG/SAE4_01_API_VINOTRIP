using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_e_sejourcadeau_sjc")]
    public partial class SejourCadeau
    {
        //Property

        [Key, Column("bcd_id")]        
        public int BonCadeauId { get; set; }

        [Required, Column("sjr_id")]
        public int SejourId { get; set; }

        [Required, Column("sjc_choixdestination"), StringLength(100)]
        public string? ChoixDestination { get; set; }

        //InverseProperty

        [ForeignKey("BonCadeauId")]
        [InverseProperty("SejourCadeauBonCadeau")]
        public virtual BonCadeau? BonCadeauSejourCadeau { get; set; }

        [ForeignKey("SejourId")]
        [InverseProperty("SejourCadeauSejour")]
        public virtual Sejour? SejourSejourCadeau{ get; set; }
    }
}
