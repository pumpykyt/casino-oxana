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

        public void Bet(int betvalue)
        {
            _context.Users.FirstOrDefault(t => t.Id == User.Identity.GetUserId()).Balance -= betvalue;
            _context.SaveChanges();
        }

       
    }
}