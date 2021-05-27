using System;

namespace BisonessLayer.DTO
{
    public class CommentDTO
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public DateTime CreatedAt { get; set; }
        public string UserId { get; set; }
        public string Text { get; set; }
    }
}
