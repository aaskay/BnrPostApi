using DemoPostApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace DemoPostApi.PostsDAL
{
    public class MockPostData : IPostData
    {

        public IList<Post> mockPosts = new List<Post>()
        {
            new Post()
            {
                Id = 1,
                UserId = 1,
                Title = "Node is awesome",
                Body = "Node.js is a JavaScript runtime built on Chrome's V8 JavaScript engine."
            },
            new Post()
            {
                Id = 2,
                UserId = 1,
                Title = "Spring Boot is cooler",
                Body = "Spring Boot makes it easy to create stand-alone, production-grade Spring based Applications that you can \"just run\"."
            },
            new Post()
            {
                Id = 3,
                UserId = 2,
                Title = "Go is faster",
                Body = "Go is an open source programming language that makes it easy to build simple, reliable, and efficient software."
            },
            new Post()
            {
                Id = 4,
                UserId = 3,
                Title = "'What about me?' -Rails",
                Body = "Ruby on Rails makes it much easier and more fun. It includes everything you need to build fantastic applications, and you can learn it with the support of our large, friendly community."
            },
            new Post()
            {
                Id = 5,
                UserId = 4,
                Title = ".NET has the gravy",
                Body = ".NET enables engineers to develop blazing fast web services with ease, utilizing tools developed by Microsoft!"
            }
        };

        public Post CreatePost(Post posts)
        {
            posts.Id = mockPosts.Max(x => x.Id) + 1;
            mockPosts.Add(posts);
            return posts;
        }

        public void DeletePost(Post post)
        {
            mockPosts.Remove(post);
        }

        public IList<Post> GetAllPosts()
        {
            return mockPosts;
        }

        public Post GetPost(int id)
        {
            return mockPosts.SingleOrDefault(p => p.Id == id);
        }

        public IList<Post> GetPostsByUser(int UserId)
        {
            return mockPosts.Where(p => p.UserId == UserId).ToList();
        }

        public Post UpdatePost(Post original, Post updated)
        {
            original.Body = updated.Body;
            original.Title = updated.Title;

            return GetPost(original.Id);
        }
    }

}
