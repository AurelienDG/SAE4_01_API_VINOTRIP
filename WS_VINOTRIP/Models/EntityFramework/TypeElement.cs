using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_e_typeelementetape_tpe")]
    public partial class TypeElement
    {
        [Key]
        [Required]
        [Column("tpe_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TypeElementId { get; set; }

        [Required]
        [StringLength(50)]
        [Column("tpe_libelletypecompte")]
        public string LibelleTypeElement { get; set; }

        [InverseProperty("TypeElementElementEtape")]
        public virtual ICollection<ElementEtape> ElementEtapeTypeElement { get; } = new List<ElementEtape>();
    }
}
