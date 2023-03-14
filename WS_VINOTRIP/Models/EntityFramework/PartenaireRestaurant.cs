using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_e_partenairerestaurant_ptr")]
    public partial class PartenaireRestaurant
    {
        //Property

        [Key, Column("ptr_id"), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PartenaireRestaurantId { get; set; }

        [Required, Column("ptn_id")]
        public int PersonneId { get; set; }

        [Required, Column("ptr_typecuisine"), StringLength(30)]
        public string? TypeCuisine { get; set; }

        [Column("ptr_specialite"), StringLength(30)]
        public string? Specialite { get; set; }

        [Column("ptr_etoiles")]
        public int Etoiles { get; set; }

        //InverseProperty

        [ForeignKey("PersonneId")]
        [InverseProperty("PartenairesRestaurantPartenaire")]
        public virtual Partenaire? PartenairePartenaireRestaurant { get; set; }

    }
}
