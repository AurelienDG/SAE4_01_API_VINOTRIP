using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_j_favori_fav")]
    public class Favori
    {
        [Required]
        [Column("prs_id")]
        public int PersonneId { get; set; }

        [Required]
        [Column("sjr_id")]
        public int SejourId { get; set; }

        [ForeignKey("PersonneId")]
        [InverseProperty("FavoriUser")]
        public virtual User UserFavori { get; set; } = null!;

        [ForeignKey("SejourId")]
        [InverseProperty("FavoriSejour")]
        public virtual Sejour SejourFavori { get; set; } = null!;
    }
}
