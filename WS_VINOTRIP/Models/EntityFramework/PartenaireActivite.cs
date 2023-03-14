using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_e_partenaireactivite_pta")]
    public partial class PartenaireActivite
    {
        //Property

        [Key, Column("pta_id"), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PartenaireActiviteId { get; set; }

        [Required, Column("ptn_id")]
        public int PersonneId { get; set; }

        [Required, Column("pta_typeactivite"), StringLength(30)]
        public string? TypeActivite { get; set; }

        [Column("pta_lieurdv"), StringLength(100)]
        public string? LieuRdv { get; set; }

        //InverseProperty

        [ForeignKey("PersonneId")]
        [InverseProperty("PartenairesActivitePartenaire")]
        public virtual Partenaire? PartenairePartenaireActivite { get; set; };

    }
}
