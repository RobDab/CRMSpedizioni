using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CRMSpedizioni.Models
{
    public class ConnControl
    {

        public static SqlConnection DBConnection
        {
            get
            {
                string ConStringName = ConfigurationManager.ConnectionStrings["DBConnection"].ToString();
                SqlConnection con = new SqlConnection(ConStringName);

                return con;
            }
        }

        public static SqlDataReader GetReader(string CmdTxt, SqlConnection con)
        {
            SqlCommand cmd = new SqlCommand(CmdTxt, con);
            

            SqlDataReader reader = cmd.ExecuteReader();

            return reader;
        }

        
    }
}