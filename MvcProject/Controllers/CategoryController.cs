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
    public class CategoryController : Controller
    {
        // GET: Category
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetCategoryList()
        {
            var categoryvalues = cm.GetList();
            return View(categoryvalues);
        }


        [HttpGet] //sayfa yüklendiği zaman çalışır.
        public ActionResult AddCategory()
        {
            return View();
        }

        [HttpPost] //sayfamdaki herhangi bir butona bastığımda çalışır.
        public ActionResult AddCategory(Category p)
        {
            // cm.CategoryAddBL(p);
            return RedirectToAction("GetCategoryList");
        }
    }
}