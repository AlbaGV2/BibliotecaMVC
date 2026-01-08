using BibliotecaMVC.Data.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BibliotecaMVC.Controllers
{
    public class LibroController : Controller
    {
        MyDbContext _context;

        public LibroController(MyDbContext context)
        {
            _context = context;
        }

        // GET: LibroController1
        public ActionResult Index()
        {
            return View();
        }

        //// GET: LibroController1/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        // GET: LibroController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LibroController1/Create
        [HttpPost]
        //[ValidateAntiForgeryToken]
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

        // GET: LibroController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LibroController1/Edit/5
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

        // GET: LibroController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LibroController1/Delete/5
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
