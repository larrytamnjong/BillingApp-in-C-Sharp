
using BillingApp.DataAccess;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingApp.UI
{
    public partial class frmInventory : Form
    {
        public frmInventory()
        {
            InitializeComponent();
        }
        categoriesDAL categoriesDAL= new categoriesDAL();
        productsDAL pdal = new productsDAL();
        private void picClose_Click(object sender, EventArgs e)
        {
            this.Hide();                    
        }

        private void frmInventory_Load(object sender, EventArgs e)
        {

            //set values to combo box
            DataTable cDt = categoriesDAL.Select();

            cmb_Category.DataSource = cDt;

            cmb_Category.DisplayMember = "title";
            cmb_Category.ValueMember = "title";

            //Display all products
            DataTable pdt = pdal.Select();
            dgv_Products.DataSource = pdt;  
        }

        private void cmb_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            string category = cmb_Category.Text;
            DataTable pdt = pdal.DisplayProductsByCategory(category);   

            dgv_Products.DataSource = pdt;  
        }

        private void btn_ShowAll_Click(object sender, EventArgs e)
        {
            DataTable pdt = pdal.Select();
            dgv_Products.DataSource = pdt;
        }
    }
}
