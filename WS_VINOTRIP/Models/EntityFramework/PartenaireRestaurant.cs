using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_e_partenairerestaurant_ptr")]
    public class PartenaireRestaurant
    {
        [Key]
        [Column("ptr_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PartenaireRestaurantId { get; set; }

        [Required]
        [Column("ptn_id")]
        public int PersonneId { get; set; }

        [Required]
        [StringLength(30)]
        [Column("ptr_typecuisine")]
        public string? TypeCuisine { get; set; }

        [StringLength(30)]
        [Column("ptr_specialite")]
        public string? Specialite { get; set; }

        [Column("ptr_etoilesrestaurant")]
        public int EtoilesRestaurant { get; set; }

        [ForeignKey("PersonneId")]
        [InverseProperty("PartenairesRestaurantPartenaire")]
        public virtual Partenaire PartenairePartenaireRestaurant { get; set; } = null!;

    }
}
