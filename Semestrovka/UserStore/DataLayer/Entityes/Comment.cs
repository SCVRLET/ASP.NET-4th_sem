using System;

namespace DataLayer.Entityes
{
    public class Comment
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public DateTime CreatedAt { get; set; }
        public string UserId { get; set; }
        public string Text { get; set; }
    }
}
