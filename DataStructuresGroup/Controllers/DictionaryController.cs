using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataStructuresGroup.Controllers
{
    public class DictionaryController : Controller
    {
        // GET: Dictionary
        public ActionResult Index()
        {
            //ViewBag.Dictionary = myDictionary;
            return View();
        }
    }
}

//im pushing it -zack