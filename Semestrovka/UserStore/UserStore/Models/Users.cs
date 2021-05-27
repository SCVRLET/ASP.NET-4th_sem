using DataLayer.Entityes;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserStore.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Role { get; set; }
        public string Type { get; set; }
        public string Avatar { get; set; }
        public DateTime JoinedAt { get; set; }
        public bool IsSubscribed { get; set; }
    }
}
