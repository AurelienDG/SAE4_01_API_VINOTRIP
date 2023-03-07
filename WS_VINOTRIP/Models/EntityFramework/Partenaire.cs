using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_e_partenaire_ptn")]
    public class Partenaire
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("prs_id")]
        public int PersonneId { get; set; }

        [Column("ptn_telpartenaire", TypeName = "char(10)")]
        [Required]
        public string? TelPartenaire { get; set; }

        [InverseProperty("ElementEtapeDuPartenaire")]
        public virtual ICollection<ElementEtape>? ElementsEtapeDuPartenaire { get; set; } = null!;

        [InverseProperty("PartenairePartenaireRestaurant")]
        public virtual ICollection<PartenaireRestaurant>? PartenaireRestaurantPartenaire { get; set; } = null!;

        [InverseProperty("PartenairePartenaireCave")]
        public virtual ICollection<PartenaireCave>? PartenaireCavePartenaire { get; set; } = null!;

        [InverseProperty("PartenairePartenaireHebergement")]
        public virtual ICollection<PartenaireHebergement>? PartenaireHebergementPartenaire { get; set; } = null!;

        [InverseProperty("PartenairePartenaireActivite")]
        public virtual ICollection<PartenaireActivite>? PartenaireActivitePartenaire { get; set; } = null!;
    }
}
