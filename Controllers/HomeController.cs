using System.Diagnostics;
using cashTracker.Data;
using cashTracker.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace cashTracker.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
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

        [Authorize]
        public IActionResult Expenses()
        {
            var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
            var userExpenses = _context.Expenses.Where(x => x.UserId == userId).ToList();
            var totalExpenses = userExpenses.Sum(x => x.Value);
            ViewBag.Expenses = totalExpenses;
            return View(userExpenses);
        }

        public IActionResult CreateEditExpense(int? id)
        {
            var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
            if (id != null)
            {
                var expenseInDb = _context.Expenses.SingleOrDefault(expense => expense.Id == id && expense.UserId == userId);
                if (expenseInDb == null)
                    return Unauthorized();
                return View(expenseInDb);
            }

            return View();
        }

        public IActionResult DeleteExpense(int? id)
        {
            var expenseInDb = _context.Expenses.SingleOrDefault(expense => expense.Id == id);
            _context.Expenses.Remove(expenseInDb);
            _context.SaveChanges();
            return RedirectToAction("Expenses");
        }

        public IActionResult CreateOrEditExpense(Expense model)
        {
            var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
            if (model.Id == 0)
            {
                model.UserId = userId;
                _context.Expenses.Add(model);
            }
            else
            {
                var expenseInDb = _context.Expenses.SingleOrDefault(e => e.Id == model.Id && e.UserId == userId);
                if (expenseInDb == null)
                    return Unauthorized();

                expenseInDb.Value = model.Value;
                expenseInDb.Description = model.Description;
            }

            _context.SaveChanges();
            return RedirectToAction("Expenses");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
