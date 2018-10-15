using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataStructuresGroup.Controllers
{
    public class StackController : Controller
    {
        public 

        static Stack<string> myStack = new Stack<string>();
        
        // GET: Stack
        public ActionResult Index()
        {

            ViewBag.Stack = myStack;
            ViewBag.Hide = "StackHide";
            //ViewBag.Search = search;
            return View();
        }

        

        public ActionResult AddOne()
        {
            myStack.Push(
            "New Entry " + (myStack.Count + 1)
            );

            //ViewBag.Stack=myStack;
            return View("Index");
        }

        public ActionResult HugeList()
        {
            myStack.Clear();
            for (int iCount=0; iCount<2000; iCount++)
            {
                myStack.Push(
                    "New Entry " + (myStack.Count + 1)
                    );
                //ViewBag.Stack = myStack;

            }
            return View("Index");
        }

        public ActionResult DisplayStack()
        {
            ViewBag.Hide = "StackShow";
            ViewBag.Stack = myStack;
            return View("Index"); 
            
        }

        public ActionResult DeleteStack()
        {
            myStack.Pop();

            ViewBag.Stack = myStack;
            return View("Index");

        }

        public ActionResult ClearStack()
        {
            myStack.Clear();

            ViewBag.Stack = myStack;
            return View("Index");

        }

        public ActionResult SearchStack()
        {
            //make input tag
            //var search = "<input type='text' id='mySearch' onkeyup='myFunction()' placeholder='Search..' title='Type in an entry'>";
            //

            /*foreach (string check in myStack)
            {
                if (check == "New Entry 5")
                {
                    return 
                }
            }*/
            ViewBag.Stack = myStack;
            foreach(var i in myStack)
            {
                if (i=="New Entry 7")
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


            return View("Index");
        }

        public ActionResult MainMenu()
        {
            return RedirectToAction("Index","Index");
        }
    }
}