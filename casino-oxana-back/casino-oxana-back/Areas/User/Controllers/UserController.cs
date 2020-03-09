using casino_oxana_back.Models;
using System;
using System.Collections.Generic;
using Microsoft.AspNet.Identity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using casino_oxana_back.Areas.User.Models;
using System.Data.Entity;

namespace casino_oxana_back.Areas.User.Controllers
{
    public class UserController : Controller
    {
        ApplicationDbContext _context = new ApplicationDbContext();
        // GET: User/User
        public ActionResult Userloh()
        {
            UserViewModel model = new UserViewModel();

            
            var userId = User.Identity.GetUserId();
            var user = _context.Users.FirstOrDefault(t => t.Id == userId);
            var userInfo = _context.userBalanceModels.FirstOrDefault(t => t.Id == userId);



            model.Email = model.Email;
            model.Balance = userInfo.Balance;


            return View(user);
        }
    }
}