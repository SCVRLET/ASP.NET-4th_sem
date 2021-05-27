using System;
using System.Collections.Generic;
using System.Text;
using DataLayer.Entityes;

namespace BisonessLayer.Interfaces
{
    public interface IEFPostsRepository
    {
        List<Post> GetProfilePosts(string userId);
        void AddPost(string userId, string postText);
        void DeletePost(int postId);
        void AddLike(int postId, string userId);
        void RemoveLike(int postId, string userId);
        void AddComment(int postId, string text, string userId);
        Post FindPost(int postId);
        public Like FindLike(int postId, string userId);
        public List<Like> GetPostLikes(int postId);
    }
}
