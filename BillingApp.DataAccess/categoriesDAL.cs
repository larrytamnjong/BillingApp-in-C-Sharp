using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using BillingApp.DataModel;

namespace BillingApp.DataAccess
{
    public class categoriesDAL
    {
        //Static string method for Database connection
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        #region Select Method 
        public DataTable Select()
        {
            // SqlConnection conn = new SqlConnection(myconnstrng);    
            MySqlConnection conn = new MySqlConnection(myconnstrng);
            DataTable dt = new DataTable();

            try
            {
                //Sql query string 
                string sql = "SELECT * FROM tbl_categories";

                //Write Sql Command
                //SqlCommand cmd = new SqlCommand(sql, conn);
                MySqlCommand cmd = new MySqlCommand(sql, conn);


                //Create instance of Adapter
                //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                conn.Open();

                adapter.Fill(dt);

            }
            catch (Exception ex)
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
        #region Insert new Category
        public bool Insert(categoriesBLL c)
        {
            //Create a boolean variable and set its default to false
            bool isSuccessful = false;
            //Connect to Database
            //SqlConnection conn = new SqlConnection(myconnstrng);
            MySqlConnection conn = new MySqlConnection(myconnstrng);
            try
            {
                //Query to add new category
                string sql = "INSERT INTO tbl_categories (title, description,added_date, added_by) VALUES (@title, @description, @added_date, @added_by)";
                //Create sql command
                // SqlCommand cmd = new SqlCommand(sql, conn);
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@title", c.title);
                cmd.Parameters.AddWithValue("@description", c.description);
                cmd.Parameters.AddWithValue("@added_date", c.added_date);
                cmd.Parameters.AddWithValue("@added_by", c.added_by);
                conn.Open();

                //Creating int variable to execute query
                int rows = cmd.ExecuteNonQuery();

                //If the query is executed successfully rows will be > 0

                if (rows > 0)
                {
                    isSuccessful = true;
                }
                else
                {
                    isSuccessful = false;
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
        #region Update Category
        public bool Update(categoriesBLL c)
        {
            bool isSuccessful = false;
            // SqlConnection conn = new SqlConnection(myconnstrng);
            MySqlConnection conn = new MySqlConnection(myconnstrng);
            try
            {

                string sql = "UPDATE tbl_categories SET title=@title, description=@description, added_date=@added_date, added_by=@added_by WHERE id=@id";
                // SqlCommand cmd = new SqlCommand(sql, conn);
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@title", c.title);
                cmd.Parameters.AddWithValue("@description", c.description);
                cmd.Parameters.AddWithValue("@added_date", c.added_date);
                cmd.Parameters.AddWithValue("@added_by", c.added_by);
                cmd.Parameters.AddWithValue("@id", c.id);

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
        #region Delete Category
        public bool Delete(categoriesBLL c)
        {
            bool isSuccessful = false;
            //SqlConnection conn = new SqlConnection(myconnstrng);
            MySqlConnection conn = new MySqlConnection(myconnstrng);
            try
            {
                string sql = "DELETE FROM tbl_categories WHERE id=@id";

                //SqlCommand cmd = new SqlCommand(sql, conn);
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id", c.id);
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
        #region Method for Search Functionality
        public DataTable Search(string keywords)
        {
            //SqlConnection conn = new SqlConnection(myconnstrng);
            MySqlConnection conn = new MySqlConnection(myconnstrng);
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM tbl_categories WHERE id LIKE '%" + keywords + "%' OR title LIKE '%" + keywords + "%' OR description LIKE '%" + keywords + "%'";
                //SqlCommand cmd = new SqlCommand(sql, conn);
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                //Hold data in data adapter
                //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                conn.Open();
                adapter.Fill(dt);

            }
            catch (Exception ex)
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
