using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProject.Controllers
{
    public class HeadingController : Controller
    {

        HeadingManager hm = new HeadingManager(new EfHeadingDal()); //hm adından bir nesne tanımladık.
        // GET: Heading
        public ActionResult Index()
        {
            var headingvalues = hm.GetList();
            return View(headingvalues);
        }

        [HttpGet]
        public ActionResult AddHeading()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult AddHeading(Heading p)
        {
            hm.HeadingAdd(p);
            return RedirectToAction("Index");
        }
    }
}