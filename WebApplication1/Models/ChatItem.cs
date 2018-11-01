using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class ChatItem
    {
        public string Message { get; set; }
        public string Author { get; set; }
        public DateTime Date { get; set; }
    }
}