using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VAS.Models;

namespace VAS.Controllers
{
    public class LoginController : Controller
    {

        RecapEntities1 db = new RecapEntities1();
       
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(User val)
        {

            if (ModelState.IsValid)
            {
                var obj = db.Users.Where(x => x.UserName.Equals(val.UserName) && x.Password.Equals(val.Password)).FirstOrDefault();
                if (obj != null)
                {
                    
                    return RedirectToAction("Index", "registrations");
                }
                else
                {
                    ModelState.AddModelError("", "UserName and Password is Incorrect");

                }
            }

            return View(val);
        }
        public ActionResult Logout()
        {
            
            return RedirectToAction("Index", "Login");
        }

    }
}