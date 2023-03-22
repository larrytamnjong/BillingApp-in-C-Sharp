
using System;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using BillingApp.DataModel;

namespace BillingApp.DataAccess
{
    public class loginDAL
    {
        //Static string to connect to database
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        public bool loginCheck(loginBLL l)
        {
            bool isSuccesful = false;
            
            //Connect to to database
         //SqlConnection conn = new SqlConnection(myconnstrng);
          MySqlConnection conn = new MySqlConnection(myconnstrng);
      
            try
            {
                string sql = "SELECT * FROM tbl_users WHERE username=@username AND password=@password AND user_type=@user_type";
                //SqlCommand cmd = new SqlCommand(sql, conn);
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@username", l.username);
                cmd.Parameters.AddWithValue("@password", l.password);
                cmd.Parameters.AddWithValue("@user_type", l.user_type);


                //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
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
