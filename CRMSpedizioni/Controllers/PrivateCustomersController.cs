using CRMSpedizioni.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRMSpedizioni.Controllers
{
    public class PrivateCustomersController : Controller
    {   
        // GET: Customers
        public ActionResult AddCustomer()
        {
            return View();
        }


        // The object current carries the data the user put in the form
        // while the string "type" param carries the value o a selected radioBtn selected by the user
        [HttpPost]
        public ActionResult AddCustomer(PrivateCustomer current)  
        {
            PrivateCustomer.AddCustomer(current);

            return RedirectToAction("Index","Home");
        }
    }
}