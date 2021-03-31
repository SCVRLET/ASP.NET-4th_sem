using System.Collections.Generic;

namespace RepusBlog_businessLayer.DTO
{
    class PostDTO
    {
        public int Id { get; set; }
        public ICollection<CommentDTO> Comments { get; set; }
        public ICollection<LikeDTO> Likes { get; set; }
    }
}
