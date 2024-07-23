using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CodingChallenge.Validations;
using Swashbuckle.AspNetCore.Annotations;

namespace CodingChallenge.DataModels
{
    public class CreateBlogPostViewModel
    {
        [Required]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }
    }
}