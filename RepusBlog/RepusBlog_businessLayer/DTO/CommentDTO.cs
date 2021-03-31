namespace RepusBlog_businessLayer.DTO
{
    class CommentDTO
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public int UserId { get; set; }
        public string Text { get; set; }
    }
}
