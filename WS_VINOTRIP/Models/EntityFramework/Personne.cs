using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_e_personne_prs")]
    public partial class Personne
    {
        //Property

        [Key, Column("prs_id"), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PersonneId { get; set; }

        [Required, Column("prs_nom"), StringLength(50)]
        public string? Nom { get; set; }

        [Required, Column("prs_mail"), EmailAddress, StringLength(50)]
        public string? Mail { get; set; }

        //InverseProperty

        [InverseProperty("PersonneUser")]
        public virtual ICollection<User>? UserPersonne { get; }

        [InverseProperty("PersonneAvis")]
        public virtual ICollection<Avis>? AvisPersonne { get; }

        [InverseProperty("PersonnePartenaire")]
        public virtual ICollection<Partenaire>? PartenairePersonne { get; }
    }
}
