using BillingApp.BLL;
using BillingApp.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingApp.UI
{
    public partial class frmProducts : Form
    {
        public frmProducts()
        {
            InitializeComponent();
        }

        //Create objects for DAL and BLL
        productsDAL pdal = new productsDAL(); 
        productsBLL p = new productsBLL();

        //create user DAL object to be able to get user id
        userDAL udal = new userDAL();
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
          

        //Function to Load categories in Form Products load event is created from form load events
        //Create new categoriesDAL object
        categoriesDAL cdal = new categoriesDAL();
        private void frmProducts_Load(object sender, EventArgs e)
        {
            //Creating Data Table to hold the categories from Database
            DataTable categoriesDT = cdal.Select();
            //Specify DataSource for Category ComboBox
            cmb_Category.DataSource = categoriesDT;
            cmb_Category.DisplayMember= "title";
            cmb_Category.ValueMember= "title";

            Console.WriteLine(cmb_Category.SelectedIndex);


            //Load data table
            DataTable dt = pdal.Select();
            dgv_products.DataSource = dt;


        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            p.name = txt_Name.Text;
            p.category = cmb_Category.Text;
            p.description = txt_Description.Text;
            p.rate = decimal.Parse(txt_Rate.Text);
            p.qty = 0;
            p.added_date = DateTime.Now;
            //Getting username
            String loggedUser = frmLogin.loggedIn;
            userBLL usr = udal.GetUserIDByUsername(loggedUser);
            p.added_by = usr.id;

            bool success = pdal.Insert(p);
            if(success == true)
            {
                MessageBox.Show("Product Was Inserted Successfully");
                Clear();
                //Refresh DataTable
                DataTable  dt = pdal.Select();  
                dgv_products.DataSource = dt;   
            }
            else
            {
                MessageBox.Show("Failed to Add New Product");
            }

           

        }

        public void Clear()
        {
            txt_Description.Text = "";
            txt_Name.Text = "";
            txt_ProductID.Text = "";
            txt_Rate.Text = "";
           

        }

        private void dgv_products_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Integer variable to know which product was clicked
            int rowIndex = e.RowIndex;

            //Display the Value on Respective TextB0xes
            txt_ProductID.Text = dgv_products.Rows[rowIndex].Cells[0].Value.ToString();
            txt_Name.Text = dgv_products.Rows[rowIndex].Cells[1].Value.ToString();
            cmb_Category.Text = dgv_products.Rows[rowIndex].Cells[2].Value.ToString();
            txt_Description.Text = dgv_products.Rows[rowIndex].Cells[3].Value.ToString();
            txt_Rate.Text = dgv_products.Rows[rowIndex].Cells[4].Value.ToString();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            p.id = int.Parse(txt_ProductID.Text);   
            p.name = txt_Name.Text;
            p.description = txt_Description.Text;
            p.category = cmb_Category.Text;
            p.rate = decimal.Parse(txt_Rate.Text);
            p.added_date= DateTime.Now;
            //Getting username
            String loggedUser = frmLogin.loggedIn;
            userBLL usr = udal.GetUserIDByUsername(loggedUser);
            p.added_by = usr.id;

            bool successful = pdal.Update(p);
            if(successful == true)
            {
                MessageBox.Show("Product updated successfully");
                Clear();
                //Refresh DataTable
                DataTable dt = pdal.Select();
                dgv_products.DataSource = dt;

            }
            else
            {
                MessageBox.Show("Product not updated");
            }

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            //Get id of product of to be deleted

            p.id = int.Parse(txt_ProductID.Text);

            bool succesful = pdal.Delete(p);
            if(succesful == true)
            {
                MessageBox.Show("Product has been successfully deleted");
                Clear();
                //Refresh DataTable
                DataTable dt = pdal.Select();
                dgv_products.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Product was not Deleted");
            }
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            //Get search keywords
            string keywords = txt_Search.Text;

            if(keywords != null)
            {
                DataTable dt = pdal.Search(keywords);
                dgv_products.DataSource = dt;
            }
            else
            {
                DataTable dt = pdal.Select();
                dgv_products.DataSource = dt;
            }
        }

        
    }
}
