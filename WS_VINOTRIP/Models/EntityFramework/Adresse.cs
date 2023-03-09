using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_e_adresse_ads")]
    public partial class Adresse
    { 
        [Key, Column("ads_id"), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AdresseId { get; set; }
        [Column("ads_rue1"), Required, StringLength(100)]
        public String? Rue1 { get; set; }
        [Column("ads_rue2"), StringLength(100)]
        public String? Rue2 { get; set; }
        [Column("ads_cp", TypeName = "char(5)"), Required]
        public int Cp { get; set; }
        [Column("ads_ville"), Required, StringLength(30)]
        public String? Ville { get; set; }
        [Column("ads_pays"), Required, StringLength(30)]
        public String? Pays { get; set; }

        [InverseProperty("AdresseEst_facturee")]
        public virtual ICollection<Est_facturee> Est_factureeAdresse { get; set; } = new List<Est_facturee>();

        [InverseProperty("AdresseReside")]
        public virtual ICollection<Reside> ResideAdresse { get; set; } = new List<Reside>();
    }
}
