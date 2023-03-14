using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_e_partenaire_ptn")]
    public partial class Partenaire
    {
        //Property

        [Key, Column("prs_id")]
        public int PersonneId { get; set; }

        [Column("ptn_tel", TypeName = "char(10)")]
        public string? Tel { get; set; }

        //InverseProperty

        [InverseProperty("PartenaireElementEtape")]
        public virtual ICollection<ElementEtape>? ElementsEtapePartenaire { get; set; }

        [InverseProperty("PartenairePartenaireRestaurant")]
        public virtual ICollection<PartenaireRestaurant>? PartenairesRestaurantPartenaire { get; set; }

        [InverseProperty("PartenairePartenaireCave")]
        public virtual ICollection<PartenaireCave>? PartenairesCavePartenaire { get; set; }

        [InverseProperty("PartenairePartenaireHebergement")]
        public virtual ICollection<PartenaireHebergement>? PartenairesHebergementPartenaire { get; set; }

        [InverseProperty("PartenairePartenaireActivite")]
        public virtual ICollection<PartenaireActivite>? PartenairesActivitePartenaire { get; set; }

        [ForeignKey("PersonneId")]
        [InverseProperty("PartenairePersonne")]
        public virtual Personne? PersonnePartenaire { get; set; }
    }
}
