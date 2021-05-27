using BisonessLayer.Interfaces;
using DataLayer;
using DataLayer.Entityes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BisonessLayer.Implementations
{
    public class EFPostsRepository : IEFPostsRepository
    {
        private EFDBContext _context;

        public EFPostsRepository(EFDBContext context)
        {
            _context = context;
        }

        public Post FindPost(int postId)
        {
            return _context.Posts.FirstOrDefault(x => x.Id == postId);
        }

        public Like FindLike(int postId, string userId)
        {
            return _context.Likes.FirstOrDefault(x => x.UserId == userId & x.PostId == postId);
        }

        public void AddComment(int postId, string text, string userId)
        {
            var newComment = new Comment { PostId = postId, Text = text, UserId = userId, CreatedAt = DateTime.Now };

             _context.Posts.FirstOrDefault(x => x.Id == postId).Comments.Add(newComment);

            _context.SaveChanges();

        }

        public void AddLike(int postId, string userId)
        {
            var newLike = new Like { PostId = postId, UserId = userId };

            _context.Likes.Add(newLike);
                
            _context.SaveChanges();
        }

        public void RemoveLike(int postId, string userId)
        {
            var like = FindPost(postId).Likes.Where(x => x.UserId == userId).FirstOrDefault();

            _context.Posts.FirstOrDefault(x => x.Id == postId).Likes.Remove(like);

            _context.SaveChanges();
        }

        public void AddPost(string userId, string postText)
        {
            var newPost = new Post { UserId = userId, Text = postText, CreatedAt = DateTime.Now };

            _context.Posts.Add(newPost);

            _context.SaveChanges();
        }

        /*public void AddPost(string userId, string postText, ICollection<PostImage> postImages)
        {
            //TODO
        }*/

        public void DeletePost(int postId)
        {
            var deletedPost = _context.Posts.FirstOrDefault(x => x.Id == postId);

            _context.Posts.Remove(deletedPost);

            _context.SaveChanges();
        }

        public List<Post> GetProfilePosts(string userId)
        {
            var ret = _context.Posts.Where(x => x.UserId == userId);

            foreach (var p in ret)
                p.Likes = GetPostLikes(p.Id);

            return ret.ToList();
        }

        public List<Like> GetPostLikes(int postId)
        {
            return _context.Likes.Where(x => x.PostId == postId).ToList();
        }
    }
}
