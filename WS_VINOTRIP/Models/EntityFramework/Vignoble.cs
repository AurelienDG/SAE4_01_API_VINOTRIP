namespace WS_VINOTRIP.Models.EntityFramework
{
    public class Vignoble
    {
        public int VignobleId { get; set; }
        public string? Titre { get; set; }
        public string? Description { get; set; }
        public int LienId { get; set; }
    }
}
