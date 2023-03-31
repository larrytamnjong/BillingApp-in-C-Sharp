
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
    public partial class frmTransactions : Form
    {
        public frmTransactions()
        {
            InitializeComponent();
        }
        BusinessLogicLayer businessLogicLayer = new BusinessLogicLayer();
        InventoryManagerContext inventoryManagerContext = new InventoryManagerContext();


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmTransactions_Load(object sender, EventArgs e)
        {

            this.tblTransactionBindingSource.DataSource = businessLogicLayer.Select<TblTransaction>(inventoryManagerContext.TblTransactions);
        }

        private void cmb_TransactionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string type = cmb_TransactionType.Text;

            this.tblTransactionBindingSource.DataSource = businessLogicLayer.Search<TblTransaction>(inventoryManagerContext.TblTransactions, t => t.Type == type);

        }

        private void btn_ShowAll_Click(object sender, EventArgs e)
        {
            this.tblTransactionBindingSource.DataSource = businessLogicLayer.Select<TblTransaction>(inventoryManagerContext.TblTransactions);
        }
    }
}
