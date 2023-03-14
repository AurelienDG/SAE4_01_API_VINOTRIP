using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_e_elementvignoble_evg")]
    public partial class ElementVignoble
    {
        //Property

        [Key, Column("evg_id"), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ElementVignobleId { get; set; }

        [Column("vgb_id")]
        public int VignobleId { get; set; }

        [Required, Column("evg_titre"), StringLength(70)]
        public string? Titre { get; set; }

        [Required, Column("evg_description", TypeName = "text")]
        public string? Description { get; set; }

        //InverseProperty

        [ForeignKey("VignobleId")]
        [InverseProperty("ElementVignobleVignoble")]
        public virtual Vignoble? VignobleElementVignoble { get; set; }

        [InverseProperty("ElementVignobleLienElementVignoble")]
        public virtual ICollection<LienElementVignoble>? LienElementVignobleElementVignoble { get; }

    }
}
