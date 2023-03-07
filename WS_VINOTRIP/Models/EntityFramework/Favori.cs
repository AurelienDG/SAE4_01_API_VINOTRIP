﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_e_favori_fav")]
    public class Favori
    {
        [Required]
        [Column("ctl_id")]
        public int PersonneId { get; set; }

        [Required]
        [Column("sjr_id")]
        public int SejourId { get; set; }

        [ForeignKey("PersonneId")]
        [InverseProperty("FavoriClient")]
        public virtual Client ClientFavori { get; set; } = null!;

        [ForeignKey("SejourId")]
        [InverseProperty("FavoriSejour")]
        public virtual Sejour SejourFavori { get; set; } = null!;
    }
}