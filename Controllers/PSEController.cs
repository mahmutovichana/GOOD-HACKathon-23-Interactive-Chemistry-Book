using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bugbusters.Controllers
{
    public class PSEController : Controller
    {
        // GET: PSEController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PSEController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PSEController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PSEController/Create
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

        // GET: PSEController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PSEController/Edit/5
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

        // GET: PSEController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PSEController/Delete/5
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
