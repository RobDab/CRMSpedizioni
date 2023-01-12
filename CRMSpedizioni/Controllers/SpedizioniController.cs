using CRMSpedizioni.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRMSpedizioni.Controllers
{
    public class SpedizioniController : Controller
    {
        // GET: Spedizioni
        public ActionResult GetSpedizioni()
        {

            return View();
        }

        public ActionResult CreateSpedizione(int id)
        {
            

            return View(); 
        }

        [HttpPost]
        public ActionResult CreateSpedizione(Spedizione current, int id)
        {
            current.CustomerID = id;
            try
            {
                Spedizione.AddSpedizione(current);
            }
            catch(Exception ex) 
            {
                ViewBag.ErrorMsg = ex.Message;
                return View();
            }
            return RedirectToAction("GetPrivateCustomers","PrivateCustomer");
        }
    }


}