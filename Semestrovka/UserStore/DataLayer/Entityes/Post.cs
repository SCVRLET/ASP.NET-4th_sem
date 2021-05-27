using System;
using System.Collections.Generic;

namespace DataLayer.Entityes
{
    public class Post
    {

        public Post()
        {
            Comments = new List<Comment>();
            Likes = new List<Like>();
            PostImages = new List<PostImage>();
        }

        public int Id { get; set; }
        public string UserId { get; set; }
        public string Text { get; set; }
        public DateTime CreatedAt { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Like> Likes { get; set; }
        public ICollection<PostImage> PostImages { get; set; }
    }
}
