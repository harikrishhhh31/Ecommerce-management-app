using ECommerceApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ECommerceApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.TotalProducts = await _context.Products.CountAsync();
            ViewBag.TotalCategories = await _context.Categories.CountAsync();
            ViewBag.TotalStock = await _context.Products.SumAsync(p => p.StockQuantity);
            ViewBag.RecentProducts = await _context.Products
                .Include(p => p.Category)
                .OrderByDescending(p => p.CreatedDate)
                .Take(5)
                .ToListAsync();
            return View();
        }
    }
}
