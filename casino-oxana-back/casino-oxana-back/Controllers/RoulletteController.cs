using casino_oxana_back.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace casino_oxana_back.Controllers
{
    public class RoulletteController : Controller
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();
        // GET: Roullette
        public ActionResult Roullette()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles="User")]
        public JsonResult Bet(ObjViewModel model)
        {
            if (Request.IsAuthenticated)
            {
                string thisUserId = User.Identity.GetUserId();
                _context.Users.FirstOrDefault(t => t.Id == thisUserId).Balance -= model.Value;
                _context.SaveChanges();
            }

            return Json("OK");
        }

        [HttpPost]
        [Authorize(Roles = "User")]
        public JsonResult BetResult(ObjViewModel model)
        {
            if (Request.IsAuthenticated)
            {
                string thisUserId = User.Identity.GetUserId();
                _context.Users.FirstOrDefault(t => t.Id == thisUserId).Balance += model.Value;
                _context.SaveChanges();
            }

            return Json("OK");
        }


    }
}