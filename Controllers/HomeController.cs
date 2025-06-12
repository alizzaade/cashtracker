using System.Diagnostics;
using cashTracker.Models;
using Microsoft.AspNetCore.Mvc;

namespace cashTracker.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly CashTrackerDbContext _context;

        public HomeController(ILogger<HomeController> logger, CashTrackerDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Expenses()
        {
            return View();
        }

        public IActionResult CreateEditExpense(Expense model)
        {
            return View();
        }

        public IActionResult CreateOrEditExpense(Expense model)
        {
            _context.Expenses.Add(model);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
