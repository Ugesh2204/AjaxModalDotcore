using AjaxModal.Data;
using AjaxModal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AjaxModal.Controllers
{
    public class HomeController : Controller
    {
        readonly AppDbContext db;
        public HomeController(AppDbContext _db)
        {
            db = _db;
        }
        

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            var model = new Contact { };

            return PartialView("_ContactModalPartial", model);
        }

        //[HttpPost]
        //public IActionResult Contact(Contact model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Contacts.Add(model);
        //        db.SaveChanges();
        //    }

        //    return PartialView("_ContactModalPartial", model);
        //}

    }
}
