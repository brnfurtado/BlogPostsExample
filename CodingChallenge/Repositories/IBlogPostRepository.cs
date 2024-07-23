using CodingChallenge.DataModels;

namespace CodingChallenge.Repositories
{
    public interface IBlogPostRepository
    {
        Task<IEnumerable<BlogPost>> GetAllBlogPosts();
        Task<BlogPost> GetBlogPostByID(Guid id);
        Task AddBlogPost(BlogPost blogPost);
        Task<bool> TryEditBlogPost(BlogPost blogPost);
        Task<bool> TryDeleteBlogPost(Guid id);
        Task<bool> TryAddComment(Guid id, Comment comment);
    }
}