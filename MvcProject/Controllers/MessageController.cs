using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProject.Controllers
{
    public class MessageController : Controller
    {
        MessageManager mm = new MessageManager(new EfMessageDal());
        ContactManager ctm = new ContactManager(new EfContactDal());
        MessageValidator messagevalidator = new MessageValidator();

        // GET: Message

        public ActionResult Inbox()
        {
            var messagelist = mm.GetListInbox();
            return View(messagelist);
        }


        public ActionResult Sendbox()
        {
            var messagelist = mm.GetListSendbox();
            return View(messagelist);
        }

        public ActionResult GetInBoxMessageDetails(int id)
        {
            var values = ctm.GetByID(id);
            return View(values);
        }

        public ActionResult GetSendBoxMessageDetails(int id)
        {
            var values = ctm.GetByID(id);
            return View(values);
        }

        [HttpGet]
        public ActionResult NewMessage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewMessage(Message p)
        {
            
            return View();
        }
    }
}