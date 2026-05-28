using CMS.Data; // Thay bằng namespace chuẩn chứa ApplicationDbContext của bạn
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CMS.Backend.Controllers
{
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _context;

        // Tiêm ApplicationDbContext thông qua Constructor Injection
        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Action Index lấy danh sách thành viên từ Database
        public IActionResult Index()
        {
            var users = _context.Users.ToList();
            return View(users);
        }
    }
}