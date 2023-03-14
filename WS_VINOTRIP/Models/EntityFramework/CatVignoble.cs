using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_e_catvignoble_cvg")]
    public partial class CatVignoble
    {
        //Property

        [Key, Column("cvg_id"), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CatVignobleId { get; set; }

        [Required, Column("cvg_libelle"), StringLength(30)]
        public string? Libelle { get; set; }

        [Column("cvg_description", TypeName = "text")]
        public string? Description { get; set; }

        //InverseProperty

        [InverseProperty("SejourCatVignoble")]
        public virtual ICollection<Sejour>? CatVignobleSejour { get; }
    }
}
