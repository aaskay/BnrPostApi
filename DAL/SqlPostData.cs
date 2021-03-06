using DemoPostApi.Models;
using DemoPostApi.PostsDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoPostApi.DAL
{
    public class SqlPostData : IPostData
    {
        private PostsContext _postContext;
        public SqlPostData(PostsContext postContext)
        {
            _postContext = postContext;
        }
        public Post CreatePost(Post posts)
        {
            _postContext.Posts.Add(posts);
            _postContext.SaveChanges();
            return posts;
        }

        public void DeletePost(Post post)
        {
            throw new NotImplementedException();
        }

        public IList<Post> GetAllPosts()
        {
            return _postContext.Posts.ToList();
        }

        public Post GetPost(int id)
        {
            return _postContext.Posts.SingleOrDefault(p => p.Id == id);
        }

        public IList<Post> GetPostsByUser(int UserId)
        {
            return _postContext.Posts.Where(p => p.UserId == UserId).ToList();
        }

        public Post UpdatePost(Post original, Post updated)
        {
            throw new NotImplementedException();
        }
    }
}
