namespace WS_VINOTRIP.Models.EntityFramework
{
    public partial class Reservation
    {
        public int ReservationId { get; set; }
        public int SejourId { get; set; }
        public int NbAdultes { get; set; }
        public int NbEnfants { get; set; }
        public int NbChambres { get; set; }
        public double MyProperty { get; set; }
    }
}
