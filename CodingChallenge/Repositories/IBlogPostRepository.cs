using CodingChallenge.DataModels;

namespace CodingChallenge.Repositories
{
    public interface IBlogPostRepository
    {
        Task<IEnumerable<GetBlogPostViewModel>> GetAllBlogPosts();
        Task<BlogPost> GetBlogPostByID(Guid id);
        Task AddBlogPost(BlogPost blogPost);
        Task<bool> TryDeleteBlogPost(Guid id);
        Task<bool> TryAddComment(Guid id, Comment comment);
    }
}