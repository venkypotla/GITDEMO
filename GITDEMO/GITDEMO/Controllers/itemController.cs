using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GITDEMO.Controllers
{
    public class itemController : Controller
    {
        // GET: item
        public ActionResult Index()
        {
            return View();
        }
    }
}