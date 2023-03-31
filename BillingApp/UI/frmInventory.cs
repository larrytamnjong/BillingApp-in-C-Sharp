
using DataAccessLayer.Model;
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
        BusinessLogicLayer businessLogicLayer = new BusinessLogicLayer();
        InventoryManagerContext inventoryManagerContext = new InventoryManagerContext();
      

       
        private void picClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmInventory_Load(object sender, EventArgs e)
        {

            //set values to combo box
       
           this.tblCategoryBindingSource.DataSource = businessLogicLayer.Select<TblCategory>(inventoryManagerContext.TblCategories);
            cmb_Category.DisplayMember = "Title";
            cmb_Category.ValueMember = "Title";

            //Display all products
            this.tblProductBindingSource.DataSource = businessLogicLayer.Select<TblProduct>(inventoryManagerContext.TblProducts);
        }

        private void cmb_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            string category = cmb_Category.Text;
            this.tblProductBindingSource.DataSource = businessLogicLayer.Search<TblProduct>(inventoryManagerContext.TblProducts, p => p.Category == category);

        }

        private void btn_ShowAll_Click(object sender, EventArgs e)
        {
            //Display all products
            this.tblProductBindingSource.DataSource = businessLogicLayer.Select<TblProduct>(inventoryManagerContext.TblProducts);
        }
    }
}
