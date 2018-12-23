using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMVCWebApp.Controllers
{
    public class DateController : Controller
    {
        // GET: Date
        public ActionResult Index()
        {
            return View();
        }

        public IActionResult Day(int offset)
        {

            DateTime test = DateTime.Now;
            return new ContentResult { Content = "Today's date is: " + test.AddDays(offset) };
        }

        // GET: Date/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Date/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Date/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Date/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Date/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Date/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Date/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}