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
    public class TourBookingsController : Controller
    {
        private DuLichEntities db = new DuLichEntities();

        // GET: TourBookings
        public ActionResult Index()
        {
            var tourBookings = db.TourBookings.Include(t => t.Customer).Include(t => t.Tour);
            return View(tourBookings.ToList());
        }

        // GET: TourBookings/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TourBooking tourBooking = db.TourBookings.Find(id);
            if (tourBooking == null)
            {
                return HttpNotFound();
            }
            return View(tourBooking);
        }

        // GET: TourBookings/Create
        public ActionResult Create()
        {
            ViewBag.MaKH = new SelectList(db.Customers, "MaKH", "TenKH");
            ViewBag.MaTour = new SelectList(db.Tours, "MaTour", "TenTour");
            return View();
        }

        // POST: TourBookings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaDatTour,MaKH,MaTour,Dongia,SoLuong,ThanhTien,TrangThai")] TourBooking tourBooking)
        {
            if (ModelState.IsValid)
            {
                db.TourBookings.Add(tourBooking);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaKH = new SelectList(db.Customers, "MaKH", "TenKH", tourBooking.MaKH);
            ViewBag.MaTour = new SelectList(db.Tours, "MaTour", "TenTour", tourBooking.MaTour);
            return View(tourBooking);
        }

        // GET: TourBookings/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TourBooking tourBooking = db.TourBookings.Find(id);
            if (tourBooking == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaKH = new SelectList(db.Customers, "MaKH", "TenKH", tourBooking.MaKH);
            ViewBag.MaTour = new SelectList(db.Tours, "MaTour", "TenTour", tourBooking.MaTour);
            return View(tourBooking);
        }

        // POST: TourBookings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaDatTour,MaKH,MaTour,Dongia,SoLuong,ThanhTien,TrangThai")] TourBooking tourBooking)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tourBooking).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaKH = new SelectList(db.Customers, "MaKH", "TenKH", tourBooking.MaKH);
            ViewBag.MaTour = new SelectList(db.Tours, "MaTour", "TenTour", tourBooking.MaTour);
            return View(tourBooking);
        }

        // GET: TourBookings/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TourBooking tourBooking = db.TourBookings.Find(id);
            if (tourBooking == null)
            {
                return HttpNotFound();
            }
            return View(tourBooking);
        }

        // POST: TourBookings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TourBooking tourBooking = db.TourBookings.Find(id);
            db.TourBookings.Remove(tourBooking);
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
