using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_e_partenairecave_ptc")]
    public partial class PartenaireCave
    {
        //Property

        [Key, Column("ptc_id"), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PartenaireCaveId { get; set; }

        [Required, Column("ptn_id")]
        public int PersonneId { get; set; }

        [Required, Column("ptc_typedegustation"), StringLength(50)]
        public string? TypeDegustation { get; set; }

        //InverseProperty

        [ForeignKey("PersonneId")]
        [InverseProperty("PartenairesCavePartenaire")]
        public virtual Partenaire? PartenairePartenaireCave { get; set; }

    }
}
