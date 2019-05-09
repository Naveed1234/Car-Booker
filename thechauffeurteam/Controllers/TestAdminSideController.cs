using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using thechauffeurteam.DAL;

namespace thechauffeurteam.Controllers
{
    public class TestAdminSideController : Controller
    {
        private MyContext db = new MyContext();
        // GET: TestAdminSide
        public ActionResult BokeJob()
        {
            ViewBag.pickUpPostcode = new SelectList(db.PostCodes.ToList(), "Id", "PostCodeValue");
            ViewBag.dropOffPostcode = new SelectList(db.PostCodes.ToList(), "Id", "PostCodeValue");

            return View();
        }

        public ActionResult Dashboard()
        {
            return View();
        }

        public ActionResult Scroll()
        {
            return View();
        }


        public ActionResult BookingJob()
        {
            return View();
        }



    }
}