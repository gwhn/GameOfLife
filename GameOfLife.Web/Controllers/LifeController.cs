﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameOfLife.Web.Controllers
{
    public class LifeController : Controller
    {
        //
        // GET: /Life/

        public ActionResult Index()
        {
            return View();
        }

    }
}
