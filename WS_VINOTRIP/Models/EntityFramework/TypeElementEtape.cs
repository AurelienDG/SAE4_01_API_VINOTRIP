using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_e_typeelementetape_tpe")]
    public partial class TypeElementEtape
    {
        [Key]
        [Required]
        [Column("tpe_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TypeElementEtapeId { get; set; }

        [Required]
        [StringLength(50)]
        [Column("tpe_libelletypecompte")]
        public string? LibelleTypeElementEtape { get; set; }

        [InverseProperty("TypeElementElementEtape")]
        public virtual ICollection<ElementEtape> ElementEtapeTypeElementetape { get; } = new List<ElementEtape>();
    }
}
