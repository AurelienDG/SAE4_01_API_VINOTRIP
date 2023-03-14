using System.ComponentModel.DataAnnotations.Schema;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_j_reside_rsd")]
    public partial class Reside
    {
        //Property

        [Column("prs_id")]
        public int PersonneId { get; set; }
        [Column("ads_id")]
        public int AdresseId { get; set; }

        //InverseProperty

        [ForeignKey("PersonneId")]
        [InverseProperty("ResideUser")]
        public virtual User? UserReside { get; set; }

        [ForeignKey("AdresseId")]
        [InverseProperty("ResideAdresse")]
        public virtual Adresse? AdresseReside { get; set; }
    }
}
