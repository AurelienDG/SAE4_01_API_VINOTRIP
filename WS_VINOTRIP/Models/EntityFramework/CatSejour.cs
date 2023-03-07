using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_e_catsejour_csj")]
    public partial class CatSejour
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column("csj_id")]
        public int VignobleId { get; set; }
        [StringLength(30), Required, Column("csj_libelle", TypeName = "varchar(30)")]
        public string? Libelle { get; set; }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column("len_id")]
        public int LienId { get; set; }



        [InverseProperty("SejourCatSejour")]
        public virtual ICollection<Sejour> CatSejoursSejour { get; set; } = new List<Sejour>();

        [ForeignKey("LienId")]
        [InverseProperty("CatSejourLien")]
        public virtual Lien LienCatSejour { get; set; } = null!;
    }
}
