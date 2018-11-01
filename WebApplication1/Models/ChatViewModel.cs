using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class ChatViewModel : IValidatableObject
    {
        public List<ChatItem>Items { get; set; }
        public string Message { get; set; }
        public string Author { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (string.IsNullOrWhiteSpace(Message))
            {
                yield return new ValidationResult("Message can not be empty");
            }
        }
    }
}