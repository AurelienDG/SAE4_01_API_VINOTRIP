using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_e_catvignoble_cvg")]
    public partial class CatVignoble
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column("cvg_id")]
        public int CatVignobleId { get; set; }

        [StringLength(30), Column("cvg_libelle")]
        public string? Libelle { get; set; }

        [Column("cvg_description", TypeName = "text")]
        public string? Description { get; set; }

        [InverseProperty("SejourCatVignoble")]
        public virtual ICollection<Sejour> CatVignobleSejour { get; set; } = new List<Sejour>();
    }
}
