using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CW_ADB_MVC.Models;

namespace CW_ADB_MVC.Controllers
{
    public class FuelsController : Controller
    {
        private toplivoEntities db = new toplivoEntities();

        
        // GET: Fuels
        public ActionResult Index(string FuelTypeFind="")
        {
            ViewBag.Title = "Виды топлива";

            var fuels = from m in db.Fuels
                        where m.FuelType.StartsWith(FuelTypeFind)
                             select m;
            return View(fuels.ToList());
        }

        // GET: Fuels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fuels fuels = db.Fuels.Find(id);
            if (fuels == null)
            {
                return HttpNotFound();
            }
            return View(fuels);
        }

        // GET: Fuels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Fuels/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FuelID,FuelType,FuelDensity")] Fuels fuels)
        {
            if (ModelState.IsValid)
            {
                db.Fuels.Add(fuels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(fuels);
        }

        // GET: Fuels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fuels fuels = db.Fuels.Find(id);
            if (fuels == null)
            {
                return HttpNotFound();
            }
            return View(fuels);
        }

        // POST: Fuels/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FuelID,FuelType,FuelDensity")] Fuels fuels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fuels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(fuels);
        }

        // GET: Fuels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fuels fuels = db.Fuels.Find(id);
            if (fuels == null)
            {
                return HttpNotFound();
            }
            return View(fuels);
        }

        // POST: Fuels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Fuels fuels = db.Fuels.Find(id);
            db.Fuels.Remove(fuels);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
