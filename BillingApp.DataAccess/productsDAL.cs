
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
using BillingApp.DataModel;

namespace BillingApp.DataAcces
{
    public class productsDAL
    {
        //Connection string
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        #region Select method for Product Module
        public DataTable Select()
        {
            //Create DataTable
            DataTable dt = new DataTable();
            //Create connection
            //SqlConnection conn = new SqlConnection(myconnstrng);
            MySqlConnection conn = new MySqlConnection(myconnstrng); 
            try
            {
                //Create query String
                string sql = "SELECT * FROM tbl_products";

                //Create Sql Command
                //SqlCommand cmd = new SqlCommand(sql, conn);
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                //Create adapter to manage data
                // SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                //Open Connection
                conn.Open();
                //Pass date to table
                adapter.Fill(dt);

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally {
                conn.Close();
            }
            return dt;
        }

        #endregion
        #region Method to Insert Product in Database
        public bool Insert(productsBLL p)
        {
            bool isSuccessful = false;
            //SqlConnection conn = new SqlConnection(myconnstrng);
            MySqlConnection conn = new MySqlConnection(myconnstrng);

            try
            {
                string sql = "INSERT INTO tbl_products (name, category, description, rate, qty, added_date, added_by) VALUES (@name, @category, @description, @rate, @qty, @added_date, @added_by)";
                //SqlCommand cmd = new SqlCommand(sql, conn);
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@name", p.name);
                cmd.Parameters.AddWithValue("@category", p.category);
                cmd.Parameters.AddWithValue("@description", p.description);
                cmd.Parameters.AddWithValue("@rate", p.rate);
                cmd.Parameters.AddWithValue("qty", p.qty);
                cmd.Parameters.AddWithValue("added_date", p.added_date);
                cmd.Parameters.AddWithValue("@added_by", p.added_by);

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
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally {
                conn.Close();
            }
            return isSuccessful;
        }
        #endregion
        #region Update Product Data
        public bool Update(productsBLL p)
        {
            bool isSuccessful = false;
          //  SqlConnection conn = new SqlConnection(myconnstrng);
              MySqlConnection conn = new MySqlConnection(myconnstrng);

            try
            {
                string sql = "UPDATE tbl_products SET name=@name, category=@category, description=@description, rate=@rate, added_date=@added_date, added_by=@added_by WHERE id=@id ";
                //SqlCommand cmd = new SqlCommand(sql, conn);
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@name", p.name);
                cmd.Parameters.AddWithValue("@category", p.category);
                cmd.Parameters.AddWithValue("@description", p.description);
                cmd.Parameters.AddWithValue("@rate", p.rate);
                cmd.Parameters.AddWithValue("@qty", p.qty);
                cmd.Parameters.AddWithValue("@added_date", p.added_date);
                cmd.Parameters.AddWithValue("@added_by", p.added_by);
                cmd.Parameters.AddWithValue("@id", p.id);

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

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally {
                conn.Close();
            }
            return isSuccessful;
        }
        #endregion
        #region Delete Product from database
        public bool Delete(productsBLL p)
        {
            bool isSuccessful = false;
            //  SqlConnection conn = new SqlConnection(myconnstrng);
            MySqlConnection conn = new MySqlConnection(myconnstrng);
            try
            {
                string sql = "DELETE FROM tbl_products WHERE id=@id";

                //SqlCommand cmd = new SqlCommand(sql, conn);
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", p.id);

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

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally {
                conn.Close();
            }
            return isSuccessful;
        }
        #endregion
        #region Search Method for Product Module
        public DataTable Search(string keywords)
        {
            DataTable dt = new DataTable();
            //SqlConnection conn = new SqlConnection(myconnstrng);
            MySqlConnection conn = new MySqlConnection(myconnstrng);
            try
            {
                string sql = "SELECT * FROM tbl_products WHERE id LIKE '%" + keywords + "%' OR name LIKE '%" + keywords + "%' OR category LIKE '%" + keywords + "%' ";
                //SqlCommand cmd = new SqlCommand(sql, conn);
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally {
                conn.Close();
            }
            return dt;
        }
        #endregion
        #region METHOD TO SEARCH PRODUCT IN TRANSACTION MODULE
        public productsBLL GetProductsForTransaction(string keyword)
        {
            productsBLL p = new productsBLL();
            // SqlConnection conn = new SqlConnection(myconnstrng);
            MySqlConnection conn = new MySqlConnection(myconnstrng);
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT name, qty, rate FROM tbl_products WHERE id LIKE '%" + keyword + "%' OR name LIKE '%" + keyword + "%' ";
                //SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
                conn.Open();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    p.name = dt.Rows[0]["name"].ToString();
                    p.rate = decimal.Parse(dt.Rows[0]["rate"].ToString());
                    p.qty = decimal.Parse(dt.Rows[0]["qty"].ToString());
                }

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return p;
        }
        #endregion
        #region Method to get product ID based on product Name
        public productsBLL GetProductIDFromName(string productName)
        {

            productsBLL p = new productsBLL();
            DataTable dt = new DataTable();
            // SqlConnection conn = new SqlConnection(myconnstrng);
            MySqlConnection conn = new MySqlConnection(myconnstrng);

            try
            {
                string sql = "SELECT id FROM tbl_products WHERE name='" + productName + "'";

                //SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
                conn.Open();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    p.id = int.Parse(dt.Rows[0]["id"].ToString());
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return p;

        }
        #endregion
        #region Method to get current quantity from the Database based on the product ID
        public decimal GetProductQty(int ProductID)
        {
            //SqlConnection conn = new SqlConnection(myconnstrng);
            MySqlConnection conn = new MySqlConnection(myconnstrng);
            decimal qty = 0;
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT qty FROM tbl_products WHERE id = '"+ProductID+"' ";
                //SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
                conn.Open();
                adapter.Fill(dt);

                if(dt.Rows.Count > 0)
                {
                    qty = decimal.Parse(dt.Rows[0]["qty"].ToString());
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return qty;
        }
        #endregion
        #region Method to update quantity
        public bool updateQuantity(int ProductID, decimal Qty)
        {
            // SqlConnection conn = new SqlConnection(myconnstrng);
            MySqlConnection conn = new MySqlConnection(myconnstrng);
            bool isSuccessful = false;
            try
            {
                string sql = "UPDATE tbl_products SET qty=@qty WHERE id=@id";
                //SqlCommand cmd = new SqlCommand(sql, conn);
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@qty", Qty);
                cmd.Parameters.AddWithValue("@id", ProductID);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if(rows > 0)
                {
                    isSuccessful= true; 
                }
                else
                {
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
        #region Method to icrease product
        public bool IncreaseProduct(int ProductID, decimal IncreaseQty)
        {
            bool isSuccessful = false;
            // SqlConnection conn = new SqlConnection(myconnstrng);
            MySqlConnection conn = new MySqlConnection(myconnstrng);
            try
            {
                //Get the Current Quantity From DataBase based on ID

                decimal currentQty = GetProductQty(ProductID);
                //Increase the current Quantity by the qty Purchased from the  dealer

                decimal NewQty = currentQty + IncreaseQty;
                isSuccessful = updateQuantity(ProductID, NewQty);

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
        #region Method to decrease the product quantity
        public bool DecreaseProduct(int ProductID, decimal Qty)
        {
            bool isSuccessful = false;
            //SqlConnection conn = new SqlConnection();
            MySqlConnection conn = new MySqlConnection(myconnstrng);
            try
            {
                decimal currentQty = GetProductQty(ProductID);

                decimal NewQty = currentQty - Qty;
                isSuccessful= updateQuantity(ProductID, NewQty);    
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
        #region Display products based on category
        public DataTable DisplayProductsByCategory(string category)
        {
            // SqlConnection conn = new SqlConnection(myconnstrng);
            MySqlConnection conn = new MySqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM tbl_products WHERE category='" + category + "'";
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

    }
}