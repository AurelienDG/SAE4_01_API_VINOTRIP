using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_e_partenairehebergement_pth")]
    public partial class PartenaireHebergement
    {
        //Property

        [Key, Column("pth_id"), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PartenaireHebergementId { get; set; }

        [Required, Column("ptn_id")]
        public int PersonneId { get; set; }

        [Required, Column("pth_typehebergement"), StringLength(30)]
        public string? TypeHebergement { get; set; }

        [Column("pth_nbchambre")]
        public int? NbChambre { get; set; }

        [Column("pth_etoiles")]
        public int? Etoiles { get; set; }

        //InverseProperty

        [ForeignKey("PersonneId")]
        [InverseProperty("PartenairesHebergementPartenaire")]
        public virtual Partenaire? PartenairePartenaireHebergement { get; set; }

    }
}
