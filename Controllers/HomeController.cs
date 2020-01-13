using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAISY_6.Models.ViewModels;

namespace DAISY_6.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }




        public ActionResult DaisyCase()
        {

            ViewBag.Message = "Create Daisy Case";
            // Call The API To Update the DAISY DATBASE THROUGH THE Stored Proc

            return View();

        }

        [HttpPost]
        public ActionResult DaisyCase(DaisyCase model)
        {
            // We neeed to update the Database with the Model here.
            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            ViewBag.Message = "Add Daisy Case";
            // Call The API To Update the DAISY DATBASE THROUGH THE Stored Proc

            return View();

        }






            public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();

        }
    }
}