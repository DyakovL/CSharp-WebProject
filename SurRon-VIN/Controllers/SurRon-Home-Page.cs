using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SurRon_VIN.Controllers
{
    public class SurRon_Home_Page : Controller
    {


        private readonly ILogger<SurRon_Home_Page> _logger;

        public SurRon_Home_Page(ILogger<SurRon_Home_Page> logger)
        {
            _logger = logger;
        }


        // GET: SurRon_Home_Page
        public ActionResult Index()
        {
            return View();
        }

        // GET: SurRon_Home_Page/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SurRon_Home_Page/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SurRon_Home_Page/Create
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

        // GET: SurRon_Home_Page/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SurRon_Home_Page/Edit/5
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

        // GET: SurRon_Home_Page/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SurRon_Home_Page/Delete/5
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
