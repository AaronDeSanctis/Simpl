using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using PayPal.Models;
using PayPal.Models.FinanceModel;

namespace PayPal.Controllers
{
    public class BenchmarksController : Controller
    {
        private ApplicationDbContext _context;

        public BenchmarksController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Benchmarks
        public IActionResult Index()
        {
            var applicationDbContext = _context.Benchmarks.Include(b => b.ActualReport).Include(b => b.BenchmarkContainer).Include(b => b.ExpectedReport);
            return View(applicationDbContext.ToList());
        }

        // GET: Benchmarks/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Benchmark benchmark = _context.Benchmarks.Single(m => m.Id == id);
            if (benchmark == null)
            {
                return HttpNotFound();
            }

            return View(benchmark);
        }

        // GET: Benchmarks/Create
        public IActionResult Create()
        {
            ViewData["ActualReportId"] = new SelectList(_context.ActualReports, "Id", "ActualReport");
            ViewData["BenchmarkContainerId"] = new SelectList(_context.BenchmarkContainers, "Id", "BenchmarkContainer");
            ViewData["ExpectedReportId"] = new SelectList(_context.ExpectedReports, "Id", "ExpectedReport");
            return View();
        }

        // POST: Benchmarks/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Benchmark benchmark)
        {
            if (ModelState.IsValid)
            {
                _context.Benchmarks.Add(benchmark);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewData["ActualReportId"] = new SelectList(_context.ActualReports, "Id", "ActualReport", benchmark.ActualReportId);
            ViewData["BenchmarkContainerId"] = new SelectList(_context.BenchmarkContainers, "Id", "BenchmarkContainer", benchmark.BenchmarkContainerId);
            ViewData["ExpectedReportId"] = new SelectList(_context.ExpectedReports, "Id", "ExpectedReport", benchmark.ExpectedReportId);
            return View(benchmark);
        }

        // GET: Benchmarks/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Benchmark benchmark = _context.Benchmarks.Single(m => m.Id == id);
            if (benchmark == null)
            {
                return HttpNotFound();
            }
            ViewData["ActualReportId"] = new SelectList(_context.ActualReports, "Id", "ActualReport", benchmark.ActualReportId);
            ViewData["BenchmarkContainerId"] = new SelectList(_context.BenchmarkContainers, "Id", "BenchmarkContainer", benchmark.BenchmarkContainerId);
            ViewData["ExpectedReportId"] = new SelectList(_context.ExpectedReports, "Id", "ExpectedReport", benchmark.ExpectedReportId);
            return View(benchmark);
        }

        // POST: Benchmarks/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Benchmark benchmark)
        {
            if (ModelState.IsValid)
            {
                _context.Update(benchmark);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewData["ActualReportId"] = new SelectList(_context.ActualReports, "Id", "ActualReport", benchmark.ActualReportId);
            ViewData["BenchmarkContainerId"] = new SelectList(_context.BenchmarkContainers, "Id", "BenchmarkContainer", benchmark.BenchmarkContainerId);
            ViewData["ExpectedReportId"] = new SelectList(_context.ExpectedReports, "Id", "ExpectedReport", benchmark.ExpectedReportId);
            return View(benchmark);
        }

        // GET: Benchmarks/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Benchmark benchmark = _context.Benchmarks.Single(m => m.Id == id);
            if (benchmark == null)
            {
                return HttpNotFound();
            }

            return View(benchmark);
        }

        // POST: Benchmarks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            Benchmark benchmark = _context.Benchmarks.Single(m => m.Id == id);
            _context.Benchmarks.Remove(benchmark);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
