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
            var list = _context.userBalanceModels.ToList();
            var userId = User.Identity.GetUserId();
            var user = list.FirstOrDefault(t => t.Id == userId);
            return View(user);
        }
    }
}