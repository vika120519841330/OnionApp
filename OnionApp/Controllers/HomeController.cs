using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace OnionApp.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return ("WELCOME HOME PAGE!!!");
        }
    }
}
