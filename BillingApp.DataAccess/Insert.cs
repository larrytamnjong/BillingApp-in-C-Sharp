using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BillingApp.DataAccess
{
    public class Insert
    {
        MySqlConnection con;
        MySqlCommand cmd;
        string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        public bool IsertV(string sql)
        {
            con = new MySqlConnection(myconnstrng);
            cmd= new MySqlCommand(sql, con);
            con.Open();
            cmd.ExecuteNonQuery();
            return true;
        }


    }
}
