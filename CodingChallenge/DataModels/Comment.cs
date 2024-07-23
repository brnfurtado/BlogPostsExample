using CodingChallenge.Validations;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CodingChallenge.DataModels
{
    public class Comment
    {
        [FromBody]
        public string? Content { get; set; }
    }
}