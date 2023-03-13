using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_e_typecompte_tpc")]
    public partial class TypeCompte
    {
        [Key]
        [Required]
        [Column("tpc_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TypeCompteId { get; set; }

        [Required]
        [StringLength(30)]
        [Column("tpc_libelletypecompte")]
        public string? Libelle { get; set; }

        [InverseProperty("TypeCompteUser")]
        public virtual ICollection<User> UserTypeCompte { get; } = new List<User>();
    }
}
