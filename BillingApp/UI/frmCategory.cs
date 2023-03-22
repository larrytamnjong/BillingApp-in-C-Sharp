
using BillingApp.DAL;
using BillingApp.DataAcces;
using BillingApp.DataAccess;
using BillingApp.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingApp.UI
{
    public partial class frmCategory : Form
    {
        public frmCategory()
        {
            InitializeComponent();
        }
        //Create objects for CategoryBLL and CategoryDLL
        categoriesBLL c = new categoriesBLL();
        categoriesDAL dal = new categoriesDAL();
        userDAL udal = new userDAL();
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            //Get values from Category Form
            c.title = txt_Title.Text;
            c.description = txt_Description.Text;
            c.added_date = DateTime.Now;

            //Getting ID of Logged in User
            string loggedInUser = frmLogin.loggedIn;
            userBLL usr = udal.GetUserIDByUsername(loggedInUser);

            //Passing the id of Logged in user in the added by field
            c.added_by = usr.id;

            //Creating Boolean method to insert data into database

            bool success = dal.Insert(c);

            //Insert successful will return true else function will return false
            if(success== true)
            {
                MessageBox.Show("Category Successfully Inserted");
                clear();
                DataTable dt = dal.Select();
                dgv_Categories.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Category Failed to Insert");
            }


        }
        public void clear()
        {
            txt_CategoryID.Text = "";
            txt_Description.Text = "";
            txt_Title.Text = "";
            txt_Search.Text = "";
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            //Display category in DataTable
            DataTable dt = dal.Select();
            dgv_Categories.DataSource = dt;
        }

        private void dgv_Categories_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Finding the Row Index of the Row Clicked on Data Grid View
            int RowIndex = e.RowIndex;
            txt_CategoryID.Text = dgv_Categories.Rows[RowIndex].Cells[0].Value.ToString();
            txt_Title.Text = dgv_Categories.Rows[RowIndex].Cells[1].Value.ToString();
            txt_Description.Text = dgv_Categories.Rows[RowIndex].Cells[2].Value.ToString();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            //Get values from category form
            c.id = int.Parse(txt_CategoryID.Text);
            c.title = txt_Title.Text;
            c.description = txt_Description.Text;
            c.added_date = DateTime.Now;

            //Getting ID of Logged in User
            string loggedInUser = frmLogin.loggedIn;
            userBLL usr = udal.GetUserIDByUsername(loggedInUser);

            //Passing the id of Logged in user in the added by field
            c.added_by = usr.id;

            bool successful = dal.Update(c);
            if (successful == true)
            {
                MessageBox.Show("Category successfully upgraded");
                clear();
                //Display category in DataTable
                DataTable dt = dal.Select();
                dgv_Categories.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed to update");
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            //Get the ID of the Category we want to delete

            c.id = int.Parse(txt_CategoryID.Text);

            bool successful = dal.Delete(c);
            if (successful == true)
            {
                MessageBox.Show("Deleted");
                clear();
                //Display category in DataTable
                DataTable dt = dal.Select();
                dgv_Categories.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed to delete");
            }
        }

        //Properties thunder symbol and textchange event
        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            //Get the keywords
            string keywords = txt_Search.Text;
            //Filter the categories based on the keywords

            if(keywords != null)
            {
                DataTable dt = dal.Search(keywords);
                dgv_Categories.DataSource = dt;
            }
            else
            {
              
                DataTable dt = dal.Select();
                dgv_Categories.DataSource = dt;
            }
        }
    }
}
