using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataStructuresGroup.Controllers
{
    public class DictionaryController : Controller
    {
        static Dictionary<string, int> myDictionary = new Dictionary<string, int>();
        // GET: Dictionary
        public ActionResult Index()
        {
            ViewBag.Dictionary = myDictionary;
            ViewBag.Hide = "StackHide";
            return View();
        }

        public ActionResult AddOne()
        {
            myDictionary.Add(
            "New Entry " + (myDictionary.Count + 1), myDictionary.Count + 1
            );
            
            return View("Index");
        }

        public ActionResult HugeList()
        {
            myDictionary.Clear();
            for (int iCount = 0; iCount < 2000; iCount++)
            {
                myDictionary.Add(
            "New Entry " + (myDictionary.Count + 1), myDictionary.Count + 1
            );
            }

            return View("Index");
        }

        public ActionResult DisplayDictionary()
        {
            ViewBag.Hide = "StackShow";
            ViewBag.Dictionary = myDictionary.Keys;

            return View("Index");
        }

        public ActionResult DeleteDictionary()
        {
            myDictionary.Remove("New Entry " + (myDictionary.Count));

            ViewBag.Dictionary = myDictionary;
            return View("Index");

        }

        public ActionResult ClearDictionary()
        {
            myDictionary.Clear();

            ViewBag.Dictionary = myDictionary;
            return View("Index");

        }

        public ActionResult SearchDictionary()
        {
            ViewBag.Dictionary = myDictionary;
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();

            sw.Start();

            foreach (var i in myDictionary.Keys)
            {
                if (i == "New Entry 7")
                {
                    ViewBag.Search = "New Entry 7 is found!";
                    break;
                }
                else
                {
                    ViewBag.Search = "New Entry 7 is not found!";
                }
            }

            sw.Stop();

            TimeSpan ts = sw.Elapsed;

            ViewBag.StopWatch = ts;


            return View("Index");

        }

        public ActionResult MainMenu()
        {
            return RedirectToAction("Index", "Index");
        }
    }
}

//im pushing it -zack