﻿
using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Windows.Forms;
using BillingApp.DataModel;

namespace BillingApp.DataAccess
{
    public class transactionDetailDAL
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        #region Insert Method for Transaction Detail
        public bool InsertTransactionDetail(transationDetailsBLL td)
        {
            //SqlConnection conn = new SqlConnection(myconnstrng);
            MySqlConnection conn = new MySqlConnection(myconnstrng);
            bool isSuccessful = false;
            try
            {
                string sql = "INSERT INTO tbl_transaction_detail (product_id, rate, qty, total, dea_cust_id, added_date, added_by) VALUES (@product_id, @rate, @qty, @total, @dea_cust_id, @added_date, @added_by)";
                //SqlCommand cmd = new SqlCommand(sql, conn);
               MySqlCommand cmd = new MySqlCommand(sql, conn);  

                cmd.Parameters.AddWithValue("@product_id", td.product_id);
                cmd.Parameters.AddWithValue("@rate", td.rate);
                cmd.Parameters.AddWithValue("@qty", td.qty);
                cmd.Parameters.AddWithValue("@total", td.total);
                cmd.Parameters.AddWithValue("@dea_cust_id", td.dea_cust_id);
                cmd.Parameters.AddWithValue("@added_date", td.added_date);
                cmd.Parameters.AddWithValue("@added_by", td.added_by);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();   
                if (rows > 0)
                {
                    isSuccessful = true;

                }
                else
                {
                    isSuccessful = false;
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


    }
}
