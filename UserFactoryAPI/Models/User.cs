namespace UserFactoryAPI.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Gender { get; set; }
        public string Nationality { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Image { get; set; }
        public string Phone { get; set; }
        public string Cell { get; set; }
        public DateTime Birth { get; set; }
        public Name Name { get; set; }
        public Location Location { get; set; }
    }
}
