using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using PayPal.Models;
using PayPal.Models.FinanceModel;

namespace PayPal.Controllers
{
    public class FakeTransactionsController : Controller
    {
        private ApplicationDbContext _context;

        public FakeTransactionsController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: FakeTransactions
        public IActionResult Index()
        {
            var applicationDbContext = _context.FakeTransactions.Include(f => f.Expense);
            return View(applicationDbContext.ToList());
        }

        // GET: FakeTransactions/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            FakeTransaction fakeTransaction = _context.FakeTransactions.Single(m => m.Id == id);
            if (fakeTransaction == null)
            {
                return HttpNotFound();
            }

            return View(fakeTransaction);
        }

        // GET: FakeTransactions/Create
        public IActionResult Create()
        {
            ViewData["ExpenseId"] = new SelectList(_context.Expenses, "Id", "Expense");
            return View();
        }

        // POST: FakeTransactions/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(FakeTransaction fakeTransaction)
        {
            if (ModelState.IsValid)
            {
                _context.FakeTransactions.Add(fakeTransaction);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewData["ExpenseId"] = new SelectList(_context.Expenses, "Id", "Expense", fakeTransaction.ExpenseId);
            return View(fakeTransaction);
        }

        // GET: FakeTransactions/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            FakeTransaction fakeTransaction = _context.FakeTransactions.Single(m => m.Id == id);
            if (fakeTransaction == null)
            {
                return HttpNotFound();
            }
            ViewData["ExpenseId"] = new SelectList(_context.Expenses, "Id", "Expense", fakeTransaction.ExpenseId);
            return View(fakeTransaction);
        }

        // POST: FakeTransactions/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(FakeTransaction fakeTransaction)
        {
            if (ModelState.IsValid)
            {
                _context.Update(fakeTransaction);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewData["ExpenseId"] = new SelectList(_context.Expenses, "Id", "Expense", fakeTransaction.ExpenseId);
            return View(fakeTransaction);
        }

        // GET: FakeTransactions/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            FakeTransaction fakeTransaction = _context.FakeTransactions.Single(m => m.Id == id);
            if (fakeTransaction == null)
            {
                return HttpNotFound();
            }

            return View(fakeTransaction);
        }

        // POST: FakeTransactions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            FakeTransaction fakeTransaction = _context.FakeTransactions.Single(m => m.Id == id);
            _context.FakeTransactions.Remove(fakeTransaction);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
