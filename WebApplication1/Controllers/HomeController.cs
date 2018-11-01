using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            ChatViewModel viewModel = new ChatViewModel
            {
                Items = Chat.Items
            };
            return View(viewModel);
        }
        [HttpPost]
        public ActionResult Index(ChatViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                Chat.Add(new ChatItem
                {
                    Author = viewModel.Author,
                    Message = viewModel.Message
                });
            }
            viewModel.Items = Chat.Items;
            return View(viewModel);
        }
    }
}