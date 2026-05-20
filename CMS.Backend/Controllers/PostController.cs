using CMS.Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CMS.Backend.Controllers
{
    public class PostController : Controller
    {
        public IActionResult Index()
        {
            List<Post> posts = new List<Post>()
            {
                new Post()
                {
                    Id = 1,
                    Title = "Lộ trình học ASP.NET Core cho người mới",
                    Content = "Nội dung bài viết về lộ trình học .NET...",
                    ImageUrl = "https://picsum.photos/300/200?1"
                },

                new Post()
                {
                    Id = 2,
                    Title = "ReactJS và WebAPI: Xu hướng Fullstack 2026",
                    Content = "Nội dung bài viết về ReactJS và API...",
                    ImageUrl = "https://picsum.photos/300/200?2"
                },

                new Post()
                {
                    Id = 3,
                    Title = "Hướng dẫn cài đặt môi trường Visual Studio",
                    Content = "Các bước cài đặt công cụ cần thiết...",
                    ImageUrl = "https://picsum.photos/300/200?3"
                }
            };

            return View(posts);
        }
    }
}