namespace RepusBlog_businessLayer.DTO
{
    class UserDTO
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }
        public string Password_hash { get; set; }
        public string Country { get; set; }
        public UserTypeDTO Type { get; set; }
        public UserRoleDTO Role { get; set; }
        public bool IsSubscribed { get; set; }

    }

    public enum UserRoleDTO
    {
        Client,
        Admin
    }

    public enum UserTypeDTO
    {
        Person,
        Company
    }
}
