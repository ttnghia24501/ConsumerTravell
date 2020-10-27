using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ConsumerTravell.Models;

namespace ConsumerTravell.Controllers
{
    public class ProvinceCitiesController : Controller
    {
        private DuLichEntities db = new DuLichEntities();

        // GET: ProvinceCities
        public ActionResult Index()
        {
            return View(db.ProvinceCities.ToList());
        }

        // GET: ProvinceCities/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProvinceCity provinceCity = db.ProvinceCities.Find(id);
            if (provinceCity == null)
            {
                return HttpNotFound();
            }
            return View(provinceCity);
        }

        // GET: ProvinceCities/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProvinceCities/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaTinh,TenTinh,TenTp")] ProvinceCity provinceCity)
        {
            if (ModelState.IsValid)
            {
                db.ProvinceCities.Add(provinceCity);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(provinceCity);
        }

        // GET: ProvinceCities/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProvinceCity provinceCity = db.ProvinceCities.Find(id);
            if (provinceCity == null)
            {
                return HttpNotFound();
            }
            return View(provinceCity);
        }

        // POST: ProvinceCities/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaTinh,TenTinh,TenTp")] ProvinceCity provinceCity)
        {
            if (ModelState.IsValid)
            {
                db.Entry(provinceCity).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(provinceCity);
        }

        // GET: ProvinceCities/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProvinceCity provinceCity = db.ProvinceCities.Find(id);
            if (provinceCity == null)
            {
                return HttpNotFound();
            }
            return View(provinceCity);
        }

        // POST: ProvinceCities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ProvinceCity provinceCity = db.ProvinceCities.Find(id);
            db.ProvinceCities.Remove(provinceCity);
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
