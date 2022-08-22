using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProject.Controllers
{
    public class ContactController : Controller
    {
        ContactManager ctm = new ContactManager(new EfContactDal());
        ContactValidator cv = new ContactValidator();

        // GET: Contact
        public ActionResult Index()
        {
            var contactvalues = ctm.GetList();
            return View(contactvalues);
        }
    }
}