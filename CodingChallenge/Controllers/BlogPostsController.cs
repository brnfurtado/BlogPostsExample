using CodingChallenge.DataModels;
using CodingChallenge.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace CodingChallenge.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BlogPostsController : ControllerBase
    {
        private readonly IBlogPostRepository _blogPostRepository;

        public BlogPostsController(IBlogPostRepository blogPostRepository)
        {
            _blogPostRepository = blogPostRepository;
        }

        [HttpGet]
        [Route("/api/posts")]
        public async Task<ActionResult<IEnumerable<GetBlogPostViewModel>>> GetAllBlogPosts()
        {
            var blogPosts = await _blogPostRepository.GetAllBlogPosts();
            return Ok(blogPosts);
        }

        [HttpPost]
        [Route("/api/posts")]
        public async Task<IActionResult> AddBlogPost(CreateBlogPostViewModel createBlogPostViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var blogPost = new BlogPost(createBlogPostViewModel.Title, createBlogPostViewModel.Content);

            await _blogPostRepository.AddBlogPost(blogPost);
            return Ok($"New BlogPost created with ID: [{blogPost.ID}]");
        }


        [HttpGet]
        [Route("/api/posts/{id}")]
        public async Task<ActionResult<BlogPost>> GetBlogPost([FromRoute] Guid id)
        {
            var blogPost = await _blogPostRepository.GetBlogPostByID(id);
            if (blogPost == null)
            {
                return NotFound();
            }
            return Ok(blogPost);
        }

        [HttpDelete]
        [Route("/api/posts/{id}")]
        public async Task<IActionResult> DeleteBlogPost([FromRoute] Guid id)
        {
            if (await _blogPostRepository.TryDeleteBlogPost(id))
            {
                return Ok($"Deleted BlogPost with ID: [{id}]");
            }

            return BadRequest($"BlogPost with ID: [{id}] was not found.");
        }

        [HttpPost]
        [Route("/api/posts/{id}/comments")]
        public async Task<IActionResult> CommentOnBlogPost([FromRoute] Guid id, Comment comment)
        {
            if (await _blogPostRepository.TryAddComment(id, comment))
            {
                return Ok($"New comment added for BlogPost with ID: [{id}]");
            }

            return BadRequest($"BlogPost with ID: [{id}] was not found.");
        }
    }
}