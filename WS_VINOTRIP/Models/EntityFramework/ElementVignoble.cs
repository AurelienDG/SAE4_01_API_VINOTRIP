using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_e_elementvignoble_evg")]
    public partial class ElementVignoble
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column("evg_id")]
        public int ElementVignobleId { get; set; }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column("vgb_id")]
        public int VignobleId { get; set; }
        [StringLength(70), Required, Column("evg_titre", TypeName = "varchar(70)")]
        public string? Titre { get; set; }
        [Required, Column("evg_description", TypeName = "text")]
        public string? Description { get; set; }

        [ForeignKey("VignobleId")]
        [InverseProperty("ElementVignobleVignoble")]
        public virtual Vignoble VignobleElementVignoble { get; set; } = null!;

        [InverseProperty("ElementVignobleLienElementVignoble")]
        public virtual ICollection<LienElementVignoble> LienElementVignobleElementVignoble { get; set; } = new List<LienElementVignoble>();

    }
}
