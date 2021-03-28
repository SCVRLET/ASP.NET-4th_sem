using System.Collections.Generic;

namespace RepusBlog_dataLayer.Entities
{
    public class Post
    {
        public int Id { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Like> Likes { get; set; }

        //public ICollection<Hashtag> Hashtags { get; set; } TODO
    }
}
