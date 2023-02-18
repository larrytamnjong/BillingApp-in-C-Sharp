using BillingApp.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingApp.DAL
{
    internal class loginDAL
    {
        //Static string to connect to database
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        public bool loginCheck(loginBLL l)
        {
            bool isSuccesful = false;
            
            //Connecto to database
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "SELECT * FROM tbl_users WHERE username=@username AND password=@password AND user_type=@user_type";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@username", l.username);
                cmd.Parameters.AddWithValue("@password", l.password);
                cmd.Parameters.AddWithValue("@user_type", l.user_type);
                

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();

                DataTable dt = new DataTable(); 

                adapter.Fill(dt);
                //Check if Login was successful by checking number of rows returned from the database
                if(dt.Rows.Count> 0)
                {
                    //Login successful
                    isSuccesful = true; 
                }
                else
                {
                    //Login Faild
                    isSuccesful = false;    
                }

            }catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSuccesful;
        }
    }
}
