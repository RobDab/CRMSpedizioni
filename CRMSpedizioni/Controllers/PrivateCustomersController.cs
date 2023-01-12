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
        public ActionResult GetPrivateCustomers()
        {
            List<PrivateCustomer> PrivateCustomersList = new List<PrivateCustomer>();
            try
            {
                PrivateCustomersList = PrivateCustomer.GetPrivates();
            }
            catch(Exception ex)
            {
                ViewBag.ErrorMsg = ex.Message;
                return View();
            }

            return View(PrivateCustomersList);
        }

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

            return RedirectToAction("GetPrivateCustomers");
        }
    }
}