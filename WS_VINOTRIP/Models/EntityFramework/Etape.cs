﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_e_etape_etp")]
    public partial class Etape
    {
        [Key, Column("etp_id"), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EtapeId { get; set; }

        [Column("sjr_id")]
        public int? SejourId { get; set; }

        [Required, Column("etp_titre"), StringLength(100)]
        public string? Titre { get; set; }

        [Required, Column("etp_description", TypeName = "text")]
        public string? Description { get; set; }

        //InverseProperty

        [ForeignKey("SejourId")]
        [InverseProperty("EtapesSejour")]
        public virtual Sejour? SejourEtape { get; set; }

        [InverseProperty("EtapeConcerne")]
        public virtual ICollection<Concerne>? ConcerneEtape { get; }

        [InverseProperty("EtapeLienEtape")]
        public virtual ICollection<LienEtape>? LienEtapeEtape { get; }

    }
}
