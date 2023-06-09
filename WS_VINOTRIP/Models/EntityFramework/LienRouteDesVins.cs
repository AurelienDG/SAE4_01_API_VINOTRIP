﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_j_lienroutedesvins_lrv")]
    public partial class LienRouteDesVins
    {
        //Property

        [Required, Column("rdv_id")]
        public int RouteDesVinsId { get; set; }
        [Required, Column("len_id")]
        public int LienId { get; set; }

        //InverseProperty

        [ForeignKey("RouteDesVinsId")]
        [InverseProperty("LienRouteDesVinsRouteDesVins")]
        public virtual RouteDesVins? RouteDesVinsLienRouteDesVins { get; set; }

        [ForeignKey("LienId")]
        [InverseProperty("LienRouteDesVinsLien")]
        public virtual Lien? LienLienRouteDesVins { get; set; }
    }
}
