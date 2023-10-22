using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bugbusters.Controllers
{
    public class KisikController : Controller
    {
        // GET: Kisik
        public ActionResult Index()
        {
            return View();
        }

        // GET: Kisik/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Kisik/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Kisik/Create
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

        // GET: Kisik/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Kisik/Edit/5
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

        // GET: Kisik/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Kisik/Delete/5
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
