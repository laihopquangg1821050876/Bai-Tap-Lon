using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BaiTapLon.Models;

namespace BaiTapLon.Controllers
{
    public class phieuxuatsController : Controller
    {
        private BTLDbContext db = new BTLDbContext();
        [Authorize]
        // GET: phieuxuats
        public ActionResult Index()
        {
            var phieuxuat = db.phieuxuat.Include(p => p.DonHangs);
            return View(phieuxuat.ToList());
        }

        // GET: phieuxuats/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            phieuxuat phieuxuat = db.phieuxuat.Find(id);
            if (phieuxuat == null)
            {
                return HttpNotFound();
            }
            return View(phieuxuat);
        }

        // GET: phieuxuats/Create
        public ActionResult Create()
        {
            ViewBag.DonHangID = new SelectList(db.DonHangs, "DonHangID", "MaKH");
            return View();
        }

        // POST: phieuxuats/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaNV,TenNV,DonHangID,TenHang,Soluong,thanhtien,Ngaytao")] phieuxuat phieuxuat)
        {
            if (ModelState.IsValid)
            {
                db.phieuxuat.Add(phieuxuat);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DonHangID = new SelectList(db.DonHangs, "DonHangID", "MaKH", phieuxuat.DonHangID);
            return View(phieuxuat);
        }

        // GET: phieuxuats/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            phieuxuat phieuxuat = db.phieuxuat.Find(id);
            if (phieuxuat == null)
            {
                return HttpNotFound();
            }
            ViewBag.DonHangID = new SelectList(db.DonHangs, "DonHangID", "MaKH", phieuxuat.DonHangID);
            return View(phieuxuat);
        }

        // POST: phieuxuats/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaNV,TenNV,DonHangID,TenHang,Soluong,thanhtien,Ngaytao")] phieuxuat phieuxuat)
        {
            if (ModelState.IsValid)
            {
                db.Entry(phieuxuat).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DonHangID = new SelectList(db.DonHangs, "DonHangID", "MaKH", phieuxuat.DonHangID);
            return View(phieuxuat);
        }

        // GET: phieuxuats/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            phieuxuat phieuxuat = db.phieuxuat.Find(id);
            if (phieuxuat == null)
            {
                return HttpNotFound();
            }
            return View(phieuxuat);
        }

        // POST: phieuxuats/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            phieuxuat phieuxuat = db.phieuxuat.Find(id);
            db.phieuxuat.Remove(phieuxuat);
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
