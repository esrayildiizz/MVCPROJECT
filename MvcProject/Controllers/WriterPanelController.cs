﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProject.Controllers
{
    public class WriterPanelController : Controller
    {
        HeadingManager hm = new HeadingManager(new EfHeadingDal());
        // GET: WriterPanel

        public ActionResult WriterProfile()
        {
            return View();
        }
        public ActionResult MyHeading(int id)
        {
            id = 4;
            var values = hm.GetListByWriter(id);
            return View(values);
        }
    }
}