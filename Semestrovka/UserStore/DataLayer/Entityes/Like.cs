﻿namespace DataLayer.Entityes
{
    public class Like
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int PostId { get; set; }
        public Post Post { get; set; }
    }
}
