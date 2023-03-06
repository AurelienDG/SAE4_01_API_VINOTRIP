using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_e_elementetape_ele")]
    public class ElementEtape
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ele_id")]
        public int ElementId { get; set; }

        [Key]
        [Column("prs_id")]
        [Required]
        public int PersonneId { get; set; }

        [Key]
        [Column("tpe_id")]
        public int TypeElementId { get; set; }

        [Column("ele_libelleelement")]
        [StringLength(100)]
        [Required]
        public string? LibelleElement { get; set; }

        [Column("ele_descriptionelement", TypeName = "text")]
        public string? DescriptionElement { get; set; }

        [ForeignKey("PersonneId")]
        [InverseProperty("PartenaireElementEtape")]
        public virtual Partenaire ElementEtapeDuPartenaire { get; set; } = null!;

        [InverseProperty("ElementEtapeConcerne")]
        public virtual ICollection<Concerne> ConcerneElementEtape { get; set; } = null!;

        [ForeignKey("TypeElementId")]
        [InverseProperty("ElementEtapeTypeElement")]
        public virtual TypeElement TypeElementElementEtape { get; set; } = null!;
    }
}
