/*
Họ Tên :Lê Trọng Bảo
MSSV:2123110056
VS:1.0
 */
using Microsoft.AspNetCore.Mvc;
using CMS.Data;
using CMS.Data.Entities;

namespace CMS.Backend.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _context;

        // Inject DbContext
        public CategoryController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            // Lấy dữ liệu thật từ database
            var data = _context.Categories.ToList();

            return View(data);
        }
    }
}