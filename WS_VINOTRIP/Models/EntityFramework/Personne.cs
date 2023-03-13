using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_e_personne_prs")]
    public partial class Personne
    {
        [Key]
        [Column("prs_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PersonneId { get; set; }

        [Required]
        [StringLength(50)]
        [Column("prs_nom")]
        public string? Nom { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(50)]
        [Column("prs_mail")]
        public string? Mail { get; set; }

        [InverseProperty("PersonneUser")]
        public virtual ICollection<User> UserPersonne { get; } = new List<User>();

        [InverseProperty("PersonneAvis")]
        public virtual ICollection<Avis> AvisPersonne { get; } = new List<Avis>();
    }
}
