using System;
using System.Collections.Generic;
using System.Text;

namespace BisonessLayer.DTO
{
    public class PostDTO
    {

        public int Id { get; set; }
        public string UserId { get; set; }
        public string Text { get; set; }
        public DateTime CreatedAt { get; set; }
        public ICollection<CommentDTO> Comments { get; set; }
        public ICollection<LikeDTO> Likes { get; set; }
        public ICollection<PostImageDTO> PostImages { get; set; }

        public PostDTO()
        {
            Comments = new List<CommentDTO>();
            Likes = new List<LikeDTO>();
            PostImages = new List<PostImageDTO>();
        }
    }
}
