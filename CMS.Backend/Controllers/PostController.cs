using CMS.Data; 
using CMS.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CMS.Backend.Controllers
{
    public class PostController : Controller
    {
        // 1. Khai báo biến private readonly để lưu trữ context
        private readonly ApplicationDbContext _context;

        // 2. Thực hiện "Tiêm" (Constructor Injection)
        public PostController(ApplicationDbContext context)
        {
            _context = context;
        }

        // 3. Action Index lấy dữ liệu thật từ Database
        public IActionResult Index()
        {
            var posts = _context.Posts.ToList(); // Lấy tất cả bài viết từ bảng Posts
            return View(posts);
        }
    }
}