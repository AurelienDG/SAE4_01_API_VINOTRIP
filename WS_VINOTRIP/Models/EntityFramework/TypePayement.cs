using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_e_typepayement_tpa")]
    public partial class TypePayement
    {
        [Key, Column("tpa_id"), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TypePayementId { get; set; }

        [Column("tpa_libelle")]
        public string? Libelle { get; set; }

        [InverseProperty("TypePayementPaye")]
        public virtual ICollection<Paye> PayeTypePayement { get; set; } = null!;
    }
}
