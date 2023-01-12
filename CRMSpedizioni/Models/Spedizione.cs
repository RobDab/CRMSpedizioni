using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CRMSpedizioni.Models
{
    public class Spedizione
    {
        public int IDSpedizione { get; set; }

        public int CustomerID { get; set; }

        public DateTime DataSpedizione { get; set; }

        public double Weight { get; set; }

        public string CittàDestinazione { get; set; }

        public string Destinatario { get; set; }

        public string IndirizzoDestinazione { get; set; }

        public decimal Costo { get; set; }

        public DateTime ConsegnaStimata { get; set; }

        public static void AddSpedizione(Spedizione current)
        {
            SqlConnection con = ConnControl.DBConnection;
            con.Open();

            //L' INSERT DA UN CODICE DI ERRORE DOVUTO AL CONFLITTO CON LA TABELLA CLIENTIB2B colonna CustomerID. 
            // POSSIBILE SOLUZIONE: aggiungere alla tabella spedizioni due colonne per idPrivato e IDAzienda entrambi valori nullable e caricati dinamicamente a seconda dell'anagrafica che fa partire la spedizione.

            SqlCommand cmd = new SqlCommand("INSERT INTO SpedizioniTab VALUES (@CustomerID, @DataSpedizione, @Weight, @CittàDestinazione, @Destinatario, @IndirizzoDest, @Costo, @DataConsegna)", con);
            cmd.Parameters.AddWithValue("CustomerID", current.CustomerID);
            cmd.Parameters.AddWithValue("DataSpedizione", current.DataSpedizione);
            cmd.Parameters.AddWithValue("Weight", current.Weight);
            cmd.Parameters.AddWithValue("CittàDestinazione", current.CittàDestinazione);
            cmd.Parameters.AddWithValue("Destinatario", current.Destinatario);
            cmd.Parameters.AddWithValue("IndirizzoDest", current.IndirizzoDestinazione);
            cmd.Parameters.AddWithValue("Costo", current.Costo);
            cmd.Parameters.AddWithValue("DataConsegna", current.ConsegnaStimata);

            cmd.ExecuteNonQuery();

            con.Close();
        }
    }
}