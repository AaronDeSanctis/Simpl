using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using PayPal.Models;
using PayPal.Models.FinanceModel;

namespace PayPal.Controllers
{
    public class ActualReportsController : Controller
    {
        private ApplicationDbContext _context;

        public ActualReportsController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: ActualReports
        public IActionResult Index()
        {
            return View(_context.ActualReports.ToList());
        }

        // GET: ActualReports/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            ActualReport actualReport = _context.ActualReports.Single(m => m.Id == id);
            if (actualReport == null)
            {
                return HttpNotFound();
            }

            return View(actualReport);
        }

        // GET: ActualReports/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ActualReports/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ActualReport actualReport)
        {
            if (ModelState.IsValid)
            {
                _context.ActualReports.Add(actualReport);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(actualReport);
        }

        // GET: ActualReports/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            ActualReport actualReport = _context.ActualReports.Single(m => m.Id == id);
            if (actualReport == null)
            {
                return HttpNotFound();
            }
            return View(actualReport);
        }

        // POST: ActualReports/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(ActualReport actualReport)
        {
            if (ModelState.IsValid)
            {
                _context.Update(actualReport);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(actualReport);
        }

        // GET: ActualReports/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            ActualReport actualReport = _context.ActualReports.Single(m => m.Id == id);
            if (actualReport == null)
            {
                return HttpNotFound();
            }

            return View(actualReport);
        }

        // POST: ActualReports/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            ActualReport actualReport = _context.ActualReports.Single(m => m.Id == id);
            _context.ActualReports.Remove(actualReport);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
