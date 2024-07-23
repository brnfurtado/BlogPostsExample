using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CodingChallenge.Validations;
using Swashbuckle.AspNetCore.Annotations;

namespace CodingChallenge.DataModels
{
    public class GetBlogPostViewModel
    {
        public Guid ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int CommentCount { get; set; }
    }
}