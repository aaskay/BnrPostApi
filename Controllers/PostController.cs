using BnrPostApi.PostsDAL;
using Microsoft.AspNetCore.Mvc;
using BnrPostApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BnrPostApi.Controllers
{
    [ApiController]
    public class PostController : ControllerBase
    {
        private IPostData _postData;

        public PostController(IPostData postData)
        {
            _postData = postData;
        }

        [HttpGet]
        [Route("api/[Controller]")]
        public IActionResult GetAllPosts()
        {
            return Ok(_postData.GetAllPosts());
        }

        [HttpGet]
        [Route("api/[Controller]/{id}")]
        public IActionResult GetPost(int id)
        {
            var post = _postData.GetPost(id);
            if (post != null)
            {
                return Ok(post);
            }

            return NotFound($"Post with id: {id} was not found");
        }

        [HttpGet]
        [Route("api/[Controller]/user/{id}")]
        public IActionResult GetPostsByUser(int id)
        {
            var posts = _postData.GetPostsByUser(id);
            if (posts.Count != 0)
            {
                return Ok(posts);
            }

            return NotFound($"No posts from user with id: {id} were found");
        }

        [HttpPost]
        [Route("api/[Controller]")]
        public IActionResult CreatePost(Post post)
        {
            _postData.CreatePost(post);
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" + post.Id, post);
        }

        [HttpDelete]
        [Route("api/[Controller]/{id}")]
        public IActionResult DeletePost(int id)
        {
            var post = _postData.GetPost(id);
            if(post != null)
            {
                _postData.DeletePost(post);
                return Ok();
            }

            return NotFound($"Post with id: {id} was not found");
        }

        [HttpPatch]
        [Route("api/[Controller]/{id}")]
        public IActionResult UpdatePost(int id, Post updatedPost)
        {
            var originalPost = _postData.GetPost(id);
            if(originalPost != null)
            {
                var post = _postData.UpdatePost(originalPost, updatedPost);
                return Ok(post);
            }

            return NotFound($"Post with id: {id} was not found");
        }
    }
}
