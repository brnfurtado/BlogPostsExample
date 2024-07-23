using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CodingChallenge.Validations;
using Swashbuckle.AspNetCore.Annotations;

namespace CodingChallenge.DataModels
{
    public class BlogPost
    {
        public Guid ID { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public List<Comment>? Comments { get; set; }

        public BlogPost(string title, string content)
        {
            ID = Guid.NewGuid();
            Title = title;
            Content = content;
            Comments = new List<Comment>();
        }
    }
}