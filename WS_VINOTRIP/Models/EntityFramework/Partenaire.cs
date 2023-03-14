using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_e_partenaire_ptn")]
    public class Partenaire
    {
        [Key]
        [Column("prs_id")]
        public int PersonneId { get; set; }

        [Column("ptn_tel", TypeName = "char(10)")]
        [Required]
        public string? Tel { get; set; }

        [InverseProperty("PartenaireElementEtape")]
        public virtual ICollection<ElementEtape>? ElementsEtapePartenaire { get; set; } = null!;

        [InverseProperty("PartenairePartenaireRestaurant")]
        public virtual ICollection<PartenaireRestaurant>? PartenairesRestaurantPartenaire { get; set; } = null!;

        [InverseProperty("PartenairePartenaireCave")]
        public virtual ICollection<PartenaireCave>? PartenairesCavePartenaire { get; set; } = null!;

        [InverseProperty("PartenairePartenaireHebergement")]
        public virtual ICollection<PartenaireHebergement>? PartenairesHebergementPartenaire { get; set; } = null!;

        [InverseProperty("PartenairePartenaireActivite")]
        public virtual ICollection<PartenaireActivite>? PartenairesActivitePartenaire { get; set; } = null!;

        [ForeignKey("PersonneId")]
        [InverseProperty("PartenairePersonne")]
        public virtual Personne? PersonnePartenaire { get; set; }
    }
}
