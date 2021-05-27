using BisonessLayer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserStore.Models
{
    public class ProfileViewModel
    {
        public User User { get; set; }

        public IEnumerable<PostDTO> UserPosts { get; set; }
    }
}
