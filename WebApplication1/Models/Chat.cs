using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public static class Chat
    {
        public static List<ChatItem> Items = new List<ChatItem>();

        private static object _lockobj = new object();
        public static void Add(ChatItem item)
        {
            if (string.IsNullOrWhiteSpace(item.Author))
            {
                item.Author = "Anonimus";
            }
            item.Date = DateTime.Now;

            lock (_lockobj)
            {
                Items.Add(item);
            }
        }
    }
}