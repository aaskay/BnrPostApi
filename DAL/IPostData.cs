using BnrPostApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BnrPostApi.PostsDAL
{
    public interface IPostData
    {
        IList<Post> GetAllPosts();

        Post GetPost(int id);

        IList<Post> GetPostsByUser(int UserId);

        Post UpdatePost(Post original, Post updated);

        Post CreatePost(Post posts);

        void DeletePost(Post post);
    }
}
