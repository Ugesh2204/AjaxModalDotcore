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

        [HttpPost]
        public IActionResult Contact(Contact model)
        {

            //Now for the jQuery part.We need to attach click event handler to 
            //a button which will send whole form.Correct element to attach to is a “Save” button.
            //We’ll identify it by an additional data-attribute(data-save= "modal"). 
            //Once user clicks “Send”, it should either show errors or disappear in case of success.


            if (ModelState.IsValid)
            {
                db.Contacts.Add(model);
                db.SaveChanges();
            }

            return PartialView("_ContactModalPartial", model);
        }

    }
}
