namespace WS_VINOTRIP.Models.EntityFramework
{
    public class User
    {
        public string UserName { get; set; }
        public string? FullName { get; set; }
        public string Password { get; set; }
        public string? UserRole { get; set; }
    }
}
