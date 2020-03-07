using casino_oxana_back.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace casino_oxana_back.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();
        // GET: Admin/Admin
        public ActionResult Admin()
        {
            var list = _context.Users.ToList();
            
            return View(list);
        }
    }
}