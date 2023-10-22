using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bugbusters.Controllers
{
    public class LekcijeController : Controller
    {
        // GET: Lekcije
        public ActionResult Index()
        {
            return View();
        }

        // GET: Lekcije/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Lekcije/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Lekcije/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Lekcije/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Lekcije/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Lekcije/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Lekcije/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
