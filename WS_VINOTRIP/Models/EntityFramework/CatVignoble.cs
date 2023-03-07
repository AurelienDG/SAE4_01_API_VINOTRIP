using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_e_catvignoble_cvg")]
    public partial class CatVignoble
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column("cvg_id")]
        public int VignobleId { get; set; }

        [StringLength(30), Column("cvg_libelle", TypeName = "varchar(30)")]
        public string? Libelle { get; set; }

        [InverseProperty("SejourCatVignoble")]
        public virtual ICollection<Sejour> CatVignobleSejour { get; set; } = new List<Sejour>();
    }
}
