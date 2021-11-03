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
    [Authorize]
    public class DanhMucHangsController : Controller
    {
        private BTLDbContext db = new BTLDbContext();

        // GET: DanhMucHangs
        public ActionResult Index()
        {
            return View(db.DanhMucHangs.ToList());
        }

        // GET: DanhMucHangs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DanhMucHang danhMucHang = db.DanhMucHangs.Find(id);
            if (danhMucHang == null)
            {
                return HttpNotFound();
            }
            return View(danhMucHang);
        }

        // GET: DanhMucHangs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DanhMucHangs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaHang,TenHang,DonViTinh,SoLuong")] DanhMucHang danhMucHang)
        {
            if (ModelState.IsValid)
            {
                db.DanhMucHangs.Add(danhMucHang);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(danhMucHang);
        }

        // GET: DanhMucHangs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DanhMucHang danhMucHang = db.DanhMucHangs.Find(id);
            if (danhMucHang == null)
            {
                return HttpNotFound();
            }
            return View(danhMucHang);
        }

        // POST: DanhMucHangs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaHang,TenHang,DonViTinh,SoLuong")] DanhMucHang danhMucHang)
        {
            if (ModelState.IsValid)
            {
                db.Entry(danhMucHang).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(danhMucHang);
        }

        // GET: DanhMucHangs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DanhMucHang danhMucHang = db.DanhMucHangs.Find(id);
            if (danhMucHang == null)
            {
                return HttpNotFound();
            }
            return View(danhMucHang);
        }

        // POST: DanhMucHangs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            DanhMucHang danhMucHang = db.DanhMucHangs.Find(id);
            db.DanhMucHangs.Remove(danhMucHang);
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
