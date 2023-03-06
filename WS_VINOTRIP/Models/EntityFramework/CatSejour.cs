using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_e_catsejour_csj")]
    public partial class CatSejour
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column("csj_id")]
        public int VignobleId { get; set; }
        public string? LibelleCatVignoble { get; set; }



        [InverseProperty("CatSejourSejour")]
        public virtual ICollection<Sejour> SejourCatSejour { get; set; } = new List<Sejour>();
    }
}
