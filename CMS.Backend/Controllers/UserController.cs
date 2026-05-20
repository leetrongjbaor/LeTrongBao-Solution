using CMS.Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CMS.Backend.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            var users = new List<User>()
            {
                new User()
                {
                    Id = 1,
                    Username = "admin",
                    FullName = "Lê Trọng Bảo",
                    Role = "Administrator"
                },

                new User()
                {
                    Id = 2,
                    Username = "editor01",
                    FullName = "Nguyễn Văn A",
                    Role = "Editor"
                }
            };

            return View(users);
        }
    }
}