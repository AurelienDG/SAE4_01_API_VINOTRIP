using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_j_reported_rep")]
    public partial class Reported
    {
        //Property

        [Required, Column("prs_id")]
        public int PersonneId { get; set; }

        [Required, Column("avi_id")]
        public int AvisId { get; set; }

        [Required, Column("rep_a_signale")]
        public bool A_Signale { get; set; }

        //InverseProperty

        [ForeignKey("PersonneId")]
        [InverseProperty("ReportedUser")]
        public virtual User? UserReported { get; set; }

        [ForeignKey("AvisId")]
        [InverseProperty("ReportedAvis")]
        public virtual Avis? AvisReported { get; set; }

    }
}
