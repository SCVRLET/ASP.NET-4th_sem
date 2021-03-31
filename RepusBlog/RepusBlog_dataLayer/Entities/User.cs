namespace RepusBlog_dataLayer.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }
        public string Password_hash { get; set; }
        public string Country { get; set; }
        public UserType Type { get; set; }
        public UserRole Role { get; set; }
        public bool IsSubscribed { get; set; }
    }
}
