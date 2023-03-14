using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_e_catsejour_csj")]
    public partial class CatSejour
    {
        //Property

        [Key, Column("csj_id"), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CatSejourId { get; set; }

        [Required, Column("csj_libelle"), StringLength(30)]
        public string? Libelle { get; set; }

        [Required, Column("len_id")]
        public int LienId { get; set; }

        //InverseProperty

        [InverseProperty("SejourCatSejour")]
        public virtual ICollection<Sejour>? CatSejoursSejour { get; }

        [ForeignKey("LienId")]
        [InverseProperty("CatSejourLien")]
        public virtual Lien? LienCatSejour { get; set; }
    }
}
