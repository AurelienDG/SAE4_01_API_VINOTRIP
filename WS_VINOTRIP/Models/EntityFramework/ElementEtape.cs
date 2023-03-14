using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_e_elementetape_ele")]
    public class ElementEtape
    {
        //Property

        [Key, Column("ele_id"), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ElementId { get; set; }

        [Required, Column("prs_id")]
        public int PersonneId { get; set; }

        [Column("tpe_id")]
        public int? TypeElementId { get; set; }

        [Required, Column("ele_libelle"), StringLength(100)]
        public string? Libelle { get; set; }

        [Required, Column("ele_description", TypeName = "text")]
        public string? Description { get; set; }

        //InverseProperty

        [ForeignKey("PersonneId")]
        [InverseProperty("ElementsEtapePartenaire")]
        public virtual Partenaire? PartenaireElementEtape { get; set; }

        [InverseProperty("ElementEtapeConcerne")]
        public virtual ICollection<Concerne>? ConcerneElementEtape { get; }

        [ForeignKey("TypeElementId")]
        [InverseProperty("ElementEtapeTypeElementEtape")]
        public virtual TypeElementEtape? TypeElementEtapeElementEtape { get; set; }

        [InverseProperty("ElementEtapeContient")]
        public virtual ICollection<Contient>? ContientElementEtape { get; }
    }
}
