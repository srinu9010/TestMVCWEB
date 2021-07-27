using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class DatasController : Controller
    {
        public ActionResult About()
        {
            Session["LabID"] = 1;

           // ViewBag.Message = " Data's and Client Your application description page.";

            ViewBag.Message = " Data's  MDI dell  and Client Your application description page.";

            return View();
        }

        // GET: Datas
        public ActionResult Index()
        {
            return View();
        }

        // GET: Datas/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Datas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Datas/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Datas/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Datas/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Datas/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Datas/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
