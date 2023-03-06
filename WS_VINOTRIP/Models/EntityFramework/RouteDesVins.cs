using System.ComponentModel.DataAnnotations.Schema;

namespace WS_VINOTRIP.Models.EntityFramework
{
    [Table("t_e_routedesvins_rdv")]
    public partial class RouteDesVins
    {

        [InverseProperty("RouteDesVinsSejour")]
        public virtual ICollection<Sejour> SejourRouteDesVins { get; set; } = new List<Sejour>();
    }
}
