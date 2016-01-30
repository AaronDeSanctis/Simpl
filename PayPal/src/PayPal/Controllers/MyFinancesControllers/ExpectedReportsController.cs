using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using PayPal.Models;
using PayPal.Models.FinanceModel;

namespace PayPal.Controllers
{
    public class ExpectedReportsController : Controller
    {
        private ApplicationDbContext _context;

        public ExpectedReportsController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: ExpectedReports
        public IActionResult Index()
        {
            return View(_context.ExpectedReports.ToList());
        }

        // GET: ExpectedReports/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            ExpectedReport expectedReport = _context.ExpectedReports.Single(m => m.Id == id);
            if (expectedReport == null)
            {
                return HttpNotFound();
            }

            return View(expectedReport);
        }

        // GET: ExpectedReports/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ExpectedReports/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ExpectedReport expectedReport)
        {
            if (ModelState.IsValid)
            {
                _context.ExpectedReports.Add(expectedReport);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(expectedReport);
        }

        // GET: ExpectedReports/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            ExpectedReport expectedReport = _context.ExpectedReports.Single(m => m.Id == id);
            if (expectedReport == null)
            {
                return HttpNotFound();
            }
            return View(expectedReport);
        }

        // POST: ExpectedReports/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(ExpectedReport expectedReport)
        {
            if (ModelState.IsValid)
            {
                _context.Update(expectedReport);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(expectedReport);
        }

        // GET: ExpectedReports/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            ExpectedReport expectedReport = _context.ExpectedReports.Single(m => m.Id == id);
            if (expectedReport == null)
            {
                return HttpNotFound();
            }

            return View(expectedReport);
        }

        // POST: ExpectedReports/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            ExpectedReport expectedReport = _context.ExpectedReports.Single(m => m.Id == id);
            _context.ExpectedReports.Remove(expectedReport);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
