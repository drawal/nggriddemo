﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace JsonWithWebApi.Controllers
{
    public class TestingController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
