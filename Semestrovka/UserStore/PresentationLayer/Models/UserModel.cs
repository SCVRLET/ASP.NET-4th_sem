using DataLayer.Entityes;
using System;
using System.Collections.Generic;
using System.Text;

namespace PresentationLayer.Models
{
    /*public class UserViewModel
    {
        public User User { get; set; }
    }*/
    public class UserEditModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string Type { get; set; }
        public byte[] Avatar { get; set; }
        public bool IsSubscribed { get; set; }
    }
}
