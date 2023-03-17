using BillingApp.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingApp.DAL
{
    internal class deaCustDAL
    {
        //Create connection to DataBase
        //ConfigurationManager is the class which helps to read data from configurations.
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        #region Select Method for Dealer and Customer
        public DataTable Select()
        {
            DataTable dt = new DataTable();
            // SqlConnection conn = new SqlConnection(myconnstrng);
            MySqlConnection conn = new MySqlConnection(myconnstrng);
            try
            {
                string sql = "SELECT * FROM tbl_dea_cust";
                //SqlCommand cmd = new SqlCommand(sql, conn);
                MySqlCommand cmd  = new MySqlCommand(sql, conn);
                //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);   

            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
           finally {
                conn.Close();
            }

            return dt;
        }
        #endregion
        #region Insert Dealer and Customer Data
        public bool Insert(deaCustBLL dc)
        {
            // SqlConnection conn = new SqlConnection(myconnstrng);
            MySqlConnection conn = new MySqlConnection(myconnstrng);
            bool isSuccessful = false;
            try
            {
                string sql = "INSERT INTO tbl_dea_cust (type, name, email, contact, address,added_date, added_by) VALUES (@type, @name, @email, @contact, @address, @added_date, @added_by)";
                
                //SqlCommand cmd = new SqlCommand(sql, conn);
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                

                cmd.Parameters.AddWithValue("@type", dc.type);
                cmd.Parameters.AddWithValue("@name", dc.name);
                cmd.Parameters.AddWithValue("@email", dc.email);
                cmd.Parameters.AddWithValue("@contact", dc.contact);
                cmd.Parameters.AddWithValue("@address", dc.address);
                cmd.Parameters.AddWithValue("@added_date", dc.added_date);
                cmd.Parameters.AddWithValue("@added_by", dc.added_by);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if(rows > 0)
                {
                    isSuccessful = true;
                }
                else
                {
                    isSuccessful= false;    
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSuccessful;
        }
        #endregion
        #region Update Dealer and Customer Method
        public bool Update(deaCustBLL dc)
        {
            //SqlConnection conn = new SqlConnection(myconnstrng);
            MySqlConnection conn = new MySqlConnection(myconnstrng);
            bool isSuccessful = false;
            try
            {
                string sql = "UPDATE tbl_dea_cust SET type=@type, name=@name, email=@email, contact=@contact, address=@address, added_date=@added_date, added_by=added_by WHERE id=@id";

                // SqlCommand cmd = new SqlCommand(sql, conn); 
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                
                cmd.Parameters.AddWithValue("@type", dc.type);
                cmd.Parameters.AddWithValue("@name", dc.name);
                cmd.Parameters.AddWithValue("@email", dc.email);
                cmd.Parameters.AddWithValue("@contact", dc.contact);
                cmd.Parameters.AddWithValue("@address", dc.address);
                cmd.Parameters.AddWithValue("@added_date", dc.added_date);
                cmd.Parameters.AddWithValue("@added_by", dc.added_by);
                cmd.Parameters.AddWithValue("@id", dc.id);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccessful = true;
                }
                else
                {
                    isSuccessful= false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);    
            }
            finally
            {
                conn.Close();
            }
            return isSuccessful;
        }
        #endregion
        #region Delete method for dealer and customer 
        public bool Delete(deaCustBLL dc)
        {
            // SqlConnection conn = new SqlConnection(myconnstrng);
            MySqlConnection conn = new MySqlConnection(myconnstrng);
            bool isSuccessful = false;
            try
            {
                string sql = "DELETE FROM tbl_dea_cust WHERE id=@id";
                //SqlCommand cmd = new SqlCommand(sql, conn);
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", dc.id);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();   

                if(rows > 0)
                {
                    isSuccessful= true;
                }
                else{
                    isSuccessful= false;
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();   
            }
            return isSuccessful;
        }
        #endregion
        #region Search Method for dealer and Customer DEALER CUSTORMER MODULE
        public DataTable Search(string keywords)
        {
            //SqlConnection conn = new SqlConnection(myconnstrng);
            MySqlConnection conn = new MySqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT *FROM tbl_dea_cust WHERE id LIKE '%"+keywords+"%' OR type LIKE '%"+keywords+"%' OR name LIKE '%"+keywords+"%'";
               // SqlCommand cmd = new SqlCommand(sql, conn);
               MySqlCommand cmd = new MySqlCommand(sql, conn);
                //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);


            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        #endregion for 
        #region METHOD TO SEARCH DEALER OF CUSTOMER FOR TRANSACTION MODULE
        public deaCustBLL SearchDealerCustomerForTransaction(string keyword)
        {
           deaCustBLL dc = new deaCustBLL();
            // SqlConnection conn = new SqlConnection(myconnstrng);
            MySqlConnection conn = new MySqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT name, email, contact, address FROM tbl_dea_cust WHERE id LIKE '%"+keyword+"%' OR name LIKE '%"+keyword+"%' OR email LIKE '%"+keyword+"%'";
                // SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
                conn.Open();
                adapter.Fill(dt);   
                if(dt.Rows.Count> 0)
                {
                    dc.name = dt.Rows[0]["name"].ToString();
                    dc.email = dt.Rows[0]["email"].ToString();
                    dc.contact = dt.Rows[0]["contact"].ToString();
                    dc.address = dt.Rows[0]["address"].ToString();
                }


            }catch(Exception ex) 
            { 
                MessageBox.Show(ex.Message);    
            }
            finally
            {
                conn.Close();   
            }
            return dc;
        }
        #endregion
        #region Method to Get ID of the dealer of Customer based on the name
        public deaCustBLL GetDeaCustIDFromName(string name)
        {

            deaCustBLL dc = new deaCustBLL();
            DataTable dt = new DataTable();
            //SqlConnection conn = new SqlConnection(myconnstrng);
            MySqlConnection conn = new MySqlConnection(myconnstrng);
            

            try
            {
                string sql = "SELECT id FROM tbl_dea_cust WHERE name='"+name+"'";
                //SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
                conn.Open();
                adapter.Fill(dt);
                if(dt.Rows.Count > 0)
                {
                    dc.id = int.Parse(dt.Rows[0]["id"].ToString());
                }
            }catch(Exception ex)
            {

            }
            finally
            {
                conn.Close(); 
            }
            return dc;

        }
        #endregion
    }
}
