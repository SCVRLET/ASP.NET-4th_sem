using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Entityes
{
    public class PostImage
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public byte[] Image { get; set; }
    }
}
