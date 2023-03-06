using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_e_typecompte_tpc")]
    public partial class TypeCompte
    {
        [Key]
        [Required]
        [Column("tpc_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdTypeCompte { get; set; }

        [Required]
        [StringLength(30)]
        [Column("tpc_libelletypecompte")]
        public string LibelleTypeCompte { get; set; }
    }
}
