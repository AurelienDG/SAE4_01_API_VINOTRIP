using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_e_routedesvins_rdv")]
    public partial class RouteDesVins
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column("rdv_id")]
        public int RouteDesVinsId { get; set; }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column("vgb_id")]
        public int VignobleId { get; set; }
        [StringLength(30), Required, Column("rdv_titre", TypeName = "varchar(30)")]
        public string? Titre { get; set; }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column("len_id")]
        public int LienId { get; set; }

        [InverseProperty("SejourRouteDesVins")]
        public virtual ICollection<Sejour> RouteDesVinsSejour { get; set; } = new List<Sejour>();
    }
}
