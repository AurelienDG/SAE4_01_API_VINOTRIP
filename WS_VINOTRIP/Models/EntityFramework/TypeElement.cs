using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_e_typeelementetape_tee")]
    public partial class TypeElementEtape
    {
        [Key]
        [Required]
        [Column("tee_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TypeElementId { get; set; }

        [Required]
        [StringLength(50)]
        [Column("tee_libelletypecompte")]
        public string LibelleTypeElement { get; set; }

        [InverseProperty("TypeElementElementEtape")]
        public virtual ICollection<ElementEtape> ElementEtapeTypeElement { get; } = new List<ElementEtape>();
    }
}
