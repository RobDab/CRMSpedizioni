using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CRMSpedizioni.Models
{
    public class PrivateCustomer
    {
        public int CustomerID { get; set; }

        public string Nome { get; set; }

        public string Cognome { get; set; }

        [Display(Name = "CAP")]
        public string PostalCode { get; set; }

        [Display(Name = "Cod. Fiscale")]
        public string FiscalCode { get; set; }

        [Display(Name = "Indirizzo")]
        public string Address { get; set; }

        [Display(Name = "Mail o Tel")]
        public string Contact { get; set; }

        public static void AddCustomer(PrivateCustomer current)
        {
            SqlConnection con = ConnControl.DBConnection;
            con.Open();
            
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO ClientiPrivatiTab VALUES (@Nome , @Cognome, @CAP, @CF, @Indirizzo, @Contatto)", con);
                cmd.Parameters.AddWithValue("Nome", current.Nome);
                cmd.Parameters.AddWithValue("Cognome", current.Cognome);
                cmd.Parameters.AddWithValue("CAP", current.PostalCode);
                cmd.Parameters.AddWithValue("CF", current.FiscalCode);
                cmd.Parameters.AddWithValue("Indirizzo", current.Address);
                cmd.Parameters.AddWithValue("Contatto", current.Contact);

                cmd.ExecuteNonQuery();

            }
            catch
            {
                con.Close();
            }
            con.Close();
        }
    }
}