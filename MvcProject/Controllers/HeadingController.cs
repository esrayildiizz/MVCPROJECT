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
        CategoryManager cm = new CategoryManager(new EfCategoryDal());//Category çağırabilmem için nesne üretmem gerekir.

        // GET: Heading
        public ActionResult Index()
        {
            var headingvalues = hm.GetList();
            return View(headingvalues);
        }

        [HttpGet]
        public ActionResult AddHeading()
        {
            List<SelectListItem> valuecategory = (from x in cm.GetList()
                                                  select new SelectListItem
                                                  { 
                                                      Text=x.CategoryName,
                                                      Value=x.CategoryID.ToString()
                                                  }).ToList();
            ViewBag.vlc = valuecategory;
            return View();
        }

        [HttpPost]
        public ActionResult AddHeading(Heading p)
        {
            p.HeadingDate = DateTime.Parse( DateTime.Now.ToShortDateString());
            hm.HeadingAdd(p);
            return RedirectToAction("Index");
        }
    }
}