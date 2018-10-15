using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace DataStructuresGroup.Controllers
{
    public class QueueController : Controller
    {
        public
        static Queue<string> myQueue = new Queue<string>();
        // GET: Queue
        public ActionResult Index()
        {
            ViewBag.Queue = myQueue;
            ViewBag.Hide = "QueueHide";
            //ViewBag.Search = search;
            return View();
        }
        public ActionResult AddOne()
        {
            myQueue.Enqueue(
            "New Entry " + (myQueue.Count + 1)
            );
            return View("Index");
        }
        public ActionResult HugeList()
        {
            myQueue.Clear();
            for (int iCount = 0; iCount < 2000; iCount++)
            {
                myQueue.Enqueue(
                    "New Entry " + (myQueue.Count + 1)
                    );
            }
            return View("Index");
        }
        public ActionResult DisplayQueue()
        {
            if (myQueue.Count == 0)
            {
                ViewBag.errormsg = "No entries in queue";
            }
            else
            {
                ViewBag.Hide = "QueueShow";
                ViewBag.Queue = myQueue;
            }
            return View("Index");
        }
        public ActionResult DeleteQueue()
        {
            if (myQueue.Count != 0)
            {
                if (myQueue.Count != 0)
                {
                    myQueue.Dequeue();
                }
                else if (myQueue.Count == 0)
                {
                    ViewBag.errormsg = "No entries in queue";
                }
            }
            ViewBag.Queue = myQueue;
            return View("Index");
        }
        public ActionResult ClearQueue()
        {
            myQueue.Clear();
            ViewBag.Queue = myQueue;
            return View("Index");
        }
        public ActionResult SearchQueue()
        {
            if (myQueue.Count != 0)
            {
                ViewBag.Queue = myQueue;
                foreach (var i in myQueue)
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
                System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
                sw.Start();
                //loop to do all the work
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