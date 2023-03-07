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

        [Column("ele_libelle")]
        [StringLength(100)]
        [Required]
        public string? Libelle { get; set; }

        [Column("ele_description", TypeName = "text")]
        public string? Description { get; set; }

        [ForeignKey("PersonneId")]
        [InverseProperty("PartenaireElementEtape")]
        public virtual Partenaire ElementEtapeDuPartenaire { get; set; } = null!;

        [InverseProperty("ElementEtapeConcerne")]
        public virtual ICollection<Concerne> ConcerneElementEtape { get; set; } = null!;

        [ForeignKey("TypeElementId")]
        [InverseProperty("ElementEtapeTypeElement")]
        public virtual TypeElement TypeElementElementEtape { get; set; } = null!;

        [InverseProperty("ElementEtapeContient")]
        public virtual ICollection<Contient> ContientElementEtape { get; set; } = new List<Contient>();
    }
}
