
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BillingApp.DataAccess;
using BillingApp.DataModel;

namespace BillingApp.UI
{
    public partial class frmTransactions : Form
    {
        public frmTransactions()
        {
            InitializeComponent();
        }

        transactionDAL tDal = new transactionDAL(); 


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmTransactions_Load(object sender, EventArgs e)
        {
            DataTable dt = tDal.DisplayAllTransactions();   
            dgv_transaction.DataSource = dt;
        }

        private void cmb_TransactionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string type = cmb_TransactionType.Text;

            DataTable dt = tDal.DisplayTransactionByType(type);
            dgv_transaction.DataSource = dt;    

        }

        private void btn_ShowAll_Click(object sender, EventArgs e)
        {
            DataTable dt = tDal.DisplayAllTransactions();
            dgv_transaction.DataSource = dt;
        }
    }
}
