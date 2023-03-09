﻿using System.ComponentModel.DataAnnotations.Schema;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_j_reside_rsd")]
    public partial class Reside
    {
        [Column("prs_id")]
        public int PersonneId { get; set; }
        [Column("ads_id")]
        public int AdresseId { get; set; }

        [ForeignKey("PersonneId")]
        [InverseProperty("ResideCompte")]
        public virtual Compte CompteReside { get; set; } = null!;

        [ForeignKey("AdresseId")]
        [InverseProperty("ResideAdresse")]
        public virtual Adresse AdresseReside { get; set; } = null!;
    }
}