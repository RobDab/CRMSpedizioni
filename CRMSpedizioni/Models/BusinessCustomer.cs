using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRMSpedizioni.Models
{
    public class BusinessCustomer
    {
        public int CustomerID { get; set; }

        [Display(Name = "Ragione Sociale")]
        public string RagSociale { get; set; }

        [Display(Name = "P. Iva")]
        public string PIva { get; set; }

        [Display(Name = "CAP")]
        public string PostalCode { get; set; }

        [Display(Name = "Sede")]
        public string Address { get; set; }

        [Display(Name = "Referente")]
        public string ContactPerson { get; set; }

        public string Mail { get; set; }
    }
}