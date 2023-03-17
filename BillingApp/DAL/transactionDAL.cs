using BillingApp.BLL;
using MySql.Data.MySqlClient;
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
    internal class transactionDAL
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        #region Insert Transaction Method
        public bool Insert_Transaction(transactionsBLL t, out int transactionID)
        {
            bool isSuccessful = false;
            //Set the out the transactionID value to negative -1
            transactionID = -1;
            //SqlConnection conn = new SqlConnection(myconnstrng);
            MySqlConnection conn = new MySqlConnection(myconnstrng);

            try
            {
                string sql = "INSERT INTO tbl_transactions (type, dea_cust_id, grandTotal, transaction_date, tax, discount, added_by) VALUES (@type, @dea_cust_id, @grandTotal, @transaction_date, @tax, @discount, @added_by); SELECT @@IDENTITY";
                // SqlCommand cmd = new SqlCommand(sql, conn);
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@type", t.type);
                cmd.Parameters.AddWithValue("@dea_cust_id", t.dea_cust_id);
                cmd.Parameters.AddWithValue("@grandTotal", t.grandTotal);
                cmd.Parameters.AddWithValue("@transaction_date", t.transaction_date);
                cmd.Parameters.AddWithValue("@tax", t.tax);
                cmd.Parameters.AddWithValue("@discount", t.discount);
                cmd.Parameters.AddWithValue("@added_by", t.added_by);

                conn.Open();
                //ExecuteScalar() only returns the value from the first column of the first row of your query.
                //ExecuteNonQuery() does not return data at all: only the number of rows affected by an

                object o = cmd.ExecuteScalar();
                
                //If successful the value will not be null else it will be null
                if(o != null) 
                { 
                    isSuccessful = true;    
                    transactionID = int.Parse(o.ToString());
                }
                else
                {
                    isSuccessful= false;    
                }
               


            }
            catch (Exception ex)
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
        #region Method to display all transactions 
        public DataTable DisplayAllTransactions()
        {
            //SqlConnection conn = new SqlConnection(myconnstrng);
            MySqlConnection conn = new MySqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM tbl_transactions";

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
        #endregion
        #region Method to display transaction base on transaction type
        public DataTable DisplayTransactionByType(string type)
        {
            // SqlConnection conn = new SqlConnection(myconnstrng);
            MySqlConnection conn = new MySqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM tbl_transactions WHERE type='"+type+"'";

                //SqlCommand cmd = new SqlCommand(sql, conn);
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
        #endregion

    }
}
