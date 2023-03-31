
using System;
using System.Configuration;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using BillingApp.DataModel;
//Data Access Layer
namespace BillingApp.DataAccess
{
    public class userDAL
    {
        //ConfigurationManager is the class which helps to read data from configurations.

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        #region select Data from Database
        public DataTable Select() {

            //Create connection to database
            //SqlConnection conn = new SqlConnection(myconnstrng);
            MySqlConnection conn = new MySqlConnection(myconnstrng);

            //create DataTable object to hold data from database(DataTable is a central object. It represents the database tables that provide a collection of rows and columns in grid form.)
            DataTable dt = new DataTable();
            try
            {
                //Create Sql query string to get data from database
                String sql = "SELECT * FROM tbl_users";

                //Create Sql command (A SqlCommand object allows you to query and send commands to a database.)
                //SqlCommand cmd = new SqlCommand(sql, conn);
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                //Created Sql adapter (The Adapter design pattern converts the interface of a class into another interface clients expect.)
                //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                //Open connection
                conn.Open();    

                //Fill data from adapter to data table
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                //show message if error
                MessageBox.Show(ex.Message);
            }
            finally
            {
               
                conn.Close();
            }

            //return Datable
            return dt;

        }


        #endregion
        #region Insert Data into Database



        public bool Insert(userBLL u)
        {
            bool isSuccesful = false;
            // SqlConnection conn = new SqlConnection(myconnstrng);
            MySqlConnection conn = new MySqlConnection(myconnstrng);
            try
            {
                String sql = "INSERT INTO tbl_users (first_name,last_name,email,username,password,contact,address,gender,user_type,added_date,added_by) VALUES (@first_name,@last_name,@email,@username,@password,@contact,@address,@gender,@user_type,@added_date,@added_by)";

                // SqlCommand cmd = new SqlCommand(sql, conn);
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                //Use AddWithValue whenever you want to add a parameter by specifying its name and value.
                cmd.Parameters.AddWithValue("@first_name", u.first_name);
                cmd.Parameters.AddWithValue("@last_name", u.last_name);
                cmd.Parameters.AddWithValue("@email", u.email);
                cmd.Parameters.AddWithValue("@username", u.username);
                cmd.Parameters.AddWithValue("@password", u.password);
                cmd.Parameters.AddWithValue("@contact", u.contact);
                cmd.Parameters.AddWithValue("@address", u.address);
                cmd.Parameters.AddWithValue("@gender", u.gender);
                cmd.Parameters.AddWithValue("@user_type", u.user_type);
                cmd.Parameters.AddWithValue("@added_date", u.added_date);
                cmd.Parameters.AddWithValue("@added_by", u.added_by);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                //If the query is executed Succesfully the the value of rows will be greater than 0 else it will be less than 0
           if(rows > 0 ) 
                { 
                isSuccesful = true;
                }
                else
                {
                    isSuccesful = false;
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
            return isSuccesful;
        }
        #endregion
        #region Update Data in Database
        public bool Update(userBLL u)
        {
          bool  isSuccesful = false;
            // SqlConnection conn = new SqlConnection(myconnstrng);
            MySqlConnection conn = new MySqlConnection(myconnstrng);

            try
            {
                string sql = "UPDATE tbl_users SET first_name=@first_name, last_name=@last_name, email=@email, username=@username, password=@password, contact=@contact, address=@address, gender=@gender, user_type=@user_type, added_date=@added_date, added_by=@added_by WHERE id=@id";
                //  SqlCommand cmd = new SqlCommand(sql, conn);
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@first_name", u.first_name);
                cmd.Parameters.AddWithValue("@last_name", u.last_name);
                cmd.Parameters.AddWithValue("@email", u.email);
                cmd.Parameters.AddWithValue("@username", u.username);
                cmd.Parameters.AddWithValue("@password", u.password);
                cmd.Parameters.AddWithValue("@contact", u.contact);
                cmd.Parameters.AddWithValue("@address", u.address);
                cmd.Parameters.AddWithValue("@gender", u.gender);
                cmd.Parameters.AddWithValue("@user_type", u.user_type);
                cmd.Parameters.AddWithValue("@added_date", u.added_date);
                cmd.Parameters.AddWithValue("@added_by", u.added_by);
                cmd.Parameters.AddWithValue("@id", u.id);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccesful = true; 
                }
                else
                {
                    isSuccesful= false;
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
            return isSuccesful;
        }

        #endregion
        #region Delete Data in Database
        public bool Delete(userBLL u)
        {
            bool isSuccesful = false;
            // SqlConnection conn = new SqlConnection(myconnstrng);
            MySqlConnection conn = new MySqlConnection(myconnstrng);
            try
            {
                string sql = "DELETE FROM tbl_users WHERE id=@id";
                //SqlCommand cmd = new SqlCommand(sql, conn);
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", u.id);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if(rows > 0)
                {
                    isSuccesful = true;

                }
                else
                {
                    isSuccesful= false;
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
            return isSuccesful;
        }
        #endregion
        #region Search Data from Database using keyword
        public DataTable Search(string keyword)
        {

            //Create connection to database
            // SqlConnection conn = new SqlConnection(myconnstrng);
            MySqlConnection conn = new MySqlConnection(myconnstrng);

            //create DataTable object to hold data from database(DataTable is a central object. It represents the database tables that provide a collection of rows and columns in grid form.)
            DataTable dt = new DataTable();
            try
            {
                //Create Sql query string to get data from database
                String sql = "SELECT * FROM tbl_users WHERE id LIKE '%"+keyword+"%' OR first_name LIKE '%"+keyword+"%' OR username LIKE '%"+keyword+"%' OR last_name LIKE '%"+keyword+"%'";

                //Create Sql command (A SqlCommand object allows you to query and send commands to a database.)
                //SqlCommand cmd = new SqlCommand(sql, conn);
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                //Created Sql adapter (The Adapter design pattern converts the interface of a class into another interface clients expect.)
                //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                //Open connection
                conn.Open();

                //Fill data from adapter to data table
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                //show message if error
                MessageBox.Show(ex.Message);
            }
            finally
            {


                conn.Close();
            }

            //return Datable
            return dt;

        }
        #endregion
        #region Getting user Id from Database based on username
        public userBLL GetUserIDByUsername(string username)
        {
            userBLL u = new userBLL();

            //SqlConnection conn = new SqlConnection(myconnstrng);
            MySqlConnection conn = new MySqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT id FROM tbl_users WHERE username = '" + username + "'";
                //SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn); 
                conn.Open();
                adapter.Fill(dt);

                if(dt.Rows.Count > 0)
                {
                    u.id = int.Parse(dt.Rows[0]["id"].ToString());

                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return u;
        }
        #endregion
    }
}
