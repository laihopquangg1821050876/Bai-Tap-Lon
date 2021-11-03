using BaiTapLon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace BaiTapLon.Controllers
{
    public class AccountController : Controller
    {

        Encrytion encry = new Encrytion();
        BTLDbContext db = new BTLDbContext();
        // GET: Account
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]

        public ActionResult Register(Account acc)
        {
            if (ModelState.IsValid)
            {
                //mã hóa mật khẩu trước khi lưu vào database
                acc.PassWord = encry.PasswordEncrytion(acc.PassWord);
                db.Accounts.Add(acc);
                db.SaveChanges();
                return RedirectToAction("Login", "Account");
            }
            return View(acc);
        }
        [HttpGet]

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public ActionResult Login(Account acc)
        {
            if (ModelState.IsValid)
            {
                string encrytionpass = encry.PasswordEncrytion(acc.PassWord);
                var model = db.Accounts.Where(m => m.UserName == acc.UserName && m.PassWord == encrytionpass).ToList().Count();
                //Thông tin đăng nhập chính xác
                if (model == 1)
                {
                    FormsAuthentication.SetAuthCookie(acc.UserName, true);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Thông tin đăng nhập không chính xác");
                }
            }
            return View(acc);
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }



    }
}