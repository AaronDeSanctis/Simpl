using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using PayPal.Models;
using PayPal.Models.FinanceModel;

namespace PayPal.Controllers
{
    public class GoalsController : Controller
    {
        private ApplicationDbContext _context;

        public GoalsController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Goals
        public IActionResult Index()
        {
            var applicationDbContext = _context.Goals.Include(g => g.BenchmarkContainer);
            return View(applicationDbContext.ToList());
        }

        // GET: Goals/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Goal goal = _context.Goals.Single(m => m.Id == id);
            if (goal == null)
            {
                return HttpNotFound();
            }

            return View(goal);
        }

        // GET: Goals/Create
        public IActionResult Create()
        {
            ViewData["BenchmarkContainerId"] = new SelectList(_context.BenchmarkContainers, "Id", "BenchmarkContainer");
            return View();
        }

        // POST: Goals/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Goal goal)
        {
            if (ModelState.IsValid)
            {
                _context.Goals.Add(goal);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewData["BenchmarkContainerId"] = new SelectList(_context.BenchmarkContainers, "Id", "BenchmarkContainer", goal.BenchmarkContainerId);
            return View(goal);
        }

        // GET: Goals/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Goal goal = _context.Goals.Single(m => m.Id == id);
            if (goal == null)
            {
                return HttpNotFound();
            }
            ViewData["BenchmarkContainerId"] = new SelectList(_context.BenchmarkContainers, "Id", "BenchmarkContainer", goal.BenchmarkContainerId);
            return View(goal);
        }

        // POST: Goals/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Goal goal)
        {
            if (ModelState.IsValid)
            {
                _context.Update(goal);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewData["BenchmarkContainerId"] = new SelectList(_context.BenchmarkContainers, "Id", "BenchmarkContainer", goal.BenchmarkContainerId);
            return View(goal);
        }

        // GET: Goals/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Goal goal = _context.Goals.Single(m => m.Id == id);
            if (goal == null)
            {
                return HttpNotFound();
            }

            return View(goal);
        }

        // POST: Goals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            Goal goal = _context.Goals.Single(m => m.Id == id);
            _context.Goals.Remove(goal);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
