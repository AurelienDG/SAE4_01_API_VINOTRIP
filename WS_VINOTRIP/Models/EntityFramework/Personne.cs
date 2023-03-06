﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_e_personne_prs")]
    public partial class Personne
    {
        [Key]
        [Required]
        [Column("prs_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPersonne { get; set; }

        [Required]
        [StringLength(50)]
        [Column("prs_nompersonne")]
        public string NomPersonne { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(50)]
        [Column("prs_mailpersonne")]
        public string MailPersonne { get; set; }

        [InverseProperty("ComptePersonne")]
        public virtual ICollection<Compte> Personnes { get; } = new List<Compte>();
    }
}
