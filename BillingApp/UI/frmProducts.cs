

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer.Model;

namespace BillingApp.UI
{
    public partial class frmProducts : Form
    {
        public frmProducts()
        {
            InitializeComponent();
        }


        BusinessLogicLayer businessLogicLayer = new BusinessLogicLayer();
        InventoryManagerContext inventoryManagerContext = new InventoryManagerContext();
        TblProduct product = new TblProduct();


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {

            cmb_Category.DataSource = businessLogicLayer.Select<TblCategory>(inventoryManagerContext.TblCategories);
            cmb_Category.DisplayMember = "Title";
            cmb_Category.ValueMember = "Title";

            //Console.WriteLine(cmb_Category.SelectedIndex);

            updateTable();


        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            product.Name = txt_Name.Text;
            product.Category = cmb_Category.Text;
            product.Description = txt_Description.Text;
            product.Rate = decimal.Parse(txt_Rate.Text);
            product.Qty = (decimal?)0.0;
            product.AddedDate = DateTime.Now;
            product.AddedBy = businessLogicLayer.GetUserID(frmLogin.loggedIn);

            bool success = businessLogicLayer.Insert<TblProduct>(product);
            if (success == true)
            {
                MessageBox.Show("Product Was Inserted Successfully");
                Clear();
                //Refresh DataTable
                updateTable();
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
        public void updateTable()
        {
            this.tblProductBindingSource1.DataSource = businessLogicLayer.Select<TblProduct>(inventoryManagerContext.TblProducts);
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
            product.Id = int.Parse(txt_ProductID.Text);
            product.Name = txt_Name.Text;
            product.Description = txt_Description.Text;
            product.Category = cmb_Category.Text;
            product.Rate = decimal.Parse(txt_Rate.Text);
            product.AddedDate = DateTime.Now;
            //Getting username


            product.AddedBy = businessLogicLayer.GetUserID(frmLogin.loggedIn);

            bool successful = businessLogicLayer.Update<TblProduct>(product);
            if (successful == true)
            {
                MessageBox.Show("Product updated successfully");
                Clear();
                //Refresh DataTable
                updateTable();

            }
            else
            {
                MessageBox.Show("Product not updated");
            }

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            //Get id of product of to be deleted

            product.Id = int.Parse(txt_ProductID.Text);

            bool succesful = businessLogicLayer.Delete<TblProduct>(product);
            if (succesful == true)
            {
                MessageBox.Show("Product has been successfully deleted");
                Clear();
                //Refresh DataTable
                updateTable();
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

            if (keywords != null)
            {
                this.tblProductBindingSource1.DataSource = businessLogicLayer.Search<TblProduct>(inventoryManagerContext.TblProducts, p => p.Name == keywords.ToString());
            }
            else
            {
                updateTable();
            }
        }

        private void cmb_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(cmb_Category.SelectedIndex.ToString());
            //updateTable();
        }
    }
}
