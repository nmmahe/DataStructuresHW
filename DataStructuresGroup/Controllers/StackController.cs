using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataStructuresGroup.Controllers
{
    public class StackController : Controller
    {

        static Stack<string> myStack = new Stack<string>();
        // GET: Stack
        public ActionResult Index()
        {

            ViewBag.Stack = myStack;
            return View();
        }

        

        public ActionResult AddOne()
        {
            myStack.Push(
            "New Entry " + (myStack.Count + 1)
            );

            ViewBag.Stack = myStack;
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
                ViewBag.Stack = myStack;

            }
            return View("Index");
        }
    }
}