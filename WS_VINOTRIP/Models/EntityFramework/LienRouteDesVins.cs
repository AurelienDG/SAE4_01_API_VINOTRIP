﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_j_lienroutedesvins_lrv")]
    public partial class LienRouteDesVins
    {
        [Key, Column("lrv_id")]
        public int RouteDesVinsId { get; set; }
        [Key, Column("lrv_id")]
        public int LienId { get; set; }

        [ForeignKey("RouteDesVinsId")]
        [InverseProperty("LienRouteDesVinsRouteDesVins")]
        public virtual RouteDesVins RouteDesVinsLienRouteDesVins { get; set; } = null!;

        [ForeignKey("LienId")]
        [InverseProperty("LienRouteDesVinsLien")]
        public virtual Lien LienLienRouteDesVins { get; set; } = null!;
    }
}
