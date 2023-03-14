using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_e_typecompte_tpc")]
    public partial class TypeCompte
    {
        //Property

        [Key, Column("tpc_id"), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TypeCompteId { get; set; }

        [Required, Column("tpc_libelle"), StringLength(30)]
        public string? Libelle { get; set; }

        //InverseProperty

        [InverseProperty("TypeCompteUser")]
        public virtual ICollection<User>? UserTypeCompte { get; }
    }
}
