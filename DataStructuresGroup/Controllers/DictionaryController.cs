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
            return View("Index");
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
            if (myDictionary.Count == 0)
            {
                ViewBag.errormsg = "No entries in dictionary";
            }
            else
            {
                ViewBag.Hide = "StackShow";
                ViewBag.Dictionary = myDictionary.Keys;
            }

            return View("Index");
        }

        public ActionResult DeleteDictionary()
        {
            if (myDictionary.Count > 0)
            {
                myDictionary.Remove("New Entry " + (myDictionary.Count));
            }
            else
            {
                ViewBag.errormsg = "No entries in dictionary";
            }

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
            if (myDictionary.Count != 0)
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
            }
            else
            {
                ViewBag.errormsg = "No entries found";
            }


            return View("Index");

        }

        public ActionResult MainMenu()
        {
            return RedirectToAction("Index", "Index");
        }
    }
}