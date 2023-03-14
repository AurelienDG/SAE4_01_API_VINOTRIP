using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_e_typeelementetape_tpe")]
    public partial class TypeElementEtape
    {
        //Property

        [Key, Column("tpe_id"), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TypeElementEtapeId { get; set; }

        [Required, Column("tpe_libelle"), StringLength(50)]
        public string? Libelle { get; set; }

        //InverseProperty

        [InverseProperty("TypeElementEtapeElementEtape")]
        public virtual ICollection<ElementEtape>? ElementEtapeTypeElementEtape { get;  }
    }
}
