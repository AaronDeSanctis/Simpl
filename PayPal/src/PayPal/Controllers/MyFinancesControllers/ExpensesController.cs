using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using PayPal.Models;
using PayPal.Models.FinanceModel;

namespace PayPal.Controllers
{
    public class ExpensesController : Controller
    {
        private ApplicationDbContext _context;

        public ExpensesController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Expenses
        public IActionResult Index()
        {
            var applicationDbContext = _context.Expenses.Include(e => e.FakeTransactions).Include(e => e.TodaysTransactions).Include(e => e.TotalTransactions);
            return View(applicationDbContext.ToList());
        }

        // GET: Expenses/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Expense expense = _context.Expenses.Single(m => m.Id == id);
            if (expense == null)
            {
                return HttpNotFound();
            }

            return View(expense);
        }

        // GET: Expenses/Create
        public IActionResult Create()
        {
            ViewData["FakeTransactionsId"] = new SelectList(_context.FakeTransactions, "Id", "FakeTransactions");
            ViewData["TodaysTransactionsId"] = new SelectList(_context.TodaysTransactions, "Id", "TodaysTransactions");
            ViewData["TotalTransactionsId"] = new SelectList(_context.TotalTransactions, "Id", "TotalTransactions");
            return View();
        }

        // POST: Expenses/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Expense expense)
        {
            if (ModelState.IsValid)
            {
                _context.Expenses.Add(expense);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewData["FakeTransactionsId"] = new SelectList(_context.FakeTransactions, "Id", "FakeTransactions", expense.FakeTransactionsId);
            ViewData["TodaysTransactionsId"] = new SelectList(_context.TodaysTransactions, "Id", "TodaysTransactions", expense.TodaysTransactionsId);
            ViewData["TotalTransactionsId"] = new SelectList(_context.TotalTransactions, "Id", "TotalTransactions", expense.TotalTransactionsId);
            return View(expense);
        }

        // GET: Expenses/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Expense expense = _context.Expenses.Single(m => m.Id == id);
            if (expense == null)
            {
                return HttpNotFound();
            }
            ViewData["FakeTransactionsId"] = new SelectList(_context.FakeTransactions, "Id", "FakeTransactions", expense.FakeTransactionsId);
            ViewData["TodaysTransactionsId"] = new SelectList(_context.TodaysTransactions, "Id", "TodaysTransactions", expense.TodaysTransactionsId);
            ViewData["TotalTransactionsId"] = new SelectList(_context.TotalTransactions, "Id", "TotalTransactions", expense.TotalTransactionsId);
            return View(expense);
        }

        // POST: Expenses/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Expense expense)
        {
            if (ModelState.IsValid)
            {
                _context.Update(expense);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewData["FakeTransactionsId"] = new SelectList(_context.FakeTransactions, "Id", "FakeTransactions", expense.FakeTransactionsId);
            ViewData["TodaysTransactionsId"] = new SelectList(_context.TodaysTransactions, "Id", "TodaysTransactions", expense.TodaysTransactionsId);
            ViewData["TotalTransactionsId"] = new SelectList(_context.TotalTransactions, "Id", "TotalTransactions", expense.TotalTransactionsId);
            return View(expense);
        }

        // GET: Expenses/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Expense expense = _context.Expenses.Single(m => m.Id == id);
            if (expense == null)
            {
                return HttpNotFound();
            }

            return View(expense);
        }

        // POST: Expenses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            Expense expense = _context.Expenses.Single(m => m.Id == id);
            _context.Expenses.Remove(expense);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
