using CodingChallenge.DataModels;

namespace CodingChallenge.Repositories
{
    public class BlogPostRepository : IBlogPostRepository
    {
        private List<BlogPost> _blogPosts = new List<BlogPost>();

        public Task<IEnumerable<BlogPost>> GetAllBlogPosts()
        {
            return Task.FromResult<IEnumerable<BlogPost>>(_blogPosts);
        }

        public async Task<BlogPost> GetBlogPostByID(Guid id)
        {
            var blogPost = _blogPosts.FirstOrDefault(b => b.ID == id);
            return blogPost;
        }

        public async Task AddBlogPost(BlogPost blogPost)
        {
            _blogPosts.Add(blogPost);
        }

        public async Task<bool> TryDeleteBlogPost(Guid id)
        {
            var blogPost = _blogPosts.FirstOrDefault(b => b.ID == id);

            if (blogPost == null)
            {
                return false;
            }

            _blogPosts.Remove(blogPost);
            return true;
        }

        public async Task<bool> TryAddComment(Guid id, Comment comment)
        {
            var blogPost = _blogPosts.FirstOrDefault(b => b.ID == id);

            if (blogPost == null)
            {
                return false;
            }

            blogPost.Comments.Add(comment);
            return true;
        }
    }
}